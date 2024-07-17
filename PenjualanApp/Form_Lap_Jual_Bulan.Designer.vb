<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Lap_Jual_Bulan
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
		Me.lblBulan = New System.Windows.Forms.Label()
		Me.btnExport = New System.Windows.Forms.Button()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.btnView = New System.Windows.Forms.Button()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.crystalBulan = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
		Me.comBulan = New System.Windows.Forms.ComboBox()
		Me.comTahun = New System.Windows.Forms.ComboBox()
		Me.lblTahun = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'lblBulan
		'
		Me.lblBulan.AutoSize = true
		Me.lblBulan.BackColor = System.Drawing.Color.Transparent
		Me.lblBulan.Font = New System.Drawing.Font("JetBrains Mono NL", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblBulan.ForeColor = System.Drawing.Color.Transparent
		Me.lblBulan.Location = New System.Drawing.Point(600, 80)
		Me.lblBulan.Name = "lblBulan"
		Me.lblBulan.Size = New System.Drawing.Size(77, 27)
		Me.lblBulan.TabIndex = 48
		Me.lblBulan.Text = "Bulan"
		'
		'btnExport
		'
		Me.btnExport.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExport.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnExport.ForeColor = System.Drawing.Color.White
		Me.btnExport.Location = New System.Drawing.Point(8, 66)
		Me.btnExport.Name = "btnExport"
		Me.btnExport.Size = New System.Drawing.Size(146, 49)
		Me.btnExport.TabIndex = 46
		Me.btnExport.Text = "Export"
		Me.btnExport.UseVisualStyleBackColor = true
		'
		'btnPrint
		'
		Me.btnPrint.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPrint.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnPrint.ForeColor = System.Drawing.Color.White
		Me.btnPrint.Location = New System.Drawing.Point(208, 66)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(146, 49)
		Me.btnPrint.TabIndex = 45
		Me.btnPrint.Text = "Print"
		Me.btnPrint.UseVisualStyleBackColor = true
		'
		'btnView
		'
		Me.btnView.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnView.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnView.ForeColor = System.Drawing.Color.White
		Me.btnView.Location = New System.Drawing.Point(408, 66)
		Me.btnView.Name = "btnView"
		Me.btnView.Size = New System.Drawing.Size(146, 49)
		Me.btnView.TabIndex = 44
		Me.btnView.Text = "View"
		Me.btnView.UseVisualStyleBackColor = true
		'
		'Label9
		'
		Me.Label9.AutoSize = true
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.Font = New System.Drawing.Font("JetBrains Mono", 36!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label9.ForeColor = System.Drawing.Color.White
		Me.Label9.Location = New System.Drawing.Point(1048, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(752, 63)
		Me.Label9.TabIndex = 43
		Me.Label9.Text = "Laporan Penjualan Bulanan"
		'
		'crystalBulan
		'
		Me.crystalBulan.ActiveViewIndex = -1
		Me.crystalBulan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.crystalBulan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.crystalBulan.Cursor = System.Windows.Forms.Cursors.Default
		Me.crystalBulan.Location = New System.Drawing.Point(8, 130)
		Me.crystalBulan.Name = "crystalBulan"
		Me.crystalBulan.ShowGroupTreeButton = false
		Me.crystalBulan.Size = New System.Drawing.Size(1784, 646)
		Me.crystalBulan.TabIndex = 42
		Me.crystalBulan.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
		'
		'comBulan
		'
		Me.comBulan.Font = New System.Drawing.Font("JetBrains Mono NL", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comBulan.FormattingEnabled = true
		Me.comBulan.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
		Me.comBulan.Location = New System.Drawing.Point(680, 80)
		Me.comBulan.Name = "comBulan"
		Me.comBulan.Size = New System.Drawing.Size(168, 29)
		Me.comBulan.TabIndex = 49
		'
		'comTahun
		'
		Me.comTahun.Font = New System.Drawing.Font("JetBrains Mono NL", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comTahun.FormattingEnabled = true
		Me.comTahun.Items.AddRange(New Object() {"2023", "2024", "2025"})
		Me.comTahun.Location = New System.Drawing.Point(952, 80)
		Me.comTahun.Name = "comTahun"
		Me.comTahun.Size = New System.Drawing.Size(168, 29)
		Me.comTahun.TabIndex = 51
		'
		'lblTahun
		'
		Me.lblTahun.AutoSize = true
		Me.lblTahun.BackColor = System.Drawing.Color.Transparent
		Me.lblTahun.Font = New System.Drawing.Font("JetBrains Mono NL", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblTahun.ForeColor = System.Drawing.Color.Transparent
		Me.lblTahun.Location = New System.Drawing.Point(872, 80)
		Me.lblTahun.Name = "lblTahun"
		Me.lblTahun.Size = New System.Drawing.Size(77, 27)
		Me.lblTahun.TabIndex = 50
		Me.lblTahun.Text = "Tahun"
		'
		'Form_Lap_Jual_Bulan
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Background
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1801, 784)
		Me.Controls.Add(Me.comTahun)
		Me.Controls.Add(Me.lblTahun)
		Me.Controls.Add(Me.comBulan)
		Me.Controls.Add(Me.lblBulan)
		Me.Controls.Add(Me.btnExport)
		Me.Controls.Add(Me.btnPrint)
		Me.Controls.Add(Me.btnView)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.crystalBulan)
		Me.Name = "Form_Lap_Jual_Bulan"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form_Lap_Jual_Bulan"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents lblBulan As Label
	Friend WithEvents btnExport As Button
	Friend WithEvents btnPrint As Button
	Friend WithEvents btnView As Button
	Friend WithEvents Label9 As Label
	Friend WithEvents crystalBulan As CrystalDecisions.Windows.Forms.CrystalReportViewer
	Friend WithEvents comBulan As ComboBox
	Friend WithEvents comTahun As ComboBox
	Friend WithEvents lblTahun As Label
End Class
