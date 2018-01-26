Public Class Available
    Private _Seat As DBL.Tables.Seating
    Private _Paid As Boolean

    ''' <summary>
    ''' Sets the text value for each label
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Available_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = frmTheater._Date.ToString("f")
        lblPerformance.Text = frmTheater._Performance
        lblSeat.Text = frmTheater._SeatNumber
    End Sub

    ''' <summary>
    ''' Closes window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Checks the Name textbox and then purchases the seat
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        If String.IsNullOrEmpty(txtName.Text) Then
            MsgBox("Name Textbox is empty", , "No Name")
        Else
            _Seat = New DBL.Tables.Seating
            _Paid = True
            Me.putPaidSeat(_Seat)

            Try
                DBL.Tables.Seating.InsertNewSeat(_Seat)
                MsgBox("Seat purchased")
                txtName.Text = ""
                Me.Close()

            Catch ex As Exception
                MsgBox("Seat cannot be inserted")
            End Try

        End If
    End Sub

    ''' <summary>
    ''' Takes the new row values
    ''' </summary>
    ''' <param name="seat"></param>
    ''' <remarks></remarks>
    Private Sub putPaidSeat(seat As DBL.Tables.Seating)
        seat.ID = 0
        seat.SeatNo = lblSeat.Text
        seat.PerfID = frmTheater._PerformID
        seat.Patron = txtName.Text
        seat.IsPaid = _Paid
    End Sub

    ''' <summary>
    ''' Checks the Name textbox and then reserves the seat
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        If String.IsNullOrEmpty(txtName.Text) Then
            MsgBox("Name Textbox is empty", , "No Name")
        Else
            _Seat = New DBL.Tables.Seating
            _Paid = False
            Me.putPaidSeat(_Seat)

            Try
                DBL.Tables.Seating.InsertNewSeat(_Seat)
                MsgBox("Seat reserved")
                txtName.Text = ""
                Me.Close()

            Catch ex As Exception
                MsgBox("Seat cannot be inserted")
            End Try
        End If
    End Sub
End Class