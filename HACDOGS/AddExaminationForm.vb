Imports System.Data.SQLite

Public Class AddExaminationForm
    Dim con As SQLiteConnection
    Dim subjectId As String

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
    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Try
            Dim cmdString As String = "insert into tbl_exams values (null, '" & BunifuTextBox1.Text & "', '" & subjectId & "', '" & BunifuTextBox2.Text & "', '" & BunifuTextBox3.Text & "');"
            Dim cmd As SQLiteCommand
            cmd = New SQLiteCommand(cmdString, con)
            cmd.ExecuteNonQuery()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub BunifuTextBox1_TextChange(sender As Object, e As EventArgs) Handles BunifuTextBox1.TextChange

    End Sub

    Private Sub AddExaminationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuTextBox1.Select()
    End Sub

    Private Sub AddExaminationForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            BunifuButton1.PerformClick()
        End If
    End Sub
End Class