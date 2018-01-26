Public Class frmAddPerform
    Private _Performances As DBL.Tables.Performance

    ''' <summary>
    ''' Validates the inputs for performance table and inserts a new row
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim valid As Boolean = True
        Dim setDate As Date = dtpDate.Text + " " + dtpTime.Text

        If String.IsNullOrEmpty(txtTitle.Text) Then
            MsgBox("Title input is empty")
            valid = False
        End If

        If Not IsNumeric(txtTicket.Text) Then
            MsgBox("Tickets input is not a number")
            valid = False
        End If

        If String.IsNullOrEmpty(txtPicture.Text) Then
            MsgBox("Picture input is empty")
            valid = False
        End If

        If valid = True Then
            _Performances = New DBL.Tables.Performance
            Me.setPerform(_Performances)

            Try
                txtTitle.Text = ""
                txtTicket.Text = ""
                txtPicture.Text = ""
                dtpDate.Text = ""
                dtpDate.Text = ""
                DBL.Tables.Performance.InsertPerform(_Performances)
                MsgBox("Performance Added")
                Me.Close()

            Catch ex As Exception
                MsgBox("Seat cannot be inserted")
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Sets all the fieldnames from performance
    ''' </summary>
    ''' <param name="perform"></param>
    ''' <remarks></remarks>
    Private Sub setPerform(perform As DBL.Tables.Performance)
        perform.PerfID = DBL.Tables.Performance.GetAllPerform.Count + 1
        perform.perfDate = dtpDate.Text
        perform.Title = txtTitle.Text
        perform.Ticket_Price = txtTicket.Text
        perform.Picture = txtPicture.Text
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
End Class