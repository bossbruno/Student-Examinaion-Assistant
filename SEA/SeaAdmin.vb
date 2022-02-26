Imports System.Data.SqlClient

Public Class Lecturer

    Dim MySqlConn As SqlConnection
    Dim Command As SqlCommand
    Dim dbDataset As New DataTable

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Admin_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lect()


        seaLogin.Hide()

    End Sub

    Private Sub ExitSystemToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Are you sure you want to exit the program")

        If MsgBoxResult.Ok Then

            Application.Exit()
        End If



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnLecturer_Click(sender As Object, e As EventArgs)




    End Sub
    Sub lect()

        MySqlConn = New SqlConnection


        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"


        Dim sda As New SqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsrc As New BindingSource

        Try

            MySqlConn.Open()


            Dim query As String

            query = "select * from Lecturer"

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
    Private Sub btnSave_Click(sender As Object, e As EventArgs)

        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"



        Try
            MySqlConn.Open()

            Dim query As String
            query = "insert into lecturer (idLecturer,LecturerUsername,LecturerPassword) values ('" & txtID.Text & "','" & txtName.Text & "','" & txtUn.Text & "') "
            Command = New SqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Data Saved")



            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)

        MySqlConn = New SqlConnection

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"
        Dim Reader As SqlDataReader


        Try
            MySqlConn.Open()

            Dim query As String
            query = "Delete from lecturer where idLecturer= ' " & txtID.Text & "'"

            Command = New SqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Data Deleted")



            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)

        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"


        Try
            MySqlConn.Open()

            Dim query As String
            query = "update lecturer set idLecturer='" & txtID.Text & "',LecturerUsername='" & txtName.Text & "',LecturerPassword='" & txtUn.Text & "' where idLecturer='" & txtID.Text & "'"
            Command = New SqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Data Updated")



            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs)

        MySqlConn = New SqlConnection


        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"


        Dim sdaa As New SqlDataAdapter
        Dim dbdatasets As New DataTable
        Dim bsrcc As New BindingSource

        Try

            MySqlConn.Open()


            Dim query As String

            query = "select * from Student"

            Command = New SqlCommand(query, MySqlConn)
            sdaa.SelectCommand = Command
            sdaa.Fill(dbdatasets)
            bsrcc.DataSource = dbdatasets
            DataGridView1.DataSource = bsrcc
            sdaa.Update(dbdatasets)


            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try



    End Sub



    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs)


    End Sub









    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)





    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)
        txtID.ResetText()
        txtName.ResetText()
        txtUn.ResetText()
        txtPass.ResetText()


        txtCid.ResetText()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"



        Try
            MySqlConn.Open()

            Dim query As String
            query = "insert into lecturer (idLecturer,LecturerName,LecturerUsername,LecturerPassword,idCourse) values ('" & txtID.Text & "','" & txtName.Text & "','" & txtUn.Text & "','" & txtPass.Text & "', '" & txtCid.Text & "') "
            Command = New SqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Data Saved")



            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try

        txtID.ResetText()
        txtName.ResetText()
        txtUn.ResetText()
        txtPass.ResetText()

        txtCid.ResetText()

        lect()

    End Sub


    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles btnDelete.Click


        MySqlConn = New SqlConnection

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"
        Dim Reader As SqlDataReader


        Try
            MySqlConn.Open()

            Dim query As String
            query = "Delete from lecturer where idLecturer= '" & txtID.Text & "'"

            Command = New SqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Data Deleted")



            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try

        txtID.ResetText()
        txtName.ResetText()
        txtUn.ResetText()
        txtPass.ResetText()


        txtCid.ResetText()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"



        Try
            MySqlConn.Open()

            Dim query As String
            query = "update lecturer set idLecturer='" & txtID.Text & "',LecturerName='" & txtName.Text & "',LecturerUsername='" & txtUn.Text & "',LecturerPassword='" & txtPass.Text & "', idCourse='" & txtCid.Text & "' where idLecturer='" & txtID.Text & "'"
            Command = New SqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Data Updated")



            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try

        txtID.ResetText()
        txtName.ResetText()
        txtUn.ResetText()
        txtPass.ResetText()


        txtCid.ResetText()


        lect()

    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            txtID.Text = row.Cells("idLecturer").Value.ToString
            txtName.Text = row.Cells("LecturerUsername").Value.ToString
            txtUn.Text = row.Cells("LecturerUserName").Value.ToString
            txtCid.Text = row.Cells("idCourse").Value.ToString
            txtPass.Text = row.Cells("LecturerPassword").Value.ToString


        End If
    End Sub

    Private Sub GrpLecturer_Enter(sender As Object, e As EventArgs) Handles GrpLecturer.Enter

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        txtID.ResetText()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        txtName.ResetText()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        txtUn.ResetText()
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        txtCid.ResetText()

    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        txtPass.ResetText()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



    End Sub
End Class