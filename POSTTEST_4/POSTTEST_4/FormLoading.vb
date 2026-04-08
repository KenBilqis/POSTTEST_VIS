Public Class FormLoading

    Private WithEvents tmrProgress As New Timer()
    Private WithEvents tmrFadeIn As New Timer()
    Private progValue As Integer = 0
    Private fadeOpa As Double = 0.0

    Private ReadOnly pesanLoading As String() = {
        "Menyelam ke lautan data...",
        "Mempersiapkan kartu anggota...",
        "Mengkalibrasi kedalaman informasi...",
        "Menjernihkan data profil...",
        "Hampir selesai, sedang surfacing..."
    }
    Private pesanIndex As Integer = 0

    Private Sub FormLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.0
        tmrFadeIn.Interval = 18
        tmrProgress.Interval = 35
        tmrFadeIn.Start()
    End Sub

    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeIn.Tick
        If fadeOpa < 1.0 Then
            fadeOpa += 0.06
            Me.Opacity = fadeOpa
        Else
            Me.Opacity = 1.0
            tmrFadeIn.Stop()
            tmrProgress.Start()
        End If
    End Sub

    Private Sub tmrProgress_Tick(sender As Object, e As EventArgs) Handles tmrProgress.Tick
        progValue += 1
        prgLoading.Value = Math.Min(progValue, 100)
        lblPersen.Text = progValue & "%"

        Dim idx As Integer = progValue \ 20
        If idx < pesanLoading.Length AndAlso idx <> pesanIndex Then
            pesanIndex = idx
            lblStatus.Text = pesanLoading(idx)
        End If

        If progValue >= 100 Then
            tmrProgress.Stop()
            Dim frmHasil As New FormHasil()
            frmHasil.Show()
            Me.Close()
        End If
    End Sub

End Class