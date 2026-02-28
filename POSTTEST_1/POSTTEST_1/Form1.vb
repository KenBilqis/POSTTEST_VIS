Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If String.IsNullOrWhiteSpace(txtIPSemester.Text) Then
            MessageBox.Show("Masukkan nilai IP Semester terlebih dahulu!")
            Exit Sub
        End If

        Dim ipSemester As Double
        Dim input As String = txtIPSemester.Text.Replace(",", ".")
        Dim valid As Boolean = Double.TryParse(input,
            Globalization.NumberStyles.Any,
            Globalization.CultureInfo.InvariantCulture,
            ipSemester)

        If Not valid OrElse ipSemester < 0 OrElse ipSemester > 4 Then
            MessageBox.Show("Masukkan nilai IP yang valid (0 - 4)!")
            Exit Sub
        End If

        totalIP += ipSemester
        jumlahSemester += 1

        Dim ipk As Double = totalIP / jumlahSemester
        txtIPKumulatif.Text = ipk.ToString("0.00").Replace(".", ",")

        If ipk >= 3.01 Then
            lblPredikat.Text = "Sangat Memuaskan"
        ElseIf ipk >= 2.76 Then
            lblPredikat.Text = "Memuaskan"
        ElseIf ipk >= 2.0 Then
            lblPredikat.Text = "Cukup"
        Else
            lblPredikat.Text = ""
        End If

        txtIPSemester.Text = ""
        txtIPSemester.Focus()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        txtIPSemester.Text = ""
        txtIPKumulatif.Text = ""
        lblPredikat.Text = ""
        txtIPSemester.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class