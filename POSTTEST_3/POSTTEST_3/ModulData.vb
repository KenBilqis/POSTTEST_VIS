Public Module ModulData
    Public NamaLengkap As String = ""
    Public Umur As String = ""
    Public NomorTelepon As String = ""
    Public Alamat As String = ""
    Public TanggalLahir As String = ""
    Public JenisKelamin As String = ""
    Public DaftarHobby As String = ""
    Public PathFoto As String = ""

    Public Sub ResetData()
        NamaLengkap = ""
        Umur = ""
        NomorTelepon = ""
        Alamat = ""
        TanggalLahir = ""
        JenisKelamin = ""
        DaftarHobby = ""
        PathFoto = ""
    End Sub

    Public Function CekKosong(nilai As String) As Boolean
        If nilai.Trim() = "" Then
            Return True
        Else
            Return False
        End If
    End Function
End Module