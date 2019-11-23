Imports System.Data.SQLite
Public Class AddQuestionsForm
    Dim con As SQLiteConnection
    Dim examId As String

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

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
            Dim cmdString As String = "insert into tbl_questions values(null, 'multiple', '" & txtQuestion.Text & "','" & examId & "','" & txtCorrectAnswer.Text & "','" & txtWrongAnswer1.Text & "','" & txtWrongAnswer2.Text & "','" & txtWrongAnswer3.Text & "');"
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