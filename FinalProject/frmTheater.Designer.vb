<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTheater
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
        Me.cboPerformance = New System.Windows.Forms.ComboBox()
        Me.TheaterHints = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuDataGridForms = New System.Windows.Forms.MenuStrip()
        Me.mnuOpenSeats = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRevenue = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblStage = New System.Windows.Forms.Label()
        Me.btnPerform = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mnuDataGridForms.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboPerformance
        '
        Me.cboPerformance.DisplayMember = "PerfID"
        Me.cboPerformance.FormattingEnabled = True
        Me.cboPerformance.Location = New System.Drawing.Point(22, 36)
        Me.cboPerformance.Name = "cboPerformance"
        Me.cboPerformance.Size = New System.Drawing.Size(279, 21)
        Me.cboPerformance.TabIndex = 1
        Me.cboPerformance.ValueMember = "PerfID"
        '
        'mnuDataGridForms
        '
        Me.mnuDataGridForms.BackColor = System.Drawing.SystemColors.Menu
        Me.mnuDataGridForms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenSeats, Me.mnuRevenue})
        Me.mnuDataGridForms.Location = New System.Drawing.Point(0, 0)
        Me.mnuDataGridForms.Name = "mnuDataGridForms"
        Me.mnuDataGridForms.Size = New System.Drawing.Size(807, 24)
        Me.mnuDataGridForms.TabIndex = 52
        Me.mnuDataGridForms.Text = "MenuStrip1"
        '
        'mnuOpenSeats
        '
        Me.mnuOpenSeats.BackColor = System.Drawing.SystemColors.Menu
        Me.mnuOpenSeats.Name = "mnuOpenSeats"
        Me.mnuOpenSeats.Size = New System.Drawing.Size(93, 20)
        Me.mnuOpenSeats.Text = "Availible seats"
        '
        'mnuRevenue
        '
        Me.mnuRevenue.BackColor = System.Drawing.SystemColors.Menu
        Me.mnuRevenue.Name = "mnuRevenue"
        Me.mnuRevenue.Size = New System.Drawing.Size(105, 20)
        Me.mnuRevenue.Text = "Movie Revenues"
        '
        'lblStage
        '
        Me.lblStage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblStage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblStage.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStage.Location = New System.Drawing.Point(9, 139)
        Me.lblStage.Name = "lblStage"
        Me.lblStage.Size = New System.Drawing.Size(785, 44)
        Me.lblStage.TabIndex = 53
        Me.lblStage.Text = "Stage"
        Me.lblStage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPerform
        '
        Me.btnPerform.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnPerform.Location = New System.Drawing.Point(654, 36)
        Me.btnPerform.Name = "btnPerform"
        Me.btnPerform.Size = New System.Drawing.Size(140, 23)
        Me.btnPerform.TabIndex = 54
        Me.btnPerform.Text = "Add New Performance"
        Me.btnPerform.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(355, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 25)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Waldo's Theater"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExit.Location = New System.Drawing.Point(742, 156)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(38, 23)
        Me.btnExit.TabIndex = 56
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmTheater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(807, 181)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPerform)
        Me.Controls.Add(Me.lblStage)
        Me.Controls.Add(Me.cboPerformance)
        Me.Controls.Add(Me.mnuDataGridForms)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.mnuDataGridForms
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTheater"
        Me.Text = "Waldo's Theater"
        Me.mnuDataGridForms.ResumeLayout(False)
        Me.mnuDataGridForms.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboPerformance As System.Windows.Forms.ComboBox
    Friend WithEvents TheaterHints As System.Windows.Forms.ToolTip
    Friend WithEvents mnuDataGridForms As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuOpenSeats As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRevenue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStage As System.Windows.Forms.Label
    Friend WithEvents btnPerform As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
