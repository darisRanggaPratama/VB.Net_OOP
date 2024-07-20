<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSearch
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
		Me.gridViewSearch = New System.Windows.Forms.DataGridView()
		Me.btnSearch = New System.Windows.Forms.Button()
		Me.txtSearch = New System.Windows.Forms.TextBox()
		CType(Me.gridViewSearch,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'gridViewSearch
		'
		Me.gridViewSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.gridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.gridViewSearch.Location = New System.Drawing.Point(8, 88)
		Me.gridViewSearch.Name = "gridViewSearch"
		Me.gridViewSearch.Size = New System.Drawing.Size(920, 416)
		Me.gridViewSearch.TabIndex = 0
		'
		'btnSearch
		'
		Me.btnSearch.Font = New System.Drawing.Font("JetBrains Mono NL", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnSearch.Location = New System.Drawing.Point(776, 32)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(147, 31)
		Me.btnSearch.TabIndex = 1
		Me.btnSearch.Text = "Search/ Filter"
		Me.btnSearch.UseVisualStyleBackColor = true
		'
		'txtSearch
		'
		Me.txtSearch.Font = New System.Drawing.Font("JetBrains Mono", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txtSearch.Location = New System.Drawing.Point(8, 32)
		Me.txtSearch.Name = "txtSearch"
		Me.txtSearch.Size = New System.Drawing.Size(712, 27)
		Me.txtSearch.TabIndex = 2
		Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'FormSearch
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(939, 516)
		Me.Controls.Add(Me.txtSearch)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.gridViewSearch)
		Me.Name = "FormSearch"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Browsing"
		CType(Me.gridViewSearch,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents gridViewSearch As DataGridView
	Friend WithEvents btnSearch As Button
	Friend WithEvents txtSearch As TextBox
End Class
