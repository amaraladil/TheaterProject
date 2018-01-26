Imports Microsoft.VisualBasic, System.Data, System.Data.SqlClient

Namespace DBL

    Public Class Connection
        Public Const ConnectionStringName As String = "dbTheater"

        Public Shared Function GetConnString() As String
            Return My.Settings.dbTheater
        End Function

    End Class


    Public Class Tables

        Public Class Performance
            Public Class FieldNames
                Public Const ID As String = "perfID"
                Public Const perfDate As String = "perf_Date"
                Public Const Title As String = "Title"
                Public Const Ticket_Price As String = "Ticket_Price"
                Public Const Picture As String = "Picture"

            End Class

#Region "Properties"
            Private _PerfID As Integer
            Public Property PerfID() As Integer
                Get
                    Return _PerfID
                End Get
                Set(ByVal value As Integer)
                    _PerfID = value
                End Set
            End Property

            Private _Date As Date
            Public Property perfDate() As Date
                Get
                    Return _Date
                End Get
                Set(ByVal value As Date)
                    _Date = value
                End Set
            End Property

            Private _Title As String
            Public Property Title() As String
                Get
                    Return _Title
                End Get
                Set(ByVal value As String)
                    _Title = value
                End Set
            End Property

            Private _TicketPrice As String
            Public Property Ticket_Price() As String
                Get
                    Return _TicketPrice
                End Get
                Set(ByVal value As String)
                    _TicketPrice = value
                End Set
            End Property
            Private _Picture As String
            Public Property Picture() As String
                Get
                    Return _Picture
                End Get
                Set(ByVal value As String)
                    _Picture = value
                End Set
            End Property


#End Region

            Public Shared Function GetAllPerform() As List(Of Performance)
                Dim RL As New List(Of Performance)
                Dim connection As New SqlConnection(DBL.Connection.GetConnString)
                Dim strSQL As String = "SELECT PerfID, (Title +'  ' + CONVERT(nvarchar(50), perf_Date)) AS Title, Ticket_Price, Picture, perf_Date FROM Performances ORDER BY CASE WHEN Title = 'Choose Show' THEN 0 ELSE 1 END, Title"

                Dim perform As New Performance

                Dim command As New SqlCommand(strSQL, connection)
                command.CommandType = CommandType.Text
                connection.Open()

                Try
                    Dim dR As IDataReader = command.ExecuteReader
                    Do While dR.Read()
                        perform = New Performance
                        If Not IsDBNull(dR(FieldNames.perfDate)) Then perform.perfDate = dR(FieldNames.perfDate)
                        If Not IsDBNull(dR(FieldNames.ID)) Then perform.PerfID = dR(FieldNames.ID)
                        If Not IsDBNull(dR(FieldNames.Title)) Then perform.Title = dR(FieldNames.Title)
                        If Not IsDBNull(dR(FieldNames.Ticket_Price)) Then perform.Ticket_Price = dR(FieldNames.Ticket_Price)
                        If Not IsDBNull(dR(FieldNames.Picture)) Then perform.Picture = dR(FieldNames.Picture)

                        RL.Add(perform)
                    Loop
                    connection.Close()

                    Return RL
                Catch ex As Exception
                    Return Nothing
                End Try
            End Function

            Public Shared Function InsertPerform(Perform As Performance) As Integer
                Dim connection As New SqlConnection(DBL.Connection.GetConnString)

                Dim strSQL As String
                strSQL = "INSERT INTO Performances (PerfID, perf_Date, Title, Ticket_Price, Picture) "
                strSQL &= "VALUES (@PerfID, @perfDate, @Title, @Ticket_Price, @Picture);"

                Dim command As New SqlCommand(strSQL, connection)
                command.CommandType = CommandType.Text
                command.Parameters.Add(New SqlParameter("@perfDate", Perform.perfDate))
                command.Parameters.AddWithValue("@Title", Perform.Title)
                command.Parameters.AddWithValue("@Ticket_Price", Perform.Ticket_Price)
                command.Parameters.AddWithValue("@Picture", Perform.Picture)
                command.Parameters.AddWithValue("@PerfID", Perform.PerfID)

                Dim ReturnValue As Integer = 0
                Try
                    connection.Open()
                    ReturnValue = command.ExecuteNonQuery
                    connection.Close()
                Catch ex As Exception
                    connection.Close()
                    ReturnValue = 0
                End Try
                Return CInt((ReturnValue = 1))
            End Function

            Public Shared Function GetAllEmptySeats(TotalSeat As Integer) As DataTable
                Dim con As New SqlConnection(DBL.Connection.GetConnString)
                Dim strSql As String = "SELECT Title, (" & (TotalSeat) & " - COUNT(SeatNo)) AS Empty_Seats "
                strSql &= "FROM Performances JOIN Seating ON Seating.PerfID = Performances.PerfID "
                strSql &= "GROUP BY Performances.Title "
                strSql &= "ORDER BY CASE WHEN Title = 'Choose Show' THEN 0 ELSE 1 END, Title "
                Dim da As New SqlDataAdapter(strSql, con)
                Dim dtSeating As New DataTable()
                da.Fill(dtSeating)
                Return dtSeating
            End Function

            Public Shared Function GetRevenue() As DataTable
                Dim con As New SqlConnection(DBL.Connection.GetConnString)
                Dim strSql As String = "SELECT Performances.Title, ROUND(Performances.Ticket_Price*COUNT(Seating.SeatNo),0) AS Purchased_Seat "
                strSql &= "FROM Performances JOIN Seating ON Seating.PerfID = Performances.PerfID "
                strSql &= "WHERE IsPaid = 'True' "
                strSql &= "GROUP BY Performances.Title, Performances.Ticket_Price "
                strSql &= "ORDER BY Title "
                Dim da As New SqlDataAdapter(strSql, con)
                Dim dtSeating As New DataTable()
                da.Fill(dtSeating)
                Return dtSeating
            End Function

        End Class

        Public Class Seating

            Public Class FieldNames
                Public Const ID As String = "ID"
                Public Const SeatNo As String = "SeatNo"
                Public Const PerfID As String = "PerfID"
                Public Const Patron As String = "Patron"
                Public Const IsPaid As String = "IsPaid"
            End Class
#Region "Properties"

            Private _ID As Integer
            Public Property ID() As Integer
                Get
                    Return _ID
                End Get
                Set(ByVal value As Integer)
                    _ID = value
                End Set
            End Property

            Private _SeatNo As Integer
            Public Property SeatNo() As Integer
                Get
                    Return _SeatNo
                End Get
                Set(ByVal value As Integer)
                    _SeatNo = value
                End Set
            End Property

            Private _PerfID As Integer
            Public Property PerfID() As Integer
                Get
                    Return _PerfID
                End Get
                Set(ByVal value As Integer)
                    _PerfID = value
                End Set
            End Property

            Private _Patron As String
            Public Property Patron() As String
                Get
                    Return _Patron
                End Get
                Set(ByVal value As String)
                    _Patron = value
                End Set
            End Property

            Private _IsPaid As Boolean
            Public Property IsPaid() As Boolean
                Get
                    Return _IsPaid
                End Get
                Set(ByVal value As Boolean)
                    _IsPaid = value
                End Set
            End Property
#End Region

            Public Shared Function GetSeat(PlayerID As Integer) As Seating
                Dim conn As New SqlConnection(DBL.Connection.GetConnString)

                Dim sqlString As String
                sqlString = "SELECT * FROM tblDatPlayers WHERE PlayerID = @PlayerID"

                Dim Command As New SqlCommand(sqlString, conn)
                Command.CommandType = CommandType.Text

                Dim Parm As New SqlParameter()
                Parm.ParameterName = "@PlayerID"
                Parm.Value = PlayerID
                Command.Parameters.Add(Parm)

                Dim LocalPlayers As New Seating

                Try
                    conn.Open()
                    Dim MyDataReader As SqlDataReader
                    MyDataReader = Command.ExecuteReader

                    MyDataReader.Read()

                    LocalPlayers.ID = CInt(MyDataReader(FieldNames.ID))
                    LocalPlayers.SeatNo = CType(MyDataReader(FieldNames.SeatNo), String)
                    LocalPlayers.PerfID = CType(MyDataReader(FieldNames.PerfID), String)
                    LocalPlayers.Patron = CInt(MyDataReader(FieldNames.Patron))
                    LocalPlayers.IsPaid = CStr(MyDataReader(FieldNames.IsPaid))

                    MyDataReader.Close()
                    conn.Close()
                Catch ex As Exception
                    LocalPlayers = Nothing
                End Try

                Return LocalPlayers
            End Function

            Public Shared Function GetAllByPerform(PerformID As Integer) As DataTable
                Dim con As New SqlConnection(DBL.Connection.GetConnString)
                Dim str1 As String = "SELECT * FROM Seating WHERE PerfID = '" & PerformID & "'"
                Dim da As New SqlDataAdapter(str1, con)
                Dim dtSeating As New DataTable()
                da.Fill(dtSeating)
                Return dtSeating
            End Function

            Public Shared Function InsertNewSeat(Seat As Seating) As Integer
                Dim connection As New SqlConnection(DBL.Connection.GetConnString)

                Dim strSQL As String
                strSQL = "INSERT INTO Seating (SeatNo, PerfID, Patron, IsPaid) "
                strSQL &= "VALUES (@SeatNo, @PerfID, @Patron, @IsPaid);"

                Dim command As New SqlCommand(strSQL, connection)
                command.CommandType = CommandType.Text
                command.Parameters.Add(New SqlParameter("@SeatNo", Seat.SeatNo))
                command.Parameters.AddWithValue("@PerfID", Seat.PerfID)
                command.Parameters.AddWithValue("@Patron", Seat.Patron)
                command.Parameters.AddWithValue("@IsPaid", Seat.IsPaid)

                Dim ReturnValue As Integer = 0
                Try
                    connection.Open()
                    ReturnValue = command.ExecuteNonQuery

                    connection.Close()
                Catch ex As Exception
                    connection.Close()
                    ReturnValue = 0
                End Try
                Return CInt((ReturnValue = 1))
            End Function

            Public Shared Function UpdateSeat(Seat As Seating) As Integer
                Dim connection As New SqlConnection(DBL.Connection.GetConnString)

                Dim strSQL As String
                strSQL = "UPDATE Seating Set IsPaid=1 "
                strSQL &= "WHERE PerfID = @PerfID AND SeatNo = @SeatNo"

                Dim command As New SqlCommand(strSQL, connection)
                command.CommandType = CommandType.Text

                command.Parameters.Add(New SqlParameter("@SeatNo", Seat.SeatNo))
                command.Parameters.AddWithValue("@PerfID", Seat.PerfID)

                Dim ReturnValue As Integer = 0
                Try
                    connection.Open()
                    ReturnValue = command.ExecuteNonQuery

                    connection.Close()
                Catch ex As Exception
                    connection.Close()
                    ReturnValue = 0
                End Try
                Return CInt((ReturnValue = 1))
            End Function

            Public Shared Function DeleteSeat(seat As Seating) As Boolean
                Dim conn As New SqlConnection(DBL.Connection.GetConnString)

                ' Define the SQL
                Dim sqlString As String
                sqlString = "DELETE Seating WHERE PerfID = @PerfID AND SeatNo = @SeatNo"

                Dim Command As New SqlCommand(sqlString, conn)
                Command.CommandType = CommandType.Text

                Command.Parameters.Add(New SqlParameter("@SeatNo", Seat.SeatNo))
                Command.Parameters.AddWithValue("@PerfID", Seat.PerfID)

                Dim ReturnValue As Integer = 0

                Try
                    conn.Open()

                    ReturnValue = Command.ExecuteNonQuery

                    conn.Close()
                Catch ex As Exception
                    'TODO: Put some code here
                    ReturnValue = 0
                End Try
                Return (ReturnValue = 1)

            End Function
           
        End Class
    End Class
End Namespace

