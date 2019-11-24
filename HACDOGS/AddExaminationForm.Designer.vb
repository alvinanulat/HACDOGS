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
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton2 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuDropdown1 = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.BunifuDropdown2 = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.BunifuDropdown3 = New Bunifu.UI.WinForms.BunifuDropdown()
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
        Me.Panel1.Size = New System.Drawing.Size(389, 34)
        Me.Panel1.TabIndex = 43
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel5.Location = New System.Drawing.Point(140, 9)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(104, 18)
        Me.BunifuLabel5.TabIndex = 50
        Me.BunifuLabel5.Text = "Add Examination"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
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
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
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
        Me.BunifuButton1.Location = New System.Drawing.Point(66, 212)
        Me.BunifuButton1.Name = "BunifuButton1"
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties2.BorderRadius = 1
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState = StateProperties2
        Me.BunifuButton1.Size = New System.Drawing.Size(112, 45)
        Me.BunifuButton1.TabIndex = 4
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuButton2
        '
        Me.BunifuButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.BackgroundImage = CType(resources.GetObject("BunifuButton2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton2.ButtonText = "Cancel"
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
        Me.BunifuButton2.Location = New System.Drawing.Point(211, 212)
        Me.BunifuButton2.Name = "BunifuButton2"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(54, Byte), Integer))
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.BunifuButton2.onHoverState = StateProperties1
        Me.BunifuButton2.Size = New System.Drawing.Size(112, 45)
        Me.BunifuButton2.TabIndex = 49
        Me.BunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuDropdown1.BorderRadius = 1
        Me.BunifuDropdown1.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.BunifuDropdown1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDropdown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.BunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick
        Me.BunifuDropdown1.DropDownHeight = 80
        Me.BunifuDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.BunifuDropdown1.FillDropDown = False
        Me.BunifuDropdown1.FillIndicator = False
        Me.BunifuDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuDropdown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown1.FormattingEnabled = True
        Me.BunifuDropdown1.Icon = Nothing
        Me.BunifuDropdown1.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.BunifuDropdown1.IntegralHeight = False
        Me.BunifuDropdown1.ItemBackColor = System.Drawing.Color.White
        Me.BunifuDropdown1.ItemBorderColor = System.Drawing.Color.White
        Me.BunifuDropdown1.ItemForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown1.ItemHeight = 26
        Me.BunifuDropdown1.ItemHighLightColor = System.Drawing.Color.Thistle
        Me.BunifuDropdown1.Location = New System.Drawing.Point(140, 109)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.Size = New System.Drawing.Size(200, 32)
        Me.BunifuDropdown1.TabIndex = 50
        '
        'BunifuDropdown2
        '
        Me.BunifuDropdown2.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuDropdown2.BorderRadius = 1
        Me.BunifuDropdown2.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuDropdown2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.BunifuDropdown2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDropdown2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.BunifuDropdown2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick
        Me.BunifuDropdown2.DropDownHeight = 80
        Me.BunifuDropdown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BunifuDropdown2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.BunifuDropdown2.FillDropDown = False
        Me.BunifuDropdown2.FillIndicator = False
        Me.BunifuDropdown2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuDropdown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuDropdown2.ForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown2.FormattingEnabled = True
        Me.BunifuDropdown2.Icon = Nothing
        Me.BunifuDropdown2.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuDropdown2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.BunifuDropdown2.IntegralHeight = False
        Me.BunifuDropdown2.ItemBackColor = System.Drawing.Color.White
        Me.BunifuDropdown2.ItemBorderColor = System.Drawing.Color.White
        Me.BunifuDropdown2.ItemForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown2.ItemHeight = 26
        Me.BunifuDropdown2.ItemHighLightColor = System.Drawing.Color.Thistle
        Me.BunifuDropdown2.Location = New System.Drawing.Point(140, 147)
        Me.BunifuDropdown2.Name = "BunifuDropdown2"
        Me.BunifuDropdown2.Size = New System.Drawing.Size(200, 32)
        Me.BunifuDropdown2.TabIndex = 51
        '
        'BunifuDropdown3
        '
        Me.BunifuDropdown3.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuDropdown3.BorderRadius = 1
        Me.BunifuDropdown3.Color = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuDropdown3.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.BunifuDropdown3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDropdown3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.BunifuDropdown3.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick
        Me.BunifuDropdown3.DropDownHeight = 80
        Me.BunifuDropdown3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BunifuDropdown3.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.BunifuDropdown3.FillDropDown = False
        Me.BunifuDropdown3.FillIndicator = False
        Me.BunifuDropdown3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuDropdown3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuDropdown3.ForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown3.FormattingEnabled = True
        Me.BunifuDropdown3.Icon = Nothing
        Me.BunifuDropdown3.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BunifuDropdown3.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.BunifuDropdown3.IntegralHeight = False
        Me.BunifuDropdown3.ItemBackColor = System.Drawing.Color.White
        Me.BunifuDropdown3.ItemBorderColor = System.Drawing.Color.White
        Me.BunifuDropdown3.ItemForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown3.ItemHeight = 26
        Me.BunifuDropdown3.ItemHighLightColor = System.Drawing.Color.Thistle
        Me.BunifuDropdown3.Items.AddRange(New Object() {"First Long Examination", "Midterm Examination", "Second Long Examination", "Final Examination"})
        Me.BunifuDropdown3.Location = New System.Drawing.Point(140, 71)
        Me.BunifuDropdown3.Name = "BunifuDropdown3"
        Me.BunifuDropdown3.Size = New System.Drawing.Size(200, 32)
        Me.BunifuDropdown3.TabIndex = 52
        '
        'AddExaminationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 280)
        Me.Controls.Add(Me.BunifuDropdown3)
        Me.Controls.Add(Me.BunifuDropdown2)
        Me.Controls.Add(Me.BunifuDropdown1)
        Me.Controls.Add(Me.BunifuButton2)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.BunifuLabel3)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddExaminationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Examination"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuButton2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuDropdown2 As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents BunifuDropdown1 As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents BunifuDropdown3 As Bunifu.UI.WinForms.BunifuDropdown
End Class
