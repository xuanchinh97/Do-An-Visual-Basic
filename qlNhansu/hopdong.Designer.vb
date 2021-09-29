<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hopdong
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hopdong))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMahd = New System.Windows.Forms.TextBox()
        Me.HopdongBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New qlNhansu.DataSet1()
        Me.txtLoaihd = New System.Windows.Forms.TextBox()
        Me.txtManv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gridHopdong = New System.Windows.Forms.DataGridView()
        Me.MaHDidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoaiHDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaNVfkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.HopdongTableAdapter = New qlNhansu.DataSet1TableAdapters.HopdongTableAdapter()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.HopdongBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridHopdong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 39)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(267, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Danh Sách Hợp Đồng"
        '
        'txtMahd
        '
        Me.txtMahd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HopdongBindingSource, "MaHD_id", True))
        Me.txtMahd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMahd.Location = New System.Drawing.Point(116, 76)
        Me.txtMahd.Name = "txtMahd"
        Me.txtMahd.Size = New System.Drawing.Size(117, 22)
        Me.txtMahd.TabIndex = 1
        '
        'HopdongBindingSource
        '
        Me.HopdongBindingSource.DataMember = "Hopdong"
        Me.HopdongBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtLoaihd
        '
        Me.txtLoaihd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HopdongBindingSource, "LoaiHD", True))
        Me.txtLoaihd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoaihd.Location = New System.Drawing.Point(116, 141)
        Me.txtLoaihd.Name = "txtLoaihd"
        Me.txtLoaihd.Size = New System.Drawing.Size(186, 22)
        Me.txtLoaihd.TabIndex = 2
        '
        'txtManv
        '
        Me.txtManv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HopdongBindingSource, "MaNV_fk", True))
        Me.txtManv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManv.Location = New System.Drawing.Point(116, 109)
        Me.txtManv.Name = "txtManv"
        Me.txtManv.Size = New System.Drawing.Size(117, 22)
        Me.txtManv.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Mã HĐ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Loại HĐ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Mã NV:"
        '
        'gridHopdong
        '
        Me.gridHopdong.AutoGenerateColumns = False
        Me.gridHopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridHopdong.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaHDidDataGridViewTextBoxColumn, Me.LoaiHDDataGridViewTextBoxColumn, Me.MaNVfkDataGridViewTextBoxColumn})
        Me.gridHopdong.DataSource = Me.HopdongBindingSource
        Me.gridHopdong.Location = New System.Drawing.Point(0, 257)
        Me.gridHopdong.Name = "gridHopdong"
        Me.gridHopdong.RowTemplate.Height = 25
        Me.gridHopdong.Size = New System.Drawing.Size(710, 211)
        Me.gridHopdong.TabIndex = 21
        '
        'MaHDidDataGridViewTextBoxColumn
        '
        Me.MaHDidDataGridViewTextBoxColumn.DataPropertyName = "MaHD_id"
        Me.MaHDidDataGridViewTextBoxColumn.HeaderText = "MaHD_id"
        Me.MaHDidDataGridViewTextBoxColumn.Name = "MaHDidDataGridViewTextBoxColumn"
        '
        'LoaiHDDataGridViewTextBoxColumn
        '
        Me.LoaiHDDataGridViewTextBoxColumn.DataPropertyName = "LoaiHD"
        Me.LoaiHDDataGridViewTextBoxColumn.HeaderText = "LoaiHD"
        Me.LoaiHDDataGridViewTextBoxColumn.Name = "LoaiHDDataGridViewTextBoxColumn"
        '
        'MaNVfkDataGridViewTextBoxColumn
        '
        Me.MaNVfkDataGridViewTextBoxColumn.DataPropertyName = "MaNV_fk"
        Me.MaNVfkDataGridViewTextBoxColumn.HeaderText = "MaNV_fk"
        Me.MaNVfkDataGridViewTextBoxColumn.Name = "MaNVfkDataGridViewTextBoxColumn"
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(597, 72)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(64, 26)
        Me.btnThem.TabIndex = 22
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(597, 104)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(64, 26)
        Me.btnSua.TabIndex = 23
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Red
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(597, 136)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(64, 26)
        Me.btnXoa.TabIndex = 25
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(597, 168)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(64, 27)
        Me.btnThoat.TabIndex = 26
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'HopdongTableAdapter
        '
        Me.HopdongTableAdapter.ClearBeforeFill = True
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        Hopdong.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Hopdong"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=THINKPADT460\SQLEXPRESS;Integrated Security=SSPI;" &
    "Initial Catalog=quanly_nhan_su"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [Hopdong] ([MaHD_id], [LoaiHD], [MaNV_fk]) VALUES (?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaHD_id", System.Data.OleDb.OleDbType.VarWChar, 0, "MaHD_id"), New System.Data.OleDb.OleDbParameter("LoaiHD", System.Data.OleDb.OleDbType.VarWChar, 0, "LoaiHD"), New System.Data.OleDb.OleDbParameter("MaNV_fk", System.Data.OleDb.OleDbType.VarWChar, 0, "MaNV_fk")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [Hopdong] SET [MaHD_id] = ?, [LoaiHD] = ?, [MaNV_fk] = ? WHERE (([MaHD_id]" &
    " = ?) AND ((? = 1 AND [LoaiHD] IS NULL) OR ([LoaiHD] = ?)) AND ((? = 1 AND [MaNV" &
    "_fk] IS NULL) OR ([MaNV_fk] = ?)))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaHD_id", System.Data.OleDb.OleDbType.VarWChar, 0, "MaHD_id"), New System.Data.OleDb.OleDbParameter("LoaiHD", System.Data.OleDb.OleDbType.VarWChar, 0, "LoaiHD"), New System.Data.OleDb.OleDbParameter("MaNV_fk", System.Data.OleDb.OleDbType.VarWChar, 0, "MaNV_fk"), New System.Data.OleDb.OleDbParameter("Original_MaHD_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaHD_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_LoaiHD", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LoaiHD", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_LoaiHD", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LoaiHD", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MaNV_fk", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaNV_fk", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaNV_fk", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaNV_fk", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [Hopdong] WHERE (([MaHD_id] = ?) AND ((? = 1 AND [LoaiHD] IS NULL) OR" &
    " ([LoaiHD] = ?)) AND ((? = 1 AND [MaNV_fk] IS NULL) OR ([MaNV_fk] = ?)))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaHD_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaHD_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_LoaiHD", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LoaiHD", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_LoaiHD", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LoaiHD", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MaNV_fk", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaNV_fk", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaNV_fk", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaNV_fk", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Hopdong", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaHD_id", "MaHD_id"), New System.Data.Common.DataColumnMapping("LoaiHD", "LoaiHD"), New System.Data.Common.DataColumnMapping("MaNV_fk", "MaNV_fk")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'hopdong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(712, 466)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.gridHopdong)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtManv)
        Me.Controls.Add(Me.txtLoaihd)
        Me.Controls.Add(Me.txtMahd)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "hopdong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "hopdong"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.HopdongBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridHopdong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMahd As TextBox
    Friend WithEvents txtLoaihd As TextBox
    Friend WithEvents txtManv As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gridHopdong As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents HopdongBindingSource As BindingSource
    Friend WithEvents HopdongTableAdapter As DataSet1TableAdapters.HopdongTableAdapter
    Friend WithEvents MaHDidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoaiHDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaNVfkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
End Class
