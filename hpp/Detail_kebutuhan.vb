Public Class Detail_kebutuhan

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Produk.Show()
        Me.Close()

    End Sub

    Private Sub Detail_kebutuhan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'dataload("SELECT kp.id_kebutuhan_produk, kp.id_produk, kp.id_kebutuhan, k.nama_kebutuhan, kp.jumlah FROM kebutuhan_produk kp, kebutuhan k WHERE kp.id_kebutuhan = k.id_kebutuhan AND id_produk = '" + Id_Produk.Text + "'")
            dataload("SELECT kp.id_kebutuhan_produk, kp.id_produk, kp.id_kebutuhan , k.nama_kebutuhan,k.satuan,k.jenis, k.watt,k.umur_pemakaian, SUM(ks.jumlah) as jumlah FROM kebutuhan k, kebutuhan_produk kp LEFT JOIN kebutuhan_sk ks ON kp.id_kebutuhan_produk = ks.id_kebutuhan_produk WHERE id_produk='" + Id_Produk.Text + "' and k.id_kebutuhan = kp.id_kebutuhan GROUP BY k.id_kebutuhan")
            filltable(Data_Kebutuhan_Produk)
            'Data_Kebutuhan_Produk.Columns(0).Visible = False
            'Data_Kebutuhan_Produk.Columns(4).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button_Tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Tambah.Click
        Tambah_detail_kebutuhan_produk.Id_Produk.Text = Id_Produk.Text
        Tambah_detail_kebutuhan_produk.ShowDialog()


    End Sub

    Private Sub Button_Hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Hapus.Click
        Try
            delete("DELETE FROM kebutuhan_sk WHERE id_kebutuhan_produk = '" + CType(Data_Kebutuhan_Produk.CurrentRow.Cells(1).Value, String) + "'")
            delete("DELETE FROM kebutuhan_produk WHERE id_kebutuhan_produk = '" + CType(Data_Kebutuhan_Produk.CurrentRow.Cells(1).Value, String) + "'")

            dataload("SELECT kp.id_kebutuhan_produk, kp.id_produk, kp.id_kebutuhan , k.nama_kebutuhan,k.satuan,k.jenis, k.watt,k.umur_pemakaian, SUM(ks.jumlah) as jumlah FROM kebutuhan k, kebutuhan_produk kp LEFT JOIN kebutuhan_sk ks ON kp.id_kebutuhan_produk = ks.id_kebutuhan_produk WHERE id_produk='" + Id_Produk.Text + "' and k.id_kebutuhan = kp.id_kebutuhan GROUP BY k.id_kebutuhan")
            filltable(Data_Kebutuhan_Produk)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Private Sub Button_Ubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Ubah.Click
    '    Ubah_detail_kebutuhan_produk.Id_Kebutuhan_Produk.Text = CType(Data_Kebutuhan_Produk.CurrentRow.Cells(1).Value, String)
    '    Ubah_detail_kebutuhan_produk.Id_Produk.Text = CType(Data_Kebutuhan_Produk.CurrentRow.Cells(2).Value, String)
    '    Ubah_detail_kebutuhan_produk.Nama_Kebutuhan.Text = CType(Data_Kebutuhan_Produk.CurrentRow.Cells(4).Value, String)
    '    Ubah_detail_kebutuhan_produk.Jumlah.Text = CType(Data_Kebutuhan_Produk.CurrentRow.Cells(5).Value, String)

    '    Ubah_detail_kebutuhan_produk.Show()

    'End Sub

   
End Class