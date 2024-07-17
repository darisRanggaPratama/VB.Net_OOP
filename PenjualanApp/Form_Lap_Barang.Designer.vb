<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Lap_Barang
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
		Me.crystalBarang = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.btnView = New System.Windows.Forms.Button()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.btnExport = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'crystalBarang
		'
		Me.crystalBarang.ActiveViewIndex = -1
		Me.crystalBarang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.crystalBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.crystalBarang.Cursor = System.Windows.Forms.Cursors.Default
		Me.crystalBarang.Location = New System.Drawing.Point(8, 152)
		Me.crystalBarang.Name = "crystalBarang"
		Me.crystalBarang.ShowGroupTreeButton = false
		Me.crystalBarang.Size = New System.Drawing.Size(1432, 632)
		Me.crystalBarang.TabIndex = 0
		Me.crystalBarang.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
		'
		'Label9
		'
		Me.Label9.AutoSize = true
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.Font = New System.Drawing.Font("JetBrains Mono", 36!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Label9.ForeColor = System.Drawing.Color.White
		Me.Label9.Location = New System.Drawing.Point(880, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(578, 63)
		Me.Label9.TabIndex = 31
		Me.Label9.Text = "Laporan Data Barang"
		'
		'btnView
		'
		Me.btnView.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnView.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnView.ForeColor = System.Drawing.Color.White
		Me.btnView.Location = New System.Drawing.Point(8, 88)
		Me.btnView.Name = "btnView"
		Me.btnView.Size = New System.Drawing.Size(146, 49)
		Me.btnView.TabIndex = 32
		Me.btnView.Text = "View"
		Me.btnView.UseVisualStyleBackColor = true
		'
		'btnPrint
		'
		Me.btnPrint.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnPrint.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnPrint.ForeColor = System.Drawing.Color.White
		Me.btnPrint.Location = New System.Drawing.Point(208, 88)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(146, 49)
		Me.btnPrint.TabIndex = 33
		Me.btnPrint.Text = "Print"
		Me.btnPrint.UseVisualStyleBackColor = true
		'
		'btnExport
		'
		Me.btnExport.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Warna
		Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExport.Font = New System.Drawing.Font("JetBrains Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnExport.ForeColor = System.Drawing.Color.White
		Me.btnExport.Location = New System.Drawing.Point(408, 88)
		Me.btnExport.Name = "btnExport"
		Me.btnExport.Size = New System.Drawing.Size(146, 49)
		Me.btnExport.TabIndex = 34
		Me.btnExport.Text = "Export"
		Me.btnExport.UseVisualStyleBackColor = true
		'
		'Form_Lap_Barang
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.PenjualanApp.My.Resources.Resources.Background
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(1450, 798)
		Me.Controls.Add(Me.btnExport)
		Me.Controls.Add(Me.btnPrint)
		Me.Controls.Add(Me.btnView)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.crystalBarang)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "Form_Lap_Barang"
		Me.ShowInTaskbar = false
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Form_Lap_Barang"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents crystalBarang As CrystalDecisions.Windows.Forms.CrystalReportViewer
	Friend WithEvents Label9 As Label
	Friend WithEvents btnView As Button
	Friend WithEvents btnPrint As Button
	Friend WithEvents btnExport As Button
End Class
