Imports System.Security.Cryptography
Imports System.IO
Imports MySql.Data.MySqlClient

Module connection


    Public usrnameFriend As String
    Public Conn As New MySqlConnection
    Public ConTemp As New MySqlConnection
    Public MsgSubject As String = String.Empty

    Sub ConTempOpen()
        ConTemp.ConnectionString = ("server= localhost;user id=root; password = ; database=dbtest")

        Try
            ConTemp.Open()
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & "Check your connection.", MsgBoxStyle.Critical, "Can not connect to the Database")
            Application.Exit()
        End Try
    End Sub

    Sub OpenConnection()
        Conn.ConnectionString = ("server= localhost;user id=root; password = ; database=dbtest")
        Try
            Conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & "Check your connection." & vbNewLine & "Application will close.", MsgBoxStyle.Critical, "Can not connect to the Database")
            Application.Exit()
        End Try

    End Sub

    Function MD5Encrypter(ByVal strPass As String) As String


        Dim Hasher As New MD5CryptoServiceProvider
        Dim PasswordBytes As Byte() = New Byte(strPass.Length + 3) {}
        Dim HashBytes As Byte()

        For i As Integer = 0 To strPass.Length - 1
            PasswordBytes(i) = CByte(Asc(strPass(i)))
        Next
        PasswordBytes(strPass.Length) = CByte(90)
        PasswordBytes(strPass.Length + 1) = CByte(85)
        PasswordBytes(strPass.Length + 2) = CByte(66)
        PasswordBytes(strPass.Length + 3) = CByte(73)

        HashBytes = Hasher.ComputeHash(PasswordBytes)



        Dim NewHashBytes As Byte() = New Byte(HashBytes.Length + 3) {}

        For j As Integer = 0 To HashBytes.Length - 1
            NewHashBytes(j) = HashBytes(j)
        Next

        NewHashBytes(HashBytes.Length) = CByte(90)
        NewHashBytes(HashBytes.Length + 1) = CByte(85)
        NewHashBytes(HashBytes.Length + 2) = CByte(66)
        NewHashBytes(HashBytes.Length + 3) = CByte(73)

        strPass = Convert.ToBase64String(NewHashBytes)
        Return strPass
    End Function




End Module
