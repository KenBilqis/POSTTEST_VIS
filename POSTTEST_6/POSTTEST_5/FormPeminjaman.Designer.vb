<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPeminjaman
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
		components = New ComponentModel.Container()
		picBgPinjam = New PictureBox()
		lblJudulPinjam = New Label()
		Label4 = New Label()
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		dtpTglPinjam = New DateTimePicker()
		cmbPeralatan = New ComboBox()
		txtNamaPeminjam = New TextBox()
		dtpTglKembali = New DateTimePicker()
		Label5 = New Label()
		Label6 = New Label()
		Label7 = New Label()
		cmbStatus = New ComboBox()
		txtKeteranganPinjam = New TextBox()
		txtSearchPinjam = New TextBox()
		btnSimpanPinjam = New Button()
		dgvPeminjaman = New DataGridView()
		btnUbahPinjam = New Button()
		btnHapusPinjam = New Button()
		btnBatalPinjam = New Button()
		ErrorProvider1 = New ErrorProvider(components)
		lblStatusPinjam = New Label()
		CType(picBgPinjam, ComponentModel.ISupportInitialize).BeginInit()
		CType(dgvPeminjaman, ComponentModel.ISupportInitialize).BeginInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' picBgPinjam
		' 
		picBgPinjam.Image = My.Resources.Resources.laut_3
		picBgPinjam.Location = New Point(0, 0)
		picBgPinjam.Name = "picBgPinjam"
		picBgPinjam.Size = New Size(1100, 680)
		picBgPinjam.SizeMode = PictureBoxSizeMode.StretchImage
		picBgPinjam.TabIndex = 0
		picBgPinjam.TabStop = False
		' 
		' lblJudulPinjam
		' 
		lblJudulPinjam.BackColor = Color.Transparent
		lblJudulPinjam.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblJudulPinjam.ForeColor = Color.DarkBlue
		lblJudulPinjam.Location = New Point(10, 10)
		lblJudulPinjam.Name = "lblJudulPinjam"
		lblJudulPinjam.Size = New Size(1060, 50)
		lblJudulPinjam.TabIndex = 2
		lblJudulPinjam.Text = "DATA PEMINJAMAN PERALATAN"
		lblJudulPinjam.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.BackColor = Color.Transparent
		Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label4.ForeColor = Color.DarkBlue
		Label4.Location = New Point(20, 215)
		Label4.Name = "Label4"
		Label4.Size = New Size(105, 23)
		Label4.TabIndex = 4
		Label4.Text = "Tgl Kembali"
		Label4.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.Transparent
		Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label1.ForeColor = Color.DarkBlue
		Label1.Location = New Point(20, 80)
		Label1.Name = "Label1"
		Label1.Size = New Size(84, 23)
		Label1.TabIndex = 5
		Label1.Text = "Peralatan"
		Label1.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = Color.Transparent
		Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label2.ForeColor = Color.DarkBlue
		Label2.Location = New Point(20, 125)
		Label2.Name = "Label2"
		Label2.Size = New Size(146, 23)
		Label2.TabIndex = 6
		Label2.Text = " Nama Peminjam"
		Label2.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.BackColor = Color.Transparent
		Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label3.ForeColor = Color.DarkBlue
		Label3.Location = New Point(20, 170)
		Label3.Name = "Label3"
		Label3.Size = New Size(94, 23)
		Label3.TabIndex = 7
		Label3.Text = "Tgl Pinjam"
		Label3.TextAlign = ContentAlignment.MiddleCenter
		' 
		' dtpTglPinjam
		' 
		dtpTglPinjam.Location = New Point(160, 166)
		dtpTglPinjam.Name = "dtpTglPinjam"
		dtpTglPinjam.Size = New Size(271, 27)
		dtpTglPinjam.TabIndex = 8
		' 
		' cmbPeralatan
		' 
		cmbPeralatan.FormattingEnabled = True
		cmbPeralatan.Location = New Point(160, 76)
		cmbPeralatan.Name = "cmbPeralatan"
		cmbPeralatan.Size = New Size(350, 28)
		cmbPeralatan.TabIndex = 9
		' 
		' txtNamaPeminjam
		' 
		txtNamaPeminjam.Location = New Point(160, 121)
		txtNamaPeminjam.Name = "txtNamaPeminjam"
		txtNamaPeminjam.Size = New Size(350, 27)
		txtNamaPeminjam.TabIndex = 10
		' 
		' dtpTglKembali
		' 
		dtpTglKembali.Location = New Point(160, 211)
		dtpTglKembali.Name = "dtpTglKembali"
		dtpTglKembali.Size = New Size(271, 27)
		dtpTglKembali.TabIndex = 11
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.BackColor = Color.Transparent
		Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label5.ForeColor = Color.DarkBlue
		Label5.Location = New Point(20, 260)
		Label5.Name = "Label5"
		Label5.Size = New Size(60, 23)
		Label5.TabIndex = 12
		Label5.Text = "Status"
		Label5.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.BackColor = Color.Transparent
		Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label6.ForeColor = Color.DarkBlue
		Label6.Location = New Point(20, 305)
		Label6.Name = "Label6"
		Label6.Size = New Size(102, 23)
		Label6.TabIndex = 13
		Label6.Text = "Keterangan"
		Label6.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.BackColor = Color.Transparent
		Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label7.ForeColor = Color.DarkBlue
		Label7.Location = New Point(20, 360)
		Label7.Name = "Label7"
		Label7.Size = New Size(47, 23)
		Label7.TabIndex = 14
		Label7.Text = "Cari:"
		Label7.TextAlign = ContentAlignment.MiddleCenter
		' 
		' cmbStatus
		' 
		cmbStatus.FormattingEnabled = True
		cmbStatus.Items.AddRange(New Object() {"Belum Dikembalikan", "Sudah Dikembalikan", "Terlambat"})
		cmbStatus.Location = New Point(160, 256)
		cmbStatus.Name = "cmbStatus"
		cmbStatus.Size = New Size(200, 28)
		cmbStatus.TabIndex = 15
		' 
		' txtKeteranganPinjam
		' 
		txtKeteranganPinjam.Location = New Point(160, 301)
		txtKeteranganPinjam.Name = "txtKeteranganPinjam"
		txtKeteranganPinjam.Size = New Size(350, 27)
		txtKeteranganPinjam.TabIndex = 16
		' 
		' txtSearchPinjam
		' 
		txtSearchPinjam.Location = New Point(160, 356)
		txtSearchPinjam.Name = "txtSearchPinjam"
		txtSearchPinjam.Size = New Size(300, 27)
		txtSearchPinjam.TabIndex = 17
		' 
		' btnSimpanPinjam
		' 
		btnSimpanPinjam.BackColor = Color.DodgerBlue
		btnSimpanPinjam.ForeColor = Color.White
		btnSimpanPinjam.Location = New Point(20, 410)
		btnSimpanPinjam.Name = "btnSimpanPinjam"
		btnSimpanPinjam.Size = New Size(120, 36)
		btnSimpanPinjam.TabIndex = 18
		btnSimpanPinjam.Text = "Simpan"
		btnSimpanPinjam.UseVisualStyleBackColor = False
		' 
		' dgvPeminjaman
		' 
		dgvPeminjaman.AllowUserToAddRows = False
		dgvPeminjaman.AllowUserToDeleteRows = False
		dgvPeminjaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvPeminjaman.Location = New Point(10, 460)
		dgvPeminjaman.Name = "dgvPeminjaman"
		dgvPeminjaman.ReadOnly = True
		dgvPeminjaman.RowHeadersWidth = 51
		dgvPeminjaman.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvPeminjaman.Size = New Size(1060, 200)
		dgvPeminjaman.TabIndex = 19
		' 
		' btnUbahPinjam
		' 
		btnUbahPinjam.BackColor = Color.DodgerBlue
		btnUbahPinjam.ForeColor = Color.White
		btnUbahPinjam.Location = New Point(155, 410)
		btnUbahPinjam.Name = "btnUbahPinjam"
		btnUbahPinjam.Size = New Size(120, 36)
		btnUbahPinjam.TabIndex = 20
		btnUbahPinjam.Text = "Ubah"
		btnUbahPinjam.UseVisualStyleBackColor = False
		' 
		' btnHapusPinjam
		' 
		btnHapusPinjam.BackColor = Color.DodgerBlue
		btnHapusPinjam.ForeColor = Color.White
		btnHapusPinjam.Location = New Point(290, 410)
		btnHapusPinjam.Name = "btnHapusPinjam"
		btnHapusPinjam.Size = New Size(120, 36)
		btnHapusPinjam.TabIndex = 21
		btnHapusPinjam.Text = "Hapus"
		btnHapusPinjam.UseVisualStyleBackColor = False
		' 
		' btnBatalPinjam
		' 
		btnBatalPinjam.BackColor = Color.DodgerBlue
		btnBatalPinjam.ForeColor = Color.White
		btnBatalPinjam.Location = New Point(425, 410)
		btnBatalPinjam.Name = "btnBatalPinjam"
		btnBatalPinjam.Size = New Size(120, 36)
		btnBatalPinjam.TabIndex = 22
		btnBatalPinjam.Text = "Batal"
		btnBatalPinjam.UseVisualStyleBackColor = False
		' 
		' ErrorProvider1
		' 
		ErrorProvider1.ContainerControl = Me
		' 
		' lblStatusPinjam
		' 
		lblStatusPinjam.AutoSize = True
		lblStatusPinjam.BackColor = Color.Transparent
		lblStatusPinjam.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblStatusPinjam.ForeColor = Color.DarkBlue
		lblStatusPinjam.Location = New Point(560, 418)
		lblStatusPinjam.Name = "lblStatusPinjam"
		lblStatusPinjam.Size = New Size(45, 23)
		lblStatusPinjam.TabIndex = 23
		lblStatusPinjam.Text = "Siap"
		lblStatusPinjam.TextAlign = ContentAlignment.MiddleCenter
		' 
		' FormPeminjaman
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(1082, 633)
		Controls.Add(lblStatusPinjam)
		Controls.Add(btnBatalPinjam)
		Controls.Add(btnHapusPinjam)
		Controls.Add(btnUbahPinjam)
		Controls.Add(dgvPeminjaman)
		Controls.Add(btnSimpanPinjam)
		Controls.Add(txtSearchPinjam)
		Controls.Add(txtKeteranganPinjam)
		Controls.Add(cmbStatus)
		Controls.Add(Label7)
		Controls.Add(Label6)
		Controls.Add(Label5)
		Controls.Add(dtpTglKembali)
		Controls.Add(txtNamaPeminjam)
		Controls.Add(cmbPeralatan)
		Controls.Add(dtpTglPinjam)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(Label4)
		Controls.Add(lblJudulPinjam)
		Controls.Add(picBgPinjam)
		Name = "FormPeminjaman"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Data Peminjaman Peralatan"
		CType(picBgPinjam, ComponentModel.ISupportInitialize).EndInit()
		CType(dgvPeminjaman, ComponentModel.ISupportInitialize).EndInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents picBgPinjam As PictureBox
	Friend WithEvents lblJudulPinjam As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents dtpTglPinjam As DateTimePicker
	Friend WithEvents cmbPeralatan As ComboBox
	Friend WithEvents txtNamaPeminjam As TextBox
	Friend WithEvents dtpTglKembali As DateTimePicker
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents cmbStatus As ComboBox
	Friend WithEvents txtKeteranganPinjam As TextBox
	Friend WithEvents txtSearchPinjam As TextBox
	Friend WithEvents btnSimpanPinjam As Button
	Friend WithEvents dgvPeminjaman As DataGridView
	Friend WithEvents btnUbahPinjam As Button
	Friend WithEvents btnHapusPinjam As Button
	Friend WithEvents btnBatalPinjam As Button
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents lblStatusPinjam As Label
End Class
