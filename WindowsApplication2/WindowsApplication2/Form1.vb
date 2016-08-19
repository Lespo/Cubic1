Imports System.Text
Imports System.IO

Public Class Form1
    Dim Name As String
    Dim Last As String
    Dim Result As String
    Dim DatePicker As String
    Dim List As String
    Dim Male As String
    Dim Female As String
    Dim path As String = "c:\temp\MyTest.txt"
    Dim read As StreamReader
    Dim ComboBox As String

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextName.Text & TextSurname.Text & ListBox1.SelectedItem = Nothing Then
                MsgBox("Enter Name, Surname and choose an Athlete")
            Else
                File.AppendAllText(path, TextName.Text & vbNewLine & TextSurname.Text & vbNewLine & ListBox1.SelectedItem & vbNewLine & ComboLocation.Text & LabelMem.Text & vbNewLine & vbNewLine & Date.Now & vbNewLine)

                MsgBox("All Saved!", MsgBoxStyle.Information, "Saved")
                ReadFile()

            End If

            Name = (TextName.Text)
            Last = (TextSurname.Text)
            DatePicker = (DateTimePicker1.Text)
            List = (ListBox1.Text)
            ComboBox = (ComboLocation.Text)
            Result = Name & Last

            LabelResult.Text = (Result & vbNewLine & List & vbNewLine & DatePicker & vbNewLine & ComboLocation.Text & vbNewLine).ToString
            LabelMem.Text = Date.Now.ToString("yy") + DateTimePicker1.Value.ToString("yyyyMMdd") + CInt(Int((999 * Rnd()) + 0)).ToString + CInt(Int((10 * Rnd()) + 0)).ToString


        Catch
            MsgBox("Please Enter Correct Inputs")
        End Try

        If RadioFemale.Checked Then
            LabelGender.Text = "Female"
        ElseIf RadioMale.Checked Then
            LabelGender.Text = "Male"
        End If



    End Sub


    Private Sub ReadFile()
        read = File.OpenText(path)

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextName.Clear()
        TextSurname.Clear()
        LabelResult.Text = ""
        ListBox1.ClearSelected()
        LabelGender.Text = ""
        TextName.Focus()
        ComboLocation.Text = ""
        DateTimePicker1.Text = ""
        LabelMem.Text = ""
        RadioFemale.Checked = False
        RadioMale.Checked = False

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S Then

            File.AppendAllText(path, TextName.Text & vbNewLine & TextSurname.Text & vbNewLine & ListBox1.SelectedItem & vbNewLine)

            MsgBox("All Saved!", MsgBoxStyle.Information, "Saved")


        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(path) Then
            Dim d As FileStream
            d = File.Create(path)
            d.Close()

        End If

        KeyPreview = True

        Label7.Text = Date.Today.ToString("dd MMMM yyyy")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Date.Now.ToString()

    End Sub
End Class
