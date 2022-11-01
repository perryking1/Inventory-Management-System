Imports System.Data.OleDb

Public Class OilForm
    Dim AvailableQuant1Lit As Double
    Dim AvailableQuant2Lit As Double
    Dim AvailableQuant5Lit As Double

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click, Label9.Click, Label8.Click, Label7.Click, Label6.Click, Label13.Click, Label12.Click, Label11.Click, Label10.Click, Label24.Click, Label23.Click, Label25.Click, Label26.Click, Label28.Click, Label27.Click, Label29.Click, Label30.Click

    End Sub

    Private Sub OilForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTimeOnSales.Text = dtpTimeOnSales.Text
        Me.MdiParent = Form1
        connect()
        selectAllSalesPersons()
        selectAllStock()

    End Sub

    Private Sub dtpCurrentDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpCurrentDate.ValueChanged
        txtDate.Text = dtpCurrentDate.Value.Date

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

    Private Sub cbo1litre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo1litre.SelectedIndexChanged
        Try
            connect()
            Dim sql As String = "select * from Stock where ItemName ='" & cbo1litre.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                txt1lUPrice.Text = reader("UnitPrice")
                txtAvailableQty1Lit.Text = reader("AvailableQuantity")
            End While
        Catch ex As Exception

        Finally
            AvailableQuant1Lit = txtAvailableQty1Lit.Text
        End Try
    End Sub

    Private Sub cbo2litre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo2litre.SelectedIndexChanged
        Try
            connect()
            Dim sql As String = "select * from Stock where ItemName ='" & cbo2litre.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                txt2lUPrice.Text = reader("UnitPrice")
                txtAvailableQty2Lit.Text = reader("AvailableQuantity")
            End While
        Catch ex As Exception

        Finally
            AvailableQuant2Lit = txtAvailableQty2Lit.Text
        End Try
    End Sub

    Private Sub cbo5litre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo5litre.SelectedIndexChanged
        Try
            connect()
            Dim sql As String = "select * from Stock where ItemName ='" & cbo5litre.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                txt5lUPrice.Text = reader("UnitPrice")
                txtAvailableQty5Lit.Text = reader("AvailableQuantity")
            End While
        Catch ex As Exception

        Finally
            AvailableQuant5Lit = txtAvailableQty5Lit.Text
        End Try
    End Sub

    Private Sub btnSaveOilSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveOilSales.Click
        If txt1lQty.Text = Nothing Then
            MessageBox.Show("Please Provide the quantity")
            txt1lQty.Text = Focus()
        End If
        If txt2lQty.Text = Nothing Then
            MessageBox.Show("Please Provide the quantity")
            txt2lQty.Text = Focus()
        End If
        If txt5lQty.Text = Nothing Then
            MessageBox.Show("Please Provide the quantity")
            txt5lQty.Text = Focus()
        End If
        Try

            Dim sql As String
            Dim cmd As OleDbCommand
            connect()

            sql = "INSERT INTO OilCreditsales (SalesPerson,SalesDate,1LitreQty,2LitreQty,5LitreQty,TotalQty,TotalAmount,Contact ) Values (@SalesPerson,@SalesDate,@1LitreQty,@2LitreQty,@5LitreQty,@TotalQty,@TotalAmount,@Contact ) "
            cmd = New OleDbCommand(sql, conn)
            With cmd.Parameters
                .AddWithValue("@SalesPerson", cboSelectSalesPerson.Text)
                .AddWithValue("@SalesDate", txtDate.Text)
                .AddWithValue("@1LitreQty", txt1lQty.Text)
                .AddWithValue("@2LitreQty", txt2lQty.Text)
                .AddWithValue("@5LitreQty", txt5lQty.Text)
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
            update1LitStockOnCreditSales()
            update2LitStockOnCreditSales()
            update5LitStockOnCreditSales()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt1lQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt1lQty.GotFocus
        txtAvailableQty1Lit.Text = ""
        txtAvailableQty1Lit.Text = AvailableQuant1Lit
    End Sub

    Private Sub txt1lQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt1lQty.LostFocus, txtAvailableQty1Lit.LostFocus, txtSalesPersonContact.LostFocus
        If cbo1litre.Text = Nothing Then
            MessageBox.Show("Please Select an item to display the price")
        Else
            Dim totalPriceFor1litre As Double
            totalPriceFor1litre = txt1lQty.Text * txt1lUPrice.Text
            txt1lTotalAmount.Text = totalPriceFor1litre
        End If
        Dim balance As Double
        AvailableQuant1Lit = txtAvailableQty1Lit.Text
        balance = (AvailableQuant1Lit - txt1lQty.Text)
        txtAvailableQty1Lit.Text = balance
    End Sub

    Private Sub txt1lQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1lQty.TextChanged, txtAvailableQty1Lit.TextChanged, txtSalesPersonContact.TextChanged

    End Sub

    Private Sub txt2lQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt2lQty.GotFocus
        txtAvailableQty2Lit.Text = ""
        txtAvailableQty2Lit.Text = AvailableQuant2Lit
    End Sub

    Private Sub txt2lQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt2lQty.LostFocus, txtAvailableQty2Lit.LostFocus
        If txt2lUPrice.Text = Nothing Then
            MessageBox.Show("Please Select an item to display the price")
        Else
            Dim totalPriceFor2litre As Double
            totalPriceFor2litre = txt2lQty.Text * txt2lUPrice.Text
            txt2lTotalAmount.Text = totalPriceFor2litre
        End If
        Dim balance As Double
        AvailableQuant2Lit = txtAvailableQty2Lit.Text
        balance = (AvailableQuant2Lit - txt2lQty.Text)
        txtAvailableQty2Lit.Text = balance
    End Sub

    Private Sub txt2lQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2lQty.TextChanged, txtAvailableQty2Lit.TextChanged

    End Sub

    Private Sub txt5lQty_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt5lQty.GotFocus
        txtAvailableQty5Lit.Text = ""
        txtAvailableQty5Lit.Text = AvailableQuant5Lit
    End Sub

    Private Sub txt5lQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt5lQty.LostFocus, txtAvailableQty5Lit.LostFocus
        If txt5lUPrice.Text = Nothing Then
            MessageBox.Show("Please Select an item to display the price")
        Else
            Dim totalPriceFor5litre As Double
            totalPriceFor5litre = txt5lQty.Text * txt5lUPrice.Text
            txt5lTotalAmount.Text = totalPriceFor5litre
        End If
        Dim balance As Double
        AvailableQuant5Lit = txtAvailableQty5Lit.Text
        balance = (AvailableQuant5Lit - txt5lQty.Text)
        txtAvailableQty5Lit.Text = balance

        'Calculating Overall Quantity on Stock
        Dim totalQuant As Double
        Dim oneLit As Double = txt1lQty.Text
        Dim twoLit As Double = txt2lQty.Text
        Dim fiveLit As Double = txt5lQty.Text
        totalQuant = oneLit + twoLit + fiveLit
        txtOverallQty.Text = totalQuant

        'Calculating Overall Cost on Stock
        Dim totalAmount As Double
        Dim oneLitCost As Double = txt1lTotalAmount.Text
        Dim twoLitCost As Double = txt2lTotalAmount.Text
        Dim fiveLitCost As Double = txt5lTotalAmount.Text
        totalAmount = oneLitCost + twoLitCost + fiveLitCost
        txtOverallAmount.Text = totalAmount


    End Sub

    Private Sub txt5lQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt5lQty.TextChanged, txtAvailableQty5Lit.TextChanged

    End Sub

    Private Sub dtpTimeOnSales_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTimeOnSales.ValueChanged
        dtpTimeOnSales.Value = txtTimeOnSales.Text

    End Sub
End Class