<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kebutuhan_sk
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Data_sk_kebutuhan = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Nama_produk = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Nama_sk = New System.Windows.Forms.Label
        Me.Id_produk = New System.Windows.Forms.Label
        Me.Id_sk_produk = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.no_sk = New System.Windows.Forms.Label
        Me.id_kebutuhan_sk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nama_kebutuhan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.Data_sk_kebutuhan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(198, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Kebutuhan Stasiun Kerja"
        '
        'Data_sk_kebutuhan
        '
        Me.Data_sk_kebutuhan.AllowUserToAddRows = False
        Me.Data_sk_kebutuhan.AllowUserToDeleteRows = False
        Me.Data_sk_kebutuhan.AllowUserToResizeColumns = False
        Me.Data_sk_kebutuhan.AllowUserToResizeRows = False
        Me.Data_sk_kebutuhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Data_sk_kebutuhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_sk_kebutuhan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_kebutuhan_sk, Me.nomor, Me.nama_kebutuhan, Me.jumlah})
        Me.Data_sk_kebutuhan.Location = New System.Drawing.Point(13, 121)
        Me.Data_sk_kebutuhan.Name = "Data_sk_kebutuhan"
        Me.Data_sk_kebutuhan.ReadOnly = True
        Me.Data_sk_kebutuhan.RowHeadersVisible = False
        Me.Data_sk_kebutuhan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Data_sk_kebutuhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Data_sk_kebutuhan.ShowCellToolTips = False
        Me.Data_sk_kebutuhan.Size = New System.Drawing.Size(759, 363)
        Me.Data_sk_kebutuhan.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(198, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Produk"
        '
        'Nama_produk
        '
        Me.Nama_produk.AutoSize = True
        Me.Nama_produk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Nama_produk.Location = New System.Drawing.Point(328, 58)
        Me.Nama_produk.Name = "Nama_produk"
        Me.Nama_produk.Size = New System.Drawing.Size(102, 20)
        Me.Nama_produk.TabIndex = 3
        Me.Nama_produk.Text = "nama produk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(198, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Stasiun Kerja"
        '
        'Nama_sk
        '
        Me.Nama_sk.AutoSize = True
        Me.Nama_sk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Nama_sk.Location = New System.Drawing.Point(364, 82)
        Me.Nama_sk.Name = "Nama_sk"
        Me.Nama_sk.Size = New System.Drawing.Size(69, 20)
        Me.Nama_sk.TabIndex = 5
        Me.Nama_sk.Text = "nama sk"
        '
        'Id_produk
        '
        Me.Id_produk.AutoSize = True
        Me.Id_produk.Location = New System.Drawing.Point(125, 65)
        Me.Id_produk.Name = "Id_produk"
        Me.Id_produk.Size = New System.Drawing.Size(54, 13)
        Me.Id_produk.TabIndex = 6
        Me.Id_produk.Text = "id_produk"
        Me.Id_produk.Visible = False
        '
        'Id_sk_produk
        '
        Me.Id_sk_produk.AutoSize = True
        Me.Id_sk_produk.Location = New System.Drawing.Point(125, 82)
        Me.Id_sk_produk.Name = "Id_sk_produk"
        Me.Id_sk_produk.Size = New System.Drawing.Size(71, 13)
        Me.Id_sk_produk.TabIndex = 7
        Me.Id_sk_produk.Text = "id_sk_produk"
        Me.Id_sk_produk.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 515)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(781, 50)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operasi"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(87, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Ubah"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(168, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(696, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'no_sk
        '
        Me.no_sk.AutoSize = True
        Me.no_sk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.no_sk.Location = New System.Drawing.Point(328, 82)
        Me.no_sk.Name = "no_sk"
        Me.no_sk.Size = New System.Drawing.Size(37, 20)
        Me.no_sk.TabIndex = 9
        Me.no_sk.Text = "(no)"
        '
        'id_kebutuhan_sk
        '
        Me.id_kebutuhan_sk.DataPropertyName = "id_kebutuhan_sk"
        Me.id_kebutuhan_sk.HeaderText = "id_kebutuhan_sk"
        Me.id_kebutuhan_sk.Name = "id_kebutuhan_sk"
        Me.id_kebutuhan_sk.ReadOnly = True
        Me.id_kebutuhan_sk.Visible = False
        '
        'nomor
        '
        Me.nomor.DataPropertyName = "nomor"
        Me.nomor.FillWeight = 20.30457!
        Me.nomor.HeaderText = "No"
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        '
        'nama_kebutuhan
        '
        Me.nama_kebutuhan.DataPropertyName = "nama_kebutuhan"
        Me.nama_kebutuhan.FillWeight = 179.6954!
        Me.nama_kebutuhan.HeaderText = "Nama Kebutuhan"
        Me.nama_kebutuhan.Name = "nama_kebutuhan"
        Me.nama_kebutuhan.ReadOnly = True
        '
        'jumlah
        '
        Me.jumlah.DataPropertyName = "jumlah"
        Me.jumlah.HeaderText = "Jumlah Kebutuhan"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        '
        'Kebutuhan_sk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.no_sk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Id_sk_produk)
        Me.Controls.Add(Me.Id_produk)
        Me.Controls.Add(Me.Nama_sk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Nama_produk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Data_sk_kebutuhan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Kebutuhan_sk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kebutuhan Stasiun Kerja"
        CType(Me.Data_sk_kebutuhan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Data_sk_kebutuhan As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nama_produk As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nama_sk As System.Windows.Forms.Label
    Friend WithEvents Id_produk As System.Windows.Forms.Label
    Friend WithEvents Id_sk_produk As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents no_sk As System.Windows.Forms.Label
    Friend WithEvents id_kebutuhan_sk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_kebutuhan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
