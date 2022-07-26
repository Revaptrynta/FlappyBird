Imports MySql.Data.MySqlClient
Public Class Form3
    Dim Con As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim db As String
    Sub koneksi()
        db = "server=localhost;user id=root;password=;database=game"
        Con = New MySqlConnection(db)
        Con.Open()
    End Sub
    Sub tampil()
        Try
            koneksi()
            da = New MySqlDataAdapter("select *from flappy order by nama", Con)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "flappy")
            Me.DataGridView1.DataSource = (ds.Tables("flappy"))

        Catch ex As Exception
            MsgBox("Menampilkan data gagal")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Form2.Label3.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Form1.Label4.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Form2.Label1.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
    End Sub
    Sub bestscore()
        Label1.Text = (From row As DataGridViewRow In DataGridView1.Rows
                       Where row.Cells(2).FormattedValue.ToString() <> String.Empty
                       Select Convert.ToInt32(row.Cells(2).FormattedValue)
                         ).Max().ToString()
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        Call bestscore()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HomePlay.Show()
        Me.Hide()
    End Sub
End Class