<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.butt_Close = New System.Windows.Forms.Button()
        Me.butt_Subscribe = New System.Windows.Forms.Button()
        Me.butt_Connect = New System.Windows.Forms.Button()
        Me.butt_TestMessage = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.butt_SelectFile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.butt_AddContacts = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(358, 28)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(112, 20)
        Me.txtUser.TabIndex = 1
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(358, 67)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(112, 20)
        Me.txtPW.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 9)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(337, 349)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'butt_Close
        '
        Me.butt_Close.Location = New System.Drawing.Point(369, 173)
        Me.butt_Close.Name = "butt_Close"
        Me.butt_Close.Size = New System.Drawing.Size(101, 21)
        Me.butt_Close.TabIndex = 6
        Me.butt_Close.Text = "Close Connection"
        Me.butt_Close.UseVisualStyleBackColor = True
        '
        'butt_Subscribe
        '
        Me.butt_Subscribe.Location = New System.Drawing.Point(369, 240)
        Me.butt_Subscribe.Name = "butt_Subscribe"
        Me.butt_Subscribe.Size = New System.Drawing.Size(101, 21)
        Me.butt_Subscribe.TabIndex = 8
        Me.butt_Subscribe.Text = "Manual Add"
        Me.butt_Subscribe.UseVisualStyleBackColor = True
        '
        'butt_Connect
        '
        Me.butt_Connect.Location = New System.Drawing.Point(369, 120)
        Me.butt_Connect.Name = "butt_Connect"
        Me.butt_Connect.Size = New System.Drawing.Size(101, 21)
        Me.butt_Connect.TabIndex = 4
        Me.butt_Connect.Text = "Connect"
        Me.butt_Connect.UseVisualStyleBackColor = True
        '
        'butt_TestMessage
        '
        Me.butt_TestMessage.Location = New System.Drawing.Point(369, 267)
        Me.butt_TestMessage.Name = "butt_TestMessage"
        Me.butt_TestMessage.Size = New System.Drawing.Size(101, 21)
        Me.butt_TestMessage.TabIndex = 7
        Me.butt_TestMessage.Text = "Send Chat Message"
        Me.butt_TestMessage.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.AddExtension = False
        Me.OpenFileDialog1.FileName = "Fluid_Offline.csv"
        Me.OpenFileDialog1.Filter = "CSV Files|*.csv"
        Me.OpenFileDialog1.Title = "Select the Fluid_Offline csv file..."
        '
        'butt_SelectFile
        '
        Me.butt_SelectFile.Location = New System.Drawing.Point(369, 93)
        Me.butt_SelectFile.Name = "butt_SelectFile"
        Me.butt_SelectFile.Size = New System.Drawing.Size(101, 21)
        Me.butt_SelectFile.TabIndex = 3
        Me.butt_SelectFile.Text = "Load CSV File"
        Me.butt_SelectFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(355, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(355, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(367, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Troubleshooting"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Auto_Add_Gchat_Contacts.My.Resources.Resources.FLUID_Logo_color_cropped_tight
        Me.PictureBox1.Location = New System.Drawing.Point(371, 299)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'butt_AddContacts
        '
        Me.butt_AddContacts.Location = New System.Drawing.Point(369, 146)
        Me.butt_AddContacts.Name = "butt_AddContacts"
        Me.butt_AddContacts.Size = New System.Drawing.Size(101, 21)
        Me.butt_AddContacts.TabIndex = 5
        Me.butt_AddContacts.Text = "Add Contacts"
        Me.butt_AddContacts.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(395, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 373)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.butt_AddContacts)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.butt_SelectFile)
        Me.Controls.Add(Me.butt_Connect)
        Me.Controls.Add(Me.butt_Subscribe)
        Me.Controls.Add(Me.butt_TestMessage)
        Me.Controls.Add(Me.butt_Close)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtUser)
        Me.Name = "frmMain"
        Me.Text = "Add Gchat Contacts"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPW As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents butt_Close As System.Windows.Forms.Button
    Friend WithEvents butt_Subscribe As System.Windows.Forms.Button
    Friend WithEvents butt_Connect As System.Windows.Forms.Button
    Friend WithEvents butt_TestMessage As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents butt_SelectFile As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents butt_AddContacts As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
