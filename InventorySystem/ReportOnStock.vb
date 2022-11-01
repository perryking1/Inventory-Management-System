Imports System.Data.OleDb

Public Class ReportOnStock
    Dim report As New StockReport

    Private Sub btnReportStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportStock.Click
        If txtDateFrom.Text = Nothing Then
            MessageBox.Show("Please Specify Date Range(FROM)", "Information....!")
            dtpFrom.Focus()

        End If
        If txtDateTo.Text = Nothing Then
            MessageBox.Show("Please Specify Date Range(TO)", "Information....!")
            dtpTo.Focus()
        Else
            Try
                connect()
                Dim sql As String = "select * from Stock where RegistryDate between(@datefrom) and (@dateto)"
                Dim cmd As New OleDbCommand(sql, conn)


                cmd.Parameters.AddWithValue("@datefrom", txtDateFrom.Text)
                cmd.Parameters.AddWithValue("@dateto", txtDateTo.Text)



                Dim da As New OleDbDataAdapter
                Dim dt As New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)
                report.SetDataSource(dt)
                crvStock.ReportSource = report
                crvStock.Refresh()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewAll.Click
        Try
            connect()
            Dim sql As String = "select * from Stock"
            Dim cmd As New OleDbCommand(sql, conn)

            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            report.SetDataSource(dt)
            crvStock.ReportSource = report
            crvStock.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged
        txtDateFrom.Text = dtpFrom.Value.Date
    End Sub

    Private Sub dtpTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTo.ValueChanged
        txtDateTo.Text = dtpTo.Value.Date
    End Sub
End Class