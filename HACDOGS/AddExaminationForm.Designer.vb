<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddExaminationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddExaminationForm))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuTextBox1 = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuTextBox2 = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuTextBox3 = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 34)
        Me.Panel1.TabIndex = 43
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.Location = New System.Drawing.Point(53, 77)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(77, 18)
        Me.BunifuLabel1.TabIndex = 44
        Me.BunifuLabel1.Text = "Exam Name"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuTextBox1
        '
        Me.BunifuTextBox1.AcceptsReturn = False
        Me.BunifuTextBox1.AcceptsTab = False
        Me.BunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTextBox1.BackgroundImage = CType(resources.GetObject("BunifuTextBox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextBox1.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.BunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BunifuTextBox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuTextBox1.BorderRadius = 1
        Me.BunifuTextBox1.BorderThickness = 2
        Me.BunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTextBox1.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTextBox1.DefaultText = ""
        Me.BunifuTextBox1.FillColor = System.Drawing.Color.White
        Me.BunifuTextBox1.HideSelection = True
        Me.BunifuTextBox1.IconLeft = Nothing
        Me.BunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBox1.IconPadding = 10
        Me.BunifuTextBox1.IconRight = Nothing
        Me.BunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBox1.Location = New System.Drawing.Point(140, 68)
        Me.BunifuTextBox1.MaxLength = 32767
        Me.BunifuTextBox1.MinimumSize = New System.Drawing.Size(100, 35)
        Me.BunifuTextBox1.Modified = False
        Me.BunifuTextBox1.Name = "BunifuTextBox1"
        Me.BunifuTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BunifuTextBox1.ReadOnly = False
        Me.BunifuTextBox1.SelectedText = ""
        Me.BunifuTextBox1.SelectionLength = 0
        Me.BunifuTextBox1.SelectionStart = 0
        Me.BunifuTextBox1.ShortcutsEnabled = True
        Me.BunifuTextBox1.Size = New System.Drawing.Size(200, 35)
        Me.BunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.BunifuTextBox1.TabIndex = 1
        Me.BunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBox1.TextMarginLeft = 5
        Me.BunifuTextBox1.TextPlaceholder = ""
        Me.BunifuTextBox1.UseSystemPasswordChar = False
        '
        'BunifuTextBox2
        '
        Me.BunifuTextBox2.AcceptsReturn = False
        Me.BunifuTextBox2.AcceptsTab = False
        Me.BunifuTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTextBox2.BackgroundImage = CType(resources.GetObject("BunifuTextBox2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextBox2.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.BunifuTextBox2.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuTextBox2.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BunifuTextBox2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuTextBox2.BorderRadius = 1
        Me.BunifuTextBox2.BorderThickness = 2
        Me.BunifuTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTextBox2.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTextBox2.DefaultText = ""
        Me.BunifuTextBox2.FillColor = System.Drawing.Color.White
        Me.BunifuTextBox2.HideSelection = True
        Me.BunifuTextBox2.IconLeft = Nothing
        Me.BunifuTextBox2.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBox2.IconPadding = 10
        Me.BunifuTextBox2.IconRight = Nothing
        Me.BunifuTextBox2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBox2.Location = New System.Drawing.Point(140, 109)
        Me.BunifuTextBox2.MaxLength = 32767
        Me.BunifuTextBox2.MinimumSize = New System.Drawing.Size(100, 35)
        Me.BunifuTextBox2.Modified = False
        Me.BunifuTextBox2.Name = "BunifuTextBox2"
        Me.BunifuTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BunifuTextBox2.ReadOnly = False
        Me.BunifuTextBox2.SelectedText = ""
        Me.BunifuTextBox2.SelectionLength = 0
        Me.BunifuTextBox2.SelectionStart = 0
        Me.BunifuTextBox2.ShortcutsEnabled = True
        Me.BunifuTextBox2.Size = New System.Drawing.Size(200, 35)
        Me.BunifuTextBox2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.BunifuTextBox2.TabIndex = 2
        Me.BunifuTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBox2.TextMarginLeft = 5
        Me.BunifuTextBox2.TextPlaceholder = ""
        Me.BunifuTextBox2.UseSystemPasswordChar = False
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.Location = New System.Drawing.Point(38, 117)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(96, 18)
        Me.BunifuLabel2.TabIndex = 46
        Me.BunifuLabel2.Text = "Academic Year"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuTextBox3
        '
        Me.BunifuTextBox3.AcceptsReturn = False
        Me.BunifuTextBox3.AcceptsTab = False
        Me.BunifuTextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuTextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuTextBox3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTextBox3.BackgroundImage = CType(resources.GetObject("BunifuTextBox3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextBox3.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.BunifuTextBox3.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuTextBox3.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BunifuTextBox3.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.BunifuTextBox3.BorderRadius = 1
        Me.BunifuTextBox3.BorderThickness = 2
        Me.BunifuTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuTextBox3.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuTextBox3.DefaultText = ""
        Me.BunifuTextBox3.FillColor = System.Drawing.Color.White
        Me.BunifuTextBox3.HideSelection = True
        Me.BunifuTextBox3.IconLeft = Nothing
        Me.BunifuTextBox3.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBox3.IconPadding = 10
        Me.BunifuTextBox3.IconRight = Nothing
        Me.BunifuTextBox3.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuTextBox3.Location = New System.Drawing.Point(140, 150)
        Me.BunifuTextBox3.MaxLength = 32767
        Me.BunifuTextBox3.MinimumSize = New System.Drawing.Size(100, 35)
        Me.BunifuTextBox3.Modified = False
        Me.BunifuTextBox3.Name = "BunifuTextBox3"
        Me.BunifuTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BunifuTextBox3.ReadOnly = False
        Me.BunifuTextBox3.SelectedText = ""
        Me.BunifuTextBox3.SelectionLength = 0
        Me.BunifuTextBox3.SelectionStart = 0
        Me.BunifuTextBox3.ShortcutsEnabled = True
        Me.BunifuTextBox3.Size = New System.Drawing.Size(200, 35)
        Me.BunifuTextBox3.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.BunifuTextBox3.TabIndex = 3
        Me.BunifuTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuTextBox3.TextMarginLeft = 5
        Me.BunifuTextBox3.TextPlaceholder = ""
        Me.BunifuTextBox3.UseSystemPasswordChar = False
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.Location = New System.Drawing.Point(66, 158)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(61, 18)
        Me.BunifuLabel3.TabIndex = 48
        Me.BunifuLabel3.Text = "Semester"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuButton1
        '
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.ButtonText = "Enter"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.Gray
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.White
        Me.BunifuButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuButton1.IdleBorderRadius = 1
        Me.BunifuButton1.IdleBorderThickness = 0
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.Location = New System.Drawing.Point(140, 210)
        Me.BunifuButton1.Name = "BunifuButton1"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState = StateProperties1
        Me.BunifuButton1.Size = New System.Drawing.Size(112, 45)
        Me.BunifuButton1.TabIndex = 4
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'AddExaminationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 280)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.BunifuTextBox3)
        Me.Controls.Add(Me.BunifuLabel3)
        Me.Controls.Add(Me.BunifuTextBox2)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.BunifuTextBox1)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddExaminationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Examination"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuTextBox1 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuTextBox2 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuTextBox3 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
