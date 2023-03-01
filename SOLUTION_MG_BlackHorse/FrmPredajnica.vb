Imports System.Drawing.Drawing2D
Public Class FrmPredajnica
    Dim rsPredajnice As DataTable
    Dim rsStavke As DataTable
    Dim Selected As Boolean

    Private Sub FrmPredajnica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lFont As Font

        lFont = New Font("Calibri", 11, FontStyle.Bold, GraphicsUnit.Point)
        grdStavke.ColumnHeadersDefaultCellStyle.Font = lFont
        lFont = New Font("Calibri", 11, FontStyle.Regular, GraphicsUnit.Point)
        grdStavke.RowsDefaultCellStyle.Font = lFont

        SifarnikMagacina.KontrolaZaPrikaz = CmbMagacin
        SifarnikMagacina.PuniKontrolu()
        CmbMagacin.SelectedValue = TekuciMagacin
        txtSifraMagacina.Text = CmbMagacin.SelectedValue

        'LblMagacin.Text = CmbMagacin.Text

        rsPredajnice = GetData("SELECT * FROM Predajnica WHERE Broj=" & Parametri.Broj & " AND Godina=" & Godina & " AND Magacin=" & TekuciMagacin)

        txtBroj.Text = rsPredajnice.Rows(0)!Broj
        dtpDatum.Value = rsPredajnice.Rows(0)!Datum

        txtBrojRadnogNaloga.Text = rsPredajnice.Rows(0)!BrojRadnogNaloga
        txtBrojFinansijskogNaloga.Text = rsPredajnice.Rows(0)!BrojFinansijskogNaloga.ToString

        DtpDatumRadnogNaloga.Value = rsPredajnice.Rows(0)!DatumRadnogNaloga
        DtpDatumKnjizenja.Value = rsPredajnice.Rows(0)!DatumKnjizenja

        chkKnjizeno.Checked = rsPredajnice.Rows(0)!Knjizeno

        txtNapomena.Text = rsPredajnice.Rows(0)!Napomena.ToString

        DajStavkePredajnice(txtBroj.Text)
        'DajSumu(txtBroj.Text)

    End Sub

    Sub DajStavkePredajnice(ByVal Broj As Long, Optional ByVal NoviDoc As Boolean = False)

        rsStavke = GetData("SELECT Rbr,SifraArtikla,NazivArtikla,JedinicaMere,Kolicina,Cena,Iznos FROM PredajnicaStavke WHERE Magacin=" & TekuciMagacin _
                           & " AND BrojPredajnice=" & Broj & " AND Godina=" & Godina & " ORDER BY Rbr")

        grdStavke.DataSource = Nothing
        grdStavke.DataSource = rsStavke

        grdStavke.Columns("Rbr").Width = 40
        grdStavke.Columns("SifraArtikla").Width = 80
        grdStavke.Columns("SifraArtikla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("SifraArtikla").HeaderText = "ŠIFRA"
        grdStavke.Columns("NazivArtikla").Width = 350
        grdStavke.Columns("NazivArtikla").HeaderText = "NAZIV ARTIKLA"
        grdStavke.Columns("NazivArtikla").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("JedinicaMere").Width = 70
        grdStavke.Columns("JedinicaMere").HeaderText = "J.M."
        grdStavke.Columns("JedinicaMere").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdStavke.Columns("Kolicina").Width = 85
        grdStavke.Columns("Kolicina").HeaderText = "KOLIČINA"
        grdStavke.Columns("Kolicina").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("Kolicina").DefaultCellStyle.Format = "###,###,###,##0.0000"
        grdStavke.Columns("Cena").Width = 100
        grdStavke.Columns("Cena").HeaderText = "KOLIČINA"
        grdStavke.Columns("Cena").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("Cena").DefaultCellStyle.Format = "###,###,###,##0.0000"
        grdStavke.Columns("Iznos").Width = 100
        grdStavke.Columns("Iznos").HeaderText = "KOLIČINA"
        grdStavke.Columns("Iznos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("Iznos").DefaultCellStyle.Format = "###,###,###,##0.0000"



    End Sub
    'Sub DajSumu(Broj As Integer, Optional Maloprodaja As Boolean = False, Optional Grid As Boolean = False)

    '    Dim VrednostRobe As Double

    '    lblVrednost.Text = "0.00"

    '    For n = 0 To grdStavke.RowCount - 1
    '        VrednostRobe += grdStavke.Rows(n).Cells("Iznos").Value

    '    Next

    '    lblVrednost.Text = FormatNumber(VrednostRobe, 2, , , TriState.True)

    'End Sub

    'Private Sub tmrDelay_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrDelay.Tick
    '    pnlOK.Visible = False

    '    cmdSnimi.Enabled = True
    '    cmdKnjizenje.Enabled = True
    '    CmdNalog.Enabled = True
    '    cmdStampa.Enabled = True

    '    tmrDelay.Enabled = False
    'End Sub


    Private Sub cmdSnimi_Click(sender As Object, e As EventArgs)
        Dim rs As DataTable

        If Parametri.PravoPristupa >= 2 Then

            Cursor = Cursors.WaitCursor

            If chkKnjizeno.Checked Then
                If MsgBox("Da li ste sigurni da želite da korigujete proknjižen dokument!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            End If

            rs = GetData("SELECT * FROM PredajnicaStavke WHERE BrojPredajnice=" & CInt(txtBroj.Text) & " AND Magacin=" & TekuciMagacin & " AND Godina=" & Godina)
            If rs.Rows.Count = 0 Then
                MsgBox("Ne možete da snimite dokument koji nema ni jednu stavku!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            rs.Dispose()

            InsertData("UPDATE Predajnica SET Datum='" & Format(CDate(dtpDatum.Text), FormatDatuma) & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
            InsertData("UPDATE Predajnica SET DatumKnjizenja='" & Format(CDate(DtpDatumKnjizenja.Text), FormatDatuma) & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)
            InsertData("UPDATE Predajnica SET Napomena='" & txtNapomena.Text & "' WHERE Broj=" & CInt(txtBroj.Text) & " AND Godina=" _
                           & Godina & " AND Magacin=" & TekuciMagacin)


            InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                               & "','Korekcija','" & DocStatus & "'," & txtBroj.Text & ",'')")


            Cursor = Cursors.Default

            'cmdSnimi.Enabled = False
            'cmdKnjizenje.Enabled = False
            'CmdNalog.Enabled = False
            'cmdStampa.Enabled = False

            'pnlOK.Visible = True

            'tmrDelay.Enabled = True
        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

    End Sub
    Private Sub cmdKnjizenje_Click(sender As Object, e As EventArgs)
        Dim rs As DataTable
        Dim rsC As DataTable
        Dim Zaliha As Double

        If Parametri.PravoPristupa >= 2 Then
            If chkKnjizeno.Checked Then
                MsgBox("Ne možete da knjižite već proknjižen dokument!", vbExclamation, "Trebovanje")
                Exit Sub
            End If

            If MsgBox("Knjiženje dokumenta će uvećava stanje artikala. Nastavljate?", vbQuestion + vbYesNo, "Predajnica") = vbNo Then Exit Sub

            Cursor = Cursors.WaitCursor

            For n = 0 To rsStavke.Rows.Count - 1
                rs = GetData("SELECT * FROM Zaliha WHERE Magacin=" & TekuciMagacin & " AND " & "Sifra=" & rsStavke.Rows(n)!SifraArtikla)

                If rs.Rows.Count = 0 Then
                    InsertData("INSERT INTO Zaliha VALUES(" & TekuciMagacin & ",'" & rsStavke(n)!SifraArtikla & "',''," & FormatNumber(rsStavke.Rows(n)!Kolicina, 4,,, TriState.False) & ",0)")
                Else
                    Zaliha = (rs.Rows(0)!Zaliha + rsStavke.Rows(n)!Kolicina)
                    InsertData("UPDATE Zaliha SET Zaliha=" & FormatNumber(Zaliha, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " AND Sifra=" & rsStavke.Rows(n)!SifraArtikla & " AND BarCod=''")
                End If

                rsC = GetData("SELECT * FROM Cenovnik WHERE SifraArtikla=" & rsStavke(n)!SifraArtikla & " AND Magacin =" & TekuciMagacin & " AND Komitent=0")
                If rsC.Rows.Count = 0 Then
                    InsertData("INSERT INTO Cenovnik VALUES(" & TekuciMagacin & "," & rsStavke(n)!SifraArtikla & ",'" & rsStavke(n)!NazivArtikla _
                               & "'," & FormatNumber(rsStavke(n)!Cena, 4,,, TriState.False) & "," & FormatNumber(rsStavke(n)!Cena, 4,,, TriState.False) _
                               & ",0,0,0,0) ")
                Else
                    InsertData("UPDATE Cenovnik Set NabavnaCena=" & FormatNumber(rsStavke(n)!Cena, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " And SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)
                    InsertData("UPDATE Cenovnik Set ProsecnaNabavnaCena=" & FormatNumber(rsStavke(n)!Cena, 4,,, TriState.False) & " WHERE Magacin=" & TekuciMagacin & " And SifraArtikla=" & grdStavke.Rows(n).Cells("SifraArtikla").Value)

                End If
            Next

            Cursor = Cursors.Default
            InsertData("UPDATE Predajnica SET Knjizeno = 'True' WHERE Godina=" & Godina & " AND Broj=" & CLng(txtBroj.Text) & " AND Magacin=" & TekuciMagacin)

            InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Knjizenje','" & DocStatus & "'," & txtBroj.Text & ",'')")

            chkKnjizeno.Checked = True

            Cursor = Cursors.Default

        Else
            Cursor = Cursors.Default
            MsgBox("Korisnik nema pravo pristupa!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

    End Sub
    Private Sub cmdStampa_Click(sender As Object, e As EventArgs)

        'Cursor = Cursors.WaitCursor

        'InsertData("UPDATE Parametri SET Broj=" & CLng(txtBroj.Text))
        'InsertData("UPDATE Parametri SET Magacin=" & TekuciMagacin)
        'InsertData("UPDATE Parametri SET Godina=" & Godina)

        'Parametri.NazivIzvestaja = "Predajnica.rpt"

        'FrmPreView.ShowDialog()

        'Cursor = Cursors.Default
    End Sub
    Private Sub cmdIzlaz_Click(sender As Object, e As EventArgs)

        Close()
    End Sub


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

#End Region
End Class