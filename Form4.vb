Imports System.Data.SqlClient

Public Class Form4

    Public Function GetButtonByName(seatNumber As String) As Button
        ' Loop through the controls on Form4 to find the button with the specified name
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Name = seatNumber Then
                Return DirectCast(ctrl, Button)
            End If
        Next
        Return Nothing ' Button with the specified name not found
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Update seat colors based on the selected movie
        UpdateSeatColors(ComboBox1.SelectedItem.ToString())
    End Sub

    Public Sub UpdateSeatColors(movieTitle As String)
        ' Clear the previously set colors
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                btn.BackColor = DefaultBackColor
            End If
        Next

        ' Fetch the selected seats for the specific movie
        If Form3.selectedSeatsByMovie.ContainsKey(movieTitle) Then
            Dim selectedSeats = Form3.selectedSeatsByMovie(movieTitle)

            ' Loop through the controls on Form4 to find the buttons representing seats
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is Button Then
                    Dim btn As Button = DirectCast(ctrl, Button)
                    Dim seatName As String = btn.Name

                    ' Debugging: Output seatName to check if the names match
                    Debug.WriteLine($"Checking seat: {seatName}")

                    ' Check if the seat is selected for the specified movie
                    If selectedSeats.Contains(seatName, StringComparer.OrdinalIgnoreCase) Then
                        ' Change the color of the button to red
                        btn.BackColor = Color.Red
                        Debug.WriteLine($"Seat {seatName} is selected for {movieTitle}")
                    End If
                End If
            Next
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        con.Open()
            ' Adjust the query to retrieve distinct movie titles
            Dim query As String = "SELECT DISTINCT MovieTitle FROM TB_reserve"
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ComboBox1.Items.Add(reader("MovieTitle").ToString())
                    End While
                End Using
            End Using
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub
End Class
