Imports System.Data.OleDb

Public Class DebtorsForm
    Dim diff, payment, owing As Double


    Private Sub cboCustomerName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSalesPersonsName.GotFocus

    End Sub

    Private Sub cboCustomerName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSalesPersonsName.SelectedIndexChanged
        Try
            connect()
            Dim sql As String = "select * from OilCreditsales where SalesPerson ='" & cboSalesPersonsName.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                txtContact.Text = reader("Contact")
                txtTotalQty.Text = reader("TotalQty")
                txtAmountOwing.Text = reader("TotalAmount")
                txtDateRecorded.Text = reader("SalesDate")
            End While
            If txtAmountOwing.Text <= 0 Then
                MsgBox("Debt Paid Fully")
                txtAcceptPayment.Hide()
            End If
        Catch ex As Exception

        Finally

        End Try
    End Sub

    Private Sub dtpDateOfPayment_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateOfPayment.ValueChanged
        txtDateOfPayment.Text = dtpDateOfPayment.Value.Date

    End Sub

    Private Sub DebtorsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        txtDateOfPayment.Text = dtpDateOfPayment.Value.Date
        ' connect()
        Try
            connect()
            Dim sql As String = "select SalesPerson from OilCreditsales"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            reader = command.ExecuteReader
            While (reader.Read())
                cboSalesPersonsName.Items.Add(reader("SalesPerson"))
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtAcceptPayment_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAcceptPayment.GotFocus
        owing = txtAmountOwing.Text
    End Sub

    Private Sub txtAcceptPayment_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAcceptPayment.LostFocus
        owing = CDbl(txtAmountOwing.Text)
        payment = CDbl(txtAcceptPayment.Text)
        diff = owing - payment
        txtNewAmountOwing.Text = diff
    End Sub

    Private Sub txtAcceptPayment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAcceptPayment.TextChanged

    End Sub

    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        Try
            Dim sql As String
            Dim cmd As OleDbCommand
            connect()

            sql = "Insert INTO Debtors (CustomerName,OldAmountOwing,DateOwing,Payment,NewAmountOwing,PaymentDate,Contact) Values (@CustomerName,@OldAmountOwing,@DateOwing,@Payment,@NewAmountOwing,@PaymentDate,@Contact ) "
            cmd = New OleDbCommand(sql, conn)
            With cmd.Parameters
                .AddWithValue("@CustomerName", cboSalesPersonsName.Text)
                .AddWithValue("@OldAmountOwing", txtAmountOwing.Text)
                .AddWithValue("@DateOwing", txtDateRecorded.Text)
                .AddWithValue("@Payment", txtAcceptPayment.Text)
                .AddWithValue("@NewAmountOwing", txtNewAmountOwing.Text)
                .AddWithValue("@PaymentDate", txtDateOfPayment.Text)
                .AddWithValue("@Contact", txtContact.Text)
            End With
            If cmd.ExecuteNonQuery() Then
                MsgBox("Debtors Info Recorded Successfully")

            Else
                MessageBox.Show("Alert", "Error In Recording", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try

        Dim id As Integer = CInt(txtContact.Text)
        Try
            Dim sql As String = "update OilCreditsales set [TotalAmount]='" & txtNewAmountOwing.Text & "' where [SalesPerson]='" & cboSalesPersonsName.Text & "'"
            Dim command As OleDbCommand = New OleDbCommand(sql, conn)

            If command.ExecuteNonQuery() Then
                MsgBox("New Balance Owing Updated In Credit Sales")
            Else
                MsgBox("Failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
        txtContact.Text = Nothing
        txtAcceptPayment.Text = Nothing
        txtDateOfPayment.Text = Nothing
        txtAmountOwing.Text = Nothing
        txtDateRecorded.Text = Nothing
        txtNewAmountOwing.Text = Nothing
        txtTotalQty.Text = Nothing

    End Sub

End Class