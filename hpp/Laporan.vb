Imports CrystalDecisions.Shared
Public Class Laporan

    Private Sub BerandaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BerandaToolStripMenuItem.Click
        Beranda.Show()
        Me.Hide()

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Login.Show()
        Me.Close()

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

    Private Sub LihatDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LihatDataToolStripMenuItem.Click
        Kebutuhan.Show()
        Me.Hide()

    End Sub

    Private Sub TambahDataToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahDataToolStripMenuItem1.Click
        Kebutuhan.Show()
        Me.Hide()
        Tambah_kebutuhan.ShowDialog()


    End Sub

    Private Sub Laporan_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            'dataload("SELECT id_produk, nama_produk FROM produk")
            dataload("SELECT p.id_produk, p.nama_produk, SUM(sp.waktu) as waktu FROM produk p LEFT JOIN sk_produk sp ON p.id_produk = sp.id_produk GROUP BY p.id_produk")

            filltable(DataLaporan)
            'DataLaporan.Columns(2).Visible = False
            DataLaporan.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Laporan_jumlah_produk.id_produk.Text = CType(DataLaporan.CurrentRow.Cells("id_produk").Value, String)
        Laporan_jumlah_produk.Nama_produk.Text = CType(DataLaporan.CurrentRow.Cells("nama_produk").Value, String)
        Laporan_jumlah_produk.ShowDialog()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CetakLaporan_kebutuhan_SK.CrystalReportViewer1.ReportSource = CetakLaporan_kebutuhan_SK.Cetak_laporan_kebutuhan_SK1
        CetakLaporan_kebutuhan_SK.Cetak_laporan_kebutuhan_SK1.SetParameterValue("id_produk", DataLaporan.CurrentRow.Cells(1).Value)
        CetakLaporan_kebutuhan_SK.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CetakLaporan_kebutuhan_SK.CrystalReportViewer1.ReportSource = CetakLaporan_kebutuhan_SK.Cetak_hpp_menit1
        CetakLaporan_kebutuhan_SK.Cetak_hpp_menit1.SetParameterValue("id_produk", DataLaporan.CurrentRow.Cells(1).Value)
        CetakLaporan_kebutuhan_SK.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CetakLaporan_kebutuhan_SK.CrystalReportViewer1.ReportSource = CetakLaporan_kebutuhan_SK.Cetak_hpp_waktu_sk1
        CetakLaporan_kebutuhan_SK.Cetak_hpp_waktu_sk1.SetParameterValue("id_produk", DataLaporan.CurrentRow.Cells(1).Value)
        CetakLaporan_kebutuhan_SK.ShowDialog()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Laporan_sk.Id_produk.Text = CType(DataLaporan.CurrentRow.Cells(1).Value, String)
        Laporan_sk.nama_produk.Text = CType(DataLaporan.CurrentRow.Cells(2).Value, String)
        Laporan_sk.Show()
        Me.Hide()
    End Sub

   
    Private Sub Laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataLaporan.Columns("waktu").DefaultCellStyle.Format = "n2"
        DataLaporan.Columns("waktu").ValueType = GetType(Double)
    End Sub
End Class