<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        btnTambah = New Button()
        txtTambahGenre = New TextBox()
        txtTambahJudul = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        btnHapus = New Button()
        txtHapusJudul = New TextBox()
        Label4 = New Label()
        lstDaftarBuku = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaption
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(txtTambahGenre)
        GroupBox1.Controls.Add(txtTambahJudul)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("SimSun-ExtG", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(50, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(316, 158)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambahkan Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(203, 108)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtTambahGenre
        ' 
        txtTambahGenre.Location = New Point(122, 64)
        txtTambahGenre.Name = "txtTambahGenre"
        txtTambahGenre.Size = New Size(175, 22)
        txtTambahGenre.TabIndex = 3
        ' 
        ' txtTambahJudul
        ' 
        txtTambahJudul.Location = New Point(122, 33)
        txtTambahJudul.Name = "txtTambahJudul"
        txtTambahJudul.Size = New Size(175, 22)
        txtTambahJudul.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 15)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 15)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ActiveCaption
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(txtHapusJudul)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Font = New Font("SimSun-ExtG", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(411, 41)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(316, 158)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(203, 108)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 4
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' txtHapusJudul
        ' 
        txtHapusJudul.Location = New Point(122, 33)
        txtHapusJudul.Name = "txtHapusJudul"
        txtHapusJudul.Size = New Size(175, 22)
        txtHapusJudul.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 33)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 15)
        Label4.TabIndex = 0
        Label4.Text = "Judul Buku"
        ' 
        ' lstDaftarBuku
        ' 
        lstDaftarBuku.Font = New Font("SimSun-ExtG", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstDaftarBuku.FormattingEnabled = True
        lstDaftarBuku.Location = New Point(106, 217)
        lstDaftarBuku.Name = "lstDaftarBuku"
        lstDaftarBuku.Size = New Size(563, 199)
        lstDaftarBuku.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(lstDaftarBuku)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTambahGenre As TextBox
    Friend WithEvents txtTambahJudul As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtHapusJudul As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lstDaftarBuku As ListBox

End Class
