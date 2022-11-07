<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbPerempuan = New System.Windows.Forms.RadioButton()
        Me.RbLaki = New System.Windows.Forms.RadioButton()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CbManajemen = New System.Windows.Forms.CheckBox()
        Me.CbTi = New System.Windows.Forms.CheckBox()
        Me.CbHukum = New System.Windows.Forms.CheckBox()
        Me.CbTE = New System.Windows.Forms.CheckBox()
        Me.CbTM = New System.Windows.Forms.CheckBox()
        Me.CbPGSD = New System.Windows.Forms.CheckBox()
        Me.CbAkuntansi = New System.Windows.Forms.CheckBox()
        Me.CbIndus = New System.Windows.Forms.CheckBox()
        Me.CbIlkom = New System.Windows.Forms.CheckBox()
        Me.ComboPendidikan = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.BtnTampilkan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Pilihan Jurusan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 384)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Pendidikan Sebelumnya"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 414)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tanggal Pendaftaran"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(145, 42)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(253, 20)
        Me.TxtNama.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(145, 71)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(253, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbPerempuan)
        Me.GroupBox1.Controls.Add(Me.RbLaki)
        Me.GroupBox1.Location = New System.Drawing.Point(145, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 53)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilihan"
        '
        'RbPerempuan
        '
        Me.RbPerempuan.AutoSize = True
        Me.RbPerempuan.Location = New System.Drawing.Point(137, 19)
        Me.RbPerempuan.Name = "RbPerempuan"
        Me.RbPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.RbPerempuan.TabIndex = 0
        Me.RbPerempuan.TabStop = True
        Me.RbPerempuan.Text = "Perempuan"
        Me.RbPerempuan.UseVisualStyleBackColor = True
        '
        'RbLaki
        '
        Me.RbLaki.AutoSize = True
        Me.RbLaki.Location = New System.Drawing.Point(29, 20)
        Me.RbLaki.Name = "RbLaki"
        Me.RbLaki.Size = New System.Drawing.Size(74, 17)
        Me.RbLaki.TabIndex = 0
        Me.RbLaki.TabStop = True
        Me.RbLaki.Text = "Laki - Laki"
        Me.RbLaki.UseVisualStyleBackColor = True
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Location = New System.Drawing.Point(145, 157)
        Me.TxtAlamat.Multiline = True
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAlamat.Size = New System.Drawing.Size(253, 62)
        Me.TxtAlamat.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CbManajemen)
        Me.GroupBox2.Controls.Add(Me.CbTi)
        Me.GroupBox2.Controls.Add(Me.CbHukum)
        Me.GroupBox2.Controls.Add(Me.CbTE)
        Me.GroupBox2.Controls.Add(Me.CbTM)
        Me.GroupBox2.Controls.Add(Me.CbPGSD)
        Me.GroupBox2.Controls.Add(Me.CbAkuntansi)
        Me.GroupBox2.Controls.Add(Me.CbIndus)
        Me.GroupBox2.Controls.Add(Me.CbIlkom)
        Me.GroupBox2.Location = New System.Drawing.Point(145, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 135)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Wajib Memilih 2 Jurusan"
        '
        'CbManajemen
        '
        Me.CbManajemen.AutoSize = True
        Me.CbManajemen.Location = New System.Drawing.Point(6, 63)
        Me.CbManajemen.Name = "CbManajemen"
        Me.CbManajemen.Size = New System.Drawing.Size(81, 17)
        Me.CbManajemen.TabIndex = 0
        Me.CbManajemen.Text = "Manajemen"
        Me.CbManajemen.UseVisualStyleBackColor = True
        '
        'CbTi
        '
        Me.CbTi.AutoSize = True
        Me.CbTi.Location = New System.Drawing.Point(6, 42)
        Me.CbTi.Name = "CbTi"
        Me.CbTi.Size = New System.Drawing.Size(114, 17)
        Me.CbTi.TabIndex = 0
        Me.CbTi.Text = "Teknik Informatika"
        Me.CbTi.UseVisualStyleBackColor = True
        '
        'CbHukum
        '
        Me.CbHukum.AutoSize = True
        Me.CbHukum.Location = New System.Drawing.Point(137, 63)
        Me.CbHukum.Name = "CbHukum"
        Me.CbHukum.Size = New System.Drawing.Size(60, 17)
        Me.CbHukum.TabIndex = 0
        Me.CbHukum.Text = "Hukum"
        Me.CbHukum.UseVisualStyleBackColor = True
        '
        'CbTE
        '
        Me.CbTE.AutoSize = True
        Me.CbTE.Location = New System.Drawing.Point(137, 86)
        Me.CbTE.Name = "CbTE"
        Me.CbTE.Size = New System.Drawing.Size(95, 17)
        Me.CbTE.TabIndex = 0
        Me.CbTE.Text = "Teknik Elektro"
        Me.CbTE.UseVisualStyleBackColor = True
        '
        'CbTM
        '
        Me.CbTM.AutoSize = True
        Me.CbTM.Location = New System.Drawing.Point(6, 109)
        Me.CbTM.Name = "CbTM"
        Me.CbTM.Size = New System.Drawing.Size(90, 17)
        Me.CbTM.TabIndex = 0
        Me.CbTM.Text = "Teknik Mesin"
        Me.CbTM.UseVisualStyleBackColor = True
        '
        'CbPGSD
        '
        Me.CbPGSD.AutoSize = True
        Me.CbPGSD.Location = New System.Drawing.Point(6, 86)
        Me.CbPGSD.Name = "CbPGSD"
        Me.CbPGSD.Size = New System.Drawing.Size(56, 17)
        Me.CbPGSD.TabIndex = 0
        Me.CbPGSD.Text = "PGSD"
        Me.CbPGSD.UseVisualStyleBackColor = True
        '
        'CbAkuntansi
        '
        Me.CbAkuntansi.AutoSize = True
        Me.CbAkuntansi.Location = New System.Drawing.Point(137, 42)
        Me.CbAkuntansi.Name = "CbAkuntansi"
        Me.CbAkuntansi.Size = New System.Drawing.Size(73, 17)
        Me.CbAkuntansi.TabIndex = 0
        Me.CbAkuntansi.Text = "Akuntansi"
        Me.CbAkuntansi.UseVisualStyleBackColor = True
        '
        'CbIndus
        '
        Me.CbIndus.AutoSize = True
        Me.CbIndus.Location = New System.Drawing.Point(137, 19)
        Me.CbIndus.Name = "CbIndus"
        Me.CbIndus.Size = New System.Drawing.Size(96, 17)
        Me.CbIndus.TabIndex = 0
        Me.CbIndus.Text = "Teknik Industri"
        Me.CbIndus.UseVisualStyleBackColor = True
        '
        'CbIlkom
        '
        Me.CbIlkom.AutoSize = True
        Me.CbIlkom.Location = New System.Drawing.Point(6, 19)
        Me.CbIlkom.Name = "CbIlkom"
        Me.CbIlkom.Size = New System.Drawing.Size(102, 17)
        Me.CbIlkom.TabIndex = 0
        Me.CbIlkom.Text = "Ilmu Komunikasi"
        Me.CbIlkom.UseVisualStyleBackColor = True
        '
        'ComboPendidikan
        '
        Me.ComboPendidikan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPendidikan.FormattingEnabled = True
        Me.ComboPendidikan.Items.AddRange(New Object() {"SMA", "SMK", "MA", "MAN"})
        Me.ComboPendidikan.Location = New System.Drawing.Point(145, 380)
        Me.ComboPendidikan.Name = "ComboPendidikan"
        Me.ComboPendidikan.Size = New System.Drawing.Size(253, 21)
        Me.ComboPendidikan.TabIndex = 6
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(145, 411)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(253, 20)
        Me.DateTimePicker2.TabIndex = 7
        '
        'BtnTampilkan
        '
        Me.BtnTampilkan.Location = New System.Drawing.Point(145, 448)
        Me.BtnTampilkan.Name = "BtnTampilkan"
        Me.BtnTampilkan.Size = New System.Drawing.Size(120, 27)
        Me.BtnTampilkan.TabIndex = 8
        Me.BtnTampilkan.Text = "Tampilkan"
        Me.BtnTampilkan.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(96, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Aplikasi Pendaftaran Mahasiswa"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 487)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnTampilkan)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.ComboPendidikan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Pendaftaran Mahasiswa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents RbLaki As System.Windows.Forms.RadioButton
    Friend WithEvents TxtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CbTi As System.Windows.Forms.CheckBox
    Friend WithEvents CbIlkom As System.Windows.Forms.CheckBox
    Friend WithEvents CbManajemen As System.Windows.Forms.CheckBox
    Friend WithEvents CbHukum As System.Windows.Forms.CheckBox
    Friend WithEvents CbTE As System.Windows.Forms.CheckBox
    Friend WithEvents CbTM As System.Windows.Forms.CheckBox
    Friend WithEvents CbPGSD As System.Windows.Forms.CheckBox
    Friend WithEvents CbAkuntansi As System.Windows.Forms.CheckBox
    Friend WithEvents CbIndus As System.Windows.Forms.CheckBox
    Friend WithEvents ComboPendidikan As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnTampilkan As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
