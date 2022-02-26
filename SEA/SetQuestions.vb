Imports System.Data.SqlClient


Public Class SetQuestions


    Dim MySqlConn As SqlConnection
    Dim Command As SqlCommand
    Dim dbDataset As New DataTable
    Private Sub SetQuestions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Hide()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader
        Dim query As String
        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"



        Try
            MySqlConn.Open()
            Select Case Convert.ToString(ComboBox1.SelectedItem)

                Case "C++"
                    query = "insert into Cplus (QuestionNumber, Question, Timer) values ('" & txtNumber.Text & "','" & txtquestion.Text & "', '" & txttime.Text & "') "
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case "Java"
                    query = "insert into Java (QuestionNumber, Question, Timer) values ('" & txtNumber.Text & "','" & txtquestion.Text & "',  '" & txttime.Text & "') "
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case "Visual Basic"
                    query = "insert into vb (QuestionNumber, Question, Timer) values ('" & txtNumber.Text & "','" & txtquestion.Text & "',  '" & txttime.Text & "') "
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case "Advanced Java"
                    query = "insert into Advancedjava (QuestionNumber, Question, Timer) values ('" & txtNumber.Text & "','" & txtquestion.Text & "',  '" & txttime.Text & "') "
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case "Advanced Visual Basic"
                    query = "insert into Advancedvb (QuestionNumber, Question, Timer) values ('" & txtNumber.Text & "','" & txtquestion.Text & "', '" & txttime.Text & "') "
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case Else
                    query = "insert into HTML (QuestionNumber, Question, Timer) values ('" & txtNumber.Text & "','" & txtquestion.Text & "', '" & txttime.Text & "') "
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")
            End Select


            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try

        txtquestion.Clear()
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click

        MySqlConn = New SqlConnection

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"
        Dim Reader As SqlDataReader

        Dim query As String
        Try
            MySqlConn.Open()

            Select Case Convert.ToString(ComboBox1.SelectedItem)

                Case "C++"
                    query = "Delete from Cplus where QuestionNumber= ' " & txtNumber.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Deleted")

                Case "Java"
                    query = "Delete from Java where QuestionNumber= ' " & txtNumber.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Deleted")

                Case "Visual Basic"
                    query = "Delete from vb where QuestionNumber= ' " & txtNumber.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Deleted")

                Case "Advanced Java"
                    query = "Delete from Advancedjava where QuestionNumber= ' " & txtNumber.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Deleted")

                Case "Advanced Visual Basic"
                    query = "Delete from Advancedvb where QuestionNumber= ' " & txtNumber.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Deleted")

                Case "HTML"
                    query = "Delete from HTML where QuestionNumber= ' " & txtNumber.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Deleted")

            End Select


            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try

    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles btnclear.Click

        txtquestion.Clear()

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        txtNumber.ResetText()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) 
        Dim dialogresult1 As DialogResult
        dialogresult1 = MessageBox.Show("Are you sure you want to Logout", "LOGOUT", MessageBoxButtons.OKCancel)
        If dialogresult1.OK Then
            Me.Hide()
            seaLogin.Show()


        End If

    End Sub

    Private Sub BunifuThinButton21_Click_2(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader
        Dim query As String
        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"



        Try
            MySqlConn.Open()
            Select Case Convert.ToString(ComboBox1.SelectedItem)



                Case "C++"
                    query = "Update Cplus set QuestionNumber= '" & txtNumber.Text & "', Question= '" & txtquestion.Text & "', Timer= '" & txttime.Text & "' where QuestionNumber= '" & txtNumber.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case "Java"
                    query = "Update java set QuestionNumber= '" & txtNumber.Text & "', Question= '" & txtquestion.Text & "', Timer= '" & txttime.Text & "' where QuestionNumber= '" & txtNumber.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case "Visual Basic"
                    query = "Update vb set QuestionNumber= '" & txtNumber.Text & "', Question= '" & txtquestion.Text & "', Timer= '" & txttime.Text & "' where QuestionNumber= '" & txtNumber.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case "Advanced Java"
                    query = "Update AdvancedJava set QuestionNumber= '" & txtNumber.Text & "', Question= '" & txtquestion.Text & "', Timer= '" & txttime.Text & "' where QuestionNumber= '" & txtNumber.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case "Advanced Visual Basic"
                    query = "Update Advancedvb set QuestionNumber= '" & txtNumber.Text & "', Question= '" & txtquestion.Text & "', Timer= '" & txttime.Text & "' where QuestionNumber= '" & txtNumber.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case Else
                    query = "Update HTML set QuestionNumber= '" & txtNumber.Text & "', Question= '" & txtquestion.Text & "', Timer= '" & txttime.Text & "' where QuestionNumber= '" & txtNumber.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")
            End Select


            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try

        txtquestion.Clear()

    End Sub
End Class