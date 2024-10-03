

Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Drawing.Printing
Imports ZXing
Imports ZXing.QrCode
Imports Spire.Pdf
Imports Spire.Pdf.Graphics
Imports Spire.Pdf.Widget
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient


Public Class Form3



    Public selectedSeatsByMovie As New Dictionary(Of String, List(Of String))


    Public selectedSeats As New List(Of String)()



    Public Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Check if TextBoxes are not empty, CheckBox is checked, and an item is selected in the ComboBox
        If TextBox1.Text <> "" AndAlso TextBox2.Text <> "" AndAlso TextBox3.Text <> "" AndAlso TextBox4.Text <> "" AndAlso TextBox5.Text <> "" AndAlso TextBox6.Text <> "" AndAlso TextBox7.Text <> "" AndAlso ComboBox1.SelectedItem IsNot Nothing Then
            Dim Name As String = TextBox1.Text
            Dim Age As String = TextBox2.Text
            Dim seatNumber As String = TextBox3.Text
            Dim Cp As String = TextBox6.Text
            Dim Email As String = TextBox7.Text
            Dim movieTitle As String = ComboBox1.SelectedItem.ToString()
            Dim Daate As String = TextBox5.Text
            Dim Time As String = TextBox4.Text

            ' Validate the seat number
            If IsSeatNumberValid(seatNumber) Then
                ' Check if the movie title is present in the dictionary
                If Not selectedSeatsByMovie.ContainsKey(movieTitle) Then
                    ' If not present, add the movie title to the dictionary with an empty list
                    selectedSeatsByMovie.Add(movieTitle, New List(Of String)())
                End If

                ' Check if the seat is not already selected for the specific movie 
                If Not selectedSeatsByMovie(movieTitle).Contains(seatNumber, StringComparer.OrdinalIgnoreCase) Then
                    ' Access Form4 and attempt to find the specified button by its name
                    Dim btn As System.Windows.Forms.Button = Form4.GetButtonByName(seatNumber)

                    If btn IsNot Nothing Then
                        ' Change the color of the button to red
                        btn.BackColor = Color.Red

                        ' Convert the seat number to a consistent case (e.g., uppercase)
                        seatNumber = seatNumber.ToUpper()

                        ' Add the seat number to the selectedSeats list for the specific movie
                        selectedSeatsByMovie(movieTitle).Add(seatNumber)




                        Dim query As String = "INSERT INTO TB_reserve (ID, Name, Age, Seats#, Cellphone#, EmailAddress, MovieTitle, Date, Time) VALUES ((SELECT ISNULL(MAX(ID) + 1, 1) FROM TB_reserve), @Name, @Age, @Seats#, @Cellphone#, @EmailAddress, @MovieTitle, @Date, @Time)"


                        Using cmd As SqlCommand = New SqlCommand(query, con)
                                cmd.Parameters.AddWithValue("@Name", Name)
                                cmd.Parameters.AddWithValue("@Age", Age)
                                cmd.Parameters.AddWithValue("@Seats#", seatNumber)
                                cmd.Parameters.AddWithValue("@Cellphone#", Cp)
                                cmd.Parameters.AddWithValue("@EmailAddress", Email)
                                cmd.Parameters.AddWithValue("@MovieTitle", movieTitle)
                                cmd.Parameters.AddWithValue("@Date", Daate)
                                cmd.Parameters.AddWithValue("@Time", Time)
                                con.Open()
                                cmd.ExecuteNonQuery()
                                con.Close()
                                MessageBox.Show("Reservation Success")
                                MessageBox.Show("Click the print button and Download or Screenshot the receipt")
                                BindData()

                                TextBox1.Clear()
                                TextBox2.Clear()
                                TextBox3.Clear()
                                TextBox4.Clear()
                                TextBox5.Clear()
                                TextBox6.Clear()
                                TextBox7.Clear()
                                ComboBox1.SelectedIndex = -1
                            End Using

                    Else
                        MessageBox.Show($"Seat {seatNumber} not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show($"Seat {seatNumber} is already selected for {movieTitle}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Invalid seat number. Please enter a valid seat number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please fill in all required fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BindData()
        Dim query As String = "SELECT ID, Name, Age, Seats#, Cellphone#, EmailAddress, MovieTitle, Date, Time FROM TB_reserve WHERE MovieTitle LIKE '%' + @SortButton + '%' ORDER BY ID ASC"


        Using cmd As SqlCommand = New SqlCommand(query, con)

            cmd.Parameters.AddWithValue("@SortButton", SortButton.Text.Trim())

                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using

    End Sub



    Private Function IsSeatNumberValid(seatNumber As String) As Boolean

        Dim validSeatNumbers As New List(Of String)


        For i As Integer = 1 To 50
            validSeatNumbers.Add("A" & i.ToString())
            validSeatNumbers.Add("a" & i.ToString())
        Next

        For i As Integer = 1 To 50
            validSeatNumbers.Add("B" & i.ToString())
            validSeatNumbers.Add("b" & i.ToString())
        Next


        For i As Integer = 1 To 50
            validSeatNumbers.Add("C" & i.ToString())
            validSeatNumbers.Add("c" & i.ToString())
        Next


        If validSeatNumbers.Contains(seatNumber.ToUpper()) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub Button2_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
        Form2.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Form4.Show()
    End Sub




    Public Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click




        Dim issuanceDateTime As DateTime = DateTime.Now


            Dim pdfDocument As New PdfDocument()


            Dim pdfPage As PdfPageBase = pdfDocument.Pages.Add()


            Dim font As New PdfFont(PdfFontFamily.Helvetica, 12)
            Dim x As Single = 40
            Dim y As Single = 40


            Dim receiptContent As String =
         "" & vbLf & vbLf &
          "" & vbLf & vbLf &
         "                                                   SM CINEMA" & vbLf & vbLf &
         "                                           SM CINEMA ONLINE TICKET" & vbLf &
         "                                            Karuhatan, Valenzuela city" & vbLf &
          " " & vbLf & vbLf &
          " " & vbLf & vbLf &
 $"                                   Issued on:                 {issuanceDateTime:MM/dd/yyyy HH:mm:ss}" & vbLf &
        "                                   Movie:                    " & ComboBox1.SelectedItem.ToString() & vbLf &
        "                                    Date:                     " & TextBox5.Text & vbLf &
        "                                    Time:                     " & TextBox4.Text & vbLf &
          " " & vbLf & vbLf &
          " " & vbLf & vbLf &
         "---------------------------------------------------------------------------------------------------------------------------------------------" & vbLf & vbLf &
         "                                   YOUR SEAT:                 " & TextBox3.Text & vbLf & vbLf &
        "----------------------------------------------------------------------------------------------------------------------------------------------" & vbLf & vbLf &
        "                                                 CINEMA 1" & vbLf &
        " " & vbLf & vbLf &
        "                                    Gross:                       400" & vbLf &   ' PRICE TICKET
        "                                    Basic:                       363.64" & vbLf &
        "                                    Am Tax:                      36.36" & vbLf &
         "                                   Amt Due:                     400" & vbLf &
           " " & vbLf & vbLf &
        "                                        Thank you for your purchase!" & vbLf &
        "                                 Please provide ID before paying at the lobby" & vbLf &
         " " & vbLf & vbLf &
         " "




            ' Draw the receipt content on the PDF
            pdfPage.Canvas.DrawString(receiptContent, font, PdfBrushes.Black, x, y)


            ' Generate the QR code for printing with a website URL
            Dim websiteUrl As String = "https://smcinema.com"
            Dim qrCodeDataForPrint As String = websiteUrl
            Dim qrCodeBitmapForPrint As Bitmap = GenerateQRCode(qrCodeDataForPrint)

            ' Create a Spire.Pdf.Image object for the QR code
            Dim qrCodeImage As PdfImage = PdfImage.FromImage(qrCodeBitmapForPrint)
            Dim qrCodeWidth As Single = qrCodeImage.Width
            Dim qrCodeHeight As Single = qrCodeImage.Height

            ' Draw the QR code on the PDF
            pdfPage.Canvas.DrawImage(qrCodeImage, x, y + font.Height * 40) ' Adjust the position as needed

            ' Save the PDF to a file
            Dim pdfPath As String = "Receipt.pdf"
            pdfDocument.SaveToFile(pdfPath)

            ' Display the PDF using the default PDF viewer
            Process.Start(pdfPath)

            ' Open the website in the default web browser
            Process.Start(websiteUrl)

    End Sub

    Private Function GenerateQRCode(data As String) As Bitmap
        Dim writer As New BarcodeWriter() With {
        .Format = BarcodeFormat.QR_CODE,
        .Options = New QrCodeEncodingOptions With {
            .ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.H,
            .Width = 250,
            .Height = 250
        }
    }

        Dim qrCodeBitmap As Bitmap = writer.Write(data)
        Return qrCodeBitmap
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0

                TextBox4.Text = "9:00am - 12:00pm"
                TextBox5.Text = "11/25/2024"

            Case 1

                TextBox4.Text = "1:00pm - 3:00pm"
                TextBox5.Text = "11/26/2024"


            Case 2

                TextBox4.Text = "4:00pm - 6:00pm"
                TextBox5.Text = "11/27/2024"


            Case 3

                TextBox4.Text = "7:00 pm - 9:00pm"
                TextBox5.Text = "11/28/2024"


        End Select
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs)
        ' Clear the text in the TextBox controls.
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""

        ComboBox1.SelectedItem = Nothing

        TextBox2.Focus()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

        Application.Exit()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub SortButton_Click(sender As Object, e As EventArgs) Handles SortButton.Click
        BindData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
        combo1()
    End Sub

    Public Sub Combo1()
        SortButton.Items.Clear()

        con.Open()

            Dim query As String = "SELECT DISTINCT MovieTitle FROM TB_reserve"
            Using cmd As New SqlCommand(query, con)
                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    For Each row As DataRow In dt.Rows
                        SortButton.Items.Add(row("MovieTitle").ToString())
                    Next
                End Using
            End Using

            con.Close()

    End Sub

    Private Sub SortButton_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SortButton.SelectedIndexChanged
        BindData()
    End Sub
End Class

