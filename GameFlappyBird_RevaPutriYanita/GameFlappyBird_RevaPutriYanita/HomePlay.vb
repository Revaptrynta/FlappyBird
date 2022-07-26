Public Class HomePlay
    Dim nama As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PicPlay.Click
        nama = InputBox("Masukkan Nama")
        Form1.Label2.Text = (nama)
        Form1.Timer1.Start()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub HomePlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Energy_Theme___Jextor, AudioPlayMode.BackgroundLoop)
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is PictureBox AndAlso ctl.Name <> "PicPlay" And ctl.Name <> "PicRank" And ctl.Name <> "PictureBox1" Then
                ctl.Visible = False
                ctl.BackColor = Color.Transparent
            End If
        Next
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PicRank.Click
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Jackpot.Show()
        Me.Hide()
    End Sub
End Class