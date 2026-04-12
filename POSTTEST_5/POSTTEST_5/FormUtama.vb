Imports System.Net.NetworkInformation

Public Class FormUtama

    Private _selectedId As Integer = -1

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(10, 30, 60)
        AturTampilanForm()
        AturTampilanDGV()
        TampilData()
        AnimasiFadeIn(Me)
    End Sub

    Private Sub AturTampilanForm()
        lblJudul.ForeColor = Color.FromArgb(100, 210, 255)
        lblJudul.BackColor = Color.Transparent
        lblCari.ForeColor = Color.White
        lblStatus.ForeColor = Color.FromArgb(150, 220, 255)
        lblStatus.BackColor = Color.Transparent

        AturTombol(btnTambah, Color.FromArgb(0, 120, 200))
        AturTombol(btnUbah, Color.FromArgb(0, 150, 100))
        AturTombol(btnHapus, Color.FromArgb(180, 40, 40))

        txtSearch.BackColor = Color.FromArgb(20, 60, 100)
        txtSearch.ForeColor = Color.White

        MenuStrip1.BackColor = Color.FromArgb(5, 20, 50)
        MenuStrip1.ForeColor = Color.White

        Try
            Dim imgPath As String = Application.StartupPath & "\bg_laut.jpg"
            If System.IO.File.Exists(imgPath) Then
                picBg.Image = Image.FromFile(imgPath)
                picBg.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                picBg.BackColor = Color.FromArgb(10, 30, 60)
            End If
            picBg.SendToBack()
        Catch ex As Exception
            picBg.BackColor = Color.FromArgb(10, 30, 60)
        End Try
    End Sub

    Private Sub AturTombol(btn As Button, warna As Color)
        btn.BackColor = warna
        btn.ForeColor = Color.White
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btn.Cursor = Cursors.Hand
    End Sub

    Private Sub AturTampilanDGV()
        dgvPeralatan.BackgroundColor = Color.FromArgb(15, 45, 80)
        dgvPeralatan.GridColor = Color.FromArgb(30, 90, 150)
        dgvPeralatan.DefaultCellStyle.BackColor = Color.FromArgb(15, 50, 90)
        dgvPeralatan.DefaultCellStyle.ForeColor = Color.White
        dgvPeralatan.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 140, 220)
        dgvPeralatan.DefaultCellStyle.SelectionForeColor = Color.White
        dgvPeralatan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 80, 160)
        dgvPeralatan.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(180, 230, 255)
        dgvPeralatan.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgvPeralatan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(20, 60, 100)
        dgvPeralatan.RowHeadersVisible = False
        dgvPeralatan.BorderStyle = BorderStyle.None
    End Sub

    Private Sub AnimasiFadeIn(frm As Form)
        frm.Opacity = 0
        Dim tmr As New Timer()
        tmr.Interval = 20
        AddHandler tmr.Tick, Sub(s, ev)
                                 frm.Opacity += 0.05
                                 If frm.Opacity >= 1 Then
                                     frm.Opacity = 1
                                     tmr.Stop()
                                     tmr.Dispose()
                                 End If
                             End Sub
        tmr.Start()
    End Sub

    Private Sub TampilData()
        dgvPeralatan.DataSource = GetAllPeralatan()
        AturKolomDGV()
        lblStatus.Text = "Total data: " & dgvPeralatan.Rows.Count & " peralatan"
    End Sub

    Private Sub AturKolomDGV()
        If dgvPeralatan.Columns.Count = 0 Then Exit Sub
        If dgvPeralatan.Columns.Contains("id") Then
            dgvPeralatan.Columns("id").HeaderText = "ID"
            dgvPeralatan.Columns("id").Width = 50
        End If
        If dgvPeralatan.Columns.Contains("namaAlat") Then
            dgvPeralatan.Columns("namaAlat").HeaderText = "Nama Peralatan"
            dgvPeralatan.Columns("namaAlat").Width = 220
        End If
        If dgvPeralatan.Columns.Contains("kategori") Then
            dgvPeralatan.Columns("kategori").HeaderText = "Kategori"
            dgvPeralatan.Columns("kategori").Width = 150
        End If
        If dgvPeralatan.Columns.Contains("kondisi") Then
            dgvPeralatan.Columns("kondisi").HeaderText = "Kondisi"
            dgvPeralatan.Columns("kondisi").Width = 110
        End If
        If dgvPeralatan.Columns.Contains("tanggalMasuk") Then
            dgvPeralatan.Columns("tanggalMasuk").HeaderText = "Tanggal Masuk"
            dgvPeralatan.Columns("tanggalMasuk").Width = 130
        End If
        If dgvPeralatan.Columns.Contains("stok") Then
            dgvPeralatan.Columns("stok").HeaderText = "Stok"
            dgvPeralatan.Columns("stok").Width = 70
        End If
        If dgvPeralatan.Columns.Contains("keterangan") Then
            dgvPeralatan.Columns("keterangan").HeaderText = "Keterangan"
            dgvPeralatan.Columns("keterangan").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvPeralatan.DataSource = SearchPeralatan(txtSearch.Text.Trim())
            AturKolomDGV()
            lblStatus.Text = "Hasil pencarian: " & dgvPeralatan.Rows.Count & " peralatan"
        End If
    End Sub

    Private Sub dgvPeralatan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPeralatan.CellClick
        If e.RowIndex >= 0 Then
            Try
                _selectedId = Convert.ToInt32(dgvPeralatan.Rows(e.RowIndex).Cells("id").Value)
                lblStatus.Text = "Data dipilih: " & dgvPeralatan.Rows(e.RowIndex).Cells("namaAlat").Value.ToString()
            Catch ex As Exception
                _selectedId = -1
            End Try
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim frmInput As New FormInput()
        frmInput.Mode = "Tambah"
        frmInput.ShowDialog()
        TampilData()
    End Sub

    Private Sub TambahDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahDataToolStripMenuItem.Click
        btnTambah_Click(sender, e)
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If _selectedId = -1 Then
            MessageBox.Show("Pilih data yang ingin diubah terlebih dahulu.",
                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim frmInput As New FormInput()
        frmInput.Mode = "Ubah"
        frmInput.SelectedId = _selectedId
        frmInput.ShowDialog()
        TampilData()
        _selectedId = -1
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If _selectedId = -1 Then
            MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.",
                "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusPeralatan(_selectedId) Then
                MessageBox.Show("Data berhasil dihapus.", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                _selectedId = -1
            End If
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah Anda yakin ingin keluar?",
            "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnTambah_MouseEnter(sender As Object, e As EventArgs) Handles btnTambah.MouseEnter
        btnTambah.BackColor = Color.FromArgb(30, 160, 240)
    End Sub

    Private Sub btnTambah_MouseLeave(sender As Object, e As EventArgs) Handles btnTambah.MouseLeave
        btnTambah.BackColor = Color.FromArgb(0, 120, 200)
    End Sub

    Private Sub btnTambah_MouseDown(sender As Object, e As MouseEventArgs) Handles btnTambah.MouseDown
        btnTambah.BackColor = Color.FromArgb(0, 80, 160)
    End Sub

    Private Sub btnUbah_MouseEnter(sender As Object, e As EventArgs) Handles btnUbah.MouseEnter
        btnUbah.BackColor = Color.FromArgb(30, 190, 130)
    End Sub

    Private Sub btnUbah_MouseLeave(sender As Object, e As EventArgs) Handles btnUbah.MouseLeave
        btnUbah.BackColor = Color.FromArgb(0, 150, 100)
    End Sub

    Private Sub btnUbah_MouseDown(sender As Object, e As MouseEventArgs) Handles btnUbah.MouseDown
        btnUbah.BackColor = Color.FromArgb(0, 100, 70)
    End Sub

    Private Sub btnHapus_MouseEnter(sender As Object, e As EventArgs) Handles btnHapus.MouseEnter
        btnHapus.BackColor = Color.FromArgb(220, 70, 70)
    End Sub

    Private Sub btnHapus_MouseLeave(sender As Object, e As EventArgs) Handles btnHapus.MouseLeave
        btnHapus.BackColor = Color.FromArgb(180, 40, 40)
    End Sub

    Private Sub btnHapus_MouseDown(sender As Object, e As MouseEventArgs) Handles btnHapus.MouseDown
        btnHapus.BackColor = Color.FromArgb(130, 20, 20)
    End Sub

End Class