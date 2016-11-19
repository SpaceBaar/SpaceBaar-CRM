<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Userame = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClarityTheme1 = New CRM.ClarityTheme()
        Me.btnregister = New CRM.iClarityButton()
        Me.btnexit = New CRM.iClarityButton()
        Me.btnlogin = New CRM.iClarityButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClarityTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(163, 104)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(151, 20)
        Me.txtusername.TabIndex = 1
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(163, 130)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(151, 20)
        Me.txtpassword.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(160, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "New User?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CRM.My.Resources.Resources.TechChums
        Me.PictureBox1.Location = New System.Drawing.Point(139, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Userame
        '
        Me.Userame.AutoSize = True
        Me.Userame.ForeColor = System.Drawing.Color.White
        Me.Userame.Location = New System.Drawing.Point(71, 111)
        Me.Userame.Name = "Userame"
        Me.Userame.Size = New System.Drawing.Size(55, 13)
        Me.Userame.TabIndex = 7
        Me.Userame.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(71, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'ClarityTheme1
        '
        Me.ClarityTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClarityTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ClarityTheme1.Colors = New CRM.Bloom(-1) {}
        Me.ClarityTheme1.Controls.Add(Me.btnregister)
        Me.ClarityTheme1.Controls.Add(Me.btnexit)
        Me.ClarityTheme1.Controls.Add(Me.btnlogin)
        Me.ClarityTheme1.Customization = ""
        Me.ClarityTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClarityTheme1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ClarityTheme1.Icon = Nothing
        Me.ClarityTheme1.Image = Nothing
        Me.ClarityTheme1.Location = New System.Drawing.Point(0, 0)
        Me.ClarityTheme1.Movable = False
        Me.ClarityTheme1.Name = "ClarityTheme1"
        Me.ClarityTheme1.NoRounding = False
        Me.ClarityTheme1.ShowIcon = False
        Me.ClarityTheme1.Sizable = False
        Me.ClarityTheme1.Size = New System.Drawing.Size(419, 247)
        Me.ClarityTheme1.SmartBounds = True
        Me.ClarityTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ClarityTheme1.TabIndex = 9
        Me.ClarityTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ClarityTheme1.Transparent = False
        '
        'btnregister
        '
        Me.btnregister.Location = New System.Drawing.Point(224, 196)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(90, 23)
        Me.btnregister.TabIndex = 11
        Me.btnregister.Text = "Register Now"
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(244, 156)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(70, 23)
        Me.btnexit.TabIndex = 10
        Me.btnexit.Text = "Exit"
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(163, 156)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 23)
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(419, 247)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Userame)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ClarityTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClarityTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Userame As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ClarityTheme1 As ClarityTheme
    Friend WithEvents btnlogin As iClarityButton
    Friend WithEvents btnexit As iClarityButton
    Friend WithEvents btnregister As iClarityButton
End Class
