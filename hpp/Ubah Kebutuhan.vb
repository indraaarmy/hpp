Public Class Ubah_Kebutuhan

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Kebutuhan.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            edit("UPDATE kebutuhan SET nama_kebutuhan = '" + nama_kebutuhan.Text + "', harga_kebutuhan = '" + harga_kebutuhan.Text + "',satuan = '" + satuan.Text + "',jenis = '" + Jenis.Text + "',listrik = '" + Listrik.Text + "',watt = '" + Watt.Text + "',Umur_pemakaian = '" + Umur_pemakaian.Text + "' WHERE id_kebutuhan = '" + id_kebutuhan.Text + "'")
            dataload("SELECT id_kebutuhan, nama_kebutuhan, harga_kebutuhan, satuan, jenis, listrik, watt, umur_pemakaian  FROM kebutuhan")
            filltable(Kebutuhan.DataKebutuhan)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class