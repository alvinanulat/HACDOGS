Imports System.Data.SQLite

Public Class registerForm
    Dim con As SQLiteConnection
    Dim cmdstring As String
    Dim dr As SQLiteDataReader
    Dim locationdb As String = Environment.CurrentDirectory
    Dim fileName As String = "db_main.db3"
    Dim fullPath As String = System.IO.Path.Combine(locationdb, fileName)
    Public connectString As String = String.Format("Data Source = {0}", fileName)

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

                    loginForm2vin.Show()
                    Me.Close()
                End If
            Else
                MessageBox.Show("Please repeat password correctly.")
            End If


        Else
            MessageBox.Show("Please fill up all fields!")
        End If



    End Sub

    Private Sub registerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SQLiteConnection(connectString)
        Try
            con.Open()
        Catch ex As Exception

        End Try
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