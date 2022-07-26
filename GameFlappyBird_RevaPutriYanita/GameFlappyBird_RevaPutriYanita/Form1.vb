Public Class Form1
    Dim yspeed As Integer = 0
    Dim gravity As Integer = 2
    Dim pipe(1) As PictureBox
    Dim toppipe(1) As PictureBox
    Dim gapBetweenPipes As Integer = 460
    Dim pipeSpeed As Single = 3.5
    Dim score As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Timer1.Enabled = True
        Timer2.Enabled = True
        createPipes(1)
        createTopPipes(1)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        yspeed += gravity
        bird.Top += yspeed
        For i = 0 To 1
            pipe(i).Left -= pipeSpeed
            toppipe(i).Left -= pipeSpeed
            If pipe(i).Left < 0 Then
                pipe(i).Left += 400
                toppipe(i).Left += 400
                pipe(i).Top = 70 + 290 * Rnd()
                toppipe(i).Top = pipe(i).Top - gapBetweenPipes
                My.Computer.Audio.Play(My.Resources.PointSound, AudioPlayMode.Background)
                label1.Text += 1
            End If
            If bird.Bounds.IntersectsWith(pipe(i).Bounds) Then
                Timer1.Stop()
                Timer2.Stop()
                My.Computer.Audio.Play(My.Resources.DieSound, AudioPlayMode.Background)
                picGameOver.Visible = True
                If MessageBox.Show("Apakah anda ingin bermain kembali?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    label1.Text = 0
                    Label4.Text = 0.00
                    Me.Controls.Clear()
                    InitializeComponent()
                    Form1_Load(e, e)

                Else
                    Form2.Show()
                End If
                picGameOver.Visible = False
            End If
            If bird.Bounds.IntersectsWith(toppipe(i).Bounds) Then
                Timer1.Stop()
                Timer2.Stop()
                My.Computer.Audio.Play(My.Resources.DieSound, AudioPlayMode.Background)
                picGameOver.Visible = True
                If MessageBox.Show("Apakah anda ingin bermain kembali?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    label1.Text = 0
                    Label4.Text = 0.00
                    Me.Controls.Clear()
                    InitializeComponent()
                    Form1_Load(e, e)

                Else
                    Form2.Show()
                End If
                picGameOver.Visible = False
            End If
        Next

        If bird.Bottom >= picGround.Top Then
            Timer1.Stop()
            Timer2.Stop()
            My.Computer.Audio.Play(My.Resources.DieSound, AudioPlayMode.Background)
            picGameOver.Visible = True
            If MessageBox.Show("Apakah anda ingin bermain kembali?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                label1.Text = 0
                Label4.Text = 0.00
                Me.Controls.Clear()
                InitializeComponent()
                Form1_Load(e, e)
            Else
                Form2.Show()
            End If
            picGameOver.Visible = False
        End If

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            yspeed = -14
            My.Computer.Audio.Play(My.Resources.JumpSound, AudioPlayMode.Background)
        End If

        If e.KeyCode = Keys.P Then
            Timer1.Stop()
            Timer2.Stop()
            lblPause.Visible = True
        End If
        If e.KeyCode = Keys.S Then
            Timer1.Start()
            Timer2.Start()
            lblPause.Visible = False
        End If
    End Sub

    Private Sub createPipes(ByVal number As Integer)
        Dim i As Integer = 0
        For i = 0 To number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Width = 50
            temp.Height = 350
            temp.BackColor = Color.Transparent
            temp.BackgroundImage = My.Resources.Pipe
            temp.BackgroundImageLayout = ImageLayout.Stretch
            temp.Top = 70 + 290 * Rnd()
            temp.Left = (i * 200) + 300
            pipe(i) = temp
            pipe(i).Visible = True
        Next
    End Sub

    Private Sub createTopPipes(ByVal number As Integer)
        Dim i As Integer = 0
        For i = 0 To number
            Dim temp As New PictureBox
            Me.Controls.Add(temp)
            temp.Width = 50
            temp.Height = 350
            temp.BackColor = Color.Transparent
            temp.BackgroundImage = My.Resources.PipeD
            temp.BackgroundImageLayout = ImageLayout.Stretch
            temp.Top = pipe(i).Top - gapBetweenPipes
            temp.Left = (i * 200) + 300
            toppipe(i) = temp
            toppipe(i).Visible = True
        Next
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label4.Text = Label4.Text + 0.01
    End Sub
End Class
