<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bacluong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bacluong))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMabl = New System.Windows.Forms.TextBox()
        Me.BacluongBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New qlNhansu.DataSet1()
        Me.txtLuongcb = New System.Windows.Forms.TextBox()
        Me.txtHesl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gridBacluong = New System.Windows.Forms.DataGridView()
        Me.BacLuongidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LuongcbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeSoLuongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.BacluongTableAdapter = New qlNhansu.DataSet1TableAdapters.BacluongTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.BacluongBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBacluong, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(266, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Danh Sách Bậc Lương"
        '
        'txtMabl
        '
        Me.txtMabl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BacluongBindingSource, "BacLuong_id", True))
        Me.txtMabl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMabl.Location = New System.Drawing.Point(116, 89)
        Me.txtMabl.Name = "txtMabl"
        Me.txtMabl.Size = New System.Drawing.Size(117, 22)
        Me.txtMabl.TabIndex = 1
        '
        'BacluongBindingSource
        '
        Me.BacluongBindingSource.DataMember = "Bacluong"
        Me.BacluongBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtLuongcb
        '
        Me.txtLuongcb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BacluongBindingSource, "Luongcb", True))
        Me.txtLuongcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLuongcb.Location = New System.Drawing.Point(116, 117)
        Me.txtLuongcb.Name = "txtLuongcb"
        Me.txtLuongcb.Size = New System.Drawing.Size(117, 22)
        Me.txtLuongcb.TabIndex = 2
        '
        'txtHesl
        '
        Me.txtHesl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BacluongBindingSource, "HeSo_Luong", True))
        Me.txtHesl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHesl.Location = New System.Drawing.Point(116, 145)
        Me.txtHesl.Name = "txtHesl"
        Me.txtHesl.Size = New System.Drawing.Size(117, 22)
        Me.txtHesl.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Mã BL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Lương CB:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Hệ SL:"
        '
        'gridBacluong
        '
        Me.gridBacluong.AutoGenerateColumns = False
        Me.gridBacluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridBacluong.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BacLuongidDataGridViewTextBoxColumn, Me.LuongcbDataGridViewTextBoxColumn, Me.HeSoLuongDataGridViewTextBoxColumn})
        Me.gridBacluong.DataSource = Me.BacluongBindingSource
        Me.gridBacluong.Location = New System.Drawing.Point(0, 257)
        Me.gridBacluong.Name = "gridBacluong"
        Me.gridBacluong.RowTemplate.Height = 25
        Me.gridBacluong.Size = New System.Drawing.Size(710, 211)
        Me.gridBacluong.TabIndex = 21
        '
        'BacLuongidDataGridViewTextBoxColumn
        '
        Me.BacLuongidDataGridViewTextBoxColumn.DataPropertyName = "BacLuong_id"
        Me.BacLuongidDataGridViewTextBoxColumn.HeaderText = "BacLuong_id"
        Me.BacLuongidDataGridViewTextBoxColumn.Name = "BacLuongidDataGridViewTextBoxColumn"
        '
        'LuongcbDataGridViewTextBoxColumn
        '
        Me.LuongcbDataGridViewTextBoxColumn.DataPropertyName = "Luongcb"
        Me.LuongcbDataGridViewTextBoxColumn.HeaderText = "Luongcb"
        Me.LuongcbDataGridViewTextBoxColumn.Name = "LuongcbDataGridViewTextBoxColumn"
        '
        'HeSoLuongDataGridViewTextBoxColumn
        '
        Me.HeSoLuongDataGridViewTextBoxColumn.DataPropertyName = "HeSo_Luong"
        Me.HeSoLuongDataGridViewTextBoxColumn.HeaderText = "HeSo_Luong"
        Me.HeSoLuongDataGridViewTextBoxColumn.Name = "HeSoLuongDataGridViewTextBoxColumn"
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(551, 73)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(64, 28)
        Me.btnThem.TabIndex = 22
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(551, 107)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(64, 28)
        Me.btnSua.TabIndex = 23
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.Red
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(551, 141)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(64, 29)
        Me.btnXoa.TabIndex = 25
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(551, 176)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(64, 27)
        Me.btnThoat.TabIndex = 26
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        Bacluong.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Bacluong"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=THINKPADT460\SQLEXPRESS;Integrated Security=SSPI;" &
    "Initial Catalog=quanly_nhan_su"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [Bacluong] ([BacLuong_id], [Luongcb], [HeSo_Luong]) VALUES (?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("BacLuong_id", System.Data.OleDb.OleDbType.VarWChar, 0, "BacLuong_id"), New System.Data.OleDb.OleDbParameter("Luongcb", System.Data.OleDb.OleDbType.VarWChar, 0, "Luongcb"), New System.Data.OleDb.OleDbParameter("HeSo_Luong", System.Data.OleDb.OleDbType.VarWChar, 0, "HeSo_Luong")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("BacLuong_id", System.Data.OleDb.OleDbType.VarWChar, 0, "BacLuong_id"), New System.Data.OleDb.OleDbParameter("Luongcb", System.Data.OleDb.OleDbType.VarWChar, 0, "Luongcb"), New System.Data.OleDb.OleDbParameter("HeSo_Luong", System.Data.OleDb.OleDbType.VarWChar, 0, "HeSo_Luong"), New System.Data.OleDb.OleDbParameter("Original_BacLuong_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BacLuong_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Luongcb", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Luongcb", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Luongcb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Luongcb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_HeSo_Luong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "HeSo_Luong", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_HeSo_Luong", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HeSo_Luong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [Bacluong] WHERE (([BacLuong_id] = ?) AND ((? = 1 AND [Luongcb] IS NU" &
    "LL) OR ([Luongcb] = ?)) AND ((? = 1 AND [HeSo_Luong] IS NULL) OR ([HeSo_Luong] =" &
    " ?)))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_BacLuong_id", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "BacLuong_id", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Luongcb", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Luongcb", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Luongcb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Luongcb", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_HeSo_Luong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "HeSo_Luong", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_HeSo_Luong", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HeSo_Luong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bacluong", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BacLuong_id", "BacLuong_id"), New System.Data.Common.DataColumnMapping("Luongcb", "Luongcb"), New System.Data.Common.DataColumnMapping("HeSo_Luong", "HeSo_Luong")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'BacluongTableAdapter
        '
        Me.BacluongTableAdapter.ClearBeforeFill = True
        '
        'bacluong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(712, 466)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.gridBacluong)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHesl)
        Me.Controls.Add(Me.txtLuongcb)
        Me.Controls.Add(Me.txtMabl)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "bacluong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bacluong"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BacluongBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBacluong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMabl As TextBox
    Friend WithEvents txtLuongcb As TextBox
    Friend WithEvents txtHesl As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gridBacluong As DataGridView
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
    Friend WithEvents BacluongBindingSource As BindingSource
    Friend WithEvents BacluongTableAdapter As DataSet1TableAdapters.BacluongTableAdapter
    Friend WithEvents BacLuongidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LuongcbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeSoLuongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
