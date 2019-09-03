Imports System.Data.SQLite
Public Class loginForm2vin
    Dim con As SQLiteConnection
    Dim cmdstring As String
    Dim dr As SQLiteDataReader
    Dim locationdb As String = Environment.CurrentDirectory
    Dim fileName As String = "db_main.db3"
    Dim fullPath As String = System.IO.Path.Combine(locationdb, fileName)
    Public connectString As String = String.Format("Data Source = {0}", fullPath)


    Public Sub createDatabase()
        If Not duplicateDatabase(fullPath) Then
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
                user_id = dr.GetInt16("user_id")
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

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtUser2.Text <> "" And txtPass2.Text <> "" And txtPassRepeat.Text <> "" Then
            If txtPass2.Text = txtPassRepeat.Text Then
                Dim registered As Boolean = False

                cmdstring = "select * from tbl_accounts where username='" & txtUser2.Text & "';"
                Dim cmd As New SQLiteCommand(cmdstring, con)
                dr = cmd.ExecuteReader()
                While dr.Read()
                    MessageBox.Show("User already registered.")
                    registered = True
                    Exit While
                End While
                dr.Close()

                If (Not registered) Then
                    cmdstring = "insert into tbl_accounts values (null, '" & txtUser2.Text & "', '" & txtPass2.Text & "');"
                    cmd.CommandText = cmdstring
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User registered successfully!")
                    txtUser2.ResetText()
                    txtPass2.ResetText()
                    txtPassRepeat.ResetText()
                End If
            Else
                MessageBox.Show("Please repeat password correctly.")
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
End Class