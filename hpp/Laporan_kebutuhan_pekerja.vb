Public Class Laporan_kebutuhan_pekerja

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Laporan.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Laporan.Show()
        Laporan_jumlah_produk.ShowDialog()

    End Sub

    Private Sub Laporan_kebutuhan_pekerja_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
       
        Try
            '("SELECT s.nama_sk , k.waktu, k.id_sk_produk FROM sk s, sk_produk k, produk p WHERE s.id_sk=k.id_sk AND k.id_produk=p.id_produk AND p.id_produk=1")
            dataload("SELECT s.nama_sk , k.waktu FROM sk s, sk_produk k, produk p WHERE s.id_sk=k.id_sk AND k.id_produk=p.id_produk AND p.id_produk=1")

            'jumlah_produksi/(((8*60)/waktu)*30)


            filltable(DataKebutuhanPekerja)
            DataKebutuhanPekerja.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        For iROW = 0 To DataKebutuhanPekerja.RowCount - 1
            Try
                DataKebutuhanPekerja.Rows(iROW).Cells("jumlah").Value = Jumlah_produksi.Text \ (((7 * 60) \ CType(DataKebutuhanPekerja.Rows(iROW).Cells(3).Value, String)) * 30)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next iROW
    End Sub

   
End Class