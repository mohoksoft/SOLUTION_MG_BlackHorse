Imports System.Drawing.Drawing2D

Public Class frmPopis
    Dim rsPopis As DataTable
    Dim rsStavke As DataTable
    Dim Selected As Boolean
    Dim SelektovanaKolona As String


#Region "FORMA"
    Private Sub frmPopis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lFont As Font

        lFont = New Font("Calibri", 11, FontStyle.Bold, GraphicsUnit.Point)
        grdStavke.ColumnHeadersDefaultCellStyle.Font = lFont
        lFont = New Font("Verdana", 9.75, FontStyle.Regular, GraphicsUnit.Point)
        grdStavke.RowsDefaultCellStyle.Font = lFont

        SifarnikMagacina.KontrolaZaPrikaz = CmbMagacin
        SifarnikMagacina.PuniKontrolu()
        CmbMagacin.SelectedValue = TekuciMagacin
        txtSifraMagacina.Text = CmbMagacin.SelectedValue

        ArtikliStavke.Puni()
        GridZaListuStavkiArtikala(GrdListaStavki)
        ArtikliStavke.DajSve()

        chkPrenosStanja.Checked = True
        ChkPojedinacniUnos.Checked = True

        If Parametri.Novi = False Then
            rsPopis = GetData("SELECT * FROM Popis WHERE Broj=" & Parametri.Broj & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
            txtSifraMagacina.Text = rsPopis.Rows(0)!Magacin
            txtBroj.Text = rsPopis.Rows(0)!Broj

            dtpDatum.Value = rsPopis.Rows(0)!Datum
            txtNapomena.Text = rsPopis.Rows(0)!Napomena.ToString
            chkKnjizeno.Checked = rsPopis.Rows(0)!Knjizeno
            ChkPocetnoStanje.Checked = rsPopis.Rows(0)!PocetnoStanje
            ChkZavrsniPopis.Checked = rsPopis.Rows(0)!ZavrsniPopis

            DajStavkePopisa(txtBroj.Text, chkNaStanju.Checked)
            'DajSumu(txtBroj.Text)

        Else
            InsertData("DELETE FROM PopisStavke WHERE BrojPopisa=" & MinusID)
        End If

        GrdListaStavki.Visible = False

        TxtNazivArtikla.Select()

    End Sub
    Private Sub frmPopis_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim rs As DataTable

        If Parametri.Novi = False Then
            rs = GetData("SELECT * FROM PopisStavke WHERE BrojPopisa=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
            If rs.Rows.Count = 0 Then
                Cursor = Cursors.Default
                MsgBox("Dokument nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
        End If

    End Sub
    Private Sub frmPopis_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Parametri.Novi = False

    End Sub

#End Region


#Region "TXT stavke"
    Private Sub TxtNazivArtikla_TextChanged(sender As Object, e As EventArgs) Handles TxtNazivArtikla.TextChanged

        If TxtNazivArtikla.Text = "" Then
            txtSifraArtikla.Text = ""
            txtJM.Text = ""
            TxtNabavnaCena.Text = ""
            TxtProdajnaCena.Text = ""
            txtStaroStanje.Text = ""
            txtNovoStanje.Text = ""
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

            txtStaroStanje.Text = FormatNumber(DajStanje(txtSifraArtikla.Text, TekuciMagacin, TekucaGodina), 2,,, TriState.True)
            'TxtNabavnaCena.Text = FormatNumber(DajCenuProsecnuNabavnu(txtSifraArtikla.Text, TekuciMagacin, TekucaGodina), 2,,, TriState.True)
            'TxtProdajnaCena.Text = FormatNumber(DajCenuProdajnu(txtSifraArtikla.Text, TekuciMagacin, TekucaGodina), 2,,, TriState.True)

            GrdListaStavki.Visible = False

            txtNovoStanje.Select()

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

                txtStaroStanje.Text = FormatNumber(DajStanje(txtSifraArtikla.Text, TekuciMagacin, TekucaGodina), 2,,, TriState.True)
                'TxtNabavnaCena.Text = FormatNumber(DajCenuProsecnuNabavnu(txtSifraArtikla.Text, TekuciMagacin, TekucaGodina), 2,,, TriState.True)
                'TxtProdajnaCena.Text = FormatNumber(DajCenuProdajnu(txtSifraArtikla.Text, TekuciMagacin, TekucaGodina), 2,,, TriState.True)

                GrdListaStavki.Visible = False

                txtNovoStanje.Select()

            End If
        End If
    End Sub
    Private Sub txtNovoStanje_TextChanged(sender As Object, e As EventArgs) Handles txtNovoStanje.TextChanged
        If IsNumeric(txtNovoStanje.Text) And IsNumeric(TxtNabavnaCena.Text) And IsNumeric(TxtProdajnaCena.Text) Then
            TxtNabavniIznos.Text = FormatNumber((CDbl(txtNovoStanje.Text) * CDbl(TxtNabavnaCena.Text)), 2,,, TriState.True)
            TxtProdajniIznos.Text = FormatNumber((CDbl(txtNovoStanje.Text) * CDbl(TxtProdajnaCena.Text)), 2,,, TriState.True)
        Else
            TxtNabavniIznos.Text = "0"
            TxtProdajniIznos.Text = "0"
        End If
    End Sub
    Private Sub txtNovoStanje_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNovoStanje.KeyDown
        Dim rs As DataTable
        Dim Iznos As Double = 0

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
                    txtNovoStanje.Select()
                    Exit Sub
                End If

                If txtNovoStanje.Text = "" Or IsNumeric(txtNovoStanje.Text) = False Then
                    MsgBox("Greska pri unosu stanja!", MsgBoxStyle.Exclamation)
                    txtNovoStanje.Select()
                    Exit Sub
                End If

                If Parametri.Novi Then
                    rs = GetData("SELECT * FROM PopisStavke WHERE SifraArtikla=" & txtSifraArtikla.Text & " AND BrojPopisa=" & MinusID _
                                & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                    If rs.Rows.Count > 0 Then
                        If MsgBox("Unosite artikal koji već postoji u ovom dokumentu!" & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                    End If
                    rs.Dispose()

                    InsertData("INSERT INTO PopisStavke VALUES(" & TekuciMagacin & "," & MinusID & ",0," & CLng(txtSifraArtikla.Text) & ",'" & TxtNazivArtikla.Text _
                                & "','','" & txtJM.Text & "'," & FormatNumber(TxtNabavnaCena.Text, 2,,, TriState.False) & "," & FormatNumber(TxtProdajnaCena.Text, 2,,, TriState.False) _
                                & "," & FormatNumber(txtStaroStanje.Text, 2,,, TriState.False) & "," & FormatNumber(txtNovoStanje.Text, 2,,, TriState.False) _
                                & "," & FormatNumber(TxtNabavniIznos.Text, 2,,, TriState.False) & "," & FormatNumber(TxtProdajniIznos.Text, 2,,, TriState.False) & "," & Godina & ")")

                    DajStavkePopisa(MinusID, chkNaStanju.Checked)
                    'DajSumu(MinusID)
                Else
                    rs = GetData("SELECT * FROM PopisStavke WHERE SifraArtikla=" & txtSifraArtikla.Text & " AND BrojPopisa=" & CLng(txtBroj.Text) _
                                 & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                    If rs.Rows.Count > 0 Then
                        If MsgBox("Unosite artikal koji već postoji u ovom dokumentu!" & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                    End If
                    rs.Dispose()

                    InsertData("INSERT INTO PopisStavke VALUES(" & TekuciMagacin & "," & CLng(txtBroj.Text) & ",0," & CLng(txtSifraArtikla.Text) & ",'" & TxtNazivArtikla.Text _
                                & "','','" & txtJM.Text & "'," & FormatNumber(TxtNabavnaCena.Text, 2,,, TriState.False) & "," & FormatNumber(TxtProdajnaCena.Text, 2,,, TriState.False) _
                                & "," & FormatNumber(txtStaroStanje.Text, 2,,, TriState.False) & "," & FormatNumber(txtNovoStanje.Text, 2,,, TriState.False) _
                                & "," & FormatNumber(TxtNabavniIznos.Text, 2,,, TriState.False) & "," & FormatNumber(TxtProdajniIznos.Text, 2,,, TriState.False) & "," & Godina & ")")

                    '***knjizenje u zalihama stavke koja se dodaje u proknjizenom dokumentu***!!!! ne jer ne moze da se isprati u kom trenutku se dodaje stavka****
                    'If chkKnjizeno.Checked Then
                    '    rsR = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & txtSifraArtikla.Text)
                    '    If rs.Rows.Count = 0 Then
                    '        MsgBox("Greška pri knjiženju!" & vbCrLf & vbCrLf & "Artikal se ne nalaze u magacinu koji se popisuje.", MsgBoxStyle.Exclamation, "POPIS")
                    '        Exit Sub
                    '    Else
                    '        InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & txtSifraArtikla.Text)
                    '    End If

                    '    InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                    '       & "','Dodavanje u proknjizenom','" & DocStatus & "'," & txtBroj.Text & ",'" & TxtNazivArtikla.Text & "')")

                    'End If


                    DajStavkePopisa(txtBroj.Text, chkNaStanju.Checked)
                    'DajSumu(txtBroj.Text)
                End If


                txtSifraArtikla.Text = ""
                TxtNazivArtikla.Text = ""
                txtJM.Text = ""
                TxtNabavnaCena.Text = ""
                TxtProdajnaCena.Text = ""
                txtStaroStanje.Text = ""
                txtNovoStanje.Text = ""
                TxtNabavniIznos.Text = ""
                TxtProdajniIznos.Text = ""
                TxtNazivArtikla.Select()

            Else
                MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Exclamation)
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
                grdStavke.Rows(e.RowIndex).Cells("NabavniIznos").Value = FormatNumber((grdStavke.Rows(e.RowIndex).Cells("NabavnaCena").Value * (grdStavke.Rows(e.RowIndex).Cells("NovoStanje").Value)), 2,,, TriState.False)

            Case "ProdajnaCena"
                grdStavke.Rows(e.RowIndex).Cells("ProdajniIznos").Value = FormatNumber((grdStavke.Rows(e.RowIndex).Cells("ProdajnaCena").Value * (grdStavke.Rows(e.RowIndex).Cells("NovoStanje").Value)), 2,,, TriState.False)

            Case "NovoStanje"
                grdStavke.Rows(e.RowIndex).Cells("NabavniIznos").Value = FormatNumber((grdStavke.Rows(e.RowIndex).Cells("NabavnaCena").Value * (grdStavke.Rows(e.RowIndex).Cells("NovoStanje").Value)), 2,,, TriState.False)
                grdStavke.Rows(e.RowIndex).Cells("ProdajniIznos").Value = FormatNumber((grdStavke.Rows(e.RowIndex).Cells("ProdajnaCena").Value * (grdStavke.Rows(e.RowIndex).Cells("NovoStanje").Value)), 2,,, TriState.False)

                'DajSumu(txtBroj.Text, False)
        End Select
    End Sub
    Private Sub grdStavke_KeyDown(sender As Object, e As KeyEventArgs) Handles grdStavke.KeyDown
        Dim rs As DataTable
        'Dim rsZaliha As DataTable
        'Dim Zaliha As Double

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
                            InsertData("DELETE FROM PopisStavke WHERE BrojPopisa=" & MinusID & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                    & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value)
                        End If
                    Next

                    DajStavkePopisa(MinusID, chkNaStanju.Checked)
                    'DajSumu(MinusID)
                Else
                    rs = GetData("SELECT * FROM PopisStavke WHERE BrojPopisa=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                    If rs.Rows.Count = 1 Then
                        Cursor = Cursors.Default
                        MsgBox("Ne možete brisati jedinu stavku u dokumentu!", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If

                    For n = 0 To grdStavke.RowCount - 1
                        Cursor = Cursors.WaitCursor
                        If grdStavke.Rows(n).Selected Then
                            InsertData("DELETE FROM PopisStavke WHERE BrojPopisa=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                    & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value)

                            'knjizenje u zalihama stavke koja se brise u proknjizenom dokumentu
                            'If chkKnjizeno.Checked Then
                            '    rsZaliha = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND BarCod=''")
                            '    Zaliha = (rsZaliha.Rows(0)!Zaliha + grdStavke.Rows(n).Cells("Kolicina").Value)
                            '    InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin _
                            '                & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND BarCod=''")

                            InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                    & "','Brisanje u proknjizenoj','" & DocStatus & "'," & txtBroj.Text & ",'" & grdStavke.Rows(n).Cells("SifraArtikla").Value & "')")

                            'End If

                        End If
                    Next

                    DajStavkePopisa(txtBroj.Text, chkNaStanju.Checked)
                    'DajSumu(txtBroj.Text)
                End If
            Else
                MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Cursor = Cursors.Default

        End If
    End Sub
    Private Sub grdStavke_MouseClick(sender As Object, e As MouseEventArgs) Handles grdStavke.MouseClick
        Dim hit As DataGridView.HitTestInfo = grdStavke.HitTest(e.X, e.Y)

        If hit.RowIndex > grdStavke.RowCount - 1 Or hit.RowIndex < 0 Then Exit Sub

        If IsDBNull(grdStavke.Rows(hit.RowIndex).Cells(0).Value) Then Exit Sub

        If e.Button = MouseButtons.Right Then
            For n = 0 To grdStavke.SelectedRows.Count - 1
                If n > grdStavke.SelectedRows.Count Then Exit For
                grdStavke.SelectedRows(n).Selected = False
            Next

            For n = 0 To grdStavke.SelectedCells.Count - 1
                If n > grdStavke.SelectedCells.Count - 1 Then Exit For
                grdStavke.SelectedCells(n).Selected = False
            Next

            Parametri.Sortiranje = grdStavke.Columns(hit.ColumnIndex).Name
            grdStavke.Rows(hit.RowIndex).Selected = True
            grdStavke.Columns(hit.ColumnIndex).Selected = True
            mnuPopis.Show(grdStavke, e.X, e.Y)
        End If
    End Sub

    Private Sub TxtGrupaSifre_TextChanged(sender As Object, e As EventArgs) Handles TxtGrupaSifre.TextChanged

        If Parametri.Novi Then
            If IsNumeric(TxtGrupaSifre.Text) Then
                If TxtGrupaSifre.Text > 0 Then
                    DajStavkePopisa(MinusID, chkNaStanju.Checked)
                    'DajSumu(MinusID)
                Else
                    grdStavke.DataSource = Nothing
                    'DajSumu(MinusID)
                End If
            Else
                DajStavkePopisa(MinusID, chkNaStanju.Checked)
                'DajSumu(MinusID)
            End If
        Else
            If IsNumeric(TxtGrupaSifre.Text) Then
                If TxtGrupaSifre.Text > 0 Then
                    DajStavkePopisa(txtBroj.Text, chkNaStanju.Checked)
                    'DajSumu(txtBroj.Text)
                Else
                    grdStavke.DataSource = Nothing
                    'DajSumu(txtBroj.Text)
                End If
            Else
                DajStavkePopisa(txtBroj.Text, chkNaStanju.Checked)
                'DajSumu(txtBroj.Text)
            End If
        End If


    End Sub


#End Region


#Region "MNU"
    Private Sub mnuBrisanje_Click(sender As Object, e As EventArgs) Handles mnuBrisanje.Click
        Dim rs As DataTable
        'Dim rsZaliha As DataTable
        'Dim Zaliha As Double

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
                        InsertData("DELETE FROM PopisStavke WHERE BrojPopisa=" & MinusID & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                    & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value)
                    End If
                Next

                DajStavkePopisa(MinusID, chkNaStanju.Checked)
                'DajSumu(MinusID)
            Else
                rs = GetData("SELECT * FROM PopisStavke WHERE BrojPopisa=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                If rs.Rows.Count = 1 Then
                    Cursor = Cursors.Default
                    MsgBox("Ne možete brisati jedinu stavku u dokumentu!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                For n = 0 To grdStavke.RowCount - 1
                    Cursor = Cursors.WaitCursor
                    If grdStavke.Rows(n).Selected Then
                        InsertData("DELETE FROM PopisStavke WHERE BrojPopisa=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                    & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value)

                        'knjizenje u zalihama stavke koja se brise u proknjizenom dokumentu
                        'If chkKnjizeno.Checked Then
                        '    rsZaliha = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND BarCod=''")
                        '    Zaliha = (rsZaliha.Rows(0)!Zaliha + grdStavke.Rows(n).Cells("Kolicina").Value)
                        '    InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin _
                        '                & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND BarCod=''")

                        InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                    & "','Brisanje u proknjizenoj','" & DocStatus & "'," & txtBroj.Text & ",'" & grdStavke.Rows(n).Cells("SifraArtikla").Value & "')")

                        'End If

                    End If
                Next

                DajStavkePopisa(txtBroj.Text, chkNaStanju.Checked)
                'DajSumu(txtBroj.Text)
            End If
        Else
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Cursor = Cursors.Default

    End Sub
    Private Sub mnuAzurirajRbr_Click(sender As Object, e As EventArgs) Handles mnuAzurirajRbr.Click

        If Parametri.PravoPristupa >= 2 Then

            Cursor = Cursors.WaitCursor

            AzurirajRbr(txtBroj.Text)
            DajStavkePopisa(txtBroj.Text, chkNaStanju.Checked)
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
        Dim rs As DataTable
        Dim NabavniIznos As Double = 0
        Dim ProdajniIznos As Double = 0

        Parametri.Novi = True

        Cursor = Cursors.WaitCursor

        InsertData("DELETE FROM PopisStavke WHERE BrojPopisa=" & MinusID)

        txtBroj.Text = "0"
        txtSifraMagacina.Text = TekuciMagacin

        If Godina <> TekucaGodina Then
            dtpDatum.Text = "31/12/" & Godina
        Else
            dtpDatum.Text = Format(Now, "dd/M/yyyy")
        End If

        chkKnjizeno.Checked = False

        txtNapomena.Text = ""

        grdStavke.DataSource = Nothing

        'CmdNovi.Enabled = False
        'CmdSnimi.Enabled = True
        'CmdKnjizenje.Enabled = False
        'CmdPocetnoStanje.Enabled = False
        'CmdZavrsniPopis.Enabled = False
        'cmdPopisnaLista.Enabled = False
        'CmdStampa.Enabled = False

        If ChkPojedinacniUnos.Checked = False Then
            rs = GetData("SELECT dbo.SifarnikArtikli.Sifra, dbo.SifarnikArtikli.Grupa, dbo.SifarnikArtikli.Naziv, dbo.SifarnikArtikli.JedinicaMere, " _
                            & "dbo.SifarnikArtikli.Pasivan, dbo.Zaliha.Zaliha, dbo.Cenovnik.ProsecnaNabavnaCena,  dbo.Cenovnik.ProdajnaCena " _
                            & "From dbo.Cenovnik INNER JOIN dbo.SifarnikArtikli ON dbo.Cenovnik.SifraArtikla = dbo.SifarnikArtikli.Sifra " _
                            & "Left OUTER JOIN dbo.Zaliha ON dbo.SifarnikArtikli.Sifra = dbo.Zaliha.Sifra " _
                            & "WHERE dbo.Zaliha.Magacin =" & TekuciMagacin & " AND Cenovnik.Magacin=" & TekuciMagacin & " And SifarnikArtikli.Pasivan='False' ORDER BY dbo.SifarnikArtikli.Naziv")

            For n = 0 To rs.Rows.Count - 1
                If chkPrenosStanja.Checked Then
                    NabavniIznos = (rs(n)!ProsecnaNabavnaCena) * (rs(n)!Zaliha)
                    ProdajniIznos = (rs(n)!ProdajnaCena) * (rs(n)!Zaliha)
                    InsertData("INSERT INTO PopisStavke VALUES(" & TekuciMagacin & "," & MinusID & "," & rs.Rows(n)!Grupa & "," & rs.Rows(n)!Sifra & ",'" & rs.Rows(n)!Naziv _
                            & "','','" & rs.Rows(n)!JedinicaMere & "'," & FormatNumber(rs.Rows(n)!ProsecnaNabavnaCena, 2,,, TriState.False) & "," & FormatNumber(rs.Rows(n)!ProdajnaCena, 2,,, TriState.False) _
                            & "," & FormatNumber(rs.Rows(n)!Zaliha, 2,,, TriState.False) & "," & FormatNumber(rs.Rows(n)!Zaliha, 2,,, TriState.False) _
                            & "," & FormatNumber(NabavniIznos, 2,,, TriState.False) & "," & FormatNumber(ProdajniIznos, 2,,, TriState.False) & "," & Godina & ")")
                Else
                    InsertData("INSERT INTO PopisStavke VALUES(" & TekuciMagacin & "," & MinusID & "," & rs.Rows(n)!Grupa & "," & rs.Rows(n)!Sifra & ",'" & rs(n)!Naziv _
                            & "','','" & rs(n)!JedinicaMere & "'," & FormatNumber(rs(n)!ProsecnaNabavnaCena, 2,,, TriState.False) & "," & FormatNumber(rs.Rows(n)!ProdajnaCena, 2,,, TriState.False) _
                            & "," & FormatNumber(rs(n)!Zaliha, 2,,, TriState.False) & ",0,0,0," & Godina & ")")
                End If
                NabavniIznos = 0
                ProdajniIznos = 0
            Next
        End If

        DajStavkePopisa(MinusID, chkNaStanju.Checked)
        'DajSumu(MinusID)

        Cursor = Cursors.Default
    End Sub
    Sub DajStavkePopisa(Broj As Long, NaStanju As Boolean)

        If NaStanju Then
            If TxtGrupaSifre.Text = "" Then
                rsStavke = GetData("SELECT BrojPopisa, SifraArtikla, NazivArtikla, JedinicaMere, NabavnaCena, ProdajnaCena, StaroStanje, NovoStanje, NabavniIznos, ProdajniIznos, ID 
                                FROM  dbo.PopisStavke WHERE PopisStavke.Magacin=" & TekuciMagacin _
                                & "AND PopisStavke.BrojPopisa=" & Broj & " AND StaroStanje>0 AND PopisStavke.Godina=" & Godina & " ORDER BY PopisStavke.SifraArtikla")
            Else
                rsStavke = GetData("SELECT BrojPopisa, SifraArtikla, NazivArtikla, JedinicaMere, NabavnaCena, ProdajnaCena, StaroStanje, NovoStanje, NabavniIznos, ProdajniIznos, ID 
                                FROM  dbo.PopisStavke WHERE PopisStavke.Magacin=" & TekuciMagacin _
                                & "AND PopisStavke.BrojPopisa=" & Broj & " AND SifraArtikla Like '" & TxtGrupaSifre.Text & "%' AND PopisStavke.Godina=" & Godina & " ORDER BY PopisStavke.SifraArtikla")
            End If
        Else
            If TxtGrupaSifre.Text = "" Then
                rsStavke = GetData("SELECT BrojPopisa, SifraArtikla, NazivArtikla, JedinicaMere, NabavnaCena, ProdajnaCena, StaroStanje, NovoStanje, NabavniIznos, ProdajniIznos, ID 
                                FROM  dbo.PopisStavke WHERE PopisStavke.Magacin=" & TekuciMagacin _
                                & "AND PopisStavke.BrojPopisa=" & Broj & " AND PopisStavke.Godina=" & Godina & " ORDER BY PopisStavke.SifraArtikla")
            Else
                rsStavke = GetData("SELECT BrojPopisa, SifraArtikla, NazivArtikla, JedinicaMere, NabavnaCena, ProdajnaCena, StaroStanje, NovoStanje, NabavniIznos, ProdajniIznos, ID 
                                FROM  dbo.PopisStavke WHERE PopisStavke.Magacin=" & TekuciMagacin _
                                & "AND PopisStavke.BrojPopisa=" & Broj & " AND SifraArtikla Like '" & TxtGrupaSifre.Text & "%' AND PopisStavke.Godina=" & Godina & " ORDER BY PopisStavke.SifraArtikla")
            End If
        End If
        ' RashodStavke.NabavnaCena, RashodStavke.ProdajnaCena, RashodStavke.Kolicina, RashodStavke.NabavniIznos, RashodStavke.ProdajniIznos, RashodStavke.ID

        grdStavke.DataSource = rsStavke

        grdStavke.Columns("BrojPopisa").Visible = False
        grdStavke.Columns("SifraArtikla").Width = 80
        grdStavke.Columns("SifraArtikla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("SifraArtikla").HeaderText = "ŠIFRA"
        grdStavke.Columns("NazivArtikla").Width = 420
        grdStavke.Columns("NazivArtikla").HeaderText = "NAZIV ARTIKLA"
        grdStavke.Columns("NazivArtikla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("JedinicaMere").Width = 50
        grdStavke.Columns("JedinicaMere").HeaderText = "J.M."
        grdStavke.Columns("JedinicaMere").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdStavke.Columns("NabavnaCena").Width = 110
        grdStavke.Columns("NabavnaCena").HeaderText = "NAB.CENA"
        grdStavke.Columns("NabavnaCena").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("NabavnaCena").DefaultCellStyle.Format = "###,###,##0.00"
        grdStavke.Columns("ProdajnaCena").Width = 110
        grdStavke.Columns("ProdajnaCena").HeaderText = "PROD.CENA"
        grdStavke.Columns("ProdajnaCena").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("ProdajnaCena").DefaultCellStyle.Format = "###,###,##0.00"
        grdStavke.Columns("StaroStanje").Width = 90
        grdStavke.Columns("StaroStanje").HeaderText = "Staro stanje"
        grdStavke.Columns("StaroStanje").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("StaroStanje").DefaultCellStyle.Format = "###,###,##0.00"
        grdStavke.Columns("NovoStanje").Width = 90
        grdStavke.Columns("NovoStanje").HeaderText = "Novo stanje"
        grdStavke.Columns("NovoStanje").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("NovoStanje").DefaultCellStyle.Format = "###,###,##0.00"
        grdStavke.Columns("NabavniIznos").Width = 120
        grdStavke.Columns("NabavniIznos").HeaderText = "NAB.IZNOS"
        grdStavke.Columns("NabavniIznos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("NabavniIznos").DefaultCellStyle.Format = "###,###,##0.00"
        grdStavke.Columns("ProdajniIznos").Width = 120
        grdStavke.Columns("ProdajniIznos").HeaderText = "NAB.IZNOS"
        grdStavke.Columns("ProdajniIznos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("ProdajniIznos").DefaultCellStyle.Format = "###,###,##0.00"
        grdStavke.Columns("ID").Visible = False

    End Sub
    'Sub DajSumu(Broj As Integer, Optional Maloprodaja As Boolean = False, Optional Grid As Boolean = False)
    '    Dim NabavnaVrednostRobe As Double
    '    Dim ProdajnaVrednostRobe As Double

    '    LblNabavnaVrednost.Text = "0.00"
    '    LblProdajnaVrednosti.Text = "0.00"

    '    For n = 0 To grdStavke.RowCount - 1
    '        NabavnaVrednostRobe += grdStavke.Rows(n).Cells("NabavniIznos").Value
    '        ProdajnaVrednostRobe += grdStavke.Rows(n).Cells("ProdajniIznos").Value
    '    Next

    '    LblNabavnaVrednost.Text = FormatNumber(NabavnaVrednostRobe, 2, , , TriState.True)
    '    LblProdajnaVrednosti.Text = FormatNumber(ProdajnaVrednostRobe, 2, , , TriState.True)

    'End Sub
    Sub AzurirajRbr(Broj As Integer)
        Dim rs As DataTable

        rs = GetData("SELECT * FROM PopisStavke WHERE BrojPopisa=" & Broj & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin & " ORDER BY ID")

        For n = 0 To rs.Rows.Count - 1
            InsertData("UPDATE PopisStavke SET RBr=" & n + 1 & " WHERE BrojPopisa=" & Broj & " AND Godina=" & Godina _
                           & " AND ID=" & rs(n)!ID & " AND Magacin=" & TekuciMagacin)
        Next

    End Sub


    'Private Sub tmrDelay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDelay.Tick
    '    pnlOK.Visible = False

    '    CmdNovi.Enabled = True
    '    CmdSnimi.Enabled = True
    '    CmdKnjizenje.Enabled = True
    '    CmdPocetnoStanje.Enabled = True
    '    CmdZavrsniPopis.Enabled = True
    '    cmdPopisnaLista.Enabled = True
    '    CmdStampa.Enabled = True


    '    tmrDelay.Enabled = False
    'End Sub

#End Region


#Region "TASTERI"
    Private Sub cmdNovi_Click(sender As Object, e As EventArgs)
        If Godina <> TekucaGodina Then
            If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
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
            If IsNumeric(txtSifraMagacina.Text) = False Then
                MsgBox("Morate izabrati magacin za koji radite dokument!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor

            If Parametri.Novi Then
                rs = GetData("SELECT * FROM PopisStavke WHERE BrojPopisa=" & MinusID & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                If rs.Rows.Count = 0 Then
                    MsgBox("Ne možete da snimite dokument koji nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                    Cursor = Cursors.Default
                    Exit Sub
                End If
                rs.Dispose()

                rs = GetData("SELECT MAX(Broj) AS Novi FROM Popis WHERE Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                If IsDBNull(rs(0)!Novi) Or rs.Rows.Count = 0 Then
                    txtBroj.Text = "1"
                Else
                    txtBroj.Text = rs(0)!Novi + 1
                End If

                InsertData("INSERT INTO Popis VALUES(" & TekuciMagacin & "," & CLng(txtBroj.Text) & ",'" & Format(CDate(dtpDatum.Text), FormatDatuma) _
                       & "','" & txtNapomena.Text & "','False','False','False','','" & TimeOfDay & "'," & Godina & "," & UserID & ")")

                InsertData("UPDATE PopisStavke SET BrojPopisa=" & CInt(txtBroj.Text) & " WHERE BrojPopisa=" & MinusID)

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','Novi dokument','" & DocStatus & "'," & txtBroj.Text & ",'" & CmbMagacin.Text & "')")

            Else
                If chkKnjizeno.Checked Then
                    If MsgBox("Snimanje proknjiženog dokumenta!" & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "POPIS") = MsgBoxResult.No Then
                        Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If

                rs = GetData("SELECT * FROM PopisStavke WHERE BrojPopisa=" & CLng(txtBroj.Text) & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
                If rs.Rows.Count = 0 Then
                    MsgBox("Ne možete da snimite dokument koji nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                    Cursor = Cursors.Default
                    Exit Sub
                End If
                rs.Dispose()

                InsertData("UPDATE Popis SET Datum='" & Format(CDate(dtpDatum.Text), FormatDatuma) & "' WHERE Magacin=" & TekuciMagacin & " AND Godina=" & Godina _
                       & " AND Broj=" & CInt(txtBroj.Text))
                InsertData("UPDATE Popis SET Napomena='" & txtNapomena.Text & "' WHERE Magacin=" & TekuciMagacin & " AND Godina=" & Godina _
                       & " AND Broj=" & CInt(txtBroj.Text))

                For n = 0 To grdStavke.Rows.Count - 1
                    InsertData("UPDATE PopisStavke SET NabavnaCena=" & FormatNumber(grdStavke.Rows(n).Cells("NabavnaCena").Value, 2,,, TriState.False) & " WHERE BrojPopisa=" & CInt(txtBroj.Text) _
                               & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value)
                    InsertData("UPDATE PopisStavke SET ProdajnaCena=" & FormatNumber(grdStavke.Rows(n).Cells("ProdajnaCena").Value, 2,,, TriState.False) & " WHERE BrojPopisa=" & CInt(txtBroj.Text) _
                               & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value)
                    InsertData("UPDATE PopisStavke SET NovoStanje=" & FormatNumber(grdStavke.Rows(n).Cells("NovoStanje").Value, 2,,, TriState.False) & " WHERE BrojPopisa=" & CInt(txtBroj.Text) _
                               & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value)
                    InsertData("UPDATE PopisStavke SET NabavniIznos=" & FormatNumber(grdStavke.Rows(n).Cells("NabavniIznos").Value, 2,,, TriState.False) & " WHERE BrojPopisa=" & CInt(txtBroj.Text) _
                              & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value)
                    InsertData("UPDATE PopisStavke SET ProdajniIznos=" & FormatNumber(grdStavke.Rows(n).Cells("ProdajniIznos").Value, 2,,, TriState.False) & " WHERE BrojPopisa=" & CInt(txtBroj.Text) _
                               & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina & " AND ID=" & grdStavke.Rows(n).Cells("ID").Value)

                Next

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','Korekcija','" & DocStatus & "'," & txtBroj.Text & ",'" & CmbMagacin.Text & "')")

            End If

            Cursor = Cursors.Default

            'CmdNovi.Enabled = False
            'CmdSnimi.Enabled = False
            'CmdKnjizenje.Enabled = False
            'CmdPocetnoStanje.Enabled = False
            'CmdZavrsniPopis.Enabled = False
            'cmdPopisnaLista.Enabled = False
            'CmdStampa.Enabled = False

            'pnlOK.Visible = True

            Parametri.Novi = False
            DajStavkePopisa(txtBroj.Text, chkNaStanju.Checked)
            'DajSumu(txtBroj.Text)
            tmrDelay.Enabled = True

            Cursor = Cursors.Default
        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Cursor = Cursors.Default

    End Sub
    Private Sub cmdKnjizenje_Click(sender As Object, e As EventArgs)

        If Parametri.PravoPristupa >= 2 Then
            If Godina <> TekucaGodina Then
                If MsgBox("Program nije startovan u tekućoj godini! " & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If

            '***Popis ne moze da se preknjizava, uneti artikal azurira se u kartici***
            If chkKnjizeno.Checked Then
                MsgBox("Ne možete da knjižite već proknjižen dokument!", vbExclamation, "POPIS")
                Exit Sub
            Else
                If MsgBox("Knjiženje?" & vbCrLf & vbCrLf & "Nastavljate?", vbQuestion + vbYesNo, "POPIS") = vbYes Then
                    Cursor = Cursors.WaitCursor

                    ProveraArtikalaUMagacinu(txtBroj.Text, TekuciMagacin, rsStavke)
                    If ArtikalUMagacinu = False Then
                        MsgBox("Pronađeni su artikli koji se ne nalaze u izabranom magacinu!", MsgBoxStyle.Exclamation)
                        Cursor = Cursors.Default
                        FrmIzvestajStanja.ShowDialog()
                        Cursor = Cursors.Default
                        Exit Sub
                    End If

                    For n = 0 To rsStavke.Rows.Count - 1
                        InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(rsStavke.Rows(n)!NovoStanje, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & rsStavke.Rows(n)!SifraArtikla)
                    Next

                    'KnjizenjeKEPKnjiga()

                    'CmdNovi.Enabled = False
                    'CmdSnimi.Enabled = False
                    'CmdKnjizenje.Enabled = False
                    'CmdPocetnoStanje.Enabled = False
                    'CmdZavrsniPopis.Enabled = False
                    'cmdPopisnaLista.Enabled = False
                    'CmdStampa.Enabled = False
                    'pnlOK.Visible = True

                    'tmrDelay.Enabled = True

                    Cursor = Cursors.Default
                    InsertData("UPDATE Popis SET Knjizeno ='True' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)

                    chkKnjizeno.Checked = True

                    Cursor = Cursors.Default
                Else
                    Cursor = Cursors.Default
                    Exit Sub
                End If
            End If
        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Cursor = Cursors.Default

    End Sub
    Private Sub CmdPocetnoStanje_Click(sender As Object, e As EventArgs)
        Dim rs As DataTable
        Dim rsK As DataTable
        Dim Rbr As Integer
        Dim Vrednost As Double = 0

        If Parametri.PravoPristupa >= 2 Then
            rs = GetData("SELECT * FROM PocetnoStanjeArtikala WHERE Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
            If rs.Rows.Count > 0 Then
                MsgBox("Za tekuću godinu već imate formirano početno stanje!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            rs.Dispose()

            If Parametri.Novi = True Then
                MsgBox("Morate prvo da snimite dokument!", MsgBoxStyle.Exclamation)
                Cursor = Cursors.Default
                Exit Sub
            End If

            If chkKnjizeno.Checked = False Then
                MsgBox("Morate prvo da proknjižite dokument!", vbExclamation, "POPIS")
                Exit Sub
            End If

            If MsgBox("Formirate početno stanje ze tekuću godinu za" & vbCrLf & vbCrLf & CmbMagacin.Text & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Cursor = Cursors.WaitCursor

                rs = GetData("SELECT * FROM PopisStavke WHERE BrojPopisa=" & CInt(txtBroj.Text) & " AND NovoStanje>0 AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)

                For n = 0 To rs.Rows.Count - 1
                    InsertData("INSERT INTO PocetnoStanjeArtikala VALUES(" & TekuciMagacin & ",0," & rs.Rows(n)!SifraArtikla & ",'" & rs.Rows(n)!NazivArtikla & "','','" & rs.Rows(n)!JedinicaMere _
                               & "'," & FormatNumber(rs.Rows(n)!NabavnaCena, 2,,, TriState.False) & "," & FormatNumber(rs.Rows(n)!ProdajnaCena, 2,,, TriState.False) _
                               & "," & FormatNumber(rs.Rows(n)!NovoStanje, 2,,, TriState.False) & "," & FormatNumber(rs.Rows(n)!NabavniIznos, 2,,, TriState.False) _
                               & "," & FormatNumber(rs.Rows(n)!ProdajniIznos, 2,,, TriState.False) & "," & Godina & ")")
                    Vrednost += rs.Rows(n)!ProdajniIznos
                Next

                rsK = GetData("SELECT MAX(RedniBroj) AS Novi FROM KEPKnjiga WHERE Godina=" & Godina & " AND Magacin=" & TekuciMagacin)
                If IsDBNull(rsK.Rows(0)!Novi) Or (rsK.Rows.Count = 0) Then
                    Rbr = 1
                Else
                    Rbr = rsK.Rows(0)!Novi + 1
                End If

                Cursor = Cursors.Default

                If Rbr <> 1 Then
                    MsgBox("Vrednost Početnog stanja treba da je pod rednim brojem 1 u KEP knjizi za tekuću godinu.", MsgBoxStyle.Exclamation)
                End If

                InsertData("INSERT INTO KEPKnjiga VALUES(" & TekuciMagacin & "," & Rbr & ",'01/01/" & Godina & "','Početno stanje',0,''," & FormatNumber(Vrednost, 2,,, TriState.False) & ",0," & Godina & ")")

                InsertData("UPDATE Popis SET PocetnoStanje ='True' WHERE Broj=" & CInt(txtBroj.Text) & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)

                Cursor = Cursors.Default

                ChkPocetnoStanje.Checked = True
            Else
                Cursor = Cursors.Default
                Exit Sub
            End If
        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


    End Sub
    Private Sub CmdZavrsniPopis_Click(sender As Object, e As EventArgs)
        Dim rs As DataTable

        If Parametri.PravoPristupa >= 2 Then
            If MsgBox("Formirate završno stanje ze tekuću godinu za " & vbCrLf & vbCrLf & CmbMagacin.Text & vbCrLf & vbCrLf & "Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            rs = GetData("SELECT * FROM Popis WHERE ZavrsniPopis='True' AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
            If rs.Rows.Count > 0 Then
                MsgBox("Završni popis već postoji!", MsgBoxStyle.Exclamation)
                Cursor = Cursors.Default
                Exit Sub
            End If

            If Parametri.Novi = True Then
                MsgBox("Morate prvo da snimite dokument!", MsgBoxStyle.Exclamation)
                Cursor = Cursors.Default
                Exit Sub
            End If

            If chkKnjizeno.Checked Then
                MsgBox("Morate prvo da proknjižite dokument!", vbExclamation, "POPIS")
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor

            InsertData("UPDATE Popis SET ZavrsniPopis ='True' WHERE Broj=" & CInt(txtBroj.Text) & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)

            Cursor = Cursors.Default

            ChkZavrsniPopis.Checked = True

        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

    End Sub
    Private Sub cmdPopisnaLista_Click(sender As Object, e As EventArgs)

        'Me.Cursor = Cursors.WaitCursor

        'Parametri.BrojDokumenta = CLng(txtBroj.Text)

        'Parametri.NazivIzvestaja = "PopisnaLista.rpt"

        ''frmPreView.ShowDialog()

        'Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdStampa_Click(sender As Object, e As EventArgs)

        'Cursor = Cursors.WaitCursor

        'InsertData("UPDATE Parametri SET Broj=" & CLng(txtBroj.Text))
        'InsertData("UPDATE Parametri SET Magacin=" & TekuciMagacin)
        'InsertData("UPDATE Parametri SET Godina=" & Godina)

        'Parametri.NazivIzvestaja = "PopisMagacina.rpt"

        'FrmPreView.ShowDialog()

        'Cursor = Cursors.Default

    End Sub
    Private Sub cmdIzlaz_Click(sender As Object, e As EventArgs)
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