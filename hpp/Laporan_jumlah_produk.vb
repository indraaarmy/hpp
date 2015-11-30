Public Class Laporan_jumlah_produk

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Laporan.Hide()
        Laporan_kebutuhan_pekerja.Id_produk.Text = CType(id_produk.Text, String)
        Laporan_kebutuhan_pekerja.Nama_Produk.Text = CType(Nama_produk.Text, String)
        Laporan_kebutuhan_pekerja.Jumlah_produksi.Text = CType(Jumlah_produksi.Text, String)
        Me.Close()
        Laporan_kebutuhan_pekerja.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Laporan.Show()
        Me.Close()
    End Sub
End Class