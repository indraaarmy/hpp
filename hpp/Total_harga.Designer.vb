<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Total_harga
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
        Me.id_produk = New System.Windows.Forms.Label
        Me.nama_produk = New System.Windows.Forms.Label
        Me.harga_jual = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Kembali = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.jumlah_produk = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'id_produk
        '
        Me.id_produk.AutoSize = True
        Me.id_produk.Location = New System.Drawing.Point(12, 130)
        Me.id_produk.Name = "id_produk"
        Me.id_produk.Size = New System.Drawing.Size(54, 13)
        Me.id_produk.TabIndex = 0
        Me.id_produk.Text = "id_produk"
        Me.id_produk.Visible = False
        '
        'nama_produk
        '
        Me.nama_produk.AutoSize = True
        Me.nama_produk.Location = New System.Drawing.Point(73, 130)
        Me.nama_produk.Name = "nama_produk"
        Me.nama_produk.Size = New System.Drawing.Size(72, 13)
        Me.nama_produk.TabIndex = 1
        Me.nama_produk.Text = "nama_produk"
        Me.nama_produk.Visible = False
        '
        'harga_jual
        '
        Me.harga_jual.AutoSize = True
        Me.harga_jual.Location = New System.Drawing.Point(151, 130)
        Me.harga_jual.Name = "harga_jual"
        Me.harga_jual.Size = New System.Drawing.Size(56, 13)
        Me.harga_jual.TabIndex = 2
        Me.harga_jual.Text = "harga_jual"
        Me.harga_jual.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(226, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Proses"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Kembali
        '
        Me.Kembali.Location = New System.Drawing.Point(307, 93)
        Me.Kembali.Name = "Kembali"
        Me.Kembali.Size = New System.Drawing.Size(75, 23)
        Me.Kembali.TabIndex = 4
        Me.Kembali.Text = "Kembali"
        Me.Kembali.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(72, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Jumlah Produk"
        '
        'jumlah_produk
        '
        Me.jumlah_produk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.jumlah_produk.Location = New System.Drawing.Point(192, 49)
        Me.jumlah_produk.Name = "jumlah_produk"
        Me.jumlah_produk.Size = New System.Drawing.Size(143, 26)
        Me.jumlah_produk.TabIndex = 6
        '
        'Total_harga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 152)
        Me.ControlBox = False
        Me.Controls.Add(Me.jumlah_produk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Kembali)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.harga_jual)
        Me.Controls.Add(Me.nama_produk)
        Me.Controls.Add(Me.id_produk)
        Me.Name = "Total_harga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Total Harga"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id_produk As System.Windows.Forms.Label
    Friend WithEvents nama_produk As System.Windows.Forms.Label
    Friend WithEvents harga_jual As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Kembali As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents jumlah_produk As System.Windows.Forms.TextBox
End Class
