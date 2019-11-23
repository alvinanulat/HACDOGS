﻿Imports System.Data.SQLite
Imports Word = Microsoft.Office.Interop.Word
Public Class SetForm
    Dim con As SQLiteConnection
    Dim setId As String
    Dim examId As String
    Dim subjectId As String

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Dim sem As String = ""
    Dim acadyear As String = ""
    Dim exam As String = ""
    Dim section As String = ""
    Dim subject As String = ""

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(con As SQLiteConnection, setId As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.con = con
        Me.setId = setId
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, lblSetAlias.MouseDown
        drag = True
        'Me.WindowState = FormWindowState.Normal
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, lblSetAlias.MouseMove
        If drag Then

            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
            Me.WindowState = FormWindowState.Normal
            'A = 0
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp, lblSetAlias.MouseUp
        drag = False
    End Sub


    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Me.Close()
    End Sub

    Private Sub AnswerKey_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim cmdString As String = "select questions, answers, set_alias, exam_id from tbl_sets where set_id='" & setId & "';"
        Dim cmd As SQLiteCommand = New SQLiteCommand(cmdString, con)
        Dim dr As SQLiteDataReader
        dr = cmd.ExecuteReader()
        Dim answers As String = ""
        Dim questions As String = ""
        While dr.Read()
            questions = dr.GetString(0)
            'MessageBox.Show(questions)
            answers = dr.GetString(1)
            'MessageBox.Show(answers)
            lblSetAlias.Text = dr.GetString(2)
            examId = dr.GetInt16(3)
        End While
        dr.Close()
        Dim answersList As String() = answers.Split(New Char() {","c})
        Dim questionsList As String() = questions.Split(New Char() {","c})

        Dim i As Integer = 0
        Dim lvi As ListViewItem
        Dim map As String() = {"a", "b", "c", "d"}
        For Each temp As String In questionsList
            lvi = New ListViewItem()
            lvi.Text = i + 1

            cmdString = "select * from tbl_questions where question_id=" & temp & ";"
            cmd.CommandText = cmdString
            dr = cmd.ExecuteReader()
            While dr.Read
                'lvi.SubItems.Add(cmd.ExecuteScalar().ToString())
                lvi.SubItems.Add(dr.GetString(2))
                lvi.SubItems.Add(map(answersList(i) - 1))
                lvi.SubItems.Add(dr.GetString(4))
                lvi.SubItems.Add(dr.GetString(5))
                lvi.SubItems.Add(dr.GetString(6))
                lvi.SubItems.Add(dr.GetString(7))
            End While
            dr.Close()
            ListView1.Items.Add(lvi)
            i += 1
        Next
        'MessageBox.Show(answersList.Count)

        AutoResizeColumns(ListView1)


        cmdString = "select exam_name,academic_year,semester,subject_id from tbl_exams where exam_id = '" & examId & "';"
        MsgBox(cmdString)
        cmd.CommandText = cmdString
        dr = cmd.ExecuteReader()
        'Dim answers As String = ""
        While dr.Read()
            exam = dr.GetString(0)
            acadyear = dr.GetString(1)
            sem = dr.GetString(2)
            ' MessageBox.Show(sem)
            subjectId = dr.GetInt16(3)
        End While
        dr.Close()

        cmdString = "select subject_name from tbl_subjects where subject_id='" & subjectId & "';"
        MsgBox(cmdString)
        cmd.CommandText = cmdString
        dr = cmd.ExecuteReader()
        Dim subject As String = ""
        While dr.Read()
            subject = dr.GetString(0)
            ' MessageBox.Show(sem)
        End While
        dr.Close()

        lblSubject.Text = subject
        lblExam.Text = exam
        lblAcadYear.Text = acadyear
        lblSem.Text = sem

    End Sub


    Private Sub AutoResizeColumns(lv As ListView)
        lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        Dim cc As ListView.ColumnHeaderCollection = lv.Columns
        For i As Integer = 0 To cc.Count - 1

            Dim colWidth As Integer = TextRenderer.MeasureText(cc(i).Text, lv.Font).Width + 10
            If colWidth > cc(i).Width Then

                cc(i).Width = colWidth
            End If
        Next
    End Sub

    Private Sub btnWord_Click(sender As Object, e As EventArgs) Handles btnWord.Click
        Dim objWordApp As New Word.Application
        objWordApp.Visible = True

        'Open an existing document.  
        Dim objDoc As Word.Document = objWordApp.Documents.Open(Environment.CurrentDirectory & "/db/examtemp.docx")
        objDoc = objWordApp.ActiveDocument

        'Find and replace some text  
        'Replace 'VB' with 'Visual Basic'  
        objDoc.Content.Find.Execute(FindText:="$sem$", ReplaceWith:=sem, Replace:=Word.WdReplace.wdReplaceAll)
        objDoc.Content.Find.Execute(FindText:="$acadyear$", ReplaceWith:=acadyear, Replace:=Word.WdReplace.wdReplaceAll)
        objDoc.Content.Find.Execute(FindText:="$exam$", ReplaceWith:=exam, Replace:=Word.WdReplace.wdReplaceAll)
        objDoc.Content.Find.Execute(FindText:="$subject$", ReplaceWith:=subject, Replace:=Word.WdReplace.wdReplaceAll)
        'objDoc.Content.Find.Execute(FindText:="$sem$", ReplaceWith:=sem, Replace:=Word.WdReplace.wdReplaceAll)
        While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
            objDoc.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        End While

        'Save And Close() the document  
        'objDoc.Save()
        'objDoc.Close()
        'objDoc = Nothing
        'objWordApp.Quit()
        'objWordApp = Nothing
    End Sub
End Class