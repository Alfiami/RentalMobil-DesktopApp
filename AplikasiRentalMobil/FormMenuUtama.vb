Public Class FormMenuUtama

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPelangganToolStripMenuItem.Click
        datapelanggan.MdiParent = Me
        datapelanggan.Show()
    End Sub

    Private Sub DataMobilToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DataMobilToolStripMenuItem1.Click
        datamobil.MdiParent = Me
        datamobil.Show()
    End Sub

    Private Sub PembayaranToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem1.Click
        datapembayaran.MdiParent = Me
        datapembayaran.Show()
    End Sub

    Private Sub PengembalianToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem1.Click
        pengembalian.MdiParent = Me
        pengembalian.Show()
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class