<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm2vin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPass1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassRepeat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPass1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUser1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 155)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'txtPass1
        '
        Me.txtPass1.Location = New System.Drawing.Point(76, 69)
        Me.txtPass1.Name = "txtPass1"
        Me.txtPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass1.Size = New System.Drawing.Size(100, 20)
        Me.txtPass1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'txtUser1
        '
        Me.txtUser1.Location = New System.Drawing.Point(76, 43)
        Me.txtUser1.Name = "txtUser1"
        Me.txtUser1.Size = New System.Drawing.Size(100, 20)
        Me.txtUser1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Instructor"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(63, 113)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassRepeat
        '
        Me.txtPassRepeat.Location = New System.Drawing.Point(103, 73)
        Me.txtPassRepeat.Name = "txtPassRepeat"
        Me.txtPassRepeat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassRepeat.Size = New System.Drawing.Size(100, 20)
        Me.txtPassRepeat.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Repeat Password"
        '
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(103, 47)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass2.Size = New System.Drawing.Size(100, 20)
        Me.txtPass2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'txtUser2
        '
        Me.txtUser2.Location = New System.Drawing.Point(103, 21)
        Me.txtUser2.Name = "txtUser2"
        Me.txtUser2.Size = New System.Drawing.Size(100, 20)
        Me.txtUser2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Instructor"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(82, 113)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 12
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPassRepeat)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtPass2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtUser2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnRegister)
        Me.GroupBox2.Location = New System.Drawing.Point(228, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 155)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Register"
        '
        'loginForm2vin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 174)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "loginForm2vin"
        Me.Text = "loginForm2vin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPass1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUser1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassRepeat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPass2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUser2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
