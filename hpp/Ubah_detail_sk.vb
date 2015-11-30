Public Class Ubah_detail_sk

    Private Sub Button_Batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Batal.Click
        Me.Close()

    End Sub

    Private Sub Button_Simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Simpan.Click
        Try
            edit("UPDATE sk_produk SET waktu = '" + Waktu.Text + "', jumlah_pekerja =  '" + Jumlah_pekerja.Text + "', upah =  '" + Upah.Text + "' WHERE id_sk_produk = '" + id_sk_produk.Text + "'")
            Me.Close()
            dataload("SELECT p.id_sk_produk, s.nama_sk, p.waktu, p.jumlah_pekerja, p.upah FROM sk s, sk_produk p where p.id_produk=" + Detail_sk.Id_produk.Text + " AND p.id_sk=s.id_sk")
            filltable(Detail_sk.Data_Sk_Produk)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    
End Class