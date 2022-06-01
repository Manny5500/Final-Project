Public Class frmReports
    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        frmSalesReport.ShowDialog()
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        frmPayReports.ShowDialog()
    End Sub
End Class