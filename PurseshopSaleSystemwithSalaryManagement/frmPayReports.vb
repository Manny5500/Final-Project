Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmPayReports
    Sub GenerateReport()
        Dim DTT As New DataTable
        Dim KoneksiStr As String = "server=localhost;user=root;port=3306;database=purseshop;password=12345"
        Dim conn As New MySqlConnection(KoneksiStr)
        conn.ConnectionString = KoneksiStr
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim DA As New MySqlDataAdapter("Select TaskID, WorkerName, ProductName, Salary, Deductions, TotalSalary, 
        DueDate, quantity, dateprocessed from tasks where date(dateprocessed) between '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' and '" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "' ", conn)
        DA.Fill(DTT)
        ReportViewer1.LocalReport.DataSources.Clear()
        Dim Rpt As New ReportDataSource("DataSet2", DTT)
        ReportViewer1.LocalReport.DataSources.Add(Rpt)
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        ReportViewer1.ShowFindControls = True
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
        ReportViewer1.RefreshReport()
    End Sub
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        GenerateReport()
    End Sub

End Class