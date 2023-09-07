Imports System.Diagnostics.Metrics

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Initializing the Variables
        Dim Name As String
        Dim Surname As String
        Dim Year As Integer
        Dim Age As Integer
        Dim Tribe As String
        Dim Greeting As String
        Dim Gender As String

        Name = txtName.Text
        Surname = txtSurname.Text

        Year = txtYear.Text
        Age = 2023 - Year
        Tribe = txtTribe.Text.ToLower


        If Tribe = "White" Then
            Greeting = "Hello"

        ElseIf Tribe = "sepedi" Then
            Greeting = "Thobela"

        ElseIf Tribe = "zulu" Then
            Greeting = "Sanibonani"

        ElseIf Tribe = "venda" Then
            Greeting = "Ndaa"

        Else
            Greeting = "Greetings"

        End If


        Gender = txtGender.SelectedItem
        If Gender = "Male" Then
            Gender = "man"
        ElseIf Gender = "Female" Then
            Gender = "lady"

        Else
            Gender = "Non binary being"

        End If


        MsgBox(Greeting & " " & Name & " " & Surname & ", you are " & Age & " years old " & Gender & ", who speaks " & Tribe)

    End Sub
End Class
