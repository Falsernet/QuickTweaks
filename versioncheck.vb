Public Class versioncheck
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonKill.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Hello.WindowState = FormWindowState.Normal
        Hello.ShowInTaskbar = True
    End Sub
End Class