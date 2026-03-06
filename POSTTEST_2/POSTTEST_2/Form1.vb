Public Class Form1

    Private Sub RefreshDaftarBuku()
        lstDaftarBuku.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            lstDaftarBuku.Items.Add(daftarBuku(i, 0) & " (" & daftarBuku(i, 1) & ")")
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDaftarBuku()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtTambahJudul.Text.Trim()
        Dim genre As String = txtTambahGenre.Text.Trim()

        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan Genre wajib diisi!")
            Return
        End If

        TambahBuku(judul, genre)
        RefreshDaftarBuku()

        txtTambahJudul.Text = ""
        txtTambahGenre.Text = ""
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judul As String = txtHapusJudul.Text.Trim()

        If judul = "" Then
            MessageBox.Show("Judul buku wajib diisi!")
            Return
        End If

        Dim berhasil As Boolean = HapusBuku(judul)

        If berhasil Then
            MessageBox.Show("Buku """ & judul & """ berhasil dihapus.")
            RefreshDaftarBuku()
            txtHapusJudul.Text = ""
        ElseIf Not berhasil Then
            MessageBox.Show("Buku """ & judul & """ tidak ditemukan dalam daftar!")
        End If
    End Sub

End Class