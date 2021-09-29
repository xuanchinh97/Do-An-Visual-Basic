<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class phongban
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(phongban))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMapb = New System.Windows.Forms.TextBox()
        Me.PhongBanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New qlNhansu.DataSet1()
        Me.txtTenpb = New System.Windows.Forms.TextBox()
        Me.txtSdt = New System.Windows.Forms.TextBox()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gridPhongban = New System.Windows.Forms.DataGridView()
        Me.MaPhongBanidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenPhongBanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDTPhongBanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiachiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.PhongBanTableAdapter = New qlNhansu.DataSet1TableAdapters.PhongBanTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.PhongBanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPhongban, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 40)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(268, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Danh Sách Phòng Ban"
        '
        'txtMapb
        '
        Me.txtMapb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhongBanBindingSource, "Ma_PhongBan_id", True))
        Me.txtMapb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMapb.Location = New System.Drawing.Point(105, 74)
        Me.txtMapb.Name = "txtMapb"
        Me.txtMapb.Size = New System.Drawing.Size(117, 22)
        Me.txtMapb.TabIndex = 1
        '
        'PhongBanBindingSource
        '
        Me.PhongBanBindingSource.DataMember = "PhongBan"
        Me.PhongBanBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTenpb
        '
        Me.txtTenpb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhongBanBindingSource, "Ten_PhongBan", True))
        Me.txtTenpb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenpb.Location = New System.Drawing.Point(105, 107)
        Me.txtTenpb.Name = "txtTenpb"
        Me.txtTenpb.Size = New System.Drawing.Size(117, 22)
        Me.txtTenpb.TabIndex = 2
        '
        'txtSdt
        '
        Me.txtSdt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhongBanBindingSource, "SDT_PhongBan", True))
        Me.txtSdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSdt.Location = New System.Drawing.Point(375, 77)
        Me.txtSdt.Name = "txtSdt"
        Me.txtSdt.Size = New System.Drawing.Size(115, 22)
        Me.txtSdt.TabIndex = 6
        '
        'txtDiachi
        '
        Me.txtDiachi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhongBanBindingSource, "Diachi", True))
        Me.txtDiachi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiachi.Location = New System.Drawing.Point(375, 107)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(115, 22)
        Me.txtDiachi.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Mã PB:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tên PB:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(313, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "SĐT:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(313, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Địa chỉ:"
        '
        'gridPhongban
        '
        Me.gridPhongban.AutoGenerateColumns = False
        Me.gridPhongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPhongban.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaPhongBanidDataGridViewTextBoxColumn, Me.TenPhongBanDataGridViewTextBoxColumn, Me.SDTPhongBanDataGridViewTextBoxColumn, Me.DiachiDataGridViewTextBoxColumn})
        Me.gridPhongban.DataSource = Me.PhongBanBindingSource
        Me.gridPhongban.Location = New System.Drawing.Point(0, 257)
        Me.gridPhongban.Name = "gridPhongban"
        Me.gridPhongban.RowTemplate.Height = 25
        Me.gridPhongban.Size = New System.Drawing.Size(710, 211)
        Me.gridPhongban.TabIndex = 21
        '
        'MaPhongBanidDataGridViewTextBoxColumn
        '
        Me.MaPhongBanidDataGridViewTextBoxColumn.DataPropertyName = "Ma_PhongBan_id"
        Me.MaPhongBanidDataGridViewTextBoxColumn.HeaderText = "Ma_PhongBan_id"
        Me.MaPhongBanidDataGridViewTextBoxColumn.Name = "MaPhongBanidDataGridViewTextBoxColumn"
        '
        'TenPhongBanDataGridViewTextBoxColumn
        '
        Me.TenPhongBanDataGridViewTextBoxColumn.DataPropertyName = "Ten_PhongBan"
        Me.TenPhongBanDataGridViewTextBoxColumn.HeaderText = "Ten_PhongBan"
        Me.TenPhongBanDataGridViewTextBoxColumn.Name = "TenPhongBanDataGridViewTextBoxColumn"
        '
        'SDTPhongBanDataGridViewTextBoxColumn
        '
        Me.SDTPhongBanDataGridViewTextBoxColumn.DataPropertyName = "SDT_PhongBan"
        Me.SDTPhongBanDataGridViewTextBoxColumn.HeaderText = "SDT_PhongBan"
        Me.SDTPhongBanDataGridViewTextBoxColumn.Name = "SDTPhongBanDataGridViewTextBoxColumn"
        '
        'DiachiDataGridViewTextBoxColumn
        '
        Me.DiachiDataGridViewTextBoxColumn.DataPropertyName = "Diachi"
        Me.DiachiDataGridViewTextBoxColumn.HeaderText = "Diachi"
        Me.DiachiDataGridViewTextBoxColumn.Name = "DiachiDataGridViewTextBoxColumn"
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(597, 77)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(64, 27)
        Me.btnThem.TabIndex = 22
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(597, 110)
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
        Me.btnXoa.Location = New System.Drawing.Point(597, 142)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(64, 27)
        Me.btnXoa.TabIndex = 25
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(597, 175)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(64, 27)
        Me.btnThoat.TabIndex = 26
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        PhongBan.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            PhongBan"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=THINKPADT460\SQLEXPRESS;Integrated Security=SSPI;" &
    "Initial Catalog=quanly_nhan_su"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [PhongBan] ([Ma_PhongBan_id], [Ten_PhongBan], [SDT_PhongBan], [Diachi" &
    "]) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Ma_PhongBan_id", System.Data.OleDb.OleDbType.VarWChar, 0, "Ma_PhongBan_id"), New System.Data.OleDb.OleDbParameter("Ten_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, "Ten_PhongBan"), New System.Data.OleDb.OleDbParameter("SDT_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, "SDT_PhongBan"), New System.Data.OleDb.OleDbParameter("Diachi", System.Data.OleDb.OleDbType.VarWChar, 0, "Diachi")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Ma_PhongBan_id", System.Data.OleDb.OleDbType.VarWChar, 0, "Ma_PhongBan_id"), New System.Data.OleDb.OleDbParameter("Ten_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, "Ten_PhongBan"), New System.Data.OleDb.OleDbParameter("SDT_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, "SDT_PhongBan"), New System.Data.OleDb.OleDbParameter("Diachi", System.Data.OleDb.OleDbType.VarWChar, 0, "Diachi"), New System.Data.OleDb.OleDbParameter("Original_Ma_PhongBan_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ma_PhongBan_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Ten_PhongBan", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Ten_PhongBan", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ten_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ten_PhongBan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SDT_PhongBan", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SDT_PhongBan", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SDT_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDT_PhongBan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Diachi", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Diachi", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Diachi", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diachi", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_Ma_PhongBan_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ma_PhongBan_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Ten_PhongBan", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Ten_PhongBan", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Ten_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ten_PhongBan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_SDT_PhongBan", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SDT_PhongBan", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SDT_PhongBan", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SDT_PhongBan", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Diachi", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Diachi", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Diachi", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Diachi", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PhongBan", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Ma_PhongBan_id", "Ma_PhongBan_id"), New System.Data.Common.DataColumnMapping("Ten_PhongBan", "Ten_PhongBan"), New System.Data.Common.DataColumnMapping("SDT_PhongBan", "SDT_PhongBan"), New System.Data.Common.DataColumnMapping("Diachi", "Diachi")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'PhongBanTableAdapter
        '
        Me.PhongBanTableAdapter.ClearBeforeFill = True
        '
        'phongban
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(712, 466)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.gridPhongban)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.txtSdt)
        Me.Controls.Add(Me.txtTenpb)
        Me.Controls.Add(Me.txtMapb)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "phongban"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "phongban"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PhongBanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPhongban, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMapb As TextBox
    Friend WithEvents txtTenpb As TextBox
    Friend WithEvents txtSdt As TextBox
    Friend WithEvents txtDiachi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents gridPhongban As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents PhongBanBindingSource As BindingSource
    Friend WithEvents PhongBanTableAdapter As DataSet1TableAdapters.PhongBanTableAdapter
    Friend WithEvents MaPhongBanidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenPhongBanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SDTPhongBanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiachiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
