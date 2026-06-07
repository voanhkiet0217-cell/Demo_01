Public Class frm_DangNhap

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mặc định che mật khẩu
        Guna2TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged
        If Guna2ToggleSwitch1.Checked Then
            ' Hiện mật khẩu
            Guna2TextBox2.UseSystemPasswordChar = False
        Else
            ' Che mật khẩu bằng dấu *
            Guna2TextBox2.UseSystemPasswordChar = True
        End If
    End Sub


End Class
