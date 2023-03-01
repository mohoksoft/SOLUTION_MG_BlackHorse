Public Class FrmSifarnikMagacini
    Dim RetCom As ReturningComplet

    Private Sub FrmSifarnikMagacini_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SifarnikVrstaArtikala.KontrolaZaPrikaz = CmbVrstaArtikla
        SifarnikVrstaArtikala.PuniKontrolu()
        CmbVrstaArtikla.SelectedValue = 1


        If Parametri.Novi Then
            BrisiPolja()
            AutoSifra()
            CmdNovi.Enabled = False

        Else
            DajMagacin(Parametri.Sifra)
            CmdNovi.Enabled = True
        End If

    End Sub
    Private Sub FrmSifarnikMagacini_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Parametri.Novi = False
    End Sub


    Private Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TxtSifra.KeyDown, TxtNaziv.KeyDown, TxtLokacija.KeyDown
        Dim TekuciTag As Integer, SledeciTag As Integer
        Dim Izlaz As Boolean

        If e.KeyCode = Keys.Enter Then
            For Each thisControl As Control In Controls
                If thisControl.Focused Then
                    If IsNumeric(thisControl.Tag) Then
                        TekuciTag = CInt(thisControl.Tag)
                        SledeciTag = TekuciTag + 1
                        If SledeciTag > 9 Then
                            SledeciTag = 0
                            Snimi()
                            TxtSifra.Focus()
                            Exit For
                        End If
                        For Each ttBox As Control In Controls
                            If IsNumeric(ttBox.Tag) Then
                                If CInt(ttBox.Tag) = SledeciTag Then
                                    ttBox.Select()
                                    Izlaz = True
                                    Exit For
                                End If
                            End If
                        Next
                    End If
                End If
                If Izlaz Then Exit For
            Next thisControl

        End If


    End Sub

    Sub AutoSifra()
        Dim rs As DataTable

        rs = GetData("SELECT MAX(Sifra) AS Novi FROM SifarnikMagacini")
        If rs.Rows.Count = 0 Or IsDBNull(rs(0)!Novi) Then
            TxtSifra.Text = "1"
        Else
            TxtSifra.Text = rs.Rows(0)!Novi + 1
        End If

    End Sub
    Sub BrisiPolja()

        For Each ttBox As Control In Controls
            If TypeOf ttBox Is TextBox Then
                ttBox.Text = ""
            End If
        Next

        CmbVrstaArtikla.SelectedValue = 1
        CmbVrstaCenovnika.SelectedValue = 4
        ChkPasivan.Checked = False
        ChkPasivan.ForeColor = Color.FromArgb(45, 45, 45)

        TxtNaziv.Select()

    End Sub
    Sub DajMagacin(Sifra As Long)
        Dim rs As DataTable

        rs = GetData("SELECT * FROM SifarnikMagacini WHERE Sifra=" & Sifra)

        If rs.Rows.Count = 0 Then Exit Sub

        TxtSifra.Text = rs(0)!Sifra.ToString
        TxtNaziv.Text = rs(0)!Naziv.ToString
        TxtLokacija.Text = rs(0)!Lokacija.ToString
        CmbVrstaArtikla.SelectedValue = rs(0)!VrstaArtikla
        CmbVrstaCenovnika.SelectedValue = rs.Rows(0)!VrstaCenovnika
        'TxtKonto.Text = rs.Rows(0)!Konto.ToString
        TxtNapomena.Text = rs(0)!Napomena.ToString
        ChkPasivan.Checked = rs(0)!Pasivan

        If ChkPasivan.Checked Then
            MsgBox("Magacin ima status NEAKTIVAN/PASIVAN!", MsgBoxStyle.Information)
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

            rs = GetData("SELECT * FROM SifarnikMagacini WHERE Sifra=" & CLng(TxtSifra.Text))
            If rs.Rows.Count > 0 And Parametri.Novi Then
                MsgBox("Magacin sa ovom šifrom već postoji! Unesite neku drugu šifru.", MsgBoxStyle.Exclamation)
                TxtSifra.Select()
                Exit Sub
            End If
            rs.Dispose()

            rs = GetData("SELECT * FROM SifarnikMagacini WHERE Naziv='" & TxtNaziv.Text & "'")
            If rs.Rows.Count > 0 And Parametri.Novi Then
                MsgBox("Magacin sa ovim nazivom već postoji!.", MsgBoxStyle.Exclamation)
                TxtNaziv.Select()
                Exit Sub
            End If


            If Parametri.Novi Then
                InsertData("INSERT INTO SifarnikMagacini VALUES(" & CInt(TxtSifra.Text) & ",'" & TxtNaziv.Text & "',0,'" & TxtLokacija.Text _
                           & "'," & CmbVrstaArtikla.SelectedValue & "," & CmbVrstaCenovnika.SelectedValue & ",'','" & TxtNapomena.Text & "','" & ChkPasivan.Checked & "')")

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Novi magacin','" & DocStatus & "'," & TxtSifra.Text & ",'" & TxtNaziv.Text & "')")

            Else
                InsertData("UPDATE SifarnikMagacini SET Naziv='" & TxtNaziv.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikMagacini SET Lokacija='" & TxtLokacija.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikMagacini SET VrstaArtikla=" & CmbVrstaArtikla.SelectedValue & " WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikMagacini SET VRstaCenovnika=" & CmbVrstaCenovnika.SelectedValue & " WHERE Sifra=" & CInt(TxtSifra.Text))
                'InsertData("UPDATE SifarnikMagacini SET Konto='" & TxtKonto.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikMagacini SET Napomena='" & TxtNapomena.Text & "' WHERE Sifra=" & CInt(TxtSifra.Text))
                InsertData("UPDATE SifarnikMagacini SET Pasivan='" & ChkPasivan.Checked & "' WHERE Sifra=" & CInt(TxtSifra.Text))

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Korekcija magacina','" & DocStatus & "'," & TxtSifra.Text & ",'" & TxtNaziv.Text & "')")

            End If


            'PnlOK.Visible = True
            'CmdSnimi.Enabled = False
            'CmdNovi.Enabled = False

            'tmrDelay.Enabled = True
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

        If IsNumeric(TxtSifra.Text) = False Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(TxtSifra, "Greška pri unosu šifre")
        End If

        If TxtNaziv.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(TxtNaziv, "Obavezan unos")
        End If

        If CmbVrstaArtikla.SelectedIndex = -1 Or IsNumeric(CmbVrstaArtikla.SelectedValue) = False Or CmbVrstaArtikla.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(CmbVrstaArtikla, "Izaberite vrstu artikla za koju se formira magacin")
        End If

        If CmbVrstaCenovnika.SelectedIndex = -1 Or IsNumeric(CmbVrstaCenovnika.SelectedValue) = False Or CmbVrstaCenovnika.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(CmbVrstaCenovnika, "Izaberite po kojim se cenama vodi magacin")
        End If

        TmrIndikatorGreske.Enabled = True

    End Sub


    Private Sub TmrDelay_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrDelay.Tick
        'PnlOK.Visible = False
        'CmdSnimi.Enabled = True
        'CmdNovi.Enabled = True

        'tmrDelay.Enabled = False

    End Sub
    Private Sub TmrIndikatorGreske_Tick(sender As Object, e As EventArgs) Handles TmrIndikatorGreske.Tick

        erpIndikatorGreske.SetError(TxtSifra, "")
        erpIndikatorGreske.SetError(TxtNaziv, "")
        erpIndikatorGreske.SetError(CmbVrstaArtikla, "")
        erpIndikatorGreske.SetError(CmbVrstaCenovnika, "")

        TmrIndikatorGreske.Enabled = False

    End Sub


    Private Sub CmdNovi_Click(sender As Object, e As EventArgs)

        BrisiPolja()
        AutoSifra()
        TxtNaziv.Select()

        Parametri.Novi = True
        CmdNovi.Enabled = False
    End Sub
    Private Sub cmdSnimi_Click(sender As Object, e As EventArgs)
        Snimi()
    End Sub
    Private Sub cmdIzlaz_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

End Class