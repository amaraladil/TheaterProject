
Public Class frmEmptySeats
    Private _TakenSeats As Double = frmTheater.NUMBER_OF_SEATS

    ''' <summary>
    ''' Loads in the table with the right amount of empty seats
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DataTableWithEmptySeats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEmptySeats.DataSource = DBL.Tables.Performance.GetAllEmptySeats(_TakenSeats)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmEmptySeats_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        dgvEmptySeats.Height = Me.Height - 130
        dgvEmptySeats.Width = Me.Width - 100
        lblHeader.Width = Me.Width - 100
    End Sub

End Class