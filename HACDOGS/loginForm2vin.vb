Imports System.Data.SQLite
Public Class loginForm2vin
    Dim con As SQLiteConnection
    Dim cmdstring As String
    Dim dr As SQLiteDataReader
    Dim locationdb As String = Environment.CurrentDirectory
    Dim fileName As String = "db_main.db3"
    Dim fullPath As String = System.IO.Path.Combine(locationdb, fileName)
    Public connectString As String = String.Format("Data Source = {0}", fileName)


    Public Sub createDatabase()
        If Not duplicateDatabase(fullPath) Then
            System.Data.SQLite.SQLiteConnection.CreateFile("db_main.db3")

            Dim createTable As String = "CREATE TABLE `tbl_accounts` (
	                                            `id`	INTEGER NOT NULL,
	                                            `username`	TEXT,
                                            	`password`	INTEGER,
	                                            PRIMARY KEY(`id`)
                                                  );"
            Using con As New SQLiteConnection(connectString)
                Dim cmd As New SQLiteCommand(createTable, con)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End If
    End Sub
    Private Function duplicateDatabase(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser1.Text <> "" And txtPass1.Text <> "" Then
            Dim loggingIn As Boolean = False
            Dim username As String = ""
            Dim user_id As String = 0
            cmdstring = "select * from  tbl_accounts where username='" & txtUser1.Text & "' and password='" & txtPass1.Text & "';"
            Dim cmd As New SQLiteCommand(cmdstring, con)
            dr = cmd.ExecuteReader()
            While (dr.Read())
                MessageBox.Show("Logging in...")
                username = txtUser1.Text
                txtUser1.ResetText()
                txtPass1.ResetText()
                loggingIn = True
                user_id = dr.GetInt16(0)
                Exit While
            End While
            dr.Close()

            If (Not loggingIn) Then
                MessageBox.Show("Username or password is incorrect.")
            Else
                ' Dim newForm As New main(comPort, username, user_id)
                ' newForm.Show()
                ' Me.Close()

            End If

        Else
            MessageBox.Show("Please fill up all fields!")
        End If
    End Sub



    Private Sub loginForm2vin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        createDatabase()
        con = New SQLiteConnection(connectString)
        Try
            con.Open()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub showregButton_Click(sender As Object, e As EventArgs) Handles showregButton.Click

        registerForm.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Dim ExitYN As System.Windows.Forms.DialogResult
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            MyBase.Close()
        Else
        End If
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimizeButton.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
End Class