Public Class Laporan_Biaya_Tetap


    Private Sub Laporan_Biaya_Tetap_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            dataload("SELECT k.nama_kebutuhan,ks.jumlah,k.watt,((k.harga_kebutuhan / k.umur_pemakaian) *(1/26)*(1/8)*(1/60)*ks.jumlah) as penyusutan,((k.harga_kebutuhan / k.umur_pemakaian) *(1/26)*(1/8)*(1/60)*ks.jumlah*sp.waktu) as penyusutan_unit, (((k.watt*ks.jumlah*1115)/1000)*(1/60)) as biaya_listrik, (((k.watt*ks.jumlah*1115)/1000)*(1/60)*sp.waktu) as biaya_listrik_unit FROM kebutuhan k, kebutuhan_sk ks, kebutuhan_produk kp, sk_produk sp WHERE kp.id_produk =  '" + id_produk.Text + "'  AND sp.id_sk_produk = '" + id_sk_produk.Text + "' AND k.jenis = 'alat' AND k.id_kebutuhan = kp.id_kebutuhan AND kp.id_kebutuhan_produk = ks.id_kebutuhan_produk AND ks.id_sk_produk = sp.id_sk_produk")
            filltable(DataLaporanBiayaTetap)
            'Data_Kebutuhan_Sk.Columns(0).Visible = False
            DataLaporanBiayaTetap.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        For iROW = 0 To DataLaporanBiayaTetap.RowCount - 1
        Next iROW

        Dim total As String = 0
        Dim total1 As String = 0
        Dim total2 As String = 0
        For i As Integer = 0 To DataLaporanBiayaTetap.RowCount - 1
            total += Convert.ToDecimal(DataLaporanBiayaTetap.Rows(i).Cells("penyusutan_unit").Value)
            total1 += Convert.ToDecimal(DataLaporanBiayaTetap.Rows(i).Cells("biaya_listrik_unit").Value)
        Next
        total_penyusutan.Text = Math.Round(Convert.ToDecimal(total), 2)
        total_listrik.Text = Math.Round(Convert.ToDecimal(total1), 2)
        total_biaya_tetap.Text = Math.Round((Convert.ToDecimal(total) + Convert.ToDecimal(total1) + upah_karyawan.Text), 2)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Laporan_sk.Id_produk.Text = CType(id_produk.Text, String)
        Laporan_sk.nama_produk.Text = CType(nama_produk.Text, String)
        Laporan_sk.Show()
        Me.Close()
    End Sub

    Private Sub Laporan_Biaya_Tetap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataLaporanBiayaTetap.Columns("penyusutan").DefaultCellStyle.Format = "n2"
        DataLaporanBiayaTetap.Columns("penyusutan").ValueType = GetType(Double)
        DataLaporanBiayaTetap.Columns("biaya_listrik").DefaultCellStyle.Format = "n2"
        DataLaporanBiayaTetap.Columns("biaya_listrik").ValueType = GetType(Double)
        DataLaporanBiayaTetap.Columns("penyusutan_unit").DefaultCellStyle.Format = "n2"
        DataLaporanBiayaTetap.Columns("penyusutan_unit").ValueType = GetType(Double)
        DataLaporanBiayaTetap.Columns("biaya_listrik_unit").DefaultCellStyle.Format = "n2"
        DataLaporanBiayaTetap.Columns("biaya_listrik_unit").ValueType = GetType(Double)
    End Sub
End Class