<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Input_Barang
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtKodeBarang = New System.Windows.Forms.TextBox()
		Me.txtNamaBarang = New System.Windows.Forms.TextBox()
		Me.txtHargaBeli = New System.Windows.Forms.TextBox()
		Me.txtHargaJual = New System.Windows.Forms.TextBox()
		Me.txtStok = New System.Windows.Forms.TextBox()
		Me.cboxJenis = New System.Windows.Forms.ComboBox()
		Me.cboxSatuan = New System.Windows.Forms.ComboBox()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'Label1
		'
		Me.Label1.AutoSize = true
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("JetBrains Mono", 36!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(1432, 4)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(375, 63)
		Me.Label1.TabIndex = 9
		Me.Label1.Text = "Input Barang"
		'
		'Label2
		'
		Me.Label2.AutoSize = true
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label2.Location = New System.Drawing.Point(30, 129)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(133, 25)
		Me.Label2.TabIndex = 10
		Me.Label2.Text = "Kode Barang"
		'
		'Label3
		'
		Me.Label3.AutoSize = true
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label3.Location = New System.Drawing.Point(30, 181)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(133, 25)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "Nama Barang"
		'
		'Label4
		'
		Me.Label4.AutoSize = true
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label4.Location = New System.Drawing.Point(30, 285)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(78, 25)
		Me.Label4.TabIndex = 13
		Me.Label4.Text = "Satuan"
		'
		'Label5
		'
		Me.Label5.AutoSize = true
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label5.Location = New System.Drawing.Point(30, 233)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(144, 25)
		Me.Label5.TabIndex = 12
		Me.Label5.Text = "Jenis Barang"
		'
		'Label6
		'
		Me.Label6.AutoSize = true
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label6.Location = New System.Drawing.Point(30, 389)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(122, 25)
		Me.Label6.TabIndex = 15
		Me.Label6.Text = "Harga Jual"
		'
		'Label7
		'
		Me.Label7.AutoSize = true
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label7.Location = New System.Drawing.Point(30, 337)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(122, 25)
		Me.Label7.TabIndex = 14
		Me.Label7.Text = "Harga Beli"
		'
		'Label8
		'
		Me.Label8.AutoSize = true
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label8.Location = New System.Drawing.Point(30, 444)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(56, 25)
		Me.Label8.TabIndex = 16
		Me.Label8.Text = "Stok"
		'
		'txtKodeBarang
		'
		Me.txtKodeBarang.BackColor = System.Drawing.Color.White
		Me.txtKodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtKodeBarang.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtKodeBarang.Location = New System.Drawing.Point(200, 127)
		Me.txtKodeBarang.Name = "txtKodeBarang"
		Me.txtKodeBarang.Size = New System.Drawing.Size(519, 33)
		Me.txtKodeBarang.TabIndex = 17
		'
		'txtNamaBarang
		'
		Me.txtNamaBarang.BackColor = System.Drawing.Color.White
		Me.txtNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtNamaBarang.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNamaBarang.Location = New System.Drawing.Point(200, 179)
		Me.txtNamaBarang.Name = "txtNamaBarang"
		Me.txtNamaBarang.Size = New System.Drawing.Size(519, 33)
		Me.txtNamaBarang.TabIndex = 18
		'
		'txtHargaBeli
		'
		Me.txtHargaBeli.BackColor = System.Drawing.Color.White
		Me.txtHargaBeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtHargaBeli.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtHargaBeli.Location = New System.Drawing.Point(200, 335)
		Me.txtHargaBeli.Name = "txtHargaBeli"
		Me.txtHargaBeli.Size = New System.Drawing.Size(519, 33)
		Me.txtHargaBeli.TabIndex = 21
		'
		'txtHargaJual
		'
		Me.txtHargaJual.BackColor = System.Drawing.Color.White
		Me.txtHargaJual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtHargaJual.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtHargaJual.Location = New System.Drawing.Point(200, 387)
		Me.txtHargaJual.Name = "txtHargaJual"
		Me.txtHargaJual.Size = New System.Drawing.Size(519, 33)
		Me.txtHargaJual.TabIndex = 22
		'
		'txtStok
		'
		Me.txtStok.BackColor = System.Drawing.Color.White
		Me.txtStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtStok.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtStok.Location = New System.Drawing.Point(200, 442)
		Me.txtStok.Name = "txtStok"
		Me.txtStok.Size = New System.Drawing.Size(519, 33)
		Me.txtStok.TabIndex = 23
		'
		'cboxJenis
		'
		Me.cboxJenis.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cboxJenis.FormattingEnabled = true
		Me.cboxJenis.Items.AddRange(New Object() {"Food", "Drink", "Stationary", "Kitchen Set"})
		Me.cboxJenis.Location = New System.Drawing.Point(200, 230)
		Me.cboxJenis.Name = "cboxJenis"
		Me.cboxJenis.Size = New System.Drawing.Size(519, 33)
		Me.cboxJenis.TabIndex = 24
		'
		'cboxSatuan
		'
		Me.cboxSatuan.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.cboxSatuan.FormattingEnabled = true
		Me.cboxSatuan.Items.AddRange(New Object() {"Pcs", "Lusin", "Kodi", "Bungkus", "Pack"})
		Me.cboxSatuan.Location = New System.Drawing.Point(200, 282)
		Me.cboxSatuan.Name = "cboxSatuan"
		Me.cboxSatuan.Size = New System.Drawing.Size(519, 33)
		Me.cboxSatuan.TabIndex = 25
		'
		'btnSave
		'
		Me.btnSave.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSave.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSave.ForeColor = System.Drawing.Color.White
		Me.btnSave.Location = New System.Drawing.Point(35, 628)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(146, 49)
		Me.btnSave.TabIndex = 26
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = true
		'
		'btnClear
		'
		Me.btnClear.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClear.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnClear.ForeColor = System.Drawing.Color.White
		Me.btnClear.Location = New System.Drawing.Point(234, 628)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(146, 49)
		Me.btnClear.TabIndex = 27
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = true
		'
		'btnDelete
		'
		Me.btnDelete.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnDelete.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnDelete.ForeColor = System.Drawing.Color.White
		Me.btnDelete.Location = New System.Drawing.Point(573, 628)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(146, 49)
		Me.btnDelete.TabIndex = 28
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = true
		'
		'btnClose
		'
		Me.btnClose.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnClose.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnClose.ForeColor = System.Drawing.Color.White
		Me.btnClose.Location = New System.Drawing.Point(686, 12)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(66, 49)
		Me.btnClose.TabIndex = 29
		Me.btnClose.Text = "X"
		Me.btnClose.UseVisualStyleBackColor = true
		'
		'Label9
		'
		Me.Label9.AutoSize = true
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.Font = New System.Drawing.Font("JetBrains Mono", 36!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label9.ForeColor = System.Drawing.Color.White
		Me.Label9.Location = New System.Drawing.Point(149, 9)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(520, 63)
		Me.Label9.TabIndex = 30
		Me.Label9.Text = "Input Data Barang"
		'
		'Form_Input_Barang
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Background
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(764, 762)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.cboxSatuan)
		Me.Controls.Add(Me.cboxJenis)
		Me.Controls.Add(Me.txtStok)
		Me.Controls.Add(Me.txtHargaJual)
		Me.Controls.Add(Me.txtHargaBeli)
		Me.Controls.Add(Me.txtNamaBarang)
		Me.Controls.Add(Me.txtKodeBarang)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "Form_Input_Barang"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form_Input_Barang"
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents txtKodeBarang As TextBox
	Friend WithEvents txtNamaBarang As TextBox
	Friend WithEvents txtHargaBeli As TextBox
	Friend WithEvents txtHargaJual As TextBox
	Friend WithEvents txtStok As TextBox
	Friend WithEvents cboxJenis As ComboBox
	Friend WithEvents cboxSatuan As ComboBox
	Friend WithEvents btnSave As Button
	Friend WithEvents btnClear As Button
	Friend WithEvents btnDelete As Button
	Friend WithEvents btnClose As Button
	Friend WithEvents Label9 As Label
End Class
