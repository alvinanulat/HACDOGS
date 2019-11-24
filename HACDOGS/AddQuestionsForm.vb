Imports System.Data.SQLite
Public Class AddQuestionsForm
    Dim con As SQLiteConnection
    Dim examId As String
    Dim questionId As String

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Dim isEditing As Boolean = False
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(con As SQLiteConnection, examId As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.con = con
        Me.examId = examId
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(con As SQLiteConnection, questionId As String, q As String, c As String, w1 As String, w2 As String, w3 As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.con = con
        Me.questionId = questionId
        txtQuestion.Text = q
        txtCorrectAnswer.Text = c
        txtWrongAnswer1.Text = w1
        txtWrongAnswer2.Text = w2
        txtWrongAnswer3.Text = w3
        BunifuLabel5.Text = "Edit Question"

        isEditing = True
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

    Private Sub btnEnterQuestion_Click(sender As Object, e As EventArgs) Handles btnEnterQuestion.Click
        Try
            Dim cmdString As String
            If isEditing Then
                cmdString = "update tbl_questions set question_content='" & txtQuestion.Text & "',
                                correct_answer='" & txtCorrectAnswer.Text & "',
                                wrong_answer1='" & txtWrongAnswer1.Text & "',
                                wrong_answer2='" & txtWrongAnswer2.Text & "',
                                wrong_answer3='" & txtWrongAnswer3.Text & "' where question_id='" & questionId & "';"
            Else
                cmdString = "insert into tbl_questions values(null, 'multiple', '" & txtQuestion.Text & "','" & examId & "','" & txtCorrectAnswer.Text & "','" & txtWrongAnswer1.Text & "','" & txtWrongAnswer2.Text & "','" & txtWrongAnswer3.Text & "');"

            End If

            Dim cmd As New SQLiteCommand(cmdString, con)
            cmd.ExecuteNonQuery()
            Me.Close()
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Me.Close()
    End Sub
End Class