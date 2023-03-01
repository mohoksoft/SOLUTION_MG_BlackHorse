Imports System.Drawing.Drawing2D

Public Class frmPrijemnica
    Dim rsPrijemnica As DataTable
    Dim rsStavke As DataTable
    Dim EditStavke As Boolean
    Dim BrojKalkulacije As Integer
    Dim Uvecanje As Double
    Dim Selected As Boolean
    Dim SelektovanaKolona As String
    Dim parametriPrijemnica As paramet


#Region "FORMA"
    Private Sub frmPrijemnica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lFont As Font

        lFont = New Font("Calibri", 11, FontStyle.Bold, GraphicsUnit.Point)
        grdStavke.ColumnHeadersDefaultCellStyle.Font = lFont
        lFont = New Font("Verdana", 9.75, FontStyle.Regular, GraphicsUnit.Point)
        grdStavke.RowsDefaultCellStyle.Font = lFont

        grdStavke.EnableHeadersVisualStyles = False
        grdStavke.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 109, 122)
        grdStavke.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(241, 246, 248)

        SifarnikMagacina.KontrolaZaPrikaz = CmbMagacin
        SifarnikMagacina.PuniKontrolu()
        CmbMagacin.SelectedValue = TekuciMagacin
        TxtSifraMagacina.Text = CmbMagacin.SelectedValue

        'LblMagacin.Text = CmbMagacin.Text

        DobavljaciAktivni.Puni()
        GridZaListuKomitenta(grdLista, DobavljaciAktivni)
        DobavljaciAktivni.DajSve()

        ArtikliStavke.Puni()
        GridZaListuStavkiArtikala(GrdListaStavki)
        ArtikliStavke.DajSve()

        If Parametri.Novi Then
            Novi()
        Else
            rsPrijemnica = GetData("SELECT * FROM Prijemnica WHERE Broj=" & Parametri.Broj & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
            TxtSifraMagacina.Text = rsPrijemnica.Rows(0)!Magacin
            txtBroj.Text = rsPrijemnica.Rows(0)!Broj

            chkKnjizeno.Checked = rsPrijemnica.Rows(0)!Knjizeno
            chkKalkulacija.Checked = rsPrijemnica.Rows(0)!Kalkulacija
            txtBrojKalkulacije.Text = rsPrijemnica.Rows(0)!BrojKalkulacije
            dtpDatum.Value = rsPrijemnica.Rows(0)!Datum
            txtSifraDobavljaca.Text = rsPrijemnica.Rows(0)!Dobavljac
            txtNazivDobavljaca.Text = Dobavljaci.Trazi("Sifra=" & rsPrijemnica.Rows(0)!Dobavljac)(0)!Naziv.ToString
            txtBrojUlaznogDokumenta.Text = rsPrijemnica.Rows(0)!BrojUlaznogDokumenta.ToString
            dtpDatumUlaza.Value = rsPrijemnica.Rows(0)!DatumUlaznogDokumenta
            txtPrevoznik.Text = rsPrijemnica.Rows(0)!Prevoznik.ToString
            txtVozilo.Text = rsPrijemnica.Rows(0)!Vozilo.ToString
            txtNapomena.Text = rsPrijemnica.Rows(0)!Napomena.ToString

            ChkMaloprodaja.Checked = rsPrijemnica.Rows(0)!Maloprodaja
            ChkVeleprodaja.Checked = rsPrijemnica.Rows(0)!Veleprodaja
            ChkUvoz.Checked = rsPrijemnica.Rows(0)!Uvoz

            DajStavkePrijemnice(txtBroj.Text)

            txtNazivDobavljaca.Select()
        End If

        grdLista.Visible = False
        GrdListaStavki.Visible = False

    End Sub
    Private Sub frmPrijemnica_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim rs As DataTable

        If Parametri.Novi = False Then
            rs = GetData("SELECT * FROM PrijemnicaStavke WHERE BrojPrijemnice=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
            If rs.Rows.Count = 0 Then
                Cursor = Cursors.Default
                MsgBox("Dokument nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
        End If

    End Sub
    Private Sub frmPrijemnica_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Parametri.Novi = False

    End Sub

#End Region


#Region "TXT zaglavlje"
    Private Sub txtNazivDobavljaca_TextChanged(sender As Object, e As EventArgs) Handles txtNazivDobavljaca.TextChanged

        If txtNazivDobavljaca.Text = "" Then
            txtSifraDobavljaca.Text = ""
            grdLista.Visible = False
        Else
            grdLista.Visible = True
            DobavljaciAktivni.Trazi(txtNazivDobavljaca.Text, True, SelektovanaKolona)
        End If
    End Sub
    Private Sub txtNazivDobavljaca_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNazivDobavljaca.KeyDown

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

            txtSifraDobavljaca.Text = grdLista.SelectedRows(0).Cells("Sifra").Value
            txtNazivDobavljaca.Text = grdLista.SelectedRows(0).Cells("Naziv").Value
            grdLista.Visible = False

            txtBrojUlaznogDokumenta.Select()

        End If
    End Sub
    Private Sub grdLista_KeyDown(sender As Object, e As KeyEventArgs) Handles grdLista.KeyDown
        If grdLista.SelectedRows.Count > 0 Then
            If e.KeyCode = Keys.Enter Then
                Dim sifra As String = grdLista.SelectedRows(0).Cells("Sifra").Value
                Dim naziv As String = grdLista.SelectedRows(0).Cells("Naziv").Value
                Dim destinacija As String = grdLista.SelectedRows(0).Cells("Destinacija").Value
                txtSifraDobavljaca.Text = sifra
                txtNazivDobavljaca.Text = naziv
                grdLista.Visible = False

                txtBrojUlaznogDokumenta.Select()

            End If
        End If
    End Sub
    Private Sub txtBrojUlaznogDokumenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBrojUlaznogDokumenta.KeyDown
        Dim rs As DataTable

        If e.KeyCode = Keys.Enter Then
            If txtBrojUlaznogDokumenta.Text = "" Then
                MsgBox("Niste uneli broj ulaznog dokumenta dobavljaca!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            rs = GetData("SELECT * FROM Prijemnica WHERE Dobavljac=" & CLng(txtSifraDobavljaca.Text) & " AND BrojUlaznogDokumenta='" & txtBrojUlaznogDokumenta.Text & "' AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
            If rs.Rows.Count > 0 Then
                MsgBox("Za izabranog dobavljača već postoji ulazni dokument sa ovim brojem!", MsgBoxStyle.Exclamation)
                txtBrojUlaznogDokumenta.Select()
                Exit Sub
            End If
            txtBrojUlaznogDokumenta.ReadOnly = True
            dtpDatumUlaza.Select()
        End If


    End Sub
    Private Sub dtpDatumUlaza_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpDatumUlaza.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsDate(dtpDatumUlaza.Text) = False Then
                MsgBox("Pogrešno unet format datuma!", MsgBoxStyle.Exclamation)
                dtpDatumUlaza.Select()
                Exit Sub
            End If
            txtPrevoznik.ReadOnly = False
            txtPrevoznik.Select()
        End If
    End Sub
    Private Sub txtPrevoznik_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPrevoznik.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPrevoznik.ReadOnly = True
            txtVozilo.ReadOnly = False
            txtVozilo.Select()
        End If
    End Sub
    Private Sub txtVozilo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVozilo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtVozilo.ReadOnly = True
            txtNapomena.ReadOnly = False
            txtNapomena.Select()
        End If
    End Sub
    Private Sub txtNapomena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNapomena.KeyDown
        If e.KeyCode = Keys.Enter Then TxtNazivArtikla.Select()
    End Sub

    Private Sub ChkVeleprodaja_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVeleprodaja.CheckedChanged

        If ChkVeleprodaja.Checked Then
            ChkUvoz.Checked = False
        Else
            ChkUvoz.Checked = True
        End If

    End Sub
    Private Sub ChkUvoz_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUvoz.CheckedChanged

        If ChkUvoz.Checked Then
            ChkVeleprodaja.Checked = False
        Else
            ChkVeleprodaja.Checked = True
        End If

    End Sub

#End Region


#Region "TXT stavke"
    Private Sub TxtNazivArtikla_TextChanged(sender As Object, e As EventArgs) Handles TxtNazivArtikla.TextChanged

        If TxtNazivArtikla.Text = "" Then
            txtSifraArtikla.Text = ""
            txtJM.Text = ""
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

                GrdListaStavki.Visible = False

                txtKolicina.Select()

            End If
        End If
    End Sub
    Private Sub txtKolicina_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKolicina.KeyDown
        Dim rs As DataTable
        Dim rsR As DataTable
        Dim rsZaliha As DataTable
        Dim Rbr As Integer
        Dim Zaliha As Double
        Dim NabavnaCena As Double, ProdajnaCena As Double, Stanje As Double

        If e.KeyCode = Keys.Enter Then
            If Parametri.PravoPristupa >= 2 Then
                If Godina <> TekucaGodina Then
                    If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                End If

                If chkKnjizeno.Checked Then
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
                    rs = GetData("SELECT * FROM PrijemnicaStavke WHERE SifraArtikla=" & txtSifraArtikla.Text & " AND BrojPrijemnice=" & MinusID _
                                 & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                    If rs.Rows.Count > 0 Then
                        If MsgBox("Unosite artikal koji već postoji u ovoj prijemnici!" & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                    End If
                    rs.Dispose()

                    rsR = GetData("SELECT MAX(Rbr) AS Novi FROM PrijemnicaStavke WHERE BrojPrijemnice=" & MinusID _
                              & " And Godina=" & Godina & " And Magacin=" & TekuciMagacin)
                    If IsDBNull(rsR.Rows(0)!Novi) Or (rsR.Rows.Count = 0) Then
                        Rbr = 1
                    Else
                        Rbr = rsR.Rows(0)!Novi + 1
                    End If

                    InsertData("INSERT INTO PrijemnicaStavke VALUES(" & TekuciMagacin & "," & MinusID & "," & Rbr & ",0," & CLng(txtSifraArtikla.Text) _
                           & ",'" & TxtNazivArtikla.Text & "','','" & txtJM.Text & "'," & FormatNumber(CDbl(Stanje), 4,,, TriState.False) & "," & FormatNumber(NabavnaCena, 4,,, TriState.True) _
                           & "," & FormatNumber(CDbl(ProdajnaCena), 4,,, TriState.False) & "," & FormatNumber(CDbl(txtKolicina.Text), 4,,, TriState.False) & "," & Godina & ")")

                    DajStavkePrijemnice(MinusID)
                Else
                    rs = GetData("SELECT * FROM PrijemnicaStavke WHERE SifraArtikla=" & txtSifraArtikla.Text & " AND BrojPrijemnice=" & CLng(txtBroj.Text) _
                                 & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                    If rs.Rows.Count > 0 Then
                        If MsgBox("Unosite artikal koji već postoji u ovoj prijemnici!" & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                    End If
                    rs.Dispose()

                    rsR = GetData("SELECT MAX(Rbr) AS Novi FROM PrijemnicaStavke WHERE BrojPrijemnice=" & CLng(txtBroj.Text) _
                              & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                    If IsDBNull(rsR.Rows(0)!Novi) Or (rsR.Rows.Count = 0) Then
                        Rbr = 1
                    Else
                        Rbr = rsR.Rows(0)!Novi + 1
                    End If

                    InsertData("INSERT INTO PrijemnicaStavke VALUES(" & TekuciMagacin & "," & CLng(txtBroj.Text) & "," & Rbr & ",0," & CLng(txtSifraArtikla.Text) _
                           & ",'" & TxtNazivArtikla.Text & "','','" & txtJM.Text & "'" & FormatNumber(CDbl(Stanje), 4,,, TriState.False) & "," & FormatNumber(NabavnaCena, 4,,, TriState.True) _
                           & "," & FormatNumber(CDbl(ProdajnaCena), 4,,, TriState.False) & "," & FormatNumber(CDbl(txtKolicina.Text), 4,,, TriState.False) & "," & Godina & ")")


                    '***knjizenje u zalihama stavke koja se dodaje u proknjizenom dokumentu
                    If chkKnjizeno.Checked Then
                        rsZaliha = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & txtSifraArtikla.Text & " AND BarCod=''")
                        If rsZaliha.Rows.Count = 0 Then
                            InsertData("INSERT INTO Zaliha VALUES(" & TekuciMagacin & "," & CLng(txtSifraArtikla.Text) & ",''," & FormatNumber(CDbl(txtKolicina.Text), 4,,, TriState.False) & ",0)")
                        Else
                            Zaliha = (rsZaliha.Rows(0)!Zaliha + CDbl(txtKolicina.Text))
                            InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & txtSifraArtikla.Text & " AND BarCod=''")
                        End If

                        InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Dodavanje u proknjizenoj','" & DocStatus & "'," & txtBroj.Text & ",'" & TxtNazivArtikla.Text & "')")

                    End If

                    ''***dodavanje stavke u kalkulaciju
                    'If chkKalkulacija.Checked Then
                    '    InsertData("INSERT INTO KalkulacijaStavke VALUES(" & TekuciMagacin & ", " & CInt(txtBrojKalkulacije.Text) & ", " & Rbr & ",0," & CLng(txtSifraArtikla.Text) _
                    '                & ",'" & TxtNazivArtikla.Text & "','" & txtJM.Text & "'," & FormatNumber(CDbl(txtKolicina.Text), 4,,, TriState.False) _
                    '                & ",0,0,0,0,0,0,0,0," & SifarnikArtikala.Trazi("Sifra=" & txtSifraArtikla.Text)(0)!PoreskaStopa & ",0,0,0,0,0,0,0,0," & Godina & ")")

                    '    InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                    '       & "','Dodavanje u kalkulaciju iz','" & DocStatus & "'," & txtBroj.Text & ",'" & txtSifraArtikla.Text & "')")

                    'End If
                    DajStavkePrijemnice(txtBroj.Text)
                End If


                txtSifraArtikla.Text = ""
                TxtNazivArtikla.Text = ""
                'txtBarCod.Text = ""
                txtJM.Text = ""
                txtKolicina.Text = ""
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
    Private Sub grdStavke_KeyDown(sender As Object, e As KeyEventArgs) Handles grdStavke.KeyDown
        Dim rs As DataTable
        Dim rsKalkulacija As DataTable
        Dim rsZaliha As DataTable
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
                            InsertData("DELETE FROM PrijemnicaStavke WHERE BrojPrijemnice=" & MinusID & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                        & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)
                        End If
                    Next

                    'AzurirajRbr(Parametri.RBR, MinusID)
                    DajStavkePrijemnice(MinusID)
                Else
                    rs = GetData("SELECT * FROM PrijemnicaStavke WHERE BrojPrijemnice=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                    If rs.Rows.Count = 1 Then
                        Cursor = Cursors.Default
                        MsgBox("Ne možete brisati jedinu stavku u dokumentu!", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If

                    For n = 0 To grdStavke.RowCount - 1
                        Cursor = Cursors.WaitCursor
                        If grdStavke.Rows(n).Selected Then
                            InsertData("DELETE FROM PrijemnicaStavke WHERE BrojPrijemnice=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                        & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)

                            'knjizenje u zalihama stavke koja se brise u proknjizenom dokumentu
                            If chkKnjizeno.Checked Then
                                rsZaliha = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND BarCod=''")
                                Zaliha = (rsZaliha.Rows(0)!Zaliha - grdStavke.Rows(n).Cells("Kolicina").Value)
                                InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin _
                                           & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND BarCod=''")

                                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                           & "','Brisanje u proknjizenoj','" & DocStatus & "'," & txtBroj.Text & ",'" & grdStavke.Rows(n).Cells("SifraArtikla").Value & "')")
                            End If

                            'brisanje stavke u kalkulaciji
                            If chkKalkulacija.Checked Then
                                If IsNumeric(txtBrojKalkulacije.Text) Then
                                    rsKalkulacija = GetData("SELECT * FROM KalkulacijaStavke WHERE BrojKalkulacije=" & CInt(txtBrojKalkulacije.Text) & " AND Godina=" & Godina _
                                                            & " AND Magacin=" & TekuciMagacin & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)

                                    If rsKalkulacija.Rows.Count = 1 Then
                                        InsertData("DELETE FROM KalkulacijaStavke WHERE BrojKalkulacije=" & CInt(txtBrojKalkulacije.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                                    & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)

                                        InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                                    & "','Brisanje u kalkulaciji iz','" & DocStatus & "'," & txtBroj.Text & ",'" & grdStavke.Rows(n).Cells("SifraArtikla").Value & "')")
                                    Else
                                        MsgBox("Artikal " & grdStavke.Rows(n).Cells("SifraArtikla").Value & vbCrLf & "nije obrisan u fakturi!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    MsgBox("Greška u broju kalkulacije!", MsgBoxStyle.Exclamation)
                                End If
                            End If
                        End If
                    Next

                    'AzurirajRbr(Parametri.RBR, txtBroj.Text)
                    DajStavkePrijemnice(txtBroj.Text)
                End If
            Else
                MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Cursor = Cursors.Default

        End If
    End Sub
    Private Sub grdStavke_MouseClick(sender As Object, e As MouseEventArgs) Handles grdStavke.MouseClick
        'Dim hit As DataGridView.HitTestInfo = grdStavke.HitTest(e.X, e.Y)

        'If hit.RowIndex > grdStavke.RowCount - 1 Or hit.RowIndex < 0 Then Exit Sub

        'If IsDBNull(grdStavke.Rows(hit.RowIndex).Cells(0).Value) Then Exit Sub

        'If e.Button = MouseButtons.Right Then
        '    For n = 0 To grdStavke.SelectedRows.Count - 1
        '        If n > grdStavke.SelectedRows.Count Then Exit For
        '        grdStavke.SelectedRows(n).Selected = False
        '    Next

        '    For n = 0 To grdStavke.SelectedCells.Count - 1
        '        If n > grdStavke.SelectedCells.Count - 1 Then Exit For
        '        grdStavke.SelectedCells(n).Selected = False
        '    Next

        '    Dim Kolona As Integer = 0
        '    If hit.ColumnIndex > -1 Then
        '        Kolona = grdStavke.Columns(hit.ColumnIndex).Name
        '    End If

        '    Parametri.Sortiranje = grdStavke.Columns(Kolona).Name
        '    grdStavke.Rows(hit.RowIndex).Selected = True
        '    grdStavke.Columns(Kolona).Selected = True
        '    mnuPrijemnica.Show(grdStavke, e.X, e.Y)
        'End If

        GridDesniKlik(sender, e, mnuPrijemnica, grdStavke)
    End Sub

#End Region


#Region "MNU"
    Private Sub mnuBrisanje_Click(sender As Object, e As EventArgs) Handles mnuBrisanje.Click
        Dim rs As DataTable
        Dim rsKalkulacija As DataTable
        Dim rsZaliha As DataTable
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
                        InsertData("DELETE FROM PrijemnicaStavke WHERE BrojPrijemnice=" & MinusID & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                        & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)
                    End If
                Next

                'AzurirajRbr(Parametri.RBR, MinusID)
                DajStavkePrijemnice(MinusID)
            Else
                rs = GetData("SELECT * FROM PrijemnicaStavke WHERE BrojPrijemnice=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                If rs.Rows.Count = 1 Then
                    Cursor = Cursors.Default
                    MsgBox("Ne možete brisati jedinu stavku u dokumentu!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                For n = 0 To grdStavke.RowCount - 1
                    Cursor = Cursors.WaitCursor
                    If grdStavke.Rows(n).Selected Then
                        InsertData("DELETE FROM PrijemnicaStavke WHERE BrojPrijemnice=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                        & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)

                        'knjizenje u zalihama stavke koja se brise u proknjizenom dokumentu
                        If chkKnjizeno.Checked Then
                            rsZaliha = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND BarCod=''")
                            Zaliha = (rsZaliha.Rows(0)!Zaliha - grdStavke.Rows(n).Cells("Kolicina").Value)
                            InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin _
                                           & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND BarCod=''")

                            InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                           & "','Brisanje u proknjizenoj','" & DocStatus & "'," & txtBroj.Text & ",'" & grdStavke.Rows(n).Cells("SifraArtikla").Value & "')")
                        End If

                        'brisanje stavke u kalkulaciji
                        If chkKalkulacija.Checked Then
                            If IsNumeric(txtBrojKalkulacije.Text) Then
                                rsKalkulacija = GetData("SELECT * FROM KalkulacijaStavke WHERE BrojKalkulacije=" & CInt(txtBrojKalkulacije.Text) & " AND Godina=" & Godina _
                                                            & " AND Magacin=" & TekuciMagacin & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)

                                If rsKalkulacija.Rows.Count = 1 Then
                                    InsertData("DELETE FROM KalkulacijaStavke WHERE BrojKalkulacije=" & CInt(txtBrojKalkulacije.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                                    & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)

                                    InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                                    & "','Brisanje u kalkulaciji iz','" & DocStatus & "'," & txtBroj.Text & ",'" & grdStavke.Rows(n).Cells("SifraArtikla").Value & "')")
                                Else
                                    MsgBox("Artikal " & grdStavke.Rows(n).Cells("SifraArtikla").Value & vbCrLf & "nije obrisan u fakturi!", MsgBoxStyle.Exclamation)
                                End If
                            Else
                                MsgBox("Greška u broju kalkulacije!", MsgBoxStyle.Exclamation)
                            End If
                        End If
                    End If
                Next

                'AzurirajRbr(Parametri.RBR, txtBroj.Text)
                DajStavkePrijemnice(txtBroj.Text)
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
            DajStavkePrijemnice(txtBroj.Text)
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

        InsertData("DELETE FROM PrijemnicaStavke WHERE BrojPrijemnice=" & MinusID)

        txtBroj.Text = "0"
        TxtSifraMagacina.Text = TekuciMagacin

        If Godina <> TekucaGodina Then
            dtpDatum.Text = "31/12/" & Godina
            dtpDatumUlaza.Text = "31/12/" & Godina
        Else
            dtpDatum.Text = Format(Now, "dd/M/yyyy")
            dtpDatumUlaza.Text = Format(Now, "dd/M/yyyy")
        End If

        txtSifraDobavljaca.Text = ""
        txtNazivDobavljaca.Text = ""
        txtBrojUlaznogDokumenta.Text = ""
        txtPrevoznik.Text = ""
        txtVozilo.Text = ""
        txtNapomena.Text = ""
        txtBrojKalkulacije.Text = "0"

        txtSifraArtikla.Text = ""
        TxtNazivArtikla.Text = ""
        'txtBarCod.Text = ""
        txtJM.Text = ""
        txtKolicina.Text = ""

        chkKnjizeno.Checked = False
        chkKalkulacija.Checked = False

        grdStavke.DataSource = Nothing

        'cmdNovi.Enabled = False
        'cmdSnimi.Enabled = True
        'CmdKalkulacija.Enabled = False
        'cmdKnjizenje.Enabled = False
        'cmdStampa.Enabled = False

        txtNazivDobavljaca.Select()

    End Sub
    Sub Odustajanje()

        InsertData("DELETE FROM PrijemnicaStavke WHERE BrojPrijemnice=" & MinusID)

    End Sub
    Sub DajStavkePrijemnice(ByVal Broj As Long, Optional ByVal NoviDoc As Boolean = False)

        rsStavke = GetData("SELECT  PrijemnicaStavke.Rbr, PrijemnicaStavke.SifraArtikla, PrijemnicaStavke.NazivArtikla, " _
                            & "PrijemnicaStavke.JedinicaMere, PrijemnicaStavke.Kolicina, PrijemnicaStavke.ID  " _
                            & "FROM PrijemnicaStavke WHERE PrijemnicaStavke.Magacin=" & TekuciMagacin _
                            & "AND PrijemnicaStavke.BrojPrijemnice=" & Broj & " AND PrijemnicaStavke.Godina=" & Godina & " ORDER BY PrijemnicaStavke.Rbr")

        grdStavke.DataSource = Nothing
        grdStavke.DataSource = rsStavke

        grdStavke.Columns("Rbr").Width = 50
        grdStavke.Columns("SifraArtikla").Width = 70
        grdStavke.Columns("SifraArtikla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("SifraArtikla").HeaderText = "ŠIFRA"
        grdStavke.Columns("NazivArtikla").Width = 535
        grdStavke.Columns("NazivArtikla").HeaderText = "NAZIV ARTIKLA"
        grdStavke.Columns("NazivArtikla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'grdStavke.Columns("BarCod").Width = 170
        'grdStavke.Columns("BarCod").HeaderText = "Serijski broj"
        'grdStavke.Columns("BarCod").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("JedinicaMere").Width = 80
        grdStavke.Columns("JedinicaMere").HeaderText = "J.M."
        grdStavke.Columns("JedinicaMere").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdStavke.Columns("Kolicina").Width = 110
        grdStavke.Columns("Kolicina").HeaderText = "KOLIČINA"
        grdStavke.Columns("Kolicina").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("Kolicina").DefaultCellStyle.Format = "###,###,###,##0.0000"
        grdStavke.Columns("ID").Visible = False


    End Sub
    'Function Kalkulacija(Prijemnica As Integer) As Integer
    '    Dim rs As DataTable
    '    Dim rsS As DataTable
    '    'Dim rsCK As DataTable
    '    Dim rsA As DataTable
    '    Dim PDV As Integer
    '    'Dim VP As Double
    '    'Dim MP As Double

    '    Cursor = Cursors.WaitCursor

    '    rs = GetData("SELECT MAX(Broj) AS Novi FROM Kalkulacija WHERE Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
    '    If rs.Rows.Count = 0 Or IsDBNull(rs.Rows(0)!Novi) Then
    '        BrojKalkulacije = "1"
    '    Else
    '        BrojKalkulacije = rs.Rows(0)!Novi + 1
    '    End If

    '    If ChkUvoz.Checked Then
    '        PDV = SifarnikPoreskihStopa.Trazi("Sifra=" & PoreskiStatusUvozneKalkulacije)(0)!Stopa.ToString
    '        InsertData("INSERT INTO Kalkulacija VALUES(" & TekuciMagacin & "," & BrojKalkulacije & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
    '                   & "'," & CInt(txtSifraDobavljaca.Text) & ",'" & txtBrojUlaznogDokumenta.Text & "','" & Format(CDate(dtpDatumUlaza.Text), FormatDatuma) _
    '                   & "','" & Format(CDate(dtpDatumUlaza.Text), FormatDatuma) & "',0," & PDV & ",0,0,0,0,'" & txtNapomena.Text & "','" & Format(CDate(dtpDatumUlaza.Text), FormatDatuma) _
    '                   & "','false'," & Prijemnica & ",'EURO'," & FormatNumber(DajKurs("EURO"), 2,,, TriState.False) & ",'" & ChkMaloprodaja.Checked & "','" & ChkVeleprodaja.Checked _
    '                   & "','" & ChkUvoz.Checked & "'," & PoreskiStatusUvozneKalkulacije & ",'','',0,'" & TimeOfDay & "'," & Godina & "," & UserID & ")")
    '    Else
    '        PDV = SifarnikPoreskihStopa.Trazi("Sifra=" & PoreskiStatusKalkulacijeVeleprodaje)(0)!Stopa.ToString
    '        InsertData("INSERT INTO Kalkulacija VALUES(" & TekuciMagacin & "," & BrojKalkulacije & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
    '                   & "'," & CInt(txtSifraDobavljaca.Text) & ",'" & txtBrojUlaznogDokumenta.Text & "','" & Format(CDate(dtpDatumUlaza.Text), FormatDatuma) _
    '                   & "','" & Format(CDate(dtpDatumUlaza.Text), FormatDatuma) & "',0," & PDV & ",0,0,0,0,'" & txtNapomena.Text & "','" & Format(CDate(dtpDatumUlaza.Text), FormatDatuma) _
    '                   & "','false'," & Prijemnica & ",'EURO'," & FormatNumber(DajKurs("EURO"), 2,,, TriState.False) & ",'" & ChkMaloprodaja.Checked & "','" & ChkVeleprodaja.Checked _
    '                   & "','" & ChkUvoz.Checked & "'," & PoreskiStatusKalkulacijeVeleprodaje & ",'','',0,'" & TimeOfDay & "'," & Godina & "," & UserID & ")")
    '    End If


    '    rsS = GetData("SELECT * FROM PrijemnicaStavke WHERE BrojPrijemnice=" & Prijemnica & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)

    '    For n = 0 To rsS.Rows.Count - 1
    '        'rsCK = GetData("SELECT * FROM Cenovnik WHERE SifraArtikla=" & rsS.Rows(n)!SifraArtikla & " AND Magacin=" & TekuciMagacin & " AND Komitent=0")
    '        'If rsCK.Rows.Count > 0 Then
    '        '    VP = rsCK.Rows(0)!ProsecnaNabavnaCena
    '        '    MP = 0
    '        'Else
    '        '    VP = 0
    '        '    MP = 0
    '        'End If

    '        rsA = GetData("Select * FROM SifarnikArtikli WHERE Sifra=" & rsS.Rows(n)!SifraArtikla)

    '        InsertData("INSERT INTO KalkulacijaStavke VALUES(" & TekuciMagacin & ", " & BrojKalkulacije & ", " & rsS.Rows(n)!Rbr & ", " & rsS.Rows(n)!SifraRobneGrupe _
    '                   & ", " & rsS.Rows(n)!SifraArtikla & ",'" & rsS.Rows(n)!NazivArtikla & "','" & rsS.Rows(n)!JedinicaMere _
    '                   & "'," & FormatNumber(rsS.Rows(n)!Kolicina, 4,,, TriState.False) & ",0,0,0,0,0,0,0,0," & rsA.Rows(0)!PoreskaStopa _
    '                   & ",0,0,0,0,0,0,0,0," & Godina & ")")

    '    Next

    '    Cursor = Cursors.Default

    '    MsgBox("Formirana je kalkulacija broj: " & BrojKalkulacije, MsgBoxStyle.Exclamation)

    '    Return BrojKalkulacije

    'End Function
    Sub AzurirajRbr(Broj As Integer)
        Dim rs As DataTable

        rs = GetData("SELECT * FROM PrijemnicaStavke WHERE BrojPrijemnice=" & Broj & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin & " ORDER BY ID")

        For n = 0 To rs.Rows.Count - 1
            InsertData("UPDATE PrijemnicaStavke SET RBr=" & n + 1 & " WHERE BrojPrijemnice=" & Broj & " AND Godina=" & Godina _
                           & " AND ID=" & rs(n)!ID & " AND Magacin=" & TekuciMagacin)
        Next

    End Sub


    Private Sub tmrDelay_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrDelay.Tick
        'pnlOK.Visible = False

        'cmdNovi.Enabled = True
        'cmdSnimi.Enabled = True
        'CmdKalkulacija.Enabled = True
        'cmdKnjizenje.Enabled = True
        'cmdStampa.Enabled = True

        tmrDelay.Enabled = False
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

        If Parametri.PravoPristupa >= 2 Then
            If Godina <> TekucaGodina Then
                If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If

            If IsNumeric(txtSifraDobavljaca.Text) = False Then
                MsgBox("Morate uneti dobavljača!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If dtpDatum.Text = "" Or IsDate(dtpDatum.Text) = False Then
                MsgBox("Morate uneti datum!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If IsNumeric(TxtSifraMagacina.Text) = False Then
                MsgBox("Morate izabrati magacin za koji radite dokument!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor

            If Parametri.Novi Then
                rs = GetData("SELECT * FROM PrijemnicaStavke WHERE BrojPrijemnice=" & MinusID & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                If rs.Rows.Count = 0 Then
                    MsgBox("Ne možete da snimite dokument koji nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                    Cursor = Cursors.Default
                    Exit Sub
                End If
                rs.Dispose()

                rs = GetData("SELECT MAX(Broj) AS Novi FROM Prijemnica WHERE Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                If rs.Rows.Count = 0 Or IsDBNull(rs.Rows(0)!Novi) Then
                    txtBroj.Text = "1"
                Else
                    txtBroj.Text = rs.Rows(0)!Novi + 1
                End If

                InsertData("INSERT INTO Prijemnica VALUES(" & TekuciMagacin & "," & CLng(txtBroj.Text) & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
                           & "'," & CInt(txtSifraDobavljaca.Text) & ",'" & txtBrojUlaznogDokumenta.Text & "','" & Format(CDate(dtpDatumUlaza.Text), FormatDatuma) _
                           & "','',0,'" & txtPrevoznik.Text & "','" & txtVozilo.Text & "','" & txtNapomena.Text _
                           & "','" & ChkMaloprodaja.Checked & "','" & ChkVeleprodaja.Checked & "','" & ChkUvoz.Checked & "','False','','False',0,'" & TimeOfDay & "'," & Godina & "," & UserID & ")")

                InsertData("UPDATE PrijemnicaStavke SET BrojPrijemnice =" & CLng(txtBroj.Text) & " WHERE BrojPrijemnice =" & MinusID)

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','Novi dokument','" & DocStatus & "'," & txtBroj.Text & ",'" & txtBrojUlaznogDokumenta.Text & "')")

            Else
                If chkKnjizeno.Checked Then
                    If MsgBox("Snimanje proknjiženog dokumenta!" & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "PRIJEMNICA") = MsgBoxResult.No Then
                        Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If

                rs = GetData("SELECT * FROM PrijemnicaStavke WHERE BrojPrijemnice=" & CInt(txtBroj.Text) & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                If rs.Rows.Count = 0 Then
                    MsgBox("Ne možete da snimite dokument koji nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                    Cursor = Cursors.Default
                    Exit Sub
                End If
                rs.Dispose()

                If ChkMaloprodaja.Checked = False And ChkVeleprodaja.Checked = False And ChkUvoz.Checked = False Then
                    MsgBox("Morate izabrati vrstu prijemnice!", MsgBoxStyle.Exclamation)
                    Cursor = Cursors.Default
                    Exit Sub
                End If

                InsertData("UPDATE Prijemnica SET Dobavljac=" & CInt(txtSifraDobavljaca.Text) & " WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Prijemnica SET Datum='" & Format(CDate(dtpDatum.Text), FormatDatuma) & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Prijemnica SET DatumUlaznogDokumenta='" & Format(CDate(dtpDatumUlaza.Text), FormatDatuma) & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Prijemnica SET BrojUlaznogDokumenta='" & txtBrojUlaznogDokumenta.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Prijemnica SET Prevoznik='" & txtPrevoznik.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Prijemnica SET Vozilo='" & txtVozilo.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Prijemnica SET Napomena='" & txtNapomena.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)

                InsertData("UPDATE Prijemnica SET Maloprodaja='" & ChkMaloprodaja.Checked & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Prijemnica SET Veleprodaja='" & ChkVeleprodaja.Checked & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
                InsertData("UPDATE Prijemnica SET Uvoz='" & ChkUvoz.Checked & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)

                'update dobavljac i u kalkulaciji
                If chkKalkulacija.Checked Then
                    InsertData("UPDATE Kalkulacija SET Dobavljac=" & CInt(txtSifraDobavljaca.Text) & " WHERE Broj=" & CLng(txtBrojKalkulacije.Text) & " And Godina=" & Godina & " And Magacin=" & TekuciMagacin)
                End If

                For n = 0 To grdStavke.Rows.Count - 1
                    InsertData("UPDATE PrijemnicaStavke SET Kolicina=" & grdStavke.Rows(n).Cells("Kolicina").Value & " WHERE BrojPrijemnice=" & CInt(txtBroj.Text) _
                               & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value _
                               & " AND Rbr=" & grdStavke.Rows(n).Cells("Rbr").Value & " And Magacin=" & TekuciMagacin & " And Godina=" & Godina)

                    If chkKalkulacija.Checked Then
                        InsertData("UPDATE KalkulacijaStavke SET Kolicina=" & grdStavke.Rows(n).Cells("Kolicina").Value & " WHERE BrojKalkulacije=" & txtBrojKalkulacije.Text _
                                    & " And SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " And Rbr=" & grdStavke.Rows(n).Cells("Rbr").Value _
                                    & " And Magacin=" & TekuciMagacin & " And Godina=" & Godina)
                    End If
                Next


                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','Korekcija','" & DocStatus & "'," & txtBroj.Text & ",'" & txtBrojUlaznogDokumenta.Text & "')")

            End If

            Cursor = Cursors.Default

            'cmdNovi.Enabled = False
            'cmdSnimi.Enabled = False
            'cmdKnjizenje.Enabled = False
            'CmdKalkulacija.Enabled = False
            'cmdStampa.Enabled = False

            'pnlOK.Visible = True

            Parametri.Novi = False
            DajStavkePrijemnice(txtBroj.Text)
            tmrDelay.Enabled = True

            Cursor = Cursors.Default
        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Cursor = Cursors.Default

    End Sub
    Private Sub cmdKnjizenje_Click(sender As Object, e As EventArgs) Handles cmdKnjizenje.Click
        Dim rs As DataTable
        Dim Zaliha As Double

        If Parametri.PravoPristupa >= 2 Then
            If Godina <> TekucaGodina Then
                If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If

            If chkKnjizeno.Checked Then
                MsgBox("Dokument je već proknjižen!", vbExclamation, "PRIJEMNICA")
                Cursor = Cursors.Default
                Exit Sub
            Else
                If MsgBox("Knjiženje?" & vbCrLf & vbCrLf & "Nastavljate?", vbQuestion + vbYesNo, "PRIJEMNICA") = vbYes Then
                    Cursor = Cursors.WaitCursor

                    For n = 0 To rsStavke.Rows.Count - 1
                        rs = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & rsStavke.Rows(n)!SifraArtikla & " AND BarCod=''")
                        If rs.Rows.Count = 0 Then
                            InsertData("INSERT INTO Zaliha VALUES(" & TekuciMagacin & ",'" & rsStavke(n)!SifraArtikla & "',''," & FormatNumber(rsStavke.Rows(n)!Kolicina, 4,,, TriState.False) & ",0)")
                        Else
                            Zaliha = (rs.Rows(0)!Zaliha + rsStavke.Rows(n)!Kolicina)
                            InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & rsStavke.Rows(n)!SifraArtikla & " AND BarCod=''")
                        End If
                    Next

                    Cursor = Cursors.Default
                    InsertData("UPDATE Prijemnica SET Knjizeno = 'True' WHERE Godina=" & Godina & " AND Broj=" & CLng(txtBroj.Text) & " AND Magacin=" & TekuciMagacin)
                    InsertData("UPDATE Prijemnica SET Vreme ='" & TimeOfDay & "' WHERE Godina=" & Godina & " AND Broj=" & CLng(txtBroj.Text) & " AND Magacin=" & TekuciMagacin)

                    InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                   & "','Knjizenje','" & DocStatus & "'," & txtBroj.Text & ",'" & txtNazivDobavljaca.Text & "')")

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
    'Private Sub cmdKalkulacija_Click(sender As Object, e As EventArgs)

    '    If chkKalkulacija.Checked Then
    '        Parametri.Broj = txtBrojKalkulacije.Text
    '    Else
    '        If Not chkKnjizeno.Checked Then
    '            MsgBox("Morate prvo proknjižiti dokument!", MsgBoxStyle.Exclamation)
    '            Exit Sub
    '        End If

    '        If ChkMaloprodaja.Checked = False And ChkVeleprodaja.Checked = False And ChkUvoz.Checked = False Then
    '            MsgBox("Morate izabrati vrstu prijemnice!", MsgBoxStyle.Exclamation)
    '            Cursor = Cursors.Default
    '            Exit Sub
    '        End If

    '        Kalkulacija(txtBroj.Text)

    '        chkKalkulacija.Checked = True

    '        InsertData("UPDATE Prijemnica SET BrojKalkulacije=" & BrojKalkulacije & " WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
    '                       & Godina & " AND Magacin=" & TekuciMagacin)
    '        InsertData("UPDATE Prijemnica SET Kalkulacija='true' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
    '                       & Godina & " AND Magacin=" & TekuciMagacin)

    '        Select Case True
    '            Case ChkVeleprodaja.Checked
    '                InsertData("UPDATE Prijemnica SET Veleprodaja='" & ChkVeleprodaja.Checked & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
    '                       & Godina & " AND Magacin=" & TekuciMagacin)
    '            Case ChkUvoz.Created
    '                InsertData("UPDATE Prijemnica SET Uvoz='" & ChkUvoz.Checked & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
    '                       & Godina & " AND Magacin=" & TekuciMagacin)
    '            Case Else
    '                InsertData("UPDATE Prijemnica SET Veleprodaja='True' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
    '                       & Godina & " AND Magacin=" & TekuciMagacin)
    '        End Select

    '        txtBrojKalkulacije.Text = BrojKalkulacije
    '        Parametri.Broj = txtBrojKalkulacije.Text
    '    End If

    '    If ChkVeleprodaja.Checked Then
    '        DocStatus = "KalkulacijaVeleprodaja"
    '        FrmKalkulacijaVeleprodaja.Dispose()
    '        Hide()
    '        FrmKalkulacijaVeleprodaja.ShowDialog()
    '        Show()
    '    Else
    '        If ChkUvoz.Checked Then
    '            DocStatus = "KalkulacijaUvoz"
    '            FrmKalkulacijaUvoz.Dispose()
    '            Hide()
    '            FrmKalkulacijaUvoz.ShowDialog()
    '            Show()
    '        Else
    '            DocStatus = ""
    '        End If
    '    End If
    '    DocStatus = "Prijemnica"
    '    Exit Sub

    'End Sub
    Private Sub cmdStampa_Click(sender As Object, e As EventArgs)

        'Cursor = Cursors.WaitCursor

        'InsertData("UPDATE Parametri SET Broj=" & CLng(txtBroj.Text))
        'InsertData("UPDATE Parametri SET Magacin=" & TekuciMagacin)
        'InsertData("UPDATE Parametri SET Godina=" & Godina)

        'Parametri.NazivIzvestaja = "Prijemnica.rpt"

        'FrmPreView.ShowDialog()

        Cursor = Cursors.Default
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
    Private Sub txtNapomena_DoubleClick(sender As Object, e As EventArgs) Handles txtNapomena.DoubleClick, txtPrevoznik.DoubleClick, txtVozilo.DoubleClick, txtBrojUlaznogDokumenta.DoubleClick
        Dim tb = TryCast(sender, TextBox)
        tb.ReadOnly = False
    End Sub


#End Region


End Class