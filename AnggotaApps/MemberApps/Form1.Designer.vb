<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMember
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
		Me.gridMember = New System.Windows.Forms.DataGridView()
		CType(Me.gridMember,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'gridMember
		'
		Me.gridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.gridMember.Location = New System.Drawing.Point(8, 8)
		Me.gridMember.Name = "gridMember"
		Me.gridMember.Size = New System.Drawing.Size(784, 432)
		Me.gridMember.TabIndex = 0
		'
		'formMember
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.gridMember)
		Me.Name = "formMember"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Member"
		CType(Me.gridMember,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)

End Sub

	Friend WithEvents gridMember As DataGridView
End Class
