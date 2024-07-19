<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAnggota
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
		Me.dataGridAnggota = New System.Windows.Forms.DataGridView()
		CType(Me.dataGridAnggota,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'dataGridAnggota
		'
		Me.dataGridAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dataGridAnggota.Location = New System.Drawing.Point(8, 56)
		Me.dataGridAnggota.Name = "dataGridAnggota"
		Me.dataGridAnggota.Size = New System.Drawing.Size(784, 384)
		Me.dataGridAnggota.TabIndex = 0
		'
		'formAnggota
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.dataGridAnggota)
		Me.Name = "formAnggota"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Anggota"
		CType(Me.dataGridAnggota,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents dataGridAnggota As DataGridView
End Class
