Imports System.IO

Public Class FrmSifarnikArtikli
    Dim RetCom As ReturningComplet


#Region "FORMA"
    Private Sub FrmSifarnikArtikli_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SifarnikVrstaArtikala.KontrolaZaPrikaz = cmbVrsta
        SifarnikVrstaArtikala.PuniKontrolu()
        cmbVrsta.SelectedIndex = -1

        'SifarnikPoreskihStopa.KontrolaZaPrikaz = cmbPoreskaStopa
        'SifarnikPoreskihStopa.PuniKontrolu()
        'cmbPoreskaStopa.SelectedValue = 1
        'txtPoreskaStopa.Text = SifarnikPoreskihStopa.Trazi("Sifra=" & cmbPoreskaStopa.SelectedValue)(0)!Stopa.ToString


        If Parametri.Novi Then
            BrisiPolja()
            AutoSifra()
            'CmdNovi.Enabled = False
            'CmdDodaj.Enabled = False
            'CmdBrisanje.Enabled = False

        Else
            DajArtikal(Parametri.Sifra)
            'CmdNovi.Enabled = True
            'CmdSnimi.Enabled = True
            'CmdDodaj.Enabled = True
            'CmdBrisanje.Enabled = True
        End If

    End Sub
    Private Sub FrmSifarnikArtikli_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Parametri.Novi = False

    End Sub
#End Region


#Region "Cmb polja"
    Private Sub cmbVrsta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVrsta.SelectedIndexChanged

        If cmbVrsta.SelectedIndex = -1 Then Exit Sub
        If IsNumeric(cmbVrsta.SelectedValue) Then
            SifarnikRobnihGrupa.Puni("SELECT * FROM SifarnikArtikliRobneGrupe WHERE Vrsta=" & cmbVrsta.SelectedValue & " AND Pasivan='False' ORDER BY Naziv")
            SifarnikRobnihGrupa.KontrolaZaPrikaz = CmbRobnaGrupa
            SifarnikRobnihGrupa.PuniKontrolu()
            CmbRobnaGrupa.SelectedIndex = -1
        Else
            cmbVrsta.Text = ""
        End If
    End Sub
    Private Sub cmbVrsta_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbVrsta.KeyDown

        If e.KeyCode = Keys.Enter Then
            If cmbVrsta.SelectedIndex > -1 And IsNumeric(cmbVrsta.SelectedValue) Then
                'cmbVrsta.Enabled = False
                'CmbRobnaGrupa.Enabled = True
                CmbRobnaGrupa.Focus()
            End If
        End If

    End Sub
    Private Sub CmbRobnaGrupa_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles CmbRobnaGrupa.KeyDown
        If e.KeyCode = Keys.Enter Then
            'txtSifra.ReadOnly = False
            txtSifra.Select()
        End If

    End Sub

    Private Sub CmdNovaRobnaGrupa_Click(sender As Object, e As EventArgs) Handles CmdNovaRobnaGrupa.Click

        Parametri.NovaRobnaGrupa = True

        FrmSifarnikArtikliRobneGrupe.Dispose()
        Hide()
        FrmSifarnikArtikliRobneGrupe.ShowDialog()
        SifarnikRobnihGrupa.Refresh()
        Show()


        BrisiPolja()

    End Sub

    'Private Sub cmbPoreskaStopa_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPoreskaStopa.SelectionChangeCommitted
    '    Dim rs As DataTable

    '    If cmbPoreskaStopa.SelectedIndex = -1 Then Exit Sub
    '    If cmbPoreskaStopa.SelectedIndex > -1 Then
    '        rs = GetData("SELECT * FROM SifarnikPoreskeStope WHERE Sifra=" & cmbPoreskaStopa.SelectedValue)
    '        txtPoreskaStopa.Text = rs.Rows(0)!Stopa

    '    End If

    'End Sub
    'Private Sub cmbPoreskaStopa_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbPoreskaStopa.KeyDown
    '    Dim rs As DataTable

    '    If e.KeyCode = Keys.Down Then cmbPoreskaStopa.DroppedDown = True

    '    If e.KeyCode = Keys.Enter Then
    '        If cmbPoreskaStopa.SelectedIndex > -1 Then
    '            rs = GetData("SELECT * FROM SifarnikPoreskeStope WHERE Sifra=" & cmbPoreskaStopa.SelectedValue)
    '            txtPoreskaStopa.Text = rs.Rows(0)!Stopa

    '            If IsNumeric(txtPoreskaStopa.Text) = False Then
    '                MsgBox("Greška pri unosu vrednosti!", MsgBoxStyle.Exclamation)
    '                cmbPoreskaStopa.Select()
    '                Exit Sub
    '            End If

    '        Else
    '            txtPoreskaStopa.Text = ""
    '            cmbPoreskaStopa.Select()
    '        End If

    '    End If
    'End Sub

#End Region


#Region "TXT polja"
    Private Sub txtSifra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSifra.KeyDown

        If e.KeyCode = Keys.Enter Then
            If IsNumeric(txtSifra.Text) Then
                'txtNaziv.ReadOnly = False
                TxtKataloskiBroj.Select()
            End If
        End If

    End Sub
    Private Sub TxtKataloskiBroj_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtKataloskiBroj.KeyDown

        If e.KeyCode = Keys.Enter Then
            txtNaziv.ReadOnly = False
            txtNaziv.Select()
        End If
    End Sub
    Private Sub txtNaziv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNaziv.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txtNaziv.Text <> "" Then
                'txtJedinicaMere.ReadOnly = False
                txtJedinicaMere.Select()
            End If
        End If

    End Sub
    Private Sub txtJedinicaMere_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJedinicaMere.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txtJedinicaMere.Text <> "" Then
                'txtMinimalnaKolicina.ReadOnly = False

            End If
        End If

    End Sub
    Private Sub txtMinimalnaKolicina_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMinimalnaKolicina.KeyDown

        If e.KeyCode = Keys.Enter Then
            If IsNumeric(txtMinimalnaKolicina.Text) Then
                txtMinimalnaKolicina.Text = FormatNumber(txtMinimalnaKolicina.Text, 2,,, TriState.True)
            Else
                txtMinimalnaKolicina.Text = "0.00"
            End If
            txtNapomena.Select()
        End If

    End Sub
#End Region


#Region "FUNKCIJE"
    Sub AutoSifra()
        Dim rs As DataTable

        rs = GetData("SELECT MAX(Sifra) AS Novi FROM SifarnikArtikli")
        If rs.Rows.Count = 0 Or IsDBNull(rs(0)!Novi) Then
            txtSifra.Text = "1"
        Else
            txtSifra.Text = rs(0)!Novi + 1
        End If

    End Sub
    Sub BrisiPolja()
        For Each ttBox As Control In Controls
            If TypeOf ttBox Is TextBox Then
                ttBox.Text = ""
            End If
        Next

        cmbVrsta.SelectedValue = 1
        CmbRobnaGrupa.SelectedValue = 1
        'cmbPoreskaStopa.SelectedValue = 1
        'txtPoreskaStopa.Text = SifarnikPoreskihStopa.Trazi("Sifra=" & cmbPoreskaStopa.SelectedValue)(0)!Stopa.ToString

        txtMinimalnaKolicina.Text = "0.00"

        ChkPasivan.Checked = False
        ChkPasivan.ForeColor = Color.FromArgb(45, 45, 45)

        txtSifra.Select()

    End Sub
    Sub DajArtikal(ByVal Artikal As Double)
        Dim rsArtikal As DataTable

        rsArtikal = GetData("SELECT * FROM SifarnikArtikli WHERE Sifra=" & Artikal)

        If rsArtikal.Rows.Count = 0 Then Exit Sub

        cmbVrsta.SelectedValue = rsArtikal(0)!Vrsta
        SifarnikRobnihGrupa.Puni("SELECT * FROM SifarnikArtikliRobneGrupe WHERE Vrsta=" & cmbVrsta.SelectedValue & " AND Pasivan='False' ORDER BY Naziv")
        SifarnikRobnihGrupa.KontrolaZaPrikaz = CmbRobnaGrupa
        SifarnikRobnihGrupa.PuniKontrolu()
        CmbRobnaGrupa.SelectedValue = rsArtikal.Rows(0)!Grupa
        txtSifra.Text = rsArtikal(0)!Sifra.ToString
        TxtKataloskiBroj.Text = rsArtikal(0)!KataloskiBroj.ToString
        txtNaziv.Text = rsArtikal(0)!Naziv.ToString
        TxtOznaka.Text = rsArtikal(0)!Oznaka.ToString
        txtJedinicaMere.Text = rsArtikal(0)!JedinicaMere.ToString
        txtBarCod.Text = rsArtikal(0)!BarCod.ToString
        'TxtKoeficijentProdajneCene.Text = FormatNumber(rsArtikal(0)!KoeficijentProdajneCene, 2)
        txtMinimalnaKolicina.Text = FormatNumber(rsArtikal(0)!MinimalnaKolicina, 2)

        'txtPoreskaStopa.Text = rsArtikal(0)!PoreskaStopa
        'cmbPoreskaStopa.SelectedValue = SifarnikPoreskihStopa.Trazi("Stopa=" & txtPoreskaStopa.Text)(0)!Sifra.ToString

        txtNapomena.Text = rsArtikal(0)!Napomena.ToString
        ChkPasivan.Checked = rsArtikal(0)!Pasivan

        If ChkPasivan.Checked = True Then
            MsgBox("Artikal ima status NEAKTIVAN/PASIVAN!", MsgBoxStyle.Information)
            ChkPasivan.ForeColor = Color.FromArgb(230, 150, 130)
            Exit Sub
        Else
            ChkPasivan.ForeColor = Color.FromArgb(45, 45, 45)
        End If

    End Sub
    Sub Snimi()
        Dim rs As DataTable
        'Dim rsC As DataTable

        If Parametri.PravoPristupa >= 2 Then

            ProveraObaveznihPolja()
            If RetCom.Poruka = "Greška" Then Exit Sub

            rs = GetData("SELECT * FROM SifarnikArtikli WHERE Sifra=" & CDbl(txtSifra.Text))
            If rs.Rows.Count > 0 And Parametri.Novi Then
                MsgBox("Artikal sa ovom šifrom već postoji! Unesite drugu šifru.", MsgBoxStyle.Exclamation)
                txtSifra.Select()
                Exit Sub
            End If
            rs.Dispose()

            ''''SMS ima iste nazive artikala... Prednji vetroban...
            rs = GetData("SELECT * FROM SifarnikArtikli WHERE Naziv='" & (txtNaziv.Text) & "'")
            If rs.Rows.Count > 0 And Parametri.Novi Then
                MsgBox("Artikal sa ovim nazivom već postoji! ", MsgBoxStyle.Exclamation)
                txtNaziv.Select()
                Exit Sub
            End If

            'If IsNumeric(TxtKoeficijentProdajneCene.Text) = False Then TxtKoeficijentProdajneCene.Text = 1
            'If TxtKoeficijentProdajneCene.Text = 0 Then TxtKoeficijentProdajneCene.Text = 1

            If Parametri.Novi Then
                InsertData("INSERT INTO SifarnikArtikli VALUES(" & CInt(cmbVrsta.SelectedValue) & ", " & CInt(CmbRobnaGrupa.SelectedValue) & ", " & CDbl(txtSifra.Text) & ",'" _
                            & txtNaziv.Text & "','" & TxtOznaka.Text & "','" & TxtKataloskiBroj.Text & "','" & txtBarCod.Text & "','" & txtJedinicaMere.Text _
                            & "',1," & FormatNumber(CDbl(txtMinimalnaKolicina.Text), 2,,, TriState.False) _
                            & ",'" & cmbPoreskaStopa.Text & "'," & CInt(txtPoreskaStopa.Text) & ",'" & txtNapomena.Text & "','" & ChkPasivan.Checked & "')")

                'onemoguceno iz razloga da se ne zna u koji ce magacin artikal biti smesten, u cenovnik se unosi preko kalkulacije
                'rsC = GetData("SELECT * FROM Cenovnik WHERE SifraArtikla=" & CDbl(txtSifra.Text))
                'If rsC.Rows.Count = 0 Then
                '    InsertData("INSERT INTO Cenovnik VALUES(" & TekuciMagacin & "," & CDbl(txtSifra.Text) & ",'" & txtNaziv.Text & "',0,0,0)")
                'End If

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Novi artikal','" & DocStatus & "'," & txtSifra.Text & ",'" & txtNaziv.Text & "')")

            Else
                InsertData("UPDATE SifarnikArtikli SET Naziv='" & txtNaziv.Text & "' WHERE Sifra=" & CDbl(txtSifra.Text))
                InsertData("UPDATE SifarnikArtikli SET Oznaka='" & TxtOznaka.Text & "' WHERE Sifra=" & CDbl(txtSifra.Text))
                InsertData("UPDATE SifarnikArtikli SET KataloskiBroj='" & TxtKataloskiBroj.Text & "' WHERE Sifra=" & CDbl(txtSifra.Text))
                InsertData("UPDATE SifarnikArtikli SET JedinicaMere='" & txtJedinicaMere.Text & "' WHERE Sifra=" & CDbl(txtSifra.Text))
                'InsertData("UPDATE SifarnikArtikli SET KoeficijentProdajneCene=" & FormatNumber(CDbl(TxtKoeficijentProdajneCene.Text), 2,,, TriState.False) & " WHERE Sifra=" & CDbl(txtSifra.Text))
                InsertData("UPDATE SifarnikArtikli SET MinimalnaKolicina=" & FormatNumber(CDbl(txtMinimalnaKolicina.Text), 2,,, TriState.False) & " WHERE Sifra=" & CDbl(txtSifra.Text))
                'InsertData("UPDATE SifarnikArtikli SET TipPoreskeStope='" & cmbPoreskaStopa.Text & "' WHERE Sifra=" & CDbl(txtSifra.Text))
                'InsertData("UPDATE SifarnikArtikli SET PoreskaStopa=" & CInt(txtPoreskaStopa.Text) & " WHERE Sifra=" & CDbl(txtSifra.Text))
                InsertData("UPDATE SifarnikArtikli SET BarCod='" & txtBarCod.Text & "' WHERE Sifra=" & CDbl(txtSifra.Text))
                InsertData("UPDATE SifarnikArtikli SET Vrsta=" & cmbVrsta.SelectedValue & " WHERE Sifra=" & CDbl(txtSifra.Text))
                InsertData("UPDATE SifarnikArtikli SET Grupa=" & CLng(CmbRobnaGrupa.SelectedValue) & " WHERE Sifra=" & CDbl(txtSifra.Text))
                InsertData("UPDATE SifarnikArtikli SET Napomena='" & txtNapomena.Text & "' WHERE Sifra=" & CDbl(txtSifra.Text))
                InsertData("UPDATE SifarnikArtikli SET Pasivan='" & ChkPasivan.Checked & "' WHERE Sifra=" & CDbl(txtSifra.Text))

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Korekcija artikla','" & DocStatus & "'," & txtSifra.Text & ",'" & txtNaziv.Text & "')")

            End If

            'PnlOK.Visible = True
            'CmdSnimi.Enabled = False
            'CmdNovi.Enabled = False
            'CmdDodaj.Enabled = False
            'CmdBrisanje.Enabled = False

            tmrDelay.Enabled = True
            Parametri.Novi = False

            If ChkPasivan.Checked = True Then
                ChkPasivan.ForeColor = Color.FromArgb(250, 190, 130)
                Exit Sub
            Else
                ChkPasivan.ForeColor = Color.FromArgb(45, 45, 45)
            End If

        Else
            MsgBox("Korisnik nema pravo snimanja i korekcije!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

    End Sub
    Sub ProveraObaveznihPolja()
        RetCom.Poruka = "OK"

        If cmbVrsta.SelectedIndex = -1 Or cmbVrsta.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(cmbVrsta, "Obavezan unos")
        End If

        If CmbRobnaGrupa.SelectedIndex = -1 Or CmbRobnaGrupa.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(CmbRobnaGrupa, "Obavezan unos")
        End If

        If IsNumeric(txtSifra.Text) = False Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(txtSifra, "Greška pri unosu šifre")
        End If

        If txtNaziv.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(txtNaziv, "Obavezan unos")
        End If

        If txtJedinicaMere.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(txtJedinicaMere, "Obavezan unos")
        End If

        If txtBarCod.Text = "" Then
            txtBarCod.Text = txtSifra.Text
        End If

        'If cmbPoreskaStopa.SelectedIndex = -1 Or cmbPoreskaStopa.Text = "" Then
        '    RetCom.Poruka = "Greška"
        '    erpIndikatorGreske.SetError(cmbPoreskaStopa, "Obavezan unos")
        'End If

        'If IsNumeric(txtPoreskaStopa.Text) = False Then
        '    txtPoreskaStopa.Text = cmbPoreskaStopa.SelectedValue
        'End If
        If IsNumeric(txtMinimalnaKolicina.Text) = False Then
            txtMinimalnaKolicina.Text = "0.00"
        End If


        TmrIndikatorGreske.Enabled = True

    End Sub


    Private Sub tmrDelay_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrDelay.Tick
        'PnlOK.Visible = False
        'CmdSnimi.Enabled = True
        'CmdNovi.Enabled = True
        'CmdDodaj.Enabled = True
        'CmdBrisanje.Enabled = True

        tmrDelay.Enabled = False

    End Sub
    Private Sub TmrIndikatorGreske_Tick(sender As Object, e As EventArgs) Handles TmrIndikatorGreske.Tick

        erpIndikatorGreske.SetError(cmbVrsta, "")
        erpIndikatorGreske.SetError(CmbRobnaGrupa, "")
        erpIndikatorGreske.SetError(txtSifra, "")
        erpIndikatorGreske.SetError(txtNaziv, "")
        erpIndikatorGreske.SetError(txtJedinicaMere, "")
        'erpIndikatorGreske.SetError(cmbPoreskaStopa, "")

        TmrIndikatorGreske.Enabled = False

    End Sub
#End Region


#Region "TASTERI"
    Private Sub cmdNovi_Click(sender As Object, e As EventArgs) Handles CmdNovi.Click

        BrisiPolja()
        AutoSifra()
        txtSifra.Select()

        Parametri.Novi = True
        'CmdNovi.Enabled = False
        'CmdDodaj.Enabled = False
        'CmdBrisanje.Enabled = False

    End Sub
    Private Sub cmdSnimi_Click(sender As Object, e As EventArgs) Handles CmdSnimi.Click
        Snimi()
    End Sub
    Private Sub cmdIzlaz_Click(sender As Object, e As EventArgs)
        'Selektovano = 0
        Close()
    End Sub


#End Region



End Class