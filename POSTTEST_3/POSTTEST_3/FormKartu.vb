Public Class FormKartu

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(26, 21, 92)
        pnlKartu.BackColor = Color.FromArgb(60, 52, 137)

        lblNama.Text = "Nama         : " & ModulData.NamaLengkap
        lblUmur.Text = "Umur          : " & ModulData.Umur & " Tahun"
        lblTelepon.Text = "Telepon      : " & ModulData.NomorTelepon
        lblTglLahir.Text = "Tgl. Lahir    : " & ModulData.TanggalLahir
        lblHobby.Text = "Hobby         : " & ModulData.DaftarHobby
        lblAlamat.Text = "Alamat        : " & ModulData.Alamat

        If Not CekKosong(ModulData.PathFoto) Then
            picFotoKartu.Image = Image.FromFile(ModulData.PathFoto)
        End If
    End Sub

End Class