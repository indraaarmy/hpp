<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ubah_kebutuhan_sk_produk
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
        Me.Nama_Kebutuhan = New System.Windows.Forms.TextBox
        Me.Id_kebutuhan_sk = New System.Windows.Forms.Label
        Me.Jumlah = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button_Simpan = New System.Windows.Forms.Button
        Me.Button_Batal = New System.Windows.Forms.Button
        Me.Id_Produk = New System.Windows.Forms.Label
        Me.Id_sk_produk = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Nama_Kebutuhan
        '
        Me.Nama_Kebutuhan.Enabled = False
        Me.Nama_Kebutuhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama_Kebutuhan.Location = New System.Drawing.Point(175, 79)
        Me.Nama_Kebutuhan.Name = "Nama_Kebutuhan"
        Me.Nama_Kebutuhan.ReadOnly = True
        Me.Nama_Kebutuhan.Size = New System.Drawing.Size(172, 26)
        Me.Nama_Kebutuhan.TabIndex = 33
        '
        'Id_kebutuhan_sk
        '
        Me.Id_kebutuhan_sk.AutoSize = True
        Me.Id_kebutuhan_sk.Location = New System.Drawing.Point(39, 30)
        Me.Id_kebutuhan_sk.Name = "Id_kebutuhan_sk"
        Me.Id_kebutuhan_sk.Size = New System.Drawing.Size(89, 13)
        Me.Id_kebutuhan_sk.TabIndex = 32
        Me.Id_kebutuhan_sk.Text = "id_kebutuhan_sk"
        Me.Id_kebutuhan_sk.Visible = False
        '
        'Jumlah
        '
        Me.Jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jumlah.Location = New System.Drawing.Point(175, 114)
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Size = New System.Drawing.Size(172, 26)
        Me.Jumlah.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Jumlah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nama Kebutuhan"
        '
        'Button_Simpan
        '
        Me.Button_Simpan.Location = New System.Drawing.Point(191, 170)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.Button_Simpan.TabIndex = 28
        Me.Button_Simpan.Text = "Simpan"
        Me.Button_Simpan.UseVisualStyleBackColor = True
        '
        'Button_Batal
        '
        Me.Button_Batal.Location = New System.Drawing.Point(272, 170)
        Me.Button_Batal.Name = "Button_Batal"
        Me.Button_Batal.Size = New System.Drawing.Size(75, 23)
        Me.Button_Batal.TabIndex = 27
        Me.Button_Batal.Text = "Batal"
        Me.Button_Batal.UseVisualStyleBackColor = True
        '
        'Id_Produk
        '
        Me.Id_Produk.AutoSize = True
        Me.Id_Produk.Location = New System.Drawing.Point(42, 14)
        Me.Id_Produk.Name = "Id_Produk"
        Me.Id_Produk.Size = New System.Drawing.Size(39, 13)
        Me.Id_Produk.TabIndex = 34
        Me.Id_Produk.Text = "Label1"
        Me.Id_Produk.Visible = False
        '
        'Id_sk_produk
        '
        Me.Id_sk_produk.AutoSize = True
        Me.Id_sk_produk.Location = New System.Drawing.Point(42, 47)
        Me.Id_sk_produk.Name = "Id_sk_produk"
        Me.Id_sk_produk.Size = New System.Drawing.Size(39, 13)
        Me.Id_sk_produk.TabIndex = 35
        Me.Id_sk_produk.Text = "Label1"
        Me.Id_sk_produk.Visible = False
        '
        'Ubah_kebutuhan_sk_produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 262)
        Me.Controls.Add(Me.Id_sk_produk)
        Me.Controls.Add(Me.Id_Produk)
        Me.Controls.Add(Me.Nama_Kebutuhan)
        Me.Controls.Add(Me.Id_kebutuhan_sk)
        Me.Controls.Add(Me.Jumlah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Simpan)
        Me.Controls.Add(Me.Button_Batal)
        Me.Name = "Ubah_kebutuhan_sk_produk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ubah Kebutuhan SK Produk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nama_Kebutuhan As System.Windows.Forms.TextBox
    Friend WithEvents Id_kebutuhan_sk As System.Windows.Forms.Label
    Friend WithEvents Jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button_Simpan As System.Windows.Forms.Button
    Friend WithEvents Button_Batal As System.Windows.Forms.Button
    Friend WithEvents Id_Produk As System.Windows.Forms.Label
    Friend WithEvents Id_sk_produk As System.Windows.Forms.Label
End Class
