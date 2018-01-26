'File Name: Final Project
'Authors:   Amar Al-Adil
'Date:      April 15th, 2016
'Purpose:   This program is for our final project and it continues off from what we had for lab 5. 
'           We had to reserve, pay or remove seats. Add new performance.

Imports System.Data.SqlClient

Public Class frmTheater
    'Place Holders for other forms when user clicks on a seat label
    Public _Date As Date
    Public _Performance As String
    Public _PerformID As Integer
    Public _SeatNumber As Integer
    Public _SeatUser As String
    Public _SeatPaid As Boolean
    'Number of labels array
    Public Const NUMBER_OF_SEATS As Integer = 50
    Private _LBL(NUMBER_OF_SEATS) As Label

    ''' <summary>
    ''' Loads the objects in the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmTheater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        'Used for the locations of the label
        Dim formHeight As Integer = 0
        Dim xLocate As Integer = 10
        Dim yLocate As Integer = 70
        For count As Integer = 1 To NUMBER_OF_SEATS
            'Creates a new label inside the form
            _LBL(count) = New Label
            _LBL(count).Name = "lblSeat" + count.ToString
            _LBL(count).Location = New System.Drawing.Point(xLocate, yLocate)
            _LBL(count).Size = New Size(65, 34)
            _LBL(count).BorderStyle = BorderStyle.FixedSingle
            _LBL(count).TextAlign = ContentAlignment.MiddleCenter
            _LBL(count).Text = count.ToString
            Me.Controls.Add(_LBL(count))
            xLocate += 80
            formHeight = yLocate + 50
            'Every tenth label, will start a new row
            If (count Mod 10 = 0) Then
                xLocate = 9
                yLocate += 50
            End If

            AddHandler _LBL(count).Click, AddressOf Label_Click
        Next
        Me.Height = formHeight + lblStage.Height + 40

        'Sets the Combobox
        cboPerformance.DisplayMember = "Title"
        cboPerformance.ValueMember = "PerfID"
        cboPerformance.DataSource = DBL.Tables.Performance.GetAllPerform

        setDefault()
    End Sub

    ''' <summary>
    ''' If combobox changes, it sets the reserved seats
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPerformance.SelectedIndexChanged
        If (cboPerformance.SelectedValue = 0) Then
            setDefault()
        Else
            setDefault()
            ReservedSeats()
        End If
    End Sub

    ''' <summary>
    ''' Checks seats for the specific performance chosen on combo box
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReservedSeats()
        Dim dtSeating As New DataTable()
        dtSeating = DBL.Tables.Seating.GetAllByPerform(cboPerformance.SelectedValue)
        'Sets the seats depending if they are paid or reserved
        For count As Integer = 0 To dtSeating.Rows.Count - 1
            Dim myLabel As Label = CType(Me.Controls("lblSeat" & dtSeating.Rows(count)("seatNo").ToString), Label)
            myLabel.Text = dtSeating.Rows(count)("Patron").ToString
            If dtSeating.Rows(count)("IsPaid").ToString = True Then
                myLabel.BackColor = Color.Red
                TheaterHints.SetToolTip(myLabel, "Paid")
            Else
                myLabel.BackColor = Color.Yellow
                TheaterHints.SetToolTip(myLabel, "Owing")
            End If
            myLabel.Font = New Font(myLabel.Font.Name, 7, myLabel.Font.Style)
        Next
        'con.Close()
    End Sub

    ''' <summary>
    ''' Resets the form back to default
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub setDefault()
        'Sets up the text for each label
        For Count = 1 To NUMBER_OF_SEATS
            _LBL(Count).Text = Count
            'Sets the background colour back with the font size
            _LBL(Count).BackColor = Color.Transparent
            _LBL(Count).Font = New Font(_LBL(Count).Font.Name, 8, _LBL(Count).Font.Style)
            TheaterHints.SetToolTip(_LBL(Count), "Available")
        Next
    End Sub

    ''' <summary>
    ''' opens the AvailibleSeats form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AvailibleSeatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuOpenSeats.Click
        frmEmptySeats.ShowDialog()
    End Sub

    ''' <summary>
    ''' Opens Movie Revenue Form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MovieRevenuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuRevenue.Click
        mnuMovieRevenue.ShowDialog()
    End Sub

    ''' <summary>
    ''' Click Settings
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Label_Click(sender As System.Object, e As System.EventArgs)
        Dim clickedLabel = TryCast(sender, Label)
        'Clicking on the labels while combobox is on "Choose Performance" will not work
        If Not cboPerformance.SelectedValue = 0 Then
            If clickedLabel IsNot Nothing Then
                Dim str As String = My.Settings.dbTheater
                Dim con As New SqlConnection(str)
                Dim str1 As String = "SELECT * FROM Performances WHERE PerfID = '" & cboPerformance.SelectedValue & "'"
                Dim da As New SqlDataAdapter(str1, con)
                Dim dtSeating As New DataTable()
                da.Fill(dtSeating)

                'Gets the date
                _Date = (dtSeating.Rows(0)("perf_Date").ToString)
                'Gets the performance name
                _Performance = (dtSeating.Rows(0)("Title").ToString)
                'Gets the performance ID
                _PerformID = CInt(cboPerformance.SelectedValue)
                'Gets the tables seat number
                For Count = 1 To NUMBER_OF_SEATS
                    Dim myLabel As Label = CType(Me.Controls("lblSeat" & Count), Label)
                    If myLabel.Text = clickedLabel.Text Then
                        _SeatNumber = Count
                    End If
                Next
                'Gets the person who reserved the seat
                _SeatUser = clickedLabel.Text
                ' Depending on the back color for each label, if they will prompt a new form for each one
                If clickedLabel.BackColor = Color.Transparent Then
                    Available.ShowDialog()
                ElseIf clickedLabel.BackColor = Color.Red Or clickedLabel.BackColor = Color.Yellow Then
                    'Checks if the clicked seat is paid or not
                    If clickedLabel.BackColor = Color.Red Then
                        _SeatPaid = True
                    Else
                        _SeatPaid = False
                    End If
                    frmReservedOrPaid.ShowDialog()
                    setDefault()
                End If
                ReservedSeats()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Shows Add Performance Window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPerform_Click(sender As Object, e As EventArgs) Handles btnPerform.Click
        frmAddPerform.ShowDialog()

        cboPerformance.DataSource = DBL.Tables.Performance.GetAllPerform
        cboPerformance.Update()
        cboPerformance.Refresh()
        'ComboBox1.
    End Sub

    ''' <summary>
    ''' Closes the program
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
