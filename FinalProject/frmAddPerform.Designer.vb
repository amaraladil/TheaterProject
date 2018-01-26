<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPerform
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
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblPicture = New System.Windows.Forms.Label()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.txtPicture = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(154, 51)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(208, 26)
        Me.txtTitle.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(86, 51)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(42, 20)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Title:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(86, 96)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(48, 20)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(11, 183)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(117, 20)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Price per ticket:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(75, 140)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(47, 20)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "Time:"
        '
        'lblPicture
        '
        Me.lblPicture.AutoSize = True
        Me.lblPicture.Location = New System.Drawing.Point(60, 226)
        Me.lblPicture.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPicture.Name = "lblPicture"
        Me.lblPicture.Size = New System.Drawing.Size(62, 20)
        Me.lblPicture.TabIndex = 5
        Me.lblPicture.Text = "Picture:"
        '
        'txtTicket
        '
        Me.txtTicket.Location = New System.Drawing.Point(154, 183)
        Me.txtTicket.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Size = New System.Drawing.Size(208, 26)
        Me.txtTicket.TabIndex = 7
        '
        'txtPicture
        '
        Me.txtPicture.Location = New System.Drawing.Point(154, 226)
        Me.txtPicture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPicture.Name = "txtPicture"
        Me.txtPicture.Size = New System.Drawing.Size(208, 26)
        Me.txtPicture.TabIndex = 9
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(154, 96)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(208, 26)
        Me.dtpDate.TabIndex = 10
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(26, 264)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(244, 35)
        Me.btnInsert.TabIndex = 11
        Me.btnInsert.Text = "Add New Performance"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'dtpTime
        '
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(154, 140)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(208, 26)
        Me.dtpTime.TabIndex = 12
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Location = New System.Drawing.Point(75, 17)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(254, 20)
        Me.lblFormTitle.TabIndex = 13
        Me.lblFormTitle.Text = "Want to Add Another Performance"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(298, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAddPerform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 311)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblFormTitle)
        Me.Controls.Add(Me.dtpTime)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtPicture)
        Me.Controls.Add(Me.txtTicket)
        Me.Controls.Add(Me.lblPicture)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAddPerform"
        Me.Text = "Add Performance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblPicture As System.Windows.Forms.Label
    Friend WithEvents txtTicket As System.Windows.Forms.TextBox
    Friend WithEvents txtPicture As System.Windows.Forms.TextBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
