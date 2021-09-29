<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.txtTendangnhap = New System.Windows.Forms.TextBox()
        Me.txtMatkhau = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDangnhap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTendangnhap
        '
        Me.txtTendangnhap.Location = New System.Drawing.Point(215, 105)
        Me.txtTendangnhap.Name = "txtTendangnhap"
        Me.txtTendangnhap.Size = New System.Drawing.Size(145, 20)
        Me.txtTendangnhap.TabIndex = 0
        '
        'txtMatkhau
        '
        Me.txtMatkhau.Location = New System.Drawing.Point(215, 146)
        Me.txtMatkhau.Name = "txtMatkhau"
        Me.txtMatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatkhau.Size = New System.Drawing.Size(145, 20)
        Me.txtMatkhau.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tên đăng nhập:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mật khẩu:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ĐĂNG NHẬP"
        '
        'btnDangnhap
        '
        Me.btnDangnhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDangnhap.Location = New System.Drawing.Point(215, 186)
        Me.btnDangnhap.Name = "btnDangnhap"
        Me.btnDangnhap.Size = New System.Drawing.Size(82, 23)
        Me.btnDangnhap.TabIndex = 5
        Me.btnDangnhap.Text = "Đăng nhập"
        Me.btnDangnhap.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(513, 252)
        Me.Controls.Add(Me.btnDangnhap)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMatkhau)
        Me.Controls.Add(Me.txtTendangnhap)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTendangnhap As TextBox
    Friend WithEvents txtMatkhau As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDangnhap As Button
End Class
