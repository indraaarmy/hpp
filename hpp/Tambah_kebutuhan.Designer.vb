<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_kebutuhan
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button_Simpan = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Nama_Kebutuhan = New System.Windows.Forms.TextBox
        Me.Harga_Kebutuhan = New System.Windows.Forms.TextBox
        Me.Satuan = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Jenis = New System.Windows.Forms.ComboBox
        Me.Watt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Listrik = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Umur_pemakaian = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(285, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Batal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button_Simpan
        '
        Me.Button_Simpan.Location = New System.Drawing.Point(201, 268)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.Button_Simpan.TabIndex = 1
        Me.Button_Simpan.Text = "Simpan"
        Me.Button_Simpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Satuan"
        '
        'Nama_Kebutuhan
        '
        Me.Nama_Kebutuhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama_Kebutuhan.Location = New System.Drawing.Point(155, 15)
        Me.Nama_Kebutuhan.Name = "Nama_Kebutuhan"
        Me.Nama_Kebutuhan.Size = New System.Drawing.Size(205, 26)
        Me.Nama_Kebutuhan.TabIndex = 6
        '
        'Harga_Kebutuhan
        '
        Me.Harga_Kebutuhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Harga_Kebutuhan.Location = New System.Drawing.Point(155, 51)
        Me.Harga_Kebutuhan.Name = "Harga_Kebutuhan"
        Me.Harga_Kebutuhan.Size = New System.Drawing.Size(205, 26)
        Me.Harga_Kebutuhan.TabIndex = 7
        '
        'Satuan
        '
        Me.Satuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Satuan.Location = New System.Drawing.Point(155, 83)
        Me.Satuan.Name = "Satuan"
        Me.Satuan.Size = New System.Drawing.Size(205, 26)
        Me.Satuan.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(10, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Jenis"
        '
        'Jenis
        '
        Me.Jenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Jenis.FormattingEnabled = True
        Me.Jenis.Items.AddRange(New Object() {"alat", "bahan"})
        Me.Jenis.Location = New System.Drawing.Point(155, 124)
        Me.Jenis.Name = "Jenis"
        Me.Jenis.Size = New System.Drawing.Size(205, 28)
        Me.Jenis.TabIndex = 10
        '
        'Watt
        '
        Me.Watt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Watt.Location = New System.Drawing.Point(155, 199)
        Me.Watt.Name = "Watt"
        Me.Watt.Size = New System.Drawing.Size(205, 26)
        Me.Watt.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(10, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Watt"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(10, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Elektronik"
        '
        'Listrik
        '
        Me.Listrik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Listrik.FormattingEnabled = True
        Me.Listrik.Items.AddRange(New Object() {"ya", "tidak"})
        Me.Listrik.Location = New System.Drawing.Point(155, 163)
        Me.Listrik.Name = "Listrik"
        Me.Listrik.Size = New System.Drawing.Size(205, 28)
        Me.Listrik.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(10, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Umur Pemakaian"
        '
        'Umur_pemakaian
        '
        Me.Umur_pemakaian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Umur_pemakaian.Location = New System.Drawing.Point(155, 236)
        Me.Umur_pemakaian.Name = "Umur_pemakaian"
        Me.Umur_pemakaian.Size = New System.Drawing.Size(205, 26)
        Me.Umur_pemakaian.TabIndex = 18
        '
        'Tambah_kebutuhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.Umur_pemakaian)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Listrik)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Watt)
        Me.Controls.Add(Me.Jenis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Satuan)
        Me.Controls.Add(Me.Harga_Kebutuhan)
        Me.Controls.Add(Me.Nama_Kebutuhan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Simpan)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "Tambah_kebutuhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah kebutuhan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button_Simpan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Nama_Kebutuhan As System.Windows.Forms.TextBox
    Friend WithEvents Harga_Kebutuhan As System.Windows.Forms.TextBox
    Friend WithEvents Satuan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Jenis As System.Windows.Forms.ComboBox
    Friend WithEvents Watt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Listrik As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Umur_pemakaian As System.Windows.Forms.TextBox
End Class
