Public Module ModulBuku

    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        End If
    End Sub

    Public Function HapusBuku(ByVal judul As String) As Boolean
        Dim ketemu As Boolean = False
        Dim idx As Integer = -1

        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judul.ToLower() Then
                ketemu = True
                idx = i
                Exit For
            End If
        Next

        If ketemu = True Then
            For i As Integer = idx To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)
            Next
            daftarBuku(jumlahBuku - 1, 0) = ""
            daftarBuku(jumlahBuku - 1, 1) = ""
            jumlahBuku -= 1
        End If

        Return ketemu
    End Function

End Module
