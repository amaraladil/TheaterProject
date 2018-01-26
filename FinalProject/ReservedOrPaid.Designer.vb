<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservedOrPaid
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
        Me.btnPaid = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblBox = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblMovieName = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblSeatNumber = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblMovie = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblReservedFor = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPaid
        '
        Me.btnPaid.Location = New System.Drawing.Point(42, 189)
        Me.btnPaid.Name = "btnPaid"
        Me.btnPaid.Size = New System.Drawing.Size(136, 23)
        Me.btnPaid.TabIndex = 0
        Me.btnPaid.Text = "Confirm Paid Seat"
        Me.btnPaid.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(215, 189)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(136, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Delete Seat Reservation"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblBox
        '
        Me.lblBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBox.Location = New System.Drawing.Point(12, 9)
        Me.lblBox.Name = "lblBox"
        Me.lblBox.Size = New System.Drawing.Size(348, 174)
        Me.lblBox.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(171, 85)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(41, 20)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "date"
        '
        'lblMovieName
        '
        Me.lblMovieName.AutoSize = True
        Me.lblMovieName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieName.Location = New System.Drawing.Point(171, 54)
        Me.lblMovieName.Name = "lblMovieName"
        Me.lblMovieName.Size = New System.Drawing.Size(100, 20)
        Me.lblMovieName.TabIndex = 4
        Me.lblMovieName.Text = "Performance"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(171, 147)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(77, 20)
        Me.lblUserName.TabIndex = 5
        Me.lblUserName.Text = "SeatUser"
        '
        'lblSeatNumber
        '
        Me.lblSeatNumber.AutoSize = True
        Me.lblSeatNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatNumber.Location = New System.Drawing.Point(171, 24)
        Me.lblSeatNumber.Name = "lblSeatNumber"
        Me.lblSeatNumber.Size = New System.Drawing.Size(99, 20)
        Me.lblSeatNumber.TabIndex = 6
        Me.lblSeatNumber.Text = "SeatNumber"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.Location = New System.Drawing.Point(58, 24)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(107, 20)
        Me.lblNumber.TabIndex = 7
        Me.lblNumber.Text = "Seat Number:"
        '
        'lblMovie
        '
        Me.lblMovie.AutoSize = True
        Me.lblMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovie.Location = New System.Drawing.Point(63, 54)
        Me.lblMovie.Name = "lblMovie"
        Me.lblMovie.Size = New System.Drawing.Size(102, 20)
        Me.lblMovie.TabIndex = 8
        Me.lblMovie.Text = "Which Movie:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(117, 85)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(48, 20)
        Me.lblDay.TabIndex = 9
        Me.lblDay.Text = "Date:"
        '
        'lblReservedFor
        '
        Me.lblReservedFor.AutoSize = True
        Me.lblReservedFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservedFor.Location = New System.Drawing.Point(23, 147)
        Me.lblReservedFor.Name = "lblReservedFor"
        Me.lblReservedFor.Size = New System.Drawing.Size(142, 20)
        Me.lblReservedFor.TabIndex = 10
        Me.lblReservedFor.Text = "Seat Reserved for:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(171, 117)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(41, 20)
        Me.lblTime.TabIndex = 11
        Me.lblTime.Text = "date"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(117, 117)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(47, 20)
        Me.lblTimer.TabIndex = 12
        Me.lblTimer.Text = "Time:"
        '
        'frmReservedOrPaid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 224)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblReservedFor)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblMovie)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblSeatNumber)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblMovieName)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblBox)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPaid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmReservedOrPaid"
        Me.Text = "ReservedOrPaid"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPaid As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblBox As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblMovieName As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblSeatNumber As System.Windows.Forms.Label
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblMovie As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblReservedFor As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
End Class
