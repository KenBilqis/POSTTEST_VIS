<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(disposing As Boolean)
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		pnlHeader = New FlowLayoutPanel()
		lblJudul = New Label()
		picFoto = New PictureBox()
		btnBrowse = New Button()
		txtNama = New TextBox()
		lblUmurInput = New Label()
		lblNamaInput = New Label()
		txtUmur = New TextBox()
		lblTeleponInput = New Label()
		txtTelepon = New TextBox()
		lblAlamatInput = New Label()
		txtAlamat = New TextBox()
		lblTglLahirInput = New Label()
		dtpTglLahir = New DateTimePicker()
		grpJenisKelamin = New GroupBox()
		rbPerempuan = New RadioButton()
		rbLaki = New RadioButton()
		grpHobby = New GroupBox()
		chkTransfiguration = New CheckBox()
		chkReading = New CheckBox()
		chkChess = New CheckBox()
		chkFlying = New CheckBox()
		chkDADA = New CheckBox()
		chkAstronomy = New CheckBox()
		chkCharms = New CheckBox()
		chkHerbology = New CheckBox()
		chkPotions = New CheckBox()
		chkQuidditch = New CheckBox()
		btnCetak = New Button()
		PictureBox1 = New PictureBox()
		pnlHeader.SuspendLayout()
		CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
		grpJenisKelamin.SuspendLayout()
		grpHobby.SuspendLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' pnlHeader
		' 
		pnlHeader.BackColor = Color.FromArgb(CByte(74), CByte(27), CByte(12))
		pnlHeader.BorderStyle = BorderStyle.FixedSingle
		pnlHeader.Controls.Add(lblJudul)
		pnlHeader.Location = New Point(60, 29)
		pnlHeader.Name = "pnlHeader"
		pnlHeader.Size = New Size(551, 24)
		pnlHeader.TabIndex = 0
		' 
		' lblJudul
		' 
		lblJudul.AutoSize = True
		lblJudul.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblJudul.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblJudul.Location = New Point(3, 0)
		lblJudul.Name = "lblJudul"
		lblJudul.Size = New Size(543, 20)
		lblJudul.TabIndex = 0
		lblJudul.Text = "⚡ HOGWARTS SCHOOL OF WITCHCRAFT AND WIZARDRY ⚡"
		' 
		' picFoto
		' 
		picFoto.BackColor = Color.FromArgb(CByte(238), CByte(237), CByte(254))
		picFoto.BorderStyle = BorderStyle.FixedSingle
		picFoto.Location = New Point(20, 80)
		picFoto.Name = "picFoto"
		picFoto.Size = New Size(110, 130)
		picFoto.SizeMode = PictureBoxSizeMode.Zoom
		picFoto.TabIndex = 1
		picFoto.TabStop = False
		' 
		' btnBrowse
		' 
		btnBrowse.BackColor = Color.FromArgb(CByte(60), CByte(52), CByte(137))
		btnBrowse.FlatStyle = FlatStyle.Flat
		btnBrowse.Font = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		btnBrowse.ForeColor = Color.FromArgb(CByte(238), CByte(237), CByte(254))
		btnBrowse.Location = New Point(20, 220)
		btnBrowse.Name = "btnBrowse"
		btnBrowse.Size = New Size(110, 30)
		btnBrowse.TabIndex = 2
		btnBrowse.Text = "📂  Browse Foto"
		btnBrowse.UseVisualStyleBackColor = False
		' 
		' txtNama
		' 
		txtNama.BackColor = Color.FromArgb(CByte(238), CByte(237), CByte(254))
		txtNama.ForeColor = Color.Black
		txtNama.Location = New Point(290, 78)
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(200, 27)
		txtNama.TabIndex = 4
		' 
		' lblUmurInput
		' 
		lblUmurInput.AutoSize = True
		lblUmurInput.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblUmurInput.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblUmurInput.Location = New Point(150, 115)
		lblUmurInput.Name = "lblUmurInput"
		lblUmurInput.Size = New Size(60, 20)
		lblUmurInput.TabIndex = 5
		lblUmurInput.Text = "Umur :"
		' 
		' lblNamaInput
		' 
		lblNamaInput.AutoSize = True
		lblNamaInput.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblNamaInput.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblNamaInput.Location = New Point(150, 80)
		lblNamaInput.Name = "lblNamaInput"
		lblNamaInput.Size = New Size(128, 20)
		lblNamaInput.TabIndex = 3
		lblNamaInput.Text = "Nama Lengkap :"
		' 
		' txtUmur
		' 
		txtUmur.BackColor = Color.FromArgb(CByte(238), CByte(237), CByte(254))
		txtUmur.ForeColor = Color.Black
		txtUmur.Location = New Point(290, 113)
		txtUmur.Name = "txtUmur"
		txtUmur.Size = New Size(80, 27)
		txtUmur.TabIndex = 6
		' 
		' lblTeleponInput
		' 
		lblTeleponInput.AutoSize = True
		lblTeleponInput.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblTeleponInput.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblTeleponInput.Location = New Point(150, 150)
		lblTeleponInput.Name = "lblTeleponInput"
		lblTeleponInput.Size = New Size(108, 20)
		lblTeleponInput.TabIndex = 7
		lblTeleponInput.Text = "No. Telepon :"
		' 
		' txtTelepon
		' 
		txtTelepon.BackColor = Color.FromArgb(CByte(238), CByte(237), CByte(254))
		txtTelepon.ForeColor = Color.Black
		txtTelepon.Location = New Point(290, 148)
		txtTelepon.Name = "txtTelepon"
		txtTelepon.Size = New Size(200, 27)
		txtTelepon.TabIndex = 8
		' 
		' lblAlamatInput
		' 
		lblAlamatInput.AutoSize = True
		lblAlamatInput.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblAlamatInput.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblAlamatInput.Location = New Point(150, 185)
		lblAlamatInput.Name = "lblAlamatInput"
		lblAlamatInput.Size = New Size(69, 20)
		lblAlamatInput.TabIndex = 9
		lblAlamatInput.Text = "Alamat :"
		' 
		' txtAlamat
		' 
		txtAlamat.BackColor = Color.FromArgb(CByte(238), CByte(237), CByte(254))
		txtAlamat.ForeColor = Color.Black
		txtAlamat.Location = New Point(290, 183)
		txtAlamat.Name = "txtAlamat"
		txtAlamat.Size = New Size(200, 27)
		txtAlamat.TabIndex = 10
		' 
		' lblTglLahirInput
		' 
		lblTglLahirInput.AutoSize = True
		lblTglLahirInput.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblTglLahirInput.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		lblTglLahirInput.Location = New Point(150, 220)
		lblTglLahirInput.Name = "lblTglLahirInput"
		lblTglLahirInput.Size = New Size(117, 20)
		lblTglLahirInput.TabIndex = 11
		lblTglLahirInput.Text = "Tanggal Lahir :"
		' 
		' dtpTglLahir
		' 
		dtpTglLahir.CalendarFont = New Font("Times New Roman", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		dtpTglLahir.CalendarForeColor = Color.Black
		dtpTglLahir.CalendarMonthBackground = Color.FromArgb(CByte(238), CByte(237), CByte(254))
		dtpTglLahir.Location = New Point(290, 218)
		dtpTglLahir.Name = "dtpTglLahir"
		dtpTglLahir.Size = New Size(200, 27)
		dtpTglLahir.TabIndex = 12
		' 
		' grpJenisKelamin
		' 
		grpJenisKelamin.Controls.Add(rbPerempuan)
		grpJenisKelamin.Controls.Add(rbLaki)
		grpJenisKelamin.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		grpJenisKelamin.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		grpJenisKelamin.Location = New Point(150, 255)
		grpJenisKelamin.Name = "grpJenisKelamin"
		grpJenisKelamin.Size = New Size(160, 78)
		grpJenisKelamin.TabIndex = 13
		grpJenisKelamin.TabStop = False
		grpJenisKelamin.Text = "Jenis Kelamin"
		' 
		' rbPerempuan
		' 
		rbPerempuan.AutoSize = True
		rbPerempuan.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		rbPerempuan.Location = New Point(10, 48)
		rbPerempuan.Name = "rbPerempuan"
		rbPerempuan.Size = New Size(112, 24)
		rbPerempuan.TabIndex = 1
		rbPerempuan.TabStop = True
		rbPerempuan.Text = "Perempuan"
		rbPerempuan.UseVisualStyleBackColor = True
		' 
		' rbLaki
		' 
		rbLaki.AutoSize = True
		rbLaki.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		rbLaki.Location = New Point(10, 25)
		rbLaki.Name = "rbLaki"
		rbLaki.Size = New Size(93, 24)
		rbLaki.TabIndex = 0
		rbLaki.TabStop = True
		rbLaki.Text = "Laki-laki"
		rbLaki.UseVisualStyleBackColor = True
		' 
		' grpHobby
		' 
		grpHobby.Controls.Add(chkTransfiguration)
		grpHobby.Controls.Add(chkReading)
		grpHobby.Controls.Add(chkChess)
		grpHobby.Controls.Add(chkFlying)
		grpHobby.Controls.Add(chkDADA)
		grpHobby.Controls.Add(chkAstronomy)
		grpHobby.Controls.Add(chkCharms)
		grpHobby.Controls.Add(chkHerbology)
		grpHobby.Controls.Add(chkPotions)
		grpHobby.Controls.Add(chkQuidditch)
		grpHobby.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		grpHobby.ForeColor = Color.FromArgb(CByte(250), CByte(199), CByte(117))
		grpHobby.Location = New Point(330, 255)
		grpHobby.Name = "grpHobby"
		grpHobby.Size = New Size(330, 155)
		grpHobby.TabIndex = 14
		grpHobby.TabStop = False
		grpHobby.Text = "Hobby (Pilih minimal 1)"
		' 
		' chkTransfiguration
		' 
		chkTransfiguration.AutoSize = True
		chkTransfiguration.Location = New Point(170, 125)
		chkTransfiguration.Name = "chkTransfiguration"
		chkTransfiguration.Size = New Size(140, 24)
		chkTransfiguration.TabIndex = 11
		chkTransfiguration.Text = "Transfiguration"
		chkTransfiguration.UseVisualStyleBackColor = True
		' 
		' chkReading
		' 
		chkReading.AutoSize = True
		chkReading.Location = New Point(10, 125)
		chkReading.Name = "chkReading"
		chkReading.Size = New Size(89, 24)
		chkReading.TabIndex = 10
		chkReading.Text = "Reading"
		chkReading.UseVisualStyleBackColor = True
		' 
		' chkChess
		' 
		chkChess.AutoSize = True
		chkChess.Location = New Point(170, 100)
		chkChess.Name = "chkChess"
		chkChess.Size = New Size(130, 24)
		chkChess.TabIndex = 9
		chkChess.Text = "Wizard Chess"
		chkChess.UseVisualStyleBackColor = True
		' 
		' chkFlying
		' 
		chkFlying.AutoSize = True
		chkFlying.Location = New Point(10, 100)
		chkFlying.Name = "chkFlying"
		chkFlying.Size = New Size(75, 24)
		chkFlying.TabIndex = 8
		chkFlying.Text = "Flying"
		chkFlying.UseVisualStyleBackColor = True
		' 
		' chkDADA
		' 
		chkDADA.AutoSize = True
		chkDADA.Font = New Font("Times New Roman", 7.0F)
		chkDADA.Location = New Point(170, 50)
		chkDADA.Name = "chkDADA"
		chkDADA.Size = New Size(158, 19)
		chkDADA.TabIndex = 7
		chkDADA.Text = "Defense Against Dark Arts"
		chkDADA.UseVisualStyleBackColor = True
		' 
		' chkAstronomy
		' 
		chkAstronomy.AutoSize = True
		chkAstronomy.Location = New Point(170, 75)
		chkAstronomy.Name = "chkAstronomy"
		chkAstronomy.Size = New Size(111, 24)
		chkAstronomy.TabIndex = 6
		chkAstronomy.Text = "Astronomy"
		chkAstronomy.UseVisualStyleBackColor = True
		' 
		' chkCharms
		' 
		chkCharms.AutoSize = True
		chkCharms.Location = New Point(10, 50)
		chkCharms.Name = "chkCharms"
		chkCharms.Size = New Size(80, 24)
		chkCharms.TabIndex = 5
		chkCharms.Text = "Charm"
		chkCharms.UseVisualStyleBackColor = True
		' 
		' chkHerbology
		' 
		chkHerbology.AutoSize = True
		chkHerbology.Location = New Point(10, 75)
		chkHerbology.Name = "chkHerbology"
		chkHerbology.Size = New Size(106, 24)
		chkHerbology.TabIndex = 2
		chkHerbology.Text = "Herbology"
		chkHerbology.UseVisualStyleBackColor = True
		' 
		' chkPotions
		' 
		chkPotions.AutoSize = True
		chkPotions.Location = New Point(170, 25)
		chkPotions.Name = "chkPotions"
		chkPotions.Size = New Size(85, 24)
		chkPotions.TabIndex = 1
		chkPotions.Text = "Potions"
		chkPotions.UseVisualStyleBackColor = True
		' 
		' chkQuidditch
		' 
		chkQuidditch.AutoSize = True
		chkQuidditch.Location = New Point(10, 25)
		chkQuidditch.Name = "chkQuidditch"
		chkQuidditch.Size = New Size(101, 24)
		chkQuidditch.TabIndex = 0
		chkQuidditch.Text = "Quidditch"
		chkQuidditch.UseVisualStyleBackColor = True
		' 
		' btnCetak
		' 
		btnCetak.BackColor = Color.FromArgb(CByte(60), CByte(52), CByte(137))
		btnCetak.FlatStyle = FlatStyle.Flat
		btnCetak.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnCetak.Location = New Point(150, 426)
		btnCetak.Name = "btnCetak"
		btnCetak.Size = New Size(508, 40)
		btnCetak.TabIndex = 15
		btnCetak.Text = ChrW(55358) & ChrW(56964) & "  Cetak Kartu"
		btnCetak.UseVisualStyleBackColor = False
		' 
		' PictureBox1
		' 
		PictureBox1.Image = My.Resources.Resources.hogwarts_logo
		PictureBox1.Location = New Point(500, 78)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(160, 160)
		PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
		PictureBox1.TabIndex = 16
		PictureBox1.TabStop = False
		' 
		' FormCetak
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(26), CByte(21), CByte(92))
		ClientSize = New Size(682, 481)
		Controls.Add(PictureBox1)
		Controls.Add(btnCetak)
		Controls.Add(grpHobby)
		Controls.Add(grpJenisKelamin)
		Controls.Add(dtpTglLahir)
		Controls.Add(lblTglLahirInput)
		Controls.Add(txtAlamat)
		Controls.Add(lblAlamatInput)
		Controls.Add(txtTelepon)
		Controls.Add(lblTeleponInput)
		Controls.Add(txtUmur)
		Controls.Add(lblUmurInput)
		Controls.Add(txtNama)
		Controls.Add(lblNamaInput)
		Controls.Add(btnBrowse)
		Controls.Add(picFoto)
		Controls.Add(pnlHeader)
		ForeColor = Color.FromArgb(CByte(238), CByte(237), CByte(254))
		Name = "FormCetak"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Hogwarts Student Card Maker"
		pnlHeader.ResumeLayout(False)
		pnlHeader.PerformLayout()
		CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
		grpJenisKelamin.ResumeLayout(False)
		grpJenisKelamin.PerformLayout()
		grpHobby.ResumeLayout(False)
		grpHobby.PerformLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents pnlHeader As FlowLayoutPanel
	Friend WithEvents lblJudul As Label
	Friend WithEvents picFoto As PictureBox
	Friend WithEvents btnBrowse As Button
	Friend WithEvents txtNama As TextBox
	Friend WithEvents lblUmurInput As Label
	Friend WithEvents lblNamaInput As Label
	Friend WithEvents txtUmur As TextBox
	Friend WithEvents lblTeleponInput As Label
	Friend WithEvents txtTelepon As TextBox
	Friend WithEvents lblAlamatInput As Label
	Friend WithEvents txtAlamat As TextBox
	Friend WithEvents lblTglLahirInput As Label
	Friend WithEvents dtpTglLahir As DateTimePicker
	Friend WithEvents grpJenisKelamin As GroupBox
	Friend WithEvents rbPerempuan As RadioButton
	Friend WithEvents rbLaki As RadioButton
	Friend WithEvents grpHobby As GroupBox
	Friend WithEvents chkCharms As CheckBox
	Friend WithEvents chkHerbology As CheckBox
	Friend WithEvents chkPotions As CheckBox
	Friend WithEvents chkQuidditch As CheckBox
	Friend WithEvents chkAstronomy As CheckBox
	Friend WithEvents chkDADA As CheckBox
	Friend WithEvents chkChess As CheckBox
	Friend WithEvents chkFlying As CheckBox
	Friend WithEvents chkReading As CheckBox
	Friend WithEvents chkTransfiguration As CheckBox
	Friend WithEvents btnCetak As Button
	Friend WithEvents PictureBox1 As PictureBox

End Class
