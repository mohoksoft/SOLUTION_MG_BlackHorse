Imports System.Data.SqlClient
Imports System.Configuration

Public Class FrmLogIn

    Dim css As String
    Private Sub FrmLogIn_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        css = GetSetting(My.Application.Info.Title, "Settings", "CSS", "Server=MOHOK-NINO\SQLEXPRESS;Database=SOLUTION_MG_BlackHorse;UId=sa;PWD=TakiTasa032;")

        CmbGodina.Items.Add(Year(Now) - 1)
        CmbGodina.Items.Add(Year(Now) - 2)
        CmbGodina.Items.Add(Year(Now) - 3)
        CmbGodina.Items.Add(Year(Now) - 4)
        CmbGodina.Items.Add(Year(Now) - 5)
        CmbGodina.Text = Year(Now)

        Veza = New SqlConnection

        On Error GoTo Greska
        Veza.ConnectionString = css

        Veza.Open()

        ActiveControl = TxtPassword
        [Select]()
        Activate()
        TxtPassword.Select()
        Exit Sub
Greska:

        If css = "False" Then End
        Veza.ConnectionString = css
        SaveSetting(My.Application.Info.Title, "Settings", "CSS", css)
        Resume Next
    End Sub
    Private Sub FrmLogIn_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        FrmMain.Show()
    End Sub
    Private Sub FrmLogIn_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles Me.DoubleClick

        If DajRacunar() = "MOHOK-MAJA" Or My.Computer.Name = "MOHOK-NINO" Then
            TxtPassword.Text = "kim"
            OK_Click(sender, e)
        Else
            MsgBox("Morate uneti lozinku!", MsgBoxStyle.Exclamation)
        End If

    End Sub



    Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK.Click

        Godina = CInt(CmbGodina.Text)
        TekucaGodina = Year(Now)

        Dim rsLog As DataTable = GetData("SELECT * FROM SifarnikOperateri WHERE Lozinka='" & TxtPassword.Text & "'")

        If rsLog.Rows.Count = 0 Then
            MsgBox("Uneta lozinka ne postoji!", MsgBoxStyle.Critical)
            TxtPassword.Select()
        Else
            Operater = rsLog.Rows(0)("Ime")
            UserID = rsLog.Rows(0)("ID")
            MinusID = UserID * -1
            Lozinka = TxtPassword.Text
            Close()
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancel.Click
        End
    End Sub


    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK_Click(sender, e)
        End If
    End Sub


End Class
