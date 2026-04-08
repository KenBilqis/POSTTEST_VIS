<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
		components = New ComponentModel.Container()
		mnuStrip = New MenuStrip()
		mnuInputData = New ToolStripMenuItem()
		mnuLihatKartu = New ToolStripMenuItem()
		mnuSimpanData = New ToolStripMenuItem()
		mnuBukaData = New ToolStripMenuItem()
		mnuKeluar = New ToolStripMenuItem()
		tabMain = New TabControl()
		tabDataUtama = New TabPage()
		btnNextTab1 = New Button()
		cmbKomunitas = New ComboBox()
		lblKomunitas = New Label()
		grpJenisKelamin = New GroupBox()
		rbPerempuan = New RadioButton()
		rbLakiLaki = New RadioButton()
		dtpTanggalLahir = New DateTimePicker()
		lblTanggalLahir = New Label()
		txtIDAnggota = New TextBox()
		lblID = New Label()
		txtNama = New TextBox()
		lblNama = New Label()
		lblGaris1 = New Label()
		lblHeaderTab1 = New Label()
		tabKontakInfo = New TabPage()
		btnPrevTab2 = New Button()
		btnNextTab2 = New Button()
		txtAlamat = New TextBox()
		lblAlamat = New Label()
		txtEmail = New TextBox()
		lblEmail = New Label()
		Label2 = New Label()
		lblTelepon = New Label()
		mtbTelepon = New MaskedTextBox()
		Label1 = New Label()
		lblHeaderTab2 = New Label()
		tabProfilAktivitas = New TabPage()
		btnSimpanCetak = New Button()
		btnPrevTab3 = New Button()
		grpHobi = New GroupBox()
		cbSpearfishing = New CheckBox()
		cbNightDive = New CheckBox()
		cbRescue = New CheckBox()
		cbKonservasi = New CheckBox()
		cbFotografiLaut = New CheckBox()
		cbSnorkeling = New CheckBox()
		cbFreediving = New CheckBox()
		cbScubaDiving = New CheckBox()
		grpPeran = New GroupBox()
		rbPelatih = New RadioButton()
		rbAdmin = New RadioButton()
		rbAnggota = New RadioButton()
		rbKetua = New RadioButton()
		btnBrowseFoto = New Button()
		picFoto = New PictureBox()
		epValidasi = New ErrorProvider(components)
		lblSubJudul = New Label()
		lblJudul = New Label()
		picLogo = New PictureBox()
		mnuStrip.SuspendLayout()
		tabMain.SuspendLayout()
		tabDataUtama.SuspendLayout()
		grpJenisKelamin.SuspendLayout()
		tabKontakInfo.SuspendLayout()
		tabProfilAktivitas.SuspendLayout()
		grpHobi.SuspendLayout()
		grpPeran.SuspendLayout()
		CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
		CType(epValidasi, ComponentModel.ISupportInitialize).BeginInit()
		CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' mnuStrip
		' 
		mnuStrip.BackColor = Color.DeepSkyBlue
		mnuStrip.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		mnuStrip.ImageScalingSize = New Size(20, 20)
		mnuStrip.Items.AddRange(New ToolStripItem() {mnuInputData, mnuLihatKartu, mnuSimpanData, mnuBukaData, mnuKeluar})
		mnuStrip.Location = New Point(0, 0)
		mnuStrip.Name = "mnuStrip"
		mnuStrip.Size = New Size(932, 31)
		mnuStrip.TabIndex = 0
		mnuStrip.Text = "MenuStrip1"
		' 
		' mnuInputData
		' 
		mnuInputData.ForeColor = Color.Navy
		mnuInputData.Name = "mnuInputData"
		mnuInputData.Size = New Size(144, 27)
		mnuInputData.Text = "⚓  Input Data"
		' 
		' mnuLihatKartu
		' 
		mnuLihatKartu.ForeColor = Color.Navy
		mnuLihatKartu.Name = "mnuLihatKartu"
		mnuLihatKartu.Size = New Size(147, 27)
		mnuLihatKartu.Text = ChrW(55358) & ChrW(57002) & "  Lihat Kartu"
		' 
		' mnuSimpanData
		' 
		mnuSimpanData.ForeColor = Color.Navy
		mnuSimpanData.Name = "mnuSimpanData"
		mnuSimpanData.Size = New Size(162, 27)
		mnuSimpanData.Text = "💾  Simpan Data"
		' 
		' mnuBukaData
		' 
		mnuBukaData.ForeColor = Color.Navy
		mnuBukaData.Name = "mnuBukaData"
		mnuBukaData.Size = New Size(141, 27)
		mnuBukaData.Text = "📂  Buka Data"
		' 
		' mnuKeluar
		' 
		mnuKeluar.ForeColor = Color.Navy
		mnuKeluar.Name = "mnuKeluar"
		mnuKeluar.Size = New Size(109, 27)
		mnuKeluar.Text = "❌  Keluar"
		' 
		' tabMain
		' 
		tabMain.Controls.Add(tabDataUtama)
		tabMain.Controls.Add(tabKontakInfo)
		tabMain.Controls.Add(tabProfilAktivitas)
		tabMain.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		tabMain.Location = New Point(15, 120)
		tabMain.Name = "tabMain"
		tabMain.SelectedIndex = 0
		tabMain.Size = New Size(920, 540)
		tabMain.TabIndex = 2
		' 
		' tabDataUtama
		' 
		tabDataUtama.BackColor = Color.DodgerBlue
		tabDataUtama.BackgroundImage = My.Resources.Resources.laut_2
		tabDataUtama.BackgroundImageLayout = ImageLayout.Stretch
		tabDataUtama.BorderStyle = BorderStyle.FixedSingle
		tabDataUtama.Controls.Add(btnNextTab1)
		tabDataUtama.Controls.Add(cmbKomunitas)
		tabDataUtama.Controls.Add(lblKomunitas)
		tabDataUtama.Controls.Add(grpJenisKelamin)
		tabDataUtama.Controls.Add(dtpTanggalLahir)
		tabDataUtama.Controls.Add(lblTanggalLahir)
		tabDataUtama.Controls.Add(txtIDAnggota)
		tabDataUtama.Controls.Add(lblID)
		tabDataUtama.Controls.Add(txtNama)
		tabDataUtama.Controls.Add(lblNama)
		tabDataUtama.Controls.Add(lblGaris1)
		tabDataUtama.Controls.Add(lblHeaderTab1)
		tabDataUtama.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		tabDataUtama.ForeColor = Color.Navy
		tabDataUtama.Location = New Point(4, 29)
		tabDataUtama.Name = "tabDataUtama"
		tabDataUtama.Padding = New Padding(3)
		tabDataUtama.Size = New Size(912, 507)
		tabDataUtama.TabIndex = 0
		tabDataUtama.Text = "⚓  Tab 1 - Data Utama"
		' 
		' btnNextTab1
		' 
		btnNextTab1.BackColor = Color.Navy
		btnNextTab1.Cursor = Cursors.Hand
		btnNextTab1.FlatAppearance.BorderColor = Color.White
		btnNextTab1.FlatAppearance.MouseDownBackColor = Color.DodgerBlue
		btnNextTab1.FlatAppearance.MouseOverBackColor = Color.Blue
		btnNextTab1.FlatStyle = FlatStyle.Flat
		btnNextTab1.ForeColor = Color.White
		btnNextTab1.Location = New Point(604, 450)
		btnNextTab1.Name = "btnNextTab1"
		btnNextTab1.Size = New Size(273, 38)
		btnNextTab1.TabIndex = 11
		btnNextTab1.Text = "Lanjut ke Kontak dan Info  →"
		btnNextTab1.UseVisualStyleBackColor = False
		' 
		' cmbKomunitas
		' 
		cmbKomunitas.BackColor = Color.Navy
		cmbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
		cmbKomunitas.FlatStyle = FlatStyle.Flat
		cmbKomunitas.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		cmbKomunitas.ForeColor = Color.White
		cmbKomunitas.FormattingEnabled = True
		cmbKomunitas.Items.AddRange(New Object() {"Freediving - Kedalaman", "Snorkeling - Rekreasi", "Rescue Diving - Penyelamatan", "Fotografi - Bawah Laut", "Konservasi - Lingkungan Laut", "Kompetisi - Freediving Sport"})
		cmbKomunitas.Location = New Point(170, 262)
		cmbKomunitas.Name = "cmbKomunitas"
		cmbKomunitas.Size = New Size(320, 31)
		cmbKomunitas.TabIndex = 10
		' 
		' lblKomunitas
		' 
		lblKomunitas.AutoSize = True
		lblKomunitas.BackColor = Color.Transparent
		lblKomunitas.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblKomunitas.Location = New Point(20, 265)
		lblKomunitas.Name = "lblKomunitas"
		lblKomunitas.Size = New Size(121, 23)
		lblKomunitas.TabIndex = 9
		lblKomunitas.Text = "Fokus Minat *"
		' 
		' grpJenisKelamin
		' 
		grpJenisKelamin.BackColor = Color.Transparent
		grpJenisKelamin.Controls.Add(rbPerempuan)
		grpJenisKelamin.Controls.Add(rbLakiLaki)
		grpJenisKelamin.Location = New Point(20, 185)
		grpJenisKelamin.Name = "grpJenisKelamin"
		grpJenisKelamin.Size = New Size(250, 60)
		grpJenisKelamin.TabIndex = 8
		grpJenisKelamin.TabStop = False
		grpJenisKelamin.Text = "Jenis Kelamin *"
		' 
		' rbPerempuan
		' 
		rbPerempuan.AutoSize = True
		rbPerempuan.Location = New Point(120, 25)
		rbPerempuan.Name = "rbPerempuan"
		rbPerempuan.Size = New Size(121, 27)
		rbPerempuan.TabIndex = 1
		rbPerempuan.Text = "Perempuan"
		rbPerempuan.UseVisualStyleBackColor = True
		' 
		' rbLakiLaki
		' 
		rbLakiLaki.AutoSize = True
		rbLakiLaki.Location = New Point(15, 25)
		rbLakiLaki.Name = "rbLakiLaki"
		rbLakiLaki.Size = New Size(100, 27)
		rbLakiLaki.TabIndex = 0
		rbLakiLaki.Text = "Laki-laki"
		rbLakiLaki.UseVisualStyleBackColor = True
		' 
		' dtpTanggalLahir
		' 
		dtpTanggalLahir.Location = New Point(170, 142)
		dtpTanggalLahir.Name = "dtpTanggalLahir"
		dtpTanggalLahir.Size = New Size(380, 30)
		dtpTanggalLahir.TabIndex = 7
		' 
		' lblTanggalLahir
		' 
		lblTanggalLahir.AutoSize = True
		lblTanggalLahir.BackColor = Color.Transparent
		lblTanggalLahir.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblTanggalLahir.Location = New Point(20, 145)
		lblTanggalLahir.Name = "lblTanggalLahir"
		lblTanggalLahir.Size = New Size(132, 23)
		lblTanggalLahir.TabIndex = 6
		lblTanggalLahir.Text = "Tanggal Lahir *"
		' 
		' txtIDAnggota
		' 
		txtIDAnggota.BackColor = Color.Navy
		txtIDAnggota.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		txtIDAnggota.ForeColor = Color.White
		txtIDAnggota.Location = New Point(170, 102)
		txtIDAnggota.MaxLength = 10
		txtIDAnggota.Name = "txtIDAnggota"
		txtIDAnggota.Size = New Size(380, 30)
		txtIDAnggota.TabIndex = 5
		' 
		' lblID
		' 
		lblID.AutoSize = True
		lblID.BackColor = Color.Transparent
		lblID.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblID.Location = New Point(20, 105)
		lblID.Name = "lblID"
		lblID.Size = New Size(116, 23)
		lblID.TabIndex = 4
		lblID.Text = "ID Anggota *"
		' 
		' txtNama
		' 
		txtNama.BackColor = Color.Navy
		txtNama.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		txtNama.ForeColor = Color.White
		txtNama.Location = New Point(170, 62)
		txtNama.MaxLength = 100
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(380, 30)
		txtNama.TabIndex = 3
		' 
		' lblNama
		' 
		lblNama.AutoSize = True
		lblNama.BackColor = Color.Transparent
		lblNama.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblNama.Location = New Point(20, 65)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(144, 23)
		lblNama.TabIndex = 2
		lblNama.Text = "Nama Lengkap *"
		' 
		' lblGaris1
		' 
		lblGaris1.BackColor = Color.FromArgb(CByte(0), CByte(105), CByte(148))
		lblGaris1.Location = New Point(20, 48)
		lblGaris1.Name = "lblGaris1"
		lblGaris1.Size = New Size(860, 2)
		lblGaris1.TabIndex = 1
		lblGaris1.Text = "Label1"
		' 
		' lblHeaderTab1
		' 
		lblHeaderTab1.AutoSize = True
		lblHeaderTab1.BackColor = Color.Transparent
		lblHeaderTab1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblHeaderTab1.Location = New Point(20, 15)
		lblHeaderTab1.Name = "lblHeaderTab1"
		lblHeaderTab1.Size = New Size(275, 31)
		lblHeaderTab1.TabIndex = 0
		lblHeaderTab1.Text = "DATA UTAMA ANGGOTA"
		' 
		' tabKontakInfo
		' 
		tabKontakInfo.BackgroundImage = My.Resources.Resources.laut_2
		tabKontakInfo.BackgroundImageLayout = ImageLayout.Stretch
		tabKontakInfo.Controls.Add(btnPrevTab2)
		tabKontakInfo.Controls.Add(btnNextTab2)
		tabKontakInfo.Controls.Add(txtAlamat)
		tabKontakInfo.Controls.Add(lblAlamat)
		tabKontakInfo.Controls.Add(txtEmail)
		tabKontakInfo.Controls.Add(lblEmail)
		tabKontakInfo.Controls.Add(Label2)
		tabKontakInfo.Controls.Add(lblTelepon)
		tabKontakInfo.Controls.Add(mtbTelepon)
		tabKontakInfo.Controls.Add(Label1)
		tabKontakInfo.Controls.Add(lblHeaderTab2)
		tabKontakInfo.ForeColor = Color.Navy
		tabKontakInfo.Location = New Point(4, 29)
		tabKontakInfo.Name = "tabKontakInfo"
		tabKontakInfo.Padding = New Padding(3)
		tabKontakInfo.Size = New Size(912, 507)
		tabKontakInfo.TabIndex = 1
		tabKontakInfo.Text = "📡  Tab 2 - Kontak & Info"
		tabKontakInfo.UseVisualStyleBackColor = True
		' 
		' btnPrevTab2
		' 
		btnPrevTab2.BackColor = Color.OrangeRed
		btnPrevTab2.Cursor = Cursors.Hand
		btnPrevTab2.FlatAppearance.BorderColor = Color.White
		btnPrevTab2.FlatAppearance.MouseDownBackColor = Color.Brown
		btnPrevTab2.FlatAppearance.MouseOverBackColor = Color.Red
		btnPrevTab2.FlatStyle = FlatStyle.Flat
		btnPrevTab2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnPrevTab2.ForeColor = Color.White
		btnPrevTab2.Location = New Point(20, 450)
		btnPrevTab2.Name = "btnPrevTab2"
		btnPrevTab2.Size = New Size(123, 38)
		btnPrevTab2.TabIndex = 13
		btnPrevTab2.Text = "←  Kembali"
		btnPrevTab2.UseVisualStyleBackColor = False
		' 
		' btnNextTab2
		' 
		btnNextTab2.BackColor = Color.Navy
		btnNextTab2.Cursor = Cursors.Hand
		btnNextTab2.FlatAppearance.BorderColor = Color.White
		btnNextTab2.FlatAppearance.MouseDownBackColor = Color.DodgerBlue
		btnNextTab2.FlatAppearance.MouseOverBackColor = Color.Blue
		btnNextTab2.FlatStyle = FlatStyle.Flat
		btnNextTab2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnNextTab2.ForeColor = Color.White
		btnNextTab2.Location = New Point(604, 450)
		btnNextTab2.Name = "btnNextTab2"
		btnNextTab2.Size = New Size(298, 38)
		btnNextTab2.TabIndex = 12
		btnNextTab2.Text = "Lanjut ke Profil dan Aktivitas  →"
		btnNextTab2.UseVisualStyleBackColor = False
		' 
		' txtAlamat
		' 
		txtAlamat.BackColor = Color.Navy
		txtAlamat.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		txtAlamat.ForeColor = Color.White
		txtAlamat.Location = New Point(190, 145)
		txtAlamat.MaxLength = 500
		txtAlamat.Multiline = True
		txtAlamat.Name = "txtAlamat"
		txtAlamat.ScrollBars = ScrollBars.Vertical
		txtAlamat.Size = New Size(580, 90)
		txtAlamat.TabIndex = 9
		' 
		' lblAlamat
		' 
		lblAlamat.AutoSize = True
		lblAlamat.BackColor = Color.Transparent
		lblAlamat.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblAlamat.Location = New Point(20, 145)
		lblAlamat.Name = "lblAlamat"
		lblAlamat.Size = New Size(155, 23)
		lblAlamat.TabIndex = 8
		lblAlamat.Text = "Alamat Lengkap *"
		' 
		' txtEmail
		' 
		txtEmail.BackColor = Color.Navy
		txtEmail.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		txtEmail.ForeColor = Color.White
		txtEmail.Location = New Point(190, 105)
		txtEmail.MaxLength = 100
		txtEmail.Name = "txtEmail"
		txtEmail.Size = New Size(380, 30)
		txtEmail.TabIndex = 7
		' 
		' lblEmail
		' 
		lblEmail.AutoSize = True
		lblEmail.BackColor = Color.Transparent
		lblEmail.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblEmail.Location = New Point(20, 105)
		lblEmail.Name = "lblEmail"
		lblEmail.Size = New Size(130, 23)
		lblEmail.TabIndex = 6
		lblEmail.Text = "Alamat Email *"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = Color.Transparent
		Label2.Font = New Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		Label2.Location = New Point(446, 69)
		Label2.Name = "Label2"
		Label2.Size = New Size(149, 17)
		Label2.TabIndex = 5
		Label2.Text = "Format: 0812-3456-7890"
		' 
		' lblTelepon
		' 
		lblTelepon.AutoSize = True
		lblTelepon.BackColor = Color.Transparent
		lblTelepon.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblTelepon.Location = New Point(20, 65)
		lblTelepon.Name = "lblTelepon"
		lblTelepon.Size = New Size(146, 23)
		lblTelepon.TabIndex = 4
		lblTelepon.Text = "Nomor Telepon *"
		' 
		' mtbTelepon
		' 
		mtbTelepon.BackColor = Color.Navy
		mtbTelepon.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		mtbTelepon.ForeColor = Color.White
		mtbTelepon.Location = New Point(190, 65)
		mtbTelepon.Mask = "0000-0000-0000"
		mtbTelepon.Name = "mtbTelepon"
		mtbTelepon.Size = New Size(250, 30)
		mtbTelepon.TabIndex = 3
		' 
		' Label1
		' 
		Label1.BackColor = Color.FromArgb(CByte(0), CByte(105), CByte(148))
		Label1.Location = New Point(20, 48)
		Label1.Name = "Label1"
		Label1.Size = New Size(860, 2)
		Label1.TabIndex = 2
		Label1.Text = "Label1"
		' 
		' lblHeaderTab2
		' 
		lblHeaderTab2.AutoSize = True
		lblHeaderTab2.BackColor = Color.Transparent
		lblHeaderTab2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblHeaderTab2.Location = New Point(20, 15)
		lblHeaderTab2.Name = "lblHeaderTab2"
		lblHeaderTab2.Size = New Size(284, 31)
		lblHeaderTab2.TabIndex = 1
		lblHeaderTab2.Text = "KONTAK dan INFORMASI"
		' 
		' tabProfilAktivitas
		' 
		tabProfilAktivitas.BackgroundImage = My.Resources.Resources.laut_2
		tabProfilAktivitas.BackgroundImageLayout = ImageLayout.Stretch
		tabProfilAktivitas.Controls.Add(btnSimpanCetak)
		tabProfilAktivitas.Controls.Add(btnPrevTab3)
		tabProfilAktivitas.Controls.Add(grpHobi)
		tabProfilAktivitas.Controls.Add(grpPeran)
		tabProfilAktivitas.Controls.Add(btnBrowseFoto)
		tabProfilAktivitas.Controls.Add(picFoto)
		tabProfilAktivitas.ForeColor = Color.Navy
		tabProfilAktivitas.Location = New Point(4, 29)
		tabProfilAktivitas.Name = "tabProfilAktivitas"
		tabProfilAktivitas.Padding = New Padding(3)
		tabProfilAktivitas.Size = New Size(912, 507)
		tabProfilAktivitas.TabIndex = 2
		tabProfilAktivitas.Text = ChrW(55358) & ChrW(56639) & "  Tab 3 - Profil & Aktivitas"
		tabProfilAktivitas.UseVisualStyleBackColor = True
		' 
		' btnSimpanCetak
		' 
		btnSimpanCetak.BackColor = Color.Navy
		btnSimpanCetak.Cursor = Cursors.Hand
		btnSimpanCetak.FlatAppearance.BorderColor = Color.White
		btnSimpanCetak.FlatAppearance.MouseDownBackColor = Color.DodgerBlue
		btnSimpanCetak.FlatAppearance.MouseOverBackColor = Color.Blue
		btnSimpanCetak.FlatStyle = FlatStyle.Flat
		btnSimpanCetak.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnSimpanCetak.ForeColor = Color.White
		btnSimpanCetak.Location = New Point(655, 450)
		btnSimpanCetak.Name = "btnSimpanCetak"
		btnSimpanCetak.Size = New Size(242, 38)
		btnSimpanCetak.TabIndex = 17
		btnSimpanCetak.Text = "Simpan dan Cetak Kartu"
		btnSimpanCetak.UseVisualStyleBackColor = False
		' 
		' btnPrevTab3
		' 
		btnPrevTab3.BackColor = Color.OrangeRed
		btnPrevTab3.Cursor = Cursors.Hand
		btnPrevTab3.FlatAppearance.BorderColor = Color.White
		btnPrevTab3.FlatAppearance.MouseDownBackColor = Color.Brown
		btnPrevTab3.FlatAppearance.MouseOverBackColor = Color.Red
		btnPrevTab3.FlatStyle = FlatStyle.Flat
		btnPrevTab3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnPrevTab3.ForeColor = Color.White
		btnPrevTab3.Location = New Point(20, 450)
		btnPrevTab3.Name = "btnPrevTab3"
		btnPrevTab3.Size = New Size(123, 38)
		btnPrevTab3.TabIndex = 16
		btnPrevTab3.Text = "←  Kembali"
		btnPrevTab3.UseVisualStyleBackColor = False
		' 
		' grpHobi
		' 
		grpHobi.Controls.Add(cbSpearfishing)
		grpHobi.Controls.Add(cbNightDive)
		grpHobi.Controls.Add(cbRescue)
		grpHobi.Controls.Add(cbKonservasi)
		grpHobi.Controls.Add(cbFotografiLaut)
		grpHobi.Controls.Add(cbSnorkeling)
		grpHobi.Controls.Add(cbFreediving)
		grpHobi.Controls.Add(cbScubaDiving)
		grpHobi.Location = New Point(405, 90)
		grpHobi.Name = "grpHobi"
		grpHobi.Size = New Size(391, 155)
		grpHobi.TabIndex = 15
		grpHobi.TabStop = False
		grpHobi.Text = "Hobi & Aktivitas (pilih minimal 1) *"
		' 
		' cbSpearfishing
		' 
		cbSpearfishing.AutoSize = True
		cbSpearfishing.Location = New Point(250, 89)
		cbSpearfishing.Name = "cbSpearfishing"
		cbSpearfishing.Size = New Size(118, 24)
		cbSpearfishing.TabIndex = 7
		cbSpearfishing.Text = "Spearfishing"
		cbSpearfishing.UseVisualStyleBackColor = True
		' 
		' cbNightDive
		' 
		cbNightDive.AutoSize = True
		cbNightDive.Location = New Point(250, 59)
		cbNightDive.Name = "cbNightDive"
		cbNightDive.Size = New Size(106, 24)
		cbNightDive.TabIndex = 6
		cbNightDive.Text = "Night Dive"
		cbNightDive.UseVisualStyleBackColor = True
		' 
		' cbRescue
		' 
		cbRescue.AutoSize = True
		cbRescue.Location = New Point(250, 28)
		cbRescue.Name = "cbRescue"
		cbRescue.Size = New Size(129, 24)
		cbRescue.TabIndex = 5
		cbRescue.Text = "Rescue Diving"
		cbRescue.UseVisualStyleBackColor = True
		' 
		' cbKonservasi
		' 
		cbKonservasi.AutoSize = True
		cbKonservasi.Location = New Point(15, 118)
		cbKonservasi.Name = "cbKonservasi"
		cbKonservasi.Size = New Size(143, 24)
		cbKonservasi.TabIndex = 4
		cbKonservasi.Text = "Konservasi Laut"
		cbKonservasi.UseVisualStyleBackColor = True
		' 
		' cbFotografiLaut
		' 
		cbFotografiLaut.AutoSize = True
		cbFotografiLaut.Location = New Point(15, 88)
		cbFotografiLaut.Name = "cbFotografiLaut"
		cbFotografiLaut.Size = New Size(182, 24)
		cbFotografiLaut.TabIndex = 3
		cbFotografiLaut.Text = "Fotografi Bawah Laut"
		cbFotografiLaut.UseVisualStyleBackColor = True
		' 
		' cbSnorkeling
		' 
		cbSnorkeling.AutoSize = True
		cbSnorkeling.Location = New Point(15, 59)
		cbSnorkeling.Name = "cbSnorkeling"
		cbSnorkeling.Size = New Size(105, 24)
		cbSnorkeling.TabIndex = 2
		cbSnorkeling.Text = "Snorkeling"
		cbSnorkeling.UseVisualStyleBackColor = True
		' 
		' cbFreediving
		' 
		cbFreediving.AutoSize = True
		cbFreediving.Location = New Point(15, 28)
		cbFreediving.Name = "cbFreediving"
		cbFreediving.Size = New Size(104, 24)
		cbFreediving.TabIndex = 1
		cbFreediving.Text = "Freediving"
		cbFreediving.UseVisualStyleBackColor = True
		' 
		' cbScubaDiving
		' 
		cbScubaDiving.AutoSize = True
		cbScubaDiving.Location = New Point(250, 119)
		cbScubaDiving.Name = "cbScubaDiving"
		cbScubaDiving.Size = New Size(121, 24)
		cbScubaDiving.TabIndex = 0
		cbScubaDiving.Text = "Scuba Diving"
		cbScubaDiving.UseVisualStyleBackColor = True
		' 
		' grpPeran
		' 
		grpPeran.Controls.Add(rbPelatih)
		grpPeran.Controls.Add(rbAdmin)
		grpPeran.Controls.Add(rbAnggota)
		grpPeran.Controls.Add(rbKetua)
		grpPeran.Location = New Point(183, 90)
		grpPeran.Name = "grpPeran"
		grpPeran.Size = New Size(205, 150)
		grpPeran.TabIndex = 14
		grpPeran.TabStop = False
		grpPeran.Text = "Peran dalam Komunitas *"
		' 
		' rbPelatih
		' 
		rbPelatih.AutoSize = True
		rbPelatih.Location = New Point(12, 118)
		rbPelatih.Name = "rbPelatih"
		rbPelatih.Size = New Size(78, 24)
		rbPelatih.TabIndex = 4
		rbPelatih.Text = "Pelatih"
		rbPelatih.UseVisualStyleBackColor = True
		' 
		' rbAdmin
		' 
		rbAdmin.AutoSize = True
		rbAdmin.Location = New Point(12, 88)
		rbAdmin.Name = "rbAdmin"
		rbAdmin.Size = New Size(77, 24)
		rbAdmin.TabIndex = 3
		rbAdmin.Text = "Admin"
		rbAdmin.UseVisualStyleBackColor = True
		' 
		' rbAnggota
		' 
		rbAnggota.AutoSize = True
		rbAnggota.Checked = True
		rbAnggota.Location = New Point(12, 58)
		rbAnggota.Name = "rbAnggota"
		rbAnggota.Size = New Size(91, 24)
		rbAnggota.TabIndex = 2
		rbAnggota.TabStop = True
		rbAnggota.Text = "Anggota"
		rbAnggota.UseVisualStyleBackColor = True
		' 
		' rbKetua
		' 
		rbKetua.AutoSize = True
		rbKetua.Location = New Point(12, 28)
		rbKetua.Name = "rbKetua"
		rbKetua.Size = New Size(71, 24)
		rbKetua.TabIndex = 1
		rbKetua.Text = "Ketua"
		rbKetua.UseVisualStyleBackColor = True
		' 
		' btnBrowseFoto
		' 
		btnBrowseFoto.BackColor = Color.Navy
		btnBrowseFoto.Cursor = Cursors.Hand
		btnBrowseFoto.FlatAppearance.BorderColor = Color.White
		btnBrowseFoto.FlatAppearance.MouseDownBackColor = Color.DodgerBlue
		btnBrowseFoto.FlatAppearance.MouseOverBackColor = Color.Blue
		btnBrowseFoto.FlatStyle = FlatStyle.Flat
		btnBrowseFoto.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnBrowseFoto.ForeColor = Color.White
		btnBrowseFoto.Location = New Point(20, 248)
		btnBrowseFoto.Name = "btnBrowseFoto"
		btnBrowseFoto.Size = New Size(130, 46)
		btnBrowseFoto.TabIndex = 13
		btnBrowseFoto.Text = "📁 Browse"
		btnBrowseFoto.UseVisualStyleBackColor = False
		' 
		' picFoto
		' 
		picFoto.BackColor = Color.Navy
		picFoto.BorderStyle = BorderStyle.FixedSingle
		picFoto.Location = New Point(20, 90)
		picFoto.Name = "picFoto"
		picFoto.Size = New Size(130, 150)
		picFoto.SizeMode = PictureBoxSizeMode.Zoom
		picFoto.TabIndex = 0
		picFoto.TabStop = False
		' 
		' epValidasi
		' 
		epValidasi.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
		epValidasi.ContainerControl = Me
		' 
		' lblSubJudul
		' 
		lblSubJudul.AutoSize = True
		lblSubJudul.BackColor = Color.Transparent
		lblSubJudul.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblSubJudul.ForeColor = Color.Navy
		lblSubJudul.Location = New Point(108, 89)
		lblSubJudul.Name = "lblSubJudul"
		lblSubJudul.Size = New Size(515, 25)
		lblSubJudul.TabIndex = 2
		lblSubJudul.Text = "Sistem Kartu Keanggotaan Komunitas Freediver Samarinda"
		' 
		' lblJudul
		' 
		lblJudul.AutoSize = True
		lblJudul.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblJudul.ForeColor = Color.Navy
		lblJudul.Location = New Point(105, 44)
		lblJudul.Name = "lblJudul"
		lblJudul.Size = New Size(484, 50)
		lblJudul.TabIndex = 1
		lblJudul.Text = "SAMARENDAH FREEDIVER"
		' 
		' picLogo
		' 
		picLogo.Image = My.Resources.Resources.logo_fdr
		picLogo.Location = New Point(12, 44)
		picLogo.Name = "picLogo"
		picLogo.Size = New Size(70, 70)
		picLogo.SizeMode = PictureBoxSizeMode.StretchImage
		picLogo.TabIndex = 0
		picLogo.TabStop = False
		' 
		' FormUtama
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.LightSkyBlue
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(932, 653)
		Controls.Add(lblSubJudul)
		Controls.Add(lblJudul)
		Controls.Add(tabMain)
		Controls.Add(picLogo)
		Controls.Add(mnuStrip)
		ForeColor = Color.FromArgb(CByte(200), CByte(240), CByte(245))
		FormBorderStyle = FormBorderStyle.FixedSingle
		MainMenuStrip = mnuStrip
		MaximizeBox = False
		MinimumSize = New Size(900, 650)
		Name = "FormUtama"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Samarendah Freediver — Kartu Anggota"
		mnuStrip.ResumeLayout(False)
		mnuStrip.PerformLayout()
		tabMain.ResumeLayout(False)
		tabDataUtama.ResumeLayout(False)
		tabDataUtama.PerformLayout()
		grpJenisKelamin.ResumeLayout(False)
		grpJenisKelamin.PerformLayout()
		tabKontakInfo.ResumeLayout(False)
		tabKontakInfo.PerformLayout()
		tabProfilAktivitas.ResumeLayout(False)
		grpHobi.ResumeLayout(False)
		grpHobi.PerformLayout()
		grpPeran.ResumeLayout(False)
		grpPeran.PerformLayout()
		CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
		CType(epValidasi, ComponentModel.ISupportInitialize).EndInit()
		CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents mnuStrip As MenuStrip
	Friend WithEvents mnuInputData As ToolStripMenuItem
	Friend WithEvents mnuLihatKartu As ToolStripMenuItem
	Friend WithEvents mnuSimpanData As ToolStripMenuItem
	Friend WithEvents mnuBukaData As ToolStripMenuItem
	Friend WithEvents mnuKeluar As ToolStripMenuItem
	Friend WithEvents tabMain As TabControl
	Friend WithEvents tabKontakInfo As TabPage
	Friend WithEvents tabDataUtama As TabPage
	Friend WithEvents tabProfilAktivitas As TabPage
	Friend WithEvents lblHeaderTab1 As Label
	Friend WithEvents lblGaris1 As Label
	Friend WithEvents txtNama As TextBox
	Friend WithEvents lblNama As Label
	Friend WithEvents txtIDAnggota As TextBox
	Friend WithEvents lblID As Label
	Friend WithEvents lblTanggalLahir As Label
	Friend WithEvents dtpTanggalLahir As DateTimePicker
	Friend WithEvents grpJenisKelamin As GroupBox
	Friend WithEvents rbPerempuan As RadioButton
	Friend WithEvents rbLakiLaki As RadioButton
	Friend WithEvents lblKomunitas As Label
	Friend WithEvents cmbKomunitas As ComboBox
	Friend WithEvents btnNextTab1 As Button
	Friend WithEvents lblHeaderTab2 As Label
	Friend WithEvents mtbTelepon As MaskedTextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents lblTelepon As Label
	Friend WithEvents lblEmail As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents lblAlamat As Label
	Friend WithEvents txtAlamat As TextBox
	Friend WithEvents epValidasi As ErrorProvider
	Friend WithEvents btnNextTab2 As Button
	Friend WithEvents btnPrevTab2 As Button
	Friend WithEvents picFoto As PictureBox
	Friend WithEvents btnBrowseFoto As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents grpPeran As GroupBox
	Friend WithEvents rbKetua As RadioButton
	Friend WithEvents rbAnggota As RadioButton
	Friend WithEvents rbPelatih As RadioButton
	Friend WithEvents rbAdmin As RadioButton
	Friend WithEvents grpHobi As GroupBox
	Friend WithEvents cbFreediving As CheckBox
	Friend WithEvents cbScubaDiving As CheckBox
	Friend WithEvents cbNightDive As CheckBox
	Friend WithEvents cbRescue As CheckBox
	Friend WithEvents cbKonservasi As CheckBox
	Friend WithEvents cbFotografiLaut As CheckBox
	Friend WithEvents cbSnorkeling As CheckBox
	Friend WithEvents cbSpearfishing As CheckBox
	Friend WithEvents btnSimpanCetak As Button
	Friend WithEvents btnPrevTab3 As Button
	Friend WithEvents lblSubJudul As Label
	Friend WithEvents lblJudul As Label
	Friend WithEvents picLogo As PictureBox

End Class
