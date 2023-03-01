Imports System.Drawing.Drawing2D

Public Class frmPrenosnica
    Dim rsPrenosnica As DataTable
    Dim rsStavke As DataTable
    Dim Selected As Boolean
    Dim SelektovanaKolona As String


#Region "FORMA"
    Private Sub frmPrenosnica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lFont As Font

        lFont = New Font("Calibri", 11, FontStyle.Bold, GraphicsUnit.Point)
        grdStavke.ColumnHeadersDefaultCellStyle.Font = lFont
        lFont = New Font("Verdana", 9.75, FontStyle.Regular, GraphicsUnit.Point)
        grdStavke.RowsDefaultCellStyle.Font = lFont

        SifarnikMagacina.KontrolaZaPrikaz = CmbIzMagacina
        SifarnikMagacina.PuniKontrolu()
        CmbIzMagacina.SelectedValue = TekuciMagacin
        txtSifraIzMagacina.Text = CmbIzMagacina.SelectedValue

        SifarnikUMagacin.KontrolaZaPrikaz = cmbUMagacin
        SifarnikUMagacin.PuniKontrolu()
        cmbUMagacin.SelectedIndex = -1
        txtSifraUMagacin.Text = ""

        ArtikliStavke.Puni()
        GridZaListuStavkiArtikala(GrdListaStavki)
        ArtikliStavke.DajSve()

        If Parametri.Novi Then
            Novi()
        Else
            rsPrenosnica = GetData("SELECT * FROM Prenosnica WHERE Broj=" & Parametri.Broj & " AND Godina=" & Godina & " AND IzMagacina=" & TekuciMagacin)
            txtSifraIzMagacina.Text = rsPrenosnica.Rows(0)!IzMagacina
            CmbIzMagacina.SelectedValue = rsPrenosnica.Rows(0)!IzMagacina
            cmbUMagacin.SelectedValue = rsPrenosnica.Rows(0)!UMagacin
            txtSifraUMagacin.Text = cmbUMagacin.SelectedValue
            txtBroj.Text = rsPrenosnica.Rows(0)!Broj

            dtpDatum.Value = rsPrenosnica.Rows(0)!Datum
            txtNapomena.Text = rsPrenosnica.Rows(0)!Napomena.ToString
            chkKnjizeno.Checked = rsPrenosnica.Rows(0)!Knjizeno
            txtBrojFinansijskogNaloga.Text = rsPrenosnica.Rows(0)!FinansijskiNalog

            DajStavkePrenosnice(txtBroj.Text)
            'DajSumu(txtBroj.Text)

        End If

        GrdListaStavki.Visible = False

        TxtNazivArtikla.Select()

    End Sub
    Private Sub frmPrenosnica_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim rs As DataTable

        If Parametri.Novi = False Then
            rs = GetData("SELECT * FROM PrenosnicaStavke WHERE BrojPrenosnice=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
            If rs.Rows.Count = 0 Then
                Cursor = Cursors.Default
                MsgBox("Dokument nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
        End If

    End Sub
    Private Sub frmPrenosnica_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Parametri.Novi = False

    End Sub

#End Region


#Region "TXT zaglavlje"
    Private Sub cmbUMagacin_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbUMagacin.SelectionChangeCommitted
        If cmbUMagacin.SelectedIndex > -1 Then
            txtSifraUMagacin.Text = cmbUMagacin.SelectedValue
        Else
            txtSifraUMagacin.Text = ""
        End If
    End Sub

#End Region


#Region "TXT stavke"
    Private Sub TxtNazivArtikla_TextChanged(sender As Object, e As EventArgs) Handles TxtNazivArtikla.TextChanged

        If TxtNazivArtikla.Text = "" Then
            txtSifraArtikla.Text = ""
            txtJM.Text = ""
            txtStanje.Text = "0"
            TxtNabavnaCena.Text = ""
            TxtProdajnaCena.Text = ""
            txtKolicina.Text = ""
            TxtNabavniIznos.Text = ""
            TxtProdajniIznos.Text = ""

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

            txtStanje.Text = FormatNumber(DajStanje(txtSifraArtikla.Text, TekuciMagacin, TekucaGodina), 2,,, TriState.True)
            'TxtNabavnaCena.Text = FormatNumber(DajCenuProsecnuNabavnu(txtSifraArtikla.Text, TekuciMagacin, TekucaGodina), 2,,, TriState.True)
            'TxtProdajnaCena.Text = FormatNumber(DajCenuProdajnu(txtSifraArtikla.Text, TekuciMagacin, TekucaGodina), 2,,, TriState.True)

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

                txtStanje.Text = FormatNumber(DajStanje(txtSifraArtikla.Text, TekuciMagacin, TekucaGodina), 2,,, TriState.True)
                'TxtNabavnaCena.Text = FormatNumber(DajCenuProsecnuNabavnu(txtSifraArtikla.Text, TekuciMagacin, TekucaGodina), 2,,, TriState.True)
                'TxtProdajnaCena.Text = FormatNumber(DajCenuProdajnu(txtSifraArtikla.Text, TekuciMagacin, TekucaGodina), 2,,, TriState.True)

                GrdListaStavki.Visible = False

                txtKolicina.Select()

            End If
        End If
    End Sub
    Private Sub txtKolicina_TextChanged(sender As Object, e As EventArgs) Handles txtKolicina.TextChanged
        If IsNumeric(txtKolicina.Text) And IsNumeric(TxtNabavnaCena.Text) And IsNumeric(TxtProdajnaCena.Text) Then
            TxtNabavniIznos.Text = FormatNumber((CDbl(txtKolicina.Text) * CDbl(TxtNabavnaCena.Text)), 2,,, TriState.True)
            TxtProdajniIznos.Text = FormatNumber((CDbl(txtKolicina.Text) * CDbl(TxtProdajnaCena.Text)), 2,,, TriState.True)
        Else
            TxtNabavniIznos.Text = "0"
            TxtProdajniIznos.Text = "0"
        End If
    End Sub
    Private Sub txtKolicina_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKolicina.KeyDown
        Dim rs As DataTable, rsIZ As DataTable, rsU As DataTable
        Dim Rbr As Integer
        Dim Iznos As Double = 0
        Dim Zaliha As Double
        Dim ZalihaUMagacin As Double

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

                If TxtNabavnaCena.Text = "" Or IsNumeric(TxtNabavnaCena.Text) = False Or TxtProdajnaCena.Text = "" Or IsNumeric(TxtProdajnaCena.Text) = False Then
                    MsgBox("Greska u polju Cena!", MsgBoxStyle.Exclamation)
                    txtKolicina.Select()
                    Exit Sub
                End If

                If txtKolicina.Text = "" Or IsNumeric(txtKolicina.Text) = False Then
                    MsgBox("Greska pri unosu količine!", MsgBoxStyle.Exclamation)
                    txtKolicina.Select()
                    Exit Sub
                End If

                If CDbl(txtKolicina.Text) > CDbl(txtStanje.Text) Then
                    If MsgBox("Uneta količina je veća od količine na stanju magacina." & vbCrLf & vbCrLf & "Nastavljate?", vbQuestion + vbYesNo, "Prenosnica") = vbNo Then Exit Sub
                End If

                If Parametri.Novi Then
                    rs = GetData("SELECT * FROM PrenosnicaStavke WHERE SifraArtikla=" & txtSifraArtikla.Text & " AND BrojPrenosnice=" & MinusID _
                                 & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                    If rs.Rows.Count > 0 Then
                        If MsgBox("Unosite artikal koji već postoji u ovom dokumentu!" & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                    End If
                    rs.Dispose()

                    rs = GetData("SELECT MAX(Rbr) AS Novi FROM PrenosnicaStavke WHERE BrojPrenosnice=" & MinusID _
                               & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                    If IsDBNull(rs.Rows(0)!Novi) Or (rs.Rows.Count = 0) Then
                        Rbr = 1
                    Else
                        Rbr = rs.Rows(0)!Novi + 1
                    End If

                    InsertData("INSERT INTO PrenosnicaStavke VALUES(" & TekuciMagacin & "," & MinusID & "," & Rbr & ",0," & CLng(txtSifraArtikla.Text) & ",'" & TxtNazivArtikla.Text _
                                & "','','" & txtJM.Text & "'," & FormatNumber(CDbl(txtStanje.Text), 2,,, TriState.False) & "," & FormatNumber(CDbl(TxtNabavnaCena.Text), 2,,, TriState.False) _
                                & "," & FormatNumber(CDbl(TxtProdajnaCena.Text), 2,,, TriState.False) & "," & FormatNumber(CDbl(txtKolicina.Text), 2,,, TriState.False) _
                                & "," & FormatNumber(CDbl(TxtNabavniIznos.Text), 2,,, TriState.False) & "," & FormatNumber(CDbl(TxtProdajniIznos.Text), 2,,, TriState.False) & "," & Godina & ")")

                    DajStavkePrenosnice(MinusID)
                    'DajSumu(MinusID)
                Else
                    rs = GetData("SELECT * FROM PrenosnicaStavke WHERE SifraArtikla=" & txtSifraArtikla.Text & " AND BrojPrenosnice=" & CLng(txtBroj.Text) _
                                 & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                    If rs.Rows.Count > 0 Then
                        If MsgBox("Unosite artikal koji već postoji u ovom dokumentu!" & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                    End If
                    rs.Dispose()

                    rs = GetData("SELECT MAX(Rbr) AS Novi FROM PrenosnicaStavke WHERE BrojPrenosnice=" & CLng(txtBroj.Text) _
                              & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                    If IsDBNull(rs.Rows(0)!Novi) Or (rs.Rows.Count = 0) Then
                        Rbr = 1
                    Else
                        Rbr = rs.Rows(0)!Novi + 1
                    End If

                    InsertData("INSERT INTO PrenosnicaStavke VALUES(" & TekuciMagacin & "," & CLng(txtBroj.Text) & "," & Rbr & ",0," & CLng(txtSifraArtikla.Text) & ",'" & TxtNazivArtikla.Text _
                                & "','','" & txtJM.Text & "'," & FormatNumber(CDbl(txtStanje.Text), 2,,, TriState.False) & "," & FormatNumber(CDbl(TxtNabavnaCena.Text), 2,,, TriState.False) _
                                & "," & FormatNumber(CDbl(TxtProdajnaCena.Text), 2,,, TriState.False) & "," & FormatNumber(CDbl(txtKolicina.Text), 2,,, TriState.False) _
                                & "," & FormatNumber(CDbl(TxtNabavniIznos.Text), 2,,, TriState.False) & "," & FormatNumber(CDbl(TxtProdajniIznos.Text), 2,,, TriState.False) & "," & Godina & ")")


                    '***knjizenje u zalihama stavke koja se dodaje u proknjizenom dokumentu
                    If chkKnjizeno.Checked Then
                        rsIZ = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & txtSifraArtikla.Text)
                        rsU = GetData("SELECT * FROM Zaliha WHERE Magacin=" & CLng(txtSifraUMagacin.Text) & " AND Sifra=" & txtSifraArtikla.Text)
                        If rsIZ.Rows.Count = 0 Then
                            Cursor = Cursors.Default
                            MsgBox("Greška pri knjiženju!" & vbCrLf & vbCrLf & "Artikal se ne nalaze u magacinu za prenos.", MsgBoxStyle.Exclamation, "PRENOSNICA")
                            Exit Sub
                        Else
                            Zaliha = (rsIZ.Rows(0)!Zaliha - CDbl(txtKolicina.Text))
                            InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & txtSifraArtikla.Text)
                            If rsU.Rows.Count = 0 Then
                                InsertData("INSERT INTO Zaliha Values(" & CLng(cmbUMagacin.SelectedValue) & "," & CLng(txtSifraArtikla.Text) & ",''," & FormatNumber(CDbl(txtKolicina.Text), 4,,, TriState.False) & ",0)")
                            Else
                                ZalihaUMagacin = (rsU.Rows(0)!Zaliha + CDbl(txtKolicina.Text))
                                InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(ZalihaUMagacin, 4,,, TriState.False) & " WHERE Magacin=" & CLng(txtSifraUMagacin.Text) & " AND Sifra=" & txtSifraArtikla.Text)
                            End If

                        End If

                        InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Dodavanje u proknjizenoj','" & DocStatus & "'," & txtBroj.Text & ",'" & TxtNazivArtikla.Text & "')")

                    End If

                    DajStavkePrenosnice(txtBroj.Text)
                    'DajSumu(txtBroj.Text)
                End If


                txtSifraArtikla.Text = ""
                TxtNazivArtikla.Text = ""
                txtJM.Text = ""
                txtStanje.Text = "0"
                TxtNabavnaCena.Text = ""
                TxtProdajnaCena.Text = ""
                txtKolicina.Text = ""
                TxtNabavniIznos.Text = ""
                TxtProdajniIznos.Text = ""
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

        If IsNumeric(grdStavke.Rows(e.RowIndex).Cells(0).Value) = False Then Exit Sub

        Select Case grdStavke.Columns(e.ColumnIndex).Name
            Case "NabavnaCena"
                grdStavke.Rows(e.RowIndex).Cells("NabavniIznos").Value = FormatNumber((grdStavke.Rows(e.RowIndex).Cells("NabavnaCena").Value * (grdStavke.Rows(e.RowIndex).Cells("Kolicina").Value)), 2,,, TriState.False)

            Case "ProdajnaCena"
                grdStavke.Rows(e.RowIndex).Cells("ProdajniIznos").Value = FormatNumber((grdStavke.Rows(e.RowIndex).Cells("ProdajnaCena").Value * (grdStavke.Rows(e.RowIndex).Cells("Kolicina").Value)), 2,,, TriState.False)

            Case "Kolicina"
                grdStavke.Rows(e.RowIndex).Cells("NabavniIznos").Value = FormatNumber((grdStavke.Rows(e.RowIndex).Cells("NabavnaCena").Value * (grdStavke.Rows(e.RowIndex).Cells("Kolicina").Value)), 2,,, TriState.False)
                grdStavke.Rows(e.RowIndex).Cells("ProdajniIznos").Value = FormatNumber((grdStavke.Rows(e.RowIndex).Cells("ProdajnaCena").Value * (grdStavke.Rows(e.RowIndex).Cells("Kolicina").Value)), 2,,, TriState.False)

                'DajSumu(txtBroj.Text, False)
        End Select
    End Sub
    Private Sub grdStavke_KeyDown(sender As Object, e As KeyEventArgs) Handles grdStavke.KeyDown
        Dim rs As DataTable
        Dim rsIZ As DataTable, rsU As DataTable
        Dim Zaliha As Double
        Dim ZalihaUMagacin As Double

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
                            InsertData("DELETE FROM PrenosnicaStavke WHERE BrojPrenosnice=" & MinusID & " And Godina=" & Godina & " And Magacin=" & TekuciMagacin _
                                        & " And SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " And RBr=" & grdStavke.Rows(n).Cells("RBr").Value & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value)
                        End If
                    Next

                    DajStavkePrenosnice(MinusID)
                    'DajSumu(txtBroj.Text)
                Else
                    rs = GetData("SELECT * FROM PrenosnicaStavke WHERE BrojPrenosnice=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                    If rs.Rows.Count = 1 Then
                        Cursor = Cursors.Default
                        MsgBox("Ne možete brisati jedinu stavku u dokumentu!", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If

                    For n = 0 To grdStavke.RowCount - 1
                        Cursor = Cursors.WaitCursor
                        If grdStavke.Rows(n).Selected Then
                            InsertData("DELETE FROM PrenosnicaStavke WHERE BrojPrenosnice=" & CInt(txtBroj.Text) & " And Godina=" & Godina & " And Magacin=" & TekuciMagacin _
                                        & " And SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " And RBr=" & grdStavke.Rows(n).Cells("RBr").Value & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value)

                            'knjizenje u zalihama stavke koja se brise u proknjizenom dokumentu
                            If chkKnjizeno.Checked Then
                                rsIZ = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)
                                rsU = GetData("SELECT * FROM Zaliha WHERE Magacin=" & CLng(txtSifraUMagacin.Text) & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)

                                Zaliha = (rsIZ.Rows(0)!Zaliha + grdStavke.Rows(n).Cells("Kolicina").Value)
                                InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)

                                ZalihaUMagacin = (rsU.Rows(0)!Zaliha - grdStavke.Rows(n).Cells("Kolicina").Value)
                                InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(ZalihaUMagacin, 4,,, TriState.False) & " WHERE Magacin=" & CLng(txtSifraUMagacin.Text) & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)

                                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                           & "','Brisanje u proknjizenoj','" & DocStatus & "'," & txtBroj.Text & ",'" & grdStavke.Rows(n).Cells("SifraArtikla").Value & "')")
                            End If
                        End If
                    Next

                    DajStavkePrenosnice(txtBroj.Text)
                    'DajSumu(txtBroj.Text)
                End If
            Else
                MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Cursor = Cursors.Default

        End If
    End Sub
    Private Sub grdStavke_MouseClick(sender As Object, e As MouseEventArgs) Handles grdStavke.MouseClick

        GridDesniKlik(sender, e, mnuForme, grdStavke)

    End Sub

#End Region


#Region "MNU"
    Private Sub mnuBrisanje_Click(sender As Object, e As EventArgs) Handles mnuBrisanje.Click
        Dim rs As DataTable
        Dim rsIZ As DataTable, rsU As DataTable
        Dim Zaliha As Double
        Dim ZalihaUMagacin As Double

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
                        InsertData("DELETE FROM PrenosnicaStavke WHERE BrojPrenosnice=" & MinusID & " And Godina=" & Godina & " And Magacin=" & TekuciMagacin _
                                    & " And SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " And RBr=" & grdStavke.Rows(n).Cells("RBr").Value & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value)
                    End If
                Next

                DajStavkePrenosnice(MinusID)
                'DajSumu(txtBroj.Text)
            Else
                rs = GetData("SELECT * FROM PrenosnicaStavke WHERE BrojPrenosnice=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                If rs.Rows.Count = 1 Then
                    Cursor = Cursors.Default
                    MsgBox("Ne možete brisati jedinu stavku u dokumentu!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                For n = 0 To grdStavke.RowCount - 1
                    Cursor = Cursors.WaitCursor
                    If grdStavke.Rows(n).Selected Then
                        InsertData("DELETE FROM PrenosnicaStavke WHERE BrojPrenosnice=" & CInt(txtBroj.Text) & " And Godina=" & Godina & " And Magacin=" & TekuciMagacin _
                                    & " And SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " And RBr=" & grdStavke.Rows(n).Cells("RBr").Value & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value)

                        'knjizenje u zalihama stavke koja se brise u proknjizenom dokumentu
                        If chkKnjizeno.Checked Then
                            rsIZ = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)
                            rsU = GetData("SELECT * FROM Zaliha WHERE Magacin=" & CLng(txtSifraUMagacin.Text) & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)

                            Zaliha = (rsIZ.Rows(0)!Zaliha + grdStavke.Rows(n).Cells("Kolicina").Value)
                            InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)

                            ZalihaUMagacin = (rsU.Rows(0)!Zaliha - grdStavke.Rows(n).Cells("Kolicina").Value)
                            InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(ZalihaUMagacin, 4,,, TriState.False) & " WHERE Magacin=" & CLng(txtSifraUMagacin.Text) & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)

                            InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                       & "','Brisanje u proknjizenoj','" & DocStatus & "'," & txtBroj.Text & ",'" & grdStavke.Rows(n).Cells("SifraArtikla").Value & "')")
                        End If
                    End If
                Next

                DajStavkePrenosnice(txtBroj.Text)
                'DajSumu(txtBroj.Text)
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
            DajStavkePrenosnice(txtBroj.Text)
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

        InsertData("DELETE FROM PrenosnicaStavke WHERE BrojPrenosnice=" & MinusID)

        txtBroj.Text = "0"
        txtSifraIzMagacina.Text = TekuciMagacin

        Select Case TekuciMagacin
            Case 1
                cmbUMagacin.SelectedValue = 3
            Case 3
                cmbUMagacin.SelectedValue = 1
        End Select
        txtSifraUMagacin.Text = cmbUMagacin.SelectedValue

        If Godina <> TekucaGodina Then
            dtpDatum.Text = "31/12/" & Godina
        Else
            dtpDatum.Text = Format(Now, "dd/M/yyyy")
        End If

        txtNapomena.Text = ""

        txtSifraArtikla.Text = ""
        TxtNazivArtikla.Text = ""
        txtJM.Text = ""
        txtStanje.Text = "0"
        TxtNabavnaCena.Text = ""
        TxtProdajnaCena.Text = ""
        txtKolicina.Text = ""
        TxtNabavniIznos.Text = ""
        TxtProdajniIznos.Text = ""

        chkKnjizeno.Checked = False

        grdStavke.DataSource = Nothing

        'cmdNovi.Enabled = False
        'cmdSnimi.Enabled = True
        'cmdStampa.Enabled = False
        'cmdKnjizenje.Enabled = False
        'CmdNalog.Enabled = False

        TxtNazivArtikla.Select()

    End Sub
    Sub Odustajanje()

        InsertData("DELETE FROM PrenosnicaStavke WHERE BrojPrenosnice=" & MinusID)

    End Sub
    Sub DajStavkePrenosnice(ByVal Broj As Long, Optional ByVal NoviDoc As Boolean = False)

        rsStavke = GetData("SELECT PrenosnicaStavke.BrojPrenosnice, PrenosnicaStavke.Rbr, PrenosnicaStavke.SifraArtikla, 
                            PrenosnicaStavke.NazivArtikla, PrenosnicaStavke.JedinicaMere, PrenosnicaStavke.NabavnaCena, PrenosnicaStavke.ProdajnaCena, PrenosnicaStavke.Kolicina, 
                            PrenosnicaStavke.NabavniIznos, PrenosnicaStavke.ProdajniIznos, PrenosnicaStavke.ID 
                            FROM PrenosnicaStavke WHERE PrenosnicaStavke.Magacin=" & TekuciMagacin _
                            & " And PrenosnicaStavke.BrojPrenosnice = " & Broj & " And PrenosnicaStavke.Godina = " & Godina & " ORDER BY PrenosnicaStavke.Rbr")

        grdStavke.DataSource = Nothing
        grdStavke.DataSource = rsStavke

        grdStavke.Columns("BrojPrenosnice").Visible = False
        grdStavke.Columns("Rbr").Width = 50
        grdStavke.Columns("SifraArtikla").Width = 80
        grdStavke.Columns("SifraArtikla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("SifraArtikla").HeaderText = "ŠIFRA"
        grdStavke.Columns("NazivArtikla").Width = 390
        grdStavke.Columns("NazivArtikla").HeaderText = "NAZIV ARTIKLA"
        grdStavke.Columns("NazivArtikla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("JedinicaMere").Width = 45
        grdStavke.Columns("JedinicaMere").HeaderText = "J.M."
        grdStavke.Columns("JedinicaMere").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdStavke.Columns("NabavnaCena").Width = 190
        grdStavke.Columns("NabavnaCena").HeaderText = "NAB.CENA"
        grdStavke.Columns("NabavnaCena").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("NabavnaCena").DefaultCellStyle.Format = "###,###,##0.00"
        grdStavke.Columns("ProdajnaCena").Width = 100
        grdStavke.Columns("ProdajnaCena").HeaderText = "PROD.CENA"
        grdStavke.Columns("ProdajnaCena").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("ProdajnaCena").DefaultCellStyle.Format = "###,###,##0.00"
        grdStavke.Columns("Kolicina").Width = 100
        grdStavke.Columns("Kolicina").HeaderText = "KOLIČINA"
        grdStavke.Columns("Kolicina").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("Kolicina").DefaultCellStyle.Format = "###,###,##0.00"
        grdStavke.Columns("NabavniIznos").Width = 110
        grdStavke.Columns("NabavniIznos").HeaderText = "NAB.IZNOS"
        grdStavke.Columns("NabavniIznos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("NabavniIznos").DefaultCellStyle.Format = "###,###,##0.00"
        grdStavke.Columns("ProdajniIznos").Width = 110
        grdStavke.Columns("ProdajniIznos").HeaderText = "NAB.IZNOS"
        grdStavke.Columns("ProdajniIznos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("ProdajniIznos").DefaultCellStyle.Format = "###,###,##0.00"
        grdStavke.Columns("ID").Visible = False

    End Sub
    Sub AzurirajRbr(Broj As Integer)
        Dim rs As DataTable

        rs = GetData("SELECT * FROM PrenosnicaStavke WHERE BrojPrenosnice=" & Broj & " And Godina=" & Godina & " And IzMagacina=" & TekuciMagacin & " ORDER BY ID")

        For n = 0 To rs.Rows.Count - 1
            InsertData("UPDATE PrenosnicaStavke SET RBr=" & n + 1 & " WHERE BrojPrenosnice=" & Broj & " And Godina=" & Godina _
                           & " And ID=" & rs(n)!ID & " And IzMagacina=" & TekuciMagacin)
        Next

    End Sub
    'Sub DajSumu(Broj As Integer, Optional Maloprodaja As Boolean = False, Optional Grid As Boolean = False)
    '    Dim NabavnaVrednost As Double
    '    Dim RUC As Double
    '    Dim ProdajnaVrednost As Double

    '    LblNabavnaVrednost.Text = "0.00"
    '    LblRUC.Text = "0.00"
    '    LblProdajnaVrednost.Text = "0.00"

    '    For n = 0 To grdStavke.RowCount - 1
    '        NabavnaVrednost += grdStavke.Rows(n).Cells("NabavniIznos").Value
    '        ProdajnaVrednost += grdStavke.Rows(n).Cells("ProdajniIznos").Value
    '    Next

    '    RUC = ProdajnaVrednost - NabavnaVrednost

    '    LblNabavnaVrednost.Text = FormatNumber(NabavnaVrednost, 2, , , TriState.True)
    '    LblRUC.Text = FormatNumber(RUC, 2, , , TriState.True)
    '    LblProdajnaVrednost.Text = FormatNumber(ProdajnaVrednost, 2, , , TriState.True)

    'End Sub
    'Sub KnjizenjeKEPKnjiga()
    '    Dim rs As DataTable
    '    Dim KEPIznos As Double
    '    Dim Rbr As Integer

    '    'KEP iz Magacina
    '    rs = GetData("Select MAX(RedniBroj) As Novi FROM KEPKnjiga WHERE Godina=" & Godina & " And Magacin=" & TekuciMagacin)
    '    If IsDBNull(rs.Rows(0)!Novi) Or (rs.Rows.Count = 0) Then
    '        Rbr = 1
    '    Else
    '        Rbr = rs.Rows(0)!Novi + 1
    '    End If

    '    KEPIznos = DajIznosPoCenovniku(txtSifraIzMagacina.Text, LblNabavnaVrednost.Text, LblProdajnaVrednost.Text)

    '    InsertData("INSERT INTO KEPKnjiga VALUES(" & TekuciMagacin & "," & Rbr & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
    '               & "','Prenosnica broj'," & CLng(txtBroj.Text) & ",'U - " & cmbUMagacin.Text & "',0," & FormatNumber(KEPIznos, 2,,, TriState.False) & "," & Godina & ")")


    '    'KEP u Magacin
    '    rs.Dispose()
    '    rs = GetData("Select MAX(RedniBroj) As Novi FROM KEPKnjiga WHERE Godina=" & Godina & " And Magacin=" & txtSifraUMagacin.Text)
    '    If IsDBNull(rs.Rows(0)!Novi) Or (rs.Rows.Count = 0) Then
    '        Rbr = 1
    '    Else
    '        Rbr = rs.Rows(0)!Novi + 1
    '    End If

    '    KEPIznos = DajIznosPoCenovniku(txtSifraUMagacin.Text, LblNabavnaVrednost.Text, LblProdajnaVrednost.Text)

    '    InsertData("INSERT INTO KEPKnjiga VALUES(" & txtSifraUMagacin.Text & "," & Rbr & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
    '               & "','Prenosnica broj'," & CLng(txtBroj.Text) & ",'IZ - " & CmbIzMagacina.Text & "'," & FormatNumber(KEPIznos, 2,,, TriState.False) & ",0," & Godina & ")")


    'End Sub
    'Sub PreknjizavanjeKEPKnjige()
    '    Dim rsKEP As DataTable
    '    Dim KEPIznos As Double

    '    'KEP iz Magacina
    '    rsKEP = GetData("Select * FROM KEPKnjiga WHERE Dokument='Prenosnica broj' AND BrojDokumenta=" & txtBroj.Text _
    '                    & " AND Opis LIKE 'U -%' AND Razduzenje>0 AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)

    '    KEPIznos = DajIznosPoCenovniku(txtSifraIzMagacina.Text, LblNabavnaVrednost.Text, LblProdajnaVrednost.Text)

    '    If rsKEP.Rows.Count = 1 Then
    '        InsertData("UPDATE KEPKnjiga SET Datum='" & Format(CDate(dtpDatum.Text), FormatDatuma) & "' WHERE BrojDokumenta=" & CInt(txtBroj.Text) _
    '               & " AND Dokument='Prenosnica broj' AND Opis LIKE 'U -%' AND Razduzenje>0 AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
    '        InsertData("UPDATE KEPKnjiga SET Razduzenje=" & FormatNumber(KEPIznos, 2,,, TriState.False) & " WHERE BrojDokumenta=" & CInt(txtBroj.Text) _
    '               & " AND Dokument='Prenosnica broj' AND Opis LIKE 'U -%' AND Razduzenje>0 AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
    '    Else
    '        MsgBox("Greška pri preknjižavanju u KEP knjigu!", vbExclamation, "PRENOSNICA")
    '        Exit Sub
    '    End If
    '    rsKEP.Dispose()


    '    'KEP u Magacin
    '    rsKEP = GetData("Select * FROM KEPKnjiga WHERE Dokument='Prenosnica broj' AND BrojDokumenta=" & txtBroj.Text _
    '                    & " AND Opis LIKE 'IZ -%' AND Zaduzenje>0 AND Godina=" & Godina & " AND Magacin=" & txtSifraUMagacin.Text)

    '    KEPIznos = DajIznosPoCenovniku(txtSifraUMagacin.Text, LblNabavnaVrednost.Text, LblProdajnaVrednost.Text)

    '    If rsKEP.Rows.Count = 1 Then
    '        InsertData("UPDATE KEPKnjiga SET Datum='" & Format(CDate(dtpDatum.Text), FormatDatuma) & "' WHERE BrojDokumenta=" & CInt(txtBroj.Text) _
    '               & " AND Dokument='Prenosnica broj' AND Opis LIKE 'IZ -%' AND Zaduzenje>0 AND Magacin=" & txtSifraUMagacin.Text & " AND Godina=" & Godina)
    '        InsertData("UPDATE KEPKnjiga SET Zaduzenje=" & FormatNumber(KEPIznos, 2,,, TriState.False) & " WHERE BrojDokumenta=" & CInt(txtBroj.Text) _
    '               & " AND Dokument='Prenosnica broj' AND Opis LIKE 'IZ -%' AND Zaduzenje>0 AND Magacin=" & txtSifraUMagacin.Text & " AND Godina=" & Godina)
    '    Else
    '        MsgBox("Greška pri preknjižavanju u KEP knjigu!", vbExclamation, "PRENOSNICA")
    '        Exit Sub
    '    End If

    'End Sub
    'Sub FinansijskiNalog(SifraDokumenta As Integer, OznakaDokumenta As String)
    '    Dim rsSema As DataTable
    '    Dim ProdajnaVrednostIzMagacina As Double
    '    Dim ProdajnaVrednostUMagacin As Double
    '    Dim NabavnaVrednostIzMagacina As Double
    '    Dim NabavnaVrednostUMagacin As Double
    '    Dim RUC As Double
    '    Dim BrojNaloga As Integer

    '    ProdajnaVrednostIzMagacina = LblProdajnaVrednost.Text
    '    ProdajnaVrednostUMagacin = LblProdajnaVrednost.Text
    '    NabavnaVrednostIzMagacina = LblNabavnaVrednost.Text
    '    NabavnaVrednostUMagacin = LblNabavnaVrednost.Text
    '    RUC = LblRUC.Text

    '    BrojNaloga = txtBroj.Text
    '    RUC = LblRUC.Text

    '    InsertData("INSERT INTO FinansijskiNalog VALUES('" & OznakaDokumenta & "'," & BrojNaloga & " ," & TekuciMagacin & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
    '               & "','" & txtNapomena.Text & "','False','" & TimeOfDay & "'," & Godina & "," & UserID & ")")

    '    rsSema = GetData("SELECT * FROM SemaKontiranja WHERE SifraDokumenta=" & SifraDokumenta & " AND Pasivan='False' AND Magacin=" & CLng(txtSifraIzMagacina.Text))
    '    If rsSema.Rows.Count = 0 Then
    '        MsgBox("Nije pronađena šema knjiženja!")
    '        Exit Sub
    '    End If

    '    For n = 0 To rsSema.Rows.Count - 1
    '        Dim KoeficijentVrednosti As String = rsSema.Rows(n)!KoeficijentVrednosti
    '        Dim K As Integer = KoeficijentVrednostiKontiranja(KoeficijentVrednosti)
    '        Select Case rsSema.Rows(n)!PoljeZaKnjizenje
    '            Case "ProdajnaVrednostIzMagacina"
    '                If rsSema.Rows(n)!Duguje Then
    '                    InsertData("INSERT INTO FinansijskiNalogStavke VALUES('" & OznakaDokumenta & "'," & BrojNaloga & " ," & CLng(txtSifraIzMagacina.Text) & "," & rsSema.Rows(n)!Rbr & ",'" & rsSema.Rows(n)!Konto _
    '                               & "',0,0,'','" & OznakaDokumenta & "-" & BrojNaloga & "-0" & TekuciMagacin & "','','',''," & FormatNumber((ProdajnaVrednostIzMagacina * K), 2,,, TriState.False) _
    '                               & ",0,0," & Godina & ")")
    '                Else
    '                    InsertData("INSERT INTO FinansijskiNalogStavke VALUES('" & OznakaDokumenta & "'," & BrojNaloga & " ," & CLng(txtSifraIzMagacina.Text) & "," & rsSema.Rows(n)!Rbr & ",'" & rsSema.Rows(n)!Konto _
    '                               & "',0,0,'','" & OznakaDokumenta & "-" & BrojNaloga & "-0" & TekuciMagacin & "','','','',0," & FormatNumber((ProdajnaVrednostIzMagacina * K), 2,,, TriState.False) _
    '                               & ",0," & Godina & ")")
    '                End If

    '            Case "ProdajnaVrednostUMagacin"
    '                If rsSema.Rows(n)!Duguje Then
    '                    InsertData("INSERT INTO FinansijskiNalogStavke VALUES('" & OznakaDokumenta & "'," & BrojNaloga & " ," & CLng(txtSifraIzMagacina.Text) & "," & rsSema.Rows(n)!Rbr & ",'" & rsSema.Rows(n)!Konto _
    '                               & "',0,0,'','" & OznakaDokumenta & "-" & BrojNaloga & "-0" & TekuciMagacin & "','','',''," & FormatNumber((ProdajnaVrednostUMagacin * K), 2,,, TriState.False) _
    '                               & ",0,0," & Godina & ")")
    '                Else
    '                    InsertData("INSERT INTO FinansijskiNalogStavke VALUES('" & OznakaDokumenta & "'," & BrojNaloga & " ," & CLng(txtSifraIzMagacina.Text) & "," & rsSema.Rows(n)!Rbr & ",'" & rsSema.Rows(n)!Konto _
    '                               & "',0,0,'','" & OznakaDokumenta & "-" & BrojNaloga & "-0" & TekuciMagacin & "','','','',0," & FormatNumber((ProdajnaVrednostUMagacin * K), 2,,, TriState.False) _
    '                               & ",0," & Godina & ")")
    '                End If

    '            Case "NabavnaVrednostIzMagacina"
    '                If rsSema.Rows(n)!Duguje Then
    '                    InsertData("INSERT INTO FinansijskiNalogStavke VALUES('" & OznakaDokumenta & "'," & BrojNaloga & " ," & CLng(txtSifraIzMagacina.Text) & "," & rsSema.Rows(n)!Rbr & ",'" & rsSema.Rows(n)!Konto _
    '                               & "',0,0,'','" & OznakaDokumenta & "-" & BrojNaloga & "-0" & TekuciMagacin & "','','',''," & FormatNumber((NabavnaVrednostIzMagacina * K), 2,,, TriState.False) _
    '                               & ",0,0," & Godina & ")")
    '                Else
    '                    InsertData("INSERT INTO FinansijskiNalogStavke VALUES('" & OznakaDokumenta & "'," & BrojNaloga & " ," & CLng(txtSifraIzMagacina.Text) & "," & rsSema.Rows(n)!Rbr & ",'" & rsSema.Rows(n)!Konto _
    '                               & "',0,0,'','" & OznakaDokumenta & "-" & BrojNaloga & "-0" & TekuciMagacin & "','','','',0," & FormatNumber((NabavnaVrednostIzMagacina * K), 2,,, TriState.False) _
    '                               & ",0," & Godina & ")")
    '                End If

    '            Case "NabavnaVrednostUMagacin"
    '                If rsSema.Rows(n)!Duguje Then
    '                    InsertData("INSERT INTO FinansijskiNalogStavke VALUES('" & OznakaDokumenta & "'," & BrojNaloga & " ," & CLng(txtSifraIzMagacina.Text) & "," & rsSema.Rows(n)!Rbr & ",'" & rsSema.Rows(n)!Konto _
    '                               & "',0,0,'','" & OznakaDokumenta & "-" & BrojNaloga & "-0" & TekuciMagacin & "','','',''," & FormatNumber((NabavnaVrednostUMagacin * K), 2,,, TriState.False) _
    '                               & ",0,0," & Godina & ")")
    '                Else
    '                    InsertData("INSERT INTO FinansijskiNalogStavke VALUES('" & OznakaDokumenta & "'," & BrojNaloga & " ," & CLng(txtSifraIzMagacina.Text) & "," & rsSema.Rows(n)!Rbr & ",'" & rsSema.Rows(n)!Konto _
    '                               & "',0,0,'','" & OznakaDokumenta & "-" & BrojNaloga & "-0" & TekuciMagacin & "','','','',0," & FormatNumber((NabavnaVrednostUMagacin * K), 2,,, TriState.False) _
    '                               & ",0," & Godina & ")")
    '                End If

    '            Case "RUC"
    '                If rsSema.Rows(n)!Duguje Then
    '                    InsertData("INSERT INTO FinansijskiNalogStavke VALUES('" & OznakaDokumenta & "'," & BrojNaloga & " ," & CLng(txtSifraIzMagacina.Text) & "," & rsSema.Rows(n)!Rbr & ",'" & rsSema.Rows(n)!Konto _
    '                               & "',0,0,'','" & OznakaDokumenta & "-" & BrojNaloga & "-0" & TekuciMagacin & "','','',''," & FormatNumber((RUC * K), 2,,, TriState.False) _
    '                               & ",0,0," & Godina & ")")
    '                Else
    '                    InsertData("INSERT INTO FinansijskiNalogStavke VALUES('" & OznakaDokumenta & "'," & BrojNaloga & " ," & CLng(txtSifraIzMagacina.Text) & "," & rsSema.Rows(n)!Rbr & ",'" & rsSema.Rows(n)!Konto _
    '                               & "',0,0,'','" & OznakaDokumenta & "-" & BrojNaloga & "-0" & TekuciMagacin & "','','','',0," & FormatNumber((RUC * K), 2,,, TriState.False) _
    '                               & ",0," & Godina & ")")
    '                End If
    '        End Select
    '    Next


    '    txtBrojFinansijskogNaloga.Text = BrojNaloga
    '    InsertData("UPDATE Prenosnica SET FinansijskiNalog =" & BrojNaloga & " WHERE Godina=" & Godina & " And Broj=" & CLng(txtBroj.Text) & " And IzMagacina=" & TekuciMagacin)


    'End Sub
    'Sub PreknjizavanjeFinansijskogNaloga()

    '    InsertData("DELETE FROM FinansijskiNalog WHERE VrstaNaloga='PN' AND Broj=" & txtBroj.Text & " AND  Oznaka=" & TekuciMagacin & " AND Godina=" & Godina)
    '    InsertData("DELETE FROM FinansijskiNalogStavke WHERE VrstaNaloga='PN' AND BrojNaloga=" & txtBroj.Text & " AND  Oznaka=" & TekuciMagacin & " AND Godina=" & Godina)

    '    FinansijskiNalog(4, "PN")

    'End Sub


    'Private Sub tmrDelay_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrDelay.Tick
    '    pnlOK.Visible = False

    '    cmdNovi.Enabled = True
    '    cmdSnimi.Enabled = True
    '    cmdKnjizenje.Enabled = True
    '    CmdNalog.Enabled = True
    '    cmdStampa.Enabled = True

    '    tmrDelay.Enabled = False
    'End Sub

#End Region


#Region "TASTERI"
    Private Sub cmdNovi_Click(sender As Object, e As EventArgs)

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
    Private Sub cmdSnimi_Click(sender As Object, e As EventArgs)
        Dim rs As DataTable

        If Parametri.PravoPristupa >= 2 Then
            If Godina <> TekucaGodina Then
                If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If

            If dtpDatum.Text = "" Or IsDate(dtpDatum.Text) = False Then
                MsgBox("Morate uneti datum!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            If IsNumeric(txtSifraUMagacin.Text) = False Then
                MsgBox("Morate izabrati magacin za koji radite dokument!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor

            If Parametri.Novi Then
                rs = GetData("SELECT * FROM PrenosnicaStavke WHERE BrojPrenosnice=" & MinusID & " And Magacin=" & TekuciMagacin & " And Godina=" & Godina)
                If rs.Rows.Count = 0 Then
                    MsgBox("Ne možete da snimite dokument koji nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                    Cursor = Cursors.Default
                    Exit Sub
                End If
                rs.Dispose()

                rs = GetData("SELECT MAX(Broj) AS Novi FROM Prenosnica WHERE Godina=" & Godina & " And IzMagacina=" & TekuciMagacin)
                If rs.Rows.Count = 0 Or IsDBNull(rs.Rows(0)!Novi) Then
                    txtBroj.Text = "1"
                Else
                    txtBroj.Text = rs.Rows(0)!Novi + 1
                End If

                InsertData("INSERT INTO Prenosnica VALUES(" & TekuciMagacin & "," & txtSifraUMagacin.Text & "," & CLng(txtBroj.Text) & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
                           & "','" & txtNapomena.Text & "','False','','" & TimeOfDay & "'," & Godina & "," & UserID & ")")

                InsertData("UPDATE PrenosnicaStavke SET BrojPrenosnice =" & CLng(txtBroj.Text) & " WHERE BrojPrenosnice =" & MinusID)

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                              & "','Novi dokument','" & DocStatus & "'," & txtBroj.Text & ",'" & CmbIzMagacina.Text & "')")

            Else
                If chkKnjizeno.Checked Then
                    If MsgBox("Snimanje proknjiženog dokumenta!" & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "PRENOSNICA") = MsgBoxResult.No Then
                        Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If

                rs = GetData("SELECT * FROM PrenosnicaStavke WHERE BrojPrenosnice=" & CLng(txtBroj.Text) & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                If rs.Rows.Count = 0 Then
                    MsgBox("Ne možete da snimite dokument koji nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                    Cursor = Cursors.Default
                    Exit Sub
                End If
                rs.Dispose()

                InsertData("UPDATE Prenosnica SET Datum='" & Format(CDate(dtpDatum.Text), FormatDatuma) & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND IzMagacina=" & TekuciMagacin)
                InsertData("UPDATE Prenosnica SET Napomena='" & txtNapomena.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND IzMagacina=" & TekuciMagacin)


                For n = 0 To grdStavke.Rows.Count - 1
                    InsertData("UPDATE PrenosnicaStavke SET NabavnaCena=" & grdStavke.Rows(n).Cells("NabavnaCena").Value & " WHERE BrojPrenosnice=" & CInt(txtBroj.Text) _
                               & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Rbr=" & grdStavke.Rows(n).Cells("Rbr").Value _
                               & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                    InsertData("UPDATE PrenosnicaStavke SET ProdajnaCena=" & grdStavke.Rows(n).Cells("ProdajnaCena").Value & " WHERE BrojPrenosnice=" & CInt(txtBroj.Text) _
                               & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Rbr=" & grdStavke.Rows(n).Cells("Rbr").Value _
                               & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                    InsertData("UPDATE PrenosnicaStavke SET Kolicina=" & grdStavke.Rows(n).Cells("Kolicina").Value & " WHERE BrojPrenosnice=" & CInt(txtBroj.Text) _
                               & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Rbr=" & grdStavke.Rows(n).Cells("Rbr").Value _
                               & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                    InsertData("UPDATE PrenosnicaStavke SET NabavniIznos=" & grdStavke.Rows(n).Cells("NabavniIznos").Value & " WHERE BrojPrenosnice=" & CInt(txtBroj.Text) _
                               & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Rbr=" & grdStavke.Rows(n).Cells("Rbr").Value _
                               & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                    InsertData("UPDATE PrenosnicaStavke SET ProdajniIznos=" & grdStavke.Rows(n).Cells("ProdajniIznos").Value & " WHERE BrojPrenosnice=" & CInt(txtBroj.Text) _
                               & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Rbr=" & grdStavke.Rows(n).Cells("Rbr").Value _
                               & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)

                Next

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','Korekcija','" & DocStatus & "'," & txtBroj.Text & ",'" & CmbIzMagacina.Text & "')")

            End If

            Cursor = Cursors.Default

            'cmdNovi.Enabled = False
            'cmdSnimi.Enabled = False
            'cmdKnjizenje.Enabled = False
            'CmdNalog.Enabled = False
            'cmdStampa.Enabled = False

            'pnlOK.Visible = True

            Parametri.Novi = False
            DajStavkePrenosnice(txtBroj.Text)
            'DajSumu(txtBroj.Text)
            'tmrDelay.Enabled = True

            Cursor = Cursors.Default
        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Cursor = Cursors.Default

    End Sub
    Private Sub cmdKnjizenje_Click(sender As Object, e As EventArgs)
        Dim rs As DataTable
        Dim rsN As DataTable
        Dim rsU As DataTable
        Dim Zaliha As Double
        Dim ZalihaUMagacin As Double

        If Parametri.PravoPristupa >= 2 Then
            If Godina <> TekucaGodina Then
                If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If

            If chkKnjizeno.Checked Then
                If MsgBox("Dokument je već proknjižen!" & vbCrLf & vbCrLf & "Da li želite da ga PREKNJIŽITE?", vbQuestion + vbYesNo, "PRENOSNICA") = vbYes Then
                    Cursor = Cursors.WaitCursor

                    'PreknjizavanjeKEPKnjige()
                    'PreknjizavanjeFinansijskogNaloga()

                    InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','PreKnjizavanje','" & DocStatus & "'," & txtBroj.Text & ",'" & CmbIzMagacina.Text & "')")
                Else
                    Cursor = Cursors.Default
                    Exit Sub
                End If
            Else
                If MsgBox("Knjiženje?" & vbCrLf & vbCrLf & "Nastavljate?", vbQuestion + vbYesNo, "PRENOSNICA") = vbYes Then
                    Cursor = Cursors.WaitCursor

                    ProveraArtikalaUMagacinu(txtBroj.Text, TekuciMagacin, rsStavke)
                    If ArtikalUMagacinu = False Then
                        MsgBox("Pronađeni su artikli koji se ne nalaze u izabranom magacinu!", MsgBoxStyle.Exclamation)
                        Cursor = Cursors.Default
                        FrmIzvestajStanja.ShowDialog()
                        Cursor = Cursors.Default
                        Exit Sub
                    End If

                    ProveraStanja(txtBroj.Text, TekuciMagacin, rsStavke)
                    If Manjak Then
                        If MsgBox("Nema dovoljne količine na stanju!" & vbCrLf & vbCrLf & "Da li želite da vidite izveštaj?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                        Cursor = Cursors.Default
                        FrmIzvestajStanja.ShowDialog()
                        Cursor = Cursors.Default
                        Exit Sub
                    End If

                    For n = 0 To grdStavke.Rows.Count - 1
                        rs = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)
                        rsU = GetData("SELECT * FROM Zaliha WHERE Magacin=" & CLng(txtSifraUMagacin.Text) & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)

                        Zaliha = rs.Rows(0)!Zaliha - rsStavke.Rows(n)!Kolicina
                        InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)
                        If rsU.Rows.Count = 0 Then
                            InsertData("INSERT INTO Zaliha Values(" & CLng(cmbUMagacin.SelectedValue) & "," & grdStavke.Rows(n).Cells("SifraArtikla").Value & ",''," & FormatNumber(grdStavke.Rows(n).Cells("Kolicina").Value, 4,,, TriState.False) & ",0)")
                        Else
                            ZalihaUMagacin = rsU.Rows(0)!Zaliha + grdStavke.Rows(n).Cells("Kolicina").Value
                            InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(ZalihaUMagacin, 4,,, TriState.False) & " WHERE Magacin=" & CLng(txtSifraUMagacin.Text) & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)
                        End If

                    Next

                    Cursor = Cursors.Default

                    rsN = GetData("SELECT * FROM FinansijskiNalog WHERE Broj=" & CLng(txtBroj.Text) & " AND VrstaNaloga ='PN' AND Oznaka=" & TekuciMagacin & " AND Godina=" & Godina)
                    If rsN.Rows.Count > 0 Then
                        MsgBox("Finansijski nalog sa ovim brojem već postoji!", MsgBoxStyle.Exclamation)
                        Cursor = Cursors.Default
                        Exit Sub
                    End If

                    Cursor = Cursors.WaitCursor

                    'KnjizenjeKEPKnjiga()
                    'FinansijskiNalog(4, "PN")

                    'cmdNovi.Enabled = False
                    'cmdSnimi.Enabled = False
                    'cmdKnjizenje.Enabled = False
                    'CmdNalog.Enabled = False
                    'cmdStampa.Enabled = False
                    'pnlOK.Visible = True

                    'tmrDelay.Enabled = True

                    Cursor = Cursors.Default
                    InsertData("UPDATE Prenosnica SET Knjizeno = 'True' WHERE Godina=" & Godina & " AND Broj=" & CLng(txtBroj.Text) & " AND IzMagacina=" & TekuciMagacin)
                    InsertData("UPDATE Prenosnica SET Vreme ='" & TimeOfDay & "' WHERE Godina=" & Godina & " AND Broj=" & CLng(txtBroj.Text) & " AND IzMagacina=" & TekuciMagacin)
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

        Cursor = Cursors.Default
    End Sub
    'Private Sub CmdNalog_Click(sender As Object, e As EventArgs)

    '    If chkKnjizeno.Checked = False Or IsNumeric(txtBrojFinansijskogNaloga.Text) = False Then
    '        MsgBox("Dokument nema formiran finansijski nalog!", vbExclamation, "PRENOSNICA")
    '        Exit Sub
    '    End If

    '    Parametri.Broj = CLng(txtBrojFinansijskogNaloga.Text)
    '    Parametri.NalogOznaka = TekuciMagacin
    '    Parametri.NalogVrsta = "PN"

    '    frmNalogZaKnjizenje.Dispose()
    '    Hide()
    '    frmNalogZaKnjizenje.ShowDialog()
    '    Show()

    'End Sub
    Private Sub cmdStampa_Click(sender As Object, e As EventArgs)

        'Cursor = Cursors.WaitCursor

        'InsertData("UPDATE Parametri SET Broj=" & CLng(txtBroj.Text))
        'InsertData("UPDATE Parametri SET Magacin=" & TekuciMagacin)
        'InsertData("UPDATE Parametri SET Godina=" & Godina)

        'Parametri.NazivIzvestaja = "Prenosnica.rpt"

        'FrmPreView.ShowDialog()

        'Cursor = Cursors.Default
    End Sub
    Private Sub cmdIzlaz_Click(sender As Object, e As EventArgs)
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
    Private Sub txtNapomena_DoubleClick(sender As Object, e As EventArgs) Handles txtNapomena.DoubleClick
        Dim tb = TryCast(sender, TextBox)
        tb.ReadOnly = False
    End Sub



#End Region


End Class

