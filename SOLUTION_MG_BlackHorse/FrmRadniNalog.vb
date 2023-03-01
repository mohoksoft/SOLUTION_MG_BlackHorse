Public Class FrmRadniNalog
    Dim rsRadniNalog As DataTable
    Dim rsStavke As DataTable
    Dim Selected As Boolean
    Dim SelektovanaKolona As String
    Dim RetCom As ReturningComplet

    Private Sub FrmRadniNalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lFont As Font

        lFont = New Font("Calibri", 12, FontStyle.Regular, GraphicsUnit.Point)
        grdStavke.ColumnHeadersDefaultCellStyle.Font = lFont
        'GrdTrebovanja.ColumnHeadersDefaultCellStyle.Font = lFont

        lFont = New Font("Verdana", 9.75, FontStyle.Regular, GraphicsUnit.Point)
        grdStavke.RowsDefaultCellStyle.Font = lFont
        'GrdTrebovanja.RowsDefaultCellStyle.Font = lFont

        grdStavke.EnableHeadersVisualStyles = False
        grdStavke.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 80, 130)
        grdStavke.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(241, 246, 248)

        SifarnikUMagacin.KontrolaZaPrikaz = CmbMagacinRN
        SifarnikUMagacin.PuniKontrolu()
        CmbMagacinRN.SelectedValue = 2
        txtSifraMagacinaRN.Text = CmbMagacinRN.SelectedValue

        SifarnikMagacina.KontrolaZaPrikaz = CmbMagacinStavkiRN
        SifarnikMagacina.PuniKontrolu()
        CmbMagacinStavkiRN.SelectedValue = 3

        ArtikliRN.Puni()
        GridZaListuGP()
        ArtikliRN.DajSve()

        ArtikliStavke.Puni()
        GridZaListuStavkiArtikala(GrdListaStavki)
        ArtikliStavke.DajSve()

        grdStavke.DataSource = Nothing

        If Parametri.Novi Then
            Novi()
        Else
            rsRadniNalog = GetData("SELECT * FROM RadniNalog WHERE Broj=" & Parametri.Broj & " AND Godina=" & Godina)

            txtBroj.Text = rsRadniNalog.Rows(0)!Broj
            dtpDatum.Value = rsRadniNalog.Rows(0)!Datum
            CmbMagacinRN.SelectedValue = rsRadniNalog.Rows(0)!Magacin
            txtSifraMagacinaRN.Text = CmbMagacinRN.SelectedValue
            txtSifraProizvoda.Text = rsRadniNalog.Rows(0)!SifraArtikla
            txtNazivProizvoda.Text = rsRadniNalog.Rows(0)!NazivArtikla
            txtJedinicaMereProizvoda.Text = rsRadniNalog.Rows(0)!JedinicaMere
            txtKolicinaProizvoda.Text = rsRadniNalog.Rows(0)!Kolicina
            TxtProizvedenaKolicina.Text = rsRadniNalog.Rows(0)!ProizvedenaKolicina

            ChkLansirano.Checked = rsRadniNalog.Rows(0)!Lansirano
            chkKnjizeno.Checked = rsRadniNalog.Rows(0)!Knjizeno

            DtpDatumKnjizenja.Value = rsRadniNalog.Rows(0)!DatumKnjizenja
            DtpDatumLansiranja.Value = rsRadniNalog.Rows(0)!DatumLansiranja

            txtPredajnica.Text = rsRadniNalog.Rows(0)!BrojPredajnice
            txtBrojFinansijskogNaloga.Text = rsRadniNalog.Rows(0)!BrojFinansijskogNaloga

            txtNapomena.Text = rsRadniNalog.Rows(0)!Napomena.ToString

            DajStavkeRadnogNaloga(txtBroj.Text)
            DajStavkeTrebovanja(txtBroj.Text)
            DajSume()

            txtNazivProizvoda.Select()

        End If

        grdListaGP.Visible = False
        GrdListaStavki.Visible = False

    End Sub
    Private Sub FrmRadniNalog_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Parametri.Novi = False
    End Sub

    Private Sub CmbMagacinRN_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbMagacinRN.SelectionChangeCommitted

        If CmbMagacinRN.SelectedIndex > -1 Then
            txtSifraMagacinaRN.Text = CmbMagacinRN.SelectedValue

            txtNazivProizvoda.Select()
        Else
            txtSifraMagacinaRN.Text = ""
        End If
    End Sub
    Private Sub txtNazivProizvoda_TextChanged(sender As Object, e As EventArgs) Handles txtNazivProizvoda.TextChanged

        If txtNazivProizvoda.Text = "" Then
            txtSifraProizvoda.Text = ""
            grdListaGP.Visible = False
        Else
            grdListaGP.Visible = True
            ArtikliRN.Trazi(txtNazivProizvoda.Text, True, SelektovanaKolona)
        End If

    End Sub
    Private Sub txtNazivProizvoda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNazivProizvoda.KeyDown

        If e.KeyCode = Keys.Down Then
            If grdListaGP.Visible Then
                grdListaGP.Rows(0).Selected = True
                grdListaGP.Select()
            End If
        End If

    End Sub
    Private Sub grdListaGP_MouseClick(sender As Object, e As MouseEventArgs) Handles grdListaGP.MouseClick
        Dim hit As DataGridView.HitTestInfo = grdListaGP.HitTest(e.X, e.Y)

        'On Error GoTo greska

        If hit.RowIndex > -1 Then

            grdListaGP.Rows(hit.RowIndex).Selected = True

            Dim sifra As String = grdListaGP.SelectedRows(0).Cells("Sifra").Value
            Dim naziv As String = grdListaGP.SelectedRows(0).Cells("Naziv").Value
            Dim JM As String = grdListaGP.SelectedRows(0).Cells("JedinicaMere").Value
            txtSifraProizvoda.Text = sifra
            txtNazivProizvoda.Text = naziv
            txtJedinicaMereProizvoda.Text = JM

            grdListaGP.Visible = False

            txtKolicinaProizvoda.Select()

        End If
    End Sub
    Private Sub grdListaGP_KeyDown(sender As Object, e As KeyEventArgs) Handles grdListaGP.KeyDown
        If grdListaGP.SelectedRows.Count > 0 Then
            If e.KeyCode = Keys.Enter Then
                Dim sifra As String = grdListaGP.SelectedRows(0).Cells("Sifra").Value
                Dim naziv As String = grdListaGP.SelectedRows(0).Cells("Naziv").Value
                Dim JM As String = grdListaGP.SelectedRows(0).Cells("JedinicaMere").Value
                txtSifraProizvoda.Text = sifra
                txtNazivProizvoda.Text = naziv
                txtJedinicaMereProizvoda.Text = JM
                grdListaGP.Visible = False

                txtKolicinaProizvoda.Select()

            End If
        End If
    End Sub
    Private Sub txtKolicinaProizvoda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKolicinaProizvoda.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(txtKolicinaProizvoda.Text) Then
                TxtNazivKomponenteRN.Select()
            End If
        End If
    End Sub


    Private Sub CmbMagacinStavkiRN_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbMagacinStavkiRN.SelectionChangeCommitted

        If CmbMagacinStavkiRN.SelectedIndex > -1 Then
            TxtNazivKomponenteRN.Select()
        Else
            CmbMagacinStavkiRN.Select()
        End If
    End Sub
    Private Sub TxtNazivKomponenteRN_TextChanged(sender As Object, e As EventArgs) Handles TxtNazivKomponenteRN.TextChanged

        If TxtNazivKomponenteRN.Text = "" Then
            TxtSifraKomponenteRN.Text = ""
            txtJM.Text = ""
            txtStanje.Text = "0"
            txtKolicina.Text = "0"
            TxtNabavnaCena.Text = "0"
            TxtNabavniIznos.Text = "0"
            GrdListaStavki.Visible = False
        Else
            GrdListaStavki.Visible = True
            ArtikliStavke.Trazi(TxtNazivKomponenteRN.Text, True, SelektovanaKolona)
        End If

    End Sub
    Private Sub TxtNazivKomponenteRN_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNazivKomponenteRN.KeyDown

        If e.KeyCode = Keys.Down Then
            If GrdListaStavki.Visible Then
                GrdListaStavki.Rows(0).Selected = True
                GrdListaStavki.Select()
            End If
        End If

    End Sub
    Private Sub GrdListaStavki_MouseClick(sender As Object, e As MouseEventArgs) Handles GrdListaStavki.MouseClick
        Dim hit As DataGridView.HitTestInfo = GrdListaStavki.HitTest(e.X, e.Y)

        'On Error GoTo greska

        If hit.RowIndex > -1 Then

            GrdListaStavki.Rows(hit.RowIndex).Selected = True

            Dim sifra As String = GrdListaStavki.SelectedRows(0).Cells("Sifra").Value
            Dim naziv As String = GrdListaStavki.SelectedRows(0).Cells("Naziv").Value
            Dim JM As String = GrdListaStavki.SelectedRows(0).Cells("JedinicaMere").Value
            TxtSifraKomponenteRN.Text = sifra
            TxtNazivKomponenteRN.Text = naziv
            txtJM.Text = JM
            txtStanje.Text = FormatNumber(DajStanje(TxtSifraKomponenteRN.Text, CLng(CmbMagacinStavkiRN.SelectedValue), TekucaGodina), 2,,, TriState.True)
            'TxtNabavnaCena.Text = FormatNumber(DajCenuProsecnuNabavnu(TxtSifraKomponenteRN.Text, CLng(CmbMagacinStavkiRN.SelectedValue), TekucaGodina), 2,,, TriState.True)

            GrdListaStavki.Visible = False

            txtKolicina.Select()

        End If
    End Sub
    Private Sub GrdListaStavki_KeyDown(sender As Object, e As KeyEventArgs) Handles GrdListaStavki.KeyDown
        If GrdListaStavki.SelectedRows.Count > 0 Then
            If e.KeyCode = Keys.Enter Then
                Dim sifra As String = GrdListaStavki.SelectedRows(0).Cells("Sifra").Value
                Dim naziv As String = GrdListaStavki.SelectedRows(0).Cells("Naziv").Value
                Dim JM As String = GrdListaStavki.SelectedRows(0).Cells("JedinicaMere").Value
                TxtSifraKomponenteRN.Text = sifra
                TxtNazivKomponenteRN.Text = naziv
                txtJM.Text = JM
                txtStanje.Text = FormatNumber(DajStanje(TxtSifraKomponenteRN.Text, CLng(CmbMagacinStavkiRN.SelectedValue), TekucaGodina), 2,,, TriState.True)
                'TxtNabavnaCena.Text = FormatNumber(DajCenuProsecnuNabavnu(TxtSifraKomponenteRN.Text, CLng(CmbMagacinStavkiRN.SelectedValue), TekucaGodina), 2,,, TriState.True)

                GrdListaStavki.Visible = False

                txtKolicina.Select()

            End If
        End If
    End Sub
    Private Sub txtKolicina_TextChanged(sender As Object, e As EventArgs) Handles txtKolicina.TextChanged
        If IsNumeric(txtKolicina.Text) And IsNumeric(TxtNabavnaCena.Text) Then
            TxtNabavniIznos.Text = FormatNumber((CDbl(txtKolicina.Text) * CDbl(TxtNabavnaCena.Text)), 2,,, TriState.True)
        Else
            TxtNabavniIznos.Text = "0"
        End If
    End Sub
    Private Sub txtKolicina_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKolicina.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(txtKolicina.Text) Then
                If IsNumeric(TxtNabavnaCena.Text) Then
                    TxtNabavniIznos.Text = FormatNumber((txtKolicina.Text * TxtNabavnaCena.Text), 2,,, TriState.True)
                    TxtNabavniIznos.Select()
                Else
                    txtKolicina.Select()
                End If
            End If
        End If
    End Sub
    Private Sub TxtNabavniIznos_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNabavniIznos.KeyDown
        Dim rs As DataTable
        Dim rsR As DataTable
        Dim Rbr As Integer

        If e.KeyCode = Keys.Enter Then
            If Parametri.PravoPristupa >= 2 Then

                If Godina <> TekucaGodina Then
                    If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                End If

                If chkKnjizeno.Checked Then
                    If MsgBox("Unosite stavku u proknjižen dokument!" & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                End If

                If TxtSifraKomponenteRN.Text = "" Or IsNumeric(TxtSifraKomponenteRN.Text) = False Or TxtNazivKomponenteRN.Text = "" Then
                    MsgBox("Greska pri unosu artikla!", MsgBoxStyle.Exclamation)
                    TxtNazivKomponenteRN.Select()
                    Exit Sub
                End If

                If txtKolicina.Text = "" Or IsNumeric(txtKolicina.Text) = False Then
                    MsgBox("Greska pri unosu količine!", MsgBoxStyle.Exclamation)
                    txtKolicina.Select()
                    Exit Sub
                End If

                If Parametri.Novi Then
                    rs = GetData("SELECT * FROM RadniNalogStavke WHERE SifraArtikla=" & TxtSifraKomponenteRN.Text & " AND BrojRadnogNaloga=" & MinusID & " AND Godina=" & Godina)
                    If rs.Rows.Count > 0 Then
                        If MsgBox("Unosite artikal koji već postoji u ovom dokumentu! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                    End If
                    rs.Dispose()

                    rsR = GetData("SELECT MAX(Rbr) AS Novi FROM RadniNalogStavke WHERE BrojRadnogNaloga=" & MinusID & " And Godina=" & Godina)
                    If IsDBNull(rsR.Rows(0)!Novi) Or (rsR.Rows.Count = 0) Then
                        Rbr = 1
                    Else
                        Rbr = rsR.Rows(0)!Novi + 1
                    End If

                    InsertData("INSERT INTO RadniNalogStavke VALUES(" & CmbMagacinStavkiRN.SelectedValue & "," & MinusID & ",'False',0," & Rbr & "," & TxtSifraKomponenteRN.Text _
                           & ",'" & TxtNazivKomponenteRN.Text & "','" & txtJM.Text & "'," & FormatNumber(CDbl(txtStanje.Text), 4,,, TriState.False) _
                           & "," & FormatNumber(CDbl(TxtNabavnaCena.Text), 2,,, TriState.False) & ",0," & FormatNumber(CDbl(txtKolicina.Text), 4,,, TriState.False) _
                           & "," & FormatNumber(CDbl(TxtNabavniIznos.Text), 2,,, TriState.False) & ",0," & Godina & ")")

                    DajStavkeRadnogNaloga(MinusID)
                    DajSume()
                Else
                    rs = GetData("SELECT * FROM RadniNalogStavke WHERE SifraArtikla=" & TxtSifraKomponenteRN.Text & " AND BrojRadnogNaloga=" & CLng(txtBroj.Text) & " AND Godina=" & Godina)
                    If rs.Rows.Count > 0 Then
                        If MsgBox("Unosite artikal koji već postoji u ovom dokumentu! Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                    End If
                    rs.Dispose()

                    rsR = GetData("SELECT MAX(Rbr) AS Novi FROM RadniNalogStavke WHERE BrojRadnogNaloga=" & CLng(txtBroj.Text) & " AND Godina=" & Godina)
                    If IsDBNull(rsR.Rows(0)!Novi) Or (rsR.Rows.Count = 0) Then
                        Rbr = 1
                    Else
                        Rbr = rsR.Rows(0)!Novi + 1
                    End If

                    InsertData("INSERT INTO RadniNalogStavke VALUES(" & CmbMagacinStavkiRN.SelectedValue & "," & CLng(txtBroj.Text) & ",'False',0," & Rbr & "," & TxtSifraKomponenteRN.Text _
                           & ",'" & TxtNazivKomponenteRN.Text & "','" & txtJM.Text & "'," & FormatNumber(CDbl(txtStanje.Text), 4,,, TriState.False) _
                           & "," & FormatNumber(CDbl(TxtNabavnaCena.Text), 2,,, TriState.False) & ",0," & FormatNumber(CDbl(txtKolicina.Text), 4,,, TriState.False) _
                           & "," & FormatNumber(CDbl(TxtNabavniIznos.Text), 2,,, TriState.False) & ",0," & Godina & ")")

                    DajStavkeRadnogNaloga(txtBroj.Text)
                    DajStavkeTrebovanja(txtBroj.Text)
                    DajSume()
                End If


                TxtSifraKomponenteRN.Text = ""
                TxtNazivKomponenteRN.Text = ""
                txtJM.Text = ""
                txtKolicina.Text = "0"
                txtStanje.Text = "0"
                TxtNabavnaCena.Text = "0"
                TxtNabavniIznos.Text = "0"
                TxtNazivKomponenteRN.Select()
            Else
                MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
                Exit Sub
            End If

        End If
    End Sub


    Sub Novi()

        Parametri.Novi = True

        InsertData("DELETE FROM RadniNalogStavke WHERE BrojRadnogNaloga=" & MinusID)


        txtBroj.Text = "0"
        dtpDatum.Text = Format(Now, "dd/M/yyyy")

        CmbMagacinRN.SelectedValue = 2
        txtSifraMagacinaRN.Text = CmbMagacinRN.SelectedValue
        txtSifraProizvoda.Text = ""
        txtNazivProizvoda.Text = ""
        txtJedinicaMereProizvoda.Text = ""
        txtKolicinaProizvoda.Text = "0"
        TxtProizvedenaKolicina.Text = "0"

        CmbMagacinStavkiRN.SelectedValue = 3
        TxtSifraKomponenteRN.Text = ""
        TxtNazivKomponenteRN.Text = ""
        txtJM.Text = ""
        txtStanje.Text = "0"
        txtKolicina.Text = "0"
        TxtNabavnaCena.Text = "0"
        TxtNabavniIznos.Text = "0"


        txtPredajnica.Text = "0"
        txtBrojFinansijskogNaloga.Text = ""
        lblJedinicnaVrednost.Text = "0.00"
        lblUkupno.Text = "0.00"
        txtNapomena.Text = ""

        ChkLansirano.Checked = False
        chkKnjizeno.Checked = False

        grdStavke.DataSource = Nothing

        'cmdNovi.Enabled = False
        'cmdSnimi.Enabled = True
        'CmdLansiranje.Enabled = False

        'cmdKnjizenje.Enabled = False
        'CmdPredajnica.Enabled = False
        'CmdNalog.Enabled = False
        'cmdStampa.Enabled = False

        txtNazivProizvoda.Select()
    End Sub
    Sub GridZaListuGP()
        ArtikliRN.Grid = grdListaGP
        ArtikliRN.KolikoVidljivihRedova = 0
        ArtikliRN.DinamickaVisina = False
        ArtikliRN.BojenjeRedova = False

        Dim kk As DataGridViewColumn

        kk = New DataGridViewColumn
        kk.Name = "Sifra"
        kk.HeaderText = "ŠIFRA"
        kk.Width = 80
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 0
        ArtikliRN.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "Naziv"
        kk.HeaderText = "NAZIV"
        kk.Width = 300
        'kk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        kk.DisplayIndex = 1
        ArtikliRN.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "JedinicaMere"
        kk.HeaderText = "JM"
        kk.Width = 100
        kk.DisplayIndex = 2
        ArtikliRN.DodajKolonuZaGrid(kk)

        kk = New DataGridViewColumn
        kk.Name = "KataloskiBroj"
        kk.HeaderText = "Kataloški br"
        kk.Width = 200
        kk.DisplayIndex = 3
        ArtikliRN.DodajKolonuZaGrid(kk)


    End Sub
    Sub DajStavkeRadnogNaloga(ByVal Broj As Long)

        rsStavke = GetData("SELECT dbo.RadniNalogStavke.BrojRadnogNaloga, dbo.RadniNalogStavke.Rbr, dbo.SifarnikMagacini.Naziv AS Magacin, dbo.RadniNalogStavke.Trebovanje, 
                            dbo.RadniNalogStavke.BrojTrebovanja, dbo.RadniNalogStavke.SifraArtikla, dbo.RadniNalogStavke.NazivArtikla, dbo.RadniNalogStavke.JedinicaMere, 
                            dbo.RadniNalogStavke.Kolicina, dbo.RadniNalogStavke.NabavnaCena, dbo.RadniNalogStavke.NabavniIznos, dbo.RadniNalogStavke.ID 
                            FROM  dbo.RadniNalogStavke INNER JOIN dbo.SifarnikMagacini ON dbo.RadniNalogStavke.Magacin = dbo.SifarnikMagacini.Sifra 
                            WHERE dbo.RadniNalogStavke.BrojRadnogNaloga=" & Broj & " And dbo.RadniNalogStavke.Godina=" & Godina & " ORDER BY dbo.RadniNalogStavke.Rbr")

        grdStavke.DataSource = Nothing
        grdStavke.DataSource = rsStavke

        grdStavke.Columns("BrojRadnogNaloga").Visible = False

        grdStavke.Columns("Rbr").Width = 40
        grdStavke.Columns("Magacin").Width = 200
        grdStavke.Columns("Magacin").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("Magacin").HeaderText = "MAGACIN"
        grdStavke.Columns("Trebovanje").Width = 100
        grdStavke.Columns("Trebovanje").HeaderText = "TREBOVANJE"
        grdStavke.Columns("BrojTrebovanja").Width = 80
        grdStavke.Columns("BrojTrebovanja").HeaderText = "BR.TREB."
        grdStavke.Columns("SifraArtikla").Width = 60
        grdStavke.Columns("SifraArtikla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("SifraArtikla").HeaderText = "ŠIFRA"
        grdStavke.Columns("NazivArtikla").Width = 400
        grdStavke.Columns("NazivArtikla").HeaderText = "NAZIV ARTIKLA"
        grdStavke.Columns("NazivArtikla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("JedinicaMere").Width = 70
        grdStavke.Columns("JedinicaMere").HeaderText = "J.M."
        grdStavke.Columns("JedinicaMere").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdStavke.Columns("Kolicina").Width = 90
        grdStavke.Columns("Kolicina").HeaderText = "KOLIČINA"
        grdStavke.Columns("Kolicina").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("Kolicina").DefaultCellStyle.Format = "###,###,###,##0.0000"
        grdStavke.Columns("NabavnaCena").Width = 120
        grdStavke.Columns("NabavnaCena").HeaderText = "CENA"
        grdStavke.Columns("NabavnaCena").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("NabavnaCena").DefaultCellStyle.Format = "###,###,###,##0.00"
        grdStavke.Columns("NabavniIznos").Width = 120
        grdStavke.Columns("NabavniIznos").HeaderText = "IZNOS"
        grdStavke.Columns("NabavniIznos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("NabavniIznos").DefaultCellStyle.Format = "###,###,###,##0.00"
        grdStavke.Columns("ID").Visible = False

    End Sub
    Sub DajStavkeTrebovanja(ByVal Broj As Long)
        Dim rs As DataTable

        'rs = GetData("SELECT Magacin, NazivMagacina, BrojTrebovanja, Datum, Vrednost FROM RadniNalogTrebovanja WHERE BrojRadnogNaloga=" & Broj & " AND Godina=" & Godina)
        rs = GetData("SELECT dbo.RadniNalogTrebovanja.Magacin, dbo.SifarnikMagacini.Naziv AS NazivMagacina, dbo.RadniNalogTrebovanja.BrojTrebovanja, 
                        dbo.RadniNalogTrebovanja.Datum, dbo.RadniNalogTrebovanja.Vrednost 
                        FROM dbo.RadniNalogTrebovanja INNER JOIN dbo.SifarnikMagacini ON dbo.RadniNalogTrebovanja.Magacin = dbo.SifarnikMagacini.Sifra
                        WHERE BrojRadnogNaloga=" & Broj & " AND Godina=" & Godina)

        GrdTrebovanja.DataSource = Nothing
        GrdTrebovanja.DataSource = rs

        GrdTrebovanja.Columns("Magacin").Width = 80
        GrdTrebovanja.Columns("Magacin").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        GrdTrebovanja.Columns("Magacin").HeaderText = "Magacin"
        GrdTrebovanja.Columns("NazivMagacina").Width = 200
        GrdTrebovanja.Columns("NazivMagacina").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        GrdTrebovanja.Columns("NazivMagacina").HeaderText = "Naziv"
        GrdTrebovanja.Columns("BrojTrebovanja").Width = 120
        GrdTrebovanja.Columns("BrojTrebovanja").HeaderText = "Brojtrebovanja"
        GrdTrebovanja.Columns("Datum").Width = 100
        GrdTrebovanja.Columns("Datum").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        GrdTrebovanja.Columns("Datum").HeaderText = "Datum"
        GrdTrebovanja.Columns("Vrednost").Width = 120
        GrdTrebovanja.Columns("Vrednost").HeaderText = "Vrednost"
        GrdTrebovanja.Columns("Vrednost").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GrdTrebovanja.Columns("Vrednost").DefaultCellStyle.Format = "###,###,###,##0.00"

    End Sub
    Sub DajSume()
        Dim VrednostTrebovanja As Double
        Dim JedinicnaVrednost As Double
        Dim Ukupno As Double

        LblVrednostTrebovanja.Text = "0.00"
        lblJedinicnaVrednost.Text = "0.00"
        lblUkupno.Text = "0.00"

        For n = 0 To grdStavke.RowCount - 1
            Ukupno += grdStavke.Rows(n).Cells("NabavniIznos").Value
        Next

        For m = 0 To GrdTrebovanja.RowCount - 1
            VrednostTrebovanja += GrdTrebovanja.Rows(m).Cells("Vrednost").Value
        Next

        LblVrednostTrebovanja.Text = FormatNumber(VrednostTrebovanja, 2,,, TriState.True)
        lblUkupno.Text = FormatNumber(Ukupno, 2, , , TriState.True)
        JedinicnaVrednost = Ukupno / CDbl(txtKolicinaProizvoda.Text)
        lblJedinicnaVrednost.Text = FormatNumber(JedinicnaVrednost, 2, , , TriState.True)

    End Sub
    Sub ProveraObaveznihPolja()
        RetCom.Poruka = "OK"

        If CmbMagacinRN.SelectedIndex = -1 Or CmbMagacinRN.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(CmbMagacinRN, "Izaberite magacin")
        End If

        If IsNumeric(txtSifraProizvoda.Text) = False Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(txtSifraProizvoda, "Greška pri unosu šifre")
        End If

        If txtNazivProizvoda.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(txtNazivProizvoda, "Obavezan unos")
        End If

        If txtJedinicaMereProizvoda.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(txtJedinicaMereProizvoda, "Obavezan unos")
        End If

        If IsNumeric(txtKolicinaProizvoda.Text) = False Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(txtKolicinaProizvoda, "Obavezan unos")
        End If
        If IsNumeric(TxtProizvedenaKolicina.Text) = False Then
            TxtProizvedenaKolicina.Text = "0"
        End If

        TmrIndikatorGreske.Enabled = True

    End Sub
    Sub FinansijskiNalog()
        Dim rs As DataTable
        Dim BrojNaloga As Integer
        Dim Rbr As Integer = 1
        Dim OznakaDokumenta As String = "RN"
        Dim KontoMagacina As String

        BrojNaloga = txtBroj.Text

        InsertData("INSERT INTO FinansijskiNalog VALUES('RN'," & BrojNaloga & " ," & CLng(txtSifraMagacinaRN.Text) & ",'" & Format(CDate(DtpDatumKnjizenja.Text), FormatDatuma) _
                   & "','" & txtNapomena.Text & "','False','" & TimeOfDay & "'," & Godina & "," & UserID & ")")

        'rs = GetData("SELECT Magacin,SUM(Iznos) As Iznos FROM dbo.RadniNalogStavke WHERE BrojRadnogNaloga=" & txtBroj.Text & " GROUP BY Magacin")
        rs = GetData("SELECT * FROM RadniNalogTrebovanja WHERE BrojRadnogNaloga=" & txtBroj.Text & " AND Godina=" & Godina & " ORDER BY BrojTrebovanja")
        For n = 0 To rs.Rows.Count - 1
            KontoMagacina = SifarnikMagacina.Trazi("Sifra=" & rs.Rows(n)!Magacin)(0)!Konto.ToString

            InsertData("INSERT INTO FinansijskiNalogStavke VALUES('RN'," & BrojNaloga & " ," & CLng(txtSifraMagacinaRN.Text) & "," & Rbr & ",'" & KontoMagacina _
                               & "',0,0,'','" & OznakaDokumenta & "-" & BrojNaloga & "-0" & CLng(txtSifraMagacinaRN.Text) _
                               & "','Trebovanje: " & rs.Rows(n)!BrojTrebovanja & "/0" & rs.Rows(n)!Magacin & "','','',0," & FormatNumber((rs.Rows(n)!Vrednost), 2,,, TriState.False) _
                               & ",0," & Godina & ")")
            Rbr += 1
        Next

        KontoMagacina = SifarnikMagacina.Trazi("Sifra=" & txtSifraMagacinaRN.Text)(0)!Konto.ToString
        InsertData("INSERT INTO FinansijskiNalogStavke VALUES('RN'," & BrojNaloga & " ," & CLng(txtSifraMagacinaRN.Text) & "," & Rbr & ",'" & KontoMagacina _
                               & "',0,0,'','" & OznakaDokumenta & "-" & BrojNaloga & "-0" & CLng(txtSifraMagacinaRN.Text) & "','','',''," & FormatNumber(FormatNumber(CDbl(lblUkupno.Text), 2,,, TriState.False), 2,,, TriState.False) _
                               & ",0,0," & Godina & ")")

        txtBrojFinansijskogNaloga.Text = BrojNaloga
        InsertData("UPDATE RadniNalog SET BrojFinansijskogNaloga ='" & BrojNaloga & "' WHERE Godina=" & Godina & " And Broj=" & CLng(txtBroj.Text) & " And Magacin=" & CLng(txtSifraMagacinaRN.Text))


    End Sub


    Private Sub grdStavke_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdStavke.CellMouseDown
        If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub
        Selected = True
        lblDisp.Visible = True
        If e.Button = MouseButtons.Left Then lblDisp.Text = "0.00"
    End Sub
    Private Sub grdStavke_SelectionChanged(sender As Object, e As EventArgs) Handles grdStavke.SelectionChanged
        Dim SelectedCellTotal As Double
        Dim value As String = Nothing

        If Selected Then
            For counter = 0 To (grdStavke.SelectedCells.Count - 1)
                If grdStavke.SelectedCells(counter).FormattedValueType Is Type.GetType("System.String") Then

                    If (grdStavke.IsCurrentCellDirty = True) Then
                        value = grdStavke.SelectedCells(counter).EditedFormattedValue.ToString()
                    Else
                        value = grdStavke.SelectedCells(counter).FormattedValue.ToString()
                    End If

                    If IsNumeric(value) Then
                        If Not value.Length = 0 Then SelectedCellTotal += Double.Parse(value)
                    End If
                End If
            Next
            lblDisp.Text = Format(SelectedCellTotal, "###,###,###,##0.00")
        End If
    End Sub
    Private Sub grdStavke_KeyDown(sender As Object, e As KeyEventArgs) Handles grdStavke.KeyDown

        If e.KeyCode = Keys.Delete Then
            If Parametri.PravoPristupa >= 2 Then

                'If chkKnjizeno.Checked Then
                '    MsgBox("Ne možete menjati proknjižen dokument!", MsgBoxStyle.Exclamation)
                '    Exit Sub
                'End If

                If chkKnjizeno.Checked Then
                    If MsgBox("Brišete stavku u proknjiženom dokumentu! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Else
                    If ChkLansirano.Checked Then
                        If MsgBox("Brišete stavku u lansiranom dokument! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                    Else
                        If MsgBox("Brisanje! " & vbCrLf & vbCrLf & "Da li ste sigurni?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                    End If
                End If

                If Parametri.Novi = True Then
                    For n = 0 To grdStavke.RowCount - 1
                        Cursor = Cursors.WaitCursor
                        If grdStavke.Rows(n).Selected Then
                            InsertData("DELETE FROM RadniNalogStavke WHERE BrojRadnogNaloga=" & MinusID & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value _
                                       & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Magacin=" & grdStavke.Rows(n).Cells("Magacin").Value & " AND Godina = " & Godina)

                        End If
                    Next

                    DajStavkeRadnogNaloga(MinusID)
                    DajSume()

                Else
                    For n = 0 To grdStavke.RowCount - 1
                        Cursor = Cursors.WaitCursor
                        If grdStavke.Rows(n).Selected Then
                            InsertData("DELETE FROM RadniNalogStavke WHERE BrojRadnogNaloga=" & CLng(txtBroj.Text) & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value _
                                       & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value & " AND Godina = " & Godina)

                        End If
                    Next

                    DajStavkeRadnogNaloga(txtBroj.Text)
                    DajStavkeTrebovanja(txtBroj.Text)
                    DajSume()
                End If

                '***brisanje iz trebovanja***
                'If ChkLansirano.Checked Then
                'Dim rs As DataTable
                'Dim rsZ As DataTable


                'End If


            Else
                MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Cursor = Cursors.Default

        End If
    End Sub
    Private Sub grdStavke_MouseClick(sender As Object, e As MouseEventArgs) Handles grdStavke.MouseClick
        Dim hit As DataGridView.HitTestInfo = grdStavke.HitTest(e.X, e.Y)

        If hit.RowIndex > grdStavke.RowCount - 1 Or hit.RowIndex < 0 Then Exit Sub

        Parametri.RBR = CLng(grdStavke.Rows(hit.RowIndex).Cells("RBr").Value)
        Parametri.SifraArtikla = CLng(grdStavke.Rows(hit.RowIndex).Cells("SifraArtikla").Value)

        If IsDBNull(grdStavke.Rows(hit.RowIndex).Cells(0).Value) Then Exit Sub

        If e.Button = MouseButtons.Right Then
            mnuRadniNalog.Show(grdStavke, e.X, e.Y)
        End If
    End Sub
    Private Sub grdStavke_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles grdStavke.CellValidated
        Dim Trosak As Double = 0
        'On Error GoTo greska

        If NumerickaProveraKolonaGrida(grdStavke, -1) = False Then
            MsgBox("Sva polja moraju biti popunjena", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Select Case grdStavke.Columns(e.ColumnIndex).Name
            Case "Cena"
                grdStavke.Rows(e.RowIndex).Cells("Iznos").Value = FormatNumber((grdStavke.Rows(e.RowIndex).Cells("Kolicina").Value * grdStavke.Rows(e.RowIndex).Cells("Cena").Value), 2,,, TriState.False)


                DajSume()
        End Select
        Exit Sub
greska:
        MsgBox(Err.Description)

    End Sub


    Private Sub GrdTrebovanja_MouseClick(sender As Object, e As MouseEventArgs) Handles GrdTrebovanja.MouseClick
        Dim hit As DataGridView.HitTestInfo = GrdTrebovanja.HitTest(e.X, e.Y)

        On Error GoTo greska

        If hit.RowIndex > -1 Then

            GrdTrebovanja.Rows(hit.RowIndex).Selected = True

            'Parametri.BrojTrebovanja = CLng(GrdTrebovanja.Rows(hit.RowIndex).Cells("BrojTrebovanja").Value)
            'Parametri.MagacinTrebovanja = CLng(GrdTrebovanja.Rows(hit.RowIndex).Cells("Magacin").Value)

            Parametri.Broj = CLng(GrdTrebovanja.Rows(hit.RowIndex).Cells("BrojTrebovanja").Value)
            TekuciMagacin = CLng(GrdTrebovanja.Rows(hit.RowIndex).Cells("Magacin").Value)
        End If

        If e.Button = MouseButtons.Right Then
            MnuTrebovanje.Show(GrdTrebovanja, e.X, e.Y)
        End If

        Exit Sub

greska:
        Exit Sub
    End Sub
    Private Sub GrdTrebovanja_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GrdTrebovanja.MouseDoubleClick
        Dim hit As DataGridView.HitTestInfo = GrdTrebovanja.HitTest(e.X, e.Y)

        'On Error GoTo greska

        If hit.RowIndex < 0 Then Exit Sub

        Parametri.Broj = CLng(GrdTrebovanja.Rows(hit.RowIndex).Cells("BrojTrebovanja").Value)
        TekuciMagacin = CLng(GrdTrebovanja.Rows(hit.RowIndex).Cells("Magacin").Value)

        FrmTrebovanje.Dispose()
        Hide()
        FrmTrebovanje.ShowDialog()
        Show()

        DajStavkeTrebovanja(txtBroj.Text)
        DajSume()

        Exit Sub

greska:
        MsgBox("Dokument nije pronađen!", MsgBoxStyle.Exclamation)
        Exit Sub

    End Sub


    Private Sub mnuBrisanje_Click(sender As Object, e As EventArgs) Handles mnuBrisanje.Click

        If Parametri.PravoPristupa >= 2 Then
            If chkKnjizeno.Checked Then
                MsgBox("Ne možete menjati proknjižen dokument!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If ChkLansirano.Checked Then
                If MsgBox("Brišete stavku u lansiranom dokument! Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Else
                If MsgBox("Brisanje! " & vbCrLf & vbCrLf & "Da li ste sigurni?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If



            If Parametri.Novi = True Then
                For n = 0 To grdStavke.RowCount - 1
                    Cursor = Cursors.WaitCursor
                    If grdStavke.Rows(n).Selected Then
                        InsertData("DELETE FROM RadniNalogStavke WHERE BrojRadnogNaloga=" & MinusID & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value _
                                   & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Magacin=" & grdStavke.Rows(n).Cells("Magacin").Value & " AND Godina = " & Godina)

                    End If
                Next

                DajStavkeRadnogNaloga(MinusID)
                DajSume()

            Else
                For n = 0 To grdStavke.RowCount - 1
                    Cursor = Cursors.WaitCursor
                    If grdStavke.Rows(n).Selected Then
                        InsertData("DELETE FROM RadniNalogStavke WHERE BrojRadnogNaloga=" & CLng(txtBroj.Text) & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value _
                                   & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Magacin=" & grdStavke.Rows(n).Cells("Magacin").Value & " AND Magacin=" & grdStavke.Rows(n).Cells("Magacin").Value & " AND Godina = " & Godina)

                    End If
                Next

                DajStavkeRadnogNaloga(txtBroj.Text)
                DajStavkeTrebovanja(txtBroj.Text)
                DajSume()
            End If
        Else
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Cursor = Cursors.Default
    End Sub
    Private Sub MnuOtvoriTrebovanje_Click(sender As Object, e As EventArgs) Handles MnuOtvoriTrebovanje.Click

        FrmTrebovanje.Dispose()
        Hide()
        FrmTrebovanje.ShowDialog()
        Show()

        DajStavkeTrebovanja(txtBroj.Text)
        DajSume()

        Exit Sub

greska:
        MsgBox("Dokument nije pronađen!", MsgBoxStyle.Exclamation)
        Exit Sub

    End Sub


    Private Sub tmrDelay_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrDelay.Tick
        'pnlOK.Visible = False

        'cmdNovi.Enabled = True
        'cmdSnimi.Enabled = True
        'CmdLansiranje.Enabled = True
        'cmdKnjizenje.Enabled = True
        'CmdPredajnica.Enabled = True
        'CmdNalog.Enabled = True
        'cmdStampa.Enabled = True

        tmrDelay.Enabled = False

    End Sub
    Private Sub TmrIndikatorGreske_Tick(sender As Object, e As EventArgs) Handles TmrIndikatorGreske.Tick

        erpIndikatorGreske.SetError(txtSifraProizvoda, "")
        erpIndikatorGreske.SetError(txtNazivProizvoda, "")
        erpIndikatorGreske.SetError(txtJedinicaMereProizvoda, "")
        erpIndikatorGreske.SetError(txtKolicinaProizvoda, "")

        erpIndikatorGreske.SetError(CmbMagacinRN, "")

        TmrIndikatorGreske.Enabled = False

    End Sub


    Private Sub cmdNovi_Click(sender As Object, e As EventArgs)
        Novi()
    End Sub
    Private Sub cmdSnimi_Click(sender As Object, e As EventArgs)
        Dim rs As DataTable

        If Parametri.PravoPristupa >= 2 Then
            ProveraObaveznihPolja()
            If RetCom.Poruka = "Greška" Then Exit Sub

            If dtpDatum.Text = "" Or IsDate(dtpDatum.Text) = False Then
                MsgBox("Morate uneti datum!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor

            If Parametri.Novi Then
                rs = GetData("SELECT * FROM RadniNalogStavke WHERE BrojRadnogNaloga=" & MinusID & "AND Godina=" & Godina)
                If rs.Rows.Count = 0 Then
                    MsgBox("Ne možete da snimite dokument koji nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                rs.Dispose()

                rs = GetData("SELECT MAX(Broj) AS Novi FROM RadniNalog WHERE Godina=" & Godina)
                If rs.Rows.Count = 0 Or IsDBNull(rs.Rows(0)!Novi) Then
                    txtBroj.Text = "1"
                Else
                    txtBroj.Text = rs.Rows(0)!Novi + 1
                End If

                InsertData("INSERT INTO RadniNalog VALUES(" & CmbMagacinRN.SelectedValue & "," & CLng(txtBroj.Text) & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
                           & "'," & CInt(txtSifraProizvoda.Text) & ",'" & txtNazivProizvoda.Text & "','" & txtJedinicaMereProizvoda.Text _
                           & "'," & FormatNumber(CDbl(txtKolicinaProizvoda.Text), 2,,, TriState.False) & ",0," & FormatNumber(CDbl(lblJedinicnaVrednost.Text), 2,,, TriState.False) _
                           & "," & FormatNumber(CDbl(lblUkupno.Text), 2,,, TriState.False) & ",0,'False','False','" & Format(CDate(DtpDatumLansiranja.Text), FormatDatuma) _
                           & "','" & Format(CDate(DtpDatumKnjizenja.Text), FormatDatuma) & "','','" & txtNapomena.Text & "','" & TimeOfDay & "'," & Godina & "," & UserID & ")")

                InsertData("UPDATE RadniNalogStavke SET BrojRadnogNaloga =" & CLng(txtBroj.Text) & " WHERE BrojRadnogNaloga =" & MinusID)

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','Novi dokument','" & DocStatus & "'," & txtBroj.Text & ",'')")

            Else
                If chkKnjizeno.Checked Then
                    If MsgBox("Da li ste sigurni da želite da korigujete proknjižen dokument!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                End If

                rs = GetData("SELECT * FROM RadniNalogStavke WHERE BrojRadnogNaloga=" & CInt(txtBroj.Text) & " AND Godina=" & Godina)
                If rs.Rows.Count = 0 Then
                    MsgBox("Ne možete da snimite dokument koji nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                rs.Dispose()

                InsertData("UPDATE RadniNalog SET Magacin=" & CInt(txtSifraMagacinaRN.Text) & " WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" & Godina)
                InsertData("UPDATE RadniNalog SET Datum='" & Format(CDate(dtpDatum.Text), FormatDatuma) & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" & Godina)
                InsertData("UPDATE RadniNalog SET SifraArtikla=" & CInt(txtSifraProizvoda.Text) & " WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" & Godina)
                InsertData("UPDATE RadniNalog SET NazivArtikla='" & txtNazivProizvoda.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" & Godina)
                InsertData("UPDATE RadniNalog SET JedinicaMere='" & txtJedinicaMereProizvoda.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" & Godina)
                InsertData("UPDATE RadniNalog SET Kolicina=" & FormatNumber(CDbl(txtKolicinaProizvoda.Text), 2,,, TriState.False) & " WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" & Godina)
                InsertData("UPDATE RadniNalog SET JedinicnaVrednostProizvoda=" & FormatNumber(CDbl(lblJedinicnaVrednost.Text), 2,,, TriState.False) & " WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" & Godina)
                InsertData("UPDATE RadniNalog SET UkupnaVrednostProizvoda=" & FormatNumber(CDbl(lblUkupno.Text), 2,,, TriState.False) & " WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" & Godina)
                InsertData("UPDATE RadniNalog SET DatumLansiranja='" & Format(CDate(DtpDatumLansiranja.Text), FormatDatuma) & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" & Godina)
                InsertData("UPDATE RadniNalog SET DatumKnjizenja='" & Format(CDate(DtpDatumKnjizenja.Text), FormatDatuma) & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" & Godina)
                InsertData("UPDATE RadniNalog SET Napomena='" & txtNapomena.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" & Godina)


                For n = 0 To grdStavke.Rows.Count - 1
                    InsertData("UPDATE RadniNalogStavke SET Kolicina=" & grdStavke.Rows(n).Cells("Kolicina").Value & " WHERE BrojRadnogNaloga=" & CInt(txtBroj.Text) _
                               & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Rbr=" & grdStavke.Rows(n).Cells("Rbr").Value & " AND Godina=" & Godina)
                    InsertData("UPDATE RadniNalogStavke SET Cena=" & grdStavke.Rows(n).Cells("Cena").Value & " WHERE BrojRadnogNaloga=" & CInt(txtBroj.Text) _
                               & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Rbr=" & grdStavke.Rows(n).Cells("Rbr").Value & " AND Godina=" & Godina)
                    InsertData("UPDATE RadniNalogStavke SET Iznos=" & grdStavke.Rows(n).Cells("Iznos").Value & " WHERE BrojRadnogNaloga=" & CInt(txtBroj.Text) _
                               & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Rbr=" & grdStavke.Rows(n).Cells("Rbr").Value & " AND Godina=" & Godina)
                Next


                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','Korekcija','" & DocStatus & "'," & txtBroj.Text & ",'')")

            End If

            Cursor = Cursors.Default

            'CmdNovi.Enabled = False
            'CmdSnimi.Enabled = False
            'CmdLansiranje.Enabled = False
            'cmdKnjizenje.Enabled = False
            'CmdPredajnica.Enabled = False
            'CmdNalog.Enabled = False
            'cmdStampa.Enabled = False

            'pnlOK.Visible = True

            Parametri.Novi = False
            DajStavkeRadnogNaloga(txtBroj.Text)
            DajStavkeTrebovanja(txtBroj.Text)
            DajSume()
            tmrDelay.Enabled = True
        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub
    Private Sub CmdLansiranje_Click(sender As Object, e As EventArgs)
        Dim rsTREBOVANJA As DataTable, rsMagacin As DataTable
        'Dim rs As DataTable
        Dim rsT As DataTable
        Dim rsTS As DataTable
        Dim BrojTrebovanja As Integer
        Dim Rbr As Integer
        Dim SumaTrebovanja As Double
        Dim TrebovanjeFormirano As Boolean

        If Parametri.PravoPristupa >= 2 Then
            'If ChkLansirano.Checked Then
            '    MsgBox("Radni nalog je već lansiran!", vbExclamation, "Radni nalog")
            '    Exit Sub
            'End If

            'If MsgBox("Lansiranjem radnog naloga formiraju se trebovanja. Nastavljate?", vbQuestion + vbYesNo, "Radni nalog") = vbNo Then Exit Sub
            If Parametri.Novi Then
                MsgBox("Radni nalog mora biti snimljen!", vbExclamation, "Radni nalog")
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor

            rsTREBOVANJA = GetData("SELECT * FROM RadniNalogStavke WHERE Trebovanje='False' AND BrojRadnogNaloga=" & txtBroj.Text & " AND Godina=" & Godina)
            If rsTREBOVANJA.Rows.Count = 0 Then
                MsgBox("Sve stavke su lansirane!", MsgBoxStyle.Exclamation, "Radni nalog")
                Cursor = Cursors.Default
                Exit Sub
            Else
                rsMagacin = GetData("SELECT Magacin FROM dbo.RadniNalogStavke WHERE Trebovanje='False' AND BrojRadnogNaloga=" & txtBroj.Text & " AND Godina=" & Godina & " GROUP BY Magacin")

                For n = 0 To rsMagacin.Rows.Count - 1
                    SumaTrebovanja = 0
                    rsT = GetData("SELECT MAX(Broj) AS Novi FROM Trebovanje WHERE Magacin=" & rsMagacin.Rows(n)!Magacin & " AND Godina=" & Godina)
                    If rsT.Rows.Count = 0 Or IsDBNull(rsT.Rows(0)!Novi) Then
                        BrojTrebovanja = "1"
                    Else
                        BrojTrebovanja = rsT.Rows(0)!Novi + 1
                    End If

                    InsertData("INSERT INTO Trebovanje VALUES(" & rsMagacin.Rows(n)!Magacin & "," & BrojTrebovanja & ",'" & Format(CDate(DtpDatumLansiranja.Text), FormatDatuma) _
                                   & "'," & CLng(txtBroj.Text) & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) & "','','" & Format(CDate(DtpDatumLansiranja.Text), FormatDatuma) _
                                   & "','False','" & txtNapomena.Text & "','" & TimeOfDay & "'," & Godina & "," & UserID & ")")

                    rsTS = GetData("SELECT * FROM RadniNalogStavke WHERE BrojRadnogNaloga=" & CLng(txtBroj.Text) & " AND Trebovanje='False' AND  Godina=" & Godina & " AND Magacin=" & rsMagacin.Rows(n)!Magacin)
                    Rbr = 1
                    For m = 0 To rsTS.Rows.Count - 1
                        InsertData("INSERT INTO TrebovanjeStavke VALUES(" & rsMagacin.Rows(n)!Magacin & "," & BrojTrebovanja & "," & CLng(txtBroj.Text) & "," & Rbr & "," & rsTS.Rows(m)!SifraArtikla _
                               & ",'" & rsTS.Rows(m)!NazivArtikla & "','" & rsTS.Rows(m)!JedinicaMere & "'," & FormatNumber(CDbl(rsTS.Rows(m)!Stanje), 4,,, TriState.False) _
                               & "," & FormatNumber(CDbl(rsTS.Rows(m)!NabavnaCena), 2,,, TriState.False) & ",0," & FormatNumber(CDbl(rsTS.Rows(m)!Kolicina), 2,,, TriState.False) _
                               & "," & FormatNumber(CDbl(rsTS.Rows(m)!NabavniIznos), 2,,, TriState.False) & ",0," & Godina & ")")

                        SumaTrebovanja += rsTS.Rows(m)!NabavniIznos

                        InsertData("UPDATE RadniNalogStavke SET Trebovanje='True' WHERE BrojRadnogNaloga=" & CInt(txtBroj.Text) _
                           & " AND SifraArtikla=" & rsTS.Rows(m)!SifraArtikla & " AND Rbr=" & rsTS.Rows(m)!Rbr _
                           & " AND Magacin=" & rsMagacin.Rows(n)!Magacin & " AND Godina=" & Godina)
                        InsertData("UPDATE RadniNalogStavke SET BrojTrebovanja=" & BrojTrebovanja & " WHERE BrojRadnogNaloga=" & CInt(txtBroj.Text) _
                           & " AND SifraArtikla=" & rsTS.Rows(m)!SifraArtikla & " AND Rbr=" & rsTS.Rows(m)!Rbr _
                           & " AND Magacin=" & rsMagacin.Rows(n)!Magacin & " AND Godina=" & Godina)

                        Rbr = Rbr + 1
                    Next

                    InsertData("UPDATE RadniNalogStavke SET Trebovanje='True' WHERE BrojRadnogNaloga=" & CLng(txtBroj.Text) _
                               & " AND Trebovanje='False' AND  Godina=" & Godina & " AND Magacin=" & rsMagacin.Rows(n)!Magacin)
                    InsertData("UPDATE RadniNalogStavke SET BrojTrebovanja=" & BrojTrebovanja & " WHERE BrojRadnogNaloga=" & CLng(txtBroj.Text) _
                               & " AND Trebovanje='False' AND  Godina=" & Godina & " AND Magacin=" & rsMagacin.Rows(n)!Magacin)

                    InsertData("INSERT INTO RadniNalogTrebovanja VALUES(" & rsMagacin.Rows(n)!Magacin & "," & BrojTrebovanja & ",'" & Format(CDate(DtpDatumLansiranja.Text), FormatDatuma) _
                               & "'," & FormatNumber(SumaTrebovanja, 2,,, TriState.False) & "," & CLng(txtBroj.Text) & "," & Godina & ")")

                    TrebovanjeFormirano = True
                Next
            End If

            If TrebovanjeFormirano Then
                InsertData("UPDATE RadniNalog SET Lansirano ='True' WHERE Broj=" & CLng(txtBroj.Text) & " AND Godina=" & Godina)
                ChkLansirano.Checked = True
                TrebovanjeFormirano = False
            End If

            DajStavkeRadnogNaloga(txtBroj.Text)
            DajStavkeTrebovanja(txtBroj.Text)
            DajSume()

            Cursor = Cursors.Default

        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
            Exit Sub
        End If

    End Sub
    'Private Sub CmdTrebovanjePP_Click(sender As Object, e As EventArgs) Handles CmdTrebovanjePP.Click

    '    If IsNumeric(txtTrebovanjePoluproizvoda.Text) And txtTrebovanjePoluproizvoda.Text > 0 Then
    '        Parametri.Broj = CLng(txtTrebovanjePoluproizvoda.Text)
    '        TekuciMagacin = 8

    '        FrmTrebovanje.Dispose()
    '        Hide()
    '        FrmTrebovanje.ShowDialog()
    '        Show()
    '    Else
    '        MsgBox("Dokument nije pronađen!", MsgBoxStyle.Exclamation)
    '    End If

    'End Sub
    'Private Sub CmdTrebovanjeRepro_Click(sender As Object, e As EventArgs) Handles CmdTrebovanjeRepro.Click

    '    If IsNumeric(TxtTrebovanjeRepromaterijal.Text) And TxtTrebovanjeRepromaterijal.Text > 0 Then
    '        Parametri.Broj = CLng(TxtTrebovanjeRepromaterijal.Text)
    '        TekuciMagacin = 3

    '        FrmTrebovanje.Dispose()
    '        Hide()
    '        FrmTrebovanje.ShowDialog()
    '        Show()
    '    Else
    '        MsgBox("Dokument nije pronađen!", MsgBoxStyle.Exclamation)
    '    End If


    'End Sub
    Private Sub cmdKnjizenje_Click(sender As Object, e As EventArgs)
        Dim rsP As DataTable
        Dim rsN As DataTable
        Dim BrojPredajnice As Integer
        Dim Rbr As Integer = 1

        If Parametri.PravoPristupa >= 2 Then
            If Godina <> TekucaGodina Then
                If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If

            If chkKnjizeno.Checked Then
                If MsgBox("Dokument je već proknjižen!" & vbCrLf & vbCrLf & "Da li želite da ga PREKNJIŽITE?", vbQuestion + vbYesNo, "RADNI NALOG") = vbYes Then

                    InsertData("DELETE FROM FinansijskiNalog WHERE VrstaNaloga='RN' AND Broj=" & txtBrojFinansijskogNaloga.Text & " AND  Godina=" & Godina)
                    InsertData("DELETE FROM FinansijskiNalogStavke WHERE VrstaNaloga='RN' AND BrojNaloga=" & txtBrojFinansijskogNaloga.Text & " AND Godina=" & Godina)

                    FinansijskiNalog()

                    InsertData("UPDATE PredajnicaStavke SET Cena=" & FormatNumber(CDbl(lblJedinicnaVrednost.Text), 2,,, TriState.False) _
                           & " WHERE SifraArtikla=" & CLng(txtSifraProizvoda.Text) & " AND BrojPredajnice=" & CLng(txtPredajnica.Text) _
                           & " AND Magacin=" & CLng(txtSifraMagacinaRN.Text) & " AND Godina=" & Godina)
                    InsertData("UPDATE PredajnicaStavke SET Iznos=" & FormatNumber(CDbl(lblUkupno.Text), 2,,, TriState.False) _
                           & " WHERE SifraArtikla=" & CLng(txtSifraProizvoda.Text) & " AND BrojPredajnice=" & CLng(txtPredajnica.Text) _
                           & " AND Magacin=" & CLng(txtSifraMagacinaRN.Text) & " AND Godina=" & Godina)

                    InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','PreKnjizavanje','" & DocStatus & "'," & txtBroj.Text & ",'" & txtNazivProizvoda.Text & "')")
                Else
                    Cursor = Cursors.Default
                    Exit Sub
                End If
            Else

                If ChkLansirano.Checked = False Then
                    MsgBox("Ne možete da knjižite radni nalog koji nije lansiran!", vbExclamation, "Radni nalog")
                    Exit Sub
                End If

                rsN = GetData("SELECT * FROM FinansijskiNalog WHERE Broj=" & CLng(txtBroj.Text) & " AND VrstaNaloga ='RN' AND Oznaka=" & txtSifraMagacinaRN.Text & " AND Godina=" & Godina)
                If rsN.Rows.Count > 0 Then
                    MsgBox("Finansijski nalog sa ovim brojem već postoji!", MsgBoxStyle.Exclamation)
                    Cursor = Cursors.Default
                    Exit Sub
                End If

                TxtProizvedenaKolicina.Text = FormatNumber(CDbl(txtKolicinaProizvoda.Text), 2,,, TriState.True)

                rsP = GetData("SELECT MAX(Broj) AS Novi FROM Predajnica WHERE Magacin=" & CLng(txtSifraMagacinaRN.Text) & " AND Godina=" & Godina)
                If rsP.Rows.Count = 0 Or IsDBNull(rsP.Rows(0)!Novi) Then
                    BrojPredajnice = "1"
                Else
                    BrojPredajnice = rsP.Rows(0)!Novi + 1
                End If

                InsertData("INSERT INTO Predajnica VALUES(" & CLng(txtSifraMagacinaRN.Text) & "," & BrojPredajnice & ",'" & Format(CDate(DtpDatumKnjizenja.Text), FormatDatuma) _
                               & "'," & CLng(txtBroj.Text) & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) & "','','" & Format(CDate(DtpDatumKnjizenja.Text), FormatDatuma) _
                               & "','False','" & txtNapomena.Text & "','" & TimeOfDay & "'," & Godina & "," & UserID & ")")

                InsertData("INSERT INTO PredajnicaStavke VALUES(" & CLng(txtSifraMagacinaRN.Text) & "," & BrojPredajnice & "," & Rbr & "," & CLng(txtSifraProizvoda.Text) _
                               & ",'" & txtNazivProizvoda.Text & "','" & txtJedinicaMereProizvoda.Text & "'," & FormatNumber(CDbl(TxtProizvedenaKolicina.Text), 2,,, TriState.False) _
                               & "," & FormatNumber(CDbl(lblJedinicnaVrednost.Text), 2,,, TriState.False) & "," & FormatNumber(CDbl(lblUkupno.Text), 2,,, TriState.False) & "," & Godina & ")")

                InsertData("UPDATE RadniNalog SET BrojPredajnice =" & BrojPredajnice & " WHERE Broj=" & CLng(txtBroj.Text) & " AND Godina=" & Godina)
                txtPredajnica.Text = BrojPredajnice

                FinansijskiNalog()

                Cursor = Cursors.Default
                InsertData("UPDATE RadniNalog SET Knjizeno = 'True' WHERE Godina=" & Godina & " AND Broj=" & CLng(txtBroj.Text) & " AND Magacin=" & txtSifraMagacinaRN.Text)
                InsertData("UPDATE RadniNalog SET ProizvedenaKolicina =" & CDbl(txtKolicinaProizvoda.Text) & " WHERE Godina=" & Godina & " AND Broj=" & CLng(txtBroj.Text) & " AND Magacin=" & txtSifraMagacinaRN.Text)

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','Knjizenje','" & DocStatus & "'," & txtBroj.Text & ",'')")

                chkKnjizeno.Checked = True
                TxtProizvedenaKolicina.Text = txtKolicinaProizvoda.Text

                Cursor = Cursors.Default
            End If

            Cursor = Cursors.Default

            'CmdNovi.Enabled = False
            'CmdSnimi.Enabled = False
            'CmdLansiranje.Enabled = False
            'cmdKnjizenje.Enabled = False
            'CmdPredajnica.Enabled = False
            'CmdNalog.Enabled = False
            'cmdStampa.Enabled = False

            'pnlOK.Visible = True

            tmrDelay.Enabled = True

            Cursor = Cursors.Default

        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
            Exit Sub
        End If

    End Sub
    Private Sub CmdPredajnica_Click(sender As Object, e As EventArgs)

        If IsNumeric(txtPredajnica.Text) And txtPredajnica.Text > 0 Then
            Parametri.Broj = CLng(txtPredajnica.Text)
            TekuciMagacin = txtSifraMagacinaRN.Text

            FrmPredajnica.Dispose()
            Hide()
            FrmPredajnica.ShowDialog()
            Show()
        Else
            MsgBox("Dokument nije pronađen!", MsgBoxStyle.Exclamation)
        End If

    End Sub
    'Private Sub CmdNalog_Click(sender As Object, e As EventArgs)

    '    If chkKnjizeno.Checked = False Or IsNumeric(txtBrojFinansijskogNaloga.Text) = False Then
    '        MsgBox("Dokument nema formiran finansijski nalog!", vbExclamation, "Radni nalog")
    '        Exit Sub
    '    End If

    '    Parametri.Broj = CLng(txtBrojFinansijskogNaloga.Text)
    '    Parametri.NalogOznaka = txtSifraMagacinaRN.Text
    '    Parametri.NalogVrsta = "RN"

    '    frmNalogZaKnjizenje.Dispose()
    '    Hide()
    '    frmNalogZaKnjizenje.ShowDialog()
    '    Show()

    'End Sub
    'Private Sub cmdStampa_Click(sender As Object, e As EventArgs)

    'End Sub
    Private Sub cmdIzlaz_Click(sender As Object, e As EventArgs)
        Parametri.Novi = False

        Close()
    End Sub


End Class