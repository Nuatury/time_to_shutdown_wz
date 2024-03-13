Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Shell("cmd.exe /c shutdown -s -t 3600")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Shell("cmd.exe /c shutdown -s -t 7200")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Shell("cmd.exe /c shutdown -s -t 18000")
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Shell("cmd.exe /c shutdown -a")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Shell("cmd.exe /c shutdown -r -t 300")
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Shell("cmd.exe /c shutdown -r -t 3600")
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim timenum As Integer = 1
        timenum = NumericUpDown1.Value

        Dim kind As Integer = 3600
        Select Case ComboBox2.Text
            Case "秒"
                kind = 1
            Case "分钟"
                kind = 60
            Case "小时"
                kind = 3600
        End Select
        Dim act As String = "关机"
        Select Case ComboBox3.Text
            Case "关机"
                act = "-s"
            Case "重启"
                act = "-r"
        End Select
        Dim quest1 = "cmd.exe /c shutdown " + act + " -t " + Str(timenum * kind)
        Shell(quest1)
    End Sub

End Class
