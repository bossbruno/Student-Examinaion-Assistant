Imports System.Data.SqlClient

Public Class Section_A

    Dim MySqlConn As SqlConnection
    Dim Command As SqlCommand
    Dim dbDataset As New DataTable


    Private Sub btnSave_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub rbnA_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Section_A_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Hide()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)
        Dim dialogresult1 As DialogResult
        dialogresult1 = MessageBox.Show("Are you sure you want to Logout", "LOGOUT", MessageBoxButtons.OKCancel)
        If dialogresult1.OK Then
            Me.Hide()
            seaLogin.Show()


        End If
    End Sub

    Private Sub firstrecord_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader
        Dim query As String
        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"



        Try
            MySqlConn.Open()
            Select Case Convert.ToString(ComboBox1.SelectedItem)

                Case "C++"
                    query = "INSERT into cplusobj (Qnumber, Question,A,B,C,D,Answer,Timer) values ('" & txtNumb.Text & "','" & txtQuest.Text & "','" & txtA.Text & "','" & txtB.Text & "','" & txtC.Text & "','" & txtD.Text & "','" & txtans.Text & "', '" & txttime.Text & "') "
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case "Java"
                    query = "insert into javaobjectives (Qnumber, Question,A,B,C,D,Answer,Timer) values ('" & txtNumb.Text & "','" & txtQuest.Text & "','" & txtA.Text & "','" & txtB.Text & "','" & txtC.Text & "','" & txtD.Text & "','" & txtans.Text & "', '" & txttime.Text & "') "
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case "Visual Basic"
                    query = "insert into vbobj (Qnumber, Question,A,B,C,D,Answer,Timer) values ('" & txtNumb.Text & "','" & txtQuest.Text & "','" & txtA.Text & "','" & txtB.Text & "','" & txtC.Text & "','" & txtD.Text & "','" & txtans.Text & "', '" & txttime.Text & "') "
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case "Advanced Java"
                    query = "insert into adjavaobj (Qnumber, Question,A,B,C,D,Answer,Timer) values ('" & txtNumb.Text & "','" & txtQuest.Text & "','" & txtA.Text & "','" & txtB.Text & "','" & txtC.Text & "','" & txtD.Text & "','" & txtans.Text & "', '" & txttime.Text & "') "
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case "Advanced Visual Basic"
                    query = "insert into advbobj (Qnumber, Question,A,B,C,D,Answer,Timer) values ('" & txtNumb.Text & "','" & txtQuest.Text & "','" & txtA.Text & "','" & txtB.Text & "','" & txtC.Text & "','" & txtD.Text & "','" & txtans.Text & "', '" & txttime.Text & "') "
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Saved")

                Case Else
                    query = "insert into htmlobj (Qnumber, Question,A,B,C,D,Answer, Timer) values ('" & txtNumb.Text & "','" & txtQuest.Text & "','" & txtA.Text & "','" & txtB.Text & "','" & txtC.Text & "','" & txtD.Text & "','" & txtans.Text & "','" & txttime.Text & "') "
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

        txtQuest.Clear()



    End Sub

    Private Sub nextrecord_Click(sender As Object, e As EventArgs) Handles btndel.Click

        MySqlConn = New SqlConnection

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"
        Dim Reader As SqlDataReader

        Dim query As String
        Try
            MySqlConn.Open()

            Select Case Convert.ToString(ComboBox1.SelectedItem)

                Case "C++"
                    query = "Delete from cplusobj where Qnumber= ' " & txtNumb.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Deleted")

                Case "Java"
                    query = "Delete from javaobjectives where Qnumber= ' " & txtNumb.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Deleted")

                Case "Visual Basic"
                    query = "Delete from vbobj where Qnumber= ' " & txtNumb.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Deleted")

                Case "Advanced Java"
                    query = "Delete from adjavaobj where Qnumber= ' " & txtNumb.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Deleted")

                Case "Advanced Visual Basic"
                    query = "Delete from advbobj where Qnumber= ' " & txtNumb.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    MessageBox.Show("Data Deleted")

                Case "HTML"
                    query = "Delete from htmlobj where Qnumber= ' " & txtNumb.Text & "'"
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



    Private Sub c_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        txtA.ResetText()
    End Sub

    Private Sub BunifuImageButton8_Click(sender As Object, e As EventArgs) Handles BunifuImageButton8.Click
        txtB.ResetText()

    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        txtC.ResetText()
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        txtD.ResetText()

    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        txtans.ResetText()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        txtNumb.ResetText()
    End Sub
End Class