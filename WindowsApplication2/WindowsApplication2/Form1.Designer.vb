<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.TextSurname = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.GroupGender = New System.Windows.Forms.GroupBox()
        Me.RadioFemale = New System.Windows.Forms.RadioButton()
        Me.RadioMale = New System.Windows.Forms.RadioButton()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.ComboLocation = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelMem = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupGender.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextName
        '
        Me.TextName.Location = New System.Drawing.Point(261, 41)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(187, 20)
        Me.TextName.TabIndex = 0
        '
        'TextSurname
        '
        Me.TextSurname.Location = New System.Drawing.Point(261, 90)
        Me.TextSurname.Name = "TextSurname"
        Me.TextSurname.Size = New System.Drawing.Size(187, 20)
        Me.TextSurname.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(604, 128)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(212, 24)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 11)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(323, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 11)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(667, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 11)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Birth Date"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Items.AddRange(New Object() {"Athlete 1", "Athlete 2", "Athlete 3", "Athlete 4", "Athlete 5"})
        Me.ListBox1.Location = New System.Drawing.Point(261, 192)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 88)
        Me.ListBox1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(258, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 11)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Choose Members"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(341, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelResult.Location = New System.Drawing.Point(601, 317)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(0, 18)
        Me.LabelResult.TabIndex = 12
        '
        'ButtonReset
        '
        Me.ButtonReset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReset.Location = New System.Drawing.Point(496, 378)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(75, 23)
        Me.ButtonReset.TabIndex = 8
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'GroupGender
        '
        Me.GroupGender.Controls.Add(Me.RadioFemale)
        Me.GroupGender.Controls.Add(Me.RadioMale)
        Me.GroupGender.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupGender.Location = New System.Drawing.Point(607, 25)
        Me.GroupGender.Name = "GroupGender"
        Me.GroupGender.Size = New System.Drawing.Size(133, 69)
        Me.GroupGender.TabIndex = 3
        Me.GroupGender.TabStop = False
        Me.GroupGender.Text = "Gender"
        '
        'RadioFemale
        '
        Me.RadioFemale.AutoSize = True
        Me.RadioFemale.Location = New System.Drawing.Point(7, 41)
        Me.RadioFemale.Name = "RadioFemale"
        Me.RadioFemale.Size = New System.Drawing.Size(65, 15)
        Me.RadioFemale.TabIndex = 1
        Me.RadioFemale.TabStop = True
        Me.RadioFemale.Text = "Female"
        Me.RadioFemale.UseVisualStyleBackColor = True
        '
        'RadioMale
        '
        Me.RadioMale.AutoSize = True
        Me.RadioMale.Location = New System.Drawing.Point(7, 20)
        Me.RadioMale.Name = "RadioMale"
        Me.RadioMale.Size = New System.Drawing.Size(51, 15)
        Me.RadioMale.TabIndex = 0
        Me.RadioMale.TabStop = True
        Me.RadioMale.Text = "Male"
        Me.RadioMale.UseVisualStyleBackColor = True
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGender.Location = New System.Drawing.Point(601, 274)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(0, 18)
        Me.LabelGender.TabIndex = 13
        '
        'ComboLocation
        '
        Me.ComboLocation.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboLocation.FormattingEnabled = True
        Me.ComboLocation.Items.AddRange(New Object() {"Gauteng", "Limpopo", "North West", "Mpumalanga", "Kwa-Zulu Natal", "Western Cape", "Eastern Cape", "Northern Cape"})
        Me.ComboLocation.Location = New System.Drawing.Point(604, 192)
        Me.ComboLocation.Name = "ComboLocation"
        Me.ComboLocation.Size = New System.Drawing.Size(212, 24)
        Me.ComboLocation.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(657, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 11)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Choose Location"
        '
        'LabelMem
        '
        Me.LabelMem.AutoSize = True
        Me.LabelMem.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMem.Location = New System.Drawing.Point(601, 303)
        Me.LabelMem.Name = "LabelMem"
        Me.LabelMem.Size = New System.Drawing.Size(0, 18)
        Me.LabelMem.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 43)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "THE CUBIC RACE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 43)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "22 August 2016"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 86)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "R200" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to Register"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 43)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "10KM Race"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 418)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelMem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboLocation)
        Me.Controls.Add(Me.LabelGender)
        Me.Controls.Add(Me.GroupGender)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextSurname)
        Me.Controls.Add(Me.TextName)
        Me.Name = "Form1"
        Me.Text = "CubicEvent App"
        Me.GroupGender.ResumeLayout(False)
        Me.GroupGender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextName As System.Windows.Forms.TextBox
    Friend WithEvents TextSurname As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabelResult As System.Windows.Forms.Label
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents GroupGender As System.Windows.Forms.GroupBox
    Friend WithEvents RadioFemale As System.Windows.Forms.RadioButton
    Friend WithEvents RadioMale As System.Windows.Forms.RadioButton
    Friend WithEvents LabelGender As System.Windows.Forms.Label
    Friend WithEvents ComboLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelMem As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
