Imports MySql.Data.MySqlClient
Public Class Form2
    Dim Con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim db As String
    Sub koneksi()
        db = "server=localhost;user id=root;password=;database=game"
        Con = New MySqlConnection(db)
        Con.Open()
    End Sub
    Sub simpan()
        koneksi()
        Dim sql As String
        sql = "insert into flappy values('" & Label3.Text & "','" & Form1.Label4.Text & "','" & Label1.Text & "')"
        cmd = New MySqlCommand(sql, Con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Melihat data berhasil", vbInformation, "INFORMASI")
            Form3.Show()
            Form1.Hide()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Melihat data gagal", vbInformation, "PERINGATAN")
        End Try
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is PictureBox AndAlso ctl.Name <> "PictureBox1" And ctl.Name <> "PictureBox2" Then
                ctl.Visible = False
                ctl.BackColor = Color.Transparent
            End If
        Next
        Label1.Text = Form1.label1.Text
        Label3.Text = Form1.Label2.Text
        Label2.Text = Form1.Label4.Text
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        HomePlay.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Call simpan()
    End Sub
End Class