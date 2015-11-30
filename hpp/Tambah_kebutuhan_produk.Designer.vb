<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tambah_kebutuhan_produk
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
        Me.Button_Simpan = New System.Windows.Forms.Button
        Me.Button_Batal = New System.Windows.Forms.Button
        Me.Id_Produk = New System.Windows.Forms.Label
        Me.ComboBox_Kebutuhan = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button_Simpan
        '
        Me.Button_Simpan.Location = New System.Drawing.Point(175, 112)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.Button_Simpan.TabIndex = 10
        Me.Button_Simpan.Text = "Simpan"
        Me.Button_Simpan.UseVisualStyleBackColor = True
        '
        'Button_Batal
        '
        Me.Button_Batal.Location = New System.Drawing.Point(272, 112)
        Me.Button_Batal.Name = "Button_Batal"
        Me.Button_Batal.Size = New System.Drawing.Size(75, 23)
        Me.Button_Batal.TabIndex = 9
        Me.Button_Batal.Text = "Batal"
        Me.Button_Batal.UseVisualStyleBackColor = True
        '
        'Id_Produk
        '
        Me.Id_Produk.AutoSize = True
        Me.Id_Produk.Location = New System.Drawing.Point(42, 17)
        Me.Id_Produk.Name = "Id_Produk"
        Me.Id_Produk.Size = New System.Drawing.Size(0, 13)
        Me.Id_Produk.TabIndex = 17
        Me.Id_Produk.Visible = False
        '
        'ComboBox_Kebutuhan
        '
        Me.ComboBox_Kebutuhan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Kebutuhan.FormattingEnabled = True
        Me.ComboBox_Kebutuhan.Items.AddRange(New Object() {"q", "w", "e", "r", "t", "y"})
        Me.ComboBox_Kebutuhan.Location = New System.Drawing.Point(175, 43)
        Me.ComboBox_Kebutuhan.Name = "ComboBox_Kebutuhan"
        Me.ComboBox_Kebutuhan.Size = New System.Drawing.Size(172, 28)
        Me.ComboBox_Kebutuhan.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Kebutuhan"
        '
        'Tambah_kebutuhan_produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 180)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox_Kebutuhan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Id_Produk)
        Me.Controls.Add(Me.Button_Simpan)
        Me.Controls.Add(Me.Button_Batal)
        Me.MaximizeBox = False
        Me.Name = "Tambah_kebutuhan_produk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Kebutuhan Produk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Simpan As System.Windows.Forms.Button
    Friend WithEvents Button_Batal As System.Windows.Forms.Button
    Friend WithEvents Id_Produk As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Kebutuhan As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
