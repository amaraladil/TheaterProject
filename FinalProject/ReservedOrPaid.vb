Public Class frmReservedOrPaid
    Private _Seat As DBL.Tables.Seating

    ''' <summary>
    ''' Checks if the clicked label was a paid seat or not
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmReservedOrPaid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmTheater._SeatPaid = True Then
            btnPaid.Visible = False
            Me.Text = "User Already Paid"
        Else
            btnPaid.Visible = True
            Me.Text = "Seat Reserved"
        End If
        'Sets up the values from the clicked value
        lblDate.Text = frmTheater._Date.ToString("D")
        lblMovieName.Text = frmTheater._Performance
        lblUserName.Text = frmTheater._SeatUser
        lblSeatNumber.Text = frmTheater._SeatNumber
        lblTime.Text = frmTheater._Date.ToString("t")
    End Sub

    ''' <summary>
    ''' Sets the seat to be paid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPaid_Click(sender As Object, e As EventArgs) Handles btnPaid.Click
        _Seat = New DBL.Tables.Seating
        Me.getSeat(_Seat)

        Try
            DBL.Tables.Seating.UpdateSeat(_Seat)
            MsgBox("Seat is now paid")
            Me.Close()

        Catch ex As Exception
            MsgBox("Seat cannot be Updated")
        End Try
    End Sub

    ''' <summary>
    ''' Gets the new row values
    ''' </summary>
    ''' <param name="seat"></param>
    ''' <remarks></remarks>
    Private Sub getSeat(seat As DBL.Tables.Seating)
        seat.ID = 0
        seat.SeatNo = lblSeatNumber.Text
        seat.PerfID = frmTheater._PerformID
        seat.Patron = lblUserName.Text
        seat.IsPaid = True
    End Sub

    ''' <summary>
    ''' Cancels the Seat reservation
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        _Seat = New DBL.Tables.Seating
        Me.getSeat(_Seat)

        Try
            DBL.Tables.Seating.DeleteSeat(_Seat)
            MsgBox("Seat is now Deleted")
            Me.Close()

        Catch ex As Exception
            MsgBox("Seat cannot be Deleted")
        End Try
    End Sub
End Class