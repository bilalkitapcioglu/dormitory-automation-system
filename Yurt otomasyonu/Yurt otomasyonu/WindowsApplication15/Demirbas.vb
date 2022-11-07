Imports System.Data.SqlClient
Public Class Demirbas
    Dim baglanti As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=YurtOtomasyon;integrated security=true")
    Dim komut As SqlCommand = New SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtadet.Text.Length > 0 And txtadi.Text.Length > 0 Then

            Try
                If baglanti.State = ConnectionState.Closed Then
                    baglanti.Open()
                End If
                Try
                    komut.CommandText = "Insert into demirbaslar(odaid,demirbasadi,adet)values('" & ComboBox1.SelectedValue & "','" & txtadi.Text & "','" & txtadet.Text & "')"
                    komut.Connection = baglanti
                    komut.ExecuteNonQuery()
                    MsgBox("Kayit Eklendi", , "Demirbaslar")
                    sil()
                    goster()
                Catch ex As Exception
                    MsgBox("Hata")
                End Try
            Catch ex As Exception
                MsgBox("Hata")
            Finally
                If baglanti.State = ConnectionState.Open Then
                    baglanti.Close()
                End If
            End Try
        Else
            MsgBox("Boş Alanları Doldurunuz", , "Demirbaşlar")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnaSayfa.Hide()
        goster()
        getodano()
    End Sub
    Private Sub goster()
        Dim adp As New SqlDataAdapter("select odaid,demirbasno,demirbasadi,adet from  demirbaslar order by odaid", baglanti)
        Dim td As DataTable = New DataTable()
        adp.Fill(td)
        DataGridView1.DataSource = td
    End Sub
    Private Sub getodano()
        Dim adp As New SqlDataAdapter("select * from odalar", baglanti)
        Dim td As DataTable = New DataTable()
        adp.Fill(td)
        ComboBox1.DataSource = td
        ComboBox1.ValueMember = "odaid"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtadet.Text.Length > 0 And txtadi.Text.Length > 0 Then
            Try

                If baglanti.State = ConnectionState.Closed Then
                    baglanti.Open()
                End If
                Try
                    komut.CommandText = "Update demirbaslar set demirbasadi='" & txtadi.Text & "',adet='" & txtadet.Text & "',odaid='" & ComboBox1.SelectedValue & "'where demirbasno='" & TextBox1.Text & "'"
                    komut.Connection = baglanti
                    komut.ExecuteNonQuery()
                    MsgBox("Kayit Değişti", , "Demirbaslar")
                    sil()
                    goster()

                Catch ex As Exception
                    MsgBox("Hata")
                End Try
            Catch ex As Exception
                MsgBox("Hata")
            Finally
                If baglanti.State = ConnectionState.Open Then
                    baglanti.Close()
                End If
            End Try
        Else
            MsgBox("Boş Alanları Doldurunuz", , "Demirbaslar")
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value()
            txtadi.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value()
            txtadet.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value()
            TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text.Length > 0 Then

            Try

                If baglanti.State = ConnectionState.Closed Then
                    baglanti.Open()
                End If
                Try
                    komut.CommandText = "delete from demirbaslar where demirbasno='" & TextBox1.Text & "' "
                    komut.Connection = baglanti
                    komut.ExecuteNonQuery()
                    MsgBox("Kayit Silindi", , "Demirbaslar")
                    goster()
                Catch ex As Exception
                    MsgBox("Hata", , "Demirbaslar")
                End Try
            Catch ex As Exception
                MsgBox("Hata")
            Finally
                If baglanti.State = ConnectionState.Open Then
                    baglanti.Close()
                End If
            End Try
        Else
            MsgBox("Herhangi Bir Demirbaş Seçilmedi", , "Demirbaslar")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AnaSayfa.Show()
    End Sub

    Private Sub txtadet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtadet.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
    Private Sub sil()
        txtadet.Clear()
        txtadi.Clear()
        TextBox1.Clear()
    End Sub
End Class