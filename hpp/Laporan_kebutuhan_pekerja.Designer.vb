<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_kebutuhan_pekerja
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataKebutuhanPekerja = New System.Windows.Forms.DataGridView
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pekerja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.waktu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.Nama_Produk = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Jumlah_produksi = New System.Windows.Forms.Label
        Me.Id_produk = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataKebutuhanPekerja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(179, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jumlah Pekerja Yang Diperlukan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(-60, 515)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(845, 50)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operasi"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(579, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ubah Jumlah Produk"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(702, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataKebutuhanPekerja
        '
        Me.DataKebutuhanPekerja.AllowUserToAddRows = False
        Me.DataKebutuhanPekerja.AllowUserToDeleteRows = False
        Me.DataKebutuhanPekerja.AllowUserToResizeColumns = False
        Me.DataKebutuhanPekerja.AllowUserToResizeRows = False
        Me.DataKebutuhanPekerja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataKebutuhanPekerja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataKebutuhanPekerja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataKebutuhanPekerja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.pekerja, Me.waktu, Me.jumlah})
        Me.DataKebutuhanPekerja.Location = New System.Drawing.Point(89, 147)
        Me.DataKebutuhanPekerja.Name = "DataKebutuhanPekerja"
        Me.DataKebutuhanPekerja.ReadOnly = True
        Me.DataKebutuhanPekerja.RowHeadersVisible = False
        Me.DataKebutuhanPekerja.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataKebutuhanPekerja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataKebutuhanPekerja.ShowCellToolTips = False
        Me.DataKebutuhanPekerja.Size = New System.Drawing.Size(607, 251)
        Me.DataKebutuhanPekerja.TabIndex = 2
        '
        'nomor
        '
        Me.nomor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.nomor.DataPropertyName = "nomor"
        Me.nomor.FillWeight = 20.0!
        Me.nomor.HeaderText = "No"
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        Me.nomor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nomor.Width = 55
        '
        'pekerja
        '
        Me.pekerja.DataPropertyName = "nama_sk"
        Me.pekerja.HeaderText = "Stasiun Kerja"
        Me.pekerja.Name = "pekerja"
        Me.pekerja.ReadOnly = True
        '
        'waktu
        '
        Me.waktu.DataPropertyName = "waktu"
        Me.waktu.HeaderText = "Waktu / Produk"
        Me.waktu.Name = "waktu"
        Me.waktu.ReadOnly = True
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah Pekerja"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Produk"
        '
        'Nama_Produk
        '
        Me.Nama_Produk.AutoSize = True
        Me.Nama_Produk.Location = New System.Drawing.Point(461, 86)
        Me.Nama_Produk.Name = "Nama_Produk"
        Me.Nama_Produk.Size = New System.Drawing.Size(0, 13)
        Me.Nama_Produk.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(323, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Jumlah Produksi"
        '
        'Jumlah_produksi
        '
        Me.Jumlah_produksi.AutoSize = True
        Me.Jumlah_produksi.Location = New System.Drawing.Point(461, 103)
        Me.Jumlah_produksi.Name = "Jumlah_produksi"
        Me.Jumlah_produksi.Size = New System.Drawing.Size(0, 13)
        Me.Jumlah_produksi.TabIndex = 6
        '
        'Id_produk
        '
        Me.Id_produk.AutoSize = True
        Me.Id_produk.Location = New System.Drawing.Point(184, 86)
        Me.Id_produk.Name = "Id_produk"
        Me.Id_produk.Size = New System.Drawing.Size(0, 13)
        Me.Id_produk.TabIndex = 7
        Me.Id_produk.Visible = False
        '
        'Laporan_kebutuhan_pekerja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Id_produk)
        Me.Controls.Add(Me.Jumlah_produksi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Nama_Produk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataKebutuhanPekerja)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Laporan_kebutuhan_pekerja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Kebutuhan Pekerja"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataKebutuhanPekerja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataKebutuhanPekerja As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nama_Produk As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Jumlah_produksi As System.Windows.Forms.Label
    Friend WithEvents Id_produk As System.Windows.Forms.Label
    Friend WithEvents nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pekerja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents waktu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
