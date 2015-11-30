Imports MySql.Data.MySqlClient

Public Class Tambah_kebutuhan_produk

    Private Sub Button_Simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Simpan.Click
        Dim myReader As MySqlDataReader
        Dim b As Integer = 0
        Try
            konek.Open()

            With perintah
                .Connection = konek
                .CommandText = "SELECT * FROM kebutuhan_produk WHERE id_produk = (SELECT x.id FROM (SELECT MAX(t.id_produk) AS id FROM produk t) x) AND id_kebutuhan = '" + ComboBox_Kebutuhan.SelectedValue.ToString + "'"

                myReader = .ExecuteReader
                myReader.Read()
            End With

            If myReader.HasRows Then
                MsgBox("data sudah ada")
                b = 1
            End If
            konek.Close()

            If b = 0 Then
                create("INSERT INTO kebutuhan_produk (id_produk, id_kebutuhan) VALUES ((SELECT x.id FROM (SELECT MAX(t.id_produk) AS id FROM produk t) x), '" + ComboBox_Kebutuhan.SelectedValue.ToString + "')")
                dataload("SELECT p.id_kebutuhan_produk, k.nama_kebutuhan, k.jenis, k.listrik, k.watt FROM kebutuhan_produk p, kebutuhan k WHERE id_produk = (SELECT x.id FROM (SELECT MAX(t.id_produk) AS id FROM produk t) x) AND k.id_kebutuhan= p.id_kebutuhan")
                filltable(Kebutuhan_produk.DataKebutuhanProduk)
                Kebutuhan_produk.Show()
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button_Batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Batal.Click
        Kebutuhan_produk.Show()
        Me.Close()
    End Sub

    Private Sub Tambah_kebutuhan_produk_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            dataload("SELECT * FROM kebutuhan")

            'TextBox1.DataBindings.Add("Text", dt, "fieldName to show in textbox")
            fillcombobox(ComboBox_Kebutuhan)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class