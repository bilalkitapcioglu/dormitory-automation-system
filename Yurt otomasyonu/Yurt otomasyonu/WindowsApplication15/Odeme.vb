Imports System.Data.SqlClient
Public Class Odeme
    Dim baglanti As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=YurtOtomasyon;integrated security=true")
    Dim komut As SqlCommand = New SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adp As New SqlDataAdapter("select adsoyad,kalanpara from kayit where tckimlikno like'" & txtc.Text & "'", baglanti)
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
                Dim odenen As Integer
                odenen = Val(txttoplamborc.Text) - (txtodenenucret.Text)
                komut.CommandText = "update kayit set kalanpara='" & odenen & "'where tckimlikno= '" & txtc.Text & "' "
                komut.Connection = baglanti
                komut.ExecuteNonQuery()
                MsgBox("Ucret Ödendi", , "Ödeme")
                yenile()
            Catch ex As Exception
                MsgBox("Hata", , "Ödeme")
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
            txtadsoyad.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value()
            txttoplamborc.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value()
        Catch ex As Exception

        End Try


    End Sub
    Private Sub yenile()
        Dim adp As New SqlDataAdapter("select adsoyad,kalanpara from kayit", baglanti)
        Dim td As DataTable = New DataTable()
        adp.Fill(td)
        DataGridView1.DataSource = td
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AnaSayfa.Show()
    End Sub

    Private Sub Odeme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnaSayfa.Hide()
    End Sub

    Private Sub txtc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtc.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtodenenucret_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtodenenucret.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class