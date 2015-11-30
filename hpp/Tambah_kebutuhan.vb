Public Class Tambah_kebutuhan

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Kebutuhan.Show()
        Me.Close()

    End Sub

    Private Sub Button_Simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Simpan.Click
        Try
            create("INSERT INTO kebutuhan (nama_kebutuhan, harga_kebutuhan, satuan,jenis,listrik,watt, umur_pemakaian) VALUES ('" + Nama_Kebutuhan.Text + "', '" + Harga_Kebutuhan.Text + "', '" + Satuan.Text + "', '" + Jenis.Text + "', '" + Listrik.Text + "', '" + Watt.Text + "', '" + Umur_pemakaian.Text + "')")
            dataload("SELECT id_kebutuhan, nama_kebutuhan, harga_kebutuhan, satuan, jenis, listrik, watt, umur_pemakaian  FROM kebutuhan")
            filltable(Kebutuhan.DataKebutuhan)
            Kebutuhan.Show()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   

End Class