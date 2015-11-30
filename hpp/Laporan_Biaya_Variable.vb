Public Class Laporan_Biaya_Variable

    Private Sub Laporan_Biaya_Variable_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            dataload("SELECT k.nama_kebutuhan, k.satuan, ks.jumlah, k.harga_kebutuhan, ( ks.jumlah *  k.harga_kebutuhan) as total FROM kebutuhan k, kebutuhan_sk ks, kebutuhan_produk kp, sk_produk sp WHERE kp.id_produk = '" + Id_produk.Text + "' AND sp.id_sk_produk = '" + id_sk_produk.Text + "' AND k.jenis = 'bahan' AND k.id_kebutuhan = kp.id_kebutuhan AND kp.id_kebutuhan_produk = ks.id_kebutuhan_produk AND ks.id_sk_produk = sp.id_sk_produk")
            filltable(DataLaporanBiayaVariable)
            'Data_Kebutuhan_Sk.Columns(0).Visible = False
            DataLaporanBiayaVariable.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        For iROW = 0 To DataLaporanBiayaVariable.RowCount - 1
        Next iROW

        Dim total As String = 0
      
        For i As Integer = 0 To DataLaporanBiayaVariable.RowCount - 1
            total += Convert.ToDecimal(DataLaporanBiayaVariable.Rows(i).Cells("total").Value)

        Next
        total_biaya_variable.Text = Math.Round(Convert.ToDecimal(total), 2)
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Laporan_sk.Id_produk.Text = CType(Id_produk.Text, String)
        Laporan_sk.nama_produk.Text = CType(nama_produk.Text, String)
        Laporan_sk.Show()
        Me.Close()
    End Sub

    
    Private Sub Laporan_Biaya_Variable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataLaporanBiayaVariable.Columns("total").DefaultCellStyle.Format = "n2"
        DataLaporanBiayaVariable.Columns("total").ValueType = GetType(Double)

    End Sub
End Class