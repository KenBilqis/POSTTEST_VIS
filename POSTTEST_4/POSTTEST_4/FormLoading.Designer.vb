<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoading
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
		lblJudul = New Label()
		lblSubJudul = New Label()
		lblStatus = New Label()
		prgLoading = New ProgressBar()
		Label1 = New Label()
		lblPersen = New Label()
		SuspendLayout()
		' 
		' lblJudul
		' 
		lblJudul.AutoSize = True
		lblJudul.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblJudul.ForeColor = Color.Coral
		lblJudul.Location = New Point(60, 58)
		lblJudul.Name = "lblJudul"
		lblJudul.Size = New Size(372, 41)
		lblJudul.TabIndex = 0
		lblJudul.Text = "Membuat Kartu Anggota"
		' 
		' lblSubJudul
		' 
		lblSubJudul.AutoSize = True
		lblSubJudul.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		lblSubJudul.ForeColor = Color.Coral
		lblSubJudul.Location = New Point(146, 99)
		lblSubJudul.Name = "lblSubJudul"
		lblSubJudul.Size = New Size(186, 23)
		lblSubJudul.TabIndex = 1
		lblSubJudul.Text = "Samarendah Freediver"
		' 
		' lblStatus
		' 
		lblStatus.AutoSize = True
		lblStatus.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblStatus.ForeColor = Color.Coral
		lblStatus.Location = New Point(117, 122)
		lblStatus.Name = "lblStatus"
		lblStatus.Size = New Size(215, 23)
		lblStatus.TabIndex = 2
		lblStatus.Text = "Menyelam ke lautan data..."
		' 
		' prgLoading
		' 
		prgLoading.Location = New Point(21, 157)
		prgLoading.Name = "prgLoading"
		prgLoading.Size = New Size(440, 18)
		prgLoading.Style = ProgressBarStyle.Continuous
		prgLoading.TabIndex = 3
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Label1.ForeColor = Color.Coral
		Label1.Location = New Point(134, 125)
		Label1.Name = "Label1"
		Label1.Size = New Size(0, 23)
		Label1.TabIndex = 4
		' 
		' lblPersen
		' 
		lblPersen.AutoSize = True
		lblPersen.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblPersen.ForeColor = Color.Coral
		lblPersen.Location = New Point(218, 178)
		lblPersen.Name = "lblPersen"
		lblPersen.Size = New Size(31, 20)
		lblPersen.TabIndex = 5
		lblPersen.Text = "0%"
		' 
		' FormLoading
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(5), CByte(15), CByte(40))
		ClientSize = New Size(482, 273)
		Controls.Add(lblPersen)
		Controls.Add(Label1)
		Controls.Add(prgLoading)
		Controls.Add(lblStatus)
		Controls.Add(lblSubJudul)
		Controls.Add(lblJudul)
		FormBorderStyle = FormBorderStyle.None
		Name = "FormLoading"
		StartPosition = FormStartPosition.CenterParent
		Text = "Form1"
		TopMost = True
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents lblJudul As Label
	Friend WithEvents lblSubJudul As Label
	Friend WithEvents lblStatus As Label
	Friend WithEvents prgLoading As ProgressBar
	Friend WithEvents Label1 As Label
	Friend WithEvents lblPersen As Label
End Class
