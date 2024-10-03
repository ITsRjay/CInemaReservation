Public Class Form2


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim myForm3 As New Form3()
        myForm3.Show()
    End Sub
    Public Sub ImagePicker_SelectedIndexChanged(sender As Object, e As EventArgs) Handles imagePicker.SelectedIndexChanged
        ' First, hide all controls.
        Thor.Visible = False
        Btm.Visible = False
        spiderman.Visible = False
        hulk.Visible = False

        ' Then, show the appropriate control and set the TextBox text based on the selected index.
        Select Case imagePicker.SelectedIndex
            Case 0
                TextBox1.Text = "Overview: 

Thor embarks on a journey unlike anything he's ever faced -- a quest for inner peace. However, his retirement gets interrupted by Gorr the God Butcher, a galactic killer who seeks the extinction of the gods. To combat the threat, Thor enlists the help of King Valkyrie, Korg and ex-girlfriend Jane Foster, who -- to his surprise -- inexplicably wields his magical hammer. Together, they set out on a harrowing cosmic adventure to uncover the mystery of the God Butcher's vengeance."
                TextBox2.Text = "Date: December 25, 2024"
                TextBox3.Text = "Start time: 9:00am"
                Label3.Text = "Price: 400"
                Thor.Visible = True
            Case 1
                TextBox1.Text = "Overview:

Batman ventures into Gotham City's underworld when a sadistic killer leaves behind a trail of cryptic clues. As the evidence begins to lead closer to home and the scale of the perpetrator's plans become clear, he must forge new relationships, unmask the culprit and bring justice to the abuse of power and corruption that has long plagued the metropolis."
                TextBox2.Text = "Date December 26, 2024"
                TextBox3.Text = "Start time: 1pm"
                Label3.Text = "Price: 400"
                Btm.Visible = True
            Case 2
                TextBox1.Text = "Overview: 

With Spider-Man's identity now revealed, our friendly neighborhood web-slinger is unmasked and no longer able to separate his normal life as Peter Parker from the high stakes of being a superhero. When Peter asks for help from Doctor Strange, the stakes become even more dangerous, forcing him to discover what it truly means to be Spider-Man."
                TextBox2.Text = "Date December 27, 2024"
                TextBox3.Text = "Start time:: 4pm"
                Label3.Text = "Price: 400"
                spiderman.Visible = True
            Case 3
                TextBox1.Text = "Overview: 

Scientist Bruce Banner scours the planet for an antidote to the unbridled force of rage within him: the Hulk. But when the military masterminds who dream of exploiting his powers force him back to civilization, he finds himself coming face to face with a new, deadly foe"
                TextBox2.Text = "Date December 28, 2024"
                TextBox3.Text = "Start time: 7pm"
                Label3.Text = "Price: 400"
                hulk.Visible = True
        End Select
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class
