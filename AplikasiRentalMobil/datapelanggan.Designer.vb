<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class datapelanggan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.Label()
        Me.txtnotlp = New System.Windows.Forms.Label()
        Me.txtpelanggan = New System.Windows.Forms.TextBox()
        Me.txtalmt = New System.Windows.Forms.TextBox()
        Me.txtnotlpn = New System.Windows.Forms.TextBox()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.A2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New AplikasiRentalMobil.DataSet1()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btntmbh = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(545, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Pelanggan"
        '
        'txtnama
        '
        Me.txtnama.AutoSize = True
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(85, 100)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(145, 20)
        Me.txtnama.TabIndex = 1
        Me.txtnama.Text = "Nama Pelanggan"
        '
        'txtalamat
        '
        Me.txtalamat.AutoSize = True
        Me.txtalamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(85, 139)
        Me.txtalamat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(65, 20)
        Me.txtalamat.TabIndex = 2
        Me.txtalamat.Text = "Alamat"
        '
        'txtnotlp
        '
        Me.txtnotlp.AutoSize = True
        Me.txtnotlp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnotlp.Location = New System.Drawing.Point(773, 103)
        Me.txtnotlp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtnotlp.Name = "txtnotlp"
        Me.txtnotlp.Size = New System.Drawing.Size(70, 20)
        Me.txtnotlp.TabIndex = 3
        Me.txtnotlp.Text = "No Telp"
        '
        'txtpelanggan
        '
        Me.txtpelanggan.Location = New System.Drawing.Point(305, 100)
        Me.txtpelanggan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpelanggan.Name = "txtpelanggan"
        Me.txtpelanggan.Size = New System.Drawing.Size(325, 26)
        Me.txtpelanggan.TabIndex = 4
        '
        'txtalmt
        '
        Me.txtalmt.Location = New System.Drawing.Point(305, 136)
        Me.txtalmt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtalmt.Multiline = True
        Me.txtalmt.Name = "txtalmt"
        Me.txtalmt.Size = New System.Drawing.Size(325, 94)
        Me.txtalmt.TabIndex = 5
        '
        'txtnotlpn
        '
        Me.txtnotlpn.Location = New System.Drawing.Point(901, 103)
        Me.txtnotlpn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnotlpn.Name = "txtnotlpn"
        Me.txtnotlpn.Size = New System.Drawing.Size(325, 26)
        Me.txtnotlpn.TabIndex = 6
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.Maroon
        Me.btnhapus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnhapus.Location = New System.Drawing.Point(669, 265)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(103, 38)
        Me.btnhapus.TabIndex = 7
        Me.btnhapus.Text = "DELETE"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Maroon
        Me.btnupdate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnupdate.Location = New System.Drawing.Point(305, 268)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(103, 38)
        Me.btnupdate.TabIndex = 8
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'A2
        '
        Me.A2.BackColor = System.Drawing.Color.Maroon
        Me.A2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.A2.Location = New System.Drawing.Point(669, 217)
        Me.A2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(103, 38)
        Me.A2.TabIndex = 9
        Me.A2.Text = "RESET"
        Me.A2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Maroon
        Me.Button4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.Location = New System.Drawing.Point(1110, 268)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 38)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "SEARCH"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.Maroon
        Me.btnTambah.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTambah.Location = New System.Drawing.Point(195, 265)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(103, 38)
        Me.btnTambah.TabIndex = 12
        Me.btnTambah.Text = "INPUT"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(803, 271)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(300, 35)
        Me.TextBox1.TabIndex = 13
        '
        'btntmbh
        '
        Me.btntmbh.BackColor = System.Drawing.Color.Maroon
        Me.btntmbh.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btntmbh.Location = New System.Drawing.Point(66, 265)
        Me.btntmbh.Name = "btntmbh"
        Me.btntmbh.Size = New System.Drawing.Size(110, 38)
        Me.btntmbh.TabIndex = 14
        Me.btntmbh.Text = "TAMBAH"
        Me.btntmbh.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(61, 345)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1165, 315)
        Me.DataGridView1.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nama Pelanggan"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Alamat"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "No.Telp"
        Me.Column3.Name = "Column3"
        '
        'datapelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 696)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btntmbh)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.A2)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.txtnotlpn)
        Me.Controls.Add(Me.txtalmt)
        Me.Controls.Add(Me.txtpelanggan)
        Me.Controls.Add(Me.txtnotlp)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "datapelanggan"
        Me.Text = "datapelanggan"
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.Label
    Friend WithEvents txtalamat As System.Windows.Forms.Label
    Friend WithEvents txtnotlp As System.Windows.Forms.Label
    Friend WithEvents txtpelanggan As System.Windows.Forms.TextBox
    Friend WithEvents txtalmt As System.Windows.Forms.TextBox
    Friend WithEvents txtnotlpn As System.Windows.Forms.TextBox
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents A2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As AplikasiRentalMobil.DataSet1
    Friend WithEvents btntmbh As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
