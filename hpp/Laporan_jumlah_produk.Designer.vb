<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_jumlah_produk
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Jumlah_produksi = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.KebutuhanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.id_produk = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Nama_produk = New System.Windows.Forms.Label
        CType(Me.KebutuhanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(54, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kebutuhan Pekerja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jumlah Produksi"
        '
        'Jumlah_produksi
        '
        Me.Jumlah_produksi.Location = New System.Drawing.Point(133, 97)
        Me.Jumlah_produksi.Name = "Jumlah_produksi"
        Me.Jumlah_produksi.Size = New System.Drawing.Size(181, 20)
        Me.Jumlah_produksi.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Batal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(157, 150)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Selanjutnya"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'KebutuhanBindingSource
        '
        Me.KebutuhanBindingSource.DataSource = GetType(hpp.Kebutuhan)
        '
        'id_produk
        '
        Me.id_produk.AutoSize = True
        Me.id_produk.Location = New System.Drawing.Point(27, 29)
        Me.id_produk.Name = "id_produk"
        Me.id_produk.Size = New System.Drawing.Size(0, 13)
        Me.id_produk.TabIndex = 5
        Me.id_produk.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Produk"
        '
        'Nama_produk
        '
        Me.Nama_produk.AutoSize = True
        Me.Nama_produk.Location = New System.Drawing.Point(133, 61)
        Me.Nama_produk.Name = "Nama_produk"
        Me.Nama_produk.Size = New System.Drawing.Size(0, 13)
        Me.Nama_produk.TabIndex = 7
        '
        'Laporan_jumlah_produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 185)
        Me.ControlBox = False
        Me.Controls.Add(Me.Nama_produk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.id_produk)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Jumlah_produksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Laporan_jumlah_produk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jumlah Produk"
        CType(Me.KebutuhanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Jumlah_produksi As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents KebutuhanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents id_produk As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Nama_produk As System.Windows.Forms.Label
End Class
