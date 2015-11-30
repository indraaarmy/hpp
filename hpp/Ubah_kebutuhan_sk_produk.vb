Public Class Ubah_kebutuhan_sk_produk

    Private Sub Button_Simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Simpan.Click
        Try
            edit("UPDATE kebutuhan_sk SET jumlah = '" + Jumlah.Text + "' WHERE id_kebutuhan_sk = '" + Id_kebutuhan_sk.Text + "'")

            dataload("SELECT s.id_kebutuhan_sk, k.nama_kebutuhan, s.jumlah FROM kebutuhan_sk s,kebutuhan_produk p, kebutuhan k where s.id_sk_produk = " + Id_sk_produk.Text + " AND p.id_kebutuhan_produk = s.id_kebutuhan_produk AND p.id_kebutuhan= k.id_kebutuhan")
            filltable(Kebutuhan_sk.Data_sk_kebutuhan)
            'Detail_kebutuhan.Data_Kebutuhan_Produk.Columns(0).Visible = False
            'Detail_kebutuhan.Data_Kebutuhan_Produk.Columns(1).Visible = False
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button_Batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Batal.Click
        Me.Close()

    End Sub

    
End Class