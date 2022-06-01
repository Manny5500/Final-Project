Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.DataTable
Imports System.Drawing.Printing
Public Class frmTasks
    Dim conn As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim SQL As String
    Dim tot As Integer = 0
    Dim Today As Date = Date.Today
    Dim edit As New frmEditTask
    Dim taskholders As String
    '-----------Variable for Receipt Printing------------------'
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As String
    Dim hey As Integer

    Sub Data_Load(ByVal data As String)
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
            "password=12345; database=purseshop"
        Try
            dt.Clear()
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = data
            cmd.Connection = conn
            cmd.CommandText = SQL
            da.SelectCommand = cmd
            da.Fill(dt)

            With DataGridView1
                .DataSource = dt
                .Columns(0).HeaderText = "TaskNo"
                .Columns(1).HeaderText = "Worker Name"
                .Columns(2).HeaderText = "Product Name"
                .Columns(3).HeaderText = "Quantity"
                .Columns(4).HeaderText = "Due Date"
                .Columns(5).HeaderText = "salary"
                .Columns(6).HeaderText = "Deductions"
                .Columns(7).HeaderText = "Total Salary"
            End With
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Sub Query(ByVal data As String)
        Try
            conn.Open()
            SQL = data
            cmd.Connection = conn
            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("error: " & myerror.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub
    Sub Loading()
        Data_Load("select TaskID, WorkerName, ProductName, Quantity, DueDate, salary, Deductions, TotalSalary from tasks where visibility = 'Show' ")

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click
        Dim add As New frmAddTask
        add.ShowDialog()
    End Sub

    Private Sub frameWorkers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading()
        'generate()
    End Sub

    Private Sub txtAddWorker_Click(sender As Object, e As EventArgs) Handles txtAddWorker.Click
        Dim worker As New frmAddWorker
        worker.ShowDialog()
    End Sub

    Private Sub btnEditInfo_Click(sender As Object, e As EventArgs) Handles btnEditInfo.Click
        edit.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        edit.taskWorkerName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        edit.textTask.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        edit.txtQuantity.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        edit.txtSalary.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        edit.txtDeductions.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        taskholders = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        edit.taskholder = taskholders
    End Sub

    Private Sub btnDeleteTask_Click(sender As Object, e As EventArgs) Handles btnDeleteTask.Click
        Query("Update tasks set visibility = '" & "Hide" & "' where taskID = '" & taskholders & "'")
        MessageBox.Show("Task Removed", "Deleting of Task", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Loading()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Data_Load("SELECT * FROM tasks where concat(TaskID, WorkerName, ProductName, quantity, DueDate,  Salary,  TotalSalary) like('%" & txtSearch.Text & "%')")
    End Sub

    '--------------------------------Reciept Printing Area----------------------------------------------'

    Sub changelongpaper() 'only a sub to change the papersize
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 210
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 300, 500)'fixed page size
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 9, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 9, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString("Purse Shop", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("Sitio Batisan Brgy. Gatid, Santa Cruz, Laguna", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Cel 09665907498", f8, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("Pay No", f8, Brushes.Black, 0, 60)
        e.Graphics.DrawString(" :", f8, Brushes.Black, 70, 60)
        e.Graphics.DrawString(DataGridView1.CurrentRow.Cells(0).Value.ToString(), f8, Brushes.Black, 90, 60) 'Kailangan

        e.Graphics.DrawString("Worker Name", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(" :", f8, Brushes.Black, 70, 75)
        e.Graphics.DrawString(DataGridView1.CurrentRow.Cells(1).Value.ToString(), f8, Brushes.Black, 90, 75)

        e.Graphics.DrawString("Task Name", f8, Brushes.Black, 0, 90)
        e.Graphics.DrawString(" :", f8, Brushes.Black, 70, 90)
        e.Graphics.DrawString(DataGridView1.CurrentRow.Cells(2).Value.ToString(), f8, Brushes.Black, 90, 90)

        e.Graphics.DrawString("Quantity", f8, Brushes.Black, 0, 105)
        e.Graphics.DrawString(" :", f8, Brushes.Black, 70, 105)
        e.Graphics.DrawString(DataGridView1.CurrentRow.Cells(3).Value.ToString(), f8, Brushes.Black, 90, 105)

        e.Graphics.DrawString("Salary", f8, Brushes.Black, 0, 120)
        e.Graphics.DrawString(" :", f8, Brushes.Black, 70, 120)
        e.Graphics.DrawString(DataGridView1.CurrentRow.Cells(5).Value.ToString(), f8, Brushes.Black, 90, 120)

        e.Graphics.DrawString("Deductions", f8, Brushes.Black, 0, 135)
        e.Graphics.DrawString(" :", f8, Brushes.Black, 70, 135)
        e.Graphics.DrawString(DataGridView1.CurrentRow.Cells(6).Value.ToString(), f8, Brushes.Black, 90, 135)

        e.Graphics.DrawString("Total Salary", f8, Brushes.Black, 0, 150)
        e.Graphics.DrawString(" :", f8, Brushes.Black, 70, 150)
        e.Graphics.DrawString(DataGridView1.CurrentRow.Cells(7).Value.ToString(), f8, Brushes.Black, 90, 150)

        e.Graphics.DrawString(Now, f8, Brushes.Black, 0, 165)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 180)

    End Sub
    Sub printingallinone()
        Try
            changelongpaper()
            PPD.Document = PD
            PPD.StartPosition = FormStartPosition.CenterScreen
            PPD.ShowDialog()
            Loading()
        Catch ex As Exception
            MessageBox.Show("There is no record")


        End Try

    End Sub
    '--------------------End of Receipt Printing --------------- section 
    Private Sub btnPrintPay_Click(sender As Object, e As EventArgs) Handles btnPrintPay.Click
        printingallinone()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

End Class