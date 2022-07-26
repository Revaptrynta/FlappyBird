<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jackpot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jackpot))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPause = New System.Windows.Forms.Label()
        Me.bird = New System.Windows.Forms.PictureBox()
        Me.picGameOver = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.bird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGameOver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.label1.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Snow
        Me.label1.Location = New System.Drawing.Point(289, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(43, 47)
        Me.label1.TabIndex = 16
        Me.label1.Text = "0"
        '
        'Timer2
        '
        '
        'lblPause
        '
        Me.lblPause.AutoSize = True
        Me.lblPause.BackColor = System.Drawing.Color.Transparent
        Me.lblPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPause.Location = New System.Drawing.Point(112, 186)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(102, 33)
        Me.lblPause.TabIndex = 19
        Me.lblPause.Text = "Pause"
        Me.lblPause.Visible = False
        '
        'bird
        '
        Me.bird.BackColor = System.Drawing.Color.Transparent
        Me.bird.Image = CType(resources.GetObject("bird.Image"), System.Drawing.Image)
        Me.bird.Location = New System.Drawing.Point(12, 100)
        Me.bird.Name = "bird"
        Me.bird.Size = New System.Drawing.Size(39, 32)
        Me.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bird.TabIndex = 14
        Me.bird.TabStop = False
        '
        'picGameOver
        '
        Me.picGameOver.BackColor = System.Drawing.Color.Transparent
        Me.picGameOver.Image = CType(resources.GetObject("picGameOver.Image"), System.Drawing.Image)
        Me.picGameOver.Location = New System.Drawing.Point(80, 116)
        Me.picGameOver.Name = "picGameOver"
        Me.picGameOver.Size = New System.Drawing.Size(173, 50)
        Me.picGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGameOver.TabIndex = 18
        Me.picGameOver.TabStop = False
        Me.picGameOver.Visible = False
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.Transparent
        Me.picGround.BackgroundImage = CType(resources.GetObject("picGround.BackgroundImage"), System.Drawing.Image)
        Me.picGround.Location = New System.Drawing.Point(-8, 431)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(389, 143)
        Me.picGround.TabIndex = 15
        Me.picGround.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(97, 470)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(310, 512)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 33)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "00"
        '
        'Jackpot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(374, 557)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bird)
        Me.Controls.Add(Me.picGameOver)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.lblPause)
        Me.DoubleBuffered = True
        Me.Name = "Jackpot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jackpot"
        CType(Me.bird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGameOver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bird As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picGameOver As PictureBox
    Friend WithEvents label1 As Label
    Friend WithEvents picGround As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblPause As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
