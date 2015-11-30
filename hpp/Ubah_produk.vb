Public Class Ubah_produk

    
    Private Sub Button_Simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Simpan.Click
        Try
            edit("UPDATE produk SET nama_produk = '" + NamaProduk.Text + "' WHERE id_produk = '" + Id_Produk.Text + "'")
            Me.Close()
            dataload("SELECT p.id_produk, p.nama_produk, SUM(sp.waktu) as waktu FROM produk p LEFT JOIN sk_produk sp ON p.id_produk = sp.id_produk GROUP BY p.id_produk")
            filltable(Produk.DataProduk)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button_Batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Batal.Click
        Me.Close()

    End Sub
End Class