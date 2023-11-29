Public Class datamobil

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles A1.Click
        Dim A1 As String
        A1 = MessageBox.Show("APAKAH ANDA INGIN MENGHAPUSNYA", "HAPUS DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If A1 = vbYes Then
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub datamobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class