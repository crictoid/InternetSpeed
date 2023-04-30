<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInternetSpeed
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
        Me.mnuFitness = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAverageInternetSpeed = New System.Windows.Forms.Label()
        Me.lstInternetSpeed = New System.Windows.Forms.ListBox()
        Me.btnInternetSpeed = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnuFitness.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuFitness
        '
        Me.mnuFitness.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuClear, Me.mnuExit})
        Me.mnuFitness.Location = New System.Drawing.Point(0, 0)
        Me.mnuFitness.Name = "mnuFitness"
        Me.mnuFitness.Size = New System.Drawing.Size(800, 24)
        Me.mnuFitness.TabIndex = 11
        Me.mnuFitness.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(46, 20)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(38, 20)
        Me.mnuExit.Text = "E&xit"
        '
        'lblAverageInternetSpeed
        '
        Me.lblAverageInternetSpeed.AutoSize = True
        Me.lblAverageInternetSpeed.BackColor = System.Drawing.Color.White
        Me.lblAverageInternetSpeed.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageInternetSpeed.ForeColor = System.Drawing.Color.Black
        Me.lblAverageInternetSpeed.Location = New System.Drawing.Point(459, 378)
        Me.lblAverageInternetSpeed.Name = "lblAverageInternetSpeed"
        Me.lblAverageInternetSpeed.Size = New System.Drawing.Size(312, 19)
        Me.lblAverageInternetSpeed.TabIndex = 15
        Me.lblAverageInternetSpeed.Text = "Average Internet Speed: XX.XX Mbps"
        Me.lblAverageInternetSpeed.Visible = False
        '
        'lstInternetSpeed
        '
        Me.lstInternetSpeed.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInternetSpeed.ForeColor = System.Drawing.Color.Black
        Me.lstInternetSpeed.FormattingEnabled = True
        Me.lstInternetSpeed.ItemHeight = 23
        Me.lstInternetSpeed.Location = New System.Drawing.Point(654, 71)
        Me.lstInternetSpeed.Name = "lstInternetSpeed"
        Me.lstInternetSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstInternetSpeed.Size = New System.Drawing.Size(50, 257)
        Me.lstInternetSpeed.TabIndex = 14
        '
        'btnInternetSpeed
        '
        Me.btnInternetSpeed.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnInternetSpeed.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInternetSpeed.Location = New System.Drawing.Point(378, 84)
        Me.btnInternetSpeed.Name = "btnInternetSpeed"
        Me.btnInternetSpeed.Size = New System.Drawing.Size(207, 38)
        Me.btnInternetSpeed.TabIndex = 13
        Me.btnInternetSpeed.Text = "Enter Internet Speed"
        Me.btnInternetSpeed.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(302, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(340, 29)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "Internet Speed Test Survey"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmInternetSpeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BulmerCh6CPA2.My.Resources.Resources.speed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mnuFitness)
        Me.Controls.Add(Me.lblAverageInternetSpeed)
        Me.Controls.Add(Me.lstInternetSpeed)
        Me.Controls.Add(Me.btnInternetSpeed)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmInternetSpeed"
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.mnuFitness.ResumeLayout(False)
        Me.mnuFitness.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuFitness As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblAverageInternetSpeed As Label
    Friend WithEvents lstInternetSpeed As ListBox
    Friend WithEvents btnInternetSpeed As Button
    Friend WithEvents lblTitle As Label
End Class
