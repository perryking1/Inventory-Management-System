Imports System.Data.OleDb

Public Class UpdateStock
    Dim inputQuant As Integer

    Private Sub cboItemName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItemName.SelectedIndexChanged
        Try
            connect()
            Dim sql As String = "select * from Stock where ItemName ='" & cboItemName.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                txtItemCode.Text = reader("ItemCode")
                txtAvailableQty.Text = reader("AvailableQuantity")
                txtNewPrice.Text = reader("UnitPrice")
            End While
        Catch ex As Exception

        Finally

        End Try
    End Sub

    Private Sub UpdateStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        connect()
        selectStockForUpdate()


    End Sub

    Private Sub txtInputBal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInputBal.GotFocus, txtNewPrice.GotFocus
        Try

            inputQuant = txtAvailableQty.Text
            txtAvailableQty.Text = ""
            txtAvailableQty.Text = inputQuant

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub

    Private Sub txtInputBal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInputBal.LostFocus, txtNewPrice.LostFocus
        Try
            Dim totalQuant As Integer
            totalQuant = (txtInputBal.Text + inputQuant)
            txtNewStockBal.Text = totalQuant
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub txtInputBal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInputBal.TextChanged, txtNewPrice.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        connect()
        updateQtyOnStockUpdate()
        updatePriceOnStockUpdate()


    End Sub
End Class