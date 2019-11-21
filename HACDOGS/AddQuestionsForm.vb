Imports System.Data.SQLite
Public Class AddQuestionsForm
    Dim con As SQLiteConnection
    Dim examId As String

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
    Private Sub btnEnterQuestion_Click(sender As Object, e As EventArgs) Handles btnEnterQuestion.Click
        Try
            Dim cmdString As String = "insert into tbl_questions values(null, 'multiple', '" & txtQuestion.Text & "','" & examId & "','" & txtCorrectAnswer.Text & "','" & txtWrongAnswer1.Text & "','" & txtWrongAnswer2.Text & "','" & txtWrongAnswer3.Text & "');"
            Dim cmd As New SQLiteCommand(cmdString, con)
            cmd.ExecuteNonQuery()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class