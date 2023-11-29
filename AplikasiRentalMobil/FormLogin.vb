Public Class FormLogin

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtUsername.Focus()
        TxtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If TxtUsername.Text = "" And TxtPassword.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username dan Password")
        ElseIf TxtUsername.Text = "liffsan" And TxtPassword.Text = "admin11" Then
            MsgBox("Login Berhasil", MsgBoxStyle.Information, "Akses Berhasil")
            FormMenuUtama.Show()
            Me.Hide()
        Else
            MsgBox("Username atau Password salah!", MsgBoxStyle.Critical, "Cek Username dan Password")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TxtPassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
        End If
        TxtPassword.Focus()
    End Sub

    Private Sub CheckBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CheckBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TxtUsername.Text = "" And TxtPassword.Text = "" Then
                MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Isi Username dan Password")
            ElseIf TxtUsername.Text = "liffsan" And TxtPassword.Text = "admin11" Then
                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Akses Berhasil")
                FormMenuUtama.Show()
                Me.Hide()
            Else
                MsgBox("Username atau Password salah!", MsgBoxStyle.Critical, "Cek Username dan Password")
            End If
        End If
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub FormLogin_Resize(sender As Object, e As EventArgs) Handles Me.Resize


    End Sub
End Class
