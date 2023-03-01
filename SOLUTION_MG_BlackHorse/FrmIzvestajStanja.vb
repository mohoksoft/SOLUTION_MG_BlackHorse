Public Class FrmIzvestajStanja
    Dim rsStavke As DataTable
    Private Sub FrmIzvestajStanja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lFont As Font

        lFont = New Font("Calibri", 11, FontStyle.Bold, GraphicsUnit.Point)
        grdStavke.ColumnHeadersDefaultCellStyle.Font = lFont
        lFont = New Font("Verdana", 9.75, FontStyle.Regular, GraphicsUnit.Point)
        grdStavke.RowsDefaultCellStyle.Font = lFont

        rsStavke = GetData("SELECT * FROM IzvestajStanja WHERE IDOperatera=" & UserID & " ORDER BY Sifra")

        grdStavke.DataSource = Nothing
        grdStavke.DataSource = rsStavke

        grdStavke.Columns("IDOPeratera").Visible = False
        grdStavke.Columns("Sifra").Width = 80
        grdStavke.Columns("Sifra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("Sifra").HeaderText = "ŠIFRA"
        grdStavke.Columns("Naziv").Width = 350
        grdStavke.Columns("Naziv").HeaderText = "NAZIV"
        grdStavke.Columns("Naziv").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("Stanje").Width = 100
        grdStavke.Columns("Stanje").HeaderText = "STANJE"
        grdStavke.Columns("Stanje").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("Stanje").DefaultCellStyle.Format = "###,###,###,##0.0000"
        grdStavke.Columns("Kolicina").Width = 100
        grdStavke.Columns("Kolicina").HeaderText = "KOLIČINA"
        grdStavke.Columns("Kolicina").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("Kolicina").DefaultCellStyle.Format = "###,###,###,##0.0000"

    End Sub


    Private Sub cmdIzlaz_Click(sender As Object, e As EventArgs) Handles cmdIzlaz.Click

        Close()
    End Sub
End Class