Imports System.Drawing.Drawing2D

Public Class FrmOtpremnica
    Dim rsOtpremnica As DataTable
    Dim rsStavke As DataTable
    Dim EditStavke As Boolean
    Dim BrojRacuna As Integer
    Dim PDV As Integer
    Dim Selected As Boolean
    Dim SelektovanaKolona As String


#Region "FORMA"
    Private Sub FrmOtpremnica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lFont As Font

        lFont = New Font("Calibri", 11, FontStyle.Bold, GraphicsUnit.Point)
        grdStavke.ColumnHeadersDefaultCellStyle.Font = lFont
        lFont = New Font("Verdana", 9.75, FontStyle.Regular, GraphicsUnit.Point)
        grdStavke.RowsDefaultCellStyle.Font = lFont

        grdStavke.EnableHeadersVisualStyles = False
        grdStavke.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 109, 122)
        grdStavke.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(241, 246, 248)

        SIfarnikGlavniMagacin.KontrolaZaPrikaz = CmbMagacin
        SIfarnikGlavniMagacin.PuniKontrolu()
        CmbMagacin.SelectedValue = TekuciMagacin
        TxtSifraMagacina.Text = CmbMagacin.SelectedValue

        SifarnikMagacina.KontrolaZaPrikaz = CmbPredhodniMagacin
        SifarnikMagacina.PuniKontrolu()
        CmbPredhodniMagacin.SelectedValue = TekuciMagacin
        txtSifraPredhodnogMagacina.Text = CmbPredhodniMagacin.SelectedValue

        SifarnikNacinaIsporike = New Sifarnik
        SifarnikNacinaIsporike.Puni("SELECT * FROM SifarnikNacinaIsporuke ORDER BY Naziv")
        SifarnikNacinaIsporike.KontrolaZaPrikaz = CmbNacinIsporuke
        SifarnikNacinaIsporike.PuniKontrolu()
        CmbNacinIsporuke.SelectedIndex = -1

        'SifarnikKurirskihSluzbi = New Sifarnik
        'SifarnikKurirskihSluzbi.Puni("SELECT dbo.SifarnikKomitenti.Sifra, dbo.SifarnikKomitenti.Naziv FROM dbo.SifarnikKomitenti INNER JOIN
        '                 dbo.SifarnikKurirskihSluzbi ON dbo.SifarnikKomitenti.Sifra = dbo.SifarnikKurirskihSluzbi.Sifra ORDER BY Naziv")
        'SifarnikKurirskihSluzbi.KontrolaZaPrikaz = CmbKurirskeSluzbe
        'SifarnikKurirskihSluzbi.PuniKontrolu()
        'CmbKurirskeSluzbe.SelectedIndex = -1

        KupciAktivni.Puni()
        GridZaListuKomitenta(grdLista, KupciAktivni)
        KupciAktivni.DajSve()

        ArtikliStavke.Puni()
        GridZaListuStavkiArtikala(GrdListaStavki)
        ArtikliStavke.DajSve()

        If Parametri.Novi Then
            Novi()
        Else
            rsOtpremnica = GetData("SELECT * FROM Otpremnica WHERE Broj=" & Parametri.Broj & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
            txtSifraPredhodnogMagacina.Text = rsOtpremnica.Rows(0)!Magacin
            txtBroj.Text = rsOtpremnica.Rows(0)!Broj

            chkKnjizeno.Checked = rsOtpremnica.Rows(0)!Knjizeno
            chkRacunUradjen.Checked = rsOtpremnica.Rows(0)!RacunUradjen
            ChkIzvoz.Checked = rsOtpremnica.Rows(0)!Izvoz
            ChkGratis.Checked = rsOtpremnica.Rows(0)!Gratis
            txtBrojRacuna.Text = rsOtpremnica.Rows(0)!BrojRacuna
            dtpDatum.Value = rsOtpremnica.Rows(0)!Datum
            txtSifraKupca.Text = rsOtpremnica.Rows(0)!Kupac
            txtNazivKupca.Text = KupciAktivni.Trazi("Sifra=" & txtSifraKupca.Text)(0)!Naziv.ToString
            TxtRobuIzdao.Text = rsOtpremnica.Rows(0)!RobuIzdao.ToString
            TxtDestinacija.Text = rsOtpremnica.Rows(0)!Destinacija.ToString
            txtVozilo.Text = rsOtpremnica.Rows(0)!Vozilo.ToString
            CmbNacinIsporuke.Text = rsOtpremnica.Rows(0)!NacinIsporuke.ToString
            'CmbKurirskeSluzbe.SelectedValue = rsOtpremnica.Rows(0)!KurirskaSluzba.ToString
            txtNapomena.Text = rsOtpremnica.Rows(0)!Napomena.ToString

            DajStavkeOtpremnice(txtBroj.Text)

            txtNazivKupca.Select()
        End If

        grdLista.Visible = False
        GrdListaStavki.Visible = False

    End Sub
    Private Sub FrmOtpremnica_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim rs As DataTable

        If Parametri.Novi = False Then
            rs = GetData("SELECT * FROM OtpremnicaStavke WHERE BrojOtpremnice=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
            If rs.Rows.Count = 0 Then
                Cursor = Cursors.Default
                MsgBox("Dokument nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
        End If

    End Sub
    Private Sub FrmOtpremnica_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        Parametri.Novi = False

    End Sub
#End Region


#Region "TXT zaglavlje"

    Private Sub txtNazivKupca_TextChanged(sender As Object, e As EventArgs) Handles txtNazivKupca.TextChanged

        If txtNazivKupca.Text = "" Then
            txtSifraKupca.Text = ""
            TxtDestinacija.Text = ""
            grdLista.Visible = False
            'grdStavke.DataSource = Nothing
        Else
            grdLista.Visible = True
            KupciAktivni.Trazi(txtNazivKupca.Text, True, SelektovanaKolona)
        End If
    End Sub
    Private Sub txtNazivKupca_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNazivKupca.KeyDown

        If e.KeyCode = Keys.Down Then
            If grdLista.Visible Then
                grdLista.Rows(0).Selected = True
                grdLista.Select()
            End If
        End If

    End Sub
    Private Sub grdLista_MouseClick(sender As Object, e As MouseEventArgs) Handles grdLista.MouseClick
        Dim hit As DataGridView.HitTestInfo = grdLista.HitTest(e.X, e.Y)

        'On Error GoTo greska

        If hit.RowIndex > -1 Then

            grdLista.Rows(hit.RowIndex).Selected = True

            txtSifraKupca.Text = grdLista.SelectedRows(0).Cells("Sifra").Value
            txtNazivKupca.Text = grdLista.SelectedRows(0).Cells("Naziv").Value
            TxtDestinacija.Text = grdLista.SelectedRows(0).Cells("Destinacija").Value.ToString
            grdLista.Visible = False

            CmbNacinIsporuke.Select()

        End If
    End Sub
    Private Sub grdLista_KeyDown(sender As Object, e As KeyEventArgs) Handles grdLista.KeyDown
        If grdLista.SelectedRows.Count > 0 Then
            If e.KeyCode = Keys.Enter Then
                Dim sifra As String = grdLista.SelectedRows(0).Cells("Sifra").Value
                Dim naziv As String = grdLista.SelectedRows(0).Cells("Naziv").Value
                Dim destinacija As String = grdLista.SelectedRows(0).Cells("Destinacija").Value.ToString
                txtSifraKupca.Text = sifra
                txtNazivKupca.Text = naziv
                TxtDestinacija.Text = destinacija
                grdLista.Visible = False

                CmbNacinIsporuke.Select()

            End If
        End If
    End Sub
    Private Sub CmbNacinIsporuke_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbNacinIsporuke.SelectionChangeCommitted
        If CmbNacinIsporuke.SelectedValue = 2 Then
            CmbKurirskeSluzbe.Select()
        Else
            CmbKurirskeSluzbe.SelectedIndex = -1
        End If
    End Sub
    Private Sub TxtRobuIzdao_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtRobuIzdao.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtRobuIzdao.ReadOnly = True
            txtNapomena.ReadOnly = False
            txtNapomena.Select()
        End If
    End Sub
    Private Sub TxtDestinacija_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtDestinacija.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDestinacija.ReadOnly = True
            txtVozilo.ReadOnly = False
            txtVozilo.Select()
        End If
    End Sub
    Private Sub txtVozilo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVozilo.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmbNacinIsporuke.Select()
        End If
    End Sub
    Private Sub ChkIzvoz_CheckedChanged(sender As Object, e As EventArgs) Handles ChkIzvoz.CheckedChanged

        If ChkIzvoz.Checked Then ChkGratis.Checked = False

    End Sub
    Private Sub ChkGratis_CheckedChanged(sender As Object, e As EventArgs) Handles ChkGratis.CheckedChanged

        If ChkGratis.Checked Then ChkIzvoz.Checked = False

    End Sub
    Private Sub txtNapomena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNapomena.KeyDown
        If e.KeyCode = Keys.Enter Then TxtNazivArtikla.Select()
    End Sub
#End Region


#Region "TXT stavke"
    Private Sub CmbPredhodniMagacin_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbPredhodniMagacin.SelectionChangeCommitted

        If CmbPredhodniMagacin.SelectedIndex > -1 Then
            txtSifraPredhodnogMagacina.Text = CmbPredhodniMagacin.SelectedValue

            txtSifraArtikla.Text = ""
            TxtNazivArtikla.Text = ""
            TxtNazivArtikla.Select()
        Else
            txtSifraPredhodnogMagacina.Text = ""
            CmbPredhodniMagacin.Select()
        End If
    End Sub

    'Private Sub txtSifraArtikla_TextChanged(sender As Object, e As EventArgs) Handles txtSifraArtikla.TextChanged

    '    If IsNumeric(txtSifraArtikla.Text) Then
    '        cmbNazivArtikla.SelectedValue = txtSifraArtikla.Text
    '    End If
    'End Sub
    'Private Sub txtSifraArtikla_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSifraArtikla.KeyDown

    '    If e.KeyCode = Keys.Enter Then
    '        If IsNumeric(txtSifraArtikla.Text) Then
    '            If cmbNazivArtikla.SelectedIndex = -1 Then Exit Sub
    '            cmbNazivArtikla.SelectedValue = txtSifraArtikla.Text
    '            txtJM.Text = SifarnikArtikala.Trazi("Sifra=" & cmbNazivArtikla.SelectedValue)(0)!JedinicaMere.ToString
    '            txtStanje.Text = FormatNumber(DajStanje(txtSifraArtikla.Text, CLng(txtSifraPredhodnogMagacina.Text)), 4,,, TriState.True)
    '            txtKolicina.Select()
    '        End If
    '    End If

    'End Sub
    'Private Sub cmbNazivArtikla_SelectionChangeCommitted(sender As Object, e As EventArgs)

    '    If cmbNazivArtikla.SelectedIndex = -1 Then Exit Sub
    '    If cmbNazivArtikla.SelectedIndex > -1 Then
    '        txtSifraArtikla.Text = cmbNazivArtikla.SelectedValue
    '        txtJM.Text = SifarnikArtikala.Trazi("Sifra=" & cmbNazivArtikla.SelectedValue)(0)!JedinicaMere.ToString
    '        txtStanje.Text = FormatNumber(DajStanje(txtSifraArtikla.Text, CLng(txtSifraPredhodnogMagacina.Text)), 4,,, TriState.True)
    '        txtKolicina.Select()
    '    Else
    '        txtSifraArtikla.Text = ""
    '    End If

    'End Sub
    'Private Sub cmbNazivArtikla_KeyDown(sender As Object, e As KeyEventArgs)

    '    If e.KeyCode = Keys.Down Then cmbNazivArtikla.DroppedDown = True

    '    If e.KeyCode = Keys.Enter And txtSifraArtikla.Text <> "" Then
    '        If cmbNazivArtikla.SelectedIndex = -1 Then Exit Sub
    '        txtSifraArtikla.Text = cmbNazivArtikla.SelectedValue
    '        txtJM.Text = SifarnikArtikala.Trazi("Sifra=" & cmbNazivArtikla.SelectedValue)(0)!JedinicaMere.ToString
    '        txtStanje.Text = FormatNumber(DajStanje(txtSifraArtikla.Text, CLng(txtSifraPredhodnogMagacina.Text)), 4,,, TriState.True)
    '        txtKolicina.Select()
    '    End If
    'End Sub
    'Private Sub txtBarCod_KeyDown(sender As Object, e As KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        txtKolicina.Select()
    '    End If
    'End Sub
    Private Sub TxtNazivArtikla_TextChanged(sender As Object, e As EventArgs) Handles TxtNazivArtikla.TextChanged

        If TxtNazivArtikla.Text = "" Then
            txtSifraArtikla.Text = ""
            txtJM.Text = ""
            txtStanje.Text = "0"
            txtKolicina.Text = ""
            GrdListaStavki.Visible = False
        Else
            GrdListaStavki.Visible = True
            ArtikliStavke.Trazi(TxtNazivArtikla.Text, True, SelektovanaKolona)
        End If

    End Sub
    Private Sub TxtNazivArtikla_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNazivArtikla.KeyDown

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
            txtSifraArtikla.Text = sifra
            TxtNazivArtikla.Text = naziv
            txtJM.Text = JM
            txtStanje.Text = FormatNumber(DajStanje(txtSifraArtikla.Text, CLng(CmbPredhodniMagacin.SelectedValue), TekucaGodina), 2,,, TriState.True)

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
                txtSifraArtikla.Text = sifra
                TxtNazivArtikla.Text = naziv
                txtJM.Text = JM

                txtStanje.Text = FormatNumber(DajStanje(txtSifraArtikla.Text, CLng(CmbPredhodniMagacin.SelectedValue), TekucaGodina), 2,,, TriState.True)

                GrdListaStavki.Visible = False

                txtKolicina.Select()

            End If
        End If
    End Sub
    Private Sub txtKolicina_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKolicina.KeyDown
        Dim rs As DataTable
        Dim rsR As DataTable
        Dim rsA As DataTable
        'Dim rsCena As DataTable
        Dim rsZaliha As DataTable
        Dim Zaliha As Double
        Dim NabavnaCena As Double, ProdajnaCena As Double, Stanje As Double
        Dim Rbr As Integer

        If e.KeyCode = Keys.Enter Then
            If Parametri.PravoPristupa >= 2 Then
                If Godina <> TekucaGodina Then
                    If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                End If

                If chkKnjizeno.Checked Then
                    'MsgBox("Ne možete menjati proknjižen dokument!", MsgBoxStyle.Exclamation)
                    'Exit Sub
                    If MsgBox("Unosite stavku u proknjižen dokument!" & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                End If

                If txtSifraArtikla.Text = "" Or IsNumeric(txtSifraArtikla.Text) = False Or TxtNazivArtikla.Text = "" Then
                    MsgBox("Greska pri unosu artikla!", MsgBoxStyle.Exclamation)
                    TxtNazivArtikla.Select()
                    Exit Sub
                End If

                If txtKolicina.Text = "" Or IsNumeric(txtKolicina.Text) = False Then
                    MsgBox("Greska pri unosu količine!", MsgBoxStyle.Exclamation)
                    txtKolicina.Select()
                    Exit Sub
                End If

                'NabavnaCena = DajCenuProsecnuNabavnu(txtSifraArtikla.Text, CLng(TxtSifraMagacina.Text), TekucaGodina)
                'ProdajnaCena = DajCenuProdajnu(txtSifraArtikla.Text, CLng(TxtSifraMagacina.Text), TekucaGodina)
                Stanje = DajStanje(txtSifraArtikla.Text, CLng(TxtSifraMagacina.Text), TekucaGodina)

                If Parametri.Novi Then
                    rs = GetData("SELECT * FROM OtpremnicaStavke WHERE SifraArtikla=" & txtSifraArtikla.Text & " AND BrojOtpremnice=" & MinusID _
                                 & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                    If rs.Rows.Count > 0 Then
                        If MsgBox("Unosite artikal koji već postoji u ovoj otpremnici!" & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                    End If
                    rs.Dispose()

                    rsR = GetData("SELECT MAX(Rbr) AS Novi FROM OtpremnicaStavke WHERE BrojOtpremnice=" & MinusID _
                              & " And Godina=" & Godina & " And Magacin=" & TekuciMagacin)
                    If IsDBNull(rsR.Rows(0)!Novi) Or (rsR.Rows.Count = 0) Then
                        Rbr = 1
                    Else
                        Rbr = rsR.Rows(0)!Novi + 1
                    End If

                    InsertData("INSERT INTO OtpremnicaStavke VALUES(" & TekuciMagacin & "," & MinusID & "," & Rbr & ",0," & CLng(txtSifraArtikla.Text) _
                           & ",'" & TxtNazivArtikla.Text & "','','" & txtJM.Text & "'," & FormatNumber(Stanje, 4,,, TriState.False) & "," & FormatNumber(NabavnaCena, 2,,, TriState.False) _
                           & "," & FormatNumber(ProdajnaCena, 2,,, TriState.False) & "," & FormatNumber(CDbl(txtKolicina.Text), 4,,, TriState.False) _
                           & "," & CLng(txtSifraPredhodnogMagacina.Text) & ",'False',0,'False',0," & Godina & ")")

                    DajStavkeOtpremnice(MinusID)
                Else
                    rs = GetData("SELECT * FROM OtpremnicaStavke WHERE SifraArtikla=" & txtSifraArtikla.Text & " AND BrojOtpremnice=" & CLng(txtBroj.Text) _
                                 & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                    If rs.Rows.Count > 0 Then
                        If MsgBox("Unosite artikal koji već postoji u ovoj otpremnici!" & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                    End If
                    rs.Dispose()

                    rsR = GetData("SELECT MAX(Rbr) AS Novi FROM OtpremnicaStavke WHERE BrojOtpremnice=" & CLng(txtBroj.Text) _
                              & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                    If IsDBNull(rsR.Rows(0)!Novi) Or (rsR.Rows.Count = 0) Then
                        Rbr = 1
                    Else
                        Rbr = rsR.Rows(0)!Novi + 1
                    End If

                    InsertData("INSERT INTO OtpremnicaStavke VALUES(" & TekuciMagacin & "," & CLng(txtBroj.Text) & "," & Rbr & ",0," & CLng(txtSifraArtikla.Text) _
                           & ",'" & TxtNazivArtikla.Text & "','','" & txtJM.Text & "'," & FormatNumber(Stanje, 4,,, TriState.False) & "," & FormatNumber(NabavnaCena, 2,,, TriState.False) _
                           & "," & FormatNumber(ProdajnaCena, 2,,, TriState.False) & "," & FormatNumber(CDbl(txtKolicina.Text), 4,,, TriState.False) _
                           & "," & CLng(txtSifraPredhodnogMagacina.Text) & ",'False',0,'False',0," & Godina & ")")


                    '***knjizenje u zalihama stavke koja se dodaje u proknjizenom dokumentu
                    If chkKnjizeno.Checked Then
                        rsZaliha = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & txtSifraArtikla.Text & " AND BarCod=''")
                        If rsZaliha.Rows.Count = 0 Then
                            InsertData("INSERT INTO Zaliha VALUES(" & TekuciMagacin & "," & CLng(txtSifraArtikla.Text) & ",'',0,0)")
                        Else
                            Zaliha = (rsZaliha.Rows(0)!Zaliha - CDbl(txtKolicina.Text))
                            InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & txtSifraArtikla.Text & " AND BarCod=''")
                        End If

                        InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Dodavanje u proknjizenoj','" & DocStatus & "'," & txtBroj.Text & ",'" & TxtNazivArtikla.Text & "')")

                    End If

                    '***dodavanje stavke u fakturu
                    If chkRacunUradjen.Checked Then
                        'rsCena = GetData("SELECT * FROM Cenovnik WHERE SifraArtikla=" & txtSifraArtikla.Text & " AND Magacin=" & TekuciMagacin & " AND Komitent=0")
                        'If rsCena.Rows.Count > 0 Then
                        '    If ChkIzvoz.Checked Then
                        '        Cena = rsCena.Rows(0)!CenaEur
                        '    Else
                        '        Cena = rsCena.Rows(0)!ProdajnaCena
                        '    End If

                        '    If ChkGratis.Checked Then
                        '        Cena = 0
                        '    Else
                        '        Cena = rsCena.Rows(0)!ProdajnaCena
                        '    End If
                        'Else
                        '    Cena = 0
                        'End If

                        If ChkGratis.Checked Then ProdajnaCena = 0

                        rsA = GetData("Select * FROM SifarnikArtikli WHERE Sifra=" & txtSifraArtikla.Text)

                        InsertData("INSERT INTO RacunStavke VALUES(" & CLng(txtBrojRacuna.Text) & ",0," & Rbr & "," & CLng(txtSifraArtikla.Text) & ",'" & TxtNazivArtikla.Text _
                       & "','" & txtJM.Text & "'," & FormatNumber(CDbl(txtKolicina.Text), 2,,, TriState.False) & "," & FormatNumber(ProdajnaCena, 2,,, TriState.False) _
                       & ",0,0,0," & rsA.Rows(0)!PoreskaStopa & ",0,0,0," & Parametri.Poreklo & "," & Godina & ")")

                        InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Dodavanje u fakturu iz','" & DocStatus & "'," & txtBroj.Text & ",'" & TxtNazivArtikla.Text & "')")

                    End If

                    DajStavkeOtpremnice(txtBroj.Text)
                End If


                txtSifraArtikla.Text = ""
                TxtNazivArtikla.Text = ""
                'txtBarCod.Text = ""
                txtJM.Text = ""
                txtKolicina.Text = ""
                txtStanje.Text = ""
                TxtNazivArtikla.Select()
            Else
                MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
                Exit Sub
            End If

        End If
    End Sub

#End Region


#Region "GRID"
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
    Private Sub grdStavke_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles grdStavke.CellValidated

    End Sub
    Private Sub grdStavke_KeyDown(sender As Object, e As KeyEventArgs) Handles grdStavke.KeyDown
        Dim rs As DataTable
        Dim rsZaliha As DataTable
        Dim rsRacun As DataTable
        Dim Zaliha As Double

        If e.KeyCode = Keys.Delete Then
            If Parametri.PravoPristupa >= 2 Then
                If Godina <> TekucaGodina Then
                    If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                End If

                If chkKnjizeno.Checked Then
                    'MsgBox("Ne možete menjati proknjižen dokument!", MsgBoxStyle.Exclamation)
                    'Exit Sub
                    If MsgBox("Brišete stavku u proknjiženom dokument! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Else
                    If MsgBox("Brisanje! " & vbCrLf & vbCrLf & "Da li ste sigurni?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                End If

                If Parametri.Novi = True Then
                    For n = 0 To grdStavke.RowCount - 1
                        Cursor = Cursors.WaitCursor
                        If grdStavke.Rows(n).Selected Then
                            InsertData("DELETE FROM OtpremnicaStavke WHERE BrojOtpremnice=" & MinusID & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                        & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)
                        End If
                    Next

                    'AzurirajRbr(Parametri.RBR, MinusID)
                    DajStavkeOtpremnice(MinusID)
                Else
                    rs = GetData("SELECT * FROM OtpremnicaStavke WHERE BrojOtpremnice=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                    If rs.Rows.Count = 1 Then
                        Cursor = Cursors.Default
                        MsgBox("Ne možete brisati jedinu stavku u dokumentu!", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If

                    For n = 0 To grdStavke.RowCount - 1
                        Cursor = Cursors.WaitCursor
                        If grdStavke.Rows(n).Selected Then
                            InsertData("DELETE FROM OtpremnicaStavke WHERE BrojOtpremnice=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                        & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)

                            'knjizenje u zalihama stavke koja se brise u proknjizenom dokumentu
                            If chkKnjizeno.Checked Then
                                rsZaliha = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND BarCod=''")
                                Zaliha = (rsZaliha.Rows(0)!Zaliha + grdStavke.Rows(n).Cells("Kolicina").Value)
                                InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin _
                                            & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND BarCod=''")

                                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                            & "','Brisanje u proknjizenoj','" & DocStatus & "'," & txtBroj.Text & ",'" & grdStavke.Rows(n).Cells("SifraArtikla").Value & "')")

                            End If

                            'brisanje stavke u fakturi
                            If chkRacunUradjen.Checked Then
                                If IsNumeric(txtBrojRacuna.Text) Then
                                    rsRacun = GetData("SELECT * FROM RacunStavke WHERE BrojRacuna=" & CInt(txtBrojRacuna.Text) & " AND Godina=" & Godina _
                                                    & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)

                                    If rsRacun.Rows.Count = 1 Then
                                        InsertData("DELETE FROM RacunStavke WHERE BrojRacuna=" & CInt(txtBrojRacuna.Text) & " AND Godina=" & Godina _
                                                & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)

                                        InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                                & "','Brisanje u fakturi','" & DocStatus & "'," & txtBroj.Text & ",'" & grdStavke.Rows(n).Cells("SifraArtikla").Value & "')")
                                    Else
                                        MsgBox("Artikal " & grdStavke.Rows(n).Cells("SifraArtikla").Value & vbCrLf & "nije obrisan u fakturi!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    MsgBox("Greška u broju fakture!", MsgBoxStyle.Exclamation)
                                End If
                            End If
                        End If
                    Next

                    'AzurirajRbr(Parametri.RBR, txtBroj.Text)
                    DajStavkeOtpremnice(txtBroj.Text)
                End If
            Else
                MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Cursor = Cursors.Default

        End If
    End Sub
    Private Sub grdStavke_MouseClick(sender As Object, e As MouseEventArgs) Handles grdStavke.MouseClick

        GridDesniKlik(sender, e, mnuOtpremnica, grdStavke)

    End Sub




#End Region


#Region "MNU"
    Private Sub mnuBrisanje_Click(sender As Object, e As EventArgs) Handles mnuBrisanje.Click
        Dim rs As DataTable
        Dim rsZaliha As DataTable
        Dim rsRacun As DataTable
        Dim Zaliha As Double

        If Parametri.PravoPristupa >= 2 Then
            If Godina <> TekucaGodina Then
                If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If

            If chkKnjizeno.Checked Then
                'MsgBox("Ne možete menjati proknjižen dokument!", MsgBoxStyle.Exclamation)
                'Exit Sub
                If MsgBox("Brišete stavku u proknjiženom dokument! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Else
                If MsgBox("Brisanje! " & vbCrLf & vbCrLf & "Da li ste sigurni?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If

            If Parametri.Novi = True Then
                For n = 0 To grdStavke.RowCount - 1
                    Cursor = Cursors.WaitCursor
                    If grdStavke.Rows(n).Selected Then
                        InsertData("DELETE FROM OtpremnicaStavke WHERE BrojOtpremnice=" & MinusID & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                    & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)
                    End If
                Next

                'AzurirajRbr(Parametri.RBR, MinusID)
                DajStavkeOtpremnice(MinusID)
            Else
                rs = GetData("SELECT * FROM OtpremnicaStavke WHERE BrojOtpremnice=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                If rs.Rows.Count = 1 Then
                    Cursor = Cursors.Default
                    MsgBox("Ne možete brisati jedinu stavku u dokumentu!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                For n = 0 To grdStavke.RowCount - 1
                    Cursor = Cursors.WaitCursor
                    If grdStavke.Rows(n).Selected Then
                        InsertData("DELETE FROM OtpremnicaStavke WHERE BrojOtpremnice=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                    & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)

                        'knjizenje u zalihama stavke koja se brise u proknjizenom dokumentu
                        If chkKnjizeno.Checked Then
                            rsZaliha = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND BarCod=''")
                            Zaliha = (rsZaliha.Rows(0)!Zaliha + grdStavke.Rows(n).Cells("Kolicina").Value)
                            InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin _
                                        & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND BarCod=''")

                            InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                        & "','Brisanje u proknjizenoj','" & DocStatus & "'," & txtBroj.Text & ",'" & grdStavke.Rows(n).Cells("SifraArtikla").Value & "')")

                        End If

                        'brisanje stavke u fakturi
                        If chkRacunUradjen.Checked Then
                            If IsNumeric(txtBrojRacuna.Text) Then
                                rsRacun = GetData("SELECT * FROM RacunStavke WHERE BrojRacuna=" & CInt(txtBrojRacuna.Text) & " AND Godina=" & Godina _
                                                & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)

                                If rsRacun.Rows.Count = 1 Then
                                    InsertData("DELETE FROM RacunStavke WHERE BrojRacuna=" & CInt(txtBrojRacuna.Text) & " AND Godina=" & Godina _
                                            & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)

                                    InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                            & "','Brisanje u fakturi','" & DocStatus & "'," & txtBroj.Text & ",'" & grdStavke.Rows(n).Cells("SifraArtikla").Value & "')")
                                Else
                                    MsgBox("Artikal " & grdStavke.Rows(n).Cells("SifraArtikla").Value & vbCrLf & "nije obrisan u fakturi!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Greška u broju fakture!", MsgBoxStyle.Exclamation)
                            End If
                        End If
                    End If
                Next

                'AzurirajRbr(Parametri.RBR, txtBroj.Text)
                DajStavkeOtpremnice(txtBroj.Text)
            End If
        Else
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Cursor = Cursors.Default

    End Sub
    Private Sub mnuAzurirajRbr_Click(sender As Object, e As EventArgs) Handles mnuAzurirajRbr.Click

        If Parametri.PravoPristupa >= 2 Then

            Cursor = Cursors.WaitCursor

            AzurirajRbr(txtBroj.Text)
            DajStavkeOtpremnice(txtBroj.Text)
        Else
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Cursor = Cursors.Default

    End Sub
    Private Sub mnuSortiranjeAZ_Click(sender As Object, e As EventArgs) Handles mnuSortiranjeAZ.Click
        grdStavke.SortiranjeAZ(Parametri.Sortiranje)
    End Sub
    Private Sub mnuSortiranjeZA_Click(sender As Object, e As EventArgs) Handles mnuSortiranjeZA.Click
        grdStavke.SortiranjeZA(Parametri.Sortiranje)
    End Sub

#End Region


#Region "FUNKCIJE"
    Sub Novi()

        Parametri.Novi = True

        InsertData("DELETE FROM OtpremnicaStavke WHERE BrojOtpremnice=" & MinusID)

        txtBroj.Text = "0"
        txtSifraPredhodnogMagacina.Text = TekuciMagacin
        CmbPredhodniMagacin.SelectedValue = TekuciMagacin

        If Godina <> TekucaGodina Then
            dtpDatum.Text = "31/12/" & Godina
        Else
            dtpDatum.Text = Format(Now, "dd/M/yyyy")
        End If

        txtSifraKupca.Text = ""
        txtNazivKupca.Text = ""
        TxtRobuIzdao.Text = ""
        TxtDestinacija.Text = ""
        txtVozilo.Text = ""
        txtNapomena.Text = ""

        txtBrojRacuna.Text = ""

        CmbNacinIsporuke.SelectedIndex = -1
        CmbKurirskeSluzbe.SelectedIndex = -1

        txtSifraArtikla.Text = ""
        TxtNazivArtikla.Text = ""
        'txtBarCod.Text = ""
        txtJM.Text = ""
        txtStanje.Text = ""
        txtKolicina.Text = ""

        chkKnjizeno.Checked = False
        chkRacunUradjen.Checked = False
        ChkIzvoz.Checked = False
        ChkGratis.Checked = False

        grdStavke.DataSource = Nothing

        'cmdNovi.Enabled = False
        'cmdSnimi.Enabled = True
        'CmdOdjava.Enabled = False
        'CmdPrenosnica.Enabled = False
        'CmdFaktura.Enabled = False
        'cmdKnjizenje.Enabled = False
        'cmdStampa.Enabled = False

        txtNazivKupca.Select()

    End Sub
    Sub Odustajanje()

        InsertData("DELETE FROM OtpremnicaStavke WHERE BrojOtpremnice=" & MinusID)

    End Sub
    Sub DajStavkeOtpremnice(ByVal Broj As Long, Optional ByVal NoviDoc As Boolean = False)

        rsStavke = GetData("Select  OtpremnicaStavke.Rbr, OtpremnicaStavke.PredhodniMagacin, dbo.SifarnikMagacini.Naziv As Magacin, OtpremnicaStavke.Odjava, OtpremnicaStavke.BrojOdjave,
                            OtpremnicaStavke.SifraArtikla, OtpremnicaStavke.NazivArtikla, OtpremnicaStavke.JedinicaMere, OtpremnicaStavke.Kolicina, OtpremnicaStavke.ID   
                            From OtpremnicaStavke INNER JOIN dbo.SifarnikMagacini ON dbo.OtpremnicaStavke.PredhodniMagacin = dbo.SifarnikMagacini.Sifra 
                            WHERE OtpremnicaStavke.Magacin=" & TekuciMagacin & " 
                            AND OtpremnicaStavke.BrojOtpremnice=" & Broj & " AND OtpremnicaStavke.Godina=" & Godina & " ORDER BY OtpremnicaStavke.Rbr")

        grdStavke.DataSource = Nothing
        grdStavke.DataSource = rsStavke

        'grdStavke.Columns("PredhodniMagacin").Visible = False

        grdStavke.Columns("Rbr").Width = 30
        grdStavke.Columns("PredhodniMagacin").HeaderText = ""
        grdStavke.Columns("PredhodniMagacin").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdStavke.Columns("PredhodniMagacin").Width = 30
        grdStavke.Columns("Magacin").Width = 250
        grdStavke.Columns("Magacin").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("Magacin").HeaderText = "MAGACIN"
        grdStavke.Columns("Odjava").Width = 60
        grdStavke.Columns("Odjava").HeaderText = "PRENOSNICA"
        grdStavke.Columns("BrojOdjave").Width = 90
        grdStavke.Columns("BrojOdjave").HeaderText = "BR.PRENOS."
        grdStavke.Columns("BrojOdjave").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdStavke.Columns("SifraArtikla").Width = 70
        grdStavke.Columns("SifraArtikla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("SifraArtikla").HeaderText = "ŠIFRA"
        grdStavke.Columns("NazivArtikla").Width = 340
        grdStavke.Columns("NazivArtikla").HeaderText = "NAZIV ARTIKLA"
        grdStavke.Columns("NazivArtikla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'grdStavke.Columns("BarCod").Width = 5
        'grdStavke.Columns("BarCod").HeaderText = "Serijski broj"
        'grdStavke.Columns("BarCod").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("JedinicaMere").Width = 60
        grdStavke.Columns("JedinicaMere").HeaderText = "J.M."
        grdStavke.Columns("JedinicaMere").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdStavke.Columns("Kolicina").Width = 160
        grdStavke.Columns("Kolicina").HeaderText = "KOLIČINA"
        grdStavke.Columns("Kolicina").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("Kolicina").DefaultCellStyle.Format = "###,###,###,##0.0000"
        grdStavke.Columns("ID").Visible = False

        ''BojenjeRedova(grdStavke, False)

        'For n = 0 To grdStavke.Columns.Count - 1
        '    grdStavke.Columns(n).Width = GetSetting(My.Application.Info.Title, "OtpremnicaStavke", grdStavke.Columns(n).Name, grdStavke.Columns(n).Width)
        'Next


    End Sub
    Sub AzurirajRbr(Broj As Integer)
        Dim rs As DataTable

        rs = GetData("SELECT * FROM OtpremnicaStavke WHERE BrojOtpremnice=" & Broj & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin & " ORDER BY ID")

        For n = 0 To rs.Rows.Count - 1
            InsertData("UPDATE OtpremnicaStavke SET RBr=" & n + 1 & " WHERE BrojOtpremnice=" & Broj & " AND Godina=" & Godina _
                           & " AND ID=" & rs(n)!ID & " AND Magacin=" & TekuciMagacin)
        Next

    End Sub
    'Function Faktura(Otpremnica As Integer) As Integer
    '    Dim rs As DataTable
    '    Dim rsS As DataTable
    '    Dim rsCK As DataTable
    '    Dim rsA As DataTable
    '    Dim Cena As Double
    '    Dim Prevoz As String

    '    Cursor = Cursors.WaitCursor

    '    If txtVozilo.Text = "" Then
    '        Prevoz = CmbNacinIsporuke.Text & " - " & CmbKurirskeSluzbe.Text
    '    Else
    '        Prevoz = CmbNacinIsporuke.Text & " - " & txtVozilo.Text
    '    End If

    '    rs = GetData("SELECT MAX(Broj) AS Novi FROM Racun WHERE Godina=" & Godina)
    '    If rs.Rows.Count = 0 Or IsDBNull(rs.Rows(0)!Novi) Then
    '        BrojRacuna = "1"
    '    Else
    '        BrojRacuna = rs.Rows(0)!Novi + 1
    '    End If

    '    If Parametri.Poreklo = 0 Then Parametri.Poreklo = 1

    '    InsertData("INSERT INTO Racun VALUES(" & BrojRacuna & ",0," & Parametri.Poreklo & "," & TekuciMagacin & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
    '                       & "','',0,'" & Format(CDate(dtpDatum.Text), FormatDatuma) & "'," & CInt(txtSifraKupca.Text) _
    '                       & ",'" & txtNazivKupca.Text & "','" & Kupci.Trazi("Sifra=" & txtSifraKupca.Text)(0)!Mesto & "','" & Kupci.Trazi("Sifra=" & txtSifraKupca.Text)(0)!Adresa _
    '                       & "','" & TxtDestinacija.Text & "','" & Prevoz & "','" & PrimarniZiroRacun & "','True',0,0,0,0,'',0,0," & DajKurs("EURO") _
    '                       & ",0,0,0,0,'','','False','False','" & ChkIzvoz.Checked & "','False'," & Parametri.PoreskiStatus & "," & PDV & ",'" & TimeOfDay & "'," & Godina & "," & UserID & ")")

    '    InsertData("INSERT INTO RacunBrojeviOtpremnica VALUES(" & TekuciMagacin & "," & BrojRacuna & "," & CLng(txtBroj.Text) & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
    '               & "'," & Parametri.Poreklo & "," & Godina & ")")

    '    rsS = GetData("Select * FROM OtpremnicaStavke WHERE BrojOtpremnice=" & Otpremnica & " And Godina=" & Godina & " And Magacin=" & TekuciMagacin)

    '    For n = 0 To rsS.Rows.Count - 1
    '        rsCK = GetData("Select * FROM Cenovnik WHERE SifraArtikla=" & rsS.Rows(n)!SifraArtikla & " And Magacin=" & TekuciMagacin & " And Komitent=0")
    '        If rsCK.Rows.Count > 0 Then
    '            Select Case Parametri.Poreklo
    '                Case 1
    '                    Cena = rsCK.Rows(0)!ProdajnaCena
    '                Case 2
    '                    Cena = rsCK.Rows(0)!CenaEur
    '                Case 3
    '                    Cena = 0
    '            End Select
    '        Else
    '            Cena = 0
    '        End If

    '        rsA = GetData("Select * FROM SifarnikArtikli WHERE Sifra=" & rsS.Rows(n)!SifraArtikla)

    '        InsertData("INSERT INTO RacunStavke VALUES(" & BrojRacuna & ", 0, " & rsS.Rows(n)!Rbr & ", " & rsS.Rows(n)!SifraArtikla & ",'" & rsS.Rows(n)!NazivArtikla _
    '                   & "','" & rsS.Rows(n)!JedinicaMere & "'," & FormatNumber(rsS.Rows(n)!Kolicina, 2,,, TriState.False) & "," & FormatNumber(Cena, 2,,, TriState.False) _
    '                   & ",0,0,0," & rsA.Rows(0)!PoreskaStopa & ",0,0,0," & Parametri.Poreklo & "," & Godina & ")")

    '    Next

    '    Cursor = Cursors.Default

    '    'If MsgBox("Formirana je Faktura broj: " & BrojRacuna & vbCrLf & "Da li želite da je otvorite?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '    '    Parametri.Broj = BrojRacuna
    '    '    Parametri.Poreklo = 1
    '    '    FrmRacunDomaci.Dispose()
    '    '    Hide()
    '    '    FrmRacunDomaci.ShowDialog()

    '    '    Show()
    '    'End If

    '    'MsgBox("Formirana je Faktura broj: " & BrojRacuna, MsgBoxStyle.Exclamation)

    '    Select Case Parametri.Poreklo
    '        Case 1
    '            Parametri.Broj = BrojRacuna
    '            DocStatus = "RacunDomaci"
    '            FrmRacunDomaci.Dispose()
    '            Hide()
    '            FrmRacunDomaci.ShowDialog()
    '            Show()
    '        Case 2
    '            Parametri.Broj = BrojRacuna
    '            DocStatus = "RacunStrani"
    '            FrmRacunStrani.Dispose()
    '            Hide()
    '            FrmRacunStrani.ShowDialog()
    '            Show()
    '        Case 3

    '    End Select

    '    DocStatus = "Otpremnica"
    '    InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
    '                           & "','Faktura iz otpremnice','" & DocStatus & "'," & BrojRacuna & ",'')")

    '    Return BrojRacuna

    'End Function


    Private Sub tmrDelay_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrDelay.Tick
        'pnlOK.Visible = False

        'CmdNovi.Enabled = True
        'cmdSnimi.Enabled = True
        'CmdPrenosnica.Enabled = True
        ''CmdOdjava.Enabled = True
        'cmdKnjizenje.Enabled = True
        ''CmdFaktura.Enabled = True
        'cmdStampa.Enabled = True

        'tmrDelay.Enabled = False
    End Sub

#End Region


#Region "TASTERI"
    Private Sub cmdNovi_Click(sender As Object, e As EventArgs) Handles CmdNovi.Click

        If Godina <> TekucaGodina Then
            If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            'MsgBox("Ne možete formirati dokumente ukoliko program nije startovan u tekućoj godini!", MsgBoxStyle.Exclamation)
            'Exit Sub
        End If

        If Parametri.PravoPristupa >= 2 Then
            Novi()
        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
            Exit Sub
        End If

    End Sub
    Private Sub cmdSnimi_Click(sender As Object, e As EventArgs) Handles CmdSnimi.Click
        Dim rs As DataTable
        Dim Kurir As Integer

        If Parametri.PravoPristupa >= 2 Then
            If Godina <> TekucaGodina Then
                If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If

            If IsNumeric(txtSifraKupca.Text) = False Then
                MsgBox("Morate uneti kupca!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If dtpDatum.Text = "" Or IsDate(dtpDatum.Text) = False Then
                MsgBox("Morate uneti datum!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If IsNumeric(txtSifraPredhodnogMagacina.Text) = False Then
                MsgBox("Morate izabrati magacin za koji radite dokument!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor

            If Parametri.Novi Then
                rs = GetData("SELECT * FROM OtpremnicaStavke WHERE BrojOtpremnice=" & MinusID & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                If rs.Rows.Count = 0 Then
                    MsgBox("Ne možete da snimite dokument koji nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                    Cursor = Cursors.Default
                    Exit Sub
                End If
                rs.Dispose()

                If IsNumeric(CmbKurirskeSluzbe.SelectedValue) Then
                    Kurir = CmbKurirskeSluzbe.SelectedValue
                Else
                    Kurir = 0
                End If

                rs = GetData("SELECT MAX(Broj) AS Novi FROM Otpremnica WHERE Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                If rs.Rows.Count = 0 Or IsDBNull(rs.Rows(0)!Novi) Then
                    txtBroj.Text = "1"
                Else
                    txtBroj.Text = rs.Rows(0)!Novi + 1
                End If

                InsertData("INSERT INTO Otpremnica VALUES(" & TekuciMagacin & "," & CLng(txtBroj.Text) & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
                           & "'," & CInt(txtSifraKupca.Text) & ",'" & TxtRobuIzdao.Text & "','" & TxtDestinacija.Text & "','" & txtVozilo.Text _
                           & "','" & CmbNacinIsporuke.Text & "'," & Kurir & ",'" & txtNapomena.Text & "','" & ChkIzvoz.Checked & "','False','False','','False',0,'" & TimeOfDay & "'," & Godina & "," & UserID & ")")

                InsertData("UPDATE OtpremnicaStavke SET BrojOtpremnice =" & CLng(txtBroj.Text) & " WHERE BrojOtpremnice =" & MinusID)

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','Novi dokument','" & DocStatus & "'," & txtBroj.Text & ",'')")

            Else
                If chkKnjizeno.Checked Then
                    If MsgBox("Snimanje proknjiženog dokumenta!" & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "OTPREMNICA") = MsgBoxResult.No Then
                        Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If

                rs = GetData("SELECT * FROM OtpremnicaStavke WHERE BrojOtpremnice=" & CInt(txtBroj.Text) & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                If rs.Rows.Count = 0 Then
                    MsgBox("Ne možete da snimite dokument koji nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                    Cursor = Cursors.Default
                    Exit Sub
                End If
                rs.Dispose()

                If IsNumeric(CmbKurirskeSluzbe.SelectedValue) Then
                    Kurir = CmbKurirskeSluzbe.SelectedValue
                Else
                    Kurir = 0
                End If

                InsertData("UPDATE Otpremnica SET Kupac=" & CInt(txtSifraKupca.Text) & " WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Otpremnica SET Datum='" & Format(CDate(dtpDatum.Text), FormatDatuma) & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Otpremnica SET RobuIzdao='" & TxtRobuIzdao.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Otpremnica SET Destinacija='" & TxtDestinacija.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Otpremnica SET Vozilo='" & txtVozilo.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Otpremnica SET NacinIsporuke='" & CmbNacinIsporuke.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Otpremnica SET KurirskaSluzba=" & Kurir & " WHERE Broj=" & CInt(txtBroj.Text) & " And Godina=" _
                           & Godina & " And Magacin=" & TekuciMagacin)
                InsertData("UPDATE Otpremnica SET Napomena='" & txtNapomena.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Otpremnica SET Izvoz='" & ChkIzvoz.Checked & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Otpremnica SET Gratis='" & ChkGratis.Checked & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)


                For n = 0 To grdStavke.Rows.Count - 1
                    InsertData("UPDATE OtpremnicaStavke SET Kolicina=" & grdStavke.Rows(n).Cells("Kolicina").Value & " WHERE BrojOtpremnice=" & CInt(txtBroj.Text) _
                               & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Rbr=" & grdStavke.Rows(n).Cells("Rbr").Value _
                               & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)

                Next

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','Korekcija','" & DocStatus & "'," & txtBroj.Text & ",'')")

            End If

            Cursor = Cursors.Default

            'CmdNovi.Enabled = False
            'CmdSnimi.Enabled = False
            'CmdPrenosnica.Enabled = False
            'CmdOdjava.Enabled = False
            'cmdKnjizenje.Enabled = False
            'CmdFaktura.Enabled = False
            'cmdStampa.Enabled = False

            'pnlOK.Visible = True

            Parametri.Novi = False
            DajStavkeOtpremnice(txtBroj.Text)
            tmrDelay.Enabled = True

            Cursor = Cursors.Default
        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Cursor = Cursors.Default

    End Sub
    Private Sub CmdPrenosnica_Click(sender As Object, e As EventArgs)
        Dim rsP As DataTable
        Dim rsO As DataTable
        Dim rsPrenosnicaK As DataTable
        Dim rsRbr As DataTable
        Dim MagacinPrenosnice As Integer = 3
        Dim NazivMagacinaPrenosnice As String
        Dim BrojPrenosnice As Integer
        Dim Rbr As Integer = 1
        Dim NabavnaCena As Double, ProdajnaCena As Double, Stanje As Double


        'formiranje prenosnice iz magacina reproMaterijala

        Cursor = Cursors.WaitCursor

        rsO = GetData("SELECT * FROM OtpremnicaStavke WHERE BrojOtpremnice=" & txtBroj.Text & " AND Magacin=" & TxtSifraMagacina.Text _
                     & " AND Godina=" & Godina & " AND Prenosnica='False' AND PredhodniMagacin=" & MagacinPrenosnice)

        NazivMagacinaPrenosnice = SifarnikMagacina.Trazi("Sifra=" & MagacinPrenosnice)(0)!Naziv.ToString
        If rsO.Rows.Count = 0 Then
            Cursor = Cursors.Default
            MsgBox("U otpremnici nema artikala za Prenosnicu iz" & vbCrLf & NazivMagacinaPrenosnice, MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            rsPrenosnicaK = GetData("SELECT * FROM Prenosnica WHERE Godina=" & Godina & " AND IzMagacina=" & MagacinPrenosnice & " AND Knjizeno='False'")
            If rsPrenosnicaK.Rows.Count = 1 Then
                BrojPrenosnice = rsPrenosnicaK.Rows(0)!Broj
                rsRbr = GetData("SELECT MAX(Rbr) AS Novi FROM PrenosnicaStavke WHERE BrojPrenosnice=" & BrojPrenosnice & " AND Godina=" & Godina & " AND Magacin=" & MagacinPrenosnice)
                Rbr = rsRbr.Rows(0)!Novi + 1

                For n = 0 To rsO.Rows.Count - 1
                    'NabavnaCena = DajCenuProsecnuNabavnu(rsO.Rows(n)!SifraArtikla, MagacinPrenosnice, TekucaGodina)
                    'ProdajnaCena = DajCenuProdajnu(rsO.Rows(n)!SifraArtikla, MagacinPrenosnice, TekucaGodina)
                    Stanje = DajStanje(rsO.Rows(n)!SifraArtikla, MagacinPrenosnice, TekucaGodina)
                    InsertData("INSERT INTO PrenosnicaStavke VALUES(" & MagacinPrenosnice & "," & BrojPrenosnice & "," & Rbr & ",0," & rsO.Rows(n)!SifraArtikla & ",'" & rsO.Rows(n)!NazivArtikla _
                               & "','','" & rsO.Rows(n)!JedinicaMere & "'," & FormatNumber(CDbl(Stanje), 4,,, TriState.False) & "," & FormatNumber(NabavnaCena, 2,,, TriState.False) _
                               & "," & FormatNumber(CDbl(ProdajnaCena), 2,,, TriState.False) & "," & FormatNumber(rsO(n)!Kolicina, 4,,, TriState.False) _
                               & "," & FormatNumber((NabavnaCena * rsO(n)!Kolicina), 2,,, TriState.False) & "," & FormatNumber((ProdajnaCena * rsO(n)!Kolicina), 2,,, TriState.False) & "," & Godina & ")")

                    Rbr += 1
                    InsertData("UPDATE OtpremnicaStavke SET Prenosnica='True' WHERE BrojOtpremnice =" & txtBroj.Text & " AND Magacin=" & TxtSifraMagacina.Text _
                                        & " AND Godina=" & Godina & " AND SifraArtikla=" & rsO.Rows(n)!SifraArtikla & "  AND PredhodniMagacin=" & MagacinPrenosnice)
                Next
            Else
                rsP = GetData("SELECT MAX(Broj) AS Novi FROM Prenosnica WHERE Godina=" & Godina & " And IzMagacina=" & MagacinPrenosnice)
                If rsP.Rows.Count = 0 Or IsDBNull(rsP.Rows(0)!Novi) Then
                    BrojPrenosnice = "1"
                Else
                    BrojPrenosnice = rsP.Rows(0)!Novi + 1
                End If

                InsertData("INSERT INTO Prenosnica VALUES(" & MagacinPrenosnice & "," & TxtSifraMagacina.Text & "," & BrojPrenosnice & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
                           & "','" & txtNapomena.Text & "','False','','" & TimeOfDay & "'," & Godina & "," & UserID & ")")

                For n = 0 To rsO.Rows.Count - 1
                    'NabavnaCena = DajCenuProsecnuNabavnu(rsO.Rows(n)!SifraArtikla, MagacinPrenosnice, TekucaGodina)
                    'ProdajnaCena = DajCenuProdajnu(rsO.Rows(n)!SifraArtikla, MagacinPrenosnice, TekucaGodina)
                    Stanje = DajStanje(rsO.Rows(n)!SifraArtikla, MagacinPrenosnice, TekucaGodina)

                    InsertData("INSERT INTO PrenosnicaStavke VALUES(" & MagacinPrenosnice & "," & BrojPrenosnice & "," & Rbr & ",0," & rsO.Rows(n)!SifraArtikla & ",'" & rsO.Rows(n)!NazivArtikla _
                               & "','','" & rsO.Rows(n)!JedinicaMere & "'," & FormatNumber(CDbl(Stanje), 4,,, TriState.False) & "," & FormatNumber(NabavnaCena, 2,,, TriState.False) _
                               & "," & FormatNumber(CDbl(ProdajnaCena), 2,,, TriState.False) & "," & FormatNumber(rsO(n)!Kolicina, 4,,, TriState.False) _
                               & "," & FormatNumber((NabavnaCena * rsO(n)!Kolicina), 2,,, TriState.False) & "," & FormatNumber((ProdajnaCena * rsO(n)!Kolicina), 2,,, TriState.False) & "," & Godina & ")")

                    Rbr += 1
                    InsertData("UPDATE OtpremnicaStavke SET Prenosnica='True' WHERE BrojOtpremnice =" & txtBroj.Text & " AND Magacin=" & TxtSifraMagacina.Text _
                                        & " AND Godina=" & Godina & " AND SifraArtikla=" & rsO.Rows(n)!SifraArtikla & "  AND PredhodniMagacin=" & MagacinPrenosnice)
                Next

            End If

            InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Prenosnica iz','" & DocStatus & "'," & txtBroj.Text & ",'" & txtNazivKupca.Text & "')")


            Cursor = Cursors.Default
            MsgBox("Formirana je prenosnica broj: " & BrojPrenosnice & vbCrLf & vbCrLf & " za " & NazivMagacinaPrenosnice, MsgBoxStyle.Exclamation)

        End If
    End Sub
    'Private Sub CmdOdjava_Click(sender As Object, e As EventArgs)
    '    Dim rsMag As DataTable
    '    Dim rsOtp As DataTable
    '    Dim rsOdjavaK As DataTable
    '    Dim rsOdjava As DataTable
    '    Dim rsRbr As DataTable
    '    Dim BrojOdjave As Integer
    '    Dim Rbr As Integer
    '    Dim KataloskiBroj As String
    '    Dim KomisioniMagacin As String

    '    Cursor = Cursors.WaitCursor

    '    rsMag = GetData("SELECT * FROM SifarnikMagacini WHERE VrstaArtikla=11")
    '    If rsMag.Rows.Count > 1 Then
    '        For n = 0 To rsMag.Rows.Count - 1
    '            KomisioniMagacin = SifarnikMagacina.Trazi("Sifra=" & rsMag.Rows(n)!Sifra)(0)!Naziv.ToString

    '            rsOtp = GetData("SELECT * FROM OtpremnicaStavke WHERE BrojOtpremnice=" & txtBroj.Text & " AND Magacin=" & TxtSifraMagacina.Text _
    '                 & " AND Godina=" & Godina & " AND Odjava='False' AND PredhodniMagacin=" & rsMag.Rows(n)!Sifra)

    '            If rsOtp.Rows.Count = 0 Then
    '                Cursor = Cursors.Default
    '                MsgBox("U otpremnici nema artikala za Odjavu iz" & vbCrLf & vbCrLf & KomisioniMagacin, MsgBoxStyle.Exclamation)

    '            Else
    '                If MsgBox("Da li formirate pojedinačnu Odjavu za" & vbCrLf & vbCrLf & KomisioniMagacin, vbQuestion + vbYesNo, "Odjava") = vbYes Then
    '                    rsOdjava = GetData("SELECT MAX(Broj) AS Novi FROM Odjava WHERE Godina=" & Godina & " And Magacin=" & rsMag.Rows(n)!Sifra)
    '                    If rsOdjava.Rows.Count = 0 Or IsDBNull(rsOdjava.Rows(0)!Novi) Then
    '                        BrojOdjave = "1"
    '                    Else
    '                        BrojOdjave = rsOdjava.Rows(0)!Novi + 1
    '                    End If

    '                    InsertData("INSERT INTO Odjava VALUES(" & rsMag.Rows(n)!Sifra & "," & BrojOdjave & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
    '                   & "'," & CLng(rsMag.Rows(n)!Oznaka) & "," & txtBroj.Text & "," & TxtSifraMagacina.Text & ",'','','False','" & TimeOfDay & "'," & Godina & "," & UserID & ")")

    '                    Rbr = 1
    '                    For m = 0 To rsOtp.Rows.Count - 1
    '                        KataloskiBroj = SifarnikArtikala.Trazi("Sifra=" & rsOtp.Rows(m)!SifraArtikla)(0)!KataloskiBroj.ToString

    '                        InsertData("INSERT INTO OdjavaStavke VALUES(" & rsMag.Rows(n)!Sifra & "," & BrojOdjave & "," & Rbr & ",0," & rsOtp.Rows(m)!SifraArtikla _
    '                                   & ",'" & KataloskiBroj & "','" & rsOtp.Rows(m)!NazivArtikla & "','','" & rsOtp.Rows(m)!JedinicaMere _
    '                                   & "'," & FormatNumber(rsOtp(m)!Kolicina, 2,,, TriState.False) & ",0," & Godina & ")")

    '                        Rbr += 1
    '                        InsertData("UPDATE OtpremnicaStavke SET Odjava='True' WHERE BrojOtpremnice =" & txtBroj.Text & " AND Magacin=" & TxtSifraMagacina.Text _
    '                                    & " AND Godina=" & Godina & " AND SifraArtikla=" & rsOtp.Rows(m)!SifraArtikla & "  AND PredhodniMagacin=" & rsMag.Rows(n)!Sifra)
    '                        InsertData("UPDATE OtpremnicaStavke SET BrojOdjave=" & BrojOdjave & " WHERE BrojOtpremnice =" & txtBroj.Text & " AND Magacin=" & TxtSifraMagacina.Text _
    '                                    & " AND Godina=" & Godina & " AND SifraArtikla=" & rsOtp.Rows(m)!SifraArtikla & "  AND PredhodniMagacin=" & rsMag.Rows(n)!Sifra)

    '                    Next

    '                    Cursor = Cursors.Default

    '                    Parametri.Broj = BrojOdjave
    '                    TekuciMagacin = rsMag.Rows(n)!Sifra
    '                    DocStatus = "Odjava"
    '                    FrmOdjava.Dispose()
    '                    Hide()
    '                    FrmOdjava.ShowDialog()
    '                    Show()

    '                    DocStatus = "Otpremnica"
    '                    TekuciMagacin = TxtSifraMagacina.Text

    '                    'MsgBox("Formirana je Odjava broj:  " & BrojOdjave & " za" & vbCrLf & KomisioniMagacin, MsgBoxStyle.Exclamation)
    '                    rsOdjava.Dispose()

    '                Else
    '                    rsOdjavaK = GetData("SELECT * FROM Odjava WHERE Knjizeno='False' AND Magacin=" & rsMag.Rows(n)!Sifra)
    '                    If rsOdjavaK.Rows.Count > 1 Then
    '                        MsgBox("Imate više neproknjiženih Odjava za " & KomisioniMagacin, MsgBoxStyle.Exclamation)
    '                        Cursor = Cursors.Default
    '                        Exit Sub
    '                    End If

    '                    If rsOdjavaK.Rows.Count = 1 Then
    '                        BrojOdjave = rsOdjavaK.Rows(0)!Broj
    '                        rsRbr = GetData("SELECT MAX(Rbr) AS Novi FROM OdjavaStavke WHERE BrojOdjave=" & BrojOdjave & " AND Godina=" & Godina & " AND Magacin=" & rsMag.Rows(n)!Sifra)
    '                        Rbr = rsRbr.Rows(0)!Novi + 1

    '                        For m = 0 To rsOtp.Rows.Count - 1
    '                            KataloskiBroj = SifarnikArtikala.Trazi("Sifra=" & rsOtp.Rows(m)!SifraArtikla)(0)!KataloskiBroj.ToString
    '                            InsertData("INSERT INTO OdjavaStavke VALUES(" & rsMag.Rows(n)!Sifra & ", " & BrojOdjave & ", " & Rbr & ", 0, " & rsOtp.Rows(m)!SifraArtikla _
    '                                       & ",'" & KataloskiBroj & "','" & rsOtp.Rows(m)!NazivArtikla & "','','" & rsOtp.Rows(m)!JedinicaMere _
    '                                       & "'," & FormatNumber(rsOtp(m)!Kolicina, 2,,, TriState.False) & ",0," & Godina & ")")

    '                            Rbr += 1
    '                            InsertData("UPDATE OtpremnicaStavke SET Odjava='True' WHERE BrojOtpremnice =" & txtBroj.Text & " AND Magacin=" & TxtSifraMagacina.Text _
    '                                    & " AND Godina=" & Godina & " AND SifraArtikla=" & rsOtp.Rows(m)!SifraArtikla & "  AND PredhodniMagacin=" & rsMag.Rows(n)!Sifra)
    '                            InsertData("UPDATE OtpremnicaStavke SET BrojOdjave=" & BrojOdjave & " WHERE BrojOtpremnice =" & txtBroj.Text & " AND Magacin=" & TxtSifraMagacina.Text _
    '                                    & " AND Godina=" & Godina & " AND SifraArtikla=" & rsOtp.Rows(m)!SifraArtikla & "  AND PredhodniMagacin=" & rsMag.Rows(n)!Sifra)

    '                        Next

    '                    Else
    '                        rsOdjava = GetData("SELECT MAX(Broj) AS Novi FROM Odjava WHERE Godina=" & Godina & " And Magacin=" & rsMag.Rows(n)!Sifra)
    '                        If rsOdjava.Rows.Count = 0 Or IsDBNull(rsOdjava.Rows(0)!Novi) Then
    '                            BrojOdjave = "1"
    '                        Else
    '                            BrojOdjave = rsOdjava.Rows(0)!Novi + 1
    '                        End If

    '                        InsertData("INSERT INTO Odjava VALUES(" & rsMag.Rows(n)!Sifra & "," & BrojOdjave & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
    '                                    & "'," & CLng(rsMag.Rows(n)!Oznaka) & "," & txtBroj.Text & "," & TxtSifraMagacina.Text & ",'','','False','" & TimeOfDay & "'," & Godina & "," & UserID & ")")

    '                        Rbr = 1
    '                        For m = 0 To rsOtp.Rows.Count - 1
    '                            KataloskiBroj = SifarnikArtikala.Trazi("Sifra=" & rsOtp.Rows(m)!SifraArtikla)(0)!KataloskiBroj.ToString
    '                            InsertData("INSERT INTO OdjavaStavke VALUES(" & rsMag.Rows(n)!Sifra & "," & BrojOdjave & "," & Rbr & ",0," & rsOtp.Rows(m)!SifraArtikla _
    '                                   & ",'" & KataloskiBroj & "','" & rsOtp.Rows(m)!NazivArtikla & "','','" & rsOtp.Rows(n)!JedinicaMere _
    '                                   & "'," & FormatNumber(rsOtp(m)!Kolicina, 2,,, TriState.False) & ",0," & Godina & ")")

    '                            Rbr += 1
    '                            InsertData("UPDATE OtpremnicaStavke SET Odjava='True' WHERE BrojOtpremnice =" & txtBroj.Text & " AND Magacin=" & TxtSifraMagacina.Text _
    '                                    & " AND Godina=" & Godina & " AND SifraArtikla=" & rsOtp.Rows(m)!SifraArtikla & "  AND PredhodniMagacin=" & rsMag.Rows(n)!Sifra)
    '                            InsertData("UPDATE OtpremnicaStavke SET BrojOdjave=" & BrojOdjave & " WHERE BrojOtpremnice =" & txtBroj.Text & " AND Magacin=" & TxtSifraMagacina.Text _
    '                                    & " AND Godina=" & Godina & " AND SifraArtikla=" & rsOtp.Rows(m)!SifraArtikla & "  AND PredhodniMagacin=" & rsMag.Rows(n)!Sifra)

    '                        Next

    '                    End If

    '                    Cursor = Cursors.Default
    '                    MsgBox("Formirana je Odjava broj: " & BrojOdjave & " za " & vbCrLf & vbCrLf & KomisioniMagacin, MsgBoxStyle.Exclamation)

    '                End If
    '            End If
    '        Next
    '    End If

    '    DajStavkeOtpremnice(txtBroj.Text)

    'End Sub
    Private Sub cmdKnjizenje_Click(sender As Object, e As EventArgs) Handles cmdKnjizenje.Click
        Dim rs As DataTable
        Dim Zaliha As Double
        Dim UMagacinu As Boolean = True

        If Parametri.PravoPristupa >= 2 Then
            If Godina <> TekucaGodina Then
                If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If

            If chkKnjizeno.Checked Then
                MsgBox("Dokument je već proknjižen!", vbExclamation, "OTPREMNICA")
                Cursor = Cursors.Default
                Exit Sub
            Else
                If MsgBox("Knjiženje?" & vbCrLf & vbCrLf & "Nastavljate?", vbQuestion + vbYesNo, "OTPREMNICA") = vbYes Then
                    Cursor = Cursors.WaitCursor

                    For n = 0 To rsStavke.Rows.Count - 1
                        rs = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & rsStavke.Rows(n)!SifraArtikla & " AND BarCod=''")
                        If rs.Rows.Count = 0 Then
                            MsgBox("Artikal sa šifrom " & rsStavke.Rows(n)!SifraArtikla & vbCrLf & "se ne nalazi u magacinu!", MsgBoxStyle.Exclamation)
                            Cursor = Cursors.Default
                            UMagacinu = False
                        End If
                    Next

                    If UMagacinu = False Then Exit Sub

                    ProveraStanja(txtBroj.Text, TekuciMagacin, rsStavke)
                    If Manjak Then
                        If MsgBox("Nema dovoljne količine na stanju!" & vbCrLf & vbCrLf & "Da li želite da vidite izveštaj?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                        Cursor = Cursors.Default
                        FrmIzvestajStanja.ShowDialog()
                        Cursor = Cursors.Default
                        Exit Sub
                    End If

                    For n = 0 To rsStavke.Rows.Count - 1
                        rs = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & rsStavke.Rows(n)!SifraArtikla & " AND BarCod=''")

                        Zaliha = (rs.Rows(0)!Zaliha - rsStavke.Rows(n)!Kolicina)
                        InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & rsStavke.Rows(n)!SifraArtikla & " AND BarCod=''")

                    Next

                    Cursor = Cursors.Default
                    InsertData("UPDATE Otpremnica SET Knjizeno = 'True' WHERE Godina=" & Godina & " AND Broj=" & CLng(txtBroj.Text) & " AND Magacin=" & TekuciMagacin)
                    InsertData("UPDATE Otpremnica SET Vreme = '" & TimeOfDay & "' WHERE Godina=" & Godina & " AND Broj=" & CLng(txtBroj.Text) & " AND Magacin=" & TekuciMagacin)

                    InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','Knjizenje','" & DocStatus & "'," & txtBroj.Text & ",'" & txtNazivKupca.Text & "')")

                    'pnlOK.Visible = True
                    'tmrDelay.Enabled = True

                    chkKnjizeno.Checked = True

                    Cursor = Cursors.Default
                Else
                    Cursor = Cursors.Default
                    Exit Sub
                End If
            End If
        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
            Exit Sub
        End If

    End Sub
    'Private Sub CmdFaktura_Click(sender As Object, e As EventArgs)

    '    'If Not chkKnjizeno.Checked Then
    '    '    MsgBox("Morate prvo proknjižiti dokument!", MsgBoxStyle.Exclamation)
    '    '    Exit Sub
    '    'End If

    '    If chkRacunUradjen.Checked Then
    '        'MsgBox("Otpremnica je fakturisana!", MsgBoxStyle.Exclamation)
    '        If ChkIzvoz.Checked Then
    '            Parametri.Poreklo = 2
    '        Else
    '            If ChkGratis.Checked Then
    '                Parametri.Poreklo = 3
    '            Else
    '                Parametri.Poreklo = 1
    '            End If
    '        End If
    '        Select Case Parametri.Poreklo
    '            Case 1
    '                Parametri.Broj = txtBrojRacuna.Text
    '                DocStatus = "RacunDomaci"
    '                FrmRacunDomaci.Dispose()
    '                Hide()
    '                FrmRacunDomaci.ShowDialog()
    '                Show()
    '            Case 2

    '            Case 3

    '        End Select
    '        DocStatus = "Otpremnica"
    '        Exit Sub
    '    End If

    '    SifarnikPoreskihStatusa = New Sifarnik
    '    SifarnikPoreskihStatusa.Puni("Select * FROM SifarnikPoreskihStatusa WHERE Izlazni='True' AND Pasivan='False' ORDER BY Sifra")

    '    If ChkIzvoz.Checked Then
    '        Parametri.Poreklo = 2
    '        Parametri.PoreskiStatus = PoreskiStatusIzvozneFakture
    '        InsertData("UPDATE Otpremnica SET Izvoz='True' WHERE Broj=" & CLng(txtBroj.Text) & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
    '    ElseIf ChkGratis.Checked Then
    '        Parametri.Poreklo = 3
    '        Parametri.PoreskiStatus = PoreskiStatusDomaceFakture
    '    Else
    '        Parametri.Poreklo = 1
    '        Parametri.PoreskiStatus = PoreskiStatusDomaceFakture
    '    End If
    '    PDV = SifarnikPoreskihStopa.Trazi("Sifra=" & (SifarnikPoreskihStatusa.Trazi("Sifra=" & Parametri.PoreskiStatus)(0)!SifraPoreskeStope))(0)!Stopa.ToString

    '    Faktura(txtBroj.Text)

    '    chkRacunUradjen.Checked = True

    '    InsertData("UPDATE Otpremnica SET BrojRacuna=" & BrojRacuna & " WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
    '                   & Godina & " AND Magacin=" & TekuciMagacin)
    '    InsertData("UPDATE Otpremnica SET RacunUradjen='true' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
    '                   & Godina & " AND Magacin=" & TekuciMagacin)

    '    InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
    '                           & "','Faktura iz otpremnice','" & DocStatus & "'," & txtBroj.Text & ",'" & txtNazivKupca.Text & "')")

    '    txtBrojRacuna.Text = BrojRacuna

    'End Sub
    Private Sub cmdStampa_Click(sender As Object, e As EventArgs)

        'Cursor = Cursors.WaitCursor

        'InsertData("UPDATE Parametri SET Broj=" & CLng(txtBroj.Text))
        'InsertData("UPDATE Parametri SET Magacin=" & TekuciMagacin)
        'InsertData("UPDATE Parametri SET Godina=" & Godina)

        'Parametri.NazivIzvestaja = "Otpremnica.rpt"

        'FrmPreView.ShowDialog()

        'Cursor = Cursors.Default
    End Sub
    Private Sub cmdIzlaz_Click(sender As Object, e As EventArgs)
        'Parametri.Novi = False
        Odustajanje()
        Close()
    End Sub


#End Region


#Region "Novi dizajn"
    Private Sub PnlRbr_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
        Dim pnl = TryCast(sender, Panel)
        Dim g = e.Graphics
        Dim Cetkica = New SolidBrush(Color.FromArgb(40, 80, 130))
        Dim rr As New Rectangle
        rr.X = 0
        rr.Y = 0
        rr.Width = pnl.Width
        rr.Height = pnl.Height

        FillRoundedRectangle(g, Cetkica, rr, 5)
    End Sub
    Public Shared Function RoundedRect(ByVal bounds As Rectangle, ByVal radius As Integer) As GraphicsPath
        Dim diameter As Integer = radius * 2
        Dim size As Size = New Size(diameter, diameter)
        Dim arc As Rectangle = New Rectangle(bounds.Location, size)
        Dim path As GraphicsPath = New GraphicsPath()

        If radius = 0 Then
            path.AddRectangle(bounds)
            Return path
        End If

        path.AddArc(arc, 180, 90)
        arc.X = bounds.Right - diameter
        path.AddArc(arc, 270, 90)
        arc.Y = bounds.Bottom - diameter
        path.AddArc(arc, 0, 90)
        arc.X = bounds.Left
        path.AddArc(arc, 90, 90)
        path.CloseFigure()
        Return path
    End Function
    Public Shared Sub FillRoundedRectangle(ByVal graphics As Graphics, ByVal brush As Brush, ByVal bounds As Rectangle, ByVal cornerRadius As Integer)
        If graphics Is Nothing Then Throw New ArgumentNullException("graphics")
        If brush Is Nothing Then Throw New ArgumentNullException("brush")

        Using path As GraphicsPath = RoundedRect(bounds, cornerRadius)
            graphics.FillPath(brush, path)
        End Using
    End Sub
    Private Sub txtNapomena_DoubleClick(sender As Object, e As EventArgs) Handles txtNapomena.DoubleClick, TxtDestinacija.DoubleClick, txtVozilo.DoubleClick, TxtRobuIzdao.DoubleClick
        Dim tb = TryCast(sender, TextBox)
        tb.ReadOnly = False
    End Sub




#End Region


End Class