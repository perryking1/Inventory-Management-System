Imports System.Data.OleDb

Public Class CashSales
    Dim quant As Integer

    Private Sub Sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MdiParent = Form1
        txtDateSold.Text = dtpSold.Value.Date

        Dim sql As String
        Dim cmd As OleDbCommand
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        connect()
        selectAllITemsForSales()
        sql = "Select * from CashSales"
        cmd = New OleDbCommand(sql, conn)
        da.SelectCommand = cmd
        da.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()



    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, Label3.Click, Label2.Click, Label4.Click, Label6.Click, Label7.Click

    End Sub

    Private Sub btnSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSales.Click
        Try
          
            Dim sql As String
            Dim cmd As OleDbCommand
            connect()

            sql = "Insert INTO CashSales (ItemCode,ItemName,CustomerName,CustomerContact,UnitPrice,QuantityBought,PurchaseDate,TotalAmount ) Values (@ItemCode,@ItemName,@CustomerName,@CustomerContact,@UnitPrice,@QuantityBought,@PurchaseDate,@TotalAmount ) "
            cmd = New OleDbCommand(sql, conn)
            With cmd.Parameters
                .AddWithValue("@ItemCode", txtItemCode.Text)
                .AddWithValue("@ItemName", cboItemName.Text)
                .AddWithValue("@CustomerName", txtCustomerName.Text)
                .AddWithValue("@CustomerContact", txtCustomerContact.Text)
                .AddWithValue("@UnitPrice", txtUnitPrice.Text)
                .AddWithValue("@QuantityBought", txtQuantityBought.Text)
                .AddWithValue("@PurchaseDate", txtDateSold.Text)
                .AddWithValue("@TotalAmount", txtTotalAmount.Text)

            End With
            Try
                If cmd.ExecuteNonQuery() Then
                    MsgBox("Sales Made Successfully")
                Else
                    MessageBox.Show("Alert", "Error In Saving", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                lblNotice.Text = Nothing

                DataGridView1.Refresh()
            End Try

        Catch ex As Exception

        End Try
        updateQtyCashSales()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Refresh()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            connect()
            Dim sql As String = "select ItemCode,ItemName,Price from Register"
            Dim cmd As New OleDbCommand(sql, conn)
            Dim da As New OleDbDataAdapter

            Dim dt As New DataTable

            da.SelectCommand = cmd
            da.Fill(dt)

            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dtpSold_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpSold.ValueChanged
        txtDateSold.Text = dtpSold.Value.Date
    End Sub

    Private Sub cmbItemName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub cboItemName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboItemName.SelectedIndexChanged
        Try
            connect()
            Dim sql As String = "select * from Stock where ItemName ='" & cboItemName.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                txtItemCode.Text = reader("ItemCode")
                txtUnitPrice.Text = reader("UnitPrice")
                txtAvailableQty.Text = reader("AvailableQuantity")
            End While
        Catch ex As Exception

        Finally
            quant = txtAvailableQty.Text
        End Try
        If txtAvailableQty.Text <= 0 Then
            txtQuantityBought.Hide()
            txtAvailableQty.BackColor = Color.Red
            txtAvailableQty.ForeColor = Color.White
            lblNotice.ForeColor = Color.Red
            lblNotice.Text = "Run Out Of Stock For Item" & " " & cboItemName.Text
        ElseIf txtAvailableQty.Text = 1 Then
            txtQuantityBought.Text = 1
            txtQuantityBought.ReadOnly = True
        Else
            txtQuantityBought.Show()
            txtQuantityBought.ReadOnly = False
            txtAvailableQty.ForeColor = Color.Black
            txtAvailableQty.BackColor = Color.White
        End If
    End Sub

    Private Sub txtQuantityBought_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantityBought.GotFocus
        txtAvailableQty.Text = ""
        txtAvailableQty.Text = quant
        txtTotalAmount.Text = Nothing
    End Sub

    Private Sub txtQuantityBought_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantityBought.LostFocus

        Try
            Dim total As Double
            total = txtQuantityBought.Text * txtUnitPrice.Text
            txtTotalAmount.Text = total

            Dim balance As Integer
            Dim quant As Integer = CInt(txtQuantityBought.Text)
            balance = txtAvailableQty.Text - quant
            txtAvailableQty.Text = balance
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtQuantityBought_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantityBought.TextChanged

    End Sub
End Class