Public Module DataModule
	Public NamaAnggota As String = ""
	Public IDAAnggota As String = ""
	Public TanggalLahir As String = ""
	Public JenisKelamin As String = ""
	Public JenisKomunitas As String = ""
	Public NomorTelepon As String = ""
	Public EmailAnggota As String = ""
	Public AlamatAnggota As String = ""
	Public FotoPath As String = ""
	Public PeranAnggota As String = ""
	Public DaftarHobi As String = ""

	Public Function ValidasiTextBoxKosong(tb As TextBox, pesan As String) As Boolean
		If tb.Text.Trim() = "" Then
			MessageBox.Show(pesan, "Peringatan",
				MessageBoxButtons.OK, MessageBoxIcon.Warning)
			tb.Focus()
			Return False
		End If
		Return True
	End Function

	Public Function ValidasiSemuaHobi(daftar As CheckBox(), pesan As String) As Boolean
		Dim adaYangDicentang As Boolean = False
		For Each cb As CheckBox In daftar
			If cb.Checked Then
				adaYangDicentang = True
			End If
		Next
		If Not adaYangDicentang Then
			MessageBox.Show(pesan, "Peringatan",
				MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return False
		End If
		Return True
	End Function

	' Hanya boleh input angka
	Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
		If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
		End If
	End Sub

	' Hanya boleh input huruf
	Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
		If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) _
		   OrElse Char.IsControl(e.KeyChar) Then
			e.Handled = False
		Else
			e.Handled = True
		End If
	End Sub

End Module