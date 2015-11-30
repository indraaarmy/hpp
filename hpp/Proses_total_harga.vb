Public Class Proses_total_harga

    Private Sub Kembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kembali.Click
        Laporan_sk.Id_produk.Text = CType(id_produk.Text, String)
        Laporan_sk.nama_produk.Text = CType(nama_produk.Text, String)
        Laporan_sk.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Total_harga.id_produk.Text = CType(id_produk.Text, String)
        Total_harga.harga_jual.Text = CType(harga_jual.Text, String)
        Total_harga.nama_produk.Text = CType(nama_produk.Text, String)

        Total_harga.Show()
        Me.Close()
    End Sub
End Class