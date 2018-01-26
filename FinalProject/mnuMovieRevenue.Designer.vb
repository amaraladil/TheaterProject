<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mnuMovieRevenue
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
        Me.dgvRevenue = New System.Windows.Forms.DataGridView()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRevenue
        '
        Me.dgvRevenue.AllowUserToAddRows = False
        Me.dgvRevenue.AllowUserToDeleteRows = False
        Me.dgvRevenue.AllowUserToResizeColumns = False
        Me.dgvRevenue.AllowUserToResizeRows = False
        Me.dgvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRevenue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRevenue.Location = New System.Drawing.Point(44, 43)
        Me.dgvRevenue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvRevenue.Name = "dgvRevenue"
        Me.dgvRevenue.ReadOnly = True
        Me.dgvRevenue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvRevenue.Size = New System.Drawing.Size(351, 248)
        Me.dgvRevenue.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.Location = New System.Drawing.Point(40, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(355, 20)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Current Movie Revenue"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(345, 299)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(77, 33)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'mnuMovieRevenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 341)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.dgvRevenue)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mnuMovieRevenue"
        Me.Text = "MovieRevenue"
        CType(Me.dgvRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvRevenue As System.Windows.Forms.DataGridView
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
