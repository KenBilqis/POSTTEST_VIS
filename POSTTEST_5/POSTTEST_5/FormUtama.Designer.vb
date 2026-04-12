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
		MenuStrip1 = New MenuStrip()
		DataPeralatanToolStripMenuItem = New ToolStripMenuItem()
		TambahDataToolStripMenuItem = New ToolStripMenuItem()
		KeluarToolStripMenuItem = New ToolStripMenuItem()
		lblJudul = New Label()
		lblCari = New Label()
		txtSearch = New TextBox()
		dgvPeralatan = New DataGridView()
		btnTambah = New Button()
		btnUbah = New Button()
		btnHapus = New Button()
		lblStatus = New Label()
		picBg = New PictureBox()
		MenuStrip1.SuspendLayout()
		CType(dgvPeralatan, ComponentModel.ISupportInitialize).BeginInit()
		CType(picBg, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.BackColor = Color.DodgerBlue
		MenuStrip1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		MenuStrip1.ImageScalingSize = New Size(20, 20)
		MenuStrip1.Items.AddRange(New ToolStripItem() {DataPeralatanToolStripMenuItem, KeluarToolStripMenuItem})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(1082, 31)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' DataPeralatanToolStripMenuItem
		' 
		DataPeralatanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TambahDataToolStripMenuItem})
		DataPeralatanToolStripMenuItem.Name = "DataPeralatanToolStripMenuItem"
		DataPeralatanToolStripMenuItem.Size = New Size(141, 27)
		DataPeralatanToolStripMenuItem.Text = "Data Peralatan"
		' 
		' TambahDataToolStripMenuItem
		' 
		TambahDataToolStripMenuItem.Name = "TambahDataToolStripMenuItem"
		TambahDataToolStripMenuItem.Size = New Size(201, 28)
		TambahDataToolStripMenuItem.Text = "Tambah Data"
		' 
		' KeluarToolStripMenuItem
		' 
		KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
		KeluarToolStripMenuItem.Size = New Size(75, 27)
		KeluarToolStripMenuItem.Text = "Keluar"
		' 
		' lblJudul
		' 
		lblJudul.BackColor = Color.Transparent
		lblJudul.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblJudul.ForeColor = Color.DarkBlue
		lblJudul.Location = New Point(12, 30)
		lblJudul.Name = "lblJudul"
		lblJudul.Size = New Size(1060, 50)
		lblJudul.TabIndex = 1
		lblJudul.Text = "INVENTARIS PERALATAN FREEDIVER"
		lblJudul.TextAlign = ContentAlignment.MiddleCenter
		' 
		' lblCari
		' 
		lblCari.BackColor = Color.Transparent
		lblCari.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblCari.ForeColor = Color.DarkBlue
		lblCari.Location = New Point(12, 103)
		lblCari.Name = "lblCari"
		lblCari.Size = New Size(1060, 50)
		lblCari.TabIndex = 2
		lblCari.Text = "Cari Peralatan:"
		lblCari.TextAlign = ContentAlignment.MiddleCenter
		' 
		' txtSearch
		' 
		txtSearch.BackColor = Color.DodgerBlue
		txtSearch.ForeColor = Color.White
		txtSearch.Location = New Point(387, 156)
		txtSearch.Name = "txtSearch"
		txtSearch.Size = New Size(300, 27)
		txtSearch.TabIndex = 3
		' 
		' dgvPeralatan
		' 
		dgvPeralatan.AllowUserToAddRows = False
		dgvPeralatan.AllowUserToDeleteRows = False
		dgvPeralatan.BackgroundColor = Color.DodgerBlue
		dgvPeralatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvPeralatan.Location = New Point(12, 203)
		dgvPeralatan.Name = "dgvPeralatan"
		dgvPeralatan.ReadOnly = True
		dgvPeralatan.RowHeadersWidth = 51
		dgvPeralatan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvPeralatan.Size = New Size(1060, 450)
		dgvPeralatan.TabIndex = 4
		' 
		' btnTambah
		' 
		btnTambah.BackColor = Color.DodgerBlue
		btnTambah.ForeColor = Color.White
		btnTambah.Location = New Point(10, 673)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(140, 36)
		btnTambah.TabIndex = 5
		btnTambah.Text = "Tambah Data"
		btnTambah.UseVisualStyleBackColor = False
		' 
		' btnUbah
		' 
		btnUbah.BackColor = Color.DodgerBlue
		btnUbah.ForeColor = Color.White
		btnUbah.Location = New Point(468, 673)
		btnUbah.Name = "btnUbah"
		btnUbah.Size = New Size(140, 36)
		btnUbah.TabIndex = 6
		btnUbah.Text = "Ubah Data"
		btnUbah.UseVisualStyleBackColor = False
		' 
		' btnHapus
		' 
		btnHapus.BackColor = Color.DodgerBlue
		btnHapus.ForeColor = Color.White
		btnHapus.Location = New Point(930, 673)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(140, 36)
		btnHapus.TabIndex = 7
		btnHapus.Text = "Hapus Data"
		btnHapus.UseVisualStyleBackColor = False
		' 
		' lblStatus
		' 
		lblStatus.BackColor = Color.Transparent
		lblStatus.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblStatus.ForeColor = Color.DarkBlue
		lblStatus.Location = New Point(12, 80)
		lblStatus.Name = "lblStatus"
		lblStatus.Size = New Size(1060, 40)
		lblStatus.TabIndex = 8
		lblStatus.Text = "Selamat datang di sistem inventaris Samarinda Freediver"
		lblStatus.TextAlign = ContentAlignment.MiddleCenter
		' 
		' picBg
		' 
		picBg.BackgroundImageLayout = ImageLayout.None
		picBg.Image = My.Resources.Resources.laut_3
		picBg.Location = New Point(0, 0)
		picBg.Name = "picBg"
		picBg.Size = New Size(1100, 768)
		picBg.SizeMode = PictureBoxSizeMode.StretchImage
		picBg.TabIndex = 9
		picBg.TabStop = False
		' 
		' FormUtama
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		BackgroundImageLayout = ImageLayout.Stretch
		ClientSize = New Size(1082, 721)
		Controls.Add(lblStatus)
		Controls.Add(btnHapus)
		Controls.Add(btnUbah)
		Controls.Add(btnTambah)
		Controls.Add(dgvPeralatan)
		Controls.Add(txtSearch)
		Controls.Add(lblCari)
		Controls.Add(lblJudul)
		Controls.Add(MenuStrip1)
		Controls.Add(picBg)
		MainMenuStrip = MenuStrip1
		Name = "FormUtama"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Samarinda Freediver - Manajemen Inventaris"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		CType(dgvPeralatan, ComponentModel.ISupportInitialize).EndInit()
		CType(picBg, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents DataPeralatanToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TambahDataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents lblJudul As Label
	Friend WithEvents lblCari As Label
	Friend WithEvents txtSearch As TextBox
	Friend WithEvents dgvPeralatan As DataGridView
	Friend WithEvents btnTambah As Button
	Friend WithEvents btnUbah As Button
	Friend WithEvents btnHapus As Button
	Friend WithEvents lblStatus As Label
	Friend WithEvents picBg As PictureBox

End Class
