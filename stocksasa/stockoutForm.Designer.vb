﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockoutForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label6 = New Label()
        saveBtn = New Button()
        cancelBtn = New Button()
        Panel1 = New Panel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(54, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 41)
        Label1.TabIndex = 0
        Label1.Text = "STOCK OUT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 1
        Label2.Text = "Ammount: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 20)
        Label3.TabIndex = 2
        Label3.Text = " Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 86)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 3
        Label4.Text = "Product ID:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(24, 20)
        Label5.TabIndex = 4
        Label5.Text = "ID"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(110, 83)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(199, 27)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(110, 127)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(135, 27)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(73, 171)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(199, 27)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(54, 210)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(199, 27)
        TextBox4.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(256, 134)
        Label6.Name = "Label6"
        Label6.Size = New Size(33, 20)
        Label6.TabIndex = 9
        Label6.Text = ".ksh"
        ' 
        ' saveBtn
        ' 
        saveBtn.Location = New Point(22, 284)
        saveBtn.Name = "saveBtn"
        saveBtn.Size = New Size(94, 29)
        saveBtn.TabIndex = 10
        saveBtn.Text = "save"
        saveBtn.UseVisualStyleBackColor = True
        ' 
        ' cancelBtn
        ' 
        cancelBtn.Location = New Point(165, 282)
        cancelBtn.Name = "cancelBtn"
        cancelBtn.Size = New Size(80, 31)
        cancelBtn.TabIndex = 11
        cancelBtn.Text = "cancel"
        cancelBtn.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.Screenshot__14_
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point(471, 171)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 219)
        Panel1.TabIndex = 12
        ' 
        ' stockoutForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(cancelBtn)
        Controls.Add(saveBtn)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "stockoutForm"
        Text = "Stock out"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents saveBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents Panel1 As Panel
End Class
