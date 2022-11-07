Imports System.Data.SqlClient
Public Class İzinler
    Dim baglanti As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=YurtOtomasyon;integrated security=true")
    Dim komut As SqlCommand = New SqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        AnaSayfa.Hide()
        Dim adp As New SqlDataAdapter("select tckimlikno from kayit order by tckimlikno", baglanti)
        Dim td As DataTable = New DataTable()
        adp.Fill(td)
        ComboBox1.DataSource = td
        ComboBox1.ValueMember = "tckimlikno"
        goster()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Length > 0 Then
            Try

                If baglanti.State = ConnectionState.Closed Then
                    baglanti.Open()
                End If
                Try
                    komut.CommandText = "set dateformat dmy Insert into izin(tckimlikno,gidistarihi,donustarihi,adres)values('" & ComboBox1.SelectedValue & "','" & DateTimePicker1.Value & "','" & DateTimePicker2.Value & "','" & TextBox1.Text & "' )"
                    komut.Connection = baglanti
                    komut.ExecuteNonQuery()
                    MsgBox("Kayit Eklendi", , "İzinler")
                    goster()
                Catch ex As Exception
                    MsgBox("Hata", , "İzinler")
                End Try
            Catch ex As Exception
                MsgBox("Hata")
            Finally
                If baglanti.State = ConnectionState.Open Then
                    baglanti.Close()
                End If
            End Try
        Else
            MsgBox("Lütfen Adres Bölümünü Giriniz", , "İzinler")
        End If
    End Sub
    Private Sub goster()
        Dim adp As New SqlDataAdapter("set dateformat dmy select a.tckimlikno,a.adsoyad,b.gidistarihi,b.donustarihi,b.adres from izin b inner join kayit a on a.TcKimlikNo=b.tckimlikno", baglanti)
        Dim td As DataTable = New DataTable()
        adp.Fill(td)
        DataGridView1.DataSource = td
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()
            End If
            Try
                komut.CommandText = "delete from izin where tckimlikno='" & ComboBox1.Text & "' "
                komut.Connection = baglanti
                komut.ExecuteNonQuery()
                MsgBox("Kayit Silindi", , "İzinler")
                goster()
            Catch ex As Exception
                MsgBox("Hata", , "İzinler")
            End Try
        Catch ex As Exception
            MsgBox("Hata")
        Finally
            If baglanti.State = ConnectionState.Open Then
                baglanti.Close()
            End If
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value()
            DateTimePicker1.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value()
            DateTimePicker2.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value()
            TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AnaSayfa.Show()
    End Sub
End Class