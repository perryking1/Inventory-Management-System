Imports System.Data.OleDb

Public Class ReportOnSales
    Dim report As New SalesReport



    Private Sub btnReportSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportSales.Click
        If cboSelectSalesPerson.Text = Nothing Then
            MessageBox.Show("Please Select Sales-Person's Name ", "Information....!")
            cboSelectSalesPerson.Focus()
        Else
            Try
                connect()
                Dim sql As String = "select * from OilCreditsales where SalesPerson =(@SalesPerson)"
                Dim cmd As New OleDbCommand(sql, conn)

                cmd.Parameters.AddWithValue("@SalesPerson", cboSelectSalesPerson.Text)



                Dim da As New OleDbDataAdapter
                Dim dt As New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
                report.SetDataSource(dt)
                crvSales.ReportSource = report
                crvSales.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub btnViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewAll.Click
        Try
            connect()
            Dim sql As String = "select * from OilCreditsales"
            Dim cmd As New OleDbCommand(sql, conn)

            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            report.SetDataSource(dt)
            crvSales.ReportSource = report
            crvSales.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ReportOnSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    End Sub
End Class