Imports System.Data.OleDb

Module ModConn
    Public constring As String = "provider=microsoft.jet.oledb.4.0; data source=" & Application.StartupPath & "\InventorySystem.mdb"
    Public conn As OleDbConnection

    Public dt As New DataTable
    Public da As New OleDbDataAdapter
    Public dr As OleDbDataReader
    Public reader As OleDbDataReader

    Public Sub connect()
        Try
            conn = New OleDbConnection(constring)
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub selectAllITemsForSales()
        Try
            Dim sql As String = "select ItemName from Stock"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                CashSales.cboItemName.Items.Add(reader("ItemName"))
            End While
        Catch ex As Exception

        End Try
    End Sub
    Public Sub selectStockForUpdate()
        Try
            Dim sql As String = "select * from Stock"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                UpdateStock.cboItemName.Items.Add(reader("ItemName"))
            End While
        Catch ex As Exception

        End Try
    End Sub
    Public Sub selectAllITemsForCreditSales()
        Try
            Dim sql As String = "select ItemName from Stock"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                CreditSales.cboItemName.Items.Add(reader("ItemName"))
            End While
        Catch ex As Exception

        End Try

    End Sub
    Public Sub selectAllSalesPersons()
        Try
            connect()
            Dim sql As String = "select PersonName from SalesPersons"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                OilForm.cboSelectSalesPerson.Items.Add(reader("PersonName"))
            End While
        Catch ex As Exception

        End Try

    End Sub
    Public Sub selectAllStock()
        Try
            connect()
            Dim sql As String = "select ItemName from Stock"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                OilForm.cbo1litre.Items.Add(reader("ItemName"))
                OilForm.cbo2litre.Items.Add(reader("ItemName"))
                OilForm.cbo5litre.Items.Add(reader("ItemName"))
            End While
        Catch ex As Exception

        End Try

    End Sub
    Public Sub selectStockPrices()
        Try
            connect()
            Dim sql As String = "select UnitPrice from Stock"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                OilForm.cboSelectSalesPerson.Items.Add(reader("PersonName"))
            End While
        Catch ex As Exception

        End Try

    End Sub

    Public Sub updateQtyCashSales()
        Try
            Dim sql As String = "update Stock set [AvailableQuantity]='" & CashSales.txtAvailableQty.Text & "' where [ItemName]='" & CashSales.cboItemName.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub updateQtyOnStockUpdate()
        Try
            Dim sql As String = "update Stock set [AvailableQuantity]='" & UpdateStock.txtNewStockBal.Text & "' where [ItemName]='" & UpdateStock.cboItemName.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            If command.ExecuteNonQuery() Then
                MsgBox(UpdateStock.cboItemName.Text & " " & "Stock Updated Successfully")
                UpdateStock.txtAvailableQty.Text = Nothing
                UpdateStock.txtInputBal.Text = Nothing
                UpdateStock.txtNewStockBal.Text = Nothing
                UpdateStock.txtItemCode.Text = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub updateQtyCreditSales()
        Try
            Dim sql As String = "update Stock set [AvailableQuantity]='" & CreditSales.txtAvailableQty.Text & "' where [ItemName]='" & CreditSales.cboItemName.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub selectCustomerName()
        Try
            Dim sql As String = "select CustomerName from CreditSales"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                DebtorsForm.cboSalesPersonsName.Items.Add(reader("CustomerName"))
            End While
        Catch ex As Exception

        End Try
    End Sub
    Public Sub AddTimeToCreditSales()
        Dim nameAndTime As String
        nameAndTime = CreditSales.txtCustomerName.Text & CreditSales.txtTimeOfCreditSales.Text
        Try
            Dim sql As String = "update CreditSales set [CustomerName]='" & nameAndTime & "' where [ItemName]='" & CreditSales.cboItemName.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            command.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub
    Public Sub UpdateCreditBalance()
        connect()
        Dim CustomerNameandTime As String = DebtorsForm.cboSalesPersonsName.Text
        Try
            Dim sql As String = "update CreditSales set [TotalAmount]='" & DebtorsForm.txtNewAmountOwing.Text & "' where [CustomerName]='" & CustomerNameandTime & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            If command.ExecuteNonQuery() Then
                MsgBox("New Balance Owing Updated In Credit Sales")
            Else
                MsgBox("Failed")
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub RecordCreditPaymentToSales()
        Try
            Dim sql As String
            Dim cmd As OleDbCommand
            connect()

            sql = "Insert INTO CashSales (CustomerName,PurchaseDate,TotalAmount ) Values (@CustomerName,@PurchaseDate,@TotalAmount ) "
            cmd = New OleDbCommand(sql, conn)
            With cmd.Parameters
                .AddWithValue("@CustomerName", DebtorsForm.cboSalesPersonsName.Text)
                .AddWithValue("@PurchaseDate", DebtorsForm.txtDateOfPayment.Text)
                .AddWithValue("@TotalAmount", DebtorsForm.txtAcceptPayment.Text)
            End With
            Try
                If cmd.ExecuteNonQuery() Then
                    MsgBox("Sales Made Successfully")
                Else
                    MessageBox.Show("Alert", "Error In Saving", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Public Sub updatePriceOnStockUpdate()
        Try
            Dim sql As String = "update Stock set [UnitPrice]='" & UpdateStock.txtNewPrice.Text & "' where [ItemName]='" & UpdateStock.cboItemName.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            If command.ExecuteNonQuery() Then
                MsgBox(UpdateStock.cboItemName.Text & " " & "Price Updated Successfully")
                UpdateStock.txtNewPrice.Text = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub update1LitStock()
        Try
            Dim sql As String = "update Stock set [AvailableStock]='" & OilForm.txtAvailableQty1Lit.Text & "' where [ItemName]='" & OilForm.cbo1litre.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            If command.ExecuteNonQuery() Then
                'MsgBox(UpdateStock.cboItemName.Text & " " & "1 Litre Qty Updated Successfully")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Updating Quantity on 1 litre stock after credit sales
    Public Sub update1LitStockOnCreditSales()
        Try
            connect()
            Dim sql As String = "update Stock set [AvailableQuantity]='" & OilForm.txtAvailableQty1Lit.Text & "' where [ItemName]='" & OilForm.cbo1litre.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            If command.ExecuteNonQuery() Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Updating Quantity on 250 stock after credit sales
    Public Sub update250gStockOnCreditSales()
        Try
            connect()
            Dim sql As String = "update Stock set [AvailableQuantity]='" & SaltForm.txtAvailableQty250g.Text & "' where [ItemName]='" & SaltForm.cbo250g.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            If command.ExecuteNonQuery() Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Updating Quantity on 500 stock after credit sales
    Public Sub update500gStockOnCreditSales()
        Try
            connect()
            Dim sql As String = "update Stock set [AvailableQuantity]='" & SaltForm.txtAvailableQty500g.Text & "' where [ItemName]='" & SaltForm.cbo500g.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            If command.ExecuteNonQuery() Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Updating Quantity on 1kg stock after credit sales
    Public Sub update1kgStockOnCreditSales()
        Try
            connect()
            Dim sql As String = "update Stock set [AvailableQuantity]='" & SaltForm.txtAvailableQty1kg.Text & "' where [ItemName]='" & SaltForm.cbo1kg.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            If command.ExecuteNonQuery() Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Updating Quantity on 2 litre stock after credit sales
    Public Sub update2LitStockOnCreditSales()
        Try
            connect()
            Dim sql As String = "update Stock set [AvailableQuantity]='" & OilForm.txtAvailableQty2Lit.Text & "' where [ItemName]='" & OilForm.cbo2litre.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            If command.ExecuteNonQuery() Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Updating Quantity on 5 litre stock after credit sales
    Public Sub update5LitStockOnCreditSales()
        Try
            connect()
            Dim sql As String = "update Stock set [AvailableQuantity]='" & OilForm.txtAvailableQty5Lit.Text & "' where [ItemName]='" & OilForm.cbo5litre.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            If command.ExecuteNonQuery() Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Module
