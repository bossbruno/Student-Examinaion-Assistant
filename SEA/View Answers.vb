Imports System.Data.SqlClient

Public Class View_Answers
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True")
    Dim MySqlConn As SqlConnection
    Dim Command As SqlCommand
    Dim dbDataset As New DataTable
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            TextBox1.Text = row.Cells("Answer").Value.ToString
            Label2.Text = row.Cells("idStudent").Value.ToString

        End If


    End Sub




    Private Sub View_Answers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Select Case Convert.ToString(ComboBox2.SelectedItem)


            Case "C++"

                WebBrowser1.Navigate("https://www.tutorialspoint.com/compile_cpp_online.php")

            Case "Html"

                WebBrowser1.Navigate("https://www.tutorialspoint.com/online_html_editor.php")


            Case "Java"

                WebBrowser1.Navigate("https://www.tutorialspoint.com/compile_java_online.php")


            Case Else

                WebBrowser1.Navigate("https://www.jdoodle.com/compile-vb-dot-net-online/")

        End Select

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        MySqlConn = New SqlConnection


        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"


        Dim sda As New SqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsrc As New BindingSource

        Try

            MySqlConn.Open()


            Dim query As String
            Select Case Convert.ToString(ComboBox1.SelectedItem)
                Case "HTML"

                    query = "select * from htmlanswers"

                    Command = New SqlCommand(query, MySqlConn)
                    sda.SelectCommand = Command
                    sda.Fill(dbdataset)
                    bsrc.DataSource = dbdataset
                    DataGridView1.DataSource = bsrc
                    sda.Update(dbdataset)

                Case "C++"
                    query = "select * from cplusanswers"

                    Command = New SqlCommand(query, MySqlConn)
                    sda.SelectCommand = Command
                    sda.Fill(dbdataset)
                    bsrc.DataSource = dbdataset
                    DataGridView1.DataSource = bsrc
                    sda.Update(dbdataset)

                Case "Java"
                    query = "select * from javaanswers"

                    Command = New SqlCommand(query, MySqlConn)
                    sda.SelectCommand = Command
                    sda.Fill(dbdataset)
                    bsrc.DataSource = dbdataset
                    DataGridView1.DataSource = bsrc
                    sda.Update(dbdataset)

                Case "Advanced Java"

                    query = "select * from advancedjavaanswers"

                    Command = New SqlCommand(query, MySqlConn)
                    sda.SelectCommand = Command
                    sda.Fill(dbdataset)
                    bsrc.DataSource = dbdataset
                    DataGridView1.DataSource = bsrc
                    sda.Update(dbdataset)

                Case "Visual Basic"
                    query = "select * from vbanswers"

                    Command = New SqlCommand(query, MySqlConn)
                    sda.SelectCommand = Command
                    sda.Fill(dbdataset)
                    bsrc.DataSource = dbdataset
                    DataGridView1.DataSource = bsrc
                    sda.Update(dbdataset)

                Case Else
                    query = "select * from advbanswers"

                    Command = New SqlCommand(query, MySqlConn)
                    sda.SelectCommand = Command
                    sda.Fill(dbdataset)
                    bsrc.DataSource = dbdataset
                    DataGridView1.DataSource = bsrc
                    sda.Update(dbdataset)


            End Select

            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click


        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader
        Dim query As String
        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"



        Try
            MySqlConn.Open()

            query = "Update Student set StudentScoreB= '" & TextBox3.Text & "'  WHERE idStudent= '" & Label2.Text & "'"
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

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class