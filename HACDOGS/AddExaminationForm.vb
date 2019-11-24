Imports System.Data.SQLite

Public Class AddExaminationForm
    Dim con As SQLiteConnection
    Dim subjectId As String
    Dim examId As String

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Dim isEditing As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(con As SQLiteConnection, subjectId As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.con = con
        Me.subjectId = subjectId
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(con As SQLiteConnection, examId As String, examName As String, acadYear As String, sem As String)

        ' This call is required by the designer.
        InitializeComponent()
        isEditing = True
        BunifuLabel5.Text = "Editing Examination"
        Me.examId = examId
        Me.con = con
        BunifuTextBox1.Text = examName
        BunifuDropdown1.Text = acadYear
        BunifuDropdown2.Text = sem

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, BunifuLabel5.MouseDown
        drag = True
        'Me.WindowState = FormWindowState.Normal
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, BunifuLabel5.MouseMove
        If drag Then

            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
            Me.WindowState = FormWindowState.Normal
            'A = 0
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp, BunifuLabel5.MouseUp
        drag = False
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Try
            Dim cmdString As String
            If isEditing Then
                cmdstring = "update tbl_exams set exam_name='" & BunifuTextBox1.Text & "', academic_year='" & BunifuDropdown1.Text & "', semester='" & BunifuDropdown2.Text & "' where exam_id='" & examId & "';"
            Else
                cmdstring = "insert into tbl_exams values (null, '" & BunifuTextBox1.Text & "', '" & subjectId & "', '0','" & BunifuDropdown1.Text & "', '" & BunifuDropdown2.Text & "');"
            End If
            'MessageBox.Show(cmdstring)
            Dim cmd As SQLiteCommand
            cmd = New SQLiteCommand(cmdString, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub AddExaminationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dateNow As Date = New Date().Now()
        Dim yearNow As String = dateNow.Year

        For i As Integer = yearNow To 2000 Step -1
            BunifuDropdown1.Items.Add(i & "-" & i + 1)
        Next
        BunifuDropdown2.Items.Add("1st Semester")
        BunifuDropdown2.Items.Add("2nd Semester")
        BunifuDropdown2.Items.Add("Summer")

        BunifuTextBox1.Select()


    End Sub

    Private Sub AddExaminationForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            BunifuButton1.PerformClick()
        End If
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Me.Close()
    End Sub
End Class