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
        Me.byndashmin = New CRM.iClarityButton()
        Me.btndashmax = New CRM.iClarityButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btndashexit = New CRM.iClarityButton()
        Me.btndashrestore = New CRM.iClarityButton()
        Me.ClarityTheme1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClarityTheme1
        '
        Me.ClarityTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClarityTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ClarityTheme1.Colors = New CRM.Bloom(-1) {}
        Me.ClarityTheme1.Controls.Add(Me.btndashrestore)
        Me.ClarityTheme1.Controls.Add(Me.byndashmin)
        Me.ClarityTheme1.Controls.Add(Me.btndashmax)
        Me.ClarityTheme1.Controls.Add(Me.SplitContainer1)
        Me.ClarityTheme1.Controls.Add(Me.btndashexit)
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
        Me.ClarityTheme1.Size = New System.Drawing.Size(1362, 741)
        Me.ClarityTheme1.SmartBounds = True
        Me.ClarityTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.ClarityTheme1.TabIndex = 0
        Me.ClarityTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ClarityTheme1.Transparent = False
        '
        'byndashmin
        '
        Me.byndashmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.byndashmin.ForeColor = System.Drawing.Color.Transparent
        Me.byndashmin.Location = New System.Drawing.Point(1246, 3)
        Me.byndashmin.Name = "byndashmin"
        Me.byndashmin.Size = New System.Drawing.Size(31, 23)
        Me.byndashmin.TabIndex = 3
        Me.byndashmin.TabStop = False
        '
        'btndashmax
        '
        Me.btndashmax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndashmax.ForeColor = System.Drawing.Color.Transparent
        Me.btndashmax.Location = New System.Drawing.Point(1283, 3)
        Me.btndashmax.Name = "btndashmax"
        Me.btndashmax.Size = New System.Drawing.Size(31, 23)
        Me.btndashmax.TabIndex = 2
        Me.btndashmax.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 59)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Size = New System.Drawing.Size(150, 100)
        Me.SplitContainer1.TabIndex = 1
        '
        'btndashexit
        '
        Me.btndashexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btndashexit.Location = New System.Drawing.Point(1319, 3)
        Me.btndashexit.Name = "btndashexit"
        Me.btndashexit.Size = New System.Drawing.Size(31, 23)
        Me.btndashexit.TabIndex = 0
        Me.btndashexit.TabStop = False
        Me.btndashexit.Text = "X"
        '
        'btndashrestore
        '
        Me.btndashrestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndashrestore.ForeColor = System.Drawing.Color.Transparent
        Me.btndashrestore.Location = New System.Drawing.Point(1283, 3)
        Me.btndashrestore.Name = "btndashrestore"
        Me.btndashrestore.Size = New System.Drawing.Size(31, 23)
        Me.btndashrestore.TabIndex = 4
        Me.btndashrestore.TabStop = False
        '
        'DashboardNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.ClarityTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardNew"
        Me.Text = "DashboardNew"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ClarityTheme1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClarityTheme1 As ClarityTheme
    Friend WithEvents btndashexit As iClarityButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btndashmax As iClarityButton
    Friend WithEvents byndashmin As iClarityButton
    Friend WithEvents btndashrestore As iClarityButton
End Class
