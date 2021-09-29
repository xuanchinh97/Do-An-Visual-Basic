Public Class login
    Private Sub btnDangnhap_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click
        If txtTendangnhap.Text = "admin" And txtMatkhau.Text = "admin" Then
            trangchu.Show()
            Me.Visible = False
        Else
            MsgBox("Tài khoản hoặc mật khẩu không chính xác. Vui lòng thử lại !!")
        End If


    End Sub
End Class