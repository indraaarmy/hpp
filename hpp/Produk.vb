Public Class Produk

    Private Sub BerandaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BerandaToolStripMenuItem.Click
        Beranda.Show()
        Me.Hide()

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub TambahDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahDataToolStripMenuItem.Click
        Tambah_produk.ShowDialog()
        'Me.Hide()
    End Sub

    Private Sub LihatDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LihatDataToolStripMenuItem.Click
        Kebutuhan.Show()
        Me.Hide()
    End Sub

    Private Sub TambahDataToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahDataToolStripMenuItem1.Click
        Kebutuhan.Show()
        Me.Hide()
        Tambah_kebutuhan.ShowDialog()

    End Sub

    Private Sub LihatDataToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LihatDataToolStripMenuItem1.Click
        Laporan.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Tambah_produk.ShowDialog()
        'Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Detail_kebutuhan.Id_Produk.Text = CType(DataProduk.CurrentRow.Cells("id_produk").Value, String)
        Detail_kebutuhan.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        
        Detail_sk.Id_produk.Text = CType(DataProduk.CurrentRow.Cells("id_produk").Value, String)
        Detail_sk.Nama_produk.Text = CType(DataProduk.CurrentRow.Cells(2).Value, String)
        Detail_sk.Show()
        Me.Hide()

    End Sub


    Private Sub Button_Hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Hapus.Click
        Try
            delete("DELETE FROM kebutuhan_sk where id_kebutuhan_sk IN (SELECT y.id FROM (SELECT ks.id_kebutuhan_sk AS id FROM produk p, kebutuhan_produk kp, kebutuhan_sk ks WHERE(p.id_produk = kp.id_produk) AND kp.id_kebutuhan_produk = ks.id_kebutuhan_produk AND p.id_produk = '" + CType(DataProduk.CurrentRow.Cells(1).Value, String) + "' ) y)")
            delete("DELETE FROM sk_produk WHERE id_produk = '" + CType(DataProduk.CurrentRow.Cells(1).Value, String) + "'")
            delete("DELETE FROM kebutuhan_produk WHERE id_produk = '" + CType(DataProduk.CurrentRow.Cells(1).Value, String) + "'")
            delete("DELETE FROM produk WHERE id_produk = '" + CType(DataProduk.CurrentRow.Cells(1).Value, String) + "'")

            dataload("SELECT p.id_produk, p.nama_produk, SUM(sp.waktu) as waktu FROM produk p LEFT JOIN sk_produk sp ON p.id_produk = sp.id_produk GROUP BY p.id_produk")
            'dataload("SELECT id_produk, nama_produk as nama where produk")
            filltable(DataProduk)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Try
        '    dataload("SELECT id_produk as 'ID Produk', nama_produk as 'Produk' FROM produk")
        '    filltable(DataProduk)

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub Button_Ubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Ubah.Click
        Ubah_produk.Id_Produk.Text = CType(DataProduk.CurrentRow.Cells(1).Value, String)
        Ubah_produk.NamaProduk.Text = CType(DataProduk.CurrentRow.Cells(2).Value, String)

        Ubah_produk.ShowDialog()
        'Me.Close()

    End Sub

    Private Sub Produk_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            dataload("SELECT p.id_produk, p.nama_produk, SUM(sp.waktu) as waktu FROM produk p LEFT JOIN sk_produk sp ON p.id_produk = sp.id_produk GROUP BY p.id_produk")
            'dataload("SELECT id_produk, nama_produk as nama where produk")
            filltable(DataProduk)
            'DataProduk.Columns(0).Visible = False
            DataProduk.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Produk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataProduk.Columns("waktu").DefaultCellStyle.Format = "n2"
        DataProduk.Columns("waktu").ValueType = GetType(Double)
    End Sub
End Class