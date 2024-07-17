<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Lap_Jual_Harian
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
		Me.btnExport = New System.Windows.Forms.Button()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.btnView = New System.Windows.Forms.Button()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.crystalHarian = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
		Me.pickerJualHari = New System.Windows.Forms.DateTimePicker()
		Me.lblTanggal = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'btnExport
		'
		Me.btnExport.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExport.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnExport.ForeColor = System.Drawing.Color.White
		Me.btnExport.Location = New System.Drawing.Point(8, 80)
		Me.btnExport.Name = "btnExport"
		Me.btnExport.Size = New System.Drawing.Size(146, 49)
		Me.btnExport.TabIndex = 39
		Me.btnExport.Text = "Export"
		Me.btnExport.UseVisualStyleBackColor = true
		'
		'btnPrint
		'
		Me.btnPrint.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPrint.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnPrint.ForeColor = System.Drawing.Color.White
		Me.btnPrint.Location = New System.Drawing.Point(208, 80)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(146, 49)
		Me.btnPrint.TabIndex = 38
		Me.btnPrint.Text = "Print"
		Me.btnPrint.UseVisualStyleBackColor = true
		'
		'btnView
		'
		Me.btnView.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnView.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnView.ForeColor = System.Drawing.Color.White
		Me.btnView.Location = New System.Drawing.Point(408, 80)
		Me.btnView.Name = "btnView"
		Me.btnView.Size = New System.Drawing.Size(146, 49)
		Me.btnView.TabIndex = 37
		Me.btnView.Text = "View"
		Me.btnView.UseVisualStyleBackColor = true
		'
		'Label9
		'
		Me.Label9.AutoSize = true
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.Font = New System.Drawing.Font("JetBrains Mono", 36!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label9.ForeColor = System.Drawing.Color.White
		Me.Label9.Location = New System.Drawing.Point(1088, 14)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(723, 63)
		Me.Label9.TabIndex = 36
		Me.Label9.Text = "Laporan Penjualan Harian"
		'
		'crystalHarian
		'
		Me.crystalHarian.ActiveViewIndex = -1
		Me.crystalHarian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.crystalHarian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.crystalHarian.Cursor = System.Windows.Forms.Cursors.Default
		Me.crystalHarian.Location = New System.Drawing.Point(8, 144)
		Me.crystalHarian.Name = "crystalHarian"
		Me.crystalHarian.ShowGroupTreeButton = false
		Me.crystalHarian.Size = New System.Drawing.Size(1792, 654)
		Me.crystalHarian.TabIndex = 35
		Me.crystalHarian.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
		'
		'pickerJualHari
		'
		Me.pickerJualHari.CustomFormat = "dd/MM/yyyy"
		Me.pickerJualHari.Font = New System.Drawing.Font("JetBrains Mono NL", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.pickerJualHari.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.pickerJualHari.Location = New System.Drawing.Point(608, 88)
		Me.pickerJualHari.Name = "pickerJualHari"
		Me.pickerJualHari.Size = New System.Drawing.Size(152, 29)
		Me.pickerJualHari.TabIndex = 40
		'
		'lblTanggal
		'
		Me.lblTanggal.AutoSize = true
		Me.lblTanggal.BackColor = System.Drawing.Color.Transparent
		Me.lblTanggal.Font = New System.Drawing.Font("JetBrains Mono NL", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTanggal.ForeColor = System.Drawing.Color.Transparent
		Me.lblTanggal.Location = New System.Drawing.Point(776, 88)
		Me.lblTanggal.Name = "lblTanggal"
		Me.lblTanggal.Size = New System.Drawing.Size(103, 27)
		Me.lblTanggal.TabIndex = 41
		Me.lblTanggal.Text = "Tanggal"
		'
		'Form_Lap_Jual_Harian
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Background
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1806, 812)
		Me.Controls.Add(Me.lblTanggal)
		Me.Controls.Add(Me.pickerJualHari)
		Me.Controls.Add(Me.btnExport)
		Me.Controls.Add(Me.btnPrint)
		Me.Controls.Add(Me.btnView)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.crystalHarian)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "Form_Lap_Jual_Harian"
		Me.Text = "Form_Lap_Jual_Harian"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents btnExport As Button
	Friend WithEvents btnPrint As Button
	Friend WithEvents btnView As Button
	Friend WithEvents Label9 As Label
	Friend WithEvents crystalHarian As CrystalDecisions.Windows.Forms.CrystalReportViewer
	Friend WithEvents pickerJualHari As DateTimePicker
	Friend WithEvents lblTanggal As Label
End Class
