<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTest
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
		Me.btnShow = New System.Windows.Forms.Button()
		Me.txtSalary = New System.Windows.Forms.TextBox()
		Me.lblSalary = New System.Windows.Forms.Label()
		Me.listLaptop = New System.Windows.Forms.ListBox()
		Me.SuspendLayout
		'
		'btnShow
		'
		Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnShow.Location = New System.Drawing.Point(72, 16)
		Me.btnShow.Name = "btnShow"
		Me.btnShow.Size = New System.Drawing.Size(88, 32)
		Me.btnShow.TabIndex = 0
		Me.btnShow.Text = "Show"
		Me.btnShow.UseVisualStyleBackColor = true
		'
		'txtSalary
		'
		Me.txtSalary.Location = New System.Drawing.Point(104, 80)
		Me.txtSalary.Name = "txtSalary"
		Me.txtSalary.Size = New System.Drawing.Size(100, 20)
		Me.txtSalary.TabIndex = 1
		'
		'lblSalary
		'
		Me.lblSalary.AutoSize = true
		Me.lblSalary.Location = New System.Drawing.Point(48, 80)
		Me.lblSalary.Name = "lblSalary"
		Me.lblSalary.Size = New System.Drawing.Size(36, 13)
		Me.lblSalary.TabIndex = 2
		Me.lblSalary.Text = "Salary"
		'
		'listLaptop
		'
		Me.listLaptop.FormattingEnabled = true
		Me.listLaptop.Items.AddRange(New Object() {"HP", "Dell", "Lenovo", "Asus", "Axioo", "MacBook"})
		Me.listLaptop.Location = New System.Drawing.Point(272, 40)
		Me.listLaptop.Name = "listLaptop"
		Me.listLaptop.Size = New System.Drawing.Size(104, 108)
		Me.listLaptop.TabIndex = 3
		'
		'formTest
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(479, 253)
		Me.Controls.Add(Me.listLaptop)
		Me.Controls.Add(Me.lblSalary)
		Me.Controls.Add(Me.txtSalary)
		Me.Controls.Add(Me.btnShow)
		Me.Name = "formTest"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Test"
		Me.ResumeLayout(false)
		Me.PerformLayout

End Sub

	Friend WithEvents btnShow As Button
	Friend WithEvents txtSalary As TextBox
	Friend WithEvents lblSalary As Label
	Friend WithEvents listLaptop As ListBox
End Class
