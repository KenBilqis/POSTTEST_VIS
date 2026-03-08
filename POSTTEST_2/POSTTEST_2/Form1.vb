Public Class Form1

    Private Sub TampilBuku()
        lstDaftarBuku.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            lstDaftarBuku.Items.Add(daftarBuku(i, 0) & " (" & daftarBuku(i, 1) & ")")
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilBuku()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtTambahJudul.Text
        Dim genre As String = txtTambahGenre.Text

        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan genre tidak boleh kosong!")
            Return
        End If

        TambahBuku(judul, genre)
        TampilBuku()

        txtTambahJudul.Text = ""
        txtTambahGenre.Text = ""
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judul As String = txtHapusJudul.Text

        If judul = "" Then
            MessageBox.Show("Judul tidak boleh kosong!")
            Return
        End If

        Dim hasil As Boolean = HapusBuku(judul)

        If hasil = True Then
            MessageBox.Show(judul & " berhasil dihapus!")
            TampilBuku()
            txtHapusJudul.Text = ""
        ElseIf hasil = False Then
            MessageBox.Show(judul & " tidak ada dalam daftar!")
        End If
    End Sub

End Class
