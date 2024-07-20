<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_crud
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
		Me.gridViewMahasiswa = New System.Windows.Forms.DataGridView()
		Me.lblKode = New System.Windows.Forms.Label()
		Me.lblNama = New System.Windows.Forms.Label()
		Me.lblAlamat = New System.Windows.Forms.Label()
		Me.lblHP = New System.Windows.Forms.Label()
		Me.txtNIM = New System.Windows.Forms.TextBox()
		Me.txtNama = New System.Windows.Forms.TextBox()
		Me.txtAlamat = New System.Windows.Forms.TextBox()
		Me.txtHP = New System.Windows.Forms.TextBox()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.btnEdit = New System.Windows.Forms.Button()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnSearch = New System.Windows.Forms.Button()
		CType(Me.gridViewMahasiswa,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'gridViewMahasiswa
		'
		Me.gridViewMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.gridViewMahasiswa.Location = New System.Drawing.Point(8, 208)
		Me.gridViewMahasiswa.Name = "gridViewMahasiswa"
		Me.gridViewMahasiswa.Size = New System.Drawing.Size(1000, 416)
		Me.gridViewMahasiswa.TabIndex = 0
		'
		'lblKode
		'
		Me.lblKode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblKode.Font = New System.Drawing.Font("JetBrains Mono", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblKode.Location = New System.Drawing.Point(8, 24)
		Me.lblKode.Name = "lblKode"
		Me.lblKode.Size = New System.Drawing.Size(100, 23)
		Me.lblKode.TabIndex = 1
		Me.lblKode.Text = "NIM"
		'
		'lblNama
		'
		Me.lblNama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblNama.Font = New System.Drawing.Font("JetBrains Mono", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblNama.Location = New System.Drawing.Point(8, 56)
		Me.lblNama.Name = "lblNama"
		Me.lblNama.Size = New System.Drawing.Size(100, 23)
		Me.lblNama.TabIndex = 1
		Me.lblNama.Text = "NAMA"
		'
		'lblAlamat
		'
		Me.lblAlamat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAlamat.Font = New System.Drawing.Font("JetBrains Mono", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblAlamat.Location = New System.Drawing.Point(8, 88)
		Me.lblAlamat.Name = "lblAlamat"
		Me.lblAlamat.Size = New System.Drawing.Size(100, 23)
		Me.lblAlamat.TabIndex = 1
		Me.lblAlamat.Text = "ALAMAT"
		'
		'lblHP
		'
		Me.lblHP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblHP.Font = New System.Drawing.Font("JetBrains Mono", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblHP.Location = New System.Drawing.Point(8, 120)
		Me.lblHP.Name = "lblHP"
		Me.lblHP.Size = New System.Drawing.Size(100, 23)
		Me.lblHP.TabIndex = 1
		Me.lblHP.Text = "HANDPHONE"
		'
		'txtNIM
		'
		Me.txtNIM.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.txtNIM.Font = New System.Drawing.Font("JetBrains Mono NL", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNIM.Location = New System.Drawing.Point(120, 24)
		Me.txtNIM.Name = "txtNIM"
		Me.txtNIM.Size = New System.Drawing.Size(248, 27)
		Me.txtNIM.TabIndex = 1
		'
		'txtNama
		'
		Me.txtNama.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.txtNama.Font = New System.Drawing.Font("JetBrains Mono NL", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtNama.Location = New System.Drawing.Point(120, 56)
		Me.txtNama.Name = "txtNama"
		Me.txtNama.Size = New System.Drawing.Size(888, 27)
		Me.txtNama.TabIndex = 2
		'
		'txtAlamat
		'
		Me.txtAlamat.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.txtAlamat.Font = New System.Drawing.Font("JetBrains Mono NL", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtAlamat.Location = New System.Drawing.Point(120, 88)
		Me.txtAlamat.Name = "txtAlamat"
		Me.txtAlamat.Size = New System.Drawing.Size(888, 27)
		Me.txtAlamat.TabIndex = 3
		'
		'txtHP
		'
		Me.txtHP.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.txtHP.Font = New System.Drawing.Font("JetBrains Mono NL", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtHP.Location = New System.Drawing.Point(120, 120)
		Me.txtHP.Name = "txtHP"
		Me.txtHP.Size = New System.Drawing.Size(248, 27)
		Me.txtHP.TabIndex = 4
		'
		'btnSave
		'
		Me.btnSave.Font = New System.Drawing.Font("JetBrains Mono", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSave.Location = New System.Drawing.Point(592, 160)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(80, 32)
		Me.btnSave.TabIndex = 5
		Me.btnSave.Text = "SAVE"
		Me.btnSave.UseVisualStyleBackColor = true
		'
		'btnEdit
		'
		Me.btnEdit.Font = New System.Drawing.Font("JetBrains Mono", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnEdit.Location = New System.Drawing.Point(704, 160)
		Me.btnEdit.Name = "btnEdit"
		Me.btnEdit.Size = New System.Drawing.Size(80, 32)
		Me.btnEdit.TabIndex = 6
		Me.btnEdit.Text = "EDIT"
		Me.btnEdit.UseVisualStyleBackColor = true
		'
		'btnDelete
		'
		Me.btnDelete.Font = New System.Drawing.Font("JetBrains Mono", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnDelete.Location = New System.Drawing.Point(816, 160)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(80, 32)
		Me.btnDelete.TabIndex = 7
		Me.btnDelete.Text = "DELETE"
		Me.btnDelete.UseVisualStyleBackColor = true
		'
		'btnClose
		'
		Me.btnClose.Font = New System.Drawing.Font("JetBrains Mono", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnClose.Location = New System.Drawing.Point(928, 160)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(80, 32)
		Me.btnClose.TabIndex = 8
		Me.btnClose.Text = "CLOSE"
		Me.btnClose.UseVisualStyleBackColor = true
		'
		'btnSearch
		'
		Me.btnSearch.Font = New System.Drawing.Font("JetBrains Mono", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSearch.Location = New System.Drawing.Point(8, 160)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(80, 32)
		Me.btnSearch.TabIndex = 9
		Me.btnSearch.Text = "SEARCH"
		Me.btnSearch.UseVisualStyleBackColor = true
		'
		'form_crud
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1019, 632)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.btnEdit)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.txtHP)
		Me.Controls.Add(Me.txtAlamat)
		Me.Controls.Add(Me.txtNama)
		Me.Controls.Add(Me.txtNIM)
		Me.Controls.Add(Me.lblHP)
		Me.Controls.Add(Me.lblAlamat)
		Me.Controls.Add(Me.lblNama)
		Me.Controls.Add(Me.lblKode)
		Me.Controls.Add(Me.gridViewMahasiswa)
		Me.Name = "form_crud"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "CRUD"
		CType(Me.gridViewMahasiswa,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents gridViewMahasiswa As DataGridView
	Friend WithEvents lblKode As Label
	Friend WithEvents lblNama As Label
	Friend WithEvents lblAlamat As Label
	Friend WithEvents lblHP As Label
	Friend WithEvents txtNIM As TextBox
	Friend WithEvents txtNama As TextBox
	Friend WithEvents txtAlamat As TextBox
	Friend WithEvents txtHP As TextBox
	Friend WithEvents btnSave As Button
	Friend WithEvents btnEdit As Button
	Friend WithEvents btnDelete As Button
	Friend WithEvents btnClose As Button
	Friend WithEvents btnSearch As Button
End Class
