Imports MySql.Data.MySqlClient
Imports System.Data
Public Class frmAddTask
    Dim conn As MySqlConnection
    Dim SQL As String
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim myData2 As New DataTable
    Dim Today As Date = Date.Today
    Dim Pos As Point
    Private Sub Panel3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Sub Query(ByVal data As String)
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
            "password=12345; database=purseshop"
        Try
            conn.Open()
            SQL = data
            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()
            'txtOrderNo.Text = String.Empty
            'txtCustomerName.Text = String.Empty
            'txtDescription.Text = String.Empty
            'txtPrice.Text = String.Empty
            'txtQuantity.Text = String.Empty
            'Data_Load("SELECT * FROM Products")
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("error: " & myerror.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub
    Sub Data_Load(ByVal data As String)
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
            "password=12345; database=purseshop"
        Try
            myData.Clear()
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = data
            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData)
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Sub Data_Load2(ByVal data As String)
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
            "password=12345; database=purseshop"
        Try
            myData2.Clear()
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = data
            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myData2)
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub frmAddTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillSelect()
        fillWorker()

    End Sub

    Sub fillSelect()
        Data_Load("select productid, productname from products ")
        comboSelectTask.DataSource = myData
        comboSelectTask.ValueMember = "productid"
        comboSelectTask.DisplayMember = "ProductName"
    End Sub
    Sub fillWorker()
        Data_Load2("select WorkerID, WorkerName from workers")
        comboWorkerName.DataSource = myData2
        comboWorkerName.ValueMember = "WorkerID"
        comboWorkerName.DisplayMember = "WorkerName"
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmTasks.Loading()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Query("insert into Tasks (WorkerName, ProductName,  Salary, Quantity, DueDate,  TotalSalary, dateprocessed, visibility  ) values" &
          "('" & comboWorkerName.Text & "','" & comboSelectTask.Text & "', '" & txtSalary.Text & "', '" & txtQuantity.Text & "', '" & txtDueDate.Text & "',
            '" & txtSalary.Text & "', '" & Today.ToString("yyyy-MM-dd") & "', '" & "Show" & "'  )")
            MessageBox.Show("Task Added")
        Catch myerror As Exception
            MessageBox.Show("Quantity and Salary Should be numbers")
        End Try

    End Sub
End Class