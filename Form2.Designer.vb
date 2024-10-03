<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.imagePicker = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.spiderman = New System.Windows.Forms.PictureBox()
        Me.Btm = New System.Windows.Forms.PictureBox()
        Me.Thor = New System.Windows.Forms.PictureBox()
        Me.hulk = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.spiderman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Thor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hulk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(901, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(880, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "--"
        '
        'imagePicker
        '
        Me.imagePicker.FormattingEnabled = True
        Me.imagePicker.Items.AddRange(New Object() {"Thor", "Batman", "Spiderman", "Hulk"})
        Me.imagePicker.Location = New System.Drawing.Point(218, 74)
        Me.imagePicker.Name = "imagePicker"
        Me.imagePicker.Size = New System.Drawing.Size(288, 21)
        Me.imagePicker.TabIndex = 7
        Me.imagePicker.Text = "AVAILABLE MOVIES"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(522, 74)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(297, 277)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(522, 358)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(173, 24)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(522, 388)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(173, 24)
        Me.TextBox3.TabIndex = 15
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'spiderman
        '
        Me.spiderman.Image = Global.CInemaReservation.My.Resources.Resources.spiderman
        Me.spiderman.Location = New System.Drawing.Point(218, 101)
        Me.spiderman.Name = "spiderman"
        Me.spiderman.Size = New System.Drawing.Size(288, 311)
        Me.spiderman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spiderman.TabIndex = 19
        Me.spiderman.TabStop = False
        '
        'Btm
        '
        Me.Btm.Image = Global.CInemaReservation.My.Resources.Resources.Btm
        Me.Btm.Location = New System.Drawing.Point(222, 101)
        Me.Btm.Name = "Btm"
        Me.Btm.Size = New System.Drawing.Size(276, 311)
        Me.Btm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btm.TabIndex = 18
        Me.Btm.TabStop = False
        '
        'Thor
        '
        Me.Thor.Image = Global.CInemaReservation.My.Resources.Resources.Thor
        Me.Thor.Location = New System.Drawing.Point(226, 101)
        Me.Thor.Name = "Thor"
        Me.Thor.Size = New System.Drawing.Size(276, 311)
        Me.Thor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Thor.TabIndex = 17
        Me.Thor.TabStop = False
        '
        'hulk
        '
        Me.hulk.Image = Global.CInemaReservation.My.Resources.Resources.hulk
        Me.hulk.Location = New System.Drawing.Point(225, 101)
        Me.hulk.Name = "hulk"
        Me.hulk.Size = New System.Drawing.Size(276, 311)
        Me.hulk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.hulk.TabIndex = 16
        Me.hulk.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 248)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 47)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "MOVIES"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(0, 193)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(159, 47)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "DASHBOARD"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(0, 301)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(159, 47)
        Me.Button7.TabIndex = 34
        Me.Button7.Text = "RESERVE"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CInemaReservation.My.Resources.Resources.sm3
        Me.PictureBox1.Location = New System.Drawing.Point(12, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(159, 548)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(711, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 20
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 548)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.spiderman)
        Me.Controls.Add(Me.Btm)
        Me.Controls.Add(Me.Thor)
        Me.Controls.Add(Me.hulk)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.imagePicker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.spiderman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Thor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hulk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents imagePicker As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents hulk As PictureBox
    Friend WithEvents Thor As PictureBox
    Friend WithEvents Btm As PictureBox
    Friend WithEvents spiderman As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
