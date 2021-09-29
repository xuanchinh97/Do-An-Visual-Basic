Public Class nhanvien

    Private Sub loadata()
        ' đổ dữ liệu lên grid
        Me.NhanVienTableAdapter.Fill(Me.DataSet1.NhanVien)
        Me.BacluongTableAdapter.Fill(Me.DataSet1.Bacluong)
        Me.PhongBanTableAdapter1.Fill(Me.DataSet1.PhongBan)
        Me.CongviecTableAdapter1.Fill(Me.DataSet1.Congviec)

        If radioNam.Tag = "Nam" Then
            radioNam.Checked = True
        Else
            radioNu.Checked = True
        End If
    End Sub
    Private Sub nhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadata()
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim gioitinh As String = ""
        If radioNam.Checked = True Then
            gioitinh = "Nam"
        Else
            gioitinh = "Nữ"
        End If

        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO NhanVien
                         (MaNV_id, Ho_ten, Dan_toc, Gioi_Tinh, Que_Quan, Ngay_Sinh, SDT, MaCV_fk, Ma_PhongBan_fk, BacLuong_fk)
                         VALUES ('" & txtManv.Text & "',
                                N'" & txtHoten.Text & "',
                                N'" & txtDantoc.Text & "',
                                N'" & gioitinh & "',
                                N'" & txtDiachi.Text & "',
                                '" & dateNgaysinh.Value.Date & "',
                                N'" & txtSdt.Text & "',
                                N'" & cbCongviec.SelectedValue.ToString() & "',
                                N'" & cbPhongban.SelectedValue.ToString() & "',
                                N'" & cbBacluong.SelectedValue.ToString() & "')"

            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            loadata()
            MsgBox("Thêm dữ liệu thành công !")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim gioitinh As String = ""
        If radioNam.Checked = True Then
            gioitinh = "Nam"
        Else
            gioitinh = "Nữ"
        End If

        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE NhanVien SET
                         [MaNV_id] = '" & txtManv.Text & "',
                         [Ho_ten] = N'" & txtHoten.Text & "',
                         [Dan_toc] = N'" & txtDantoc.Text & "',
                         [Gioi_Tinh] = N'" & gioitinh & "',
                         [Que_Quan] = N'" & txtDiachi.Text & "',
                         [Ngay_Sinh] = '" & dateNgaysinh.Value.Date & "',
                         [SDT] = N'" & txtSdt.Text & "',
                         [MaCV_fk] = N'" & cbCongviec.SelectedValue.ToString() & "',
                         [Ma_PhongBan_fk] = N'" & cbPhongban.SelectedValue.ToString() & "',
                         [BacLuong_fk] = N'" & cbBacluong.SelectedValue.ToString() & "'
                         WHERE [MaNV_id] = '" & txtManv.Text & "'"

            OleDbUpdateCommand1.CommandText = sql
            OleDbUpdateCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            loadata()
            MsgBox("Cập nhật dữ liệu thành công !")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM NhanVien WHERE [MaNV_id] = '" & txtManv.Text & "'"
            OleDbDeleteCommand1.CommandText = sql
            OleDbDeleteCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            loadata()
            MsgBox("Dữ liệu đã xóa thành công !")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Visible = False
    End Sub

    Private Sub gridNhanvien_SelectionChanged(sender As Object, e As EventArgs) Handles gridNhanvien.SelectionChanged

        If (gridNhanvien.SelectedCells.Count > 0) Then
            cbCongviec.SelectedValue = gridNhanvien.Rows(gridNhanvien.CurrentRow.Index).Cells(7).Value
            cbPhongban.SelectedValue = gridNhanvien.Rows(gridNhanvien.CurrentRow.Index).Cells(8).Value
            cbBacluong.SelectedValue = gridNhanvien.Rows(gridNhanvien.CurrentRow.Index).Cells(9).Value

            Dim gtChecked As String = gridNhanvien.Rows(gridNhanvien.CurrentRow.Index).Cells(3).Value
            If Not IsDBNull(gtChecked) Then
                If gtChecked = "Nam" Then
                    radioNam.Checked = True
                Else
                    radioNu.Checked = True

                End If
            End If
        End If
    End Sub

End Class