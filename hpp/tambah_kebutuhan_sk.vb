Imports MySql.Data.MySqlClient
Public Class tambah_kebutuhan_sk

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim myReader As MySqlDataReader
        Dim b As Integer = 0
        Try
            konek.Open()

            With perintah
                .Connection = konek
                .CommandText = "SELECT * FROM kebutuhan_sk WHERE id_sk_produk = '" + id_sk_produk.Text + "' AND id_kebutuhan_produk = '" + ComboBox_tambah_kebutuhan_sk.SelectedValue.ToString + "'"

                myReader = .ExecuteReader
                myReader.Read()
            End With

            If myReader.HasRows Then
                MsgBox("data sudah ada")
                b = 1
            End If
            konek.Close()

            If b = 0 Then
                create("INSERT INTO kebutuhan_sk (id_kebutuhan_produk, id_sk_produk, jumlah) VALUES ('" + ComboBox_tambah_kebutuhan_sk.SelectedValue.ToString + "' ,'" + id_sk_produk.Text + "','" + Jumlah.Text + "')")
                dataload("SELECT s.id_kebutuhan_sk, k.nama_kebutuhan, s.jumlah FROM kebutuhan_sk s,kebutuhan_produk p, kebutuhan k where s.id_sk_produk = " + id_sk_produk.Text + " AND p.id_kebutuhan_produk = s.id_kebutuhan_produk AND p.id_kebutuhan= k.id_kebutuhan")
                filltable(Kebutuhan_sk.Data_sk_kebutuhan)
                Kebutuhan_sk.Show()
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tambah_kebutuhan_sk_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            dataload("SELECT p.id_kebutuhan_produk, k.nama_kebutuhan FROM kebutuhan k, kebutuhan_produk p where id_produk = '" + id_produk.Text + "' AND k.id_kebutuhan = p. id_kebutuhan")
            fillcombobox(ComboBox_tambah_kebutuhan_sk)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
   
End Class