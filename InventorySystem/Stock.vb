Imports System.Data.OleDb

Public Class Stock

    Private Sub Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()



    End Sub

    Private Sub btnStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStock.Click
        Try
            Dim sql As String
            Dim cmd As OleDbCommand
            connect()

            sql = "Insert INTO Stock (ItemCode,ItemName,UnitPrice,QuantityRecorded,RegistryDate,AvailableQuantity ) Values (@ItemCode,@ItemName,@UnitPrice,@Qty,@RegistryDate,@AvailableQty ) "
            cmd = New OleDbCommand(sql, conn)
            With cmd.Parameters
                .AddWithValue("@ItemCode", txtItemID.Text)
                .AddWithValue("@ItemName", txtItemName.Text)
                .AddWithValue("@ItemName", txtUnitPrice.Text)
                .AddWithValue("@Qty", txtQtyRecorded.Text)
                .AddWithValue("@RegistryDate", dateRecorded.Text)
                .AddWithValue("@AvailableQty", txtQtyRecorded.Text)

            End With
            If cmd.ExecuteNonQuery() Then
                MsgBox("Details Added Successfully")
                lblInfo.Text = (txtItemName.Text & " " & "Added Successfully!!")
                txtItemID.Text = Nothing
                txtItemName.Text = Nothing
                txtUnitPrice.Text = Nothing
                txtQtyRecorded.Text = Nothing
                dateRecorded.Text = Nothing
            Else
                MessageBox.Show("Alert", "Records Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            conn.Open()
        End Try


    End Sub
    
    Public Sub ClearAll()
        Try
            txtItemID.Text = Nothing
            txtItemName.Text = Nothing
            txtQtyRecorded.Text = Nothing
            txtUnitPrice.Text = Nothing
            lblInfo.Text = ("Fields Cleared Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtpSold_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpSold.ValueChanged
        dateRecorded.Text = dtpSold.Value.Date
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        ClearAll()

    End Sub
End Class