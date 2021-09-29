Public Class congviec
    Private Sub loadata()
        Me.CongviecTableAdapter.Fill(Me.DataSet1.Congviec)
    End Sub
    Private Sub congviec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Congviec' table. You can move, or remove it, as needed.
        loadata()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO Congviec(MaCV_id, TenCV) VALUES(N'" & txtMacv.Text & "',N'" & txtTencv.Text & "')"
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
            Dim sql As String = "UPDATE [Congviec] SET [MaCV_id] = '" & txtMacv.Text & "', [TenCV] = N'" & txtTencv.Text & "' WHERE [MaCV_id] = '" & txtMacv.Text & "'"
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
            Dim sql As String = "DELETE FROM [Congviec] WHERE [MaCV_id] = '" & txtMacv.Text & "'"
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