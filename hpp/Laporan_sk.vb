Public Class Laporan_sk

    Private Sub Laporan_sk_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            dataload("SELECT p.id_sk_produk, s.nama_sk, p.waktu, p.jumlah_pekerja, p.upah FROM sk s, sk_produk p where p.id_produk=" + Id_produk.Text + " AND p.id_sk=s.id_sk")
            'DataLaporanSK.Columns.Item(0).DefaultCellStyle.Format = "n2"
            'Me.DataLaporanSK.Columns.Item(9).ValueType = GetType(Double)
            filltable(DataLaporanSK)
            'Data_Kebutuhan_Sk.Columns(0).Visible = False
            DataLaporanSK.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        For iROW = 0 To DataLaporanSK.RowCount - 1
            Try
                DataLaporanSK.Rows(iROW).Cells("upah_karyawan").Value = (CType(DataLaporanSK.Rows(iROW).Cells("upah").Value, String) * CType(DataLaporanSK.Rows(iROW).Cells("waktu").Value, String) / CType(DataLaporanSK.Rows(iROW).Cells("jumlah_pekerja").Value, String)) * (1 / 26) * (1 / 8) * (1 / 60)
                'DataLaporanSK.Rows(iROW).Cells("biaya_proses").Value = Convert.ToDecimal(selek("SELECT ((SUM((k.harga_kebutuhan / k.umur_pemakaian) *(1/26)*(1/8)*(1/60)*ks.jumlah)+ SUM(((k.watt*ks.jumlah*1115)/1000)*(1/60)) + ((sp.upah/sp.jumlah_pekerja)*(1/26)*(1/8)*(1/60)))*sp.waktu)as biaya_tetap FROM kebutuhan k, kebutuhan_sk ks, kebutuhan_produk kp, sk_produk sp WHERE kp.id_produk = " + Id_produk.Text + " AND sp.id_sk_produk = " + CType(DataLaporanSK.Rows(iROW).Cells("id_sk_produk").Value, String) + " AND k.jenis = 'alat' AND k.id_kebutuhan = kp.id_kebutuhan AND kp.id_kebutuhan_produk = ks.id_kebutuhan_produk AND ks.id_sk_produk = sp.id_sk_produk"))
                DataLaporanSK.Rows(iROW).Cells("biaya_proses").Value = Convert.ToDecimal(selek("SELECT ((SUM((k.harga_kebutuhan / k.umur_pemakaian) *(1/26)*(1/8)*(1/60)*ks.jumlah)+ SUM(((k.watt*ks.jumlah*1115)/1000)*(1/60)))*sp.waktu)as biaya_tetap FROM kebutuhan k, kebutuhan_sk ks, kebutuhan_produk kp, sk_produk sp WHERE kp.id_produk = " + Id_produk.Text + " AND sp.id_sk_produk = " + CType(DataLaporanSK.Rows(iROW).Cells("id_sk_produk").Value, String) + " AND k.jenis = 'alat' AND k.id_kebutuhan = kp.id_kebutuhan AND kp.id_kebutuhan_produk = ks.id_kebutuhan_produk AND ks.id_sk_produk = sp.id_sk_produk")) + Convert.ToDecimal(CType(DataLaporanSK.Rows(iROW).Cells("upah_karyawan").Value, String))
                DataLaporanSK.Rows(iROW).Cells("biaya_tetap").Value = CType(DataLaporanSK.Rows(iROW).Cells("biaya_proses").Value, String) / CType(DataLaporanSK.Rows(iROW).Cells("waktu").Value, String)
                DataLaporanSK.Rows(iROW).Cells("biaya_kebutuhan").Value = Convert.ToDecimal(selek("SELECT SUM(ks.jumlah *  k.harga_kebutuhan) as biaya_kebutuhan FROM kebutuhan k, kebutuhan_sk ks, kebutuhan_produk kp, sk_produk sp WHERE kp.id_produk = " + Id_produk.Text + " AND sp.id_sk_produk = " + CType(DataLaporanSK.Rows(iROW).Cells("id_sk_produk").Value, String) + " AND k.jenis = 'bahan' AND k.id_kebutuhan = kp.id_kebutuhan AND kp.id_kebutuhan_produk = ks.id_kebutuhan_produk AND ks.id_sk_produk = sp.id_sk_produk"))
                DataLaporanSK.Rows(iROW).Cells("biaya_sk").Value = Convert.ToDecimal(CType(DataLaporanSK.Rows(iROW).Cells("biaya_proses").Value, String)) + Convert.ToDecimal(CType(DataLaporanSK.Rows(iROW).Cells("biaya_kebutuhan").Value, String))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next iROW

        Dim total As String = 0
        Dim total1 As String = 0
        Dim total2 As String = 0
        Dim total3 As String = 0
        For i As Integer = 0 To DataLaporanSK.RowCount - 1
            total += Convert.ToDecimal(DataLaporanSK.Rows(i).Cells("waktu").Value)
            total1 += Convert.ToDecimal(DataLaporanSK.Rows(i).Cells("biaya_kebutuhan").Value)
            total2 += Convert.ToDecimal(DataLaporanSK.Rows(i).Cells("biaya_tetap").Value)
            total3 += Convert.ToDecimal(DataLaporanSK.Rows(i).Cells("biaya_proses").Value)
        Next
        total_waktu.Text = Math.Round(Convert.ToDecimal(total), 2)
        total_biaya_variable.Text = Math.Round(Convert.ToDecimal(total1), 2)
        total_biaya_proses.Text = Math.Round(Convert.ToDecimal(total3), 2)
        total_biaya_tetap.Text = Math.Round(Convert.ToDecimal(total2), 2)
        hpp.Text = Math.Round((Convert.ToDecimal(total_biaya_proses.Text) + Convert.ToDecimal(total_biaya_variable.Text)), 2)
        harga_jual.Text = Math.Round((hpp.Text + hpp.Text * (15 / 100)), 2)



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Laporan_Biaya_Tetap.id_sk_produk.Text = CType(DataLaporanSK.CurrentRow.Cells("id_sk_produk").Value, String)
        Laporan_Biaya_Tetap.nama_sk.Text = CType(DataLaporanSK.CurrentRow.Cells("nama_sk").Value, String)
        Laporan_Biaya_Tetap.upah_karyawan.Text = CType(DataLaporanSK.CurrentRow.Cells("upah_karyawan").Value, String)

        Laporan_Biaya_Tetap.id_produk.Text = CType(Id_produk.Text, String)
        Laporan_Biaya_Tetap.nama_produk.Text = CType(nama_produk.Text, String)
        Laporan_Biaya_Tetap.no_sk.Text = "(" + CType(DataLaporanSK.CurrentRow.Cells("nomor").Value, String) + ")"
        Laporan_Biaya_Tetap.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Laporan_Biaya_Variable.id_sk_produk.Text = CType(DataLaporanSK.CurrentRow.Cells("id_sk_produk").Value, String)
        Laporan_Biaya_Variable.nama_sk.Text = CType(DataLaporanSK.CurrentRow.Cells("nama_sk").Value, String)
        Laporan_Biaya_Variable.Id_produk.Text = CType(Id_produk.Text, String)
        Laporan_Biaya_Variable.nama_produk.Text = CType(nama_produk.Text, String)
        Laporan_Biaya_Variable.no_sk.Text = "(" + CType(DataLaporanSK.CurrentRow.Cells("nomor").Value, String) + ")"
        Laporan_Biaya_Variable.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Laporan.Show()
        Me.Close()
    End Sub

    
    Private Sub Laporan_sk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DataLaporanSK.Columns.Item(0).DefaultCellStyle.Format = "n2"
        'DataLaporanSK.Columns.Item(0).ValueType = GetType(Double)

        DataLaporanSK.Columns("upah_karyawan").DefaultCellStyle.Format = "n2"
        DataLaporanSK.Columns("upah_karyawan").ValueType = GetType(Double)

        DataLaporanSK.Columns("biaya_tetap").DefaultCellStyle.Format = "n2"
        DataLaporanSK.Columns("biaya_tetap").ValueType = GetType(Double)

        DataLaporanSK.Columns("biaya_proses").DefaultCellStyle.Format = "n2"
        DataLaporanSK.Columns("biaya_proses").ValueType = GetType(Double)

        DataLaporanSK.Columns("biaya_sk").DefaultCellStyle.Format = "n2"
        DataLaporanSK.Columns("biaya_sk").ValueType = GetType(Double)

        DataLaporanSK.Columns("biaya_kebutuhan").DefaultCellStyle.Format = "n2"
        DataLaporanSK.Columns("biaya_kebutuhan").ValueType = GetType(Double)

        'total_biaya_proses.Text = Decimal.Round(Convert.ToDecimal(total_biaya_proses.Text), 2).ToString()
        ' Math.Round(Convert.ToDecimal(total_biaya_proses.Text), 2)



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        
        Total_harga.id_produk.Text = CType(Id_produk.Text, String)
        Total_harga.harga_jual.Text = CType(harga_jual.Text, String)
        Total_harga.nama_produk.Text = CType(nama_produk.Text, String)

        Total_harga.ShowDialog()
    End Sub
End Class