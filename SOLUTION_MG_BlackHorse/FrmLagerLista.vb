Public Class FrmLagerLista

#Region "FORMA"
    Private Sub FrmLagerLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lFont As Font

        lFont = New Font("Calibri", 11, FontStyle.Bold, GraphicsUnit.Point)
        grdStavke.ColumnHeadersDefaultCellStyle.Font = lFont
        lFont = New Font("Verdana", 9.75, FontStyle.Regular, GraphicsUnit.Point)
        grdStavke.RowsDefaultCellStyle.Font = lFont

        SifarnikMagacina.KontrolaZaPrikaz = cmbMagacin
        SifarnikMagacina.PuniKontrolu()
        cmbMagacin.SelectedValue = TekuciMagacin
        txtSifraMagacina.Text = cmbMagacin.SelectedValue

        TxtGrupa.Text = ""
        ChkSviArtikli.Checked = True
        ChkSaCenom.Checked = True
        chkNaStanju.Checked = False

        If Godina <> TekucaGodina Then
            Close()
        Else
            DajListu(ChkSviArtikli.Checked, ChkSaCenom.Checked, chkNaStanju.Checked, TxtGrupa.Text = "0")
        End If




    End Sub

#End Region

#Region "FILTERI"
    Private Sub cmbMagacin_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbMagacin.SelectionChangeCommitted

        If cmbMagacin.SelectedIndex > -1 Then
            txtSifraMagacina.Text = cmbMagacin.SelectedValue
            TekuciMagacin = CLng(txtSifraMagacina.Text)

            If ChkSviArtikli.Checked Then
                DajListu(ChkSviArtikli.Checked, ChkSaCenom.Checked, chkNaStanju.Checked, 0)
            Else
                DajListu(ChkSviArtikli.Checked, ChkSaCenom.Checked, chkNaStanju.Checked, CLng(TxtGrupa.Text))
            End If
        Else
            grdStavke.DataSource = Nothing
            txtSifraMagacina.Text = ""

        End If
    End Sub
    Private Sub cmbMagacin_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbMagacin.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbMagacin.SelectedIndex = -1 Then Exit Sub
            If cmbMagacin.SelectedIndex > -1 Then
                txtSifraMagacina.Text = cmbMagacin.SelectedValue
                TekuciMagacin = CLng(txtSifraMagacina.Text)

                If ChkSviArtikli.Checked Then
                    DajListu(ChkSviArtikli.Checked, ChkSaCenom.Checked, chkNaStanju.Checked, 0)
                Else
                    DajListu(ChkSviArtikli.Checked, ChkSaCenom.Checked, chkNaStanju.Checked, CLng(TxtGrupa.Text))
                End If
            Else
                grdStavke.DataSource = Nothing
                txtSifraMagacina.Text = ""

            End If

        End If
    End Sub
    Private Sub TxtGrupa_TextChanged(sender As Object, e As EventArgs) Handles TxtGrupa.TextChanged

        If IsNumeric(TxtGrupa.Text) And TxtGrupa.Text <> "" Then
            If cmbMagacin.SelectedIndex > -1 Then
                If TxtGrupa.Text > 0 Then
                    ChkSviArtikli.Checked = False
                    DajListu(ChkSviArtikli.Checked, ChkSaCenom.Checked, chkNaStanju.Checked, CLng(TxtGrupa.Text))
                Else
                    grdStavke.DataSource = Nothing
                End If
            Else
                grdStavke.DataSource = Nothing
            End If
        Else
            ChkSviArtikli.Checked = True
            DajListu(ChkSviArtikli.Checked, ChkSaCenom.Checked, chkNaStanju.Checked, 0)
        End If
    End Sub
    Private Sub ChkSviArtikli_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSviArtikli.CheckedChanged

        If ChkSviArtikli.Checked Then
            TxtGrupa.Text = ""
            DajListu(ChkSviArtikli.Checked, ChkSaCenom.Checked, chkNaStanju.Checked, 0)
        Else
            If IsNumeric(TxtGrupa.Text) Then
                DajListu(ChkSviArtikli.Checked, ChkSaCenom.Checked, chkNaStanju.Checked, CLng(TxtGrupa.Text))
            Else
                grdStavke.DataSource = Nothing
            End If
        End If
    End Sub
    Private Sub ChkSaCenom_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSaCenom.CheckedChanged

        If ChkSviArtikli.Checked Then
            DajListu(ChkSviArtikli.Checked, ChkSaCenom.Checked, chkNaStanju.Checked, 0)
        Else
            DajListu(ChkSviArtikli.Checked, ChkSaCenom.Checked, chkNaStanju.Checked, CLng(TxtGrupa.Text))
        End If

    End Sub
    Private Sub chkNaStanju_CheckedChanged(sender As Object, e As EventArgs) Handles chkNaStanju.CheckedChanged

        If cmbMagacin.SelectedIndex > -1 Then
            If ChkSviArtikli.Checked Then
                DajListu(ChkSviArtikli.Checked, ChkSaCenom.Checked, chkNaStanju.Checked, 0)
            Else
                DajListu(ChkSviArtikli.Checked, ChkSaCenom.Checked, chkNaStanju.Checked, CLng(TxtGrupa.Text))
            End If
        Else
            grdStavke.DataSource = Nothing
        End If

    End Sub

#End Region


#Region "FUNKCIJE"
    Sub DajListu(SviArtikli As Boolean, SaCenom As Boolean, NaStanju As Boolean, GrupaSifre As Integer)
        Dim rs As DataTable

        If SviArtikli Then
            If NaStanju Then
                rs = GetData("SELECT dbo.Zaliha.Magacin, dbo.Zaliha.Sifra, dbo.SifarnikArtikli.Naziv, dbo.SifarnikArtikli.JedinicaMere, 
                        dbo.Cenovnik.ProsecnaNabavnaCena, dbo.Cenovnik.ProdajnaCena, dbo.Zaliha.Zaliha As Stanje
                        FROM dbo.Zaliha INNER JOIN dbo.Cenovnik ON dbo.Zaliha.Sifra = dbo.Cenovnik.SifraArtikla AND dbo.Zaliha.Magacin = dbo.Cenovnik.Magacin 
                        INNER JOIN dbo.SifarnikArtikli ON dbo.Cenovnik.SifraArtikla = dbo.SifarnikArtikli.Sifra
                        WHERE dbo.Zaliha.Magacin=" & txtSifraMagacina.Text & " AND dbo.Zaliha.Zaliha>0 ORDER BY dbo.Zaliha.Sifra")
            Else
                rs = GetData("SELECT dbo.Zaliha.Magacin, dbo.Zaliha.Sifra, dbo.SifarnikArtikli.Naziv, dbo.SifarnikArtikli.JedinicaMere, 
                        dbo.Cenovnik.ProsecnaNabavnaCena, dbo.Cenovnik.ProdajnaCena, dbo.Zaliha.Zaliha As Stanje 
                        FROM dbo.Zaliha INNER JOIN dbo.Cenovnik ON dbo.Zaliha.Sifra = dbo.Cenovnik.SifraArtikla AND dbo.Zaliha.Magacin = dbo.Cenovnik.Magacin 
                        INNER JOIN dbo.SifarnikArtikli ON dbo.Cenovnik.SifraArtikla = dbo.SifarnikArtikli.Sifra
                        WHERE dbo.Zaliha.Magacin=" & txtSifraMagacina.Text & " ORDER BY dbo.Zaliha.Sifra")
            End If
        Else
            If NaStanju Then
                rs = GetData("SELECT dbo.Zaliha.Magacin, dbo.Zaliha.Sifra, dbo.SifarnikArtikli.Naziv, dbo.SifarnikArtikli.JedinicaMere, 
                        dbo.Cenovnik.ProsecnaNabavnaCena, dbo.Cenovnik.ProdajnaCena, dbo.Zaliha.Zaliha As Stanje 
                        FROM dbo.Zaliha INNER JOIN dbo.Cenovnik ON dbo.Zaliha.Sifra = dbo.Cenovnik.SifraArtikla AND dbo.Zaliha.Magacin = dbo.Cenovnik.Magacin 
                        INNER JOIN dbo.SifarnikArtikli ON dbo.Cenovnik.SifraArtikla = dbo.SifarnikArtikli.Sifra
                        WHERE dbo.Zaliha.Sifra LIKE '" & GrupaSifre & "%' AND dbo.Zaliha.Zaliha>0 AND dbo.Zaliha.Magacin=" & txtSifraMagacina.Text & " ORDER BY dbo.Zaliha.Sifra")
            Else
                rs = GetData("SELECT dbo.Zaliha.Magacin, dbo.Zaliha.Sifra, dbo.SifarnikArtikli.Naziv, dbo.SifarnikArtikli.JedinicaMere, 
                        dbo.Cenovnik.ProsecnaNabavnaCena, dbo.Cenovnik.ProdajnaCena, dbo.Zaliha.Zaliha As Stanje 
                        FROM dbo.Zaliha INNER JOIN dbo.Cenovnik ON dbo.Zaliha.Sifra = dbo.Cenovnik.SifraArtikla AND dbo.Zaliha.Magacin = dbo.Cenovnik.Magacin 
                        INNER JOIN dbo.SifarnikArtikli ON dbo.Cenovnik.SifraArtikla = dbo.SifarnikArtikli.Sifra
                        WHERE dbo.Zaliha.Sifra LIKE '" & GrupaSifre & "%' AND dbo.Zaliha.Magacin=" & txtSifraMagacina.Text & " ORDER BY dbo.Zaliha.Sifra")
            End If
        End If


        grdStavke.DataSource = Nothing
        grdStavke.DataSource = rs

        grdStavke.Columns("Sifra").Width = 100
        grdStavke.Columns("Sifra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("Sifra").HeaderText = "ŠIFRA"
        grdStavke.Columns("Naziv").Width = 530
        grdStavke.Columns("Naziv").HeaderText = "NAZIV ARTIKLA"
        grdStavke.Columns("Naziv").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grdStavke.Columns("JedinicaMere").Width = 60
        grdStavke.Columns("JedinicaMere").HeaderText = "J.M."
        grdStavke.Columns("JedinicaMere").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdStavke.Columns("ProsecnaNabavnaCena").Width = 140
        grdStavke.Columns("ProsecnaNabavnaCena").HeaderText = "NABAVNA CENA"
        grdStavke.Columns("ProsecnaNabavnaCena").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("ProsecnaNabavnaCena").DefaultCellStyle.Format = "###,###,##0.00"
        grdStavke.Columns("ProdajnaCena").Width = 140
        grdStavke.Columns("ProdajnaCena").HeaderText = "PRODAJNA CENA"
        grdStavke.Columns("ProdajnaCena").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("ProdajnaCena").DefaultCellStyle.Format = "###,###,##0.00"
        grdStavke.Columns("Stanje").Width = 130
        grdStavke.Columns("Stanje").HeaderText = "STANJE"
        grdStavke.Columns("Stanje").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdStavke.Columns("Stanje").DefaultCellStyle.Format = "###,###,###,##0.0000"

        If SaCenom = False Then
            grdStavke.Columns("Naziv").Width = 810
            grdStavke.Columns("ProsecnaNabavnaCena").Visible = False
            grdStavke.Columns("ProdajnaCena").Visible = False
        End If

        grdStavke.Columns("Magacin").Visible = False

    End Sub

#End Region


#Region "TASTERI"
    Private Sub cmdStampa_Click(sender As Object, e As EventArgs) Handles cmdStampa.Click

        'Cursor = Cursors.WaitCursor

        'InsertData("UPDATE Parametri SET Magacin=" & TekuciMagacin)
        'InsertData("UPDATE Parametri SET Text='" & TxtGrupa.Text & "'")
        'InsertData("UPDATE Parametri SET Status='" & chkNaStanju.Checked & "'")
        'InsertData("UPDATE Parametri SET Godina=" & Godina)

        'Parametri.NazivIzvestaja = "LagerLista.rpt"

        'FrmPreView.ShowDialog()

        'Cursor = Cursors.Default

    End Sub
    Private Sub cmdIzlaz_Click(sender As Object, e As EventArgs) Handles cmdIzlaz.Click
        Close()
    End Sub



#End Region

End Class