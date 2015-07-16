<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.menuQuit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.trayMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.outStatus = New System.Windows.Forms.TextBox()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.menuQuit.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuQuit
        '
        Me.menuQuit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitToolStripMenuItem})
        Me.menuQuit.Name = "menuQuit"
        Me.menuQuit.Size = New System.Drawing.Size(104, 54)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(100, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'trayMain
        '
        Me.trayMain.Icon = CType(resources.GetObject("trayMain.Icon"), System.Drawing.Icon)
        Me.trayMain.Text = "Steam Loader"
        Me.trayMain.Visible = True
        '
        'outStatus
        '
        Me.outStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.outStatus.Enabled = False
        Me.outStatus.Location = New System.Drawing.Point(64, 14)
        Me.outStatus.Name = "outStatus"
        Me.outStatus.ReadOnly = True
        Me.outStatus.Size = New System.Drawing.Size(100, 13)
        Me.outStatus.TabIndex = 2
        Me.outStatus.TabStop = False
        '
        'labelStatus
        '
        Me.labelStatus.AutoSize = True
        Me.labelStatus.Location = New System.Drawing.Point(18, 14)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(40, 13)
        Me.labelStatus.TabIndex = 1
        Me.labelStatus.Text = "Status:"
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(170, 9)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(75, 23)
        Me.btnHide.TabIndex = 4
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(251, 9)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 41)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.labelStatus)
        Me.Controls.Add(Me.outStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formMain"
        Me.ShowIcon = False
        Me.Text = "Steam Loader"
        Me.menuQuit.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents trayMain As NotifyIcon
    Friend WithEvents outStatus As TextBox
    Friend WithEvents labelStatus As Label
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnHide As Button
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents menuQuit As ContextMenuStrip
    Friend WithEvents btnQuit As Button
End Class
