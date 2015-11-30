<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail_sk
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
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button_Ubah = New System.Windows.Forms.Button
        Me.Button_Detail_Kebutuhan = New System.Windows.Forms.Button
        Me.Data_Sk_Produk = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Id_produk = New System.Windows.Forms.Label
        Me.Nama_produk = New System.Windows.Forms.Label
        Me.id_sk_produk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nama_sk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.waktu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.jumlah_pekerja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.upah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.Data_Sk_Produk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(258, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Stasiun Kerja"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button_Ubah)
        Me.GroupBox1.Controls.Add(Me.Button_Detail_Kebutuhan)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 517)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 46)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operasi"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(696, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Kembali"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button_Ubah
        '
        Me.Button_Ubah.Location = New System.Drawing.Point(131, 17)
        Me.Button_Ubah.Name = "Button_Ubah"
        Me.Button_Ubah.Size = New System.Drawing.Size(75, 23)
        Me.Button_Ubah.TabIndex = 1
        Me.Button_Ubah.Text = "Ubah"
        Me.Button_Ubah.UseVisualStyleBackColor = True
        '
        'Button_Detail_Kebutuhan
        '
        Me.Button_Detail_Kebutuhan.Location = New System.Drawing.Point(11, 17)
        Me.Button_Detail_Kebutuhan.Name = "Button_Detail_Kebutuhan"
        Me.Button_Detail_Kebutuhan.Size = New System.Drawing.Size(114, 23)
        Me.Button_Detail_Kebutuhan.TabIndex = 0
        Me.Button_Detail_Kebutuhan.Text = "Detail Kebutuhan"
        Me.Button_Detail_Kebutuhan.UseVisualStyleBackColor = True
        '
        'Data_Sk_Produk
        '
        Me.Data_Sk_Produk.AllowUserToAddRows = False
        Me.Data_Sk_Produk.AllowUserToDeleteRows = False
        Me.Data_Sk_Produk.AllowUserToResizeColumns = False
        Me.Data_Sk_Produk.AllowUserToResizeRows = False
        Me.Data_Sk_Produk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Data_Sk_Produk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Data_Sk_Produk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_Sk_Produk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_sk_produk, Me.nomor, Me.nama_sk, Me.waktu, Me.jumlah_pekerja, Me.upah})
        Me.Data_Sk_Produk.Location = New System.Drawing.Point(12, 127)
        Me.Data_Sk_Produk.Name = "Data_Sk_Produk"
        Me.Data_Sk_Produk.ReadOnly = True
        Me.Data_Sk_Produk.RowHeadersVisible = False
        Me.Data_Sk_Produk.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Data_Sk_Produk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Data_Sk_Produk.Size = New System.Drawing.Size(760, 384)
        Me.Data_Sk_Produk.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(259, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Produk :"
        '
        'Id_produk
        '
        Me.Id_produk.AutoSize = True
        Me.Id_produk.Location = New System.Drawing.Point(186, 73)
        Me.Id_produk.Name = "Id_produk"
        Me.Id_produk.Size = New System.Drawing.Size(39, 13)
        Me.Id_produk.TabIndex = 8
        Me.Id_produk.Text = "Label3"
        Me.Id_produk.Visible = False
        '
        'Nama_produk
        '
        Me.Nama_produk.AutoSize = True
        Me.Nama_produk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Nama_produk.Location = New System.Drawing.Point(378, 73)
        Me.Nama_produk.Name = "Nama_produk"
        Me.Nama_produk.Size = New System.Drawing.Size(0, 20)
        Me.Nama_produk.TabIndex = 9
        '
        'id_sk_produk
        '
        Me.id_sk_produk.DataPropertyName = "id_sk_produk"
        Me.id_sk_produk.HeaderText = "id_sk_produk"
        Me.id_sk_produk.Name = "id_sk_produk"
        Me.id_sk_produk.ReadOnly = True
        Me.id_sk_produk.Visible = False
        '
        'nomor
        '
        Me.nomor.DataPropertyName = "nomor"
        Me.nomor.FillWeight = 38.07107!
        Me.nomor.HeaderText = "No"
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        '
        'nama_sk
        '
        Me.nama_sk.DataPropertyName = "nama_sk"
        Me.nama_sk.FillWeight = 130.9645!
        Me.nama_sk.HeaderText = "Stasiun Kerja"
        Me.nama_sk.Name = "nama_sk"
        Me.nama_sk.ReadOnly = True
        '
        'waktu
        '
        Me.waktu.DataPropertyName = "waktu"
        Me.waktu.FillWeight = 130.9645!
        Me.waktu.HeaderText = "Waktu (menit)"
        Me.waktu.Name = "waktu"
        Me.waktu.ReadOnly = True
        '
        'jumlah_pekerja
        '
        Me.jumlah_pekerja.DataPropertyName = "jumlah_pekerja"
        Me.jumlah_pekerja.HeaderText = "Jumlah Pekerja (Orang)"
        Me.jumlah_pekerja.Name = "jumlah_pekerja"
        Me.jumlah_pekerja.ReadOnly = True
        '
        'upah
        '
        Me.upah.DataPropertyName = "upah"
        Me.upah.HeaderText = "Upah (Rp)"
        Me.upah.Name = "upah"
        Me.upah.ReadOnly = True
        '
        'Detail_sk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Nama_produk)
        Me.Controls.Add(Me.Id_produk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Data_Sk_Produk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Detail_sk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Stasiun Kerja"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Data_Sk_Produk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button_Ubah As System.Windows.Forms.Button
    Friend WithEvents Button_Detail_Kebutuhan As System.Windows.Forms.Button
    Friend WithEvents Data_Sk_Produk As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Id_produk As System.Windows.Forms.Label
    Friend WithEvents Nama_produk As System.Windows.Forms.Label
    Friend WithEvents id_sk_produk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_sk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents waktu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah_pekerja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents upah As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
