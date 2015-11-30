﻿Public Class TQC

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim iROW As Integer
        create("INSERT INTO sk_produk (id_produk,id_sk, waktu, jumlah_pekerja, upah) VALUES ( ( SELECT x.id FROM (SELECT MAX(t.id_produk) AS id FROM produk t) x),9,'" + waktu.Text + "','" + jumlah_pekerja.Text + "','" + upah.Text + "')")
        For iROW = 0 To DataKebutuhanProduk.RowCount - 1
            If DataKebutuhanProduk.Rows(iROW).Cells("pilih").Value Then
                Try
                    create("INSERT INTO kebutuhan_sk (id_kebutuhan_produk, id_sk_produk) VALUES ('" + CType(DataKebutuhanProduk.Rows(iROW).Cells(2).Value, String) + "', (SELECT x.id FROM (SELECT MAX(t.id_sk_produk) AS id FROM sk_produk t) x))")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Next iROW
        Produk.Show()
        Me.Close()
        dataload("SELECT p.id_produk, p.nama_produk, SUM(sp.waktu) as waktu FROM produk p LEFT JOIN sk_produk sp ON p.id_produk = sp.id_produk GROUP BY p.id_produk")
        filltable(Produk.DataProduk)
        Produk.DataProduk.Columns(0).Visible = False
        Produk.DataProduk.ClearSelection()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        delete("DELETE FROM kebutuhan_sk where id_kebutuhan_sk IN (SELECT y.id FROM (SELECT ks.id_kebutuhan_sk AS id FROM produk p, kebutuhan_produk kp, kebutuhan_sk ks WHERE(p.id_produk = kp.id_produk) AND kp.id_kebutuhan_produk = ks.id_kebutuhan_produk AND p.id_produk = (SELECT x.id FROM (SELECT MAX(t.id_produk) AS id FROM kebutuhan_produk t) x)) y)")
        delete("DELETE FROM sk_produk WHERE id_produk = (SELECT x.id FROM (SELECT MAX(t.id_produk) AS id FROM kebutuhan_produk t) x)")
        delete("DELETE FROM kebutuhan_produk WHERE id_produk = (SELECT x.id FROM (SELECT MAX(t.id_produk) AS id FROM kebutuhan_produk t) x)")
        delete("DELETE FROM produk WHERE id_produk = (SELECT x.id FROM (SELECT MAX(t.id_produk) AS id FROM produk t) x)")
        Produk.Show()
        Me.Close()
    End Sub

    Private Sub TQC_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            dataload("SELECT p.id_kebutuhan_produk as id, k.nama_kebutuhan as Kebutuhan FROM kebutuhan_produk p, kebutuhan k WHERE id_produk = (SELECT x.id FROM (SELECT MAX(t.id_produk) AS id FROM produk t) x) AND k.id_kebutuhan= p.id_kebutuhan")
            filltable(DataKebutuhanProduk)
            DataKebutuhanProduk.Columns(1).Visible = False
            DataKebutuhanProduk.Columns(2).Visible = False
            DataKebutuhanProduk.Columns(2).ReadOnly = True
            DataKebutuhanProduk.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class