<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
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
		picFotoKartu = New PictureBox()
		lblHeaderKartu = New Label()
		lblNama = New Label()
		pnlKartu = New Panel()
		PictureBox1 = New PictureBox()
		lblFooter = New Label()
		lblGaris = New Label()
		lblAlamat = New Label()
		lblHobby = New Label()
		lblTglLahir = New Label()
		lblTelepon = New Label()
		lblUmur = New Label()
		CType(picFotoKartu, ComponentModel.ISupportInitialize).BeginInit()
		pnlKartu.SuspendLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' picFotoKartu
		' 
		picFotoKartu.BackColor = Color.FromArgb(CByte(238), CByte(237), CByte(254))
		picFotoKartu.BorderStyle = BorderStyle.FixedSingle
		picFotoKartu.Location = New Point(12, 40)
		picFotoKartu.Name = "picFotoKartu"
		picFotoKartu.Size = New Size(90, 110)
		picFotoKartu.SizeMode = PictureBoxSizeMode.Zoom
		picFotoKartu.TabIndex = 0
		picFotoKartu.TabStop = False
		' 
		' lblHeaderKartu
		' 
		lblHeaderKartu.AutoSize = True
		lblHeaderKartu.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblHeaderKartu.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblHeaderKartu.Location = New Point(10, 8)
		lblHeaderKartu.Name = "lblHeaderKartu"
		lblHeaderKartu.Size = New Size(541, 23)
		lblHeaderKartu.TabIndex = 1
		lblHeaderKartu.Text = "HOGWARTS SCHOOL OF WITCHCRAFT AND WIZARDRY"
		' 
		' lblNama
		' 
		lblNama.AutoSize = True
		lblNama.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblNama.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblNama.Location = New Point(115, 40)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(61, 20)
		lblNama.TabIndex = 4
		lblNama.Text = "Nama :"
		' 
		' pnlKartu
		' 
		pnlKartu.BackColor = Color.FromArgb(CByte(60), CByte(52), CByte(137))
		pnlKartu.BorderStyle = BorderStyle.FixedSingle
		pnlKartu.Controls.Add(PictureBox1)
		pnlKartu.Controls.Add(lblFooter)
		pnlKartu.Controls.Add(lblGaris)
		pnlKartu.Controls.Add(lblAlamat)
		pnlKartu.Controls.Add(lblHobby)
		pnlKartu.Controls.Add(lblTglLahir)
		pnlKartu.Controls.Add(lblTelepon)
		pnlKartu.Controls.Add(lblUmur)
		pnlKartu.Controls.Add(lblNama)
		pnlKartu.Controls.Add(lblHeaderKartu)
		pnlKartu.Controls.Add(picFotoKartu)
		pnlKartu.Location = New Point(25, 25)
		pnlKartu.Name = "pnlKartu"
		pnlKartu.Size = New Size(564, 260)
		pnlKartu.TabIndex = 0
		' 
		' PictureBox1
		' 
		PictureBox1.Image = My.Resources.Resources.hogwarts_logo
		PictureBox1.Location = New Point(411, 45)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(140, 140)
		PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
		PictureBox1.TabIndex = 17
		PictureBox1.TabStop = False
		' 
		' lblFooter
		' 
		lblFooter.AutoSize = True
		lblFooter.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblFooter.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblFooter.Location = New Point(115, 224)
		lblFooter.Name = "lblFooter"
		lblFooter.Size = New Size(339, 20)
		lblFooter.TabIndex = 11
		lblFooter.Text = "★  STUDENT IDENTIFICATION CARD  ★"
		' 
		' lblGaris
		' 
		lblGaris.AutoSize = True
		lblGaris.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblGaris.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblGaris.Location = New Point(10, 195)
		lblGaris.Name = "lblGaris"
		lblGaris.Size = New Size(541, 20)
		lblGaris.TabIndex = 10
		lblGaris.Text = "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━"
		' 
		' lblAlamat
		' 
		lblAlamat.AutoSize = True
		lblAlamat.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblAlamat.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblAlamat.Location = New Point(115, 165)
		lblAlamat.Name = "lblAlamat"
		lblAlamat.Size = New Size(69, 20)
		lblAlamat.TabIndex = 9
		lblAlamat.Text = "Alamat :"
		' 
		' lblHobby
		' 
		lblHobby.AutoSize = True
		lblHobby.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblHobby.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblHobby.Location = New Point(115, 140)
		lblHobby.Name = "lblHobby"
		lblHobby.Size = New Size(67, 20)
		lblHobby.TabIndex = 8
		lblHobby.Text = "Hobby :"
		' 
		' lblTglLahir
		' 
		lblTglLahir.AutoSize = True
		lblTglLahir.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblTglLahir.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblTglLahir.Location = New Point(115, 115)
		lblTglLahir.Name = "lblTglLahir"
		lblTglLahir.Size = New Size(85, 20)
		lblTglLahir.TabIndex = 7
		lblTglLahir.Text = "Tgl Lahir :"
		' 
		' lblTelepon
		' 
		lblTelepon.AutoSize = True
		lblTelepon.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblTelepon.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblTelepon.Location = New Point(115, 90)
		lblTelepon.Name = "lblTelepon"
		lblTelepon.Size = New Size(76, 20)
		lblTelepon.TabIndex = 6
		lblTelepon.Text = "Telepon :"
		' 
		' lblUmur
		' 
		lblUmur.AutoSize = True
		lblUmur.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblUmur.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblUmur.Location = New Point(115, 65)
		lblUmur.Name = "lblUmur"
		lblUmur.Size = New Size(60, 20)
		lblUmur.TabIndex = 5
		lblUmur.Text = "Umur :"
		' 
		' FormKartu
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(26), CByte(21), CByte(92))
		ClientSize = New Size(612, 303)
		Controls.Add(pnlKartu)
		FormBorderStyle = FormBorderStyle.FixedDialog
		Name = "FormKartu"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Hogwarts Student ID Card"
		CType(picFotoKartu, ComponentModel.ISupportInitialize).EndInit()
		pnlKartu.ResumeLayout(False)
		pnlKartu.PerformLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
	End Sub

	Friend WithEvents picFotoKartu As PictureBox
	Friend WithEvents lblHeaderKartu As Label
	Friend WithEvents lblNama As Label
	Friend WithEvents pnlKartu As Panel
	Friend WithEvents lblTelepon As Label
	Friend WithEvents lblUmur As Label
	Friend WithEvents lblGaris As Label
	Friend WithEvents lblAlamat As Label
	Friend WithEvents lblHobby As Label
	Friend WithEvents lblTglLahir As Label
	Friend WithEvents lblFooter As Label
	Friend WithEvents PictureBox1 As PictureBox
End Class
