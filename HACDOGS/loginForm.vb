Public Class loginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menuForm As New menuForm()
        menuForm.Show()
        Me.Close()
    End Sub
End Class