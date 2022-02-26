Imports System.Data.SqlClient


Imports System.Security.Cryptography
Public Class seaLogin
    Dim MySqlConn As SqlConnection
    Dim Command As SqlCommand


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        MySqlConn = New SqlConnection

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"
        Dim Reader As SqlDataReader


        Try
            MySqlConn.Open()






            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try



    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"



        Try
            MySqlConn.Open()

            Dim query As String
            '   query = "select * from dbtest.Student where StudentUsername='" & txtSun.Text & "' and StudentPassword='" & txtSpass.Text & "'"
            Command = New SqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader

            Dim count As Integer

            count = 0

            While Reader.Read

                count = count + 1

            End While

            If count = 1 Then

                MessageBox.Show("Username and Password are correct")
                Me.Hide()

                seaStudent_Page.Show()

            ElseIf count > 1 Then

                MessageBox.Show("Username and Password are duplicate")

            Else
                MessageBox.Show("Username and Password are not correct")

            End If

            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try

        ' txtSun.Clear()
        ' txtSpass.Clear()



    End Sub







    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub grpLecturer_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub btnClear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MySqlConn = New SqlConnection
        Dim Reader As SqlDataReader
        Dim query As String

        MySqlConn.ConnectionString = "Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True"



        Try
            MySqlConn.Open()
            Select Case Convert.ToString(ComboBox2.SelectedItem)

                Case "Administrator"
                    query = "select * from Administrator where idAdministrator='" & TextBox1.Text & "' and AdministratorPassword='" & TextBox2.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    Reader.Read()

                    Dim b As String

                    b = Reader("AdministratorUsername")
                    MessageBox.Show("Welcome " & b)
                    Me.Hide()
                    Administrator_Page.Show()
                    Administrator_Page.Label2.Text = b


                Case "Lecturer"

                    query = "select * from lecturer where idLecturer='" & TextBox1.Text & "' and LecturerPassword='" & TextBox2.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    Reader.Read()

                    Dim b, c As String

                    b = Reader("LecturerUsername")
                    c = Reader("idCourse")
                    MessageBox.Show("Welcome " & b)
                    Me.Hide()
                    Lecturer_Page.Show()
                    Lecturer_Page.Label1.Text = b
                    SetQuestions.Label2.Text = c
                    Section_A.Label1.Text = c

                Case "Student"

                    query = "select * from Student where idStudent='" & TextBox1.Text & "' and StudentPassword='" & TextBox2.Text & "'"
                    Command = New SqlCommand(query, MySqlConn)
                    Reader = Command.ExecuteReader
                    Reader.Read()


                    Dim b, c, d As String


                    b = Reader("StudentName")
                    c = Reader("idStudent")
                    d = Reader("StudentCourseID")

                    Me.Hide()
                    seaStudent_Page.Show()
                    seaStudent_Page.Label5.Text = b
                    seaStudent_Page.Label6.Text = c
                    seaStudent_Page.Label7.Text = d
                    JavaExams.Label2.Text = b
                    JavaExams.id.Text = c

                    vb_exams.Label2.Text = b
                    vb_exams.id.Text = c

                    cplusexam.Label2.Text = b
                    cplusexam.id.Text = c

                    adjavaexams.Label2.Text = b
                    adjavaexams.id.Text = c

                    HtmlQuestion.Label2.Text = b
                    HtmlQuestion.id.Text = c

                    advbexams.Label2.Text = b
                    advbexams.id.Text = c

                    Java_Objectives.Label3.Text = b
                    Java_Objectives.it.Text = c

                    advbobj.Label3.Text = b
                    advbobj.it.Text = c

                    Htmlobj.Label3.Text = b
                    Htmlobj.it.Text = c

                    Cplusobj.Label3.Text = b
                    Cplusobj.it.Text = c

                    vbobj.Label3.Text = b
                    vbobj.it.Text = c

                    adjavaobj.Label3.Text = b
                    adjavaobj.it.Text = c


                Case Else


                    MsgBox("Username and Password are incorrect")


            End Select

            MySqlConn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally


            MySqlConn.Dispose()


        End Try

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        TextBox1.ResetText()
        TextBox2.ResetText()

    End Sub

    Private Sub TextBox1_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox1.OnValueChanged

    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub TextBox2_OnValueChanged(sender As Object, e As EventArgs) Handles TextBox2.OnValueChanged

    End Sub
End Class
