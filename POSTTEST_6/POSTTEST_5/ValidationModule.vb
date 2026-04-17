Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox,
                                     pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cmb As ComboBox,
                                      pesan As String) As Boolean
        If cmb.SelectedIndex < 0 Then
            ep.SetError(cmb, pesan)
            Return False
        Else
            ep.SetError(cmb, "")
            Return True
        End If
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

    Public Function ValidasiPeminjaman(ep As ErrorProvider, txtNama As TextBox,
                                        cmbAlat As ComboBox) As Boolean
        Dim namaOk As Boolean = ValidasiTextBox(ep, txtNama, "Nama peminjam tidak boleh kosong")
        Dim alatOk As Boolean = ValidasiComboBox(ep, cmbAlat, "Pilih peralatan yang dipinjam")
        Return namaOk And alatOk
    End Function

End Module