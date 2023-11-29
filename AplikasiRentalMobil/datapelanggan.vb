Imports System.Data.Odbc
Public Class datapelanggan
    Sub tampil_data()
        DA = New OdbcDataAdapter("SELECT * FROM rentalmobil1", konek)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
        DataGridView1.ReadOnly = True
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 200




    End Sub

    Sub databaru()
        txtpelanggan.Clear()
        txtalmt.Clear()
        txtnotlpn.Clear()
        txtpelanggan.Focus()
    End Sub
    Sub bersihkan()
        txtpelanggan.Clear()
        txtalmt.Clear()
        txtnotlpn.Clear()
        txtpelanggan.Focus()
    End Sub
    Private Property queri As String

    Private Sub datapelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KonekDB()
        Call tampil_data()
        Call bersihkan()
        txtpelanggan.Enabled = False
    End Sub
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call databaru()
    End Sub
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Call KonekDB()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btntmbh.Click

    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs)

    End Sub
End Class