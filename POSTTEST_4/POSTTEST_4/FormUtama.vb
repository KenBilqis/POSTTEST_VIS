Imports System.IO

Public Class FormUtama
	' Timer untuk animasi
	Private WithEvents tmrFade As New Timer()
	Private WithEvents tmrHoverIn As New Timer()
	Private WithEvents tmrHoverOut As New Timer()
	Private WithEvents tmrOcean As New Timer()

	' Variabel animasi
	Private fadeOpacity As Double = 0.0
	Private currentHoverBtn As Button = Nothing
	Private waveOffset As Integer = 0

	' Warna tema biru laut
	Private ReadOnly clrDeepOcean As Color = Color.FromArgb(5, 15, 40)
	Private ReadOnly clrMidOcean As Color = Color.FromArgb(10, 55, 100)
	Private ReadOnly clrShallowOcean As Color = Color.FromArgb(0, 105, 148)
	Private ReadOnly clrSurface As Color = Color.FromArgb(0, 175, 185)
	Private ReadOnly clrFoam As Color = Color.FromArgb(200, 240, 245)
	Private ReadOnly clrGold As Color = Color.FromArgb(255, 200, 80)

	Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Setup timer
		tmrFade.Interval = 20
		tmrHoverIn.Interval = 15
		tmrHoverOut.Interval = 15
		tmrOcean.Interval = 50

		' Mulai fade in
		Me.Opacity = 0.0
		tmrFade.Start()
		tmrOcean.Start()

		' Atur event validasi karakter
		AddHandler txtNama.KeyPress, AddressOf DataModule.HanyaHuruf
		AddHandler txtIDAnggota.KeyPress, AddressOf DataModule.HanyaAngka

		' Pasang hover pada semua tombol
		PasangHoverTombol(btnNextTab1)
		PasangHoverTombol(btnNextTab2)
		PasangHoverTombol(btnPrevTab2)
		PasangHoverTombol(btnPrevTab3)
		PasangHoverTombol(btnSimpanCetak)
		PasangHoverTombol(btnBrowseFoto)
	End Sub

	Private Sub PasangHoverTombol(btn As Button)
		AddHandler btn.MouseEnter, AddressOf TombolHoverMasuk
		AddHandler btn.MouseLeave, AddressOf TombolHoverKeluar
	End Sub

	Private Sub tmrFade_Tick(sender As Object, e As EventArgs) Handles tmrFade.Tick
		If fadeOpacity < 1.0 Then
			fadeOpacity += 0.04
			Me.Opacity = fadeOpacity
		Else
			Me.Opacity = 1.0
			tmrFade.Stop()
		End If
	End Sub

	Private Sub TombolHoverMasuk(sender As Object, e As EventArgs)
		currentHoverBtn = DirectCast(sender, Button)
		tmrHoverOut.Stop()
		tmrHoverIn.Start()
	End Sub

	Private Sub TombolHoverKeluar(sender As Object, e As EventArgs)
		currentHoverBtn = DirectCast(sender, Button)
		tmrHoverIn.Stop()
		tmrHoverOut.Start()
	End Sub

	Private Sub tmrHoverIn_Tick(sender As Object, e As EventArgs) Handles tmrHoverIn.Tick
		If currentHoverBtn Is Nothing Then
			tmrHoverIn.Stop()
			Return
		End If
		Dim c As Color = currentHoverBtn.BackColor
		Dim r As Integer = Math.Min(c.R + 12, 255)
		Dim g As Integer = Math.Min(c.G + 8, 255)
		Dim b As Integer = Math.Min(c.B + 5, 255)
		currentHoverBtn.BackColor = Color.FromArgb(r, g, b)
		If c.R >= 220 Then tmrHoverIn.Stop()
	End Sub

	Private Sub tmrHoverOut_Tick(sender As Object, e As EventArgs) Handles tmrHoverOut.Tick
		If currentHoverBtn Is Nothing Then
			tmrHoverOut.Stop()
			Return
		End If
		Dim c As Color = currentHoverBtn.BackColor
		Dim r As Integer = Math.Max(c.R - 10, 0)
		Dim g As Integer = Math.Max(c.G - 6, 105)
		Dim b As Integer = Math.Max(c.B - 4, 100)
		currentHoverBtn.BackColor = Color.FromArgb(r, g, b)
		If c.R <= 10 Then tmrHoverOut.Stop()
	End Sub

	Private Sub tmrOcean_Tick(sender As Object, e As EventArgs) Handles tmrOcean.Tick
		waveOffset += 1
		If waveOffset > 200 Then waveOffset = 0
	End Sub

	Private Sub tabMain_DrawItem(sender As Object, e As DrawItemEventArgs) Handles tabMain.DrawItem
		Dim g As Graphics = e.Graphics
		Dim tabBounds As Rectangle = e.Bounds

		Dim bgColor As Color
		Dim fgColor As Color

		If e.Index = tabMain.SelectedIndex Then
			bgColor = clrShallowOcean
			fgColor = clrGold
		Else
			bgColor = clrMidOcean
			fgColor = clrFoam
		End If

		Using brush As New SolidBrush(bgColor)
			g.FillRectangle(brush, tabBounds)
		End Using

		Dim sf As New StringFormat()
		sf.Alignment = StringAlignment.Center
		sf.LineAlignment = StringAlignment.Center

		Using txtBrush As New SolidBrush(fgColor)
			g.DrawString(tabMain.TabPages(e.Index).Text,
				New Font("Segoe UI", 9.5F, FontStyle.Bold),
				txtBrush, tabBounds, sf)
		End Using
	End Sub

	Private Sub tabMain_SelectedIndexChanged(sender As Object, e As EventArgs) _
	Handles tabMain.SelectedIndexChanged

		' Efek fade ringan dengan mengulang invalidate
		Dim tmrTabFade As New Timer()
		tmrTabFade.Interval = 16
		Dim hitungan As Integer = 0
		AddHandler tmrTabFade.Tick, Sub(s, ev)
										hitungan += 1
										tabMain.SelectedTab.Invalidate()
										If hitungan >= 10 Then
											tmrTabFade.Stop()
										End If
									End Sub
		tmrTabFade.Start()
	End Sub

	Private Sub btnNextTab1_Click(sender As Object, e As EventArgs) Handles btnNextTab1.Click
		If ValidasiTab1() Then
			tabMain.SelectedIndex = 1
		End If
	End Sub

	Private Sub btnPrevTab2_Click(sender As Object, e As EventArgs) Handles btnPrevTab2.Click
		tabMain.SelectedIndex = 0
	End Sub

	Private Sub btnNextTab2_Click(sender As Object, e As EventArgs) Handles btnNextTab2.Click
		If ValidasiTab2() Then
			tabMain.SelectedIndex = 2
		End If
	End Sub

	Private Sub btnPrevTab3_Click(sender As Object, e As EventArgs) Handles btnPrevTab3.Click
		tabMain.SelectedIndex = 1
	End Sub

	Private Function ValidasiTab1() As Boolean
		If Not DataModule.ValidasiTextBoxKosong(txtNama,
			"Inputan tidak boleh kosong — Nama wajib diisi!") Then Return False
		If Not DataModule.ValidasiTextBoxKosong(txtIDAnggota,
			"Inputan tidak boleh kosong — ID Anggota wajib diisi!") Then Return False
		If cmbKomunitas.SelectedIndex < 0 Then
			MessageBox.Show("Silakan pilih divisi komunitas!", "Peringatan",
				MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return False
		End If
		Return True
	End Function

	Private Function ValidasiTab2() As Boolean
		If Not mtbTelepon.MaskCompleted Then
			MessageBox.Show("Inputan tidak boleh kosong — Nomor telepon harus " &
				"sesuai format: 0812-3456-7890!", "Peringatan",
				MessageBoxButtons.OK, MessageBoxIcon.Warning)
			mtbTelepon.Focus()
			Return False
		End If
		If Not DataModule.ValidasiTextBoxKosong(txtEmail,
			"Inputan tidak boleh kosong — Email wajib diisi!") Then Return False
		If Not DataModule.ValidasiTextBoxKosong(txtAlamat,
			"Inputan tidak boleh kosong — Alamat wajib diisi!") Then Return False
		Return True
	End Function

	Private Function ValidasiSemuaInput() As Boolean
		If Not ValidasiTab1() Then
			tabMain.SelectedIndex = 0
			Return False
		End If
		If Not ValidasiTab2() Then
			tabMain.SelectedIndex = 1
			Return False
		End If
		Dim daftarCb As CheckBox() = {
			cbFreediving, cbSnorkeling, cbFotografiLaut, cbKonservasi,
			cbRescue, cbNightDive, cbSpearfishing, cbScubaDiving
		}
		If Not DataModule.ValidasiSemuaHobi(daftarCb,
			"Inputan tidak boleh kosong — Pilih minimal 1 hobi/aktivitas!") Then
			tabMain.SelectedIndex = 2
			Return False
		End If
		Return True
	End Function

	Private Sub mtbTelepon_Leave(sender As Object, e As EventArgs) Handles mtbTelepon.Leave
		If Not mtbTelepon.MaskCompleted Then
			epValidasi.SetError(mtbTelepon, "Nomor HP harus lengkap, contoh: 0812-3456-7890")
		Else
			epValidasi.SetError(mtbTelepon, "")
		End If
	End Sub

	Private Sub btnBrowseFoto_Click(sender As Object, e As EventArgs) Handles btnBrowseFoto.Click
		Dim ofd As New OpenFileDialog()
		ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
		ofd.Title = "Pilih Foto Profil Anggota"

		If ofd.ShowDialog() = DialogResult.OK Then
			Dim folderPath As String = Path.Combine(Application.StartupPath, "FotoAnggota")
			Dim namaFile As String = "profil" & Path.GetExtension(ofd.FileName)
			Dim tujuan As String = Path.Combine(folderPath, namaFile)

			If Not Directory.Exists(folderPath) Then
				Directory.CreateDirectory(folderPath)
			End If

			File.Copy(ofd.FileName, tujuan, True)
			DataModule.FotoPath = tujuan

			picFoto.Image = Image.FromFile(tujuan)
			picFoto.SizeMode = PictureBoxSizeMode.Zoom

			MessageBox.Show("Foto profil berhasil diunggah!", "Sukses",
				MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub

	Private Sub KumpulkanData()
		DataModule.NamaAnggota = txtNama.Text.Trim()
		DataModule.IDAAnggota = txtIDAnggota.Text.Trim()
		DataModule.TanggalLahir = dtpTanggalLahir.Value.ToString("dd MMMM yyyy")
		DataModule.JenisKelamin = If(rbLakiLaki.Checked, "Laki-laki", "Perempuan")
		DataModule.JenisKomunitas = cmbKomunitas.Text
		DataModule.NomorTelepon = mtbTelepon.Text
		DataModule.EmailAnggota = txtEmail.Text.Trim()
		DataModule.AlamatAnggota = txtAlamat.Text.Trim()

		If rbKetua.Checked Then
			DataModule.PeranAnggota = "Ketua"
		ElseIf rbAdmin.Checked Then
			DataModule.PeranAnggota = "Admin"
		ElseIf rbPelatih.Checked Then
			DataModule.PeranAnggota = "Pelatih"
		Else
			DataModule.PeranAnggota = "Anggota"
		End If

		Dim hobi As String = ""
		If cbFreediving.Checked Then hobi &= "Freediving, "
		If cbSnorkeling.Checked Then hobi &= "Snorkeling, "
		If cbFotografiLaut.Checked Then hobi &= "Fotografi Laut, "
		If cbKonservasi.Checked Then hobi &= "Konservasi, "
		If cbRescue.Checked Then hobi &= "Rescue Diving, "
		If cbNightDive.Checked Then hobi &= "Night Dive, "
		If cbSpearfishing.Checked Then hobi &= "Spearfishing, "
		If cbScubaDiving.Checked Then hobi &= "Underwater Rugby, "
		If hobi.EndsWith(", ") Then hobi = hobi.Substring(0, hobi.Length - 2)
		DataModule.DaftarHobi = hobi
	End Sub

	Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
		If Not ValidasiSemuaInput() Then Exit Sub

		Dim hasil As DialogResult
		hasil = MessageBox.Show(
			"Apakah Anda yakin ingin membuat kartu anggota?" & vbCrLf &
			"Pastikan semua data sudah benar.",
			"Konfirmasi Cetak Kartu",
			MessageBoxButtons.YesNoCancel,
			MessageBoxIcon.Question
		)

		If hasil = DialogResult.Yes Then
			KumpulkanData()
			Dim frmLoading As New FormLoading()
			frmLoading.Show()
		ElseIf hasil = DialogResult.No Then
			MessageBox.Show("Pembuatan kartu dibatalkan.", "Info",
				MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub

	Private Sub mnuInputData_Click(sender As Object, e As EventArgs) Handles mnuInputData.Click
		tabMain.SelectedIndex = 0
	End Sub

	Private Sub mnuLihatKartu_Click(sender As Object, e As EventArgs) Handles mnuLihatKartu.Click
		If ValidasiSemuaInput() Then
			KumpulkanData()
			Dim frmHasil As New FormHasil()
			frmHasil.Show()
		End If
	End Sub

	Private Sub mnuSimpanData_Click(sender As Object, e As EventArgs) Handles mnuSimpanData.Click
		SimpanDataKeFile()
	End Sub

	Private Sub mnuBukaData_Click(sender As Object, e As EventArgs) Handles mnuBukaData.Click
		BukaDataDariFile()
	End Sub

	Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
		Dim hasil As DialogResult
		hasil = MessageBox.Show("Yakin ingin keluar dari aplikasi?",
			"Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
		If hasil = DialogResult.Yes Then
			Me.Close()
		End If
	End Sub

	Private Sub SimpanDataKeFile()
		If Not ValidasiSemuaInput() Then Exit Sub
		KumpulkanData()

		Dim sfd As New SaveFileDialog()
		sfd.Filter = "Text File|*.txt|CSV File|*.csv"
		sfd.Title = "Simpan Data Anggota"
		sfd.FileName = "Anggota_" & DataModule.IDAAnggota

		If sfd.ShowDialog() = DialogResult.OK Then
			Dim isi As String =
				"=== DATA ANGGOTA SAMARENDAH FREEDIVER ===" & vbCrLf &
				"Nama          : " & DataModule.NamaAnggota & vbCrLf &
				"ID Anggota    : " & DataModule.IDAAnggota & vbCrLf &
				"Tanggal Lahir : " & DataModule.TanggalLahir & vbCrLf &
				"Jenis Kelamin : " & DataModule.JenisKelamin & vbCrLf &
				"Divisi        : " & DataModule.JenisKomunitas & vbCrLf &
				"Telepon       : " & DataModule.NomorTelepon & vbCrLf &
				"Email         : " & DataModule.EmailAnggota & vbCrLf &
				"Alamat        : " & DataModule.AlamatAnggota & vbCrLf &
				"Peran         : " & DataModule.PeranAnggota & vbCrLf &
				"Hobi          : " & DataModule.DaftarHobi & vbCrLf &
				"========================================"
			IO.File.WriteAllText(sfd.FileName, isi)
			MessageBox.Show("Data berhasil disimpan!", "Sukses",
				MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub

	Private Sub BukaDataDariFile()
		Dim ofd As New OpenFileDialog()
		ofd.Filter = "Text File|*.txt|CSV File|*.csv"
		ofd.Title = "Buka Data Anggota"

		If ofd.ShowDialog() = DialogResult.OK Then
			Dim isi As String = IO.File.ReadAllText(ofd.FileName)
			MessageBox.Show(isi, "Data Anggota — " & IO.Path.GetFileName(ofd.FileName),
				MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub

	Private Sub FormUtama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
		If e.CloseReason = CloseReason.UserClosing Then
			Dim hasil As DialogResult
			hasil = MessageBox.Show("Yakin ingin menutup aplikasi?", "Konfirmasi",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			If hasil = DialogResult.No Then
				e.Cancel = True
			End If
		End If
	End Sub

End Class
