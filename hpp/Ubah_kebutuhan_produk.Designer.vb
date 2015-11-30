<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ubah_kebutuhan_produk
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
        Me.Jumlah = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button_Simpan = New System.Windows.Forms.Button
        Me.Button_Batal = New System.Windows.Forms.Button
        Me.Id_Kebutuhan_Produk = New System.Windows.Forms.Label
        Me.Nama = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Jumlah
        '
        Me.Jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jumlah.Location = New System.Drawing.Point(165, 74)
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Size = New System.Drawing.Size(172, 26)
        Me.Jumlah.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Jumlah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nama Kebutuhan"
        '
        'Button_Simpan
        '
        Me.Button_Simpan.Location = New System.Drawing.Point(181, 130)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.Button_Simpan.TabIndex = 18
        Me.Button_Simpan.Text = "Simpan"
        Me.Button_Simpan.UseVisualStyleBackColor = True
        '
        'Button_Batal
        '
        Me.Button_Batal.Location = New System.Drawing.Point(262, 130)
        Me.Button_Batal.Name = "Button_Batal"
        Me.Button_Batal.Size = New System.Drawing.Size(75, 23)
        Me.Button_Batal.TabIndex = 17
        Me.Button_Batal.Text = "Batal"
        Me.Button_Batal.UseVisualStyleBackColor = True
        '
        'Id_Kebutuhan_Produk
        '
        Me.Id_Kebutuhan_Produk.AutoSize = True
        Me.Id_Kebutuhan_Produk.Location = New System.Drawing.Point(38, 9)
        Me.Id_Kebutuhan_Produk.Name = "Id_Kebutuhan_Produk"
        Me.Id_Kebutuhan_Produk.Size = New System.Drawing.Size(0, 13)
        Me.Id_Kebutuhan_Produk.TabIndex = 25
        Me.Id_Kebutuhan_Produk.Visible = False
        '
        'Nama
        '
        Me.Nama.Enabled = False
        Me.Nama.Location = New System.Drawing.Point(165, 39)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(172, 20)
        Me.Nama.TabIndex = 26
        '
        'Ubah_kebutuhan_produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 182)
        Me.ControlBox = False
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Id_Kebutuhan_Produk)
        Me.Controls.Add(Me.Jumlah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Simpan)
        Me.Controls.Add(Me.Button_Batal)
        Me.Name = "Ubah_kebutuhan_produk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ubah Kebutuhan Produk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button_Simpan As System.Windows.Forms.Button
    Friend WithEvents Button_Batal As System.Windows.Forms.Button
    Friend WithEvents Id_Kebutuhan_Produk As System.Windows.Forms.Label
    Friend WithEvents Nama As System.Windows.Forms.TextBox
End Class
