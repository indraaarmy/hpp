<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Beranda
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BerandaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TambahDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KebutuhanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LihatDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TambahDataToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LihatDataToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PanduanPenggunaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProdukToolStripMenuItem, Me.KebutuhanToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.PanduanPenggunaanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BerandaToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BerandaToolStripMenuItem
        '
        Me.BerandaToolStripMenuItem.Name = "BerandaToolStripMenuItem"
        Me.BerandaToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.BerandaToolStripMenuItem.Text = "Beranda"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'ProdukToolStripMenuItem
        '
        Me.ProdukToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.TambahDataToolStripMenuItem})
        Me.ProdukToolStripMenuItem.Name = "ProdukToolStripMenuItem"
        Me.ProdukToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ProdukToolStripMenuItem.Text = "Produk"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DataToolStripMenuItem.Text = "Lihat Data"
        '
        'TambahDataToolStripMenuItem
        '
        Me.TambahDataToolStripMenuItem.Name = "TambahDataToolStripMenuItem"
        Me.TambahDataToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.TambahDataToolStripMenuItem.Text = "Tambah Data"
        '
        'KebutuhanToolStripMenuItem
        '
        Me.KebutuhanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatDataToolStripMenuItem, Me.TambahDataToolStripMenuItem1})
        Me.KebutuhanToolStripMenuItem.Name = "KebutuhanToolStripMenuItem"
        Me.KebutuhanToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.KebutuhanToolStripMenuItem.Text = "Kebutuhan"
        '
        'LihatDataToolStripMenuItem
        '
        Me.LihatDataToolStripMenuItem.Name = "LihatDataToolStripMenuItem"
        Me.LihatDataToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.LihatDataToolStripMenuItem.Text = "Lihat Data"
        '
        'TambahDataToolStripMenuItem1
        '
        Me.TambahDataToolStripMenuItem1.Name = "TambahDataToolStripMenuItem1"
        Me.TambahDataToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.TambahDataToolStripMenuItem1.Text = "Tambah Data"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatDataToolStripMenuItem1})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LihatDataToolStripMenuItem1
        '
        Me.LihatDataToolStripMenuItem1.Name = "LihatDataToolStripMenuItem1"
        Me.LihatDataToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.LihatDataToolStripMenuItem1.Text = "Lihat Data"
        '
        'PanduanPenggunaanToolStripMenuItem
        '
        Me.PanduanPenggunaanToolStripMenuItem.Name = "PanduanPenggunaanToolStripMenuItem"
        Me.PanduanPenggunaanToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PanduanPenggunaanToolStripMenuItem.Text = "Panduan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selamat Datang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Di Aplikasi HPP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(274, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 38)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "UD. M. JOIN"
        '
        'Beranda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Beranda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beranda"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BerandaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KebutuhanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahDataToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatDataToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanduanPenggunaanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
