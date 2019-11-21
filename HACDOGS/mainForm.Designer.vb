<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.minimizeButton = New System.Windows.Forms.PictureBox()
        Me.closeButton = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.lblLoggedIn = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btnMaximize = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtAddSubject = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.btnAddSubject = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnDeleteSubject = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.lblSubjectName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton2 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.minimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'minimizeButton
        '
        Me.minimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.minimizeButton.BackgroundImage = Global.HACDOGS.My.Resources.Resources.min2
        Me.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minimizeButton.Location = New System.Drawing.Point(36, 6)
        Me.minimizeButton.Name = "minimizeButton"
        Me.minimizeButton.Size = New System.Drawing.Size(18, 18)
        Me.minimizeButton.TabIndex = 36
        Me.minimizeButton.TabStop = False
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.Transparent
        Me.closeButton.BackgroundImage = Global.HACDOGS.My.Resources.Resources.x21
        Me.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closeButton.Location = New System.Drawing.Point(12, 6)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(18, 18)
        Me.closeButton.TabIndex = 35
        Me.closeButton.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(81, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "HACDOGS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.lblLoggedIn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(217, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(807, 34)
        Me.Panel1.TabIndex = 42
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.ButtonText = "Log-out"
        Me.btnLogout.ButtonTextMarginLeft = 0
        Me.btnLogout.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnLogout.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnLogout.DisabledForecolor = System.Drawing.Color.White
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnLogout.IconPadding = 10
        Me.btnLogout.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnLogout.IdleBorderColor = System.Drawing.Color.Firebrick
        Me.btnLogout.IdleBorderRadius = 1
        Me.btnLogout.IdleBorderThickness = 0
        Me.btnLogout.IdleFillColor = System.Drawing.Color.Firebrick
        Me.btnLogout.IdleIconLeftImage = Nothing
        Me.btnLogout.IdleIconRightImage = Nothing
        Me.btnLogout.Location = New System.Drawing.Point(712, 7)
        Me.btnLogout.Name = "btnLogout"
        StateProperties3.BorderColor = System.Drawing.Color.DarkRed
        StateProperties3.BorderRadius = 1
        StateProperties3.BorderThickness = 0
        StateProperties3.FillColor = System.Drawing.Color.DarkRed
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.btnLogout.onHoverState = StateProperties3
        Me.btnLogout.Size = New System.Drawing.Size(83, 20)
        Me.btnLogout.TabIndex = 42
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLoggedIn
        '
        Me.lblLoggedIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoggedIn.AutoEllipsis = False
        Me.lblLoggedIn.CursorType = Nothing
        Me.lblLoggedIn.Font = New System.Drawing.Font("SansSerif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblLoggedIn.Location = New System.Drawing.Point(523, 10)
        Me.lblLoggedIn.Name = "lblLoggedIn"
        Me.lblLoggedIn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLoggedIn.Size = New System.Drawing.Size(63, 17)
        Me.lblLoggedIn.TabIndex = 43
        Me.lblLoggedIn.Text = "Logged in:"
        Me.lblLoggedIn.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLoggedIn.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'btnMaximize
        '
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.BackgroundImage = Global.HACDOGS.My.Resources.Resources.full2
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximize.Location = New System.Drawing.Point(60, 6)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(18, 18)
        Me.btnMaximize.TabIndex = 38
        Me.btnMaximize.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.txtAddSubject)
        Me.Panel2.Controls.Add(Me.btnAddSubject)
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel2.Controls.Add(Me.btnDeleteSubject)
        Me.Panel2.Controls.Add(Me.btnMaximize)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.minimizeButton)
        Me.Panel2.Controls.Add(Me.closeButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(217, 740)
        Me.Panel2.TabIndex = 43
        '
        'txtAddSubject
        '
        Me.txtAddSubject.AcceptsReturn = False
        Me.txtAddSubject.AcceptsTab = False
        Me.txtAddSubject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAddSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtAddSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtAddSubject.BackColor = System.Drawing.Color.Transparent
        Me.txtAddSubject.BackgroundImage = CType(resources.GetObject("txtAddSubject.BackgroundImage"), System.Drawing.Image)
        Me.txtAddSubject.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.txtAddSubject.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.txtAddSubject.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.txtAddSubject.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtAddSubject.BorderRadius = 1
        Me.txtAddSubject.BorderThickness = 2
        Me.txtAddSubject.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAddSubject.DefaultFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddSubject.DefaultText = ""
        Me.txtAddSubject.FillColor = System.Drawing.Color.White
        Me.txtAddSubject.HideSelection = True
        Me.txtAddSubject.IconLeft = Nothing
        Me.txtAddSubject.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.txtAddSubject.IconPadding = 10
        Me.txtAddSubject.IconRight = Nothing
        Me.txtAddSubject.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.txtAddSubject.Location = New System.Drawing.Point(12, 622)
        Me.txtAddSubject.MaxLength = 32767
        Me.txtAddSubject.MinimumSize = New System.Drawing.Size(100, 35)
        Me.txtAddSubject.Modified = False
        Me.txtAddSubject.Name = "txtAddSubject"
        Me.txtAddSubject.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddSubject.ReadOnly = False
        Me.txtAddSubject.SelectedText = ""
        Me.txtAddSubject.SelectionLength = 0
        Me.txtAddSubject.SelectionStart = 0
        Me.txtAddSubject.ShortcutsEnabled = True
        Me.txtAddSubject.Size = New System.Drawing.Size(196, 35)
        Me.txtAddSubject.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu
        Me.txtAddSubject.TabIndex = 42
        Me.txtAddSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAddSubject.TextMarginLeft = 5
        Me.txtAddSubject.TextPlaceholder = ""
        Me.txtAddSubject.UseSystemPasswordChar = False
        '
        'btnAddSubject
        '
        Me.btnAddSubject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddSubject.BackColor = System.Drawing.Color.Transparent
        Me.btnAddSubject.BackgroundImage = CType(resources.GetObject("btnAddSubject.BackgroundImage"), System.Drawing.Image)
        Me.btnAddSubject.ButtonText = "Add Subject"
        Me.btnAddSubject.ButtonTextMarginLeft = 0
        Me.btnAddSubject.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnAddSubject.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnAddSubject.DisabledForecolor = System.Drawing.Color.White
        Me.btnAddSubject.ForeColor = System.Drawing.Color.White
        Me.btnAddSubject.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnAddSubject.IconPadding = 10
        Me.btnAddSubject.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnAddSubject.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnAddSubject.IdleBorderRadius = 1
        Me.btnAddSubject.IdleBorderThickness = 0
        Me.btnAddSubject.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnAddSubject.IdleIconLeftImage = Nothing
        Me.btnAddSubject.IdleIconRightImage = Nothing
        Me.btnAddSubject.Location = New System.Drawing.Point(12, 662)
        Me.btnAddSubject.Name = "btnAddSubject"
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties4.BorderRadius = 1
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.btnAddSubject.onHoverState = StateProperties4
        Me.btnAddSubject.Size = New System.Drawing.Size(192, 30)
        Me.btnAddSubject.TabIndex = 41
        Me.btnAddSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(13, 47)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 569)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'btnDeleteSubject
        '
        Me.btnDeleteSubject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteSubject.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteSubject.BackgroundImage = CType(resources.GetObject("btnDeleteSubject.BackgroundImage"), System.Drawing.Image)
        Me.btnDeleteSubject.ButtonText = "Delete Subject"
        Me.btnDeleteSubject.ButtonTextMarginLeft = 0
        Me.btnDeleteSubject.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnDeleteSubject.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnDeleteSubject.DisabledForecolor = System.Drawing.Color.White
        Me.btnDeleteSubject.ForeColor = System.Drawing.Color.White
        Me.btnDeleteSubject.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnDeleteSubject.IconPadding = 10
        Me.btnDeleteSubject.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnDeleteSubject.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnDeleteSubject.IdleBorderRadius = 1
        Me.btnDeleteSubject.IdleBorderThickness = 0
        Me.btnDeleteSubject.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnDeleteSubject.IdleIconLeftImage = Nothing
        Me.btnDeleteSubject.IdleIconRightImage = Nothing
        Me.btnDeleteSubject.Location = New System.Drawing.Point(12, 698)
        Me.btnDeleteSubject.Name = "btnDeleteSubject"
        StateProperties5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties5.BorderRadius = 1
        StateProperties5.BorderThickness = 1
        StateProperties5.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties5.IconLeftImage = Nothing
        StateProperties5.IconRightImage = Nothing
        Me.btnDeleteSubject.onHoverState = StateProperties5
        Me.btnDeleteSubject.Size = New System.Drawing.Size(192, 30)
        Me.btnDeleteSubject.TabIndex = 40
        Me.btnDeleteSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubjectName
        '
        Me.lblSubjectName.AutoSize = True
        Me.lblSubjectName.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectName.Location = New System.Drawing.Point(364, 47)
        Me.lblSubjectName.Name = "lblSubjectName"
        Me.lblSubjectName.Size = New System.Drawing.Size(77, 26)
        Me.lblSubjectName.TabIndex = 44
        Me.lblSubjectName.Text = "Subject"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 26)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Examinations in"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.btnLogout
        '
        'BunifuButton1
        '
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.ButtonText = "Add Examination"
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
        Me.BunifuButton1.Location = New System.Drawing.Point(228, 341)
        Me.BunifuButton1.Name = "BunifuButton1"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState = StateProperties1
        Me.BunifuButton1.Size = New System.Drawing.Size(192, 30)
        Me.BunifuButton1.TabIndex = 43
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuButton2
        '
        Me.BunifuButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.BackgroundImage = CType(resources.GetObject("BunifuButton2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton2.ButtonText = "Delete Examination"
        Me.BunifuButton2.ButtonTextMarginLeft = 0
        Me.BunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuButton2.DisabledFillColor = System.Drawing.Color.Gray
        Me.BunifuButton2.DisabledForecolor = System.Drawing.Color.White
        Me.BunifuButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconPadding = 10
        Me.BunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuButton2.IdleBorderRadius = 1
        Me.BunifuButton2.IdleBorderThickness = 0
        Me.BunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuButton2.IdleIconLeftImage = Nothing
        Me.BunifuButton2.IdleIconRightImage = Nothing
        Me.BunifuButton2.Location = New System.Drawing.Point(446, 341)
        Me.BunifuButton2.Name = "BunifuButton2"
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties2.BorderRadius = 1
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.BunifuButton2.onHoverState = StateProperties2
        Me.BunifuButton2.Size = New System.Drawing.Size(192, 30)
        Me.BunifuButton2.TabIndex = 42
        Me.BunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(228, 75)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(410, 260)
        Me.ListView1.TabIndex = 46
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 46
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Exam Name"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 140
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Academic Year"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 131
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Semester"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 81
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 740)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuButton2)
        Me.Controls.Add(Me.lblSubjectName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainForm"
        CType(Me.minimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents closeButton As PictureBox
    Friend WithEvents minimizeButton As PictureBox
    Friend WithEvents btnMaximize As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDeleteSubject As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAddSubject As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents lblSubjectName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogout As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents txtAddSubject As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents lblLoggedIn As Bunifu.UI.WinForms.BunifuLabel
End Class
