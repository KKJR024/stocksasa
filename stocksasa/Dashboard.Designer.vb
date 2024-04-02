<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboardForm
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label1 = New Label()
        signOutBtn = New Button()
        Button1 = New Button()
        formsComboBox = New ComboBox()
        reportsComboBox = New ComboBox()
        settingsBtn = New Button()
        Panel3 = New Panel()
        lblsalelabel = New Label()
        lblcurrentsale = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(signOutBtn)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 34)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Controls.Add(settingsBtn)
        Panel2.Controls.Add(reportsComboBox)
        Panel2.Controls.Add(formsComboBox)
        Panel2.Location = New Point(-1, 29)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(157, 447)
        Panel2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 23)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' signOutBtn
        ' 
        signOutBtn.BackColor = SystemColors.AppWorkspace
        signOutBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        signOutBtn.Location = New Point(723, 5)
        signOutBtn.Name = "signOutBtn"
        signOutBtn.Size = New Size(74, 26)
        signOutBtn.TabIndex = 1
        signOutBtn.Text = "Sign out"
        signOutBtn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.AppWorkspace
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(612, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 27)
        Button1.TabIndex = 2
        Button1.Text = "Notifications"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' formsComboBox
        ' 
        formsComboBox.BackColor = Color.Silver
        formsComboBox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        formsComboBox.FormattingEnabled = True
        formsComboBox.Items.AddRange(New Object() {"INVENTORY", "SALES", "STOCK OUT", "EXPENSES"})
        formsComboBox.Location = New Point(3, 11)
        formsComboBox.Name = "formsComboBox"
        formsComboBox.Size = New Size(151, 28)
        formsComboBox.TabIndex = 0
        formsComboBox.Text = "Forms"
        ' 
        ' reportsComboBox
        ' 
        reportsComboBox.BackColor = Color.Silver
        reportsComboBox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        reportsComboBox.FormattingEnabled = True
        reportsComboBox.Items.AddRange(New Object() {"Financial Report"})
        reportsComboBox.Location = New Point(3, 45)
        reportsComboBox.Name = "reportsComboBox"
        reportsComboBox.Size = New Size(151, 28)
        reportsComboBox.TabIndex = 1
        reportsComboBox.Text = "Reports"
        ' 
        ' settingsBtn
        ' 
        settingsBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        settingsBtn.Location = New Point(35, 399)
        settingsBtn.Name = "settingsBtn"
        settingsBtn.Size = New Size(84, 34)
        settingsBtn.TabIndex = 2
        settingsBtn.Text = "Settings"
        settingsBtn.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = My.Resources.Resources.dashboard_background_
        Panel3.BackgroundImageLayout = ImageLayout.Stretch
        Panel3.Controls.Add(lblcurrentsale)
        Panel3.Controls.Add(lblsalelabel)
        Panel3.Location = New Point(152, 32)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(647, 444)
        Panel3.TabIndex = 2
        ' 
        ' lblsalelabel
        ' 
        lblsalelabel.AutoSize = True
        lblsalelabel.BackColor = Color.MediumSeaGreen
        lblsalelabel.Font = New Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblsalelabel.Location = New Point(62, 379)
        lblsalelabel.Name = "lblsalelabel"
        lblsalelabel.Size = New Size(86, 18)
        lblsalelabel.TabIndex = 0
        lblsalelabel.Text = "LIVE SALE"
        ' 
        ' lblcurrentsale
        ' 
        lblcurrentsale.AutoSize = True
        lblcurrentsale.BackColor = Color.Transparent
        lblcurrentsale.Location = New Point(62, 401)
        lblcurrentsale.Name = "lblcurrentsale"
        lblcurrentsale.Size = New Size(69, 20)
        lblcurrentsale.TabIndex = 1
        lblcurrentsale.Text = "KSH. O.O"
        ' 
        ' dashboardForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 474)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "dashboardForm"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents signOutBtn As Button
    Friend WithEvents formsComboBox As ComboBox
    Friend WithEvents settingsBtn As Button
    Friend WithEvents reportsComboBox As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblcurrentsale As Label
    Friend WithEvents lblsalelabel As Label

End Class
