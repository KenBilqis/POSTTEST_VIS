Public Class FormHasil

    Private WithEvents tmrFadeIn As New Timer()
    Private WithEvents tmrWave As New Timer()
    Private fadeOpa As Double = 0.0
    Private waveOffset As Integer = 0

    ' Warna tema
    Private ReadOnly clrDeep As Color = Color.FromArgb(5, 15, 40)
    Private ReadOnly clrMid As Color = Color.FromArgb(10, 55, 100)
    Private ReadOnly clrShallow As Color = Color.FromArgb(0, 105, 148)
    Private ReadOnly clrCyan As Color = Color.FromArgb(0, 175, 185)
    Private ReadOnly clrFoam As Color = Color.FromArgb(200, 240, 245)
    Private ReadOnly clrGold As Color = Color.FromArgb(255, 200, 80)

    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.Opacity = 0.0
        Me.Text = "Kartu Anggota — " & DataModule.NamaAnggota

        Dim pnlBaru As New PanelKartu()
        pnlBaru.Size = pnlKartu.Size
        pnlBaru.Location = pnlKartu.Location
        pnlBaru.BackColor = Color.Transparent
        AddHandler pnlBaru.Paint, AddressOf pnlKartu_Paint
        Me.Controls.Remove(pnlKartu)
        pnlKartu = pnlBaru
        Me.Controls.Add(pnlKartu)

        tmrFadeIn.Interval = 20
        tmrWave.Interval = 45
        tmrFadeIn.Start()
        tmrWave.Start()
    End Sub

    ' ---- FADE IN ----
    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeIn.Tick
        If fadeOpa < 1.0 Then
            fadeOpa += 0.05
            Me.Opacity = fadeOpa
        Else
            Me.Opacity = 1.0
            tmrFadeIn.Stop()
        End If
    End Sub

    ' ---- GELOMBANG ----
    Private Sub tmrWave_Tick(sender As Object, e As EventArgs) Handles tmrWave.Tick
        waveOffset += 2
        If waveOffset > 300 Then waveOffset = 0
        pnlKartu.Invalidate()
    End Sub

    ' ---- GAMBAR KARTU ----
    Private Sub pnlKartu_Paint(sender As Object, e As PaintEventArgs) Handles pnlKartu.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim w As Integer = pnlKartu.Width
        Dim h As Integer = pnlKartu.Height

        ' Background gradasi
        Dim brushBg As New Drawing2D.LinearGradientBrush(
            New Point(0, 0), New Point(w, h),
            Color.FromArgb(8, 30, 70), Color.FromArgb(0, 80, 130))
        g.FillRectangle(brushBg, 0, 0, w, h)

        ' Border kartu
        Dim penBorder As New Pen(clrCyan, 2)
        g.DrawRectangle(penBorder, 1, 1, w - 3, h - 3)

        ' Strip atas
        Dim brushStrip As New SolidBrush(clrShallow)
        g.FillRectangle(brushStrip, 0, 0, w, 55)

        ' Teks nama organisasi di strip
        Dim fntOrg As New Font("Segoe UI", 14.0F, FontStyle.Bold)
        g.DrawString("SAMARENDAH FREEDIVER", fntOrg, New SolidBrush(clrGold), 130, 8)
        Dim fntSub As New Font("Segoe UI", 8.5F, FontStyle.Italic)
        g.DrawString("Kartu Anggota Resmi — Komunitas Selam Bebas Samarinda",
            fntSub, New SolidBrush(clrFoam), 132, 34)

        ' Foto profil
        Dim fotoRect As New Rectangle(30, 80, 130, 155)
        Dim penFoto As New Pen(clrGold, 3)
        g.DrawRectangle(penFoto, fotoRect)

        If DataModule.FotoPath <> "" AndAlso IO.File.Exists(DataModule.FotoPath) Then
            Dim img As Image = Image.FromFile(DataModule.FotoPath)
            g.DrawImage(img, 32, 82, 126, 151)
            img.Dispose()
        Else
            Dim brushPh As New SolidBrush(clrMid)
            g.FillRectangle(brushPh, 32, 82, 126, 151)
            Dim fntIcon As New Font("Segoe UI", 22.0F)
            g.DrawString("🤿", fntIcon, New SolidBrush(Color.FromArgb(120, 255, 255, 255)), 55, 130)
            brushPh.Dispose()
            fntIcon.Dispose()
        End If

        ' Nama anggota
        Dim fntNama As New Font("Segoe UI", 20.0F, FontStyle.Bold)
        g.DrawString(DataModule.NamaAnggota, fntNama, New SolidBrush(clrFoam), 185, 65)

        ' Peran & divisi
        Dim fntPeran As New Font("Segoe UI", 10.0F, FontStyle.Italic)
        g.DrawString(DataModule.PeranAnggota & "  |  " & DataModule.JenisKomunitas,
            fntPeran, New SolidBrush(clrGold), 185, 110)

        ' Garis pemisah
        g.DrawLine(New Pen(clrShallow, 1), 185, 135, w - 30, 135)

        ' Data detail (label + nilai)
        Dim fntLabel As New Font("Segoe UI", 8.5F, FontStyle.Bold)
        Dim fntVal As New Font("Segoe UI", 10.0F)
        Dim brushLabel As New SolidBrush(clrCyan)
        Dim brushVal As New SolidBrush(clrFoam)

        Dim col1 As Integer = 185
        Dim col2 As Integer = 475
        Dim baris As Integer = 150
        Dim jarak As Integer = 32

        ' Kolom kiri
        g.DrawString("ID ANGGOTA", fntLabel, brushLabel, col1, baris)
        g.DrawString(DataModule.IDAAnggota, fntVal, brushVal, col1, baris + 14)

        g.DrawString("TANGGAL LAHIR", fntLabel, brushLabel, col1, baris + jarak)
        g.DrawString(DataModule.TanggalLahir, fntVal, brushVal, col1, baris + jarak + 14)

        g.DrawString("JENIS KELAMIN", fntLabel, brushLabel, col1, baris + jarak * 2)
        g.DrawString(DataModule.JenisKelamin, fntVal, brushVal, col1, baris + jarak * 2 + 14)

        g.DrawString("TELEPON", fntLabel, brushLabel, col1, baris + jarak * 3)
        g.DrawString(DataModule.NomorTelepon, fntVal, brushVal, col1, baris + jarak * 3 + 14)

        ' Kolom kanan
        g.DrawString("EMAIL", fntLabel, brushLabel, col2, baris)
        g.DrawString(DataModule.EmailAnggota, fntVal, brushVal, col2, baris + 14)

        g.DrawString("ALAMAT", fntLabel, brushLabel, col2, baris + jarak)
        Dim rectAlamat As New RectangleF(col2, baris + jarak + 14, 240, 44)
        g.DrawString(DataModule.AlamatAnggota, fntVal, brushVal, rectAlamat)

        g.DrawString("AKTIVITAS", fntLabel, brushLabel, col2, baris + jarak * 3)
        Dim rectHobi As New RectangleF(col2, baris + jarak * 3 + 14, 240, 44)
        g.DrawString(DataModule.DaftarHobi, fntVal, brushVal, rectHobi)

        ' Gelombang bawah dekoratif
        Dim brushWave As New SolidBrush(Color.FromArgb(20, 0, 175, 185))
        For i As Integer = 0 To 2
            Dim yBase As Integer = h - 50 + i * 15
            Dim path As New Drawing2D.GraphicsPath()
            path.StartFigure()
            path.AddLine(0, h, 0, yBase)
            Dim xPos As Integer = 0
            Do While xPos <= w
                Dim yy As Single = CSng(yBase + 8 * Math.Sin(xPos * 0.03 + waveOffset * 0.05 + i))
                path.AddLine(xPos, yy, xPos + 2, yy)
                xPos += 2
            Loop
            path.AddLine(w, yBase, w, h)
            path.CloseFigure()
            g.FillPath(brushWave, path)
            path.Dispose()
        Next

        ' Strip bawah
        Dim brushBottom As New SolidBrush(Color.FromArgb(80, 0, 40, 80))
        g.FillRectangle(brushBottom, 0, h - 35, w, 35)
        Dim fntBot As New Font("Segoe UI", 7.5F)
        g.DrawString("Dokumen Resmi Samarendah Freediver  •  Tidak untuk dipindahtangankan",
            fntBot, New SolidBrush(Color.FromArgb(150, 200, 230, 240)), 15, h - 22)

        ' Bersihkan
        brushBg.Dispose() : penBorder.Dispose() : brushStrip.Dispose()
        fntOrg.Dispose() : fntSub.Dispose() : fntNama.Dispose() : fntPeran.Dispose()
        fntLabel.Dispose() : fntVal.Dispose() : brushLabel.Dispose() : brushVal.Dispose()
        penFoto.Dispose() : brushWave.Dispose() : brushBottom.Dispose() : fntBot.Dispose()
    End Sub

    ' ---- TOMBOL ----
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub btnSimpanUlang_Click(sender As Object, e As EventArgs) Handles btnSimpanUlang.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Simpan data anggota ke file?", "Konfirmasi Simpan",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "Text File|*.txt|CSV File|*.csv"
            sfd.FileName = "Anggota_" & DataModule.IDAAnggota

            If sfd.ShowDialog() = DialogResult.OK Then
                Dim isi As String =
                    "=== KARTU ANGGOTA SAMARENDAH FREEDIVER ===" & vbCrLf &
                    "Nama      : " & DataModule.NamaAnggota & vbCrLf &
                    "ID        : " & DataModule.IDAAnggota & vbCrLf &
                    "Lahir     : " & DataModule.TanggalLahir & vbCrLf &
                    "Kelamin   : " & DataModule.JenisKelamin & vbCrLf &
                    "Divisi    : " & DataModule.JenisKomunitas & vbCrLf &
                    "Telepon   : " & DataModule.NomorTelepon & vbCrLf &
                    "Email     : " & DataModule.EmailAnggota & vbCrLf &
                    "Alamat    : " & DataModule.AlamatAnggota & vbCrLf &
                    "Peran     : " & DataModule.PeranAnggota & vbCrLf &
                    "Aktivitas : " & DataModule.DaftarHobi & vbCrLf &
                    "==========================================="
                IO.File.WriteAllText(sfd.FileName, isi)
                MessageBox.Show("Data berhasil disimpan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

End Class

' Panel khusus anti-flicker untuk gambar kartu
Public Class PanelKartu
    Inherits Panel

    Public Sub New()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or
                    ControlStyles.UserPaint Or
                    ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()
    End Sub

End Class