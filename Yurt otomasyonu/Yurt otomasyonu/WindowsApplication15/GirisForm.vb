Public Class GirisForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "123456" Then
            AnaSayfa.Show()

        Else
            MsgBox("Yanlış Kullanıcı Adı/Şifre", , "Yurt Otomasyonu")
        End If
    End Sub
End Class
