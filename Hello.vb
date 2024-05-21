Public Class Hello

    ReadOnly hklm As String = "HKEY_LOCAL_MACHINE\"
    ReadOnly hkcu As String = "HKEY_CURRENT_USER\"
    ReadOnly lPos As Integer = 0
    ReadOnly tPos As Integer = 27
    ReadOnly winWidth As Integer = 363
    Dim coolcat As Integer = 0

    Public Sub Hello_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LocateAll()

        If Int(winpoint().Substring(0, 1)) < My.Settings.minVersion Then
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
            versioncheck.Owner = Me
            versioncheck.Show()
            versioncheck.TopMost() = True
        End If

        Dim colormode As Integer = getColorMode()

        setcolors(getColors(False, colormode), getColors(True, colormode))

        Label2.Text() = "version " + My.Settings.VersionNum + " " + My.Settings.VersionType

        Label4.Text() = "Windows " + winver() + winpeasant(True) + ", build " + winbuild()

        If winver() = "10" Then
            InitWin10()
        End If

        menu_home_display()
    End Sub

    Private Sub InitWin10()
        menu_apps_photo.Enabled() = True
    End Sub

    Private Function getColorMode()
        If My.Settings.DarkMode = 1 Then
            Return 1
        ElseIf My.Settings.DarkMode = 2 Then
            Return 2
        Else
            If My.Computer.Registry.GetValue(hkcu + "SOFTWARE\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", Nothing) = 1 Then
                Return 1
            Else
                Return 2
            End If
        End If
    End Function

    Private Function getColors(returnfore As Boolean, mode As Integer)
        Dim backgr As Color
        Dim foregr As Color

        If mode = 1 Then
            backgr = Color.FromArgb(255, 255, 255)
            foregr = Color.FromArgb(0, 0, 0)
        ElseIf mode = 2 Then
            backgr = Color.FromArgb(0, 0, 0)
            foregr = Color.FromArgb(255, 255, 255)
        Else
            backgr = Color.FromArgb(0, 0, 255)
            foregr = Color.FromArgb(255, 255, 0)
        End If

        If returnfore = False Then
            Return backgr
        Else
            Return foregr
        End If
    End Function

    Private Sub setcolors(backgr As Color, foregr As Color)
        Me.BackColor() = backgr
        Me.ForeColor() = foregr
        versioncheck.BackColor() = backgr
        versioncheck.ForeColor() = foregr
    End Sub

    Private Function winver()
        Dim build As Integer = Convert.ToInt16(winbuild())
        If build >= 23000 Then
            Return "NT Unknown (>=11)"
        ElseIf build <= 22999 And build >= 22000 Then
            Return "11"
        ElseIf build <= 19999 And build >= 10000 Then
            Return "10"
        ElseIf build <= 9999 And winpoint() = "6.3" Then
            Return "8.1"
        ElseIf winpoint() = "6.2" Then
            Return "8"
        ElseIf winpoint() = "6.1" Then
            Return "7"
        ElseIf winpoint() = "6.0" Or winpoint() = "6" Then
            Return "Vista"
        ElseIf winpoint() = "5.2" And winbits() = "AMD64" Then
            Return "XP 64-bit"
        ElseIf winpoint() = "5.2" And winbits() <> "AMD64" Then
            Return "Server 2003"
        ElseIf winpoint() = "5.1" Then
            Return "XP 32-bit"
        ElseIf winpoint() = "5.0" Then
            Return "2000"
        ElseIf winpoint() = "4.90" Or winpoint() = "4.9" Then
            Return "ME"
        ElseIf winpoint() = "4.00" Or winpoint() = "4.10" Then
            Return "9x"
        ElseIf winpoint() = "4.0" Then
            Return "NT 4.0"
        Else
            Return "Unknown"
        End If
    End Function

    Private Function winpoint()
        Return My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion", "CurrentVersion", Nothing)
    End Function

    Private Function winbits()
        Return My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment", "PROCESSOR_ARCHITECTURE", Nothing)
    End Function

    Private Function winbuild()
        Dim sanpellegrino As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion", "CurrentBuild", Nothing)
        Dim lemon As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion", "CurrentBuildNumber", Nothing)

        If sanpellegrino = Nothing Then
            If lemon = Nothing Then
                Return Nothing
            Else
                Return lemon
            End If
        Else
            Return sanpellegrino
        End If
    End Function

    Private Function winpeasant(raze As Boolean)
        Dim valorant As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion", "EditionID", Nothing)

        If valorant <> Nothing And raze = True Then
            Return " " + valorant
        Else
            Return valorant
        End If
    End Function

    Private Sub Resizer(W, H)
        Me.Size() = New Size(W + (lPos * 2), H + (tPos * 2) + 32)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim currentcl As Color = Me.BackColor()
        Dim defaultcl As Color = getColors(False, 0)
        Dim newcl As Color
        coolcat += 1
        If coolcat >= 5 Then
            If currentcl.R = currentcl.G And currentcl.G = currentcl.B Then
                newcl = defaultcl
            Else
                newcl = incColor(currentcl)
            End If
            If ((coolcat - 5) Mod 6) < 3 Then
                setcolors(darkColor(newcl), invColor(newcl))
            Else
                setcolors(newcl, darkColor(invColor(newcl)))
            End If
        End If
    End Sub

    Private Function incColor(color As Color)
        If color.R = 0 And color.G = 0 Then
            Return Color.FromArgb(255, 0, 255)
        ElseIf color.R > 0 And color.B > 0 Then
            Return Color.FromArgb(255, 0, 0)
        ElseIf color.G = 0 And color.B = 0 Then
            Return Color.FromArgb(255, 255, 0)
        ElseIf color.R > 0 And color.G > 0 Then
            Return Color.FromArgb(0, 255, 0)
        ElseIf color.R = 0 And color.B = 0 Then
            Return Color.FromArgb(0, 255, 255)
        ElseIf color.G > 0 And color.B > 0 Then
            Return Color.FromArgb(0, 0, 255)
        Else
            Return Color.FromArgb(50, 50, 50)
        End If
    End Function

    Private Function invColor(color As Color)
        Dim red As Integer = 255 - color.R
        Dim green As Integer = 255 - color.G
        Dim blue As Integer = 255 - color.B
        Return Color.FromArgb(red, green, blue)
    End Function

    Private Function darkColor(color As Color)
        Dim minus As Integer = 128
        Dim red As Integer = Math.Max(0, color.R - minus)
        Dim green As Integer = Math.Max(0, color.G - minus)
        Dim blue As Integer = Math.Max(0, color.B - minus)
        Return Color.FromArgb(red, green, blue)
    End Function

    Private Sub HideAllPanels()
        panel_about.Hide()
        panel_login_screen.Hide()
        panel_office.Hide()
        panel_photo.Hide()
        panel_start.Hide()
        panel_taskbar.Hide()
        panel_theme.Hide()
    End Sub

    Private Sub LocateAll()
        panel_about.Left() = lPos
        panel_about.Top() = tPos

        panel_login_screen.Left() = lPos
        panel_login_screen.Top() = tPos

        panel_office.Left() = lPos
        panel_office.Top() = tPos

        panel_photo.Left() = lPos
        panel_photo.Top() = tPos

        panel_start.Left() = lPos
        panel_start.Top() = tPos

        panel_taskbar.Left() = lPos
        panel_taskbar.Top() = tPos

        panel_theme.Left() = lPos
        panel_theme.Top() = tPos
    End Sub

    Private Sub RegRead()

    End Sub

    Private Sub menu_home_Click(sender As Object, e As EventArgs) Handles menu_home.Click
        menu_home_display()
    End Sub

    Private Sub menu_home_display()
        HideAllPanels()
        Resizer(panel_login_screen.Width(), panel_about.Height() + 32)
        panel_about.Show()
    End Sub

    Private Sub menu_login_Click(sender As Object, e As EventArgs) Handles menu_login.Click
        HideAllPanels()
        Resizer(panel_login_screen.Width(), panel_login_screen.Height())
        panel_login_screen.Show()
    End Sub

    Private Sub menu_start_Click(sender As Object, e As EventArgs) Handles menu_start.Click
        HideAllPanels()
        Resizer(panel_start.Width(), panel_start.Height())
        panel_start.Show()
    End Sub

    Private Sub menu_taskbar_Click(sender As Object, e As EventArgs) Handles menu_taskbar.Click
        HideAllPanels()
        Resizer(panel_taskbar.Width(), panel_taskbar.Height())
        panel_taskbar.Show()
    End Sub

    Private Sub menu_theme_Click(sender As Object, e As EventArgs) Handles menu_theme.Click
        HideAllPanels()
        Resizer(panel_theme.Width(), panel_theme.Height())
        panel_theme.Show()
    End Sub

    Private Sub menu_apps_photo_Click(sender As Object, e As EventArgs) Handles menu_apps_photo.Click
        HideAllPanels()
        Resizer(panel_photo.Width(), panel_photo.Height())
        panel_photo.Show()
    End Sub

    Private Sub menu_apps_office_Click(sender As Object, e As EventArgs) Handles menu_apps_office.Click
        HideAllPanels()
        Resizer(panel_office.Width(), panel_office.Height())
        ComboBox3.SelectedIndex() = 1
        panel_office.Show()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedIndex() = 1 Then
            Label31.Image() = My.Resources.access
            Label32.Image() = My.Resources.Excel
            Label42.Image() = Nothing
            Label33.Image() = My.Resources.infopath
            Label34.Image() = My.Resources.onenote
            Label35.Image() = My.Resources.outlook
            Label36.Image() = My.Resources.powerpoint
            Label37.Image() = My.Resources.project
            Label38.Image() = My.Resources.publisher
            Label39.Image() = My.Resources.sharepoint
            Label40.Image() = My.Resources.visio
            Label41.Image() = My.Resources.word
        ElseIf ComboBox3.SelectedIndex() = 3 Then
            Label31.Image() = My.Resources.access03
            Label32.Image() = My.Resources.excel03
            Label42.Image() = Nothing
            Label33.Image() = My.Resources.infopath03
            Label34.Image() = Nothing
            Label35.Image() = My.Resources.outlook03
            Label36.Image() = My.Resources.ppt03
            Label37.Image() = Nothing
            Label38.Image() = My.Resources.pub03
            Label39.Image() = Nothing
            Label40.Image() = Nothing
            Label41.Image() = My.Resources.word03
        ElseIf ComboBox3.SelectedIndex() = 4 Then
            Label31.Image() = My.Resources.accessxp
            Label32.Image() = My.Resources.excelxp
            Label42.Image() = My.Resources.frontpagexp
            Label33.Image() = Nothing
            Label34.Image() = Nothing
            Label35.Image() = My.Resources.outlookxp
            Label36.Image() = My.Resources.pptxp
            Label37.Image() = Nothing
            Label38.Image() = Nothing
            Label39.Image() = Nothing
            Label40.Image() = Nothing
            Label41.Image() = My.Resources.wordxp
        End If
    End Sub
End Class


