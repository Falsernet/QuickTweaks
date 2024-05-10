Public Class Hello
    Private Sub Hello_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New System.Drawing.Size(Me.Width, Me.Height)
        Me.Width = 450
        Me.Height = 450

        Dim colormode As Integer = 0

        If My.Settings.DarkMode = 1 Then
            colormode = 1
        ElseIf My.Settings.DarkMode = 2 Then
            colormode = 2
        Else
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", Nothing) = 1 Then
                colormode = 1
            Else
                colormode = 2
            End If
        End If

        If colormode = 1 Then
            Me.BackColor() = Color.FromArgb(255, 255, 255)
        ElseIf colormode = 2 Then
            Me.BackColor() = Color.FromArgb(0, 0, 0)
        Else
            Me.BackColor() = Color.FromArgb(0, 0, 255)
        End If

        Dim winvercode As String = My.Computer.Info.OSVersion.ToString()
        Dim winver As String = winvercode

        'If winvercode == "" Then

        Label4.Text() = "Windows version: " + winvercode + " a.k.a. " + winver

        DisableAcrylicBackgroundOnLogon(0)
        NoLockScreen(0)
        UseOLEDTaskbarTransparency(0)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        DisableAcrylicBackgroundOnLogon(1)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        NoLockScreen(1)
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        UseOLEDTaskbarTransparency(1)
    End Sub

    Private Sub DisableAcrylicBackgroundOnLogon(q As Integer)
        Dim value = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "DisableAcrylicBackgroundOnLogon", Nothing)
        If q = 0 Then
            If value = Nothing Then
                CheckBox1.CheckState() = 2
            ElseIf value = 1 Then
                CheckBox1.CheckState() = 1
            Else
                CheckBox1.CheckState() = 0
            End If
        ElseIf q = 1 Then
            Dim boxstate As Integer = CheckBox1.CheckState()
            If value <> boxstate Then
                If value = Nothing Then
                    My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Policies\Microsoft\Windows\System")
                End If
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "DisableAcrylicBackgroundOnLogon", boxstate)
            End If
        End If
    End Sub

    Private Sub NoLockScreen(q As Integer)
        Dim value = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Personalization", "NoLockScreen", Nothing)
        If q = 0 Then
            If value = Nothing Then
                CheckBox2.CheckState() = 2
            ElseIf value = 1 Then
                CheckBox2.CheckState() = 1
            Else
                CheckBox2.CheckState() = 0
            End If
        ElseIf q = 1 Then
            Dim boxstate As Integer = CheckBox2.CheckState()
            If value <> boxstate Then
                If value = Nothing Then
                    My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Policies\Microsoft\Windows\Personalization")
                End If
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Personalization", "NoLockScreen", boxstate)
            End If
        End If
    End Sub

    Private Sub UseOLEDTaskbarTransparency(q As Integer)
        Dim value = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "UseOLEDTaskbarTransparency", Nothing)
        If q = 0 Then
            If value = Nothing Then
                CheckBox3.CheckState() = 2
            ElseIf value = 1 Then
                CheckBox3.CheckState() = 1
            Else
                CheckBox3.CheckState() = 0
            End If
        ElseIf q = 1 Then
            Dim boxstate As Integer = CheckBox3.CheckState()
            If value <> boxstate Then
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "UseOLEDTaskbarTransparency", boxstate)
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\Dwm", "ForceEffectMode", boxstate)
            End If
        End If
    End Sub
End Class


