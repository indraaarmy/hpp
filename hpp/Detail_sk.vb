Public Class Detail_sk

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Produk.Show()
        Me.Close()

    End Sub

    Private Sub Button_Ubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Ubah.Click
        Ubah_detail_sk.id_sk_produk.Text = CType(Data_Sk_Produk.CurrentRow.Cells(1).Value, String)
        Ubah_detail_sk.nama_produk.Text = CType(Nama_produk.Text, String)
        Ubah_detail_sk.nama_sk.Text = CType(Data_Sk_Produk.CurrentRow.Cells(2).Value, String)
        Ubah_detail_sk.Waktu.Text = CType(Data_Sk_Produk.CurrentRow.Cells(3).Value, String)
        Ubah_detail_sk.Jumlah_pekerja.Text = CType(Data_Sk_Produk.CurrentRow.Cells(4).Value, String)
        Ubah_detail_sk.Upah.Text = CType(Data_Sk_Produk.CurrentRow.Cells(5).Value, String)

        Ubah_detail_sk.ShowDialog()

    End Sub

    Private Sub Detail_sk_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            dataload("SELECT p.id_sk_produk, s.nama_sk, p.waktu, p.jumlah_pekerja, p.upah FROM sk s, sk_produk p where p.id_produk=" + Id_produk.Text + " AND p.id_sk=s.id_sk")
            filltable(Data_Sk_Produk)
            'Data_Kebutuhan_Sk.Columns(0).Visible = False
            Data_Sk_Produk.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button_Detail_Kebutuhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Detail_Kebutuhan.Click
        Kebutuhan_sk.Id_sk_produk.Text = CType(Data_Sk_Produk.CurrentRow.Cells(1).Value, String)
        Kebutuhan_sk.Nama_sk.Text = CType(Data_Sk_Produk.CurrentRow.Cells(2).Value, String)
        Kebutuhan_sk.Id_produk.Text = CType(Id_produk.Text, String)
        Kebutuhan_sk.Nama_produk.Text = CType(Nama_produk.Text, String)
        Kebutuhan_sk.no_sk.Text = "(" + CType(Data_Sk_Produk.CurrentRow.Cells(0).Value, String) + ")"
        Kebutuhan_sk.Show()
        Me.Close()
    End Sub

    
End Class