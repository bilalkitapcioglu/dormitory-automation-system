Imports System.Data.SqlClient
Public Class calisan
    Dim baglanti As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=YurtOtomasyon;integrated security=true")
    Dim komut As SqlCommand = New SqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnaSayfa.Hide()
        goster()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Length > 0 And TextBox2.Text.Length > 0 And TextBox3.Text.Length > 0 And TextBox4.Text.Length > 0 Then
            If TextBox1.Text.Length = 11 And TextBox3.Text.Length = 10 Then
                Try

                    If baglanti.State = ConnectionState.Closed Then
                        baglanti.Open()
                    End If
                    Try
                        komut.CommandText = "Insert into calisan(calisantc,calisanadsoyad,calisantel,gorev)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
                        komut.Connection = baglanti
                        komut.ExecuteNonQuery()
                        MsgBox("Kayit Eklendi", , "Calisan Kayıt")
                        goster()
                        sil()
                    Catch ex As Exception
                        MsgBox("Hata", , "Calisan Kayit")
                    End Try
                Catch ex As Exception
                    MsgBox("Hata")
                Finally
                    If baglanti.State = ConnectionState.Open Then
                        baglanti.Close()
                    End If
                End Try
            Else
                MsgBox("Hatali Veri Girişi Yaptiniz", , "Calisan Kayit")
            End If
        Else
            MsgBox("Boş Alanları Doldurunuz", , "Calisan Kayit")
        End If
    End Sub
    Private Sub goster()
        Dim adp As New SqlDataAdapter("select * from calisan", baglanti)
        Dim td As DataTable = New DataTable()
        adp.Fill(td)
        DataGridView1.DataSource = td
    End Sub
    Private Sub sil()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value()
            TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value()
            TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value()
            TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text.Length > 0 And TextBox3.Text.Length > 0 And TextBox4.Text.Length > 0 Then
            If TextBox1.Text.Length = 11 And TextBox3.Text.Length = 10 Then
                Try

                    If baglanti.State = ConnectionState.Closed Then
                        baglanti.Open()
                    End If
                    Try
                        komut.CommandText = "update calisan set calisanadsoyad='" & TextBox2.Text & "',calisantel='" & TextBox3.Text & "',gorev='" & TextBox4.Text & "'where calisantc='" & TextBox1.Text & "'"
                        komut.Connection = baglanti
                        komut.ExecuteNonQuery()
                        MsgBox("Kayit Güncellendi", , "Calisan Kayit")
                        goster()
                        sil()
                    Catch ex As Exception
                        MsgBox("Hata", , "Calisan Kayit")
                    End Try
                Catch ex As Exception
                    MsgBox("Hata")
                Finally
                    If baglanti.State = ConnectionState.Open Then
                        baglanti.Close()
                    End If
                End Try
            Else
                MsgBox("Hatali Veri Girişi Yaptiniz", , "Calisan Kayit")
            End If
        Else
            MsgBox("Boş Alanları Doldurunuz", , "Calisan Kayit")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text.Length > 0 Then
            Try

                If baglanti.State = ConnectionState.Closed Then
                    baglanti.Open()
                End If
                Try
                    komut.CommandText = "delete from calisan where calisantc='" & TextBox1.Text & "' "
                    komut.Connection = baglanti
                    komut.ExecuteNonQuery()
                    MsgBox("Kayit Silindi", , "Calisan Kayit")
                    goster()
                    sil()
                Catch ex As Exception
                    MsgBox("Hata", , "Calisan Kayit")
                End Try
            Catch ex As Exception
                MsgBox("Hata")
            Finally
                If baglanti.State = ConnectionState.Open Then
                    baglanti.Close()
                End If
            End Try
        Else
            MsgBox("Silinmek İstenen Kaydi Belirtiniz", , "Calisan Kayit")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text.Length > 0 Then
            Dim adp As New SqlDataAdapter("select * from calisan where calisantc like'" & TextBox1.Text & "'", baglanti)
            Dim td As DataTable = New DataTable()
            adp.Fill(td)
            DataGridView1.DataSource = td
        Else
            MsgBox("Aranacak tckimlikno'yu giriniz", , "Calisan Kayit")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AnaSayfa.Show()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
End Class