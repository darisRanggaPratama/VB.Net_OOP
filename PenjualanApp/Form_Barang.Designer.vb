<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Barang
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.dataGridViewBarang = New System.Windows.Forms.DataGridView()
		Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.btnTambah = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtSearch = New System.Windows.Forms.TextBox()
		CType(Me.dataGridViewBarang,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'Label1
		'
		Me.Label1.AutoSize = true
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("JetBrains Mono", 36!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(1341, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(346, 63)
		Me.Label1.TabIndex = 8
		Me.Label1.Text = "Data Barang"
		'
		'btnClose
		'
		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.btnClose.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClose.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnClose.ForeColor = System.Drawing.Color.White
		Me.btnClose.Location = New System.Drawing.Point(1693, 9)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(127, 76)
		Me.btnClose.TabIndex = 9
		Me.btnClose.Text = "X"
		Me.btnClose.UseVisualStyleBackColor = true
		'
		'dataGridViewBarang
		'
		Me.dataGridViewBarang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("JetBrains Mono", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dataGridViewBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		Me.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridViewBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
		Me.dataGridViewBarang.Location = New System.Drawing.Point(12, 207)
		Me.dataGridViewBarang.Name = "dataGridViewBarang"
		Me.dataGridViewBarang.Size = New System.Drawing.Size(1799, 574)
		Me.dataGridViewBarang.TabIndex = 10
		'
		'Column1
		'
		Me.Column1.HeaderText = "Kode"
		Me.Column1.Name = "Column1"
		Me.Column1.Width = 150
		'
		'Column2
		'
		Me.Column2.HeaderText = "Nama Barang"
		Me.Column2.Name = "Column2"
		Me.Column2.Width = 400
		'
		'Column3
		'
		Me.Column3.HeaderText = "Jenis"
		Me.Column3.Name = "Column3"
		'
		'Column4
		'
		Me.Column4.HeaderText = "Satuan"
		Me.Column4.Name = "Column4"
		'
		'Column5
		'
		Me.Column5.HeaderText = "Harga Beli"
		Me.Column5.Name = "Column5"
		Me.Column5.Width = 150
		'
		'Column6
		'
		Me.Column6.HeaderText = "Harga Jual"
		Me.Column6.Name = "Column6"
		Me.Column6.Width = 150
		'
		'Column7
		'
		Me.Column7.HeaderText = "Stok"
		Me.Column7.Name = "Column7"
		'
		'btnTambah
		'
		Me.btnTambah.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnTambah.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnTambah.ForeColor = System.Drawing.Color.White
		Me.btnTambah.Location = New System.Drawing.Point(12, 138)
		Me.btnTambah.Name = "btnTambah"
		Me.btnTambah.Size = New System.Drawing.Size(146, 49)
		Me.btnTambah.TabIndex = 11
		Me.btnTambah.Text = "Tambah"
		Me.btnTambah.UseVisualStyleBackColor = true
		'
		'Label2
		'
		Me.Label2.AutoSize = true
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("JetBrains Mono", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
		Me.Label2.Location = New System.Drawing.Point(190, 151)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(111, 36)
		Me.Label2.TabIndex = 12
		Me.Label2.Text = "Search"
		'
		'txtSearch
		'
		Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtSearch.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtSearch.Location = New System.Drawing.Point(307, 155)
		Me.txtSearch.Name = "txtSearch"
		Me.txtSearch.Size = New System.Drawing.Size(732, 33)
		Me.txtSearch.TabIndex = 13
		'
		'Form_Barang
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Background
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1823, 853)
		Me.Controls.Add(Me.txtSearch)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.btnTambah)
		Me.Controls.Add(Me.dataGridViewBarang)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Form_Barang"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form_Barang"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.dataGridViewBarang,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents btnClose As Button
	Friend WithEvents dataGridViewBarang As DataGridView
	Friend WithEvents btnTambah As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents txtSearch As TextBox
	Friend WithEvents Column1 As DataGridViewTextBoxColumn
	Friend WithEvents Column2 As DataGridViewTextBoxColumn
	Friend WithEvents Column3 As DataGridViewTextBoxColumn
	Friend WithEvents Column4 As DataGridViewTextBoxColumn
	Friend WithEvents Column5 As DataGridViewTextBoxColumn
	Friend WithEvents Column6 As DataGridViewTextBoxColumn
	Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
