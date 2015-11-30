Imports MySql.Data.MySqlClient


Module concrud
    Public Function mysqlkoneksi() As MySqlConnection
        Return New MySqlConnection("server=localhost;database=hpp;uid=root;password=root")
    End Function

    Public konek As MySqlConnection = mysqlkoneksi()
    Public hasil As String
    Public perintah As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Sub loginuser(ByVal sql As String)
        Dim myReader As MySqlDataReader

        Try
            konek.Open()

            With perintah
                .Connection = konek
                .CommandText = sql

                myReader = .ExecuteReader
                myReader.Read()


                If myReader.HasRows Then
                    Beranda.Show()
                    Login.Hide()
                Else
                    MsgBox("Maaf, Username dan Password Anda tidak cocok")
                End If

                myReader.Close()
                konek.Close()
                Login.Password.Text = ""
                Login.Password.Focus()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        konek.Close()

    End Sub

    Public Sub dataload(ByVal sql As String)
        Try
            dt = New DataTable
            konek.Open()

            With perintah
                .Connection = konek
                .CommandText = sql
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        konek.Close()
        da.Dispose()

    End Sub

    Public Sub filltable(ByVal dtg As DataGridView)
        Try
            konek.Open()

            da.SelectCommand = perintah
            'tambah iki i
            dt.Columns.Add("nomor", GetType(Integer))
            dt.Columns("nomor").AutoIncrement = True
            dt.Columns("nomor").AutoIncrementSeed = 1
            'iki
            da.Fill(dt)
            dtg.DataSource = dt
            dtg.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        konek.Close()
        da.Dispose()

    End Sub
 Public Sub fillcombobox(ByVal cb As ComboBox)
        Try
            konek.Open()
            da.SelectCommand = perintah
            da.Fill(dt)

            cb.DataSource = dt
            cb.DisplayMember = dt.Columns(1).ColumnName
            cb.ValueMember = dt.Columns(0).ColumnName
            Dim newRow = dt.NewRow()
            newRow(dt.Columns(0).ColumnName) = 0
            newRow(dt.Columns(1).ColumnName) = "Pilih"
            dt.Rows.Add(newRow)
            dt.DefaultView.Sort = dt.Columns(0).ColumnName + " asc"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        konek.Close()
        da.Dispose()
    End Sub
	
    Public Sub create(ByVal sql As String)
        Try
            konek.Open()

            With perintah
                .Connection = konek
                .CommandText = sql

                hasil = .ExecuteNonQuery


                If hasil = 0 Then
                    MsgBox("Data tidak tersimpan", MsgBoxStyle.Information)
                End If
                MsgBox("Data tersimpan di database")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        konek.Close()
    End Sub

    Public Sub delete(ByVal sql As String)
        Try
            konek.Open()

            With perintah
                .Connection = konek
                .CommandText = sql

                hasil = .ExecuteNonQuery



                If hasil = 0 Then
                    MsgBox("Data gagal dihapus dari database", MsgBoxStyle.Information)
                End If
                MsgBox("Data berhasil dihapus dari database")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        konek.Close()
    End Sub

    Public Sub edit(ByVal sql As String)
        Try
            konek.Open()

            With perintah
                .Connection = konek
                .CommandText = sql

                hasil = .ExecuteNonQuery


                If hasil = 0 Then
                    MsgBox("Data gagal diubah", MsgBoxStyle.Information)
                End If
                MsgBox("Data berhasil diubah")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        konek.Close()
    End Sub

    Public Function selek(ByVal sql As String) As String
        Dim myReader As MySqlDataReader
        Dim hasil_res As String
        hasil_res = "0"
        Try
            konek.Open()

            With perintah
                .Connection = konek
                .CommandText = sql
                myReader = .ExecuteReader()
                If myReader.HasRows Then
                    Do While myReader.Read()
                        hasil_res = myReader.GetString(0)
                    Loop
                Else
                    hasil_res = "0"
                End If

            End With
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        konek.Close()
        Return hasil_res
    End Function

End Module
