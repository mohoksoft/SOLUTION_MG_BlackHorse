Public Class frmMain
    'kdsajfbjsdkfbh
    'kadshbfhdsbfkhbd
    Private Sub CmdHello_Click(sender As Object, e As EventArgs) Handles CmdHello.Click
        If ChkOK.Checked = True Then
            MsgBox("Sa cekiranjem", vbCritical)
        Else
            MsgBox("Bez cekiranja")
        End If
    End Sub

    Private Sub CmdSabiranje_Click(sender As Object, e As EventArgs) Handles CmdSabiranje.Click
        'komentar sta radi ovaj taster
        LblDisplej.Text = "Rezultat = " & (CInt(TxtA.Text) + CInt(TxtB.Text)).ToString
        TxtDisplej.Text = (CInt(TxtA.Text) + CInt(TxtB.Text)).ToString
    End Sub

    Private Sub CmdIzlaz_Click(sender As Object, e As EventArgs) Handles CmdIzlaz.Click
        End
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblDisplej.Text = "Otvaranje"
    End Sub

    'Private Sub frmMain_Click(sender As Object, e As EventArgs) Handles Me.Click
    '    MsgBox("Klik na formu")
    'End Sub

    Private Sub frmMain_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        MsgBox("doubleKlik na formu")
    End Sub
End Class
