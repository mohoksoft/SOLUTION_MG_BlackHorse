Imports System.Drawing.Drawing2D
Public Class FrmTrebovanje
    Dim rsTrebovanje As DataTable
    Dim rsStavke As DataTable
    Dim Selected As Boolean
    Dim Klik As Boolean

    Private Sub FrmTrebovanje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lFont As Font

        lFont = New Font("Calibri", 11, FontStyle.Bold, GraphicsUnit.Point)
        grdStavke.ColumnHeadersDefaultCellStyle.Font = lFont
        lFont = New Font("Verdana", 9.75, FontStyle.Regular, GraphicsUnit.Point)
        grdStavke.RowsDefaultCellStyle.Font = lFont

        SifarnikMagacina.KontrolaZaPrikaz = CmbMagacin
        SifarnikMagacina.PuniKontrolu()
        CmbMagacin.SelectedValue = TekuciMagacin
        txtSifraMagacina.Text = CmbMagacin.SelectedValue

        LblMagacin.Text = CmbMagacin.Text

        rsTrebovanje = GetData("SELECT * FROM Trebovanje WHERE Broj=" & Parametri.Broj & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)

        txtBroj.Text = rsTrebovanje.Rows(0)!Broj
        dtpDatum.Value = rsTrebovanje.Rows(0)!Datum

        txtBrojRadnogNaloga.Text = rsTrebovanje.Rows(0)!BrojRadnogNaloga
        txtBrojFinansijskogNaloga.Text = rsTrebovanje.Rows(0)!BrojFinansijskogNaloga.ToString

        DtpDatumRadnogNaloga.Value = rsTrebovanje.Rows(0)!DatumRadnogNaloga
        DtpDatumKnjizenja.Value = rsTrebovanje.Rows(0)!DatumKnjizenja

        chkKnjizeno.Checked = rsTrebovanje.Rows(0)!Knjizeno

        txtNapomena.Text = rsTrebovanje.Rows(0)!Napomena.ToString

        DajStavkeTrebovanja(txtBroj.Text)
        DajSumu(txtBroj.Text)

    End Sub


    Sub DajStavkeTrebovanja(ByVal Broj As Long, Optional ByVal NoviDoc As Boolean = False)

        rsStavke = GetData("SELECT Rbr,SifraArtikla,NazivArtikla,JedinicaMere,Kolicina,NabavnaCena,NabavniIznos FROM TrebovanjeStavke WHERE Magacin=" & TekuciMagacin _
                           & " AND BrojTrebovanja=" & Broj & " AND Godina=" & Godina & " ORDER BY Rbr")

        grdStavke.DataSource = Nothing
        grdStavke.DataSource = rsStavke

        grdStavke.Columns("Rbr").Width = 40
        grdStavke.Columns("SifraArtikla").Width = 80
        grdStavke.Columns("SifraArtikla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("SifraArtikla").HeaderText = "ŠIFRA"
        grdStavke.Columns("NazivArtikla").Width = 390
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
        grdStavke.Columns("NabavnaCena").HeaderText = "KOLIČINA"
        grdStavke.Columns("NabavnaCena").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("NabavnaCena").DefaultCellStyle.Format = "###,###,###,##0.0000"
        grdStavke.Columns("NabavniIznos").Width = 120
        grdStavke.Columns("NabavniIznos").HeaderText = "KOLIČINA"
        grdStavke.Columns("NabavniIznos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("NabavniIznos").DefaultCellStyle.Format = "###,###,###,##0.00"



    End Sub
    Sub DajSumu(Broj As Integer, Optional Maloprodaja As Boolean = False, Optional Grid As Boolean = False)

        Dim VrednostRobe As Double

        lblVrednost.Text = "0.00"

        For n = 0 To grdStavke.RowCount - 1
            VrednostRobe += grdStavke.Rows(n).Cells("NabavniIznos").Value

        Next

        lblVrednost.Text = FormatNumber(VrednostRobe, 2, , , TriState.True)

    End Sub
    Private Sub tmrDelay_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrDelay.Tick
        pnlOK.Visible = False

        cmdSnimi.Enabled = True
        cmdKnjizenje.Enabled = True
        cmdStampa.Enabled = True

        tmrDelay.Enabled = False
    End Sub


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
        Dim rsZaliha As DataTable
        Dim Zaliha As Double

        If e.KeyCode = Keys.Delete Then
            If Parametri.PravoPristupa >= 2 Then
                If chkKnjizeno.Checked Then
                    'MsgBox("Ne možete menjati proknjižen dokument!", MsgBoxStyle.Exclamation)
                    'Exit Sub
                    If MsgBox("Brišete stavku u proknjiženom dokument! Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Else
                    If MsgBox("Brisanje! " & vbCrLf & vbCrLf & "Da li ste sigurni?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                End If

                For n = 0 To grdStavke.RowCount - 1
                    Cursor = Cursors.WaitCursor
                    If grdStavke.Rows(n).Selected Then
                        InsertData("DELETE FROM TrebovanjeStavke WHERE BrojTrebovanja=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                        & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)

                        'vracanje na stanje u zalihama stavke koja se brise u proknjizenom dokumentu
                        If chkKnjizeno.Checked Then
                            rsZaliha = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)

                            Zaliha = (rsZaliha.Rows(0)!Zaliha + grdStavke.Rows(n).Cells("Kolicina").Value)
                            InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)

                            InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                           & "','Brisanje u proknjizenoj','" & DocStatus & "'," & txtBroj.Text & ",'" & grdStavke.Rows(n).Cells("SifraArtikla").Value & "')")
                        End If
                    End If

                Next

                'AzurirajRbr(Parametri.RBR, txtBroj.Text)
                DajStavkeTrebovanja(txtBroj.Text)
                DajSumu(txtBroj.Text)

                InsertData("UPDATE RadniNalogTrebovanja SET Vrednost=" & FormatNumber(lblVrednost.Text, 2,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin _
                           & " AND BrojTrebovanja=" & CLng(txtBroj.Text) & " AND BrojRadnogNaloga=" & CLng(txtBrojRadnogNaloga.Text) & " AND Godina=" & Godina)
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

        'Parametri.RBR = CLng(grdStavke.Rows(hit.RowIndex).Cells("RBr").Value)
        'Parametri.SifraArtikla = CLng(grdStavke.Rows(hit.RowIndex).Cells("SifraArtikla").Value)

        If IsDBNull(grdStavke.Rows(hit.RowIndex).Cells(0).Value) Then Exit Sub

        If e.Button = MouseButtons.Right Then
            mnuTrebovanje.Show(grdStavke, e.X, e.Y)
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
            Case "NabavnaCena"
                grdStavke.Rows(e.RowIndex).Cells("NabavniIznos").Value = FormatNumber((grdStavke.Rows(e.RowIndex).Cells("Kolicina").Value * grdStavke.Rows(e.RowIndex).Cells("NabavnaCena").Value), 2,,, TriState.False)


                DajSumu(txtBroj.Text)
        End Select
        Exit Sub
greska:
        MsgBox(Err.Description)

    End Sub

#End Region

    Private Sub mnuBrisanje_Click(sender As Object, e As EventArgs) Handles mnuBrisanje.Click
        Dim rsZaliha As DataTable
        Dim Zaliha As Double

        If Parametri.PravoPristupa >= 2 Then
            If chkKnjizeno.Checked Then
                'MsgBox("Ne možete menjati proknjižen dokument!", MsgBoxStyle.Exclamation)
                'Exit Sub
                If MsgBox("Brišete stavku u proknjiženom dokument! Nastavljate?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Else
                If MsgBox("Brisanje! " & vbCrLf & vbCrLf & "Da li ste sigurni?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If

            For n = 0 To grdStavke.RowCount - 1
                Cursor = Cursors.WaitCursor
                If grdStavke.Rows(n).Selected Then
                    InsertData("DELETE FROM TrebovanjeStavke WHERE BrojTrebovanja=" & CInt(txtBroj.Text) & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin _
                                    & " AND SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND RBr=" & grdStavke.Rows(n).Cells("RBr").Value)

                    'vracanje na stanje u zalihama stavke koja se brise u proknjizenom dokumentu
                    If chkKnjizeno.Checked Then
                        rsZaliha = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND BarCod='" & grdStavke.Rows(n).Cells("BarCod").Value & "'")

                        Zaliha = (rsZaliha.Rows(0)!Zaliha + grdStavke.Rows(n).Cells("Kolicina").Value)
                        InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " AND BarCod='" & grdStavke.Rows(n).Cells("BarCod").Value & "'")

                        InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                                       & "','Brisanje u proknjizenoj','" & DocStatus & "'," & txtBroj.Text & ",'" & grdStavke.Rows(n).Cells("SifraArtikla").Value & "')")
                    End If
                End If

            Next

            'AzurirajRbr(Parametri.RBR, txtBroj.Text)
            DajStavkeTrebovanja(txtBroj.Text)
            DajSumu(txtBroj.Text)

            InsertData("UPDATE RadniNalogTrebovanja SET Vrednost=" & FormatNumber(lblVrednost.Text, 2,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin _
                       & " AND BrojTrebovanja=" & CLng(txtBroj.Text) & " AND BrojRadnogNaloga=" & CLng(txtBrojRadnogNaloga.Text) & " AND Godina=" & Godina)
        Else
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub cmdSnimi_Click(sender As Object, e As EventArgs) Handles cmdSnimi.Click
        Dim rs As DataTable

        If Parametri.PravoPristupa >= 2 Then

            Cursor = Cursors.WaitCursor

            If chkKnjizeno.Checked Then
                If MsgBox("Da li ste sigurni da želite da korigujete proknjižen dokument!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If

            rs = GetData("SELECT * FROM TrebovanjeStavke WHERE BrojTrebovanja=" & CInt(txtBroj.Text) & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
            If rs.Rows.Count = 0 Then
                MsgBox("Ne možete da snimite dokument koji nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            rs.Dispose()

            InsertData("UPDATE Trebovanje SET Datum='" & Format(CDate(dtpDatum.Text), FormatDatuma) & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
            InsertData("UPDATE Trebovanje SET DatumKnjizenja='" & Format(CDate(DtpDatumKnjizenja.Text), FormatDatuma) & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
            InsertData("UPDATE Trebovanje SET Napomena='" & txtNapomena.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)

            For n = 0 To grdStavke.Rows.Count - 1
                InsertData("UPDATE TrebovanjeStavke SET Kolicina=" & grdStavke.Rows(n).Cells("Kolicina").Value & " WHERE BrojTrebovanja=" & CInt(txtBroj.Text) _
                                & " AND BrojRadnogNaloga=" & CInt(txtBrojRadnogNaloga.Text) _
                                & " And SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " And Rbr=" & grdStavke.Rows(n).Cells("Rbr").Value & " And Godina=" & Godina)
                InsertData("UPDATE TrebovanjeStavke SET NabavnaCena=" & grdStavke.Rows(n).Cells("NabavnaCena").Value & " WHERE BrojTrebovanja=" & CInt(txtBroj.Text) _
                                & " AND BrojRadnogNaloga=" & CInt(txtBrojRadnogNaloga.Text) _
                                & " And SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " And Rbr=" & grdStavke.Rows(n).Cells("Rbr").Value & " And Godina=" & Godina)
                InsertData("UPDATE TrebovanjeStavke SET NabavniIznos=" & grdStavke.Rows(n).Cells("NabavniIznos").Value & " WHERE BrojTrebovanja=" & CInt(txtBroj.Text) _
                                & " AND BrojRadnogNaloga=" & CInt(txtBrojRadnogNaloga.Text) _
                                & " And SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value & " And Rbr=" & grdStavke.Rows(n).Cells("Rbr").Value & " And Godina=" & Godina)
            Next

            DajSumu(txtBroj.Text)

            InsertData("UPDATE RadniNalogTrebovanja SET Vrednost=" & FormatNumber(lblVrednost.Text, 2,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin _
                           & " And BrojTrebovanja=" & CLng(txtBroj.Text) & " And BrojRadnogNaloga=" & CLng(txtBrojRadnogNaloga.Text) & " And Godina=" & Godina)
            InsertData("UPDATE RadniNalogTrebovanja SET Datum='" & Format(CDate(dtpDatum.Text), FormatDatuma) & "' WHERE Magacin=" & TekuciMagacin _
                           & " And BrojTrebovanja=" & CLng(txtBroj.Text) & " And BrojRadnogNaloga=" & CLng(txtBrojRadnogNaloga.Text) & " And Godina=" & Godina)

            InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','Korekcija','" & DocStatus & "'," & txtBroj.Text & ",'')")


            Cursor = Cursors.Default

            cmdSnimi.Enabled = False
            cmdKnjizenje.Enabled = False
            cmdStampa.Enabled = False

            pnlOK.Visible = True

            tmrDelay.Enabled = True
        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
            Exit Sub
        End If

    End Sub
    Private Sub cmdKnjizenje_Click(sender As Object, e As EventArgs) Handles cmdKnjizenje.Click
        Dim rs As DataTable
        'Dim rsC As DataTable
        Dim Zaliha As Double

        If Parametri.PravoPristupa >= 2 Then
            If chkKnjizeno.Checked Then
                MsgBox("Ne možete da knjižite već proknjižen dokument!", vbExclamation, "Trebovanje")
                Exit Sub
            End If

            ProveraStanja(txtBroj.Text, TekuciMagacin, rsStavke)
            If Manjak Then
                If MsgBox("Nema dovoljne količine na stanju! Da li želite da vidite izveštaj?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                FrmIzvestajStanja.ShowDialog()
                Exit Sub
            End If

            If MsgBox("Knjiženje dokumenta će umanjiti stanje artikala. Nastavljate?", vbQuestion + vbYesNo, "Trebovanje") = vbNo Then Exit Sub

            Cursor = Cursors.WaitCursor

            For n = 0 To rsStavke.Rows.Count - 1
                rs = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & rsStavke.Rows(n)!SifraArtikla)
                Zaliha = (rs.Rows(0)!Zaliha - rsStavke.Rows(n)!Kolicina)
                InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & rsStavke.Rows(n)!SifraArtikla)

            Next

            Cursor = Cursors.Default
            InsertData("UPDATE Trebovanje SET Knjizeno = 'True' WHERE Godina=" & Godina & " AND Broj=" & CLng(txtBroj.Text) & " AND Magacin=" & TekuciMagacin)
            InsertData("UPDATE Trebovanje SET Vreme = '" & TimeOfDay & "' WHERE Godina=" & Godina & " AND Broj=" & CLng(txtBroj.Text) & " AND Magacin=" & TekuciMagacin)

            InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Knjizenje','" & DocStatus & "'," & txtBroj.Text & ",'')")

            chkKnjizeno.Checked = True

            Cursor = Cursors.Default

        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Critical)
            Exit Sub
        End If

    End Sub
    Private Sub cmdStampa_Click(sender As Object, e As EventArgs) Handles cmdStampa.Click

        'Cursor = Cursors.WaitCursor

        'InsertData("UPDATE Parametri SET Broj=" & CLng(txtBroj.Text))
        'InsertData("UPDATE Parametri SET Magacin=" & TekuciMagacin)
        'InsertData("UPDATE Parametri SET Godina=" & Godina)

        'Parametri.NazivIzvestaja = "Trebovanje.rpt"

        'FrmPreView.ShowDialog()

        'Cursor = Cursors.Default
    End Sub
    Private Sub cmdIzlaz_Click(sender As Object, e As EventArgs) Handles cmdIzlaz.Click

        Close()
    End Sub


#Region "Novi dizajn"
    Private Sub PnlRbr_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles PnlRbr.Paint, PnlSifra.Paint, PnlNaziv.Paint, PnlBarCod.Paint, PnlStanje.Paint, PnlKil.Paint, Panel1.Paint
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

    Private Sub LblNaziv_Click(sender As Object, e As EventArgs) Handles LblNaziv.Click, PnlNaziv.Click
        Dim kolona As New DataGridViewColumn
        kolona = grdStavke.Columns("NazivArtikla")
        If Klik Then
            Klik = False
            grdStavke.Sort(kolona, ComponentModel.ListSortDirection.Descending)
        Else
            Klik = True
            grdStavke.Sort(kolona, ComponentModel.ListSortDirection.Ascending)
        End If

    End Sub

    Private Sub LblSifra_Click(sender As Object, e As EventArgs) Handles LblSifra.Click, PnlNaziv.Click
        Dim kolona As New DataGridViewColumn
        kolona = grdStavke.Columns("SifraArtikla")
        If Klik Then
            Klik = False
            grdStavke.Sort(kolona, ComponentModel.ListSortDirection.Descending)
        Else
            Klik = True
            grdStavke.Sort(kolona, ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub


#End Region

End Class