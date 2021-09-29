Public Class trangchu

    Private Sub nhanvien_Click(sender As Object, e As EventArgs) Handles btnNhanvien.Click
        nhanvien.Show()
        congviec.Hide()
        bacluong.Hide()
        phongban.Hide()
        hopdong.Hide()

    End Sub

    Private Sub congviec_Click(sender As Object, e As EventArgs) Handles btnCongviec.Click
        nhanvien.Hide()
        congviec.Show()
        bacluong.Hide()
        hopdong.Hide()
        phongban.Hide()
    End Sub

    Private Sub phongban_Click(sender As Object, e As EventArgs) Handles btnPhongban.Click
        nhanvien.Hide()
        congviec.Hide()
        bacluong.Hide()
        hopdong.Hide()
        phongban.Show()
    End Sub

    Private Sub bacluong_Click(sender As Object, e As EventArgs) Handles btnBacluong.Click
        nhanvien.Hide()
        congviec.Hide()
        bacluong.Show()
        hopdong.Hide()
        phongban.Hide()
    End Sub

    Private Sub hopdong_Click(sender As Object, e As EventArgs) Handles btnHopdong.Click
        nhanvien.Hide()
        congviec.Hide()
        bacluong.Hide()
        hopdong.Show()
        phongban.Hide()
    End Sub

End Class