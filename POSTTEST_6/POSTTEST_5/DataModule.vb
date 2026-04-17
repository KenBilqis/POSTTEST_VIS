Imports MySqlConnector

Module DataModule

    Public Function GetAllPeralatan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id, namaAlat, kategori, kondisi, tanggalMasuk, stok, keterangan FROM tbperalatan ORDER BY id ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchPeralatan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id, namaAlat, kategori, kondisi, tanggalMasuk, stok, keterangan " &
                "FROM tbperalatan WHERE namaAlat LIKE @keyword OR kategori LIKE @keyword " &
                "OR kondisi LIKE @keyword ORDER BY id ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetPeralatanById(idAlat As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id, namaAlat, kategori, kondisi, tanggalMasuk, stok, keterangan " &
                "FROM tbperalatan WHERE id = @id"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", idAlat)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanPeralatan(nama As String, kat As String, kond As String,
                                     tgl As String, stok As Integer, ket As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbperalatan (namaAlat, kategori, kondisi, tanggalMasuk, stok, keterangan) " &
                "VALUES (@nama, @kat, @kond, @tgl, @stok, @ket)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kat", kat)
                    cmd.Parameters.AddWithValue("@kond", kond)
                    cmd.Parameters.AddWithValue("@tgl", tgl)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@ket", ket)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPeralatan(idAlat As Integer, nama As String, kat As String,
                                   kond As String, tgl As String, stok As Integer,
                                   ket As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbperalatan SET namaAlat=@nama, kategori=@kat, kondisi=@kond, " &
                "tanggalMasuk=@tgl, stok=@stok, keterangan=@ket WHERE id=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idAlat)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kat", kat)
                    cmd.Parameters.AddWithValue("@kond", kond)
                    cmd.Parameters.AddWithValue("@tgl", tgl)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@ket", ket)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPeralatan(idAlat As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM tbperalatan WHERE id = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idAlat)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllPeminjaman() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT tbpeminjaman.idPinjam, tbperalatan.namaAlat, " &
                "tbpeminjaman.namaPeminjam, tbpeminjaman.tanggalPinjam, " &
                "tbpeminjaman.tanggalKembali, tbpeminjaman.statusKembali, " &
                "tbpeminjaman.keterangan " &
                "FROM tbpeminjaman " &
                "INNER JOIN tbperalatan ON tbpeminjaman.idPeralatan = tbperalatan.id " &
                "ORDER BY tbpeminjaman.idPinjam ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data peminjaman: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchPeminjaman(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT tbpeminjaman.idPinjam, tbperalatan.namaAlat, " &
                "tbpeminjaman.namaPeminjam, tbpeminjaman.tanggalPinjam, " &
                "tbpeminjaman.tanggalKembali, tbpeminjaman.statusKembali, " &
                "tbpeminjaman.keterangan " &
                "FROM tbpeminjaman " &
                "INNER JOIN tbperalatan ON tbpeminjaman.idPeralatan = tbperalatan.id " &
                "WHERE tbpeminjaman.namaPeminjam LIKE @keyword " &
                "OR tbperalatan.namaAlat LIKE @keyword " &
                "OR tbpeminjaman.statusKembali LIKE @keyword " &
                "ORDER BY tbpeminjaman.idPinjam ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data peminjaman: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetPeminjamanById(idPinjam As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT idPinjam, idPeralatan, namaPeminjam, tanggalPinjam, " &
                "tanggalKembali, statusKembali, keterangan " &
                "FROM tbpeminjaman WHERE idPinjam = @id"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", idPinjam)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data peminjaman: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanPeminjaman(idPeralatan As Integer, namaPeminjam As String,
                                      tglPinjam As String, tglKembali As String,
                                      status As String, ket As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbpeminjaman (idPeralatan, namaPeminjam, tanggalPinjam, " &
                "tanggalKembali, statusKembali, keterangan) " &
                "VALUES (@idPeralatan, @nama, @tglPinjam, @tglKembali, @status, @ket)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idPeralatan", idPeralatan)
                    cmd.Parameters.AddWithValue("@nama", namaPeminjam)
                    cmd.Parameters.AddWithValue("@tglPinjam", tglPinjam)
                    cmd.Parameters.AddWithValue("@tglKembali", tglKembali)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@ket", ket)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data peminjaman: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPeminjaman(idPinjam As Integer, idPeralatan As Integer,
                                    namaPeminjam As String, tglPinjam As String,
                                    tglKembali As String, status As String,
                                    ket As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbpeminjaman SET idPeralatan=@idPeralatan, namaPeminjam=@nama, " &
                "tanggalPinjam=@tglPinjam, tanggalKembali=@tglKembali, " &
                "statusKembali=@status, keterangan=@ket WHERE idPinjam=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idPinjam)
                    cmd.Parameters.AddWithValue("@idPeralatan", idPeralatan)
                    cmd.Parameters.AddWithValue("@nama", namaPeminjam)
                    cmd.Parameters.AddWithValue("@tglPinjam", tglPinjam)
                    cmd.Parameters.AddWithValue("@tglKembali", tglKembali)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@ket", ket)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data peminjaman: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPeminjaman(idPinjam As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM tbpeminjaman WHERE idPinjam = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idPinjam)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data peminjaman: " & ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module