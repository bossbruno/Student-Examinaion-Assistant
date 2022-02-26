Imports System.Data.SqlClient

Public Class Questions


    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True")
    Dim ds As DataSet = New DataSet


    Dim cmd As SqlCommand = New SqlCommand()
    Dim dv As DataView
    Dim cm As CurrencyManager
    Dim datareader As SqlDataReader



    Private Sub Questions_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub



    Public Sub afilldatasetview()

        ds = New DataSet
        Select Case Convert.ToString(ComboBox1.SelectedItem)

            Case "C++"
                Dim dataadapt As New SqlDataAdapter("select * from Cplus", con)
                dataadapt.Fill(ds, "Cplus")

            Case "Visual Basic"
                Dim dataadapt As New SqlDataAdapter("select * from vb", con)
                dataadapt.Fill(ds, "vb")

            Case "HTML"
                Dim dataadapt As New SqlDataAdapter("select * from Html", con)
                dataadapt.Fill(ds, "Html")

            Case "Advanced Visual Basic"
                Dim dataadapt As New SqlDataAdapter("select * from Advancedvb", con)
                dataadapt.Fill(ds, "Advancedvb")

            Case "Advanced Java"
                Dim dataadapt As New SqlDataAdapter("select * from Advancedjava", con)
                dataadapt.Fill(ds, "Advancedjava")

            Case Else
                Dim dataadapt As New SqlDataAdapter("select * from Java", con)
                dataadapt.Fill(ds, "Java")

        End Select

        Select Case Convert.ToString(ComboBox1.SelectedItem)

            Case "C++"

                dv = New DataView(ds.Tables("Cplus"))

            Case "Visual Basic"

                dv = New DataView(ds.Tables("vb"))

            Case "HTML"

                dv = New DataView(ds.Tables("Html"))

            Case "Advanced Visual Basic"

                dv = New DataView(ds.Tables("Advancedvb"))

            Case "Advanced Java"

                dv = New DataView(ds.Tables("Advancedjava"))
            Case Else

                dv = New DataView(ds.Tables("Java"))

        End Select
        cm = CType(Me.BindingContext(dv), CurrencyManager)

    End Sub


    Public Sub sbindfields()


        Label2.DataBindings.Clear()
        Label3.DataBindings.Clear()

        Label2.DataBindings.Add("text", dv, "QuestionNumber")
        Label3.DataBindings.Add("text", dv, "Question")


    End Sub


    Public Sub showposition()


        Label4.Text = cm.Position + 1 & "  " & " of  " & "  " & cm.Count()



    End Sub


    Private Sub previouserecord_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub nextrecord_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub firstrecord_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub lastrecord_Click(sender As Object, e As EventArgs)



    End Sub



    Private Sub btnview_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles btnview.Click

        Select Case Convert.ToString(ComboBox1.SelectedItem)

            Case "C++"

                Dim dataadapt As New SqlDataAdapter("select * from Cplus", con)

            Case "Java"

                Dim dataadapt As New SqlDataAdapter("select * from Java", con)

            Case "Visual Basic"

                Dim dataadapt As New SqlDataAdapter("select * from vb", con)

            Case "Advanced Java"

                Dim dataadapt As New SqlDataAdapter("select * from Advancedjava", con)

            Case "Advanced Visual Basic"

                Dim dataadapt As New SqlDataAdapter("select * from Advancedvb", con)

            Case Else

                Dim dataadapt As New SqlDataAdapter("select * from HTML", con)

        End Select


        afilldatasetview()
        sbindfields()
        showposition()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles firstrecord.Click
        cm.Position = 0
        showposition()

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles nextrecord.Click

        cm.Position = cm.Position + 1
        showposition()

    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles previouserecord.Click

        cm.Position = cm.Position - 1
        showposition()

    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles lastrecord.Click
        cm.Position = cm.Count - 1
        showposition()

    End Sub
End Class