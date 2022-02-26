Imports MySql.Data.MySqlClient
Public Class vb_exams

    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim con As MySqlConnection = New MySqlConnection("server=localhost; userid= root; password=; database= dbtest;")
    Dim ds As DataSet = New DataSet
    Dim dataadapt As New MySqlDataAdapter("select * from dbtest.vb", con)
    Dim cmd As MySqlCommand = New MySqlCommand()
    Dim dv As DataView
    Dim cm As CurrencyManager
    Dim datareader As MySqlDataReader
    Dim TargetDT As DateTime
    Private Sub vb_exams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server= localhost; userid= root; password=; database= dbtest"
        Dim quer As String

        Try

            MySqlConn.Open()



            quer = "select Timer from dbtest.vb"

            cmd = New MySqlCommand(quer, MySqlConn)
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



        Catch ex As MySqlException

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
        dataadapt.Fill(ds, "vb")
        dv = New DataView(ds.Tables("vb"))
        cm = CType(Me.BindingContext(dv), CurrencyManager)

    End Sub


    Public Sub bindfieldss()

        lblQnu.DataBindings.Clear()
        lblQuest.DataBindings.Clear()

        lblQnu.DataBindings.Add("text", dv, "QuestionNumber")
        lblQuest.DataBindings.Add("text", dv, "Question")



    End Sub

    Public Sub showpositions()


        pos.Text = cm.Position + 1 & "  " & " of  " & "  " & cm.Count()



    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles previouserecord.Click
        cm.Position = cm.Position - 1
        showpositions()


    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles lastrecord.Click

        cm.Position = cm.Count - 1
        showpositions()


    End Sub

    Private Sub firstrecord_Click(sender As Object, e As EventArgs) Handles firstrecord.Click

        cm.Position = 0
        showpositions()
    End Sub

    Private Sub nextrecord_Click(sender As Object, e As EventArgs) Handles nextrecord.Click

        cm.Position = cm.Position + 1
        showpositions()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Me.Hide()
        vbobj.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click

        MySqlConn = New MySqlConnection
        Dim Reader As MySqlDataReader

        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=dbtest"



        Try
            MySqlConn.Open()

            Dim query As String
            query = "insert into dbtest.vbanswers (idStudent,Answer,Qno) values ('" & id.Text & "','" & TextBox1.Text & "', '" & lblQnu.Text & "' ) "
            Command = New MySqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader

            MessageBox.Show("Submitted")



            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try



    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        Me.Hide()
        vbobj.Show()


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

        MySqlConn = New MySqlConnection
        Dim Reader As MySqlDataReader

        MySqlConn.ConnectionString = "server=localhost; userid=root; password=; database=dbtest"



        Try
            MySqlConn.Open()

            Dim query As String
            query = "update dbtest.Student set StudentPassword='" & Label5.Text & "',  where idStudent='" & id.Text & "'"
            Command = New MySqlCommand(query, MySqlConn)
            Reader = Command.ExecuteReader





            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()


        End Try




    End Sub
End Class