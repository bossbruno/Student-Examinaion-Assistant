Imports System.Data.SqlClient

Public Class Student_Form

    Dim MySqlConn As SqlConnection
    Dim Command As SqlCommand
    Dim dbDataset As New DataTable
    Private Sub Button2_Click(sender As Object, e As EventArgs)



    End Sub




    Sub looad()

        MySqlConn = New SqlConnection


        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"


        Dim sda As New SqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsrc As New BindingSource

        Try

            MySqlConn.Open()


            Dim query As String

            query = "select * from Student"

            Command = New SqlCommand(query, MySqlConn)
            sda.SelectCommand = Command
            sda.Fill(dbdataset)
            bsrc.DataSource = dbdataset
            DataGridView1.DataSource = bsrc
            sda.Update(dbdataset)


            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try




    End Sub

    Private Sub btnStupdate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnStSave_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnStuDel_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub seaLecturer_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        looad()

    End Sub

    Private Sub btnSetquestions_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            txtStid.Text = row.Cells("idStudent").Value.ToString

            txtStname.Text = row.Cells("StudentName").Value.ToString

            txtStun.Text = row.Cells("StudentUsername").Value.ToString

            txtStuPass.Text = row.Cells("StudentPassword").Value.ToString

            txtScore.Text = row.Cells("StudentScoreA").Value.ToString

            txtscoreb.Text = row.Cells("StudentScoreB").Value.ToString

            txtClass.Text = row.Cells("StudentClass").Value.ToString

            txtCID.Text = row.Cells("StudentCourseID").Value.ToString
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnStSave.Click

        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"



        Try
            MySqlConn.Open()

            Dim query As String
            query = "insert into Student (idStudent,StudentName,StudentPassword,StudentClass,StudentUsername,StudentScoreA,StudentScoreB,StudentCourseID) values ('" & txtStid.Text & "','" & txtStname.Text & "','" & txtStuPass.Text & "','" & txtClass.Text & "','" & txtStun.Text & "','" & txtScore.Text & "','" & txtscoreb.Text & "','" & txtCID.Text & "') "
            Command = New SqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Data Saved")



            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try

        txtClass.ResetText()
        txtScore.ResetText()
        txtscoreb.ResetText()
        txtStid.ResetText()
        txtStname.ResetText()
        txtStun.ResetText()
        txtStuPass.ResetText()
        txtCID.ResetText()



        looad()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnStupdate.Click

        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader

        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=dbtest"



        Try
            MySqlConn.Open()

            Dim query As String
            query = "update Student set idStudent='" & txtStid.Text & "',StudentName='" & txtStname.Text & "',StudentPassword='" & txtStuPass.Text & "',StudentClass='" & txtClass.Text & "',StudentScoreA='" & txtScore.Text & "',StudentScoreB='" & txtscoreb.Text & "',StudentUsername='" & txtStun.Text & "', StudentCourseID='" & txtCID.Text & "' where idStudent='" & txtStid.Text & "'"
            Command = New SqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Data Updated")



            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try


        txtClass.ResetText()
        txtScore.ResetText()
        txtStid.ResetText()
        txtStname.ResetText()
        txtStun.ResetText()
        txtStuPass.ResetText()
        txtCID.ResetText()
        txtscoreb.ResetText()



        looad()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnStuDel.Click
        MySqlConn = New SqlConnection

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"
        Dim Reader As SqlDataReader


        Try
            MySqlConn.Open()

            Dim query As String
            query = "Delete from Student where idStudent= '" & txtStid.Text & "'"

            Command = New SqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Data Deleted")



            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try


        txtClass.ResetText()
        txtScore.ResetText()
        txtscoreb.ResetText()
        txtStid.ResetText()
        txtStname.ResetText()
        txtStun.ResetText()
        txtStuPass.ResetText()
        txtCID.ResetText()





        looad()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        looad()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class