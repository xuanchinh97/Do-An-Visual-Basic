<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class congviec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(congviec))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMacv = New System.Windows.Forms.TextBox()
        Me.CongviecBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New qlNhansu.DataSet1()
        Me.txtTencv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gridCongviec = New System.Windows.Forms.DataGridView()
        Me.MaCVidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenCVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.CongviecTableAdapter = New qlNhansu.DataSet1TableAdapters.CongviecTableAdapter()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.CongviecBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCongviec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 37)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(279, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Danh Sách Công Việc"
        '
        'txtMacv
        '
        Me.txtMacv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CongviecBindingSource, "MaCV_id", True))
        Me.txtMacv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMacv.Location = New System.Drawing.Point(114, 83)
        Me.txtMacv.Name = "txtMacv"
        Me.txtMacv.Size = New System.Drawing.Size(89, 22)
        Me.txtMacv.TabIndex = 1
        '
        'CongviecBindingSource
        '
        Me.CongviecBindingSource.DataMember = "Congviec"
        Me.CongviecBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTencv
        '
        Me.txtTencv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CongviecBindingSource, "TenCV", True))
        Me.txtTencv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTencv.Location = New System.Drawing.Point(114, 116)
        Me.txtTencv.Name = "txtTencv"
        Me.txtTencv.Size = New System.Drawing.Size(197, 22)
        Me.txtTencv.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Mã CV:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tên CV:"
        '
        'gridCongviec
        '
        Me.gridCongviec.AutoGenerateColumns = False
        Me.gridCongviec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCongviec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaCVidDataGridViewTextBoxColumn, Me.TenCVDataGridViewTextBoxColumn})
        Me.gridCongviec.DataSource = Me.CongviecBindingSource
        Me.gridCongviec.Location = New System.Drawing.Point(0, 257)
        Me.gridCongviec.Name = "gridCongviec"
        Me.gridCongviec.RowTemplate.Height = 25
        Me.gridCongviec.Size = New System.Drawing.Size(710, 211)
        Me.gridCongviec.TabIndex = 21
        '
        'MaCVidDataGridViewTextBoxColumn
        '
        Me.MaCVidDataGridViewTextBoxColumn.DataPropertyName = "MaCV_id"
        Me.MaCVidDataGridViewTextBoxColumn.HeaderText = "MaCV_id"
        Me.MaCVidDataGridViewTextBoxColumn.Name = "MaCVidDataGridViewTextBoxColumn"
        '
        'TenCVDataGridViewTextBoxColumn
        '
        Me.TenCVDataGridViewTextBoxColumn.DataPropertyName = "TenCV"
        Me.TenCVDataGridViewTextBoxColumn.HeaderText = "TenCV"
        Me.TenCVDataGridViewTextBoxColumn.Name = "TenCVDataGridViewTextBoxColumn"
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(576, 76)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(74, 29)
        Me.btnThem.TabIndex = 22
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(575, 114)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 29)
        Me.btnSua.TabIndex = 23
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Red
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(575, 149)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(74, 32)
        Me.btnXoa.TabIndex = 25
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(576, 187)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(74, 27)
        Me.btnThoat.TabIndex = 26
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'CongviecTableAdapter
        '
        Me.CongviecTableAdapter.ClearBeforeFill = True
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        Congviec.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Congviec"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=THINKPADT460\SQLEXPRESS;Integrated Security=SSPI;" &
    "Initial Catalog=quanly_nhan_su"
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
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Congviec", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaCV_id", "MaCV_id"), New System.Data.Common.DataColumnMapping("TenCV", "TenCV")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'congviec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(713, 466)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.gridCongviec)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTencv)
        Me.Controls.Add(Me.txtMacv)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "congviec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "congviec"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CongviecBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCongviec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMacv As TextBox
    Friend WithEvents txtTencv As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents gridCongviec As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CongviecBindingSource As BindingSource
    Friend WithEvents CongviecTableAdapter As DataSet1TableAdapters.CongviecTableAdapter
    Friend WithEvents MaCVidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenCVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
End Class
