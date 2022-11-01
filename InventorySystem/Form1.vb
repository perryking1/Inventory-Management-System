Public Class Form1

    Private Sub SalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        SalesCategory.Show()
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ReportOnSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportOnSalesToolStripMenuItem.Click
        ReportOnSales.Show()

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Stock.Show()

    End Sub

    Private Sub ReportOnStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportOnStockToolStripMenuItem.Click
        ReportOnStock.Show()

    End Sub

    Private Sub UpdateStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateStockToolStripMenuItem.Click
        UpdateStock.Show()

    End Sub

    Private Sub AcceptDebtPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcceptDebtPaymentToolStripMenuItem.Click
        DebtorsForm.Show()
    End Sub

    Private Sub OilFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CreateSalesPersonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateSalesPersonToolStripMenuItem.Click
        CreateSalesPerson.Show()
    End Sub
End Class
