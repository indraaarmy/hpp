Public Class Login

    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        Try
            loginuser("SELECT * FROM user WHERE username='" + Username.Text + "' AND password='" + Password.Text + "'")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
