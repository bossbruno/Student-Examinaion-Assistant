Imports System.Data.SqlClient


Public Class View_Objs


    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-JP78HRE\SQLEXPRESS;Initial Catalog=dbtest;Integrated Security=True")
    Dim ds As DataSet = New DataSet


    Dim cmd As SqlCommand = New SqlCommand()
    Dim dv As DataView
    Dim cm As CurrencyManager
    Dim datareader As SqlDataReader

    Private Sub View_Objs_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click

        Select Case Convert.ToString(ComboBox1.SelectedItem)

            Case "C++"

                Dim dataadapt As New SqlDataAdapter("select * from cplusobj", con)

            Case "HTML"

                Dim dataadapt As New SqlDataAdapter("select * from htmlobj", con)

            Case "Visual Basic"

                Dim dataadapt As New SqlDataAdapter("select * from vbobj", con)

            Case "Advanced Java"

                Dim dataadapt As New SqlDataAdapter("select * from adjavaobj", con)

            Case "Advanced Visual Basic"

                Dim dataadapt As New SqlDataAdapter("select * from advbobj", con)

            Case Else
                Dim dataadapt As New SqlDataAdapter("select * from javaobjectives", con)


        End Select


        afilldatasetview()
        sbindfields()
        showposition()
    End Sub

    Public Sub afilldatasetview()

        ds = New DataSet
        Select Case Convert.ToString(ComboBox1.SelectedItem)

            Case "C++"
                Dim dataadapt As New SqlDataAdapter("select * from cplusobj", con)
                dataadapt.Fill(ds, "cplusobj")

            Case "Visual Basic"
                Dim dataadapt As New SqlDataAdapter("select * from vbobj", con)
                dataadapt.Fill(ds, "vbobj")

            Case "HTML"
                Dim dataadapt As New SqlDataAdapter("select * from htmlobj", con)
                dataadapt.Fill(ds, "htmlobj")

            Case "Advanced Visual Basic"
                Dim dataadapt As New SqlDataAdapter("select * from advbobj", con)
                dataadapt.Fill(ds, "advbobj")

            Case "Advanced Java"
                Dim dataadapt As New SqlDataAdapter("select * from adjavaobj", con)
                dataadapt.Fill(ds, "adjavaobj")

            Case Else
                Dim dataadapt As New SqlDataAdapter("select * from javaobjectives", con)
                dataadapt.Fill(ds, "javaobjectives")

        End Select

        Select Case Convert.ToString(ComboBox1.SelectedItem)

            Case "C++"

                dv = New DataView(ds.Tables("cplusobj"))

            Case "Visual Basic"

                dv = New DataView(ds.Tables("vbobj"))

            Case "HTML"

                dv = New DataView(ds.Tables("htmlobj"))

            Case "Advanced Visual Basic"

                dv = New DataView(ds.Tables("advbobj"))

            Case "Advanced Java"

                dv = New DataView(ds.Tables("adjavaobj"))
            Case Else

                dv = New DataView(ds.Tables("javaobjectives"))

        End Select
        cm = CType(Me.BindingContext(dv), CurrencyManager)

    End Sub

    Public Sub sbindfields()


        lblQuest.DataBindings.Clear()
        lblQnu.DataBindings.Clear()
        rbnA.DataBindings.Clear()
        rbnB.DataBindings.Clear()
        rbnC.DataBindings.Clear()
        rbnD.DataBindings.Clear()
        txtans.DataBindings.Clear()

        lblQnu.DataBindings.Add("text", dv, "Qnumber")
        lblQuest.DataBindings.Add("text", dv, "Question")
        rbnA.DataBindings.Add("text", dv, "A")
        rbnB.DataBindings.Add("text", dv, "B")
        rbnC.DataBindings.Add("text", dv, "C")
        rbnD.DataBindings.Add("text", dv, "D")
        txtans.DataBindings.Add("text", dv, "Answer")


    End Sub



    Public Sub showposition()


        Label4.Text = cm.Position + 1 & "  " & " of  " & "  " & cm.Count()



    End Sub


    Private Sub previouserecord_Click(sender As Object, e As EventArgs) Handles previouserecord.Click

        cm.Position = cm.Position - 1
        showposition()


    End Sub

    Private Sub nextrecord_Click(sender As Object, e As EventArgs) Handles nextrecord.Click

        cm.Position = cm.Position + 1
        showposition()


    End Sub

    Private Sub firstrecord_Click(sender As Object, e As EventArgs) Handles firstrecord.Click

        cm.Position = 0
        showposition()


    End Sub

    Private Sub lastrecord_Click(sender As Object, e As EventArgs) Handles lastrecord.Click

        cm.Position = cm.Count - 1
        showposition()


    End Sub
End Class