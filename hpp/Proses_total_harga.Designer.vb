<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proses_total_harga
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
        Me.Kembali = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.harga_jual = New System.Windows.Forms.Label
        Me.nama_produk = New System.Windows.Forms.Label
        Me.id_produk = New System.Windows.Forms.Label
        Me.total_harga1 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.total_produk = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Kembali
        '
        Me.Kembali.Location = New System.Drawing.Point(140, 93)
        Me.Kembali.Name = "Kembali"
        Me.Kembali.Size = New System.Drawing.Size(75, 23)
        Me.Kembali.TabIndex = 9
        Me.Kembali.Text = "Kembali"
        Me.Kembali.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(257, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Ubah Jumlah"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'harga_jual
        '
        Me.harga_jual.AutoSize = True
        Me.harga_jual.Location = New System.Drawing.Point(195, 128)
        Me.harga_jual.Name = "harga_jual"
        Me.harga_jual.Size = New System.Drawing.Size(56, 13)
        Me.harga_jual.TabIndex = 7
        Me.harga_jual.Text = "harga_jual"
        Me.harga_jual.Visible = False
        '
        'nama_produk
        '
        Me.nama_produk.AutoSize = True
        Me.nama_produk.Location = New System.Drawing.Point(94, 129)
        Me.nama_produk.Name = "nama_produk"
        Me.nama_produk.Size = New System.Drawing.Size(72, 13)
        Me.nama_produk.TabIndex = 6
        Me.nama_produk.Text = "nama_produk"
        Me.nama_produk.Visible = False
        '
        'id_produk
        '
        Me.id_produk.AutoSize = True
        Me.id_produk.Location = New System.Drawing.Point(10, 129)
        Me.id_produk.Name = "id_produk"
        Me.id_produk.Size = New System.Drawing.Size(54, 13)
        Me.id_produk.TabIndex = 5
        Me.id_produk.Text = "id_produk"
        Me.id_produk.Visible = False
        '
        'total_harga1
        '
        Me.total_harga1.AutoSize = True
        Me.total_harga1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_harga1.Location = New System.Drawing.Point(167, 49)
        Me.total_harga1.Name = "total_harga1"
        Me.total_harga1.Size = New System.Drawing.Size(145, 29)
        Me.total_harga1.TabIndex = 10
        Me.total_harga1.Text = "total_harga1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Total Jumlah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Total Produk"
        '
        'total_produk
        '
        Me.total_produk.AutoSize = True
        Me.total_produk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_produk.Location = New System.Drawing.Point(168, 26)
        Me.total_produk.Name = "total_produk"
        Me.total_produk.Size = New System.Drawing.Size(98, 20)
        Me.total_produk.TabIndex = 13
        Me.total_produk.Text = "total_produk"
        '
        'Proses_total_harga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 152)
        Me.Controls.Add(Me.total_produk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.total_harga1)
        Me.Controls.Add(Me.Kembali)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.harga_jual)
        Me.Controls.Add(Me.nama_produk)
        Me.Controls.Add(Me.id_produk)
        Me.Name = "Proses_total_harga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proses_total_harga"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Kembali As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents harga_jual As System.Windows.Forms.Label
    Friend WithEvents nama_produk As System.Windows.Forms.Label
    Friend WithEvents id_produk As System.Windows.Forms.Label
    Friend WithEvents total_harga1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents total_produk As System.Windows.Forms.Label
End Class
