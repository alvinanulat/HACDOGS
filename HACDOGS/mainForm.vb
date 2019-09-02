Imports System.Data.SQLite
Public Class mainForm
    'Dim locationdb As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Dim cmdstring As String

    Dim locationdb As String = Environment.CurrentDirectory
    Dim fileName As String = "db_main.db3"
    Dim fullPath As String = System.IO.Path.Combine(locationdb, fileName)
    Public connectString As String = String.Format("Data Source = {0}", fullPath)

    Public Sub createDatabase()
        If Not duplicateDatabase(fullPath) Then
            Dim createTable As String = "CREATE TABLE `tbl_sets` (
	                                     `id`	INTEGER NOT NULL,
	                                    `sets`	INTEGER,
                                    	PRIMARY KEY(`id`)
                                        );"
            Using SqlConn As New SQLiteConnection(connectString)
                Dim cmd As New SQLiteCommand(createTable, SqlConn)
                SqlConn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End If
    End Sub
    Private Function duplicateDatabase(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createDatabase()
    End Sub

    Private Sub testButton_Click(sender As Object, e As EventArgs) Handles testButton.Click
        Using sqlconn As New SQLiteConnection(connectString)
            cmdstring = "Insert into  tbl_sets  (sets) values ('" & TextBox1.Text & "');"
            Dim cmd As New SQLiteCommand(cmdstring, sqlconn)
            sqlconn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class