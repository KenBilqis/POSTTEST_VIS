<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
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
		lblJudulInput = New Label()
		TabControl1 = New TabControl()
		tabDataUtama = New TabPage()
		txtStok = New TextBox()
		Label4 = New Label()
		dtpTanggal = New DateTimePicker()
		Label3 = New Label()
		cmbKondisi = New ComboBox()
		Label2 = New Label()
		cmbKategori = New ComboBox()
		Label1 = New Label()
		txtNama = New TextBox()
		lblCari = New Label()
		tabKeterangan = New TabPage()
		txtKeterangan = New TextBox()
		Label5 = New Label()
		btnSimpanInput = New Button()
		btnBatalInput = New Button()
		ErrorProvider1 = New ErrorProvider(components)
		picBgInput = New PictureBox()
		TabControl1.SuspendLayout()
		tabDataUtama.SuspendLayout()
		tabKeterangan.SuspendLayout()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		CType(picBgInput, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' lblJudulInput
		' 
		lblJudulInput.BackColor = Color.Transparent
		lblJudulInput.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblJudulInput.ForeColor = Color.DarkBlue
		lblJudulInput.Location = New Point(10, 15)
		lblJudulInput.Name = "lblJudulInput"
		lblJudulInput.Size = New Size(660, 45)
		lblJudulInput.TabIndex = 2
		lblJudulInput.Text = "FORM INPUT PERALATAN"
		lblJudulInput.TextAlign = ContentAlignment.MiddleCenter
		' 
		' TabControl1
		' 
		TabControl1.Controls.Add(tabDataUtama)
		TabControl1.Controls.Add(tabKeterangan)
		TabControl1.Location = New Point(10, 70)
		TabControl1.Name = "TabControl1"
		TabControl1.SelectedIndex = 0
		TabControl1.Size = New Size(660, 420)
		TabControl1.TabIndex = 3
		' 
		' tabDataUtama
		' 
		tabDataUtama.BackColor = Color.DodgerBlue
		tabDataUtama.Controls.Add(txtStok)
		tabDataUtama.Controls.Add(Label4)
		tabDataUtama.Controls.Add(dtpTanggal)
		tabDataUtama.Controls.Add(Label3)
		tabDataUtama.Controls.Add(cmbKondisi)
		tabDataUtama.Controls.Add(Label2)
		tabDataUtama.Controls.Add(cmbKategori)
		tabDataUtama.Controls.Add(Label1)
		tabDataUtama.Controls.Add(txtNama)
		tabDataUtama.Controls.Add(lblCari)
		tabDataUtama.Location = New Point(4, 29)
		tabDataUtama.Name = "tabDataUtama"
		tabDataUtama.Padding = New Padding(3)
		tabDataUtama.Size = New Size(652, 387)
		tabDataUtama.TabIndex = 0
		tabDataUtama.Text = "Data Utama"
		' 
		' txtStok
		' 
		txtStok.Location = New Point(160, 196)
		txtStok.Name = "txtStok"
		txtStok.Size = New Size(100, 27)
		txtStok.TabIndex = 12
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.BackColor = Color.Transparent
		Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label4.ForeColor = Color.White
		Label4.Location = New Point(20, 200)
		Label4.Name = "Label4"
		Label4.Size = New Size(47, 23)
		Label4.TabIndex = 11
		Label4.Text = "Stok"
		Label4.TextAlign = ContentAlignment.MiddleCenter
		' 
		' dtpTanggal
		' 
		dtpTanggal.Location = New Point(160, 151)
		dtpTanggal.Name = "dtpTanggal"
		dtpTanggal.Size = New Size(250, 27)
		dtpTanggal.TabIndex = 10
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.BackColor = Color.Transparent
		Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label3.ForeColor = Color.White
		Label3.Location = New Point(20, 155)
		Label3.Name = "Label3"
		Label3.Size = New Size(131, 23)
		Label3.TabIndex = 9
		Label3.Text = "Tanggal Masuk"
		Label3.TextAlign = ContentAlignment.MiddleCenter
		' 
		' cmbKondisi
		' 
		cmbKondisi.FormattingEnabled = True
		cmbKondisi.Items.AddRange(New Object() {"Baik", "Cukup Baik", "Perlu Servis", "Rusak"})
		cmbKondisi.Location = New Point(160, 106)
		cmbKondisi.Name = "cmbKondisi"
		cmbKondisi.Size = New Size(200, 28)
		cmbKondisi.TabIndex = 8
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = Color.Transparent
		Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label2.ForeColor = Color.White
		Label2.Location = New Point(20, 110)
		Label2.Name = "Label2"
		Label2.Size = New Size(69, 23)
		Label2.TabIndex = 7
		Label2.Text = "Kondisi"
		Label2.TextAlign = ContentAlignment.MiddleCenter
		' 
		' cmbKategori
		' 
		cmbKategori.FormattingEnabled = True
		cmbKategori.Items.AddRange(New Object() {"Masker", "Fins", "Wetsuit", "Snorkel", "Weight Belt", "Buoy", "Lanyard"})
		cmbKategori.Location = New Point(160, 61)
		cmbKategori.Name = "cmbKategori"
		cmbKategori.Size = New Size(250, 28)
		cmbKategori.TabIndex = 6
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.Transparent
		Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label1.ForeColor = Color.White
		Label1.Location = New Point(20, 65)
		Label1.Name = "Label1"
		Label1.Size = New Size(79, 23)
		Label1.TabIndex = 5
		Label1.Text = "Kategori"
		Label1.TextAlign = ContentAlignment.MiddleCenter
		' 
		' txtNama
		' 
		txtNama.Location = New Point(160, 16)
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(400, 27)
		txtNama.TabIndex = 4
		' 
		' lblCari
		' 
		lblCari.AutoSize = True
		lblCari.BackColor = Color.Transparent
		lblCari.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblCari.ForeColor = Color.White
		lblCari.Location = New Point(20, 20)
		lblCari.Name = "lblCari"
		lblCari.Size = New Size(136, 23)
		lblCari.TabIndex = 3
		lblCari.Text = "Nama Peralatan"
		lblCari.TextAlign = ContentAlignment.MiddleCenter
		' 
		' tabKeterangan
		' 
		tabKeterangan.BackColor = Color.DodgerBlue
		tabKeterangan.Controls.Add(txtKeterangan)
		tabKeterangan.Controls.Add(Label5)
		tabKeterangan.Location = New Point(4, 29)
		tabKeterangan.Name = "tabKeterangan"
		tabKeterangan.Padding = New Padding(3)
		tabKeterangan.Size = New Size(652, 387)
		tabKeterangan.TabIndex = 1
		tabKeterangan.Text = "Keterangan"
		' 
		' txtKeterangan
		' 
		txtKeterangan.Location = New Point(20, 50)
		txtKeterangan.Multiline = True
		txtKeterangan.Name = "txtKeterangan"
		txtKeterangan.Size = New Size(580, 200)
		txtKeterangan.TabIndex = 6
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.BackColor = Color.Transparent
		Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label5.ForeColor = Color.White
		Label5.Location = New Point(20, 20)
		Label5.Name = "Label5"
		Label5.Size = New Size(102, 23)
		Label5.TabIndex = 5
		Label5.Text = "Keterangan"
		Label5.TextAlign = ContentAlignment.MiddleCenter
		' 
		' btnSimpanInput
		' 
		btnSimpanInput.BackColor = Color.DodgerBlue
		btnSimpanInput.ForeColor = Color.White
		btnSimpanInput.Location = New Point(220, 510)
		btnSimpanInput.Name = "btnSimpanInput"
		btnSimpanInput.Size = New Size(120, 36)
		btnSimpanInput.TabIndex = 6
		btnSimpanInput.Text = "Simpan"
		btnSimpanInput.UseVisualStyleBackColor = False
		' 
		' btnBatalInput
		' 
		btnBatalInput.BackColor = Color.Crimson
		btnBatalInput.ForeColor = Color.White
		btnBatalInput.Location = New Point(360, 510)
		btnBatalInput.Name = "btnBatalInput"
		btnBatalInput.Size = New Size(120, 36)
		btnBatalInput.TabIndex = 7
		btnBatalInput.Text = "Batal"
		btnBatalInput.UseVisualStyleBackColor = False
		' 
		' ErrorProvider1
		' 
		ErrorProvider1.ContainerControl = Me
		' 
		' picBgInput
		' 
		picBgInput.BackgroundImageLayout = ImageLayout.None
		picBgInput.Image = My.Resources.Resources.laut_3
		picBgInput.Location = New Point(0, 0)
		picBgInput.Name = "picBgInput"
		picBgInput.Size = New Size(700, 600)
		picBgInput.SizeMode = PictureBoxSizeMode.StretchImage
		picBgInput.TabIndex = 10
		picBgInput.TabStop = False
		' 
		' FormInput
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(682, 553)
		Controls.Add(btnBatalInput)
		Controls.Add(btnSimpanInput)
		Controls.Add(TabControl1)
		Controls.Add(lblJudulInput)
		Controls.Add(picBgInput)
		FormBorderStyle = FormBorderStyle.FixedSingle
		MaximizeBox = False
		Name = "FormInput"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Form Input Peralatan"
		TabControl1.ResumeLayout(False)
		tabDataUtama.ResumeLayout(False)
		tabDataUtama.PerformLayout()
		tabKeterangan.ResumeLayout(False)
		tabKeterangan.PerformLayout()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		CType(picBgInput, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
	End Sub

	Friend WithEvents lblJudulInput As Label
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents tabDataUtama As TabPage
	Friend WithEvents tabKeterangan As TabPage
	Friend WithEvents txtNama As TextBox
	Friend WithEvents lblCari As Label
	Friend WithEvents cmbKategori As ComboBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents dtpTanggal As DateTimePicker
	Friend WithEvents Label3 As Label
	Friend WithEvents cmbKondisi As ComboBox
	Friend WithEvents txtStok As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents txtKeterangan As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents btnSimpanInput As Button
	Friend WithEvents btnBatalInput As Button
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents picBgInput As PictureBox
End Class
