Public Class Beranda


    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click

        Login.Show()
        Me.Close()

    End Sub

    Private Sub LihatDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LihatDataToolStripMenuItem.Click

        Kebutuhan.Show()
        Me.Hide()

    End Sub

    Private Sub LihatDataToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LihatDataToolStripMenuItem1.Click
        Laporan.Show()
        Me.Hide()

    End Sub

    Private Sub DataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataToolStripMenuItem.Click
        Produk.Show()
        Me.Hide()

    End Sub

    Private Sub TambahDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahDataToolStripMenuItem.Click
        Produk.Show()
        Me.Hide()
        Tambah_produk.ShowDialog()

    End Sub

    Private Sub TambahDataToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahDataToolStripMenuItem1.Click
        Kebutuhan.Show()
        Me.Hide()
        Tambah_kebutuhan.ShowDialog()

    End Sub
End Class