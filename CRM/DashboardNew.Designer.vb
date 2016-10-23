<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardNew
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
        Me.ClarityTheme1 = New CRM.ClarityTheme()
        Me.ClarityTabControl1 = New CRM.ClarityTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.IClarityButton1 = New CRM.iClarityButton()
        Me.IClarityCheckBox1 = New CRM.iClarityCheckBox()
        Me.ClarityListBox1 = New CRM.ClarityListBox()
        Me.ClarityGroupBox1 = New CRM.ClarityGroupBox()
        Me.ClarityTheme1.SuspendLayout()
        Me.ClarityTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClarityTheme1
        '
        Me.ClarityTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClarityTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ClarityTheme1.Colors = New CRM.Bloom(-1) {}
        Me.ClarityTheme1.Controls.Add(Me.ClarityGroupBox1)
        Me.ClarityTheme1.Controls.Add(Me.ClarityListBox1)
        Me.ClarityTheme1.Controls.Add(Me.IClarityCheckBox1)
        Me.ClarityTheme1.Controls.Add(Me.IClarityButton1)
        Me.ClarityTheme1.Controls.Add(Me.ClarityTabControl1)
        Me.ClarityTheme1.Customization = ""
        Me.ClarityTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClarityTheme1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ClarityTheme1.Icon = Nothing
        Me.ClarityTheme1.Image = Nothing
        Me.ClarityTheme1.Location = New System.Drawing.Point(0, 0)
        Me.ClarityTheme1.Movable = True
        Me.ClarityTheme1.Name = "ClarityTheme1"
        Me.ClarityTheme1.NoRounding = False
        Me.ClarityTheme1.ShowIcon = False
        Me.ClarityTheme1.Sizable = True
        Me.ClarityTheme1.Size = New System.Drawing.Size(606, 343)
        Me.ClarityTheme1.SmartBounds = True
        Me.ClarityTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.ClarityTheme1.TabIndex = 0
        Me.ClarityTheme1.Text = "s"
        Me.ClarityTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ClarityTheme1.Transparent = False
        '
        'ClarityTabControl1
        '
        Me.ClarityTabControl1.Controls.Add(Me.TabPage1)
        Me.ClarityTabControl1.Controls.Add(Me.TabPage2)
        Me.ClarityTabControl1.Location = New System.Drawing.Point(36, 54)
        Me.ClarityTabControl1.Name = "ClarityTabControl1"
        Me.ClarityTabControl1.SelectedIndex = 0
        Me.ClarityTabControl1.Size = New System.Drawing.Size(200, 100)
        Me.ClarityTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(192, 71)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(192, 71)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'IClarityButton1
        '
        Me.IClarityButton1.Location = New System.Drawing.Point(328, 136)
        Me.IClarityButton1.Name = "IClarityButton1"
        Me.IClarityButton1.Size = New System.Drawing.Size(154, 52)
        Me.IClarityButton1.TabIndex = 1
        Me.IClarityButton1.Text = "IClarityButton1"
        '
        'IClarityCheckBox1
        '
        Me.IClarityCheckBox1.Checked = False
        Me.IClarityCheckBox1.Customization = "/////wAAAP8oKCj/"
        Me.IClarityCheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.IClarityCheckBox1.Image = Nothing
        Me.IClarityCheckBox1.Location = New System.Drawing.Point(379, 274)
        Me.IClarityCheckBox1.Name = "IClarityCheckBox1"
        Me.IClarityCheckBox1.NoRounding = False
        Me.IClarityCheckBox1.Size = New System.Drawing.Size(124, 17)
        Me.IClarityCheckBox1.TabIndex = 2
        Me.IClarityCheckBox1.Text = "IClarityCheckBox1"
        Me.IClarityCheckBox1.Transparent = False
        '
        'ClarityListBox1
        '
        Me.ClarityListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClarityListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClarityListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ClarityListBox1.FormattingEnabled = True
        Me.ClarityListBox1.ItemHeight = 15
        Me.ClarityListBox1.Location = New System.Drawing.Point(238, 204)
        Me.ClarityListBox1.Name = "ClarityListBox1"
        Me.ClarityListBox1.Size = New System.Drawing.Size(120, 90)
        Me.ClarityListBox1.TabIndex = 3
        '
        'ClarityGroupBox1
        '
        Me.ClarityGroupBox1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ClarityGroupBox1.Colors = New CRM.Bloom(-1) {}
        Me.ClarityGroupBox1.Customization = ""
        Me.ClarityGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ClarityGroupBox1.Image = Nothing
        Me.ClarityGroupBox1.Location = New System.Drawing.Point(40, 204)
        Me.ClarityGroupBox1.Movable = True
        Me.ClarityGroupBox1.Name = "ClarityGroupBox1"
        Me.ClarityGroupBox1.NoRounding = False
        Me.ClarityGroupBox1.Sizable = True
        Me.ClarityGroupBox1.Size = New System.Drawing.Size(172, 105)
        Me.ClarityGroupBox1.SmartBounds = True
        Me.ClarityGroupBox1.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ClarityGroupBox1.TabIndex = 4
        Me.ClarityGroupBox1.Text = "ClarityGroupBox1"
        Me.ClarityGroupBox1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ClarityGroupBox1.Transparent = False
        '
        'DashboardNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 343)
        Me.Controls.Add(Me.ClarityTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardNew"
        Me.Text = "DashboardNew"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ClarityTheme1.ResumeLayout(False)
        Me.ClarityTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClarityTheme1 As ClarityTheme
    Friend WithEvents IClarityButton1 As iClarityButton
    Friend WithEvents ClarityTabControl1 As ClarityTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ClarityGroupBox1 As ClarityGroupBox
    Friend WithEvents ClarityListBox1 As ClarityListBox
    Friend WithEvents IClarityCheckBox1 As iClarityCheckBox
End Class
