Public Class FrmSifarnikArtikliRobneGrupe
    Dim RetCom As ReturningComplet

    Private Sub FrmSifarnikArtikliRobneGrupe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SifarnikVrstaArtikala.KontrolaZaPrikaz = cmbVrsta
        SifarnikVrstaArtikala.PuniKontrolu()
        cmbVrsta.SelectedValue = 1

        If Parametri.NovaRobnaGrupa Then
            BrisiPolja()
            AutoSifra()
            CmdNovi.Enabled = False
            TxtNazivRobneGrupe.Text = ""
        Else
            DajRobnuGrupu(Parametri.Sifra)
            CmdNovi.Enabled = True
        End If

    End Sub
    Private Sub FrmSifarnikArtikliRobneGrupe_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Parametri.NovaRobnaGrupa = False
    End Sub

    Sub AutoSifra()
        Dim rs As DataTable

        rs = GetData("SELECT MAX(Sifra) AS Novi FROM SifarnikArtikliRobneGrupe")
        If rs.Rows.Count = 0 Or IsDBNull(rs(0)!Novi) Then
            TxtSifraRobneGrupe.Text = "1"
        Else
            TxtSifraRobneGrupe.Text = rs(0)!Novi + 1
        End If
    End Sub
    Sub BrisiPolja()
        'cmbVrsta.SelectedIndex = -1
        'TxtSifraVrsteArtikla.Text = ""
        cmbVrsta.SelectedValue = 1
        TxtSifraRobneGrupe.Text = ""
        TxtNazivRobneGrupe.Text = ""
        TxtNapomena.Text = ""

        ChkPasivan.Checked = False
        ChkPasivan.ForeColor = Color.FromArgb(45, 45, 45)

    End Sub
    Sub DajRobnuGrupu(Grupa As Integer)
        Dim rs As DataTable

        rs = GetData("SELECT * FROM SifarnikArtikliRobneGrupe WHERE Sifra=" & Grupa)

        cmbVrsta.SelectedValue = rs(0)!Vrsta
        TxtSifraVrsteArtikla.Text = rs(0)!Vrsta
        TxtNazivRobneGrupe.Text = rs(0)!Naziv
        TxtSifraRobneGrupe.Text = rs(0)!Sifra
        TxtNapomena.Text = rs(0)!Napomena.ToString
        ChkPasivan.Checked = rs(0)!Pasivan

        If ChkPasivan.Checked = True Then
            MsgBox("Robna grupa ima status NEAKTIVNA/PASIVNA!", MsgBoxStyle.Information)
            ChkPasivan.ForeColor = Color.FromArgb(250, 190, 130)
            Exit Sub
        Else
            ChkPasivan.ForeColor = Color.FromArgb(45, 45, 45)
        End If

    End Sub
    Sub Snimi()
        Dim rs As DataTable

        If Parametri.PravoPristupa >= 2 Then

            ProveraObaveznihPolja()
            If RetCom.Poruka = "Greška" Then Exit Sub

            rs = GetData("SELECT * FROM SifarnikArtikliRobneGrupe WHERE Sifra=" & CLng(TxtSifraRobneGrupe.Text))
            If rs.Rows.Count > 0 And Parametri.NovaRobnaGrupa Then
                MsgBox("Robna grupa sa ovom šifrom već postoji! Unesite drugu šifru.", MsgBoxStyle.Exclamation)
                TxtSifraRobneGrupe.Select()
                Exit Sub
            End If

            If Parametri.NovaRobnaGrupa = True Then
                InsertData("INSERT INTO SifarnikArtikliRobneGrupe VALUES(" & CLng(cmbVrsta.SelectedValue) & "," & CLng(TxtSifraRobneGrupe.Text) _
                           & ",'" & TxtNazivRobneGrupe.Text & "','" & TxtNapomena.Text & "','" & ChkPasivan.Checked & "')")

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Nova robna grupa','" & DocStatus & "'," & TxtSifraRobneGrupe.Text & ",'" & TxtNazivRobneGrupe.Text & "')")
            Else
                InsertData("UPDATE SifarnikArtikliRobneGrupe SET Naziv='" & TxtNazivRobneGrupe.Text & "' WHERE Sifra=" & CLng(TxtSifraRobneGrupe.Text))
                InsertData("UPDATE SifarnikArtikliRobneGrupe SET Napomena='" & TxtNapomena.Text & "' WHERE Sifra=" & CLng(TxtSifraRobneGrupe.Text))
                InsertData("UPDATE SifarnikArtikliRobneGrupe SET Pasivan='" & ChkPasivan.Checked & "' WHERE Sifra=" & CLng(TxtSifraRobneGrupe.Text))

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Korekcija robne grupe','" & DocStatus & "'," & TxtSifraRobneGrupe.Text & ",'" & TxtNazivRobneGrupe.Text & "')")
            End If

            'PnlOK.Visible = True
            CmdSnimi.Enabled = False
            CmdNovi.Enabled = False

            tmrDelay.Enabled = True
            Parametri.NovaRobnaGrupa = False

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

        If IsNumeric(TxtSifraRobneGrupe.Text) = False Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(TxtSifraRobneGrupe, "Greška pri unosu")
        End If

        If TxtNazivRobneGrupe.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(TxtNazivRobneGrupe, "Obavezan unos")
        End If

        TmrIndikatorGreske.Enabled = True

    End Sub

    Private Sub tmrDelay_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrDelay.Tick
        'PnlOK.Visible = False
        CmdSnimi.Enabled = True
        CmdNovi.Enabled = True

        tmrDelay.Enabled = False

    End Sub
    Private Sub TmrIndikatorGreske_Tick(sender As Object, e As EventArgs) Handles TmrIndikatorGreske.Tick

        erpIndikatorGreske.SetError(cmbVrsta, "")
        erpIndikatorGreske.SetError(TxtSifraRobneGrupe, "")
        erpIndikatorGreske.SetError(TxtNazivRobneGrupe, "")

        TmrIndikatorGreske.Enabled = False

    End Sub


    Private Sub cmbVrsta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbVrsta.SelectionChangeCommitted
        If cmbVrsta.SelectedIndex = -1 Then Exit Sub
        If cmbVrsta.SelectedIndex > -1 Then
            TxtSifraVrsteArtikla.Text = cmbVrsta.SelectedValue
            TxtNazivRobneGrupe.Select()
        Else
            TxtSifraVrsteArtikla.Text = ""
        End If
    End Sub

    Private Sub cmdNovi_Click(sender As Object, e As EventArgs)

        BrisiPolja()
        AutoSifra()
        CmdNovi.Enabled = False
        Parametri.NovaRobnaGrupa = True
    End Sub
    Private Sub cmdSnimi_Click(sender As Object, e As EventArgs)
        Snimi()
    End Sub
    Private Sub cmdIzlaz_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

End Class