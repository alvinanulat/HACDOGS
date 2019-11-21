<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddQuestionsForm
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
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddQuestionsForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btnEnterQuestion = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.txtWrongAnswer1 = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.txtCorrectAnswer = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.txtQuestion = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.txtWrongAnswer2 = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtWrongAnswer3 = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.BunifuLabel6 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuLabel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 34)
        Me.Panel1.TabIndex = 44
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.Location = New System.Drawing.Point(12, 179)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(100, 18)
        Me.BunifuLabel3.TabIndex = 55
        Me.BunifuLabel3.Text = "Wrong Answer 1"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.Location = New System.Drawing.Point(12, 114)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(93, 18)
        Me.BunifuLabel2.TabIndex = 54
        Me.BunifuLabel2.Text = "Correct Answer"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.Location = New System.Drawing.Point(12, 49)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(56, 18)
        Me.BunifuLabel1.TabIndex = 53
        Me.BunifuLabel1.Text = "Question"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'btnEnterQuestion
        '
        Me.btnEnterQuestion.BackColor = System.Drawing.Color.Transparent
        Me.btnEnterQuestion.BackgroundImage = CType(resources.GetObject("btnEnterQuestion.BackgroundImage"), System.Drawing.Image)
        Me.btnEnterQuestion.ButtonText = "Enter"
        Me.btnEnterQuestion.ButtonTextMarginLeft = 0
        Me.btnEnterQuestion.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnEnterQuestion.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnEnterQuestion.DisabledForecolor = System.Drawing.Color.White
        Me.btnEnterQuestion.ForeColor = System.Drawing.Color.White
        Me.btnEnterQuestion.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnEnterQuestion.IconPadding = 10
        Me.btnEnterQuestion.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnEnterQuestion.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnEnterQuestion.IdleBorderRadius = 1
        Me.btnEnterQuestion.IdleBorderThickness = 0
        Me.btnEnterQuestion.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnEnterQuestion.IdleIconLeftImage = Nothing
        Me.btnEnterQuestion.IdleIconRightImage = Nothing
        Me.btnEnterQuestion.Location = New System.Drawing.Point(144, 374)
        Me.btnEnterQuestion.Name = "btnEnterQuestion"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btnEnterQuestion.onHoverState = StateProperties1
        Me.btnEnterQuestion.Size = New System.Drawing.Size(112, 45)
        Me.btnEnterQuestion.TabIndex = 6
        Me.btnEnterQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtWrongAnswer1
        '
        Me.txtWrongAnswer1.AcceptsReturn = False
        Me.txtWrongAnswer1.AcceptsTab = False
        Me.txtWrongAnswer1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtWrongAnswer1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtWrongAnswer1.BackColor = System.Drawing.Color.Transparent
        Me.txtWrongAnswer1.BackgroundImage = CType(resources.GetObject("txtWrongAnswer1.BackgroundImage"), System.Drawing.Image)
        Me.txtWrongAnswer1.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtWrongAnswer1.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.txtWrongAnswer1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.txtWrongAnswer1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtWrongAnswer1.BorderRadius = 1
        Me.txtWrongAnswer1.BorderThickness = 2
        Me.txtWrongAnswer1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtWrongAnswer1.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWrongAnswer1.DefaultText = ""
        Me.txtWrongAnswer1.FillColor = System.Drawing.Color.White
        Me.txtWrongAnswer1.HideSelection = True
        Me.txtWrongAnswer1.IconLeft = Nothing
        Me.txtWrongAnswer1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.txtWrongAnswer1.IconPadding = 10
        Me.txtWrongAnswer1.IconRight = Nothing
        Me.txtWrongAnswer1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.txtWrongAnswer1.Location = New System.Drawing.Point(12, 203)
        Me.txtWrongAnswer1.MaxLength = 32767
        Me.txtWrongAnswer1.MinimumSize = New System.Drawing.Size(100, 35)
        Me.txtWrongAnswer1.Modified = False
        Me.txtWrongAnswer1.Name = "txtWrongAnswer1"
        Me.txtWrongAnswer1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWrongAnswer1.ReadOnly = False
        Me.txtWrongAnswer1.SelectedText = ""
        Me.txtWrongAnswer1.SelectionLength = 0
        Me.txtWrongAnswer1.SelectionStart = 0
        Me.txtWrongAnswer1.ShortcutsEnabled = True
        Me.txtWrongAnswer1.Size = New System.Drawing.Size(507, 35)
        Me.txtWrongAnswer1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.txtWrongAnswer1.TabIndex = 3
        Me.txtWrongAnswer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtWrongAnswer1.TextMarginLeft = 5
        Me.txtWrongAnswer1.TextPlaceholder = ""
        Me.txtWrongAnswer1.UseSystemPasswordChar = False
        '
        'txtCorrectAnswer
        '
        Me.txtCorrectAnswer.AcceptsReturn = False
        Me.txtCorrectAnswer.AcceptsTab = False
        Me.txtCorrectAnswer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtCorrectAnswer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtCorrectAnswer.BackColor = System.Drawing.Color.Transparent
        Me.txtCorrectAnswer.BackgroundImage = CType(resources.GetObject("txtCorrectAnswer.BackgroundImage"), System.Drawing.Image)
        Me.txtCorrectAnswer.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtCorrectAnswer.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.txtCorrectAnswer.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.txtCorrectAnswer.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtCorrectAnswer.BorderRadius = 1
        Me.txtCorrectAnswer.BorderThickness = 2
        Me.txtCorrectAnswer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCorrectAnswer.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrectAnswer.DefaultText = ""
        Me.txtCorrectAnswer.FillColor = System.Drawing.Color.White
        Me.txtCorrectAnswer.HideSelection = True
        Me.txtCorrectAnswer.IconLeft = Nothing
        Me.txtCorrectAnswer.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.txtCorrectAnswer.IconPadding = 10
        Me.txtCorrectAnswer.IconRight = Nothing
        Me.txtCorrectAnswer.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.txtCorrectAnswer.Location = New System.Drawing.Point(12, 138)
        Me.txtCorrectAnswer.MaxLength = 32767
        Me.txtCorrectAnswer.MinimumSize = New System.Drawing.Size(100, 35)
        Me.txtCorrectAnswer.Modified = False
        Me.txtCorrectAnswer.Name = "txtCorrectAnswer"
        Me.txtCorrectAnswer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorrectAnswer.ReadOnly = False
        Me.txtCorrectAnswer.SelectedText = ""
        Me.txtCorrectAnswer.SelectionLength = 0
        Me.txtCorrectAnswer.SelectionStart = 0
        Me.txtCorrectAnswer.ShortcutsEnabled = True
        Me.txtCorrectAnswer.Size = New System.Drawing.Size(507, 35)
        Me.txtCorrectAnswer.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.txtCorrectAnswer.TabIndex = 2
        Me.txtCorrectAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCorrectAnswer.TextMarginLeft = 5
        Me.txtCorrectAnswer.TextPlaceholder = ""
        Me.txtCorrectAnswer.UseSystemPasswordChar = False
        '
        'txtQuestion
        '
        Me.txtQuestion.AcceptsReturn = False
        Me.txtQuestion.AcceptsTab = False
        Me.txtQuestion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtQuestion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtQuestion.BackColor = System.Drawing.Color.Transparent
        Me.txtQuestion.BackgroundImage = CType(resources.GetObject("txtQuestion.BackgroundImage"), System.Drawing.Image)
        Me.txtQuestion.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtQuestion.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.txtQuestion.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.txtQuestion.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtQuestion.BorderRadius = 1
        Me.txtQuestion.BorderThickness = 2
        Me.txtQuestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtQuestion.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.DefaultText = ""
        Me.txtQuestion.FillColor = System.Drawing.Color.White
        Me.txtQuestion.HideSelection = True
        Me.txtQuestion.IconLeft = Nothing
        Me.txtQuestion.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.txtQuestion.IconPadding = 10
        Me.txtQuestion.IconRight = Nothing
        Me.txtQuestion.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.txtQuestion.Location = New System.Drawing.Point(12, 73)
        Me.txtQuestion.MaxLength = 32767
        Me.txtQuestion.MinimumSize = New System.Drawing.Size(100, 35)
        Me.txtQuestion.Modified = False
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuestion.ReadOnly = False
        Me.txtQuestion.SelectedText = ""
        Me.txtQuestion.SelectionLength = 0
        Me.txtQuestion.SelectionStart = 0
        Me.txtQuestion.ShortcutsEnabled = True
        Me.txtQuestion.Size = New System.Drawing.Size(507, 35)
        Me.txtQuestion.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.txtQuestion.TabIndex = 1
        Me.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtQuestion.TextMarginLeft = 5
        Me.txtQuestion.TextPlaceholder = ""
        Me.txtQuestion.UseSystemPasswordChar = False
        '
        'txtWrongAnswer2
        '
        Me.txtWrongAnswer2.AcceptsReturn = False
        Me.txtWrongAnswer2.AcceptsTab = False
        Me.txtWrongAnswer2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtWrongAnswer2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtWrongAnswer2.BackColor = System.Drawing.Color.Transparent
        Me.txtWrongAnswer2.BackgroundImage = CType(resources.GetObject("txtWrongAnswer2.BackgroundImage"), System.Drawing.Image)
        Me.txtWrongAnswer2.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtWrongAnswer2.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.txtWrongAnswer2.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.txtWrongAnswer2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtWrongAnswer2.BorderRadius = 1
        Me.txtWrongAnswer2.BorderThickness = 2
        Me.txtWrongAnswer2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtWrongAnswer2.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWrongAnswer2.DefaultText = ""
        Me.txtWrongAnswer2.FillColor = System.Drawing.Color.White
        Me.txtWrongAnswer2.HideSelection = True
        Me.txtWrongAnswer2.IconLeft = Nothing
        Me.txtWrongAnswer2.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.txtWrongAnswer2.IconPadding = 10
        Me.txtWrongAnswer2.IconRight = Nothing
        Me.txtWrongAnswer2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.txtWrongAnswer2.Location = New System.Drawing.Point(12, 268)
        Me.txtWrongAnswer2.MaxLength = 32767
        Me.txtWrongAnswer2.MinimumSize = New System.Drawing.Size(100, 35)
        Me.txtWrongAnswer2.Modified = False
        Me.txtWrongAnswer2.Name = "txtWrongAnswer2"
        Me.txtWrongAnswer2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWrongAnswer2.ReadOnly = False
        Me.txtWrongAnswer2.SelectedText = ""
        Me.txtWrongAnswer2.SelectionLength = 0
        Me.txtWrongAnswer2.SelectionStart = 0
        Me.txtWrongAnswer2.ShortcutsEnabled = True
        Me.txtWrongAnswer2.Size = New System.Drawing.Size(507, 35)
        Me.txtWrongAnswer2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.txtWrongAnswer2.TabIndex = 4
        Me.txtWrongAnswer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtWrongAnswer2.TextMarginLeft = 5
        Me.txtWrongAnswer2.TextPlaceholder = ""
        Me.txtWrongAnswer2.UseSystemPasswordChar = False
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.CursorType = Nothing
        Me.BunifuLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel4.Location = New System.Drawing.Point(12, 244)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(100, 18)
        Me.BunifuLabel4.TabIndex = 57
        Me.BunifuLabel4.Text = "Wrong Answer 2"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txtWrongAnswer3
        '
        Me.txtWrongAnswer3.AcceptsReturn = False
        Me.txtWrongAnswer3.AcceptsTab = False
        Me.txtWrongAnswer3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtWrongAnswer3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtWrongAnswer3.BackColor = System.Drawing.Color.Transparent
        Me.txtWrongAnswer3.BackgroundImage = CType(resources.GetObject("txtWrongAnswer3.BackgroundImage"), System.Drawing.Image)
        Me.txtWrongAnswer3.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtWrongAnswer3.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.txtWrongAnswer3.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.txtWrongAnswer3.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtWrongAnswer3.BorderRadius = 1
        Me.txtWrongAnswer3.BorderThickness = 2
        Me.txtWrongAnswer3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtWrongAnswer3.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWrongAnswer3.DefaultText = ""
        Me.txtWrongAnswer3.FillColor = System.Drawing.Color.White
        Me.txtWrongAnswer3.HideSelection = True
        Me.txtWrongAnswer3.IconLeft = Nothing
        Me.txtWrongAnswer3.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.txtWrongAnswer3.IconPadding = 10
        Me.txtWrongAnswer3.IconRight = Nothing
        Me.txtWrongAnswer3.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.txtWrongAnswer3.Location = New System.Drawing.Point(12, 333)
        Me.txtWrongAnswer3.MaxLength = 32767
        Me.txtWrongAnswer3.MinimumSize = New System.Drawing.Size(100, 35)
        Me.txtWrongAnswer3.Modified = False
        Me.txtWrongAnswer3.Name = "txtWrongAnswer3"
        Me.txtWrongAnswer3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWrongAnswer3.ReadOnly = False
        Me.txtWrongAnswer3.SelectedText = ""
        Me.txtWrongAnswer3.SelectionLength = 0
        Me.txtWrongAnswer3.SelectionStart = 0
        Me.txtWrongAnswer3.ShortcutsEnabled = True
        Me.txtWrongAnswer3.Size = New System.Drawing.Size(507, 35)
        Me.txtWrongAnswer3.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.txtWrongAnswer3.TabIndex = 5
        Me.txtWrongAnswer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtWrongAnswer3.TextMarginLeft = 5
        Me.txtWrongAnswer3.TextPlaceholder = ""
        Me.txtWrongAnswer3.UseSystemPasswordChar = False
        '
        'BunifuLabel6
        '
        Me.BunifuLabel6.AutoEllipsis = False
        Me.BunifuLabel6.CursorType = Nothing
        Me.BunifuLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel6.Location = New System.Drawing.Point(12, 309)
        Me.BunifuLabel6.Name = "BunifuLabel6"
        Me.BunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel6.Size = New System.Drawing.Size(100, 18)
        Me.BunifuLabel6.TabIndex = 59
        Me.BunifuLabel6.Text = "Wrong Answer 3"
        Me.BunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuButton1
        '
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.ButtonText = "Cancel"
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
        Me.BunifuButton1.Location = New System.Drawing.Point(293, 374)
        Me.BunifuButton1.Name = "BunifuButton1"
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties2.BorderRadius = 1
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState = StateProperties2
        Me.BunifuButton1.Size = New System.Drawing.Size(112, 45)
        Me.BunifuButton1.TabIndex = 7
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel5.Location = New System.Drawing.Point(220, 10)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(84, 18)
        Me.BunifuLabel5.TabIndex = 0
        Me.BunifuLabel5.Text = "Add Question"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'AddQuestionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 434)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.txtWrongAnswer3)
        Me.Controls.Add(Me.BunifuLabel6)
        Me.Controls.Add(Me.txtWrongAnswer2)
        Me.Controls.Add(Me.BunifuLabel4)
        Me.Controls.Add(Me.btnEnterQuestion)
        Me.Controls.Add(Me.txtWrongAnswer1)
        Me.Controls.Add(Me.BunifuLabel3)
        Me.Controls.Add(Me.txtCorrectAnswer)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddQuestionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddQuestionsForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEnterQuestion As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents txtWrongAnswer1 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtCorrectAnswer As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtQuestion As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtWrongAnswer2 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents txtWrongAnswer3 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents BunifuLabel6 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
End Class
