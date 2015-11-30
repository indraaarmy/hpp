Public Class Kebutuhan_produk

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'delete all max id

        delete("DELETE FROM kebutuhan_produk WHERE id_produk = (SELECT x.id FROM (SELECT MAX(t.id_produk) AS id FROM kebutuhan_produk t) x)")
        delete("DELETE FROM produk WHERE id_produk = (SELECT x.id FROM (SELECT MAX(t.id_produk) AS id FROM produk t) x)")
        Produk.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Tambah_kebutuhan_produk.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Perencanaan_gambar_pola.Show()
        Me.Close()
    End Sub

    Private Sub Kebutuhan_produk_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            dataload("SELECT p.id_kebutuhan_produk, k.nama_kebutuhan, k.jenis, k.listrik, k.watt FROM kebutuhan_produk p, kebutuhan k WHERE id_produk = (SELECT x.id FROM (SELECT MAX(t.id_produk) AS id FROM produk t) x) AND k.id_kebutuhan= p.id_kebutuhan")
            filltable(DataKebutuhanProduk)
            'DataKebutuhanProduk.Columns(0).Visible = False
            DataKebutuhanProduk.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Ubah_kebutuhan_produk.Id_Kebutuhan_Produk.Text = CType(DataKebutuhanProduk.CurrentRow.Cells(1).Value, String)
        Ubah_kebutuhan_produk.Nama.Text = CType(DataKebutuhanProduk.CurrentRow.Cells(2).Value, String)
        Ubah_kebutuhan_produk.Jumlah.Text = CType(DataKebutuhanProduk.CurrentRow.Cells(3).Value, String)
        Ubah_kebutuhan_produk.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            delete("DELETE FROM kebutuhan_produk WHERE id_kebutuhan_produk = '" + CType(DataKebutuhanProduk.CurrentRow.Cells(1).Value, String) + "'")
            dataload("SELECT p.id_kebutuhan_produk, k.nama_kebutuhan, k.jenis, k.listrik, k.watt FROM kebutuhan_produk p, kebutuhan k WHERE id_produk = (SELECT x.id FROM (SELECT MAX(t.id_produk) AS id FROM produk t) x) AND k.id_kebutuhan= p.id_kebutuhan")
            filltable(DataKebutuhanProduk)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class