Imports System.Data.OleDb

Public Class CreateSalesPerson

    Private Sub CreateSalesPerson_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim sql As String
            Dim cmd As OleDbCommand
            connect()

            sql = "Insert INTO SalesPersons (PersonName,Contact,Sex ) Values (@PersonName, @Contact,@Sex ) "
            cmd = New OleDbCommand(sql, conn)

            With cmd.Parameters
                .AddWithValue("@PersonName", txtSalesPersonName.Text)
                .AddWithValue("@Contact", txtContact.Text)
                .AddWithValue("@Sex", cboSex.Text)
            End With
            If cmd.ExecuteNonQuery() Then
                MsgBox("Sales Person Created Successfully")
                txtSalesPersonName.Text = Nothing
                txtContact.Text = ""
                cboSex.Text = Nothing
            Else
                MessageBox.Show("Alert", "Sales Person Not Created", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class