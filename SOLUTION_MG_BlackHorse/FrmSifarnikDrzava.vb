Public Class FrmSifarnikDrzava
    Dim RetCom As ReturningComplet

    Private Sub FrmSifarnikDrzava_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rs As DataTable

        If Parametri.NovaDrzava Then
            BrisiPolja()
            AutoSifra()
            CmdNovi.Enabled = False
            TxtNaziv.Select()
        Else
            rs = GetData("SELECT * FROM SifarnikDrzave WHERE Sifra=" & Parametri.Sifra)

            TxtSifra.Text = rs(0)!Sifra
            TxtNaziv.Text = rs(0)!Naziv
            TxtNapomena.Text = rs(0)!Napomena.ToString
            ChkPasivan.Checked = rs(0)!Pasivan

            If ChkPasivan.Checked = True Then
                MsgBox("Država ima status NEAKTIVNA/PASIVNA!", MsgBoxStyle.Information)
                ChkPasivan.ForeColor = Color.FromArgb(220, 150, 90)
                Exit Sub
            Else
                ChkPasivan.ForeColor = Color.FromArgb(45, 45, 45)
            End If
            CmdNovi.Enabled = True
        End If

    End Sub


    Sub AutoSifra()
        Dim rs As DataTable

        rs = GetData("SELECT MAX(Sifra) AS Novi FROM SifarnikDrzave")
        If rs.Rows.Count = 0 Or IsDBNull(rs(0)!Novi) Then
            TxtSifra.Text = "1"
        Else
            TxtSifra.Text = rs.Rows(0)!Novi + 1
        End If

    End Sub
    Sub BrisiPolja()

        TxtSifra.Text = ""
        TxtNaziv.Text = ""
        TxtNapomena.Text = ""

        ChkPasivan.Checked = False
        ChkPasivan.ForeColor = Color.FromArgb(45, 45, 45)

    End Sub


    Private Sub cmdNovi_Click(sender As Object, e As EventArgs) Handles CmdNovi.Click

        BrisiPolja()
        AutoSifra()
        CmdNovi.Enabled = False
        Parametri.NovaDrzava = True
        TxtNaziv.Select()

    End Sub
    Private Sub CmdSnimi_Click(sender As Object, e As EventArgs) Handles CmdSnimi.Click
        Dim rs As DataTable

        If Parametri.PravoPristupa >= 2 Then

            ProveraObaveznihPolja()
            If RetCom.Poruka = "Greška" Then Exit Sub


            rs = GetData("SELECT * FROM SifarnikDrzave WHERE Sifra=" & CLng(TxtSifra.Text))
            If rs.Rows.Count > 0 And Parametri.NovaDrzava Then
                MsgBox("Država sa ovom šifrom već postoji! Unesite neku drugu šifru.", MsgBoxStyle.Exclamation)
                TxtSifra.Select()
                Exit Sub
            End If
            rs.Dispose()

            rs = GetData("SELECT * FROM SifarnikDrzave WHERE Naziv='" & TxtNaziv.Text & "'")
            If rs.Rows.Count > 0 And Parametri.NovaDrzava Then
                MsgBox("Država sa ovim nazivom već postoji!.", MsgBoxStyle.Exclamation)
                TxtNaziv.Select()
                Exit Sub
            End If

            If Parametri.NovaDrzava = True Then
                InsertData("INSERT INTO SifarnikDrzave VALUES(" & CLng(TxtSifra.Text) & ",'" & TxtNaziv.Text & "','" & TxtNapomena.Text & "','" & ChkPasivan.Checked & "')")

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Nova drzava','" & DocStatus & "'," & TxtSifra.Text & ",'" & TxtNaziv.Text & "')")
            Else
                InsertData("UPDATE SifarnikDrzave SET Naziv='" & TxtNaziv.Text & "' WHERE Sifra=" & CLng(TxtSifra.Text))
                InsertData("UPDATE SifarnikDrzave SET Napomena='" & TxtNapomena.Text & "' WHERE Sifra=" & CLng(TxtSifra.Text))
                InsertData("UPDATE SifarnikDrzave SET Pasivan='" & ChkPasivan.Checked & "' WHERE Sifra=" & CLng(TxtSifra.Text))

                InsertData("INSERT INTO Log VALUES('" & Operater & "','" & NazivPrograma & "','" & DajRacunar() & "','" & Format(Date.Now, FormatDatuma) & "','" & TimeOfDay _
                           & "','Korekcija drzave','" & DocStatus & "'," & TxtSifra.Text & ",'" & TxtNaziv.Text & "')")
            End If

            PnlOK.Visible = True
            CmdSnimi.Enabled = False
            CmdNovi.Enabled = False

            tmrDelay.Enabled = True
            Parametri.NovaDrzava = False

            If ChkPasivan.Checked = True Then
                ChkPasivan.ForeColor = Color.FromArgb(220, 150, 90)
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
            erpIndikatorGreske.SetError(TxtSifra, "Greška pri unosu")
        End If

        If TxtNaziv.Text = "" Then
            RetCom.Poruka = "Greška"
            erpIndikatorGreske.SetError(TxtNaziv, "Obavezan unos")
        End If

        TmrIndikatorGreske.Enabled = True

    End Sub
    Private Sub tmrDelay_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrDelay.Tick
        PnlOK.Visible = False
        CmdNovi.Enabled = True
        CmdSnimi.Enabled = True

        tmrDelay.Enabled = False

    End Sub
    Private Sub TmrIndikatorGreske_Tick(sender As Object, e As EventArgs) Handles TmrIndikatorGreske.Tick

        erpIndikatorGreske.SetError(TxtSifra, "")
        erpIndikatorGreske.SetError(TxtNaziv, "")

        TmrIndikatorGreske.Enabled = False

    End Sub
    Private Sub cmdIzlaz_Click(sender As Object, e As EventArgs) Handles cmdIzlaz.Click
        Close()
    End Sub

End Class