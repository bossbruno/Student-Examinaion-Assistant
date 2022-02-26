﻿Imports System.Data.SqlClient
Imports System.Security.Cryptography
Public Class JavaExams

    Dim MySqlConn As SqlConnection
    Dim Command As SqlCommand
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True")
    Dim ds As DataSet = New DataSet
    Dim dataadapt As New SqlDataAdapter("select * from java", con)
    Dim cmd As SqlCommand = New SqlCommand()
    Dim dv As DataView
    Dim cm As CurrencyManager
    Dim datareader As SqlDataReader
    Dim TargetDT As DateTime
    Private Sub JavaExams_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        Label5.Hide()


        MySqlConn = New SqlConnection
        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"
        Dim quer As String

        Try

            MySqlConn.Open()



            quer = "select Timer from java"

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


    End Sub

    Public Sub wfilldatasetviews()

        ds = New DataSet
        dataadapt.Fill(ds, "java")
        dv = New DataView(ds.Tables("java"))
        cm = CType(Me.BindingContext(dv), CurrencyManager)

    End Sub


    Public Sub bindfieldss()

        lblQnu.DataBindings.Clear()
        lblQuest.DataBindings.Clear()

        lblQnu.DataBindings.Add("text", dv, "QuestionNumber")
        lblQuest.DataBindings.Add("text", dv, "Question")



    End Sub

    Public Sub showpositions()


        Label4.Text = cm.Position + 1 & "  " & " of  " & "  " & cm.Count()



    End Sub


    Private Sub previouserecord_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub nextrecord_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub firstrecord_Click(sender As Object, e As EventArgs)

        cm.Position = 0
        showpositions()


    End Sub

    Private Sub lastrecord_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Dim dialogresult1 As DialogResult
        dialogresult1 = MessageBox.Show("Are you sure you want to Logout", "LOGOUT", MessageBoxButtons.OKCancel)
        If dialogresult1.OK Then
            Me.Hide()
            seaLogin.Show()


        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles firstrecord.Click

        cm.Position = cm.Count - 1
        showpositions()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles nextrecord.Click

        cm.Position = cm.Position + 1
        showpositions()
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

    Private Sub BunifuThinButton22_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click

        Me.Hide()
        Java_Objectives.Show()

    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click


        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"



        Try
            MySqlConn.Open()

            Dim query As String
            query = "insert into javaanswers (idStudent,Answer,Qno) values ('" & id.Text & "','" & TextBox1.Text & "', '" & lblQnu.Text & "' )"
            Command = New SqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Submitted")



            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            Label3.Text = ts.ToString("hh\:mm\:ss")
        Else
            Label3.Text = "00:00:00"
            Timer1.Stop()
            MessageBox.Show("Done")
            Me.Hide()
            seaLogin.Show()
        End If
        If ts.TotalMinutes < 10 Then
            Label3.ForeColor = Color.Red
        End If


    End Sub

    Private Sub BunifuThinButton23_Click_1(sender As Object, e As EventArgs)

        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"



        Try
            MySqlConn.Open()

            Dim query As String
            query = "update Student set StudentPassword='" & Label5.Text & "',  where idStudent='" & id.Text & "'"
            Command = New SqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader





            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try




    End Sub

    Private Sub BunifuGradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel2.Paint

    End Sub
End Class