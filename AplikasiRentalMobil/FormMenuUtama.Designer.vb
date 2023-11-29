<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataMobilToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengembalianToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiwayarTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataMobilToolStripMenuItem, Me.PembayaranToolStripMenuItem, Me.PengembalianToolStripMenuItem, Me.RiwayarTransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1065, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPelangganToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(137, 29)
        Me.FileToolStripMenuItem.Text = "File Pelanggan"
        '
        'DataPelangganToolStripMenuItem
        '
        Me.DataPelangganToolStripMenuItem.Name = "DataPelangganToolStripMenuItem"
        Me.DataPelangganToolStripMenuItem.Size = New System.Drawing.Size(220, 30)
        Me.DataPelangganToolStripMenuItem.Text = "Data Pelanggan"
        '
        'DataMobilToolStripMenuItem
        '
        Me.DataMobilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMobilToolStripMenuItem1})
        Me.DataMobilToolStripMenuItem.Name = "DataMobilToolStripMenuItem"
        Me.DataMobilToolStripMenuItem.Size = New System.Drawing.Size(112, 29)
        Me.DataMobilToolStripMenuItem.Text = "Data Mobil"
        '
        'DataMobilToolStripMenuItem1
        '
        Me.DataMobilToolStripMenuItem1.Name = "DataMobilToolStripMenuItem1"
        Me.DataMobilToolStripMenuItem1.Size = New System.Drawing.Size(184, 30)
        Me.DataMobilToolStripMenuItem1.Text = "Data Mobil"
        '
        'PembayaranToolStripMenuItem
        '
        Me.PembayaranToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembayaranToolStripMenuItem1})
        Me.PembayaranToolStripMenuItem.Name = "PembayaranToolStripMenuItem"
        Me.PembayaranToolStripMenuItem.Size = New System.Drawing.Size(121, 29)
        Me.PembayaranToolStripMenuItem.Text = "Pembayaran"
        '
        'PembayaranToolStripMenuItem1
        '
        Me.PembayaranToolStripMenuItem1.Name = "PembayaranToolStripMenuItem1"
        Me.PembayaranToolStripMenuItem1.Size = New System.Drawing.Size(193, 30)
        Me.PembayaranToolStripMenuItem1.Text = "Pembayaran"
        '
        'PengembalianToolStripMenuItem
        '
        Me.PengembalianToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengembalianToolStripMenuItem1})
        Me.PengembalianToolStripMenuItem.Name = "PengembalianToolStripMenuItem"
        Me.PengembalianToolStripMenuItem.Size = New System.Drawing.Size(135, 29)
        Me.PengembalianToolStripMenuItem.Text = "Pengembalian"
        '
        'PengembalianToolStripMenuItem1
        '
        Me.PengembalianToolStripMenuItem1.Name = "PengembalianToolStripMenuItem1"
        Me.PengembalianToolStripMenuItem1.Size = New System.Drawing.Size(207, 30)
        Me.PengembalianToolStripMenuItem1.Text = "Pengembalian"
        '
        'RiwayarTransaksiToolStripMenuItem
        '
        Me.RiwayarTransaksiToolStripMenuItem.Name = "RiwayarTransaksiToolStripMenuItem"
        Me.RiwayarTransaksiToolStripMenuItem.Size = New System.Drawing.Size(160, 29)
        Me.RiwayarTransaksiToolStripMenuItem.Text = "Riwayar Transaksi"
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 588)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormMenuUtama"
        Me.Text = "FormMenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataMobilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembayaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataMobilToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembayaranToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RiwayarTransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
