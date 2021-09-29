Public Class phongban
    Private Sub loadata()
        Me.PhongBanTableAdapter.Fill(Me.DataSet1.PhongBan)
    End Sub
    Private Sub phongban_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.PhongBan' table. You can move, or remove it, as needed.
        loadata()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO PhongBan (Ma_PhongBan_id, Ten_PhongBan, SDT_PhongBan, Diachi) VALUES ('" & txtMapb.Text & "',N'" & txtTenpb.Text & "',N'" & txtSdt.Text & "',N'" & txtDiachi.Text & "')"
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
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE [PhongBan] SET [Ma_PhongBan_id] = '" & txtMapb.Text & "', [Ten_PhongBan] = N'" & txtTenpb.Text & "', [SDT_PhongBan] = '" & txtSdt.Text & "', [Diachi] = N'" & txtDiachi.Text & "' WHERE Ma_PhongBan_id= '" & txtMapb.Text & "'"
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
            Dim sql As String = "DELETE FROM [PhongBan] WHERE [Ma_PhongBan_id] = '" & txtMapb.Text & "'"
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
        Me.Hide()
    End Sub

End Class