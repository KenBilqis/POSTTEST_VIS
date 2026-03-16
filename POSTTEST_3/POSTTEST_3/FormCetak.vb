Imports System.IO

Public Class FormCetak

    Private Sub FormCetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(26, 21, 92)
        pnlHeader.BackColor = Color.FromArgb(74, 27, 12)
        btnCetak.BackColor = Color.FromArgb(60, 52, 137)
        btnBrowse.BackColor = Color.FromArgb(60, 52, 137)
        picFoto.BackColor = Color.FromArgb(238, 237, 254)
    End Sub

    Private Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(sender, e)
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog.Title = "Pilih Foto Profil"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
            Dim fileName As String = "profil" & Path.GetExtension(openFileDialog.FileName)
            Dim destinationPath As String = Path.Combine(folderPath, fileName)
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If
            File.Copy(openFileDialog.FileName, destinationPath, True)
            ModulData.PathFoto = destinationPath
            picFoto.Image = Image.FromFile(destinationPath)
        End If
    End Sub

    Private Function KumpulkanHobby() As String
        Dim daftar As String = ""
        For Each ctrl As Control In grpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                If cb.Checked Then
                    If daftar = "" Then
                        daftar = cb.Text
                    Else
                        daftar = daftar & ", " & cb.Text
                    End If
                End If
            End If
        Next
        Return daftar
    End Function

    Private Function AdaHobbyDipilih() As Boolean
        For Each ctrl As Control In grpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                If cb.Checked Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If CekKosong(txtNama.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong : Nama Lengkap wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If

        If CekKosong(txtUmur.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong : Umur wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUmur.Focus()
            Return
        End If

        If CekKosong(txtTelepon.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong : Nomor Telepon wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTelepon.Focus()
            Return
        End If

        If CekKosong(txtAlamat.Text) Then
            MessageBox.Show("Inputan tidak boleh kosong : Alamat wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAlamat.Focus()
            Return
        End If

        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong : Jenis Kelamin wajib dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not AdaHobbyDipilih() Then
            MessageBox.Show("Inputan tidak boleh kosong : Pilih minimal 1 Hobby!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If CekKosong(ModulData.PathFoto) Then
            MessageBox.Show("Inputan tidak boleh kosong : Foto profil wajib diupload!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ModulData.NamaLengkap = txtNama.Text.Trim()
        ModulData.Umur = txtUmur.Text.Trim()
        ModulData.NomorTelepon = txtTelepon.Text.Trim()
        ModulData.Alamat = txtAlamat.Text.Trim()
        ModulData.TanggalLahir = dtpTglLahir.Value.ToString("dd MMMM yyyy")

        If rbLaki.Checked Then
            ModulData.JenisKelamin = "Laki-laki"
        Else
            ModulData.JenisKelamin = "Perempuan"
        End If

        ModulData.DaftarHobby = KumpulkanHobby()

        Dim frmKartu As New FormKartu()
        frmKartu.Show()
    End Sub

End Class