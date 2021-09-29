<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class nhanvien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nhanvien))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtManv = New System.Windows.Forms.TextBox()
        Me.NhanVienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New qlNhansu.DataSet1()
        Me.txtHoten = New System.Windows.Forms.TextBox()
        Me.txtDantoc = New System.Windows.Forms.TextBox()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtSdt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.cbCongviec = New System.Windows.Forms.ComboBox()
        Me.cbPhongban = New System.Windows.Forms.ComboBox()
        Me.cbBacluong = New System.Windows.Forms.ComboBox()
        Me.gridNhanvien = New System.Windows.Forms.DataGridView()
        Me.MaNVidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HotenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DantocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QueQuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaCVfkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaPhongBanfkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BacLuongfkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.radioNam = New System.Windows.Forms.RadioButton()
        Me.radioNu = New System.Windows.Forms.RadioButton()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbDataAdapter_nhanvien = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand = New System.Data.OleDb.OleDbCommand()
        Me.BacluongTableAdapter = New qlNhansu.DataSet1TableAdapters.BacluongTableAdapter()
        Me.NhanVienTableAdapter = New qlNhansu.DataSet1TableAdapters.NhanVienTableAdapter()
        Me.dateNgaysinh = New System.Windows.Forms.DateTimePicker()
        Me.PhongBanTableAdapter1 = New qlNhansu.DataSet1TableAdapters.PhongBanTableAdapter()
        Me.CongviecTableAdapter1 = New qlNhansu.DataSet1TableAdapters.CongviecTableAdapter()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter_congviec = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter_phongban = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter_bacluong = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand5 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand4 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.NhanVienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridNhanvien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1042, 37)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(423, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Danh Sách Nhân Viên"
        '
        'txtManv
        '
        Me.txtManv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NhanVienBindingSource, "MaNV_id", True))
        Me.txtManv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManv.Location = New System.Drawing.Point(225, 86)
        Me.txtManv.Name = "txtManv"
        Me.txtManv.Size = New System.Drawing.Size(167, 22)
        Me.txtManv.TabIndex = 1
        '
        'NhanVienBindingSource
        '
        Me.NhanVienBindingSource.DataMember = "NhanVien"
        Me.NhanVienBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtHoten
        '
        Me.txtHoten.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NhanVienBindingSource, "Ho_ten", True))
        Me.txtHoten.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoten.Location = New System.Drawing.Point(225, 113)
        Me.txtHoten.Name = "txtHoten"
        Me.txtHoten.Size = New System.Drawing.Size(167, 22)
        Me.txtHoten.TabIndex = 2
        '
        'txtDantoc
        '
        Me.txtDantoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NhanVienBindingSource, "Dan_toc", True))
        Me.txtDantoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDantoc.Location = New System.Drawing.Point(224, 201)
        Me.txtDantoc.Name = "txtDantoc"
        Me.txtDantoc.Size = New System.Drawing.Size(128, 22)
        Me.txtDantoc.TabIndex = 5
        '
        'txtDiachi
        '
        Me.txtDiachi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NhanVienBindingSource, "Que_Quan", True))
        Me.txtDiachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiachi.Location = New System.Drawing.Point(555, 84)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(165, 22)
        Me.txtDiachi.TabIndex = 6
        '
        'txtSdt
        '
        Me.txtSdt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NhanVienBindingSource, "SDT", True))
        Me.txtSdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSdt.Location = New System.Drawing.Point(555, 113)
        Me.txtSdt.Name = "txtSdt"
        Me.txtSdt.Size = New System.Drawing.Size(165, 22)
        Me.txtSdt.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Mã NV:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(169, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Họ tên:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(148, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Ngày sinh:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(161, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Giới tính:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(162, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Dân tộc:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(498, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Địa chỉ:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(511, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "SĐT:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(483, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Công việc:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(478, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Phòng ban:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(486, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Bậc lương"
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnThem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(822, 82)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(64, 28)
        Me.btnThem.TabIndex = 22
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSua.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(822, 116)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(64, 28)
        Me.btnSua.TabIndex = 23
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Red
        Me.btnXoa.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(822, 150)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(64, 28)
        Me.btnXoa.TabIndex = 25
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnThoat.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(822, 184)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(64, 28)
        Me.btnThoat.TabIndex = 26
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'cbCongviec
        '
        Me.cbCongviec.DataSource = Me.DataSet1
        Me.cbCongviec.DisplayMember = "Congviec.TenCV"
        Me.cbCongviec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCongviec.FormattingEnabled = True
        Me.cbCongviec.Location = New System.Drawing.Point(555, 141)
        Me.cbCongviec.Name = "cbCongviec"
        Me.cbCongviec.Size = New System.Drawing.Size(165, 24)
        Me.cbCongviec.TabIndex = 27
        Me.cbCongviec.ValueMember = "Congviec.MaCV_id"
        '
        'cbPhongban
        '
        Me.cbPhongban.DataSource = Me.DataSet1
        Me.cbPhongban.DisplayMember = "PhongBan.Ten_PhongBan"
        Me.cbPhongban.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPhongban.FormattingEnabled = True
        Me.cbPhongban.Location = New System.Drawing.Point(555, 171)
        Me.cbPhongban.Name = "cbPhongban"
        Me.cbPhongban.Size = New System.Drawing.Size(165, 24)
        Me.cbPhongban.TabIndex = 28
        Me.cbPhongban.ValueMember = "PhongBan.Ma_PhongBan_id"
        '
        'cbBacluong
        '
        Me.cbBacluong.DataSource = Me.DataSet1
        Me.cbBacluong.DisplayMember = "Bacluong.HeSo_Luong"
        Me.cbBacluong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBacluong.FormattingEnabled = True
        Me.cbBacluong.Location = New System.Drawing.Point(555, 201)
        Me.cbBacluong.Name = "cbBacluong"
        Me.cbBacluong.Size = New System.Drawing.Size(165, 24)
        Me.cbBacluong.TabIndex = 29
        Me.cbBacluong.ValueMember = "Bacluong.BacLuong_id"
        '
        'gridNhanvien
        '
        Me.gridNhanvien.AutoGenerateColumns = False
        Me.gridNhanvien.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridNhanvien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaNVidDataGridViewTextBoxColumn, Me.HotenDataGridViewTextBoxColumn, Me.DantocDataGridViewTextBoxColumn, Me.GioiTinhDataGridViewTextBoxColumn, Me.QueQuanDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.SDTDataGridViewTextBoxColumn, Me.MaCVfkDataGridViewTextBoxColumn, Me.MaPhongBanfkDataGridViewTextBoxColumn, Me.BacLuongfkDataGridViewTextBoxColumn})
        Me.gridNhanvien.DataSource = Me.NhanVienBindingSource
        Me.gridNhanvien.Location = New System.Drawing.Point(0, 266)
        Me.gridNhanvien.Name = "gridNhanvien"
        Me.gridNhanvien.RowTemplate.Height = 25
        Me.gridNhanvien.Size = New System.Drawing.Size(1043, 211)
        Me.gridNhanvien.TabIndex = 21
        '
        'MaNVidDataGridViewTextBoxColumn
        '
        Me.MaNVidDataGridViewTextBoxColumn.DataPropertyName = "MaNV_id"
        Me.MaNVidDataGridViewTextBoxColumn.HeaderText = "MaNV_id"
        Me.MaNVidDataGridViewTextBoxColumn.Name = "MaNVidDataGridViewTextBoxColumn"
        '
        'HotenDataGridViewTextBoxColumn
        '
        Me.HotenDataGridViewTextBoxColumn.DataPropertyName = "Ho_ten"
        Me.HotenDataGridViewTextBoxColumn.HeaderText = "Ho_ten"
        Me.HotenDataGridViewTextBoxColumn.Name = "HotenDataGridViewTextBoxColumn"
        '
        'DantocDataGridViewTextBoxColumn
        '
        Me.DantocDataGridViewTextBoxColumn.DataPropertyName = "Dan_toc"
        Me.DantocDataGridViewTextBoxColumn.HeaderText = "Dan_toc"
        Me.DantocDataGridViewTextBoxColumn.Name = "DantocDataGridViewTextBoxColumn"
        '
        'GioiTinhDataGridViewTextBoxColumn
        '
        Me.GioiTinhDataGridViewTextBoxColumn.DataPropertyName = "Gioi_Tinh"
        Me.GioiTinhDataGridViewTextBoxColumn.HeaderText = "Gioi_Tinh"
        Me.GioiTinhDataGridViewTextBoxColumn.Name = "GioiTinhDataGridViewTextBoxColumn"
        '
        'QueQuanDataGridViewTextBoxColumn
        '
        Me.QueQuanDataGridViewTextBoxColumn.DataPropertyName = "Que_Quan"
        Me.QueQuanDataGridViewTextBoxColumn.HeaderText = "Que_Quan"
        Me.QueQuanDataGridViewTextBoxColumn.Name = "QueQuanDataGridViewTextBoxColumn"
        '
        'NgaySinhDataGridViewTextBoxColumn
        '
        Me.NgaySinhDataGridViewTextBoxColumn.DataPropertyName = "Ngay_Sinh"
        Me.NgaySinhDataGridViewTextBoxColumn.HeaderText = "Ngay_Sinh"
        Me.NgaySinhDataGridViewTextBoxColumn.Name = "NgaySinhDataGridViewTextBoxColumn"
        '
        'SDTDataGridViewTextBoxColumn
        '
        Me.SDTDataGridViewTextBoxColumn.DataPropertyName = "SDT"
        Me.SDTDataGridViewTextBoxColumn.HeaderText = "SDT"
        Me.SDTDataGridViewTextBoxColumn.Name = "SDTDataGridViewTextBoxColumn"
        '
        'MaCVfkDataGridViewTextBoxColumn
        '
        Me.MaCVfkDataGridViewTextBoxColumn.DataPropertyName = "MaCV_fk"
        Me.MaCVfkDataGridViewTextBoxColumn.HeaderText = "MaCV_fk"
        Me.MaCVfkDataGridViewTextBoxColumn.Name = "MaCVfkDataGridViewTextBoxColumn"
        '
        'MaPhongBanfkDataGridViewTextBoxColumn
        '
        Me.MaPhongBanfkDataGridViewTextBoxColumn.DataPropertyName = "Ma_PhongBan_fk"
        Me.MaPhongBanfkDataGridViewTextBoxColumn.HeaderText = "Ma_PhongBan_fk"
        Me.MaPhongBanfkDataGridViewTextBoxColumn.Name = "MaPhongBanfkDataGridViewTextBoxColumn"
        '
        'BacLuongfkDataGridViewTextBoxColumn
        '
        Me.BacLuongfkDataGridViewTextBoxColumn.DataPropertyName = "BacLuong_fk"
        Me.BacLuongfkDataGridViewTextBoxColumn.HeaderText = "BacLuong_fk"
        Me.BacLuongfkDataGridViewTextBoxColumn.Name = "BacLuongfkDataGridViewTextBoxColumn"
        '
        'radioNam
        '
        Me.radioNam.AutoSize = True
        Me.radioNam.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.NhanVienBindingSource, "Gioi_Tinh", True))
        Me.radioNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioNam.Location = New System.Drawing.Point(225, 172)
        Me.radioNam.Name = "radioNam"
        Me.radioNam.Size = New System.Drawing.Size(55, 20)
        Me.radioNam.TabIndex = 32
        Me.radioNam.TabStop = True
        Me.radioNam.Text = "Nam"
        Me.radioNam.UseVisualStyleBackColor = True
        '
        'radioNu
        '
        Me.radioNu.AutoSize = True
        Me.radioNu.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.NhanVienBindingSource, "Gioi_Tinh", True))
        Me.radioNu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioNu.Location = New System.Drawing.Point(286, 172)
        Me.radioNu.Name = "radioNu"
        Me.radioNu.Size = New System.Drawing.Size(43, 20)
        Me.radioNu.TabIndex = 33
        Me.radioNu.TabStop = True
        Me.radioNu.Text = "Nữ"
        Me.radioNu.UseVisualStyleBackColor = True
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        NhanVien.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            NhanVien"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=THINKPADT460\SQLEXPRESS;Integrated Security=SSPI;" &
    "Initial Catalog=quanly_nhan_su"
        '
        'OleDbDataAdapter_nhanvien
        '
        Me.OleDbDataAdapter_nhanvien.DeleteCommand = Me.OleDbCommand1
        Me.OleDbDataAdapter_nhanvien.InsertCommand = Me.OleDbInsertCommand
        Me.OleDbDataAdapter_nhanvien.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter_nhanvien.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "NhanVien", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaNV_id", "MaNV_id"), New System.Data.Common.DataColumnMapping("Ho_ten", "Ho_ten"), New System.Data.Common.DataColumnMapping("Dan_toc", "Dan_toc"), New System.Data.Common.DataColumnMapping("Gioi_Tinh", "Gioi_Tinh"), New System.Data.Common.DataColumnMapping("Que_Quan", "Que_Quan"), New System.Data.Common.DataColumnMapping("Ngay_Sinh", "Ngay_Sinh"), New System.Data.Common.DataColumnMapping("SDT", "SDT"), New System.Data.Common.DataColumnMapping("MaCV_fk", "MaCV_fk"), New System.Data.Common.DataColumnMapping("Ma_PhongBan_fk", "Ma_PhongBan_fk"), New System.Data.Common.DataColumnMapping("BacLuong_fk", "BacLuong_fk")})})
        Me.OleDbDataAdapter_nhanvien.UpdateCommand = Me.OleDbUpdateCommand
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = resources.GetString("OleDbCommand1.CommandText")
        Me.OleDbCommand1.Connection = Me.OleDbConnection1
        Me.OleDbCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaNV_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaNV_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Ho_ten", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Ho_ten", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ho_ten", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ho_ten", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Dan_toc", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Dan_toc", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Dan_toc", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dan_toc", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Gioi_Tinh", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gioi_Tinh", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Gioi_Tinh", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gioi_Tinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Que_Quan", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Que_Quan", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Que_Quan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Que_Quan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Ngay_Sinh", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Ngay_Sinh", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ngay_Sinh", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ngay_Sinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SDT", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SDT", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SDT", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDT", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MaCV_fk", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaCV_fk", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaCV_fk", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaCV_fk", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Ma_PhongBan_fk", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Ma_PhongBan_fk", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ma_PhongBan_fk", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ma_PhongBan_fk", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_BacLuong_fk", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "BacLuong_fk", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_BacLuong_fk", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BacLuong_fk", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbInsertCommand
        '
        Me.OleDbInsertCommand.CommandText = "INSERT INTO [NhanVien] ([MaNV_id], [Ho_ten], [Dan_toc], [Gioi_Tinh], [Que_Quan], " &
    "[Ngay_Sinh], [SDT], [MaCV_fk], [Ma_PhongBan_fk], [BacLuong_fk]) VALUES (?, ?, ?," &
    " ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaNV_id", System.Data.OleDb.OleDbType.VarWChar, 0, "MaNV_id"), New System.Data.OleDb.OleDbParameter("Ho_ten", System.Data.OleDb.OleDbType.VarWChar, 0, "Ho_ten"), New System.Data.OleDb.OleDbParameter("Dan_toc", System.Data.OleDb.OleDbType.VarWChar, 0, "Dan_toc"), New System.Data.OleDb.OleDbParameter("Gioi_Tinh", System.Data.OleDb.OleDbType.VarWChar, 0, "Gioi_Tinh"), New System.Data.OleDb.OleDbParameter("Que_Quan", System.Data.OleDb.OleDbType.VarWChar, 0, "Que_Quan"), New System.Data.OleDb.OleDbParameter("Ngay_Sinh", System.Data.OleDb.OleDbType.VarWChar, 0, "Ngay_Sinh"), New System.Data.OleDb.OleDbParameter("SDT", System.Data.OleDb.OleDbType.VarWChar, 0, "SDT"), New System.Data.OleDb.OleDbParameter("MaCV_fk", System.Data.OleDb.OleDbType.VarWChar, 0, "MaCV_fk"), New System.Data.OleDb.OleDbParameter("Ma_PhongBan_fk", System.Data.OleDb.OleDbType.VarWChar, 0, "Ma_PhongBan_fk"), New System.Data.OleDb.OleDbParameter("BacLuong_fk", System.Data.OleDb.OleDbType.VarWChar, 0, "BacLuong_fk")})
        '
        'OleDbUpdateCommand
        '
        Me.OleDbUpdateCommand.CommandText = resources.GetString("OleDbUpdateCommand.CommandText")
        Me.OleDbUpdateCommand.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaNV_id", System.Data.OleDb.OleDbType.VarWChar, 0, "MaNV_id"), New System.Data.OleDb.OleDbParameter("Ho_ten", System.Data.OleDb.OleDbType.VarWChar, 0, "Ho_ten"), New System.Data.OleDb.OleDbParameter("Dan_toc", System.Data.OleDb.OleDbType.VarWChar, 0, "Dan_toc"), New System.Data.OleDb.OleDbParameter("Gioi_Tinh", System.Data.OleDb.OleDbType.VarWChar, 0, "Gioi_Tinh"), New System.Data.OleDb.OleDbParameter("Que_Quan", System.Data.OleDb.OleDbType.VarWChar, 0, "Que_Quan"), New System.Data.OleDb.OleDbParameter("Ngay_Sinh", System.Data.OleDb.OleDbType.VarWChar, 0, "Ngay_Sinh"), New System.Data.OleDb.OleDbParameter("SDT", System.Data.OleDb.OleDbType.VarWChar, 0, "SDT"), New System.Data.OleDb.OleDbParameter("MaCV_fk", System.Data.OleDb.OleDbType.VarWChar, 0, "MaCV_fk"), New System.Data.OleDb.OleDbParameter("Ma_PhongBan_fk", System.Data.OleDb.OleDbType.VarWChar, 0, "Ma_PhongBan_fk"), New System.Data.OleDb.OleDbParameter("BacLuong_fk", System.Data.OleDb.OleDbType.VarWChar, 0, "BacLuong_fk"), New System.Data.OleDb.OleDbParameter("Original_MaNV_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaNV_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Ho_ten", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Ho_ten", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ho_ten", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ho_ten", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Dan_toc", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Dan_toc", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Dan_toc", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dan_toc", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Gioi_Tinh", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Gioi_Tinh", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Gioi_Tinh", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gioi_Tinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Que_Quan", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Que_Quan", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Que_Quan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Que_Quan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Ngay_Sinh", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Ngay_Sinh", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ngay_Sinh", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ngay_Sinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SDT", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SDT", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SDT", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDT", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MaCV_fk", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaCV_fk", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaCV_fk", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaCV_fk", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Ma_PhongBan_fk", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Ma_PhongBan_fk", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ma_PhongBan_fk", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ma_PhongBan_fk", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_BacLuong_fk", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "BacLuong_fk", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_BacLuong_fk", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BacLuong_fk", System.Data.DataRowVersion.Original, Nothing)})
        '
        'BacluongTableAdapter
        '
        Me.BacluongTableAdapter.ClearBeforeFill = True
        '
        'NhanVienTableAdapter
        '
        Me.NhanVienTableAdapter.ClearBeforeFill = True
        '
        'dateNgaysinh
        '
        Me.dateNgaysinh.CustomFormat = "dd-MM-yyyy"
        Me.dateNgaysinh.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NhanVienBindingSource, "Ngay_Sinh", True))
        Me.dateNgaysinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateNgaysinh.Location = New System.Drawing.Point(224, 141)
        Me.dateNgaysinh.Name = "dateNgaysinh"
        Me.dateNgaysinh.Size = New System.Drawing.Size(167, 22)
        Me.dateNgaysinh.TabIndex = 34
        '
        'PhongBanTableAdapter1
        '
        Me.PhongBanTableAdapter1.ClearBeforeFill = True
        '
        'CongviecTableAdapter1
        '
        Me.CongviecTableAdapter1.ClearBeforeFill = True
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT        Congviec.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Congviec"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [Congviec] ([MaCV_id], [TenCV]) VALUES (?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaCV_id", System.Data.OleDb.OleDbType.VarWChar, 0, "MaCV_id"), New System.Data.OleDb.OleDbParameter("TenCV", System.Data.OleDb.OleDbType.VarWChar, 0, "TenCV")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [Congviec] SET [MaCV_id] = ?, [TenCV] = ? WHERE (([MaCV_id] = ?) AND ((? =" &
    " 1 AND [TenCV] IS NULL) OR ([TenCV] = ?)))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaCV_id", System.Data.OleDb.OleDbType.VarWChar, 0, "MaCV_id"), New System.Data.OleDb.OleDbParameter("TenCV", System.Data.OleDb.OleDbType.VarWChar, 0, "TenCV"), New System.Data.OleDb.OleDbParameter("Original_MaCV_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaCV_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TenCV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TenCV", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenCV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenCV", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [Congviec] WHERE (([MaCV_id] = ?) AND ((? = 1 AND [TenCV] IS NULL) OR" &
    " ([TenCV] = ?)))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaCV_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaCV_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TenCV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TenCV", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenCV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenCV", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter_congviec
        '
        Me.OleDbDataAdapter_congviec.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter_congviec.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter_congviec.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter_congviec.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Congviec", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaCV_id", "MaCV_id"), New System.Data.Common.DataColumnMapping("TenCV", "TenCV")})})
        Me.OleDbDataAdapter_congviec.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT        PhongBan.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            PhongBan"
        Me.OleDbSelectCommand3.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO [PhongBan] ([Ma_PhongBan_id], [Ten_PhongBan], [SDT_PhongBan], [Diachi" &
    "]) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Ma_PhongBan_id", System.Data.OleDb.OleDbType.VarWChar, 0, "Ma_PhongBan_id"), New System.Data.OleDb.OleDbParameter("Ten_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, "Ten_PhongBan"), New System.Data.OleDb.OleDbParameter("SDT_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, "SDT_PhongBan"), New System.Data.OleDb.OleDbParameter("Diachi", System.Data.OleDb.OleDbType.VarWChar, 0, "Diachi")})
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = resources.GetString("OleDbUpdateCommand2.CommandText")
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Ma_PhongBan_id", System.Data.OleDb.OleDbType.VarWChar, 0, "Ma_PhongBan_id"), New System.Data.OleDb.OleDbParameter("Ten_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, "Ten_PhongBan"), New System.Data.OleDb.OleDbParameter("SDT_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, "SDT_PhongBan"), New System.Data.OleDb.OleDbParameter("Diachi", System.Data.OleDb.OleDbType.VarWChar, 0, "Diachi"), New System.Data.OleDb.OleDbParameter("Original_Ma_PhongBan_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ma_PhongBan_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Ten_PhongBan", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Ten_PhongBan", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ten_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ten_PhongBan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SDT_PhongBan", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SDT_PhongBan", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SDT_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDT_PhongBan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Diachi", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Diachi", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Diachi", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diachi", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = resources.GetString("OleDbDeleteCommand2.CommandText")
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_Ma_PhongBan_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ma_PhongBan_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Ten_PhongBan", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Ten_PhongBan", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ten_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ten_PhongBan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SDT_PhongBan", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SDT_PhongBan", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SDT_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDT_PhongBan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Diachi", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Diachi", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Diachi", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diachi", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter_phongban
        '
        Me.OleDbDataAdapter_phongban.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter_phongban.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter_phongban.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapter_phongban.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PhongBan", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Ma_PhongBan_id", "Ma_PhongBan_id"), New System.Data.Common.DataColumnMapping("Ten_PhongBan", "Ten_PhongBan"), New System.Data.Common.DataColumnMapping("SDT_PhongBan", "SDT_PhongBan"), New System.Data.Common.DataColumnMapping("Diachi", "Diachi")})})
        Me.OleDbDataAdapter_phongban.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbSelectCommand4
        '
        Me.OleDbSelectCommand4.CommandText = "SELECT        Bacluong.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Bacluong"
        Me.OleDbSelectCommand4.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO [Bacluong] ([BacLuong_id], [Luongcb], [HeSo_Luong]) VALUES (?, ?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("BacLuong_id", System.Data.OleDb.OleDbType.VarWChar, 0, "BacLuong_id"), New System.Data.OleDb.OleDbParameter("Luongcb", System.Data.OleDb.OleDbType.VarWChar, 0, "Luongcb"), New System.Data.OleDb.OleDbParameter("HeSo_Luong", System.Data.OleDb.OleDbType.VarWChar, 0, "HeSo_Luong")})
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = resources.GetString("OleDbUpdateCommand3.CommandText")
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("BacLuong_id", System.Data.OleDb.OleDbType.VarWChar, 0, "BacLuong_id"), New System.Data.OleDb.OleDbParameter("Luongcb", System.Data.OleDb.OleDbType.VarWChar, 0, "Luongcb"), New System.Data.OleDb.OleDbParameter("HeSo_Luong", System.Data.OleDb.OleDbType.VarWChar, 0, "HeSo_Luong"), New System.Data.OleDb.OleDbParameter("Original_BacLuong_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BacLuong_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Luongcb", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Luongcb", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Luongcb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Luongcb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_HeSo_Luong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "HeSo_Luong", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_HeSo_Luong", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HeSo_Luong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM [Bacluong] WHERE (([BacLuong_id] = ?) AND ((? = 1 AND [Luongcb] IS NU" &
    "LL) OR ([Luongcb] = ?)) AND ((? = 1 AND [HeSo_Luong] IS NULL) OR ([HeSo_Luong] =" &
    " ?)))"
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_BacLuong_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BacLuong_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Luongcb", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Luongcb", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Luongcb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Luongcb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_HeSo_Luong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "HeSo_Luong", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_HeSo_Luong", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HeSo_Luong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter_bacluong
        '
        Me.OleDbDataAdapter_bacluong.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapter_bacluong.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapter_bacluong.SelectCommand = Me.OleDbSelectCommand4
        Me.OleDbDataAdapter_bacluong.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bacluong", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BacLuong_id", "BacLuong_id"), New System.Data.Common.DataColumnMapping("Luongcb", "Luongcb"), New System.Data.Common.DataColumnMapping("HeSo_Luong", "HeSo_Luong")})})
        Me.OleDbDataAdapter_bacluong.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand4
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand4
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand5
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand4
        '
        'nhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1043, 466)
        Me.Controls.Add(Me.dateNgaysinh)
        Me.Controls.Add(Me.radioNu)
        Me.Controls.Add(Me.radioNam)
        Me.Controls.Add(Me.cbBacluong)
        Me.Controls.Add(Me.cbPhongban)
        Me.Controls.Add(Me.cbCongviec)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.gridNhanvien)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSdt)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.txtDantoc)
        Me.Controls.Add(Me.txtHoten)
        Me.Controls.Add(Me.txtManv)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "nhanvien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "nhanvien"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NhanVienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridNhanvien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtManv As TextBox
    Friend WithEvents txtHoten As TextBox
    Friend WithEvents txtDantoc As TextBox
    Friend WithEvents txtDiachi As TextBox
    Friend WithEvents txtSdt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents cbCongviec As ComboBox
    Friend WithEvents cbPhongban As ComboBox
    Friend WithEvents cbBacluong As ComboBox
    Friend WithEvents Nu As CheckBox
    Friend WithEvents radioNam As RadioButton
    Friend WithEvents radioNu As RadioButton
    Friend WithEvents gridNhanvien As DataGridView
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter_nhanvien As OleDb.OleDbDataAdapter
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents BacluongTableAdapter As DataSet1TableAdapters.BacluongTableAdapter
    Friend WithEvents NhanVienBindingSource As BindingSource
    Friend WithEvents NhanVienTableAdapter As DataSet1TableAdapters.NhanVienTableAdapter
    Friend WithEvents dateNgaysinh As DateTimePicker
    Friend WithEvents PhongBanTableAdapter1 As DataSet1TableAdapters.PhongBanTableAdapter
    Friend WithEvents CongviecTableAdapter1 As DataSet1TableAdapters.CongviecTableAdapter
    Friend WithEvents OleDbCommand1 As OleDb.OleDbCommand
    Friend WithEvents MaNVidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HotenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DantocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GioiTinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QueQuanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SDTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaCVfkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaPhongBanfkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BacLuongfkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OleDbSelectCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter_congviec As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand3 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter_phongban As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand4 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter_bacluong As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand5 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand4 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand4 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand4 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbInsertCommand As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand As OleDb.OleDbCommand
End Class
