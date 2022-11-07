Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
        DateTimePicker1.Value = Format(Now)

        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "dd MMMM yyyy"
        DateTimePicker2.Value = Format(Now)
    End Sub

    Private Sub BtnTampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTampilkan.Click
        Dim JK As String
        Dim Jurusan As String

        If RbLaki.Checked = True Then
            JK = RbLaki.Text
        Else
            JK = RbPerempuan.Text
        End If

        If CbIlkom.Checked = True Then
            Jurusan = Jurusan & CbIlkom.Text & ", "
        End If
        If CbTi.Checked = True Then
            Jurusan = Jurusan & CbTi.Text & ", "
        End If
        If CbManajemen.Checked = True Then
            Jurusan = Jurusan & CbManajemen.Text & ", "
        End If
        If CbIndus.Checked = True Then
            Jurusan = Jurusan & CbIndus.Text & ", "
        End If
        If CbAkuntansi.Checked = True Then
            Jurusan = Jurusan & CbAkuntansi.Text & ", "
        End If
        If CbHukum.Checked = True Then
            Jurusan = Jurusan & CbHukum.Text & ", "
        End If
        If CbPGSD.Checked = True Then
            Jurusan = Jurusan & CbPGSD.Text & ", "
        End If
        If CbTM.Checked = True Then
            Jurusan = Jurusan & CbTM.Text & ", "
        End If
        If CbTE.Checked = True Then
            Jurusan = Jurusan & CbTE.Text & ", "
        End If

        MessageBox.Show("Nama : " & TxtNama.Text & vbCrLf & "Tanggal Lahir : " & DateTimePicker1.Text & vbCrLf & "Jenis Kelamin : " & JK & vbCrLf & "Alamat : " & TxtAlamat.Text & vbCrLf & "Pilihan Jurusan : " & Jurusan & vbCrLf & "Pendidikan Sebelumnya : " & ComboPendidikan.Text & vbCrLf & "Tanggal Daftar : " & DateTimePicker2.Text, "Hasil Pengisian", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TxtAlamat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAlamat.TextChanged

    End Sub

    Private Sub CbPGSD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbPGSD.CheckedChanged

    End Sub
End Class
