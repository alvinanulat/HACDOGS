Imports System.ComponentModel
Imports System.Data.SQLite
Imports System.Text.RegularExpressions
'Imports Word = Microsoft.Office.Interop.Word

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
    Private setId As String
    Private questionId As String
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, lblLoggedIn.MouseDown
        drag = True
        'Me.WindowState = FormWindowState.Normal
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, lblLoggedIn.MouseMove
        If drag Then

            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
            Me.WindowState = FormWindowState.Normal
            a = 0
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp, lblLoggedIn.MouseUp
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

        ListView2.Items.Clear()
        questionId = ""
        lblExamName.Text = "Exam"
        ListView3.Items.Clear()
        setId = ""
        ListView1.Items.Clear()
        examId = ""
        lblSubjectName.Text = "Subject"
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

            ListView3.Items.Clear()
            setId = ""
            ListView2.Items.Clear()
            questionId = ""
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
        If isDeletingSubject Then
            Dim deleteYN As System.Windows.Forms.DialogResult
            deleteYN = MsgBox("Do you really want to delete the subject?", MsgBoxStyle.YesNo)
            If deleteYN = MsgBoxResult.Yes Then
                Try
                    Dim cmdString As String = "delete from tbl_subjects where subject_id='" & subject & "';"
                    cmd = New SQLiteCommand(cmdString, con)
                    cmd.ExecuteNonQuery()
                    refreshSubjects()
                    ListView1.Items.Clear()
                    lblSubjectName.Text = "Subject"
                    subjectId = ""
                    ListView2.Items.Clear()
                    lblExamName.Text = "Exam"
                    examId = ""
                    ListView3.Items.Clear()
                    setId = ""
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            End If
        Else
            subjectId = subject

            refreshExams()
            lblSubjectName.Text = subjectName

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
            btnDeleteSubject.IdleFillColor = Color.FromArgb(254, 127, 74)
            btnDeleteSubject.IdleBorderColor = Color.FromArgb(254, 127, 74)
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
        Else
            MsgBox("Enter a valid Subject.")
        End If


    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim logout As System.Windows.Forms.DialogResult
        logout = MsgBox("Do you really want to logout?", MsgBoxStyle.YesNo)
        If logout = MsgBoxResult.Yes Then
            registerForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BunifuButton2_Click_1(sender As Object, e As EventArgs) Handles btnDeleteExam.Click
        Try
            If ListView1.SelectedItems().Count > 0 Then
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
            Else
                MsgBox("Select what Examination will be deleted.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuButton1_Click_1(sender As Object, e As EventArgs) Handles btnAddExam.Click
        If subjectId <> "" Then
            Dim temp As New AddExaminationForm(con, subjectId)
            temp.ShowDialog()
            temp.Dispose()
            refreshExams()
        Else
            MsgBox("Select what Subject will be edited.")
        End If
    End Sub

    Private Sub btnEditExam_Click(sender As Object, e As EventArgs) Handles btnEditExam.Click
        If ListView1.SelectedItems().Count > 0 Then
            Dim examName As String = ListView1.SelectedItems(0).SubItems.Item(1).Text
            Dim acadYear As String = ListView1.SelectedItems(0).SubItems.Item(3).Text
            Dim sem As String = ListView1.SelectedItems(0).SubItems.Item(4).Text

            Dim temp As AddExaminationForm = New AddExaminationForm(con, examId, examName, acadYear, sem)
            temp.ShowDialog()
            temp.Dispose()
            refreshExams()
        Else
            MsgBox("Select what Examination will be edited.")
        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick

    End Sub

    Private Sub BunifuButton2_Click_2(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        If ListView1.SelectedItems().Count > 0 Or ListView2.SelectedItems().Count > 0 Then
            Dim temp As AddQuestionsForm = New AddQuestionsForm(con, examId)
            temp.ShowDialog()
            refreshQuestions()
            temp.Dispose()
        Else
            MsgBox("Select what Examination will be added a new question.")
        End If
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Dim qList As List(Of String) = New List(Of String)
        Dim aList As String

        For Each lvi As ListViewItem In ListView2.Items
            qList.Add(lvi.Tag)
        Next

        If qList.Count <= 0 Then
            Exit Sub
        End If

        Dim now As Date = New Date().Now()
        Dim dateTimeNow As String = Regex.Replace(now.ToShortDateString & now.ToLongTimeString, "[^0-9]", "")


        'MessageBox.Show(aList)
        For j As Integer = 1 To Integer.Parse(txtNumberOfSets.Text)
            Try
                aList = ""
                For i As Integer = 1 To qList.Count
                    aList &= rnd.Next(1, 5).ToString() & ","
                Next

                aList = aList.Substring(0, aList.Length - 1)


                Dim cmdString As String = "insert into tbl_sets values (null, '" & examId & "','" & Shuffle(qList.ToArray()) & "','" & aList & "','" & dateTimeNow & "_" & j & "');"
                cmd = New SQLiteCommand(cmdString, con)
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Next
        refreshSets()

    End Sub

    Private rnd As New Random()

    Public Function Shuffle(items As String()) As String
        Dim j As Int32
        Dim temp As String
        Dim output As String = ""

        For n As Int32 = items.Length - 1 To 0 Step -1
            j = rnd.Next(0, n + 1)
            ' Swap them.
            temp = items(n)
            items(n) = items(j)
            items(j) = temp
        Next n

        For Each i As String In items
            output &= i & ","
        Next

        Return output.Substring(0, output.Length - 1)

    End Function

    Private Sub ListView1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseClick
        lblExamName.Text = ListView1.SelectedItems(0).SubItems.Item(1).Text
        examId = ListView1.SelectedItems(0).Tag
        refreshQuestions()
        refreshSets()
    End Sub

    Private Sub refreshSets()
        Try
            Dim i As Integer = 1
            Dim lvi As ListViewItem
            Dim dr As SQLiteDataReader
            Dim cmdString As String = "select * from tbl_sets where exam_id='" & examId & "';"
            cmd = New SQLiteCommand(cmdString, con)
            dr = cmd.ExecuteReader()

            ListView3.Items.Clear()
            setId = ""
            While dr.Read()
                lvi = New ListViewItem
                lvi.Text = i
                i += 1
                lvi.Tag = dr.GetInt16(0)
                lvi.SubItems.Add(dr.GetString(4))

                ListView3.Items.Add(lvi)
            End While
            dr.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        Try
            If ListView2.SelectedItems().Count > 0 Then
                Dim index As String = ListView2.SelectedItems(0).Tag
                Dim cmdString As String = "delete from tbl_questions where question_id='" & index & "';"
                cmd = New SQLiteCommand(cmdString, con)
                Dim DeleteYN As System.Windows.Forms.DialogResult
                DeleteYN = MsgBox("Do you really want to delete the question?", MsgBoxStyle.YesNo)
                If DeleteYN = MsgBoxResult.Yes Then
                    cmd.ExecuteNonQuery()
                    refreshQuestions()
                End If
            Else
                MsgBox("Select what Question will be deleted.")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles btnGenerator.Click
        'Dim objWordApp As New Word.Application
        'objWordApp.Visible = True

        ''Open an existing document.  
        'Dim objDoc As Word.Document = objWordApp.Documents.Open(Environment.CurrentDirectory & "/db/examtemp.docx")
        'objDoc = objWordApp.ActiveDocument

        Dim cmdString As String = "select questions, answers, set_alias from tbl_sets where set_id='" & setId & "';"
        'Dim cmd As SQLiteCommand = New SQLiteCommand(cmdString, con)
        'Dim dr As SQLiteDataReader
        'dr = cmd.ExecuteReader()
        'Dim answers As String = ""
        'Dim questions As String = ""
        'While dr.Read()
        '    questions = dr.GetString(0)
        '    MessageBox.Show(questions)
        '    answers = dr.GetString(1)
        '    MessageBox.Show(answers)
        '    ' lblSetAlias.Text = dr.GetString(2)
        'End While
        'dr.Close()
        'Dim cmdString As String = "select exam_name,academic_year,semester from tbl_exams where exam_id = (select exam_id from tbl_sets where tbl_sets.set_id='" & setId & "');"
        'MsgBox(cmdString)
        'Dim cmd As SQLiteCommand = New SQLiteCommand(cmdString, con)
        'Dim dr As SQLiteDataReader
        'dr = cmd.ExecuteReader()
        ''Dim answers As String = ""
        'Dim sem As String = ""
        'Dim acadyear As String = ""
        'Dim exam As String = ""
        'Dim section As String = ""
        'While dr.Read()
        '    exam = dr.GetString(0)
        '    acadyear = dr.GetString(1)
        '    sem = dr.GetString(2)
        '    ' MessageBox.Show(sem)
        'End While
        'dr.Close()

        'cmdString = "select subject_name from tbl_subjects where subject_id=(select subject_id from tbl_exams where exam_id = (select exam_id from tbl_sets where tbl_sets.set_id='" & setId & "'));"
        'MsgBox(cmdString)
        'cmd = New SQLiteCommand(cmdString, con)
        'dr = cmd.ExecuteReader()
        'Dim subject As String = ""
        'While dr.Read()
        '    subject = dr.GetString(0)
        '    ' MessageBox.Show(sem)
        'End While
        'dr.Close()
        ''Find and replace some text  
        ''Replace 'VB' with 'Visual Basic'  
        'objDoc.Content.Find.Execute(FindText:="$sem$", ReplaceWith:=sem, Replace:=Word.WdReplace.wdReplaceAll)
        'objDoc.Content.Find.Execute(FindText:="$acadyear$", ReplaceWith:=acadyear, Replace:=Word.WdReplace.wdReplaceAll)
        'objDoc.Content.Find.Execute(FindText:="$exam$", ReplaceWith:=exam, Replace:=Word.WdReplace.wdReplaceAll)
        'objDoc.Content.Find.Execute(FindText:="$subject$", ReplaceWith:=subject, Replace:=Word.WdReplace.wdReplaceAll)
        ''objDoc.Content.Find.Execute(FindText:="$sem$", ReplaceWith:=sem, Replace:=Word.WdReplace.wdReplaceAll)
        'While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
        '    objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        'End While

        ''Save And Close() the document  
        ''objDoc.Save()
        ''objDoc.Close()
        ''objDoc = Nothing
        ''objWordApp.Quit()
        ''objWordApp = Nothing

        If examId <> "" Then

            Try
                Dim q As Integer = 20
                For i As Integer = 1 To q
                    cmdString = "insert into tbl_questions values(null,
                    'multiple',
                    'This is the content of question number " & i & ".',
                    '" & examId & "',
                    'Correct answer to question number " & i & "',
                    'First wrong answer to question number " & i & "',
                    'Second wrong answer to question number " & i & "',
                    'Third wrong answer to question number " & i & "');"
                    cmd = New SQLiteCommand(cmdString, con)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Next

                MessageBox.Show(q & "questions created!")

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            MsgBox("Select what Subject will be edited.")
        End If
    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles btnAnswerKey.Click
        'MessageBox.Show(ListView3.SelectedItems.Count)
        If ListView3.SelectedItems.Count = 1 Then
            Dim temp As New SetForm(con, setId)
            temp.ShowDialog()
        Else
            MsgBox("Select what Exam Set will be opened.")
        End If
    End Sub

    Private Sub ListView3_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView3.MouseClick
        'lblExamName.Text = ListView1.SelectedItems(0).SubItems.Item(1).Text
        setId = ListView3.SelectedItems(0).Tag

    End Sub

    Private Sub mainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        cmd.Dispose()
        con.Close()
        con.Dispose()
    End Sub

    Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles ListView2.Click
        questionId = ListView2.SelectedItems(0).Tag
    End Sub

    Private Sub BunifuButton1_Click_2(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        If ListView2.SelectedItems().Count > 0 Then
            Dim q As String = ListView2.SelectedItems(0).SubItems.Item(1).Text
            Dim c As String = ListView2.SelectedItems(0).SubItems.Item(2).Text
            Dim w1 As String = ListView2.SelectedItems(0).SubItems.Item(3).Text
            Dim w2 As String = ListView2.SelectedItems(0).SubItems.Item(4).Text
            Dim w3 As String = ListView2.SelectedItems(0).SubItems.Item(5).Text

            Dim temp As AddQuestionsForm = New AddQuestionsForm(con, questionId, q, c, w1, w2, w3)
            temp.ShowDialog()
            temp.Dispose()
            refreshQuestions()
        Else
            MsgBox("Select what Question will be edited.")
        End If
    End Sub
End Class