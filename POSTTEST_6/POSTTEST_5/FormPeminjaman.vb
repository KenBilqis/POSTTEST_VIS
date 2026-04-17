Public Class FormPeminjaman

    Private _selectedIdPinjam As Integer = -1

    Private Sub FormPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(10, 30, 60)
        AturTampilanPinjam()
        MuatDataPeralatan()
        TampilData()
        AnimasiFadeIn(Me)
    End Sub

    Private Sub AturTampilanPinjam()
        lblJudulPinjam.ForeColor = Color.FromArgb(100, 210, 255)
        lblJudulPinjam.BackColor = Color.Transparent

        For Each lbl As Label In Me.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.White
            lbl.BackColor = Color.Transparent
        Next

        txtNamaPeminjam.BackColor = Color.FromArgb(20, 60, 100)
        txtNamaPeminjam.ForeColor = Color.White
        txtKeteranganPinjam.BackColor = Color.FromArgb(20, 60, 100)
        txtKeteranganPinjam.ForeColor = Color.White
        txtSearchPinjam.BackColor = Color.FromArgb(20, 60, 100)
        txtSearchPinjam.ForeColor = Color.White

        cmbPeralatan.BackColor = Color.FromArgb(20, 60, 100)
        cmbPeralatan.ForeColor = Color.White
        cmbStatus.BackColor = Color.FromArgb(20, 60, 100)
        cmbStatus.ForeColor = Color.White

        AturTombolPinjam(btnSimpanPinjam, Color.FromArgb(0, 120, 200))
        AturTombolPinjam(btnUbahPinjam, Color.FromArgb(0, 150, 100))
        AturTombolPinjam(btnHapusPinjam, Color.FromArgb(180, 40, 40))
        AturTombolPinjam(btnBatalPinjam, Color.FromArgb(80, 80, 90))

        lblStatusPinjam.ForeColor = Color.FromArgb(150, 220, 255)
        lblStatusPinjam.BackColor = Color.Transparent

        AturTampilanDGVPinjam()

        Try
            Dim imgPath As String = Application.StartupPath & "\bg_laut.jpg"
            If System.IO.File.Exists(imgPath) Then
                picBgPinjam.Image = Image.FromFile(imgPath)
                picBgPinjam.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                picBgPinjam.BackColor = Color.FromArgb(10, 30, 60)
            End If
            picBgPinjam.SendToBack()
        Catch ex As Exception
            picBgPinjam.BackColor = Color.FromArgb(10, 30, 60)
        End Try
    End Sub

    Private Sub AturTombolPinjam(btn As Button, warna As Color)
        btn.BackColor = warna
        btn.ForeColor = Color.White
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub AturTampilanDGVPinjam()
        dgvPeminjaman.BackgroundColor = Color.FromArgb(15, 45, 80)
        dgvPeminjaman.GridColor = Color.FromArgb(30, 90, 150)
        dgvPeminjaman.DefaultCellStyle.BackColor = Color.FromArgb(15, 50, 90)
        dgvPeminjaman.DefaultCellStyle.ForeColor = Color.White
        dgvPeminjaman.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 140, 220)
        dgvPeminjaman.DefaultCellStyle.SelectionForeColor = Color.White
        dgvPeminjaman.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 80, 160)
        dgvPeminjaman.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(180, 230, 255)
        dgvPeminjaman.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgvPeminjaman.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(20, 60, 100)
        dgvPeminjaman.RowHeadersVisible = False
        dgvPeminjaman.BorderStyle = BorderStyle.None
    End Sub

    Private Sub AnimasiFadeIn(frm As Form)
        frm.Opacity = 0
        Dim tmr As New Timer()
        tmr.Interval = 20
        AddHandler tmr.Tick, Sub(s, ev)
                                 frm.Opacity += 0.06
                                 If frm.Opacity >= 1 Then
                                     frm.Opacity = 1
                                     tmr.Stop()
                                     tmr.Dispose()
                                 End If
                             End Sub
        tmr.Start()
    End Sub

    Private Sub MuatDataPeralatan()
        Dim dt As DataTable = GetAllPeralatan()
        cmbPeralatan.DataSource = dt
        cmbPeralatan.DisplayMember = "namaAlat"
        cmbPeralatan.ValueMember = "id"
        cmbPeralatan.SelectedIndex = -1
    End Sub

    Private Sub TampilData()
        dgvPeminjaman.DataSource = GetAllPeminjaman()
        AturKolomDGVPinjam()
        lblStatusPinjam.Text = "Total data: " & dgvPeminjaman.Rows.Count & " peminjaman"
    End Sub

    Private Sub AturKolomDGVPinjam()
        If dgvPeminjaman.Columns.Count = 0 Then Exit Sub
        If dgvPeminjaman.Columns.Contains("idPinjam") Then
            dgvPeminjaman.Columns("idPinjam").HeaderText = "ID"
            dgvPeminjaman.Columns("idPinjam").Width = 50
        End If
        If dgvPeminjaman.Columns.Contains("namaAlat") Then
            dgvPeminjaman.Columns("namaAlat").HeaderText = "Peralatan"
            dgvPeminjaman.Columns("namaAlat").Width = 200
        End If
        If dgvPeminjaman.Columns.Contains("namaPeminjam") Then
            dgvPeminjaman.Columns("namaPeminjam").HeaderText = "Nama Peminjam"
            dgvPeminjaman.Columns("namaPeminjam").Width = 180
        End If
        If dgvPeminjaman.Columns.Contains("tanggalPinjam") Then
            dgvPeminjaman.Columns("tanggalPinjam").HeaderText = "Tgl Pinjam"
            dgvPeminjaman.Columns("tanggalPinjam").Width = 110
        End If
        If dgvPeminjaman.Columns.Contains("tanggalKembali") Then
            dgvPeminjaman.Columns("tanggalKembali").HeaderText = "Tgl Kembali"
            dgvPeminjaman.Columns("tanggalKembali").Width = 110
        End If
        If dgvPeminjaman.Columns.Contains("statusKembali") Then
            dgvPeminjaman.Columns("statusKembali").HeaderText = "Status"
            dgvPeminjaman.Columns("statusKembali").Width = 150
        End If
        If dgvPeminjaman.Columns.Contains("keterangan") Then
            dgvPeminjaman.Columns("keterangan").HeaderText = "Keterangan"
            dgvPeminjaman.Columns("keterangan").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub

    Private Sub Kosong()
        cmbPeralatan.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        dtpTglPinjam.Value = DateTime.Today
        dtpTglKembali.Value = DateTime.Today
        cmbStatus.SelectedIndex = -1
        txtKeteranganPinjam.Clear()
        txtSearchPinjam.Clear()
        ErrorProvider1.Clear()
        _selectedIdPinjam = -1
        cmbPeralatan.Focus()
        lblStatusPinjam.Text = "Form dikosongkan."
    End Sub

    Private Sub dgvPeminjaman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPeminjaman.CellClick
        If e.RowIndex >= 0 Then
            Try
                _selectedIdPinjam = Convert.ToInt32(dgvPeminjaman.Rows(e.RowIndex).Cells("idPinjam").Value)
                Dim dt As DataTable = GetPeminjamanById(_selectedIdPinjam)
                If dt.Rows.Count > 0 Then
                    cmbPeralatan.SelectedValue = Convert.ToInt32(dt.Rows(0)("idPeralatan"))
                    txtNamaPeminjam.Text = dt.Rows(0)("namaPeminjam").ToString()
                    dtpTglPinjam.Value = Convert.ToDateTime(dt.Rows(0)("tanggalPinjam"))
                    dtpTglKembali.Value = Convert.ToDateTime(dt.Rows(0)("tanggalKembali"))
                    cmbStatus.Text = dt.Rows(0)("statusKembali").ToString()
                    txtKeteranganPinjam.Text = dt.Rows(0)("keterangan").ToString()
                    lblStatusPinjam.Text = "Data dipilih: " & txtNamaPeminjam.Text
                End If
            Catch ex As Exception
                _selectedIdPinjam = -1
            End Try
        End If
    End Sub

    Private Sub btnSimpanPinjam_Click(sender As Object, e As EventArgs) Handles btnSimpanPinjam.Click
        ErrorProvider1.Clear()
        If Not ValidasiPeminjaman(ErrorProvider1, txtNamaPeminjam, cmbPeralatan) Then Exit Sub
        If cmbStatus.SelectedIndex < 0 Then
            MessageBox.Show("Pilih status peminjaman.", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If dtpTglKembali.Value < dtpTglPinjam.Value Then
            MessageBox.Show("Tanggal kembali tidak boleh sebelum tanggal pinjam.",
                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idAlat As Integer = Convert.ToInt32(cmbPeralatan.SelectedValue)
        Dim nama As String = txtNamaPeminjam.Text.Trim()
        Dim tglPinjam As String = dtpTglPinjam.Value.ToString("yyyy-MM-dd")
        Dim tglKembali As String = dtpTglKembali.Value.ToString("yyyy-MM-dd")
        Dim status As String = cmbStatus.Text
        Dim ket As String = txtKeteranganPinjam.Text.Trim()

        If SimpanPeminjaman(idAlat, nama, tglPinjam, tglKembali, status, ket) Then
            MessageBox.Show("Data peminjaman berhasil disimpan!", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbahPinjam_Click(sender As Object, e As EventArgs) Handles btnUbahPinjam.Click
        If _selectedIdPinjam = -1 Then
            MessageBox.Show("Pilih data peminjaman yang ingin diubah.",
                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ErrorProvider1.Clear()
        If Not ValidasiPeminjaman(ErrorProvider1, txtNamaPeminjam, cmbPeralatan) Then Exit Sub
        If cmbStatus.SelectedIndex < 0 Then
            MessageBox.Show("Pilih status peminjaman.", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If dtpTglKembali.Value < dtpTglPinjam.Value Then
            MessageBox.Show("Tanggal kembali tidak boleh sebelum tanggal pinjam.",
                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idAlat As Integer = Convert.ToInt32(cmbPeralatan.SelectedValue)
        Dim nama As String = txtNamaPeminjam.Text.Trim()
        Dim tglPinjam As String = dtpTglPinjam.Value.ToString("yyyy-MM-dd")
        Dim tglKembali As String = dtpTglKembali.Value.ToString("yyyy-MM-dd")
        Dim status As String = cmbStatus.Text
        Dim ket As String = txtKeteranganPinjam.Text.Trim()

        If UbahPeminjaman(_selectedIdPinjam, idAlat, nama, tglPinjam, tglKembali, status, ket) Then
            MessageBox.Show("Data peminjaman berhasil diubah!", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapusPinjam_Click(sender As Object, e As EventArgs) Handles btnHapusPinjam.Click
        If _selectedIdPinjam = -1 Then
            MessageBox.Show("Pilih data peminjaman yang ingin dihapus.",
                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah Anda yakin ingin menghapus data peminjaman ini?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusPeminjaman(_selectedIdPinjam) Then
                MessageBox.Show("Data peminjaman berhasil dihapus.", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatalPinjam_Click(sender As Object, e As EventArgs) Handles btnBatalPinjam.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub txtNamaPeminjam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaPeminjam.KeyPress
        HanyaHuruf(e)
        If IsEnterKey(e) Then
            e.Handled = True
            dtpTglPinjam.Focus()
        End If
    End Sub

    Private Sub txtSearchPinjam_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPinjam.TextChanged
        If txtSearchPinjam.Text.Trim() = "" Then
            TampilData()
        Else
            dgvPeminjaman.DataSource = SearchPeminjaman(txtSearchPinjam.Text.Trim())
            AturKolomDGVPinjam()
            lblStatusPinjam.Text = "Hasil pencarian: " & dgvPeminjaman.Rows.Count & " data"
        End If
    End Sub

    Private Sub btnSimpanPinjam_MouseEnter(sender As Object, e As EventArgs) Handles btnSimpanPinjam.MouseEnter
        btnSimpanPinjam.BackColor = Color.FromArgb(30, 160, 240)
    End Sub

    Private Sub btnSimpanPinjam_MouseLeave(sender As Object, e As EventArgs) Handles btnSimpanPinjam.MouseLeave
        btnSimpanPinjam.BackColor = Color.FromArgb(0, 120, 200)
    End Sub

    Private Sub btnSimpanPinjam_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSimpanPinjam.MouseDown
        btnSimpanPinjam.BackColor = Color.FromArgb(0, 80, 150)
    End Sub

    Private Sub btnUbahPinjam_MouseEnter(sender As Object, e As EventArgs) Handles btnUbahPinjam.MouseEnter
        btnUbahPinjam.BackColor = Color.FromArgb(30, 190, 130)
    End Sub

    Private Sub btnUbahPinjam_MouseLeave(sender As Object, e As EventArgs) Handles btnUbahPinjam.MouseLeave
        btnUbahPinjam.BackColor = Color.FromArgb(0, 150, 100)
    End Sub

    Private Sub btnUbahPinjam_MouseDown(sender As Object, e As MouseEventArgs) Handles btnUbahPinjam.MouseDown
        btnUbahPinjam.BackColor = Color.FromArgb(0, 100, 70)
    End Sub

    Private Sub btnHapusPinjam_MouseEnter(sender As Object, e As EventArgs) Handles btnHapusPinjam.MouseEnter
        btnHapusPinjam.BackColor = Color.FromArgb(220, 70, 70)
    End Sub

    Private Sub btnHapusPinjam_MouseLeave(sender As Object, e As EventArgs) Handles btnHapusPinjam.MouseLeave
        btnHapusPinjam.BackColor = Color.FromArgb(180, 40, 40)
    End Sub

    Private Sub btnHapusPinjam_MouseDown(sender As Object, e As MouseEventArgs) Handles btnHapusPinjam.MouseDown
        btnHapusPinjam.BackColor = Color.FromArgb(130, 20, 20)
    End Sub

    Private Sub btnBatalPinjam_MouseEnter(sender As Object, e As EventArgs) Handles btnBatalPinjam.MouseEnter
        btnBatalPinjam.BackColor = Color.FromArgb(110, 110, 120)
    End Sub

    Private Sub btnBatalPinjam_MouseLeave(sender As Object, e As EventArgs) Handles btnBatalPinjam.MouseLeave
        btnBatalPinjam.BackColor = Color.FromArgb(80, 80, 90)
    End Sub

    Private Sub btnBatalPinjam_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBatalPinjam.MouseDown
        btnBatalPinjam.BackColor = Color.FromArgb(50, 50, 60)
    End Sub

End Class