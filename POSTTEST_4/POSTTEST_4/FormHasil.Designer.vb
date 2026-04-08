<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
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
		lblHeaderForm = New Label()
		lblSubHeader = New Label()
		pnlKartu = New Panel()
		btnSimpanUlang = New Button()
		btnKembali = New Button()
		SuspendLayout()
		' 
		' lblHeaderForm
		' 
		lblHeaderForm.AutoSize = True
		lblHeaderForm.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblHeaderForm.ForeColor = Color.Coral
		lblHeaderForm.Location = New Point(192, 9)
		lblHeaderForm.Name = "lblHeaderForm"
		lblHeaderForm.Size = New Size(367, 38)
		lblHeaderForm.TabIndex = 1
		lblHeaderForm.Text = "KARTU ANGGOTA DIGITAL"
		' 
		' lblSubHeader
		' 
		lblSubHeader.AutoSize = True
		lblSubHeader.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		lblSubHeader.ForeColor = Color.Coral
		lblSubHeader.Location = New Point(279, 47)
		lblSubHeader.Name = "lblSubHeader"
		lblSubHeader.Size = New Size(186, 23)
		lblSubHeader.TabIndex = 2
		lblSubHeader.Text = "Samarendah Freediver"
		' 
		' pnlKartu
		' 
		pnlKartu.BackColor = Color.Transparent
		pnlKartu.Location = New Point(30, 75)
		pnlKartu.Name = "pnlKartu"
		pnlKartu.Size = New Size(750, 440)
		pnlKartu.TabIndex = 3
		' 
		' btnSimpanUlang
		' 
		btnSimpanUlang.BackColor = Color.Navy
		btnSimpanUlang.Cursor = Cursors.Hand
		btnSimpanUlang.FlatAppearance.BorderColor = Color.White
		btnSimpanUlang.FlatAppearance.MouseDownBackColor = Color.DodgerBlue
		btnSimpanUlang.FlatAppearance.MouseOverBackColor = Color.Blue
		btnSimpanUlang.FlatStyle = FlatStyle.Flat
		btnSimpanUlang.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnSimpanUlang.ForeColor = Color.White
		btnSimpanUlang.Location = New Point(538, 523)
		btnSimpanUlang.Name = "btnSimpanUlang"
		btnSimpanUlang.Size = New Size(242, 38)
		btnSimpanUlang.TabIndex = 18
		btnSimpanUlang.Text = "Simpan Data Anggota"
		btnSimpanUlang.UseVisualStyleBackColor = False
		' 
		' btnKembali
		' 
		btnKembali.BackColor = Color.OrangeRed
		btnKembali.Cursor = Cursors.Hand
		btnKembali.FlatAppearance.BorderColor = Color.White
		btnKembali.FlatAppearance.MouseDownBackColor = Color.Brown
		btnKembali.FlatAppearance.MouseOverBackColor = Color.Red
		btnKembali.FlatStyle = FlatStyle.Flat
		btnKembali.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnKembali.ForeColor = Color.White
		btnKembali.Location = New Point(30, 523)
		btnKembali.Name = "btnKembali"
		btnKembali.Size = New Size(123, 38)
		btnKembali.TabIndex = 19
		btnKembali.Text = "←  Kembali"
		btnKembali.UseVisualStyleBackColor = False
		' 
		' FormHasil
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(5), CByte(15), CByte(40))
		ClientSize = New Size(802, 573)
		Controls.Add(btnKembali)
		Controls.Add(btnSimpanUlang)
		Controls.Add(pnlKartu)
		Controls.Add(lblSubHeader)
		Controls.Add(lblHeaderForm)
		MaximizeBox = False
		Name = "FormHasil"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Form Hasil"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents lblHeaderForm As Label
	Friend WithEvents lblSubHeader As Label
	Friend WithEvents pnlKartu As Panel
	Friend WithEvents btnSimpanUlang As Button
	Friend WithEvents btnKembali As Button
End Class
