Public Class Ubah_kebutuhan_produk

    Private Sub Button_Batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Batal.Click

        Me.Close()

    End Sub

    Private Sub Button_Simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Simpan.Click
        Try
            edit("UPDATE kebutuhan_produk SET jumlah = '" + Jumlah.Text + "' WHERE id_kebutuhan_produk = '" + Id_Kebutuhan_Produk.Text + "'")
            dataload("SELECT p.id_kebutuhan_produk as id, k.nama_kebutuhan as nama, p.jumlah as jumlah FROM kebutuhan_produk p, kebutuhan k WHERE id_produk = (SELECT x.id FROM (SELECT MAX(t.id_produk) AS id FROM produk t) x) AND k.id_kebutuhan= p.id_kebutuhan")
            filltable(Kebutuhan_produk.DataKebutuhanProduk)

            'dataload("SELECT id_kebutuhan_produk as ID, id_produk as 'ID Produk', id_kebutuhan as 'ID Kebutuhan', jumlah as 'Jumlah' FROM kebutuhan_produk WHERE id_produk = '" + Id_Produk.Text + "'")
            'filltable(Detail_kebutuhan.Data_Kebutuhan_Produk)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class