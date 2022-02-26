Public Class seaStudent_Page


    Private Sub JnjToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCplus_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub seaStudent_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label7.Hide()


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub btnJava_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim dialogresult1 As DialogResult
        dialogresult1 = MessageBox.Show("Are you sure you want to Logout", "LOGOUT", MessageBoxButtons.OKCancel)
        If dialogresult1.OK Then
            Me.Hide()
            seaLogin.Show()



        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click

    End Sub

    Private Sub btnCplus_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click


        If Label7.Text = "IT543" Then
            Dim dialogresult As DialogResult
            dialogresult = MessageBox.Show("Start Section A?", "Choose", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            Select Case dialogresult

                Case Windows.Forms.DialogResult.Yes
                    Me.Hide()
                    adjavaobj.Show()
                Case Else
                    Me.Hide()
                    adjavaexams.Show()

            End Select


        Else
            MessageBox.Show("You have not been registered for this course, Please select the correct course")


        End If

    End Sub

    Private Sub btnJava_Click_1(sender As Object, e As EventArgs) Handles btnJava.Click


        If Label7.Text = "IT232" Then

            Dim dialogresult As DialogResult
            dialogresult = MessageBox.Show("Start Section A?", "Choose", MessageBoxButtons.YesNo, MessageBoxIcon.Question)



            Select Case dialogresult



                Case Windows.Forms.DialogResult.Yes
                    Me.Hide()
                    Java_Objectives.Show()
                Case Else
                    Me.Hide()
                    JavaExams.Show()



            End Select

        Else
            MessageBox.Show("You have not been registered for this course, Please select the correct course")


        End If
    End Sub

    Private Sub btnCplus_Click_2(sender As Object, e As EventArgs) Handles btnCplus.Click

        If Label7.Text = "IT321" Then

            Dim dialogresult As DialogResult
            dialogresult = MessageBox.Show("Start Section A?", "Choose", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            Select Case dialogresult

                Case Windows.Forms.DialogResult.Yes
                    Me.Hide()
                    Cplusobj.Show()
                Case Else
                    Me.Hide()
                    cplusexam.Show()
            End Select

        Else
            MessageBox.Show("You have not been registered for this course, Please select the correct course")


        End If

    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click

        If Label7.Text = "IT124" Then

            Dim dialogresult As DialogResult
            dialogresult = MessageBox.Show("Start Section A?", "Choose", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            Select Case dialogresult

                Case Windows.Forms.DialogResult.Yes
                    Me.Hide()
                    vbobj.Show()
                Case Else
                    Me.Hide()
                    vb_exams.Show()
            End Select

        Else
            MessageBox.Show("You have not been registered for this course, Please select the correct course")


        End If

    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click

        If Label7.Text = "IT241" Then

            Dim dialogresult As DialogResult
            dialogresult = MessageBox.Show("Start Section A?", "Choose", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            Select Case dialogresult

                Case Windows.Forms.DialogResult.Yes
                    Me.Hide()
                    Htmlobj.Show()
                Case Else
                    Me.Hide()
                    HtmlQuestion.Show()


            End Select

        Else

            MessageBox.Show("You have not been registered for this course, Please select the correct course")

        End If

    End Sub

    Private Sub BunifuImageButton8_Click(sender As Object, e As EventArgs) Handles BunifuImageButton8.Click

        If Label7.Text = "IT237" Then

            Dim dialogresult As DialogResult
            dialogresult = MessageBox.Show("Start Section A?", "Choose", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            Select Case dialogresult

                Case Windows.Forms.DialogResult.Yes
                    Me.Hide()
                    advbobj.Show()
                Case Else
                    Me.Hide()
                    advbexams.Show()


            End Select

        Else

            MessageBox.Show("You have not been registered for this course, Please select the correct course")

        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub
End Class