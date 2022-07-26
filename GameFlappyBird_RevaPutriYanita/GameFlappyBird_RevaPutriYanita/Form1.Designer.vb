<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.bird = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picGameOver = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPause = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.bird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGameOver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bird
        '
        Me.bird.BackColor = System.Drawing.Color.Transparent
        Me.bird.Image = Global.GameFlappyBird_RevaPutriYanita.My.Resources.Resources.flappybirdflying
        Me.bird.Location = New System.Drawing.Point(34, 53)
        Me.bird.Name = "bird"
        Me.bird.Size = New System.Drawing.Size(39, 32)
        Me.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bird.TabIndex = 0
        Me.bird.TabStop = False
        '
        'Timer1
        '
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.Transparent
        Me.picGround.BackgroundImage = Global.GameFlappyBird_RevaPutriYanita.My.Resources.Resources.ground
        Me.picGround.Location = New System.Drawing.Point(0, 378)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(389, 110)
        Me.picGround.TabIndex = 1
        Me.picGround.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.label1.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Snow
        Me.label1.Location = New System.Drawing.Point(263, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(43, 47)
        Me.label1.TabIndex = 6
        Me.label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 465)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 18)
        Me.Label2.TabIndex = 7
        '
        'picGameOver
        '
        Me.picGameOver.BackColor = System.Drawing.Color.Transparent
        Me.picGameOver.Image = Global.GameFlappyBird_RevaPutriYanita.My.Resources.Resources.game_over
        Me.picGameOver.Location = New System.Drawing.Point(87, 118)
        Me.picGameOver.Name = "picGameOver"
        Me.picGameOver.Size = New System.Drawing.Size(173, 50)
        Me.picGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGameOver.TabIndex = 8
        Me.picGameOver.TabStop = False
        Me.picGameOver.Visible = False
        '
        'Timer2
        '
        '
        'lblPause
        '
        Me.lblPause.AutoSize = True
        Me.lblPause.BackColor = System.Drawing.Color.Transparent
        Me.lblPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPause.Location = New System.Drawing.Point(119, 188)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(102, 33)
        Me.lblPause.TabIndex = 11
        Me.lblPause.Text = "Pause"
        Me.lblPause.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(312, 451)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 33)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "0.00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GameFlappyBird_RevaPutriYanita.My.Resources.Resources.flappy_birds
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(387, 487)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPause)
        Me.Controls.Add(Me.picGameOver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.bird)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.bird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGameOver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bird As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picGround As PictureBox
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picGameOver As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblPause As Label
    Friend WithEvents Label4 As Label
End Class
