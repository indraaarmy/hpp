<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kebutuhan_produk
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataKebutuhanProduk = New System.Windows.Forms.DataGridView
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Kebutuhan_Produk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nama_Kebutuhan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.jenis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.listrik = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.watt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataKebutuhanProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(272, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kebutuhan Produk"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 516)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(781, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operasi"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(619, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Selanjutnya"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(700, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Batal"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(90, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataKebutuhanProduk
        '
        Me.DataKebutuhanProduk.AllowUserToAddRows = False
        Me.DataKebutuhanProduk.AllowUserToDeleteRows = False
        Me.DataKebutuhanProduk.AllowUserToResizeColumns = False
        Me.DataKebutuhanProduk.AllowUserToResizeRows = False
        Me.DataKebutuhanProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataKebutuhanProduk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataKebutuhanProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataKebutuhanProduk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.Id_Kebutuhan_Produk, Me.Nama_Kebutuhan, Me.jenis, Me.listrik, Me.watt})
        Me.DataKebutuhanProduk.Location = New System.Drawing.Point(3, 90)
        Me.DataKebutuhanProduk.Name = "DataKebutuhanProduk"
        Me.DataKebutuhanProduk.ReadOnly = True
        Me.DataKebutuhanProduk.RowHeadersVisible = False
        Me.DataKebutuhanProduk.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataKebutuhanProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataKebutuhanProduk.ShowCellToolTips = False
        Me.DataKebutuhanProduk.Size = New System.Drawing.Size(775, 420)
        Me.DataKebutuhanProduk.TabIndex = 2
        '
        'nomor
        '
        Me.nomor.DataPropertyName = "nomor"
        Me.nomor.FillWeight = 30.45685!
        Me.nomor.HeaderText = "No"
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        '
        'Id_Kebutuhan_Produk
        '
        Me.Id_Kebutuhan_Produk.DataPropertyName = "id_kebutuhan_produk"
        Me.Id_Kebutuhan_Produk.FillWeight = 123.181!
        Me.Id_Kebutuhan_Produk.HeaderText = "ID Kebutuhan Produk"
        Me.Id_Kebutuhan_Produk.Name = "Id_Kebutuhan_Produk"
        Me.Id_Kebutuhan_Produk.ReadOnly = True
        Me.Id_Kebutuhan_Produk.Visible = False
        '
        'Nama_Kebutuhan
        '
        Me.Nama_Kebutuhan.DataPropertyName = "nama_kebutuhan"
        Me.Nama_Kebutuhan.FillWeight = 123.181!
        Me.Nama_Kebutuhan.HeaderText = "Kebutuhan"
        Me.Nama_Kebutuhan.Name = "Nama_Kebutuhan"
        Me.Nama_Kebutuhan.ReadOnly = True
        '
        'jenis
        '
        Me.jenis.DataPropertyName = "jenis"
        Me.jenis.HeaderText = "Jenis"
        Me.jenis.Name = "jenis"
        Me.jenis.ReadOnly = True
        '
        'listrik
        '
        Me.listrik.DataPropertyName = "listrik"
        Me.listrik.HeaderText = "Elektronik"
        Me.listrik.Name = "listrik"
        Me.listrik.ReadOnly = True
        '
        'watt
        '
        Me.watt.DataPropertyName = "watt"
        Me.watt.HeaderText = "Watt"
        Me.watt.Name = "watt"
        Me.watt.ReadOnly = True
        '
        'Kebutuhan_produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataKebutuhanProduk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Kebutuhan_produk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kebutuhan Produk"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataKebutuhanProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataKebutuhanProduk As System.Windows.Forms.DataGridView
    Friend WithEvents nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Kebutuhan_Produk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama_Kebutuhan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents listrik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents watt As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
