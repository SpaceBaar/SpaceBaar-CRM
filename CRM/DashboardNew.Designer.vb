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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardNew))
        Me.ClarityTheme1 = New CRM.ClarityTheme()
        Me.btndashrestore = New System.Windows.Forms.Button()
        Me.btndashmin = New System.Windows.Forms.Button()
        Me.btndashmax = New System.Windows.Forms.Button()
        Me.btndashexit = New System.Windows.Forms.Button()
        Me.ClarityTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClarityTheme1
        '
        Me.ClarityTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClarityTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ClarityTheme1.Colors = New CRM.Bloom(-1) {}
        Me.ClarityTheme1.Controls.Add(Me.btndashrestore)
        Me.ClarityTheme1.Controls.Add(Me.btndashmin)
        Me.ClarityTheme1.Controls.Add(Me.btndashmax)
        Me.ClarityTheme1.Controls.Add(Me.btndashexit)
        Me.ClarityTheme1.Customization = ""
        Me.ClarityTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClarityTheme1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ClarityTheme1.Icon = CType(resources.GetObject("ClarityTheme1.Icon"), System.Drawing.Icon)
        Me.ClarityTheme1.Image = Nothing
        Me.ClarityTheme1.Location = New System.Drawing.Point(0, 0)
        Me.ClarityTheme1.Movable = True
        Me.ClarityTheme1.Name = "ClarityTheme1"
        Me.ClarityTheme1.NoRounding = False
        Me.ClarityTheme1.ShowIcon = True
        Me.ClarityTheme1.Sizable = False
        Me.ClarityTheme1.Size = New System.Drawing.Size(1354, 705)
        Me.ClarityTheme1.SmartBounds = True
        Me.ClarityTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.ClarityTheme1.TabIndex = 0
        Me.ClarityTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ClarityTheme1.Transparent = False
        '
        'btndashrestore
        '
        Me.btndashrestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndashrestore.ForeColor = System.Drawing.Color.Transparent
        Me.btndashrestore.Image = Global.CRM.My.Resources.Resources.User_Interface_Restore_Window_icon
        Me.btndashrestore.Location = New System.Drawing.Point(1298, 3)
        Me.btndashrestore.Name = "btndashrestore"
        Me.btndashrestore.Size = New System.Drawing.Size(23, 23)
        Me.btndashrestore.TabIndex = 4
        Me.btndashrestore.UseVisualStyleBackColor = True
        '
        'btndashmin
        '
        Me.btndashmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndashmin.ForeColor = System.Drawing.Color.Transparent
        Me.btndashmin.Image = Global.CRM.My.Resources.Resources.Programming_Minimize_Window_icon
        Me.btndashmin.Location = New System.Drawing.Point(1269, 3)
        Me.btndashmin.Name = "btndashmin"
        Me.btndashmin.Size = New System.Drawing.Size(23, 23)
        Me.btndashmin.TabIndex = 3
        Me.btndashmin.UseVisualStyleBackColor = True
        '
        'btndashmax
        '
        Me.btndashmax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndashmax.ForeColor = System.Drawing.Color.Transparent
        Me.btndashmax.Image = Global.CRM.My.Resources.Resources.Programming_Maximize_Window_icon
        Me.btndashmax.Location = New System.Drawing.Point(1298, 3)
        Me.btndashmax.Name = "btndashmax"
        Me.btndashmax.Size = New System.Drawing.Size(23, 23)
        Me.btndashmax.TabIndex = 2
        Me.btndashmax.UseVisualStyleBackColor = True
        '
        'btndashexit
        '
        Me.btndashexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndashexit.ForeColor = System.Drawing.Color.Transparent
        Me.btndashexit.Image = Global.CRM.My.Resources.Resources.Close_icon
        Me.btndashexit.Location = New System.Drawing.Point(1327, 3)
        Me.btndashexit.Name = "btndashexit"
        Me.btndashexit.Size = New System.Drawing.Size(23, 23)
        Me.btndashexit.TabIndex = 0
        Me.btndashexit.UseVisualStyleBackColor = True
        '
        'DashboardNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 705)
        Me.Controls.Add(Me.ClarityTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DashboardNew"
        Me.Text = "DashboardNew"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ClarityTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClarityTheme1 As ClarityTheme
    Friend WithEvents btndashexit As Button
    Friend WithEvents btndashmin As Button
    Friend WithEvents btndashmax As Button
    Friend WithEvents btndashrestore As Button
End Class
