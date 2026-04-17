Public Class FormInput

    Private _mode As String = "Tambah"
    Public Property Mode As String
        Get
            Return _mode
        End Get
        Set(value As String)
            _mode = value
        End Set
    End Property

    Private _selectedId As Integer = -1
    Public Property SelectedId As Integer
        Get
            Return _selectedId
        End Get
        Set(value As Integer)
            _selectedId = value
        End Set
    End Property

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(10, 30, 60)
        AturTampilanInput()
        TabControl1.SelectedTab = tabDataUtama
        AnimasiFadeIn(Me)

        If Mode = "Ubah" Then
            Me.Text = "Ubah Data Peralatan"
            lblJudulInput.Text = "UBAH DATA PERALATAN"
            IsiDataUntukUbah()
        Else
            Me.Text = "Tambah Data Peralatan"
            lblJudulInput.Text = "TAMBAH DATA PERALATAN"
        End If
    End Sub

    Private Sub AturTampilanInput()
        lblJudulInput.ForeColor = Color.FromArgb(100, 210, 255)
        lblJudulInput.BackColor = Color.Transparent

        For Each lbl As Label In Me.Controls.OfType(Of Label)()
            lbl.ForeColor = Color.White
            lbl.BackColor = Color.Transparent
        Next

        AturWarnaTab(TabControl1)

        txtNama.BackColor = Color.FromArgb(20, 60, 100)
        txtNama.ForeColor = Color.White
        txtStok.BackColor = Color.FromArgb(20, 60, 100)
        txtStok.ForeColor = Color.White
        txtKeterangan.BackColor = Color.FromArgb(20, 60, 100)
        txtKeterangan.ForeColor = Color.White

        cmbKategori.BackColor = Color.FromArgb(20, 60, 100)
        cmbKategori.ForeColor = Color.White
        cmbKondisi.BackColor = Color.FromArgb(20, 60, 100)
        cmbKondisi.ForeColor = Color.White

        AturTombolInput(btnSimpanInput, Color.FromArgb(0, 120, 200))
        AturTombolInput(btnBatalInput, Color.FromArgb(80, 80, 90))

        Try
            Dim imgPath As String = Application.StartupPath & "\bg_laut.jpg"
            If System.IO.File.Exists(imgPath) Then
                picBgInput.Image = Image.FromFile(imgPath)
                picBgInput.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                picBgInput.BackColor = Color.FromArgb(10, 30, 60)
            End If
            picBgInput.SendToBack()
        Catch ex As Exception
            picBgInput.BackColor = Color.FromArgb(10, 30, 60)
        End Try
    End Sub

    Private Sub AturWarnaTab(tc As TabControl)
        tc.DrawMode = TabDrawMode.OwnerDrawFixed
        tc.SizeMode = TabSizeMode.Fixed
        tc.ItemSize = New Size(160, 36)
        AddHandler tc.DrawItem, Sub(s, ev)
                                    Dim tab As TabPage = tc.TabPages(ev.Index)
                                    Dim rect As Rectangle = ev.Bounds
                                    If ev.Index = tc.SelectedIndex Then
                                        ev.Graphics.FillRectangle(
                                            New SolidBrush(Color.FromArgb(0, 100, 180)), rect)
                                        TextRenderer.DrawText(ev.Graphics, tab.Text,
                                            New Font("Segoe UI", 10, FontStyle.Bold),
                                            rect, Color.White,
                                            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
                                    Else
                                        ev.Graphics.FillRectangle(
                                            New SolidBrush(Color.FromArgb(20, 55, 90)), rect)
                                        TextRenderer.DrawText(ev.Graphics, tab.Text,
                                            New Font("Segoe UI", 10),
                                            rect, Color.FromArgb(160, 200, 230),
                                            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
                                    End If
                                End Sub
        tabDataUtama.BackColor = Color.FromArgb(12, 38, 70)
        tabKeterangan.BackColor = Color.FromArgb(12, 38, 70)
    End Sub

    Private Sub AturTombolInput(btn As Button, warna As Color)
        btn.BackColor = warna
        btn.ForeColor = Color.White
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btn.Cursor = Cursors.Hand
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

    Private Sub IsiDataUntukUbah()
        If SelectedId = -1 Then Exit Sub
        Dim dt As DataTable = GetPeralatanById(SelectedId)
        If dt.Rows.Count > 0 Then
            txtNama.Text = dt.Rows(0)("namaAlat").ToString()
            cmbKategori.Text = dt.Rows(0)("kategori").ToString()
            cmbKondisi.Text = dt.Rows(0)("kondisi").ToString()
            dtpTanggal.Value = Convert.ToDateTime(dt.Rows(0)("tanggalMasuk"))
            txtStok.Text = dt.Rows(0)("stok").ToString()
            txtKeterangan.Text = dt.Rows(0)("keterangan").ToString()
        End If
    End Sub

    Private Function ValidasiSemuaInput() As Boolean
        ErrorProvider1.Clear()
        Dim namaOk As Boolean = ValidasiTextBox(ErrorProvider1, txtNama, "Nama peralatan tidak boleh kosong")
        Dim katOk As Boolean = ValidasiComboBox(ErrorProvider1, cmbKategori, "Pilih kategori peralatan")
        Dim kondOk As Boolean = ValidasiComboBox(ErrorProvider1, cmbKondisi, "Pilih kondisi peralatan")
        Dim stokOk As Boolean = ValidasiTextBox(ErrorProvider1, txtStok, "Stok tidak boleh kosong")
        Return namaOk And katOk And kondOk And stokOk
    End Function

    Private Sub btnSimpanInput_Click(sender As Object, e As EventArgs) Handles btnSimpanInput.Click
        If Not ValidasiSemuaInput() Then
            TabControl1.SelectedTab = tabDataUtama
            Exit Sub
        End If

        Dim nama As String = txtNama.Text.Trim()
        Dim kat As String = cmbKategori.Text
        Dim kond As String = cmbKondisi.Text
        Dim tgl As String = dtpTanggal.Value.ToString("yyyy-MM-dd")
        Dim stok As Integer = Convert.ToInt32(txtStok.Text.Trim())
        Dim ket As String = txtKeterangan.Text.Trim()

        If Mode = "Tambah" Then
            If SimpanPeralatan(nama, kat, kond, tgl, stok, ket) Then
                MessageBox.Show("Data berhasil disimpan!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        ElseIf Mode = "Ubah" Then
            If UbahPeralatan(SelectedId, nama, kat, kond, tgl, stok, ket) Then
                MessageBox.Show("Data berhasil diubah!", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Data tidak ditemukan.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnBatalInput_Click(sender As Object, e As EventArgs) Handles btnBatalInput.Click
        Me.Close()
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
        If IsEnterKey(e) Then
            e.Handled = True
            cmbKategori.Focus()
        End If
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        HanyaAngka(e)
        If IsEnterKey(e) Then
            e.Handled = True
            TabControl1.SelectedTab = tabKeterangan
        End If
    End Sub

    Private Sub btnSimpanInput_MouseEnter(sender As Object, e As EventArgs) Handles btnSimpanInput.MouseEnter
        btnSimpanInput.BackColor = Color.FromArgb(30, 160, 240)
    End Sub

    Private Sub btnSimpanInput_MouseLeave(sender As Object, e As EventArgs) Handles btnSimpanInput.MouseLeave
        btnSimpanInput.BackColor = Color.FromArgb(0, 120, 200)
    End Sub

    Private Sub btnSimpanInput_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSimpanInput.MouseDown
        btnSimpanInput.BackColor = Color.FromArgb(0, 80, 150)
    End Sub

    Private Sub btnBatalInput_MouseEnter(sender As Object, e As EventArgs) Handles btnBatalInput.MouseEnter
        btnBatalInput.BackColor = Color.FromArgb(110, 110, 120)
    End Sub

    Private Sub btnBatalInput_MouseLeave(sender As Object, e As EventArgs) Handles btnBatalInput.MouseLeave
        btnBatalInput.BackColor = Color.FromArgb(80, 80, 90)
    End Sub

    Private Sub btnBatalInput_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBatalInput.MouseDown
        btnBatalInput.BackColor = Color.FromArgb(50, 50, 60)
    End Sub

End Class