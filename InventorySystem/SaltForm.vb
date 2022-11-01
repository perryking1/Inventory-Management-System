Imports System.Data.OleDb

Public Class SaltForm
    Dim AvailableQuant250g As Double
    Dim AvailableQuant500g As Double
    Dim AvailableQuant1kg As Double

    Private Sub SaltForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        connect()
        Try
            connect()
            Dim sql As String = "select PersonName from SalesPersons"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                cboSelectSalesPerson.Items.Add(reader("PersonName"))
            End While
        Catch ex As Exception

        End Try
        Try
            connect()
            Dim sql As String = "select ItemName from Stock"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                cbo250g.Items.Add(reader("ItemName"))
                cbo500g.Items.Add(reader("ItemName"))
                cbo1kg.Items.Add(reader("ItemName"))
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbo250g_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo250g.SelectedIndexChanged
        Try
            connect()
            Dim sql As String = "select * from Stock where ItemName ='" & cbo250g.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                txt250gUPrice.Text = reader("UnitPrice")
                txtAvailableQty250g.Text = reader("AvailableQuantity")
            End While
        Catch ex As Exception

        Finally
            AvailableQuant250g = txtAvailableQty250g.Text
        End Try
    End Sub

    Private Sub cbo500g_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo500g.SelectedIndexChanged
        Try
            connect()
            Dim sql As String = "select * from Stock where ItemName ='" & cbo500g.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                txt500gUPrice.Text = reader("UnitPrice")
                txtAvailableQty500g.Text = reader("AvailableQuantity")
            End While
        Catch ex As Exception

        Finally
            AvailableQuant500g = txtAvailableQty500g.Text
        End Try
    End Sub

    Private Sub cbo1kg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo1kg.SelectedIndexChanged
        Try
            connect()
            Dim sql As String = "select * from Stock where ItemName ='" & cbo1kg.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                txt1kgUPrice.Text = reader("UnitPrice")
                txtAvailableQty1kg.Text = reader("AvailableQuantity")
            End While
        Catch ex As Exception

        Finally
            AvailableQuant1kg = txtAvailableQty1kg.Text
        End Try
    End Sub

    Private Sub cboSelectSalesPerson_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelectSalesPerson.SelectedIndexChanged
        Try
            connect()
            Dim sql As String = "select Contact from SalesPersons where PersonName ='" & cboSelectSalesPerson.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                txtSalesPersonContact.Text = reader("Contact")
            End While
        Catch ex As Exception

        Finally

        End Try
    End Sub

    Private Sub dtpCurrentDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCurrentDate.ValueChanged
        txtDate.Text = dtpCurrentDate.Value.Date
    End Sub

    Private Sub txt250gQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt250gQty.GotFocus
        txtAvailableQty250g.Text = ""
        txtAvailableQty250g.Text = AvailableQuant250g
    End Sub

    Private Sub txt250gQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt250gQty.LostFocus
        If txt250gUPrice.Text = Nothing Then
            MessageBox.Show("Please Select an item to display the price")
        Else
            Dim totalPriceFor250g As Double
            totalPriceFor250g = txt250gQty.Text * txt250gUPrice.Text
            txt250gTotalAmount.Text = totalPriceFor250g
        End If
        Dim balance As Double
        AvailableQuant250g = txtAvailableQty250g.Text
        balance = (AvailableQuant250g - txt250gQty.Text)
        txtAvailableQty250g.Text = balance
    End Sub

    Private Sub txt250gQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt250gQty.TextChanged

    End Sub

    Private Sub txt500gQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt500gQty.GotFocus
        txtAvailableQty500g.Text = ""
        txtAvailableQty500g.Text = AvailableQuant500g
    End Sub

    Private Sub txt500gQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt500gQty.LostFocus
        If txt500gUPrice.Text = Nothing Then
            MessageBox.Show("Please Select an item to display the price")
        Else
            Dim totalPriceFor500g As Double
            totalPriceFor500g = txt500gQty.Text * txt500gUPrice.Text
            txt500gTotalAmount.Text = totalPriceFor500g
        End If
        Dim balance As Double
        AvailableQuant500g = txtAvailableQty500g.Text
        balance = (AvailableQuant500g - txt500gQty.Text)
        txtAvailableQty500g.Text = balance
    End Sub

    Private Sub txt500gQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt500gQty.TextChanged

    End Sub

    Private Sub txt1kgQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt1kgQty.GotFocus
        txtAvailableQty1kg.Text = ""
        txtAvailableQty1kg.Text = AvailableQuant1kg
    End Sub

    Private Sub txt1kgQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt1kgQty.LostFocus
        If txt1kgUPrice.Text = Nothing Then
            MessageBox.Show("Please Select an item to display the price")
        Else
            Dim totalPriceFor1kg As Double
            totalPriceFor1kg = txt1kgQty.Text * txt1kgUPrice.Text
            txt1kgTotalAmount.Text = totalPriceFor1kg
        End If
        Dim balance As Double
        AvailableQuant1kg = txtAvailableQty1kg.Text
        balance = (AvailableQuant1kg - txt1kgQty.Text)
        txtAvailableQty1kg.Text = balance

        'Calculating Overall Quantity on Stock
        Dim totalQuant As Double
        Dim S250g As Double = txt250gQty.Text
        Dim S500g As Double = txt500gQty.Text
        Dim S1kg As Double = txt1kgQty.Text
        totalQuant = S250g + S500g + S1kg
        txtOverallQty.Text = totalQuant

        'Calculating Overall Cost on Stock
        Dim totalAmount As Double
        Dim S250gCost As Double = txt250gTotalAmount.Text
        Dim S500gCost As Double = txt500gTotalAmount.Text
        Dim S1kgCost As Double = txt1kgTotalAmount.Text
        totalAmount = S250gCost + S500gCost + S1kgCost
        txtOverallAmount.Text = totalAmount
    End Sub

    Private Sub txt1kgQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1kgQty.TextChanged

    End Sub

    Private Sub btnSaveSaltSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSaltSales.Click
        If txt250gQty.Text = Nothing Then
            MessageBox.Show("Please Provide the quantity")
            txt250gQty.Text = Focus()
        End If
        If txt500gQty.Text = Nothing Then
            MessageBox.Show("Please Provide the quantity")
            txt500gQty.Text = Focus()
        End If
        If txt500gQty.Text = Nothing Then
            MessageBox.Show("Please Provide the quantity")
            txt500gQty.Text = Focus()
        End If
        Try

            Dim sql As String
            Dim cmd As OleDbCommand
            connect()

            sql = "INSERT INTO SaltCreditSales (SalesPerson,SalesDate,250g,500g,1kg,TotalQty,TotalAmount,Contact ) Values (@SalesPerson,@SalesDate,@250g,@500g,@1kg,@TotalQty,@TotalAmount,@Contact ) "
            cmd = New OleDbCommand(sql, conn)
            With cmd.Parameters
                .AddWithValue("@SalesPerson", cboSelectSalesPerson.Text)
                .AddWithValue("@SalesDate", txtDate.Text)
                .AddWithValue("@250g", txt250gQty.Text)
                .AddWithValue("@500", txt500gQty.Text)
                .AddWithValue("@1kg", txt1kgQty.Text)
                .AddWithValue("@TotalQty", txtOverallQty.Text)
                .AddWithValue("@TotalAmount", txtOverallAmount.Text)
                .AddWithValue("@Contact", txtSalesPersonContact.Text)

            End With
            Try
                If cmd.ExecuteNonQuery() Then
                    MsgBox("Credit Sales Made On Oil Successfully")
                Else
                    MessageBox.Show("Alert", "Error In Saving", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

            End Try
            update250gStockOnCreditSales()
            update500gStockOnCreditSales()
            update1kgStockOnCreditSales()
        Catch ex As Exception

        End Try
    End Sub
End Class