Imports System.Data.SQLite
Public Class mainForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        'Me.WindowState = FormWindowState.Normal
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then

            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
            Me.WindowState = FormWindowState.Normal
            a = 0
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Dim a As Integer = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If a = 0 Then
            Me.WindowState = FormWindowState.Maximized
            a = 1
        Else
            Me.WindowState = FormWindowState.Normal
            a = 0
        End If
    End Sub

    Private Sub Panel1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDoubleClick
        If a = 0 Then
            Me.WindowState = FormWindowState.Maximized
            a = 1
        Else
            Me.WindowState = FormWindowState.Normal
            a = 0
        End If
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