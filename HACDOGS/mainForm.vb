﻿Imports System.Data.SQLite
Public Class mainForm
    'Dim locphotos As String = Environment.CurrentDirectory & "\data\photos\"

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Dim locationdb As String = Environment.CurrentDirectory & "\db\"
    Dim fileName As String = "db_main.db3"
    'Dim fullPath As String = System.IO.Path.Combine(locationdb, fileName)
    Dim connectString As String = String.Format("Data Source = {0}", fullPath)

    Dim fullPath As String = System.IO.Path.Combine(locationdb, fileName)
    Dim conString As String = "Data Source = " & fullPath & ";password=anulatbuen;"
    Dim con As SQLiteConnection
    Dim cmd As SQLiteCommand

    Dim isDeletingSubject As Boolean = False

    Public userId As Integer
    Public username As String

    Private subjectId As String
    Private examId As String
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

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshSubjects()
        lblLoggedIn.Text = "Logged in: " & username
    End Sub



    Private Sub mainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'BunifuVScrollBar1.ThumbLength = FlowLayoutPanel1.VerticalScroll.
    End Sub

    Private Sub BunifuVScrollBar1_Scroll(sender As Object, e As Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs)
        FlowLayoutPanel1.AutoScrollPosition = New Point(FlowLayoutPanel1.AutoScrollPosition.X, e.Value)
    End Sub

    Private Sub refreshSubjects()
        Dim dr As SQLiteDataReader
        Dim cmdString As String

        FlowLayoutPanel1.Controls.Clear()

        Try
            con = New SQLiteConnection(conString)
            con.Open()
            cmdString = "select * from tbl_subjects where account_id=" & userId
            cmd = New SQLiteCommand(cmdString, con)
            dr = cmd.ExecuteReader()
            While dr.Read()
                'MessageBox.Show(dr.GetString(2))
                'Console.WriteLine(dr.getString("subject_name"))

                Dim tempButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
                Dim tempStateProperties As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
                tempStateProperties.FillColor = Color.FromArgb(137, 39, 52)
                tempStateProperties.BorderColor = System.Drawing.Color.FromArgb(137, 39, 52)
                tempStateProperties.BorderRadius = 1
                tempStateProperties.BorderThickness = 1
                'tempStateProperties.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
                tempStateProperties.IconLeftImage = Nothing
                tempStateProperties.IconRightImage = Nothing
                tempButton.onHoverState = tempStateProperties

                tempButton.Size = New System.Drawing.Size(175, 24)
                tempButton.ButtonText = dr.GetString(2)
                tempButton.Tag = dr.GetInt16(0).ToString
                tempButton.IdleFillColor = Color.FromArgb(253, 230, 214)
                tempButton.ForeColor = Color.Black

                AddHandler tempButton.Click, Function(sender, e) subjectButtonsHandler(tempButton.Tag, tempButton.ButtonText)


                FlowLayoutPanel1.Controls.Add(tempButton)

            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub refreshExams()
        Dim dr As SQLiteDataReader
        Dim cmdString As String = "select * from tbl_exams where subject_id='" & subjectId & "';"
        Dim lvi As ListViewItem
        Dim i As Integer = 1
        cmd = New SQLiteCommand(cmdString, con)
        dr = cmd.ExecuteReader()

        ListView1.Items.Clear()
        While dr.Read()
            lvi = New ListViewItem()
            lvi.Text = i
            i += 1
            lvi.Tag = dr.GetInt16(0)
            lvi.SubItems.Add(dr.GetString(1))
            lvi.SubItems.Add(dr.GetInt16(3))
            lvi.SubItems.Add(dr.GetString(4))
            lvi.SubItems.Add(dr.GetString(5))
            ListView1.Items.Add(lvi)
        End While
        dr.Close()
        'MessageBox.Show(subject)

    End Sub

    Private Sub refreshQuestions()
        Try
            Dim i As Integer = 1
            Dim lvi As ListViewItem
            Dim dr As SQLiteDataReader
            Dim cmdString As String = "select * from tbl_questions where exam_id='" & examId & "';"
            cmd = New SQLiteCommand(cmdString, con)
            dr = cmd.ExecuteReader()

            ListView2.Items.Clear()
            While dr.Read()
                lvi = New ListViewItem
                lvi.Text = i
                i += 1
                lvi.Tag = dr.GetInt16(0)
                lvi.SubItems.Add(dr.GetString(2))
                lvi.SubItems.Add(dr.GetString(4))
                lvi.SubItems.Add(dr.GetString(5))
                lvi.SubItems.Add(dr.GetString(6))
                lvi.SubItems.Add(dr.GetString(7))

                ListView2.Items.Add(lvi)
            End While
            dr.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Function subjectButtonsHandler(ByVal subject As String, ByVal subjectName As String) As String
        lblSubjectName.Text = subjectName
        subjectId = subject
        If isDeletingSubject Then
            Dim deleteYN As System.Windows.Forms.DialogResult
            deleteYN = MsgBox("Do you really want to delete the subject?", MsgBoxStyle.YesNo)
            If deleteYN = MsgBoxResult.Yes Then
                Try
                    Dim cmdString As String = "delete from tbl_subjects where subject_id='" & subject & "';"
                    cmd = New SQLiteCommand(cmdString, con)
                    cmd.ExecuteNonQuery()
                    refreshSubjects()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            End If
        Else
            refreshExams()
        End If

        Return ""
    End Function

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles btnDeleteSubject.Click
        If Not isDeletingSubject Then
            isDeletingSubject = True
            btnDeleteSubject.IdleFillColor = Color.FromArgb(216, 5, 11)
            btnDeleteSubject.IdleBorderColor = Color.FromArgb(216, 5, 11)
            btnDeleteSubject.ButtonText = "Select Subject/s to Delete"
            btnAddSubject.Enabled = False
        Else
            isDeletingSubject = False
            btnDeleteSubject.IdleFillColor = Color.FromArgb(51, 122, 183)
            btnDeleteSubject.IdleBorderColor = Color.FromArgb(51, 122, 183)
            btnDeleteSubject.ButtonText = "Delete Subject"
            btnAddSubject.Enabled = True
        End If

    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles btnAddSubject.Click
        Dim subjectName = txtAddSubject.Text
        txtAddSubject.Clear()

        If subjectName <> "" Then
            Dim cmdString As String
            Try
                cmdString = "insert into tbl_subjects values (null,'" & userId & "', '" & subjectName & "');"
                'MessageBox.Show(cmdString)
                cmd = New SQLiteCommand(cmdString, con)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

            refreshSubjects()
        End If


    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        registerForm.Show()
        Me.Close()
    End Sub

    Private Sub BunifuButton2_Click_1(sender As Object, e As EventArgs) Handles btnDeleteExam.Click
        Try
            Dim cmdString As String = "delete from tbl_exams where exam_id=" & ListView1.SelectedItems(0).Tag

            Dim deleteYN As System.Windows.Forms.DialogResult
            deleteYN = MsgBox("Do you really want to delete the examination?", MsgBoxStyle.YesNo)
            If deleteYN = MsgBoxResult.Yes Then

                cmd = New SQLiteCommand(cmdString, con)
                cmd.ExecuteNonQuery()
                refreshExams()
                ListView2.Items.Clear()
                lblExamName.Text = "Examination"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuButton1_Click_1(sender As Object, e As EventArgs) Handles btnAddExam.Click
        Dim temp As New AddExaminationForm(con, subjectId)
        temp.ShowDialog()
        temp.Dispose()
        refreshExams()
    End Sub

    Private Sub btnEditExam_Click(sender As Object, e As EventArgs) Handles btnEditExam.Click

    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        lblExamName.Text = ListView1.SelectedItems(0).SubItems.Item(1).Text
        examId = ListView1.SelectedItems(0).Tag
        refreshQuestions()
    End Sub

    Private Sub BunifuButton2_Click_2(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Dim temp As AddQuestionsForm = New AddQuestionsForm(con, examId)
        temp.ShowDialog()
        refreshQuestions()
        temp.Dispose()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Dim qList As List(Of String) = New List(Of String)

        For Each lvi As ListViewItem In ListView2.Items
            qList.Add(lvi.Tag)
        Next

        MessageBox.Show(qList.Count)
    End Sub

    Private rnd As New Random()

    Public Sub Shuffle(items As String())
        Dim j As Int32
        Dim temp As String

        For n As Int32 = items.Length - 1 To 0 Step -1
            j = rnd.Next(0, n + 1)
            ' Swap them.
            temp = items(n)
            items(n) = items(j)
            items(j) = temp
        Next n
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub
End Class