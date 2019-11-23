<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetForm))
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSetAlias = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnWord = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblExam = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblSubject = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblAcadYear = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lblSem = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 104)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(864, 335)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 37
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Question"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 244
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Letter of Answer"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 106
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Correct Answer"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 108
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Wrong Answer 1"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Wrong Answer 2"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 120
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Wrong  Answer 3"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 120
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblSetAlias)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 34)
        Me.Panel1.TabIndex = 45
        '
        'lblSetAlias
        '
        Me.lblSetAlias.AutoEllipsis = False
        Me.lblSetAlias.CursorType = Nothing
        Me.lblSetAlias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetAlias.Location = New System.Drawing.Point(402, 3)
        Me.lblSetAlias.Name = "lblSetAlias"
        Me.lblSetAlias.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSetAlias.Size = New System.Drawing.Size(75, 26)
        Me.lblSetAlias.TabIndex = 46
        Me.lblSetAlias.Text = "Set Alias"
        Me.lblSetAlias.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblSetAlias.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuButton1
        '
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.ButtonText = "Exit"
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
        Me.BunifuButton1.Location = New System.Drawing.Point(513, 445)
        Me.BunifuButton1.Name = "BunifuButton1"
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties3.BorderRadius = 1
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState = StateProperties3
        Me.BunifuButton1.Size = New System.Drawing.Size(129, 29)
        Me.BunifuButton1.TabIndex = 47
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnWord
        '
        Me.btnWord.BackColor = System.Drawing.Color.Transparent
        Me.btnWord.BackgroundImage = CType(resources.GetObject("btnWord.BackgroundImage"), System.Drawing.Image)
        Me.btnWord.ButtonText = "View in MS Word"
        Me.btnWord.ButtonTextMarginLeft = 0
        Me.btnWord.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.btnWord.DisabledFillColor = System.Drawing.Color.Gray
        Me.btnWord.DisabledForecolor = System.Drawing.Color.White
        Me.btnWord.ForeColor = System.Drawing.Color.White
        Me.btnWord.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnWord.IconPadding = 10
        Me.btnWord.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnWord.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnWord.IdleBorderRadius = 1
        Me.btnWord.IdleBorderThickness = 0
        Me.btnWord.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnWord.IdleIconLeftImage = Nothing
        Me.btnWord.IdleIconRightImage = Nothing
        Me.btnWord.Location = New System.Drawing.Point(236, 447)
        Me.btnWord.Name = "btnWord"
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties4.BorderRadius = 1
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.btnWord.onHoverState = StateProperties4
        Me.btnWord.Size = New System.Drawing.Size(129, 29)
        Me.btnWord.TabIndex = 48
        Me.btnWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.Location = New System.Drawing.Point(12, 40)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(71, 26)
        Me.BunifuLabel1.TabIndex = 47
        Me.BunifuLabel1.Text = "Subject:"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.Location = New System.Drawing.Point(12, 72)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(112, 26)
        Me.BunifuLabel2.TabIndex = 49
        Me.BunifuLabel2.Text = "Examination:"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel3.Location = New System.Drawing.Point(460, 72)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(88, 26)
        Me.BunifuLabel3.TabIndex = 50
        Me.BunifuLabel3.Text = "Semester:"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.CursorType = Nothing
        Me.BunifuLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel4.Location = New System.Drawing.Point(460, 40)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(137, 26)
        Me.BunifuLabel4.TabIndex = 51
        Me.BunifuLabel4.Text = "Academic Year:"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblExam
        '
        Me.lblExam.AutoEllipsis = False
        Me.lblExam.CursorType = Nothing
        Me.lblExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExam.Location = New System.Drawing.Point(130, 72)
        Me.lblExam.Name = "lblExam"
        Me.lblExam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblExam.Size = New System.Drawing.Size(107, 26)
        Me.lblExam.TabIndex = 52
        Me.lblExam.Text = "Examination"
        Me.lblExam.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblExam.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblSubject
        '
        Me.lblSubject.AutoEllipsis = False
        Me.lblSubject.CursorType = Nothing
        Me.lblSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(130, 40)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSubject.Size = New System.Drawing.Size(66, 26)
        Me.lblSubject.TabIndex = 53
        Me.lblSubject.Text = "Subject"
        Me.lblSubject.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblSubject.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblAcadYear
        '
        Me.lblAcadYear.AutoEllipsis = False
        Me.lblAcadYear.CursorType = Nothing
        Me.lblAcadYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcadYear.Location = New System.Drawing.Point(603, 40)
        Me.lblAcadYear.Name = "lblAcadYear"
        Me.lblAcadYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAcadYear.Size = New System.Drawing.Size(132, 26)
        Me.lblAcadYear.TabIndex = 54
        Me.lblAcadYear.Text = "Academic Year"
        Me.lblAcadYear.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblAcadYear.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lblSem
        '
        Me.lblSem.AutoEllipsis = False
        Me.lblSem.CursorType = Nothing
        Me.lblSem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSem.Location = New System.Drawing.Point(603, 72)
        Me.lblSem.Name = "lblSem"
        Me.lblSem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSem.Size = New System.Drawing.Size(83, 26)
        Me.lblSem.TabIndex = 55
        Me.lblSem.Text = "Semester"
        Me.lblSem.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.lblSem.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'SetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 492)
        Me.Controls.Add(Me.lblSem)
        Me.Controls.Add(Me.lblAcadYear)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblExam)
        Me.Controls.Add(Me.BunifuLabel4)
        Me.Controls.Add(Me.BunifuLabel3)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.btnWord)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SetForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AnswerKey"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents lblSetAlias As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnWord As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblExam As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblSubject As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblAcadYear As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lblSem As Bunifu.UI.WinForms.BunifuLabel
End Class
