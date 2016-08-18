Imports System.IO

Public Class Form1

    Dim a As StreamReader
    Dim b As String
    Dim c As String = "C:\temp\test1.txt"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not File.Exists(c) Then
            Dim d As FileStream
            d = File.Create(c)
            d.Close()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = Nothing Then
            MsgBox("Enter Password")
        Else
            File.AppendAllText(c, TextBox1.Text & vbCrLf)
            TextBox1.Text = ""
            MsgBox("Password Saved!", MsgBoxStyle.Information, "Saved")

        End If

    End Sub
End Class
