
Public Class mnuMovieRevenue

    ''' <summary>
    ''' Loads in a table with performance revenue
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MovieRevenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvRevenue.DataSource = DBL.Tables.Performance.GetRevenue
    End Sub

    Private Sub mnuMovieRevenue_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        dgvRevenue.Height = Me.Height - 130
        dgvRevenue.Width = Me.Width - 100
        lblHeader.Width = Me.Width - 100
    End Sub
End Class