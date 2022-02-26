

Public Class Administrator_Page




    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()

    End Sub

    Dim dialogresult1 As DialogResult

    Private Sub Administrator_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized


    End Sub





    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        switchPanel(Lecturer)
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        switchPanel(Student_Form)
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        switchPanel(View_Objs)
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        switchPanel(Questions)
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        dialogresult1 = MessageBox.Show("Are you sure you want to Logout", "LOGOUT", MessageBoxButtons.OKCancel)
        If dialogresult1.OK Then
            Me.Hide()
            seaLogin.Show()


        Else
            MessageBox.Show("Don't Close")

        End If

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click

        Me.WindowState = FormWindowState.Minimized


    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click

        Me.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub Administrator_Page_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class