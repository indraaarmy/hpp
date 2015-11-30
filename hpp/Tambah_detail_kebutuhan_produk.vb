Imports MySql.Data.MySqlClient

Public Class Tambah_detail_kebutuhan_produk

    Private Sub Button_Batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Batal.Click
        Me.Close()

    End Sub

    Private Sub Button_Simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Simpan.Click
        Dim myReader As MySqlDataReader
        Dim b As Integer = 0
        Try
            konek.Open()

            With perintah
                .Connection = konek
                .CommandText = "SELECT * FROM kebutuhan_produk WHERE id_produk = '" + Id_Produk.Text + "' AND id_kebutuhan = '" + ComboBox1.SelectedValue.ToString + "'"

                myReader = .ExecuteReader
                myReader.Read()
            End With

            If myReader.HasRows Then
                MsgBox("data sudah ada")
                b = 1
            End If
            konek.Close()

            If b = 0 Then
                create("INSERT INTO kebutuhan_produk (id_produk, id_kebutuhan) VALUES ('" + Id_Produk.Text + "', '" + ComboBox1.SelectedValue.ToString + "')")
                dataload("SELECT kp.id_kebutuhan_produk, kp.id_produk, kp.id_kebutuhan , k.nama_kebutuhan,k.satuan,k.jenis, k.watt,k.umur_pemakaian, SUM(ks.jumlah) as jumlah FROM kebutuhan k, kebutuhan_produk kp LEFT JOIN kebutuhan_sk ks ON kp.id_kebutuhan_produk = ks.id_kebutuhan_produk WHERE id_produk='" + Id_Produk.Text + "' and k.id_kebutuhan = kp.id_kebutuhan GROUP BY k.id_kebutuhan")
                filltable(Detail_kebutuhan.Data_Kebutuhan_Produk)
                'Detail_kebutuhan.Data_Kebutuhan_Produk.Columns(0).Visible = False
                'Detail_kebutuhan.Data_Kebutuhan_Produk.Columns(1).Visible = False
                Detail_kebutuhan.Show()
                'Detail_kebutuhan.Label2.Text = ComboBox1.SelectedValue
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Tambah_detail_kebutuhan_produk_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            dataload("SELECT * FROM kebutuhan")

            'TextBox1.DataBindings.Add("Text", dt, "fieldName to show in textbox")
            fillcombobox(ComboBox1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class