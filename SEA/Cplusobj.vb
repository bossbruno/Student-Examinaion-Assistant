Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Cplusobj
    Dim answer As String
    Dim MySqlConn As SqlConnection
    Dim Command As SqlCommand
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True")
    Dim ds As DataSet = New DataSet
    Dim dataadapt As New SqlDataAdapter("select * from cplusobj", con)
    Dim cmd As SqlCommand = New SqlCommand()
    Dim dv As DataView
    Dim cm As CurrencyManager
    Dim datareader As SqlDataReader
    Dim score As Integer = 0
    Dim selected As String
    Dim finalanswer As Integer
    Dim no As Integer
    Dim q(no) As String
    Dim TargetDT As DateTime
    Private Sub Cplusobj_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        lblQnu.Hide()

        Label2.Hide()
        Label5.Hide()
        Label6.Hide()

        MySqlConn = New SqlConnection
        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"
        Dim quer As String

        Try

            MySqlConn.Open()



            quer = "select Timer from cplus"

            cmd = New SqlCommand(quer, MySqlConn)
            datareader = cmd.ExecuteReader

            If (datareader.HasRows) Then


                datareader.Read()

                Dim b As String
                b = datareader("Timer")


                Dim countdownfrom As TimeSpan = TimeSpan.FromMinutes(b)
                Timer1.Start()
                Timer1.Interval = 100
                TargetDT = DateTime.Now.Add(countdownfrom)






            Else

                MessageBox.Show("Nice")
            End If



        Catch ex As SqlException

            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
        MySqlConn.Close()

        wfilldatasetviews()
        bindfieldss()
        showpositions()
        question()
    End Sub


    Private Function RandomizeListOrder(answers As List(Of String)) As List(Of String)


        Dim answer2 As Integer
        Dim rnd As New Random

        For answer1 As Integer = 0 To answers.Count - 1

            answer2 = rnd.Next(0, answers.Count - 1)

            If answer1 = answer2 Then
                Continue For
            End If

            Dim temp As String
            temp = answers(answer1)
            answers(answer1) = answers(answer2)
            answers(answer2) = temp
        Next

        Return answers

    End Function

    Private Sub question()

        Try
            con.Open()
            ' Dim dt As DataTable
            ' For Each drs As DataRow In dt.Rows

            cmd.CommandText = "SELECT  Question, A, B, C, D, Answer FROM cplusobj"
            cmd.Connection = con

            datareader = cmd.ExecuteReader

            Dim answerList As New List(Of String)

            If datareader.HasRows Then
                datareader.Read()
                answerList.Add(datareader.Item("A"))
                answerList.Add(datareader.Item("B"))
                answerList.Add(datareader.Item("C"))
                answerList.Add(datareader.Item("D"))


                answerList = RandomizeListOrder(answerList)
                rbnA.Text = answerList(0)
                rbnB.Text = answerList(1)
                rbnC.Text = answerList(2)
                rbnD.Text = answerList(3)


                datareader.Close()
            End If

            con.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()



        End Try

    End Sub
    Private Sub mark()
        con.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"

        Try
            Do

                con.Open()
                cmd.CommandText = "SELECT  Answer FROM cplusobj WHERE Answer IS NOT NULL"
                cmd.Connection = con
                datareader = cmd.ExecuteReader
                If datareader.HasRows Then
                    datareader.Read()
                    answer = datareader.Item("Answer")
                End If



                If Label6.Text = rbnA.Text And rbnA.Checked Then
                    score = score + 1
                ElseIf Label6.Text = rbnB.Text And rbnB.Checked Then
                    score = score + 1
                ElseIf Label6.Text = rbnC.Text And rbnC.Checked Then
                    score = score + 1
                ElseIf Label6.Text = rbnD.Text And rbnD.Checked Then
                    score = score + 1
                End If
                Exit Do

            Loop Until cm.Position = cm.Count





            'If selected = answer Then score = score + 1
            'If selected <> answer Then score = +0
            datareader.Close()

            con.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            con.Dispose()



        End Try



    End Sub



    Public Sub wfilldatasetviews()

        ds = New DataSet
        dataadapt.Fill(ds, "cplusobj")
        dv = New DataView(ds.Tables("cplusobj"))
        cm = CType(Me.BindingContext(dv), CurrencyManager)

    End Sub


    Public Sub bindfieldss()

        ' Label1.DataBindings.Clear()
        ' lblQnu.DataBindings.Clear()
        'lblQuest.DataBindings.Clear()
        ' rbnA.DataBindings.Clear()
        ' rbnB.DataBindings.Clear()
        ' rbnC.DataBindings.Clear()
        ' rbnD.DataBindings.Clear()

        'lblQnu.DataBindings.Add("text", dv, "Qnumber")
        lblQuest.DataBindings.Add("text", dv, "Question")
        rbnA.DataBindings.Add("text", dv, "A")
        rbnB.DataBindings.Add("text", dv, "B")
        rbnC.DataBindings.Add("text", dv, "C")
        rbnD.DataBindings.Add("text", dv, "D")
        Label1.DataBindings.Add("text", dv, "Timer")
        Label6.DataBindings.Add("text", dv, "Answer")


    End Sub

    Public Sub showpositions()


        Label4.Text = cm.Position + 1 & "  " & " of  " & "  " & cm.Count()



    End Sub


    Private Sub previouserecord_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub nextrecord_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub firstrecord_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub lastrecord_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub lblQuest_Click(sender As Object, e As EventArgs) Handles lblQuest.Click

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim dialogresult1 As DialogResult
        dialogresult1 = MessageBox.Show("Are you sure you want to Logout", "LOGOUT", MessageBoxButtons.OKCancel)
        If dialogresult1.OK Then
            Me.Hide()
            seaLogin.Show()


        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles firstrecord.Click

        cm.Position = 0
        showpositions()

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles nextrecord.Click
        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"

        Try
            MySqlConn.Open()
            Dim query As String
            query = "UPDATE cplusobj set score = '" & score + 1 & "' WHERE score IS NOT NULL "
            cmd.Connection = MySqlConn
            cmd = New SqlCommand(query, MySqlConn)
            datareader = cmd.ExecuteReader
            datareader.Close()

            con.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try


        mark()

        Label5.Text = score
        cm.Position = cm.Position + 1
        If cm.Position = cm.Count - 1 Then
            MessageBox.Show("Press Finish when done", "Last Question")

        End If

        showpositions()

        rbnA.Checked = False
        rbnB.Checked = False
        rbnC.Checked = False
        rbnD.Checked = False

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles previouserecord.Click

        cm.Position = cm.Position - 1
        showpositions()

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles lastrecord.Click

        cm.Position = cm.Count - 1
        showpositions()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        Me.Hide()
        cplusexam.Show()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            Label1.Text = ts.ToString("hh\:mm\:ss")
        Else
            Label1.Text = "00:00:00"
            Timer1.Stop()
            MessageBox.Show("Done")
            Me.Hide()
            cplusexam.Show()
        End If
        If ts.TotalMinutes < 10 Then
            Label1.ForeColor = Color.Red
        End If

    End Sub

    Private Sub BunifuThinButton22_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click

        MsgBox("Your score is " & score)

        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"



        Try
            MySqlConn.Open()

            Dim query As String
            query = "update Student set StudentPassword='" & Label2.Text & "', StudentScoreA='" & Label5.Text & "' where idStudent='" & it.Text & "'"
            Command = New SqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader





            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try




    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class

