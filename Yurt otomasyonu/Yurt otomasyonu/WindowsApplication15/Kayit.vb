Imports System.Data.SqlClient
Public Class Kayit
    Dim baglanti As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=YurtOtomasyon;integrated security=true")
    Dim komut As SqlCommand = New SqlCommand
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboyatak.Items.Clear()
        combooda.Items.Clear()
        AnaSayfa.Hide()
        goster()
        getodano()
        sayac = 0
    End Sub
    Private Function getTcKontrol(tc As String) As Integer
        Dim adp As New SqlDataAdapter("select TcKimlikNo from kayit where TcKimlikNo='" & tc & "'", baglanti)
        Dim td As DataTable = New DataTable()
        adp.Fill(td)
        If td.Rows.Count() > 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtadsoyad.Text.Length > 0 And txtadres.Text.Length > 0 And txttc.Text.Length > 0 And txttelefon.Text.Length > 0 And txtucret.Text.Length > 0 And txtvelitel.Text.Length > 0 Then
            If txttc.Text.Length = 11 And txttelefon.Text.Length = 10 And txtvelitel.Text.Length = 10 Then
                If getTcKontrol(txttc.Text) = 0 Then

                    Try

                        If baglanti.State = ConnectionState.Closed Then
                            baglanti.Open()
                        End If
                        Try
                            komut.CommandText = "set dateformat dmy Insert into Kayit(tckimlikno,adsoyad,telefonno,dogumtarihi,adres,velitel,odano,yatakno,kalanpara)values('" & txttc.Text & "','" & txtadsoyad.Text & "','" & txttelefon.Text & "','" & DateTimePicker1.Value & "','" & txtadres.Text & "','" & txtvelitel.Text & "','" & combooda.SelectedValue & "','" & comboyatak.SelectedValue & "','" & txtucret.Text & "') "
                            komut.Connection = baglanti
                            komut.ExecuteNonQuery()
                            MsgBox("Kayit Basarili", , "Öğrenci Kayıt")
                            goster()
                            sil()
                        Catch ex As Exception
                            MsgBox("Yatak Dolu", , "Ögrenci Kayit")
                        End Try
                    Catch ex As Exception
                        MsgBox("Hata" & ex.Message)
                    Finally
                        If baglanti.State = ConnectionState.Open Then
                            baglanti.Close()
                        End If
                    End Try
                Else
                    MsgBox("Aynı kayıt mevcut", MsgBoxStyle.Critical, "Öğrenci Kayit")

                End If
                sayac = 0
            Else
                MsgBox("Hatali Veri Girişi Yaptiniz", , "Öğrenci Kayit")
            End If
        Else
            MsgBox("Boş Alanları Doldurunuz", , "Öğrenci Kayit")
        End If

    End Sub
    Private Sub getodano()
        Dim adp As New SqlDataAdapter("select * from odalar", baglanti)
        Dim td As DataTable = New DataTable()
        adp.Fill(td)
        combooda.DataSource = td
        combooda.ValueMember = "odano"
    End Sub
    Private Sub getyatakno(odano As String)
        Dim adp As New SqlDataAdapter("select distinct a.yatakno from yataklar a where odaid=" & odano, baglanti)
        Dim td As DataTable = New DataTable()
        adp.Fill(td)
        comboyatak.DataSource = td
        comboyatak.ValueMember = "yatakno"
    End Sub

    Private Sub goster()
        Dim adp As New SqlDataAdapter("select tckimlikno,adsoyad,telefonno,dogumtarihi,adres,velitel,odano,yatakno,kalanpara from kayit", baglanti)
        Dim td As DataTable = New DataTable()
        adp.Fill(td)
        DataGridView1.DataSource = td
    End Sub
    Dim sayac As Integer = 0

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txttc.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value()
            txtadsoyad.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value()
            txttelefon.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value()
            DateTimePicker1.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value()
            txtadres.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value()
            txtvelitel.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value()
            combooda.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value()
            comboyatak.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value()
            txtucret.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value()
            sayac = 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtadsoyad.Text.Length > 0 And txtadres.Text.Length > 0 And txttelefon.Text.Length > 0 And txtucret.Text.Length > 0 And txtvelitel.Text.Length > 0 Then
            If txttc.Text.Length = 11 And txttelefon.Text.Length = 10 And txtvelitel.Text.Length = 10 Then
                Try

                    If baglanti.State = ConnectionState.Closed Then
                        baglanti.Open()
                    End If
                    Try
                        komut.CommandText = "set dateformat dmy update kayit set adsoyad='" & txtadsoyad.Text & "',telefonno='" & txttelefon.Text & "',dogumtarihi='" & DateTimePicker1.Value & "',adres='" & txtadres.Text & "',velitel='" & txtvelitel.Text & "',odano='" & combooda.SelectedValue & "',yatakno='" & comboyatak.SelectedValue & "',kalanpara='" & txtucret.Text & "' where tckimlikno='" & txttc.Text & "'"
                        komut.Connection = baglanti
                        komut.ExecuteNonQuery()
                        MsgBox("Kayit Güncellendi", , "Öğrenci Kayıt")
                        goster()
                        sil()
                    Catch ex As Exception
                        MsgBox("Yatak Dolu", , "Ogrenci Kayit")
                    End Try
                Catch ex As Exception
                    MsgBox("Hata")
                Finally
                    If baglanti.State = ConnectionState.Open Then
                        baglanti.Close()
                    End If
                End Try
                sayac = 0
            Else
                MsgBox("Hatali Veri Girişi Yaptiniz", , "Öğrenci Kayit")
            End If
        Else
            MsgBox("Boş Alanları Doldurunuz", , "Öğrenci Kayit")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txttc.Text.Length > 0 Then

            Try

                If baglanti.State = ConnectionState.Closed Then
                    baglanti.Open()
                End If
                Try
                    komut.CommandText = "delete from kayit where tckimlikno='" & txttc.Text & "' "
                    komut.Connection = baglanti
                    komut.ExecuteNonQuery()
                    MsgBox("Kayit Silindi", , "Öğrenci Kayıt")
                    goster()
                    sil()
                Catch ex As Exception
                    MsgBox("Hata", , "Ogrenci Kayit")
                End Try
            Catch ex As Exception
                MsgBox("Hata")
            Finally
                If baglanti.State = ConnectionState.Open Then
                    baglanti.Close()
                End If
            End Try
            sayac = 0
        Else
            MsgBox("Silinmek İstenen Kaydi Belirtiniz", , "Öğrenci Kayit")
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AnaSayfa.Show()
    End Sub

    Private Sub txttc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttc.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtadsoyad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtadsoyad.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttelefon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefon.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtvelitel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvelitel.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtucret_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtucret.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txttc.Text.Length > 0 Then
            Dim adp As New SqlDataAdapter("select tckimlikno,adsoyad,telefonno,dogumtarihi,adres,velitel,odano,yatakno,kalanpara from kayit where tckimlikno like'" & txttc.Text & "'", baglanti)
            Dim td As DataTable = New DataTable()
            adp.Fill(td)
            DataGridView1.DataSource = td
            sayac = 0
        Else
            MsgBox("Aranmak İstenen tckimlikno'yu Belirtiniz", , "Öğrenci Kayit")
        End If
    End Sub

    Private Sub sil()
        txttc.Clear()
        txtadsoyad.Clear()
        txtadres.Clear()
        txttelefon.Clear()
        txtucret.Clear()
        txtvelitel.Clear()
    End Sub

    Private Sub combooda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combooda.SelectedIndexChanged
        If sayac = 0 Then
            getyatakno(combooda.Text)
        End If


    End Sub
End Class