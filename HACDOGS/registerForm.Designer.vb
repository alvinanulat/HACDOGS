<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registerForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registerForm))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.closeButton = New System.Windows.Forms.PictureBox()
        Me.minimizeButton = New System.Windows.Forms.PictureBox()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.cbUser = New System.Windows.Forms.ComboBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtPass1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.showregButton = New System.Windows.Forms.Button()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse5 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.pnlRegister = New System.Windows.Forms.Panel()
        Me.btnLoginInstead = New System.Windows.Forms.Button()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtUser2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassRepeat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuElipse6 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse7 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse8 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse9 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuElipse10 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse11 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogin.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlRegister.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(67, 367)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(622, 23)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Helpful Anti-Cheating Concept in Developing Official and Graded Exams System"
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.Red
        Me.closeButton.BackgroundImage = Global.HACDOGS.My.Resources.Resources.x21
        Me.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeButton.Location = New System.Drawing.Point(12, 5)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(18, 18)
        Me.closeButton.TabIndex = 35
        Me.closeButton.TabStop = False
        '
        'minimizeButton
        '
        Me.minimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.minimizeButton.BackgroundImage = Global.HACDOGS.My.Resources.Resources.min2
        Me.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minimizeButton.Location = New System.Drawing.Point(36, 5)
        Me.minimizeButton.Name = "minimizeButton"
        Me.minimizeButton.Size = New System.Drawing.Size(18, 18)
        Me.minimizeButton.TabIndex = 36
        Me.minimizeButton.TabStop = False
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.White
        Me.pnlLogin.Controls.Add(Me.cbUser)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.PictureBox3)
        Me.pnlLogin.Controls.Add(Me.txtPass1)
        Me.pnlLogin.Controls.Add(Me.PictureBox2)
        Me.pnlLogin.Controls.Add(Me.showregButton)
        Me.pnlLogin.Location = New System.Drawing.Point(244, 43)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(269, 312)
        Me.pnlLogin.TabIndex = 40
        '
        'cbUser
        '
        Me.cbUser.FormattingEnabled = True
        Me.cbUser.Location = New System.Drawing.Point(92, 148)
        Me.cbUser.Name = "cbUser"
        Me.cbUser.Size = New System.Drawing.Size(121, 21)
        Me.cbUser.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(86, 218)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(96, 39)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(52, 142)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 31)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'txtPass1
        '
        Me.txtPass1.Location = New System.Drawing.Point(91, 180)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass1.Size = New System.Drawing.Size(122, 20)
        Me.txtPass1.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(52, 174)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 31)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'showregButton
        '
        Me.showregButton.BackColor = System.Drawing.Color.Plum
        Me.showregButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.showregButton.FlatAppearance.BorderSize = 0
        Me.showregButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showregButton.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showregButton.ForeColor = System.Drawing.Color.Black
        Me.showregButton.Location = New System.Drawing.Point(91, 261)
        Me.showregButton.Name = "showregButton"
        Me.showregButton.Size = New System.Drawing.Size(86, 40)
        Me.showregButton.TabIndex = 6
        Me.showregButton.Text = "Create an Account"
        Me.showregButton.UseVisualStyleBackColor = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.closeButton)
        Me.Panel1.Controls.Add(Me.minimizeButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(756, 26)
        Me.Panel1.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "HACDOGS"
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 10
        Me.BunifuElipse4.TargetControl = Me.pnlLogin
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 10
        Me.BunifuElipse5.TargetControl = Me.pnlRegister
        '
        'pnlRegister
        '
        Me.pnlRegister.BackColor = System.Drawing.Color.White
        Me.pnlRegister.Controls.Add(Me.btnLoginInstead)
        Me.pnlRegister.Controls.Add(Me.txtPass2)
        Me.pnlRegister.Controls.Add(Me.btnRegister)
        Me.pnlRegister.Controls.Add(Me.txtUser2)
        Me.pnlRegister.Controls.Add(Me.Label4)
        Me.pnlRegister.Controls.Add(Me.txtPassRepeat)
        Me.pnlRegister.Controls.Add(Me.Label2)
        Me.pnlRegister.Controls.Add(Me.Label5)
        Me.pnlRegister.Location = New System.Drawing.Point(244, 43)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Size = New System.Drawing.Size(269, 312)
        Me.pnlRegister.TabIndex = 37
        '
        'btnLoginInstead
        '
        Me.btnLoginInstead.BackColor = System.Drawing.Color.Plum
        Me.btnLoginInstead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoginInstead.FlatAppearance.BorderSize = 0
        Me.btnLoginInstead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginInstead.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginInstead.ForeColor = System.Drawing.Color.Black
        Me.btnLoginInstead.Location = New System.Drawing.Point(91, 262)
        Me.btnLoginInstead.Name = "btnLoginInstead"
        Me.btnLoginInstead.Size = New System.Drawing.Size(86, 33)
        Me.btnLoginInstead.TabIndex = 35
        Me.btnLoginInstead.Text = "Login instead"
        Me.btnLoginInstead.UseVisualStyleBackColor = False
        '
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(112, 157)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass2.Size = New System.Drawing.Size(122, 20)
        Me.txtPass2.TabIndex = 23
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(86, 217)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(96, 39)
        Me.btnRegister.TabIndex = 30
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtUser2
        '
        Me.txtUser2.Location = New System.Drawing.Point(112, 129)
        Me.txtUser2.Name = "txtUser2"
        Me.txtUser2.Size = New System.Drawing.Size(122, 20)
        Me.txtUser2.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Instructor"
        '
        'txtPassRepeat
        '
        Me.txtPassRepeat.Location = New System.Drawing.Point(112, 183)
        Me.txtPassRepeat.Name = "txtPassRepeat"
        Me.txtPassRepeat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassRepeat.Size = New System.Drawing.Size(122, 20)
        Me.txtPassRepeat.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Repeat Password"
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 10
        Me.BunifuElipse6.TargetControl = Me.btnRegister
        '
        'BunifuElipse7
        '
        Me.BunifuElipse7.ElipseRadius = 10
        Me.BunifuElipse7.TargetControl = Me.btnLogin
        '
        'BunifuElipse8
        '
        Me.BunifuElipse8.ElipseRadius = 10
        Me.BunifuElipse8.TargetControl = Me.showregButton
        '
        'BunifuElipse9
        '
        Me.BunifuElipse9.ElipseRadius = 10
        Me.BunifuElipse9.TargetControl = Me.btnLoginInstead
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(244, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(269, 312)
        Me.Panel2.TabIndex = 38
        '
        'BunifuElipse10
        '
        Me.BunifuElipse10.ElipseRadius = 10
        Me.BunifuElipse10.TargetControl = Me.Panel2
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(323, 61)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(111, 97)
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        '
        'BunifuElipse11
        '
        Me.BunifuElipse11.ElipseRadius = 10
        Me.BunifuElipse11.TargetControl = Me.Panel2
        '
        'registerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(756, 399)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.pnlRegister)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "registerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HACDOGS"
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents closeButton As PictureBox
    Friend WithEvents minimizeButton As PictureBox
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPass1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents showregButton As Button
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse5 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse6 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse7 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse8 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pnlRegister As Panel
    Friend WithEvents btnLoginInstead As Button
    Friend WithEvents txtPass2 As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtUser2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassRepeat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuElipse9 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuElipse10 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents cbUser As ComboBox
    Friend WithEvents BunifuElipse11 As Bunifu.Framework.UI.BunifuElipse
End Class
