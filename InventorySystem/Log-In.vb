Imports System.Data.OleDb

Public Class Log_In

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        connect()
        Try
            Dim sql As String = "select UserName, UserPassword from LogIn where UserName=@user and UserPassword=@pass"
            Dim cmd As New OleDbCommand(sql, conn)
            With cmd.Parameters
                .AddWithValue("@user", txtUserName.Text)
                .AddWithValue("@pass", txtPassword.Text)

            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            Dim row As Integer = dt.Rows.Count
            If row = 0 Then
                labelCaution.Text = "Sorry You Can't Log In ...Check Your User Name and Password And Try Again!!"
            Else
                txtPassword.Text = Nothing
                txtUserName.Text = Nothing
                Me.Hide()
                Form1.Show()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class