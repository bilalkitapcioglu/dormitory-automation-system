Imports System.Data.SqlClient
Public Class Listele
    Dim baglanti As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=YurtOtomasyon;integrated security=true")
    Dim komut As SqlCommand = New SqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnaSayfa.Hide()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim adp As New SqlDataAdapter("select odano,yatakno,tckimlikno,adsoyad,telefonno,dogumtarihi,adres,velitel,kalanpara from kayit order by odano", baglanti)
        Dim td As DataTable = New DataTable()
        adp.Fill(td)
        DataGridView1.DataSource = td
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim adp As New SqlDataAdapter("select * from calisan order by calisantc", baglanti)
        Dim td As DataTable = New DataTable()
        adp.Fill(td)
        DataGridView1.DataSource = td
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AnaSayfa.Show()
    End Sub
End Class