Public Class Lecturer_Page
    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnSecA_Click(sender As Object, e As EventArgs)
        switchPanel(Section_A)
    End Sub

    Private Sub btnVSecA_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)


        Me.Close()


    End Sub

    Private Sub Lecturer_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)

        switchPanel(Student_Form)
    End Sub

    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs) Handles btnSecA.Click
        switchPanel(Section_A)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles btnVSecA.Click

        switchPanel(View_Objs)

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles btnQuesB.Click

        switchPanel(SetQuestions)

    End Sub

    Private Sub BunifuFlatButton2_Click_2(sender As Object, e As EventArgs) Handles btnQuesBview.Click

        switchPanel(Questions)

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim dialogresult1 As DialogResult
        dialogresult1 = MessageBox.Show("Are you sure you want to Logout", "LOGOUT", MessageBoxButtons.OKCancel)
        If dialogresult1.OK Then
            Me.Hide()
            seaLogin.Show()


        End If
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        switchPanel(View_Answers)

    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class