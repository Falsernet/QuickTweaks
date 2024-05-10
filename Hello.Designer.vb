<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hello
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hello))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.LoginScreen = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Aero = New System.Windows.Forms.TabPage()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.PhotoViewer = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.Tweaks = New System.Windows.Forms.TabPage()
        Me.About = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.LoginScreen.SuspendLayout()
        Me.Aero.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.Tweaks.SuspendLayout()
        Me.About.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.LoginScreen)
        Me.TabControl1.Controls.Add(Me.Aero)
        Me.TabControl1.Controls.Add(Me.PhotoViewer)
        Me.TabControl1.Location = New System.Drawing.Point(6, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(213, 144)
        Me.TabControl1.TabIndex = 0
        '
        'LoginScreen
        '
        Me.LoginScreen.AutoScroll = True
        Me.LoginScreen.BackColor = System.Drawing.Color.Black
        Me.LoginScreen.Controls.Add(Me.CheckBox1)
        Me.LoginScreen.Controls.Add(Me.CheckBox2)
        Me.LoginScreen.Location = New System.Drawing.Point(4, 22)
        Me.LoginScreen.Name = "LoginScreen"
        Me.LoginScreen.Padding = New System.Windows.Forms.Padding(3)
        Me.LoginScreen.Size = New System.Drawing.Size(205, 118)
        Me.LoginScreen.TabIndex = 0
        Me.LoginScreen.Text = "Login Screen"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(6, 6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(179, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Disable acrylic login background"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Cursor = System.Windows.Forms.Cursors.No
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(6, 29)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(157, 17)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "Disable swiping lock screen"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Aero
        '
        Me.Aero.AutoScroll = True
        Me.Aero.BackColor = System.Drawing.Color.Black
        Me.Aero.Controls.Add(Me.CheckBox3)
        Me.Aero.ForeColor = System.Drawing.Color.White
        Me.Aero.Location = New System.Drawing.Point(4, 22)
        Me.Aero.Name = "Aero"
        Me.Aero.Padding = New System.Windows.Forms.Padding(3)
        Me.Aero.Size = New System.Drawing.Size(205, 118)
        Me.Aero.TabIndex = 1
        Me.Aero.Text = "Taskbar"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.ForeColor = System.Drawing.Color.White
        Me.CheckBox3.Location = New System.Drawing.Point(6, 6)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(153, 17)
        Me.CheckBox3.TabIndex = 4
        Me.CheckBox3.Text = "Enable transparent taskbar"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'PhotoViewer
        '
        Me.PhotoViewer.BackColor = System.Drawing.Color.Black
        Me.PhotoViewer.Location = New System.Drawing.Point(4, 22)
        Me.PhotoViewer.Name = "PhotoViewer"
        Me.PhotoViewer.Size = New System.Drawing.Size(205, 118)
        Me.PhotoViewer.TabIndex = 2
        Me.PhotoViewer.Text = "Photo Viewer"
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.Tweaks)
        Me.TabControl2.Controls.Add(Me.About)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(223, 172)
        Me.TabControl2.TabIndex = 1
        '
        'Tweaks
        '
        Me.Tweaks.BackColor = System.Drawing.Color.Black
        Me.Tweaks.Controls.Add(Me.TabControl1)
        Me.Tweaks.ForeColor = System.Drawing.Color.White
        Me.Tweaks.Location = New System.Drawing.Point(4, 22)
        Me.Tweaks.Name = "Tweaks"
        Me.Tweaks.Padding = New System.Windows.Forms.Padding(3)
        Me.Tweaks.Size = New System.Drawing.Size(215, 146)
        Me.Tweaks.TabIndex = 0
        Me.Tweaks.Text = "Tweaks"
        '
        'About
        '
        Me.About.BackColor = System.Drawing.Color.Black
        Me.About.Controls.Add(Me.Label4)
        Me.About.Controls.Add(Me.PictureBox1)
        Me.About.Controls.Add(Me.Label3)
        Me.About.Controls.Add(Me.Label2)
        Me.About.Controls.Add(Me.Label1)
        Me.About.ForeColor = System.Drawing.Color.White
        Me.About.Location = New System.Drawing.Point(4, 22)
        Me.About.Name = "About"
        Me.About.Padding = New System.Windows.Forms.Padding(3)
        Me.About.Size = New System.Drawing.Size(215, 146)
        Me.About.TabIndex = 1
        Me.About.Text = "About"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QuickTweaks.My.Resources.Resources.logosmall
        Me.PictureBox1.Location = New System.Drawing.Point(113, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 61)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "by Sam Heppenstall"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "version 0.0.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QuickTweaks"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Couldn't fetch Windows version"
        '
        'Hello
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(247, 196)
        Me.Controls.Add(Me.TabControl2)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Hello"
        Me.Text = "QuickTweaks"
        Me.TabControl1.ResumeLayout(False)
        Me.LoginScreen.ResumeLayout(False)
        Me.LoginScreen.PerformLayout()
        Me.Aero.ResumeLayout(False)
        Me.Aero.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.Tweaks.ResumeLayout(False)
        Me.About.ResumeLayout(False)
        Me.About.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents LoginScreen As TabPage
    Friend WithEvents Aero As TabPage
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents Tweaks As TabPage
    Friend WithEvents About As TabPage
    Friend WithEvents PhotoViewer As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
