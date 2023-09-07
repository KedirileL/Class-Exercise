<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtName = New TextBox()
        txtYear = New TextBox()
        txtSurname = New TextBox()
        txtTribe = New TextBox()
        txtGender = New ListBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(102, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(102, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 25)
        Label2.TabIndex = 0
        Label2.Text = "Surname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(102, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 25)
        Label3.TabIndex = 0
        Label3.Text = "Year of Birth"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(102, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 25)
        Label4.TabIndex = 0
        Label4.Text = "Tribe"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(102, 280)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 25)
        Label5.TabIndex = 0
        Label5.Text = "Gender"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(404, 16)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 1
        ' 
        ' txtYear
        ' 
        txtYear.Location = New Point(404, 141)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(150, 31)
        txtYear.TabIndex = 1
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(404, 74)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(150, 31)
        txtSurname.TabIndex = 1
        ' 
        ' txtTribe
        ' 
        txtTribe.Location = New Point(404, 209)
        txtTribe.Name = "txtTribe"
        txtTribe.Size = New Size(150, 31)
        txtTribe.TabIndex = 1
        ' 
        ' txtGender
        ' 
        txtGender.FormattingEnabled = True
        txtGender.ItemHeight = 25
        txtGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        txtGender.Location = New Point(404, 280)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(180, 79)
        txtGender.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Location = New Point(230, 402)
        Button1.Name = "Button1"
        Button1.Size = New Size(335, 61)
        Button1.TabIndex = 4
        Button1.Text = "Your Small Bio"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 494)
        Controls.Add(Button1)
        Controls.Add(txtGender)
        Controls.Add(txtSurname)
        Controls.Add(txtTribe)
        Controls.Add(txtYear)
        Controls.Add(txtName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtTribe As TextBox
    Friend WithEvents txtGender As ListBox
    Friend WithEvents Button1 As Button
End Class
