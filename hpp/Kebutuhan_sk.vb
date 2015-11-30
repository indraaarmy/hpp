Public Class Kebutuhan_sk

    Private Sub Kebutuhan_sk_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            dataload("SELECT s.id_kebutuhan_sk, k.nama_kebutuhan, s.jumlah FROM kebutuhan_sk s,kebutuhan_produk p, kebutuhan k where s.id_sk_produk = " + Id_sk_produk.Text + " AND p.id_kebutuhan_produk = s.id_kebutuhan_produk AND p.id_kebutuhan= k.id_kebutuhan")
            filltable(Data_sk_kebutuhan)
            'Data_sk_kebutuhan.Columns(0).Visible = False
            Data_sk_kebutuhan.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Detail_sk.Id_produk.Text = CType(Id_produk.Text, String)
        Detail_sk.Nama_produk.Text = CType(Nama_produk.Text, String)
        Detail_sk.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tambah_kebutuhan_sk.id_produk.Text = CType(Id_produk.Text, String)
        tambah_kebutuhan_sk.nama_produk.Text = CType(Nama_produk.Text, String)
        tambah_kebutuhan_sk.nama_sk.Text = CType(Nama_sk.Text, String)
        tambah_kebutuhan_sk.id_sk_produk.Text = CType(Id_sk_produk.Text, String)

        tambah_kebutuhan_sk.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            delete("DELETE FROM kebutuhan_sk where id_kebutuhan_sk = '" + CType(Data_sk_kebutuhan.CurrentRow.Cells(1).Value, String) + "' ")
            dataload("SELECT s.id_kebutuhan_sk, k.nama_kebutuhan, s.jumlah FROM kebutuhan_sk s,kebutuhan_produk p, kebutuhan k where s.id_sk_produk = " + Id_sk_produk.Text + " AND p.id_kebutuhan_produk = s.id_kebutuhan_produk AND p.id_kebutuhan= k.id_kebutuhan")
            filltable(Data_sk_kebutuhan)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Ubah_kebutuhan_sk_produk.Id_kebutuhan_sk.Text = CType(Data_sk_kebutuhan.CurrentRow.Cells(1).Value, String)
        Ubah_kebutuhan_sk_produk.Nama_Kebutuhan.Text = CType(Data_sk_kebutuhan.CurrentRow.Cells(2).Value, String)
        Ubah_kebutuhan_sk_produk.Jumlah.Text = CType(Data_sk_kebutuhan.CurrentRow.Cells(3).Value, String)
        Ubah_kebutuhan_sk_produk.Id_Produk.Text = CType(Id_produk.Text, String)
        Ubah_kebutuhan_sk_produk.Id_sk_produk.Text = CType(Id_sk_produk.Text, String)
        Ubah_kebutuhan_sk_produk.ShowDialog()

    End Sub
End Class