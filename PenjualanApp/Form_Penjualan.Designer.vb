<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Penjualan
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.gBoxTransaksi = New System.Windows.Forms.GroupBox()
		Me.gBoxGrandTotal = New System.Windows.Forms.GroupBox()
		Me.txtGrandTotal = New System.Windows.Forms.TextBox()
		Me.gBoxTransaksiDetail = New System.Windows.Forms.GroupBox()
		Me.txtKasir = New System.Windows.Forms.TextBox()
		Me.lblKasir = New System.Windows.Forms.Label()
		Me.txtTanggal = New System.Windows.Forms.TextBox()
		Me.lblTanggal = New System.Windows.Forms.Label()
		Me.txtJam = New System.Windows.Forms.TextBox()
		Me.lblJam = New System.Windows.Forms.Label()
		Me.txtNoFaktur = New System.Windows.Forms.TextBox()
		Me.lblNoFaktur = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.txtKembalian = New System.Windows.Forms.TextBox()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.lblKembalian = New System.Windows.Forms.Label()
		Me.txtDibayar = New System.Windows.Forms.TextBox()
		Me.lblDibayar = New System.Windows.Forms.Label()
		Me.dataGridViewPenjualan = New System.Windows.Forms.DataGridView()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.txtKodeBarang = New System.Windows.Forms.TextBox()
		Me.txtNamaBarang = New System.Windows.Forms.TextBox()
		Me.txtJenisBarang = New System.Windows.Forms.TextBox()
		Me.txtSatuan = New System.Windows.Forms.TextBox()
		Me.txtHargaJual = New System.Windows.Forms.TextBox()
		Me.txtQuantity = New System.Windows.Forms.TextBox()
		Me.txtTotalHarga = New System.Windows.Forms.TextBox()
		Me.timerJam = New System.Windows.Forms.Timer(Me.components)
		Me.gBoxTransaksi.SuspendLayout
		Me.gBoxGrandTotal.SuspendLayout
		Me.gBoxTransaksiDetail.SuspendLayout
		Me.GroupBox1.SuspendLayout
		CType(Me.dataGridViewPenjualan,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'gBoxTransaksi
		'
		Me.gBoxTransaksi.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.gBoxTransaksi.Controls.Add(Me.gBoxGrandTotal)
		Me.gBoxTransaksi.Controls.Add(Me.gBoxTransaksiDetail)
		Me.gBoxTransaksi.Dock = System.Windows.Forms.DockStyle.Top
		Me.gBoxTransaksi.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gBoxTransaksi.ForeColor = System.Drawing.Color.White
		Me.gBoxTransaksi.Location = New System.Drawing.Point(0, 0)
		Me.gBoxTransaksi.Name = "gBoxTransaksi"
		Me.gBoxTransaksi.Size = New System.Drawing.Size(1824, 276)
		Me.gBoxTransaksi.TabIndex = 0
		Me.gBoxTransaksi.TabStop = false
		'
		'gBoxGrandTotal
		'
		Me.gBoxGrandTotal.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.gBoxGrandTotal.Controls.Add(Me.txtGrandTotal)
		Me.gBoxGrandTotal.Dock = System.Windows.Forms.DockStyle.Fill
		Me.gBoxGrandTotal.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gBoxGrandTotal.ForeColor = System.Drawing.Color.White
		Me.gBoxGrandTotal.Location = New System.Drawing.Point(557, 29)
		Me.gBoxGrandTotal.Name = "gBoxGrandTotal"
		Me.gBoxGrandTotal.Size = New System.Drawing.Size(1264, 244)
		Me.gBoxGrandTotal.TabIndex = 12
		Me.gBoxGrandTotal.TabStop = false
		Me.gBoxGrandTotal.Text = "Grand Total"
		'
		'txtGrandTotal
		'
		Me.txtGrandTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.txtGrandTotal.BackColor = System.Drawing.Color.Black
		Me.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtGrandTotal.Font = New System.Drawing.Font("DS-Digital", 80.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtGrandTotal.ForeColor = System.Drawing.Color.Lime
		Me.txtGrandTotal.Location = New System.Drawing.Point(30, 47)
		Me.txtGrandTotal.Multiline = true
		Me.txtGrandTotal.Name = "txtGrandTotal"
		Me.txtGrandTotal.ReadOnly = true
		Me.txtGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGrandTotal.Size = New System.Drawing.Size(1211, 155)
		Me.txtGrandTotal.TabIndex = 17
		Me.txtGrandTotal.Text = "123.456.789"
		Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'gBoxTransaksiDetail
		'
		Me.gBoxTransaksiDetail.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.gBoxTransaksiDetail.Controls.Add(Me.txtKasir)
		Me.gBoxTransaksiDetail.Controls.Add(Me.lblKasir)
		Me.gBoxTransaksiDetail.Controls.Add(Me.txtTanggal)
		Me.gBoxTransaksiDetail.Controls.Add(Me.lblTanggal)
		Me.gBoxTransaksiDetail.Controls.Add(Me.txtJam)
		Me.gBoxTransaksiDetail.Controls.Add(Me.lblJam)
		Me.gBoxTransaksiDetail.Controls.Add(Me.txtNoFaktur)
		Me.gBoxTransaksiDetail.Controls.Add(Me.lblNoFaktur)
		Me.gBoxTransaksiDetail.Dock = System.Windows.Forms.DockStyle.Left
		Me.gBoxTransaksiDetail.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gBoxTransaksiDetail.ForeColor = System.Drawing.Color.White
		Me.gBoxTransaksiDetail.Location = New System.Drawing.Point(3, 29)
		Me.gBoxTransaksiDetail.Name = "gBoxTransaksiDetail"
		Me.gBoxTransaksiDetail.Size = New System.Drawing.Size(554, 244)
		Me.gBoxTransaksiDetail.TabIndex = 1
		Me.gBoxTransaksiDetail.TabStop = false
		Me.gBoxTransaksiDetail.Text = "Transaksi"
		'
		'txtKasir
		'
		Me.txtKasir.Location = New System.Drawing.Point(286, 169)
		Me.txtKasir.Name = "txtKasir"
		Me.txtKasir.ReadOnly = true
		Me.txtKasir.Size = New System.Drawing.Size(254, 33)
		Me.txtKasir.TabIndex = 16
		Me.txtKasir.Text = "anya"
		Me.txtKasir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblKasir
		'
		Me.lblKasir.AutoSize = true
		Me.lblKasir.BackColor = System.Drawing.Color.Transparent
		Me.lblKasir.Font = New System.Drawing.Font("JetBrains Mono", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblKasir.ForeColor = System.Drawing.Color.White
		Me.lblKasir.Location = New System.Drawing.Point(282, 145)
		Me.lblKasir.Name = "lblKasir"
		Me.lblKasir.Size = New System.Drawing.Size(60, 21)
		Me.lblKasir.TabIndex = 15
		Me.lblKasir.Text = "Kasir"
		'
		'txtTanggal
		'
		Me.txtTanggal.Location = New System.Drawing.Point(286, 83)
		Me.txtTanggal.Name = "txtTanggal"
		Me.txtTanggal.ReadOnly = true
		Me.txtTanggal.Size = New System.Drawing.Size(254, 33)
		Me.txtTanggal.TabIndex = 14
		Me.txtTanggal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblTanggal
		'
		Me.lblTanggal.AutoSize = true
		Me.lblTanggal.BackColor = System.Drawing.Color.Transparent
		Me.lblTanggal.Font = New System.Drawing.Font("JetBrains Mono", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTanggal.ForeColor = System.Drawing.Color.White
		Me.lblTanggal.Location = New System.Drawing.Point(282, 59)
		Me.lblTanggal.Name = "lblTanggal"
		Me.lblTanggal.Size = New System.Drawing.Size(80, 21)
		Me.lblTanggal.TabIndex = 13
		Me.lblTanggal.Text = "Tanggal"
		'
		'txtJam
		'
		Me.txtJam.Location = New System.Drawing.Point(15, 169)
		Me.txtJam.Name = "txtJam"
		Me.txtJam.ReadOnly = true
		Me.txtJam.Size = New System.Drawing.Size(254, 33)
		Me.txtJam.TabIndex = 12
		Me.txtJam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblJam
		'
		Me.lblJam.AutoSize = true
		Me.lblJam.BackColor = System.Drawing.Color.Transparent
		Me.lblJam.Font = New System.Drawing.Font("JetBrains Mono", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblJam.ForeColor = System.Drawing.Color.White
		Me.lblJam.Location = New System.Drawing.Point(11, 145)
		Me.lblJam.Name = "lblJam"
		Me.lblJam.Size = New System.Drawing.Size(40, 21)
		Me.lblJam.TabIndex = 11
		Me.lblJam.Text = "Jam"
		'
		'txtNoFaktur
		'
		Me.txtNoFaktur.Location = New System.Drawing.Point(15, 83)
		Me.txtNoFaktur.Name = "txtNoFaktur"
		Me.txtNoFaktur.ReadOnly = true
		Me.txtNoFaktur.Size = New System.Drawing.Size(254, 33)
		Me.txtNoFaktur.TabIndex = 10
		Me.txtNoFaktur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'lblNoFaktur
		'
		Me.lblNoFaktur.AutoSize = true
		Me.lblNoFaktur.BackColor = System.Drawing.Color.Transparent
		Me.lblNoFaktur.Font = New System.Drawing.Font("JetBrains Mono", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblNoFaktur.ForeColor = System.Drawing.Color.White
		Me.lblNoFaktur.Location = New System.Drawing.Point(11, 59)
		Me.lblNoFaktur.Name = "lblNoFaktur"
		Me.lblNoFaktur.Size = New System.Drawing.Size(130, 21)
		Me.lblNoFaktur.TabIndex = 9
		Me.lblNoFaktur.Text = "No Transaksi"
		'
		'GroupBox1
		'
		Me.GroupBox1.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.GroupBox1.Controls.Add(Me.btnClose)
		Me.GroupBox1.Controls.Add(Me.txtKembalian)
		Me.GroupBox1.Controls.Add(Me.btnDelete)
		Me.GroupBox1.Controls.Add(Me.btnSave)
		Me.GroupBox1.Controls.Add(Me.lblKembalian)
		Me.GroupBox1.Controls.Add(Me.txtDibayar)
		Me.GroupBox1.Controls.Add(Me.lblDibayar)
		Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.GroupBox1.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.GroupBox1.ForeColor = System.Drawing.Color.White
		Me.GroupBox1.Location = New System.Drawing.Point(0, 703)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(1824, 146)
		Me.GroupBox1.TabIndex = 11
		Me.GroupBox1.TabStop = false
		Me.GroupBox1.Text = "Pembayaran"
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.btnClose.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClose.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnClose.ForeColor = System.Drawing.Color.White
		Me.btnClose.Location = New System.Drawing.Point(1709, 55)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(107, 63)
		Me.btnClose.TabIndex = 31
		Me.btnClose.Text = "X"
		Me.btnClose.UseVisualStyleBackColor = true
		'
		'txtKembalian
		'
		Me.txtKembalian.BackColor = System.Drawing.Color.Black
		Me.txtKembalian.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtKembalian.Font = New System.Drawing.Font("DS-Digital", 48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtKembalian.ForeColor = System.Drawing.Color.Red
		Me.txtKembalian.Location = New System.Drawing.Point(468, 62)
		Me.txtKembalian.Multiline = true
		Me.txtKembalian.Name = "txtKembalian"
		Me.txtKembalian.ReadOnly = true
		Me.txtKembalian.Size = New System.Drawing.Size(408, 72)
		Me.txtKembalian.TabIndex = 30
		Me.txtKembalian.Text = "123.456.789"
		Me.txtKembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'btnDelete
		'
		Me.btnDelete.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDelete.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnDelete.ForeColor = System.Drawing.Color.White
		Me.btnDelete.Location = New System.Drawing.Point(1393, 62)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(146, 49)
		Me.btnDelete.TabIndex = 29
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = true
		'
		'btnSave
		'
		Me.btnSave.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSave.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSave.ForeColor = System.Drawing.Color.White
		Me.btnSave.Location = New System.Drawing.Point(1014, 62)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(146, 49)
		Me.btnSave.TabIndex = 27
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = true
		'
		'lblKembalian
		'
		Me.lblKembalian.AutoSize = true
		Me.lblKembalian.BackColor = System.Drawing.Color.Transparent
		Me.lblKembalian.Font = New System.Drawing.Font("JetBrains Mono", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblKembalian.ForeColor = System.Drawing.Color.White
		Me.lblKembalian.Location = New System.Drawing.Point(464, 38)
		Me.lblKembalian.Name = "lblKembalian"
		Me.lblKembalian.Size = New System.Drawing.Size(100, 21)
		Me.lblKembalian.TabIndex = 14
		Me.lblKembalian.Text = "Kembalian"
		'
		'txtDibayar
		'
		Me.txtDibayar.BackColor = System.Drawing.Color.Black
		Me.txtDibayar.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtDibayar.Font = New System.Drawing.Font("DS-Digital", 48!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtDibayar.ForeColor = System.Drawing.Color.Blue
		Me.txtDibayar.Location = New System.Drawing.Point(18, 62)
		Me.txtDibayar.Multiline = true
		Me.txtDibayar.Name = "txtDibayar"
		Me.txtDibayar.Size = New System.Drawing.Size(408, 72)
		Me.txtDibayar.TabIndex = 13
		Me.txtDibayar.Text = "123.456.789"
		Me.txtDibayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'lblDibayar
		'
		Me.lblDibayar.AutoSize = true
		Me.lblDibayar.BackColor = System.Drawing.Color.Transparent
		Me.lblDibayar.Font = New System.Drawing.Font("JetBrains Mono", 12!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblDibayar.ForeColor = System.Drawing.Color.White
		Me.lblDibayar.Location = New System.Drawing.Point(14, 38)
		Me.lblDibayar.Name = "lblDibayar"
		Me.lblDibayar.Size = New System.Drawing.Size(80, 21)
		Me.lblDibayar.TabIndex = 12
		Me.lblDibayar.Text = "Dibayar"
		'
		'dataGridViewPenjualan
		'
		Me.dataGridViewPenjualan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataGridViewPenjualan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dataGridViewPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridViewPenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
		Me.dataGridViewPenjualan.Location = New System.Drawing.Point(12, 352)
		Me.dataGridViewPenjualan.Name = "dataGridViewPenjualan"
		Me.dataGridViewPenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dataGridViewPenjualan.Size = New System.Drawing.Size(1800, 350)
		Me.dataGridViewPenjualan.TabIndex = 12
		Me.dataGridViewPenjualan.VirtualMode = true
		'
		'Column1
		'
		Me.Column1.HeaderText = "Kode Barang"
		Me.Column1.Name = "Column1"
		Me.Column1.Width = 200
		'
		'Column2
		'
		Me.Column2.HeaderText = "Nama Barang"
		Me.Column2.Name = "Column2"
		Me.Column2.Width = 400
		'
		'Column3
		'
		Me.Column3.HeaderText = "Jenis Barang"
		Me.Column3.Name = "Column3"
		Me.Column3.Width = 200
		'
		'Column4
		'
		Me.Column4.HeaderText = "Satuan"
		Me.Column4.Name = "Column4"
		'
		'Column5
		'
		Me.Column5.HeaderText = "Harga"
		Me.Column5.Name = "Column5"
		Me.Column5.Width = 150
		'
		'Column6
		'
		Me.Column6.HeaderText = "Qty"
		Me.Column6.Name = "Column6"
		'
		'Column7
		'
		Me.Column7.HeaderText = "Total Harga"
		Me.Column7.Name = "Column7"
		Me.Column7.Width = 200
		'
		'txtKodeBarang
		'
		Me.txtKodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtKodeBarang.Font = New System.Drawing.Font("JetBrains Mono", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtKodeBarang.Location = New System.Drawing.Point(51, 295)
		Me.txtKodeBarang.Name = "txtKodeBarang"
		Me.txtKodeBarang.Size = New System.Drawing.Size(203, 29)
		Me.txtKodeBarang.TabIndex = 13
		Me.txtKodeBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtNamaBarang
		'
		Me.txtNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtNamaBarang.Font = New System.Drawing.Font("JetBrains Mono", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNamaBarang.Location = New System.Drawing.Point(254, 295)
		Me.txtNamaBarang.Name = "txtNamaBarang"
		Me.txtNamaBarang.ReadOnly = true
		Me.txtNamaBarang.Size = New System.Drawing.Size(399, 29)
		Me.txtNamaBarang.TabIndex = 14
		'
		'txtJenisBarang
		'
		Me.txtJenisBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtJenisBarang.Font = New System.Drawing.Font("JetBrains Mono", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtJenisBarang.Location = New System.Drawing.Point(653, 295)
		Me.txtJenisBarang.Name = "txtJenisBarang"
		Me.txtJenisBarang.ReadOnly = true
		Me.txtJenisBarang.Size = New System.Drawing.Size(200, 29)
		Me.txtJenisBarang.TabIndex = 15
		'
		'txtSatuan
		'
		Me.txtSatuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtSatuan.Font = New System.Drawing.Font("JetBrains Mono", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtSatuan.Location = New System.Drawing.Point(853, 295)
		Me.txtSatuan.Name = "txtSatuan"
		Me.txtSatuan.ReadOnly = true
		Me.txtSatuan.Size = New System.Drawing.Size(99, 29)
		Me.txtSatuan.TabIndex = 16
		Me.txtSatuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtHargaJual
		'
		Me.txtHargaJual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtHargaJual.Font = New System.Drawing.Font("JetBrains Mono", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtHargaJual.Location = New System.Drawing.Point(952, 295)
		Me.txtHargaJual.Name = "txtHargaJual"
		Me.txtHargaJual.ReadOnly = true
		Me.txtHargaJual.Size = New System.Drawing.Size(152, 29)
		Me.txtHargaJual.TabIndex = 17
		Me.txtHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'txtQuantity
		'
		Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtQuantity.Font = New System.Drawing.Font("JetBrains Mono", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtQuantity.Location = New System.Drawing.Point(1104, 295)
		Me.txtQuantity.Name = "txtQuantity"
		Me.txtQuantity.Size = New System.Drawing.Size(100, 29)
		Me.txtQuantity.TabIndex = 18
		Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtTotalHarga
		'
		Me.txtTotalHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtTotalHarga.Font = New System.Drawing.Font("JetBrains Mono", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtTotalHarga.Location = New System.Drawing.Point(1204, 295)
		Me.txtTotalHarga.Name = "txtTotalHarga"
		Me.txtTotalHarga.ReadOnly = true
		Me.txtTotalHarga.Size = New System.Drawing.Size(200, 29)
		Me.txtTotalHarga.TabIndex = 19
		Me.txtTotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'timerJam
		'
		Me.timerJam.Enabled = true
		Me.timerJam.Interval = 1000
		'
		'Form_Penjualan
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Background
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1824, 849)
		Me.Controls.Add(Me.txtTotalHarga)
		Me.Controls.Add(Me.txtQuantity)
		Me.Controls.Add(Me.txtHargaJual)
		Me.Controls.Add(Me.txtSatuan)
		Me.Controls.Add(Me.txtJenisBarang)
		Me.Controls.Add(Me.txtNamaBarang)
		Me.Controls.Add(Me.txtKodeBarang)
		Me.Controls.Add(Me.dataGridViewPenjualan)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.gBoxTransaksi)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Form_Penjualan"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form_Penjualan"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.gBoxTransaksi.ResumeLayout(false)
		Me.gBoxGrandTotal.ResumeLayout(false)
		Me.gBoxGrandTotal.PerformLayout
		Me.gBoxTransaksiDetail.ResumeLayout(false)
		Me.gBoxTransaksiDetail.PerformLayout
		Me.GroupBox1.ResumeLayout(false)
		Me.GroupBox1.PerformLayout
		CType(Me.dataGridViewPenjualan,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents gBoxTransaksi As GroupBox
	Friend WithEvents gBoxTransaksiDetail As GroupBox
	
	Friend WithEvents gBoxGrandTotal As GroupBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents lblNoFaktur As Label
	Friend WithEvents txtNoFaktur As TextBox
	Friend WithEvents txtTanggal As TextBox
	Friend WithEvents lblTanggal As Label
	Friend WithEvents txtJam As TextBox
	Friend WithEvents lblJam As Label
	Friend WithEvents txtKasir As TextBox
	Friend WithEvents lblKasir As Label
	Friend WithEvents lblKembalian As Label
	Friend WithEvents txtDibayar As TextBox
	Friend WithEvents lblDibayar As Label
	Friend WithEvents btnSave As Button
	Friend WithEvents btnDelete As Button
	Friend WithEvents txtGrandTotal As TextBox
	Friend WithEvents txtKembalian As TextBox
	Friend WithEvents btnClose As Button
	Friend WithEvents dataGridViewPenjualan As DataGridView
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
	Friend WithEvents Column2 As DataGridViewTextBoxColumn
	Friend WithEvents Column3 As DataGridViewTextBoxColumn
	Friend WithEvents Column4 As DataGridViewTextBoxColumn
	Friend WithEvents Column5 As DataGridViewTextBoxColumn
	Friend WithEvents Column6 As DataGridViewTextBoxColumn
	Friend WithEvents Column7 As DataGridViewTextBoxColumn
	Friend WithEvents txtKodeBarang As TextBox
	Friend WithEvents txtNamaBarang As TextBox
	Friend WithEvents txtJenisBarang As TextBox
	Friend WithEvents txtSatuan As TextBox
	Friend WithEvents txtHargaJual As TextBox
	Friend WithEvents txtQuantity As TextBox
	Friend WithEvents txtTotalHarga As TextBox
	Friend WithEvents timerJam As Timer
End Class
