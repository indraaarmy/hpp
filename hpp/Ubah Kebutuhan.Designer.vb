<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ubah_Kebutuhan
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.nama_kebutuhan = New System.Windows.Forms.TextBox
        Me.harga_kebutuhan = New System.Windows.Forms.TextBox
        Me.satuan = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.id_kebutuhan = New System.Windows.Forms.Label
        Me.Listrik = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Watt = New System.Windows.Forms.TextBox
        Me.Jenis = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Umur_pemakaian = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Satuan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Harga"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama"
        '
        'nama_kebutuhan
        '
        Me.nama_kebutuhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.nama_kebutuhan.Location = New System.Drawing.Point(152, 21)
        Me.nama_kebutuhan.Name = "nama_kebutuhan"
        Me.nama_kebutuhan.Size = New System.Drawing.Size(205, 26)
        Me.nama_kebutuhan.TabIndex = 8
        '
        'harga_kebutuhan
        '
        Me.harga_kebutuhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.harga_kebutuhan.Location = New System.Drawing.Point(152, 57)
        Me.harga_kebutuhan.Name = "harga_kebutuhan"
        Me.harga_kebutuhan.Size = New System.Drawing.Size(205, 26)
        Me.harga_kebutuhan.TabIndex = 9
        '
        'satuan
        '
        Me.satuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.satuan.Location = New System.Drawing.Point(152, 92)
        Me.satuan.Name = "satuan"
        Me.satuan.Size = New System.Drawing.Size(205, 26)
        Me.satuan.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(282, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Batal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(201, 277)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'id_kebutuhan
        '
        Me.id_kebutuhan.AutoSize = True
        Me.id_kebutuhan.Location = New System.Drawing.Point(25, 9)
        Me.id_kebutuhan.Name = "id_kebutuhan"
        Me.id_kebutuhan.Size = New System.Drawing.Size(0, 13)
        Me.id_kebutuhan.TabIndex = 13
        Me.id_kebutuhan.Visible = False
        '
        'Listrik
        '
        Me.Listrik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Listrik.FormattingEnabled = True
        Me.Listrik.Items.AddRange(New Object() {"ya", "tidak"})
        Me.Listrik.Location = New System.Drawing.Point(152, 168)
        Me.Listrik.Name = "Listrik"
        Me.Listrik.Size = New System.Drawing.Size(205, 28)
        Me.Listrik.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(7, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Elektronik"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(7, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Watt"
        '
        'Watt
        '
        Me.Watt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Watt.Location = New System.Drawing.Point(152, 204)
        Me.Watt.Name = "Watt"
        Me.Watt.Size = New System.Drawing.Size(205, 26)
        Me.Watt.TabIndex = 19
        '
        'Jenis
        '
        Me.Jenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Jenis.FormattingEnabled = True
        Me.Jenis.Items.AddRange(New Object() {"alat", "bahan"})
        Me.Jenis.Location = New System.Drawing.Point(152, 129)
        Me.Jenis.Name = "Jenis"
        Me.Jenis.Size = New System.Drawing.Size(205, 28)
        Me.Jenis.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(7, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Jenis"
        '
        'Umur_pemakaian
        '
        Me.Umur_pemakaian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Umur_pemakaian.Location = New System.Drawing.Point(152, 236)
        Me.Umur_pemakaian.Name = "Umur_pemakaian"
        Me.Umur_pemakaian.Size = New System.Drawing.Size(205, 26)
        Me.Umur_pemakaian.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(7, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Umur Pemakaian"
        '
        'Ubah_Kebutuhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.Umur_pemakaian)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Listrik)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Watt)
        Me.Controls.Add(Me.Jenis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.id_kebutuhan)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.satuan)
        Me.Controls.Add(Me.harga_kebutuhan)
        Me.Controls.Add(Me.nama_kebutuhan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Ubah_Kebutuhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ubah_Kebutuhan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nama_kebutuhan As System.Windows.Forms.TextBox
    Friend WithEvents harga_kebutuhan As System.Windows.Forms.TextBox
    Friend WithEvents satuan As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents id_kebutuhan As System.Windows.Forms.Label
    Friend WithEvents Listrik As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Watt As System.Windows.Forms.TextBox
    Friend WithEvents Jenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Umur_pemakaian As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
