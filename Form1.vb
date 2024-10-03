Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Public originalMoviesCount As Integer
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Application.Exit()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
        Combo1()
    End Sub


    Public Sub Combo1()
        SortButton.Items.Clear()

        Try

            Dim query As String = "SELECT DISTINCT MovieTitle FROM TB_reserve"
            Using cmd As New SqlCommand(query, con)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    originalMoviesCount = dt.Rows.Count
                    Label4.Text = originalMoviesCount.ToString()
                    If dt.Rows.Count > 0 Then
                        originalMoviesCount = dt.Rows.Count
                        Label4.Text = originalMoviesCount.ToString()
                        For Each row As DataRow In dt.Rows
                            SortButton.Items.Add(row("MovieTitle").ToString())
                        Next

                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error fetching movie titles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdateAvailableMoviesCount()
        ' Update available movies count in Label4
        Label4.Text = SortButton.Items.Count.ToString()
    End Sub

    Private Sub BindData()
        If SortButton.SelectedItem IsNot Nothing Then
            Dim selectedMovieTitle As String = SortButton.SelectedItem.ToString()

            ' The maximum limit of seats (150 in this case)
            Dim totalSeatsLimit As Integer = 150

            Dim query As String = "SELECT COUNT(*) AS SeatCount FROM TB_reserve WHERE MovieTitle = @MovieTitle"

            Try

                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@MovieTitle", selectedMovieTitle)

                    con.Open()

                    Dim seatCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' Calculate the available seats
                    Dim availableSeats As Integer = totalSeatsLimit - seatCount

                    ' Display occupied seats
                    Label3.Text = $"{availableSeats} / {totalSeatsLimit}"

                    ' Decrease available movies count in Label4 if the limit is reached
                    If availableSeats <= 0 Then
                        MessageBox.Show($"No more available seats for {selectedMovieTitle}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        UpdateAvailableMoviesCount()
                    End If
                    con.Close()
                End Using

            Catch ex As Exception
                MessageBox.Show($"Error fetching seat count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    ' Example: Handle ComboBox selection change event

    Private Sub SortButton_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SortButton.SelectedIndexChanged
          BindData()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
