Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.DataTable
Public Class frmListofOrders
    Dim conn As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim SQL As String
    Dim tot As Integer = 0
    Dim Today As Date = Date.Today
    Shadows update As New frmUpdateOrders
    Dim orderholder As String
    Private Sub frmListOfOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loading()
    End Sub
    'for code simplicity
    Sub Loading()
        Data_Load("select  c.CustomerName, c.Address, c.Email, c.Cp_No, p.ProductName, o.Description, p.Price, o.Quantity, o.TotalPrice, o.DateOrdered, o.DueDate, o.OrderID
         from orders as o join customers as c on c.CustomerID = o.CustomerID join products as p on p.ProductID = o.ProductID where visibility = '" & "SHOW" & "'")
    End Sub

    'for data_loading
    Public Sub Data_Load(ByVal data As String)
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
                .Columns(0).HeaderText = "Customer Name"
                .Columns(1).HeaderText = "Address"
                .Columns(2).HeaderText = "Email"
                .Columns(3).HeaderText = "Cp_No"
                .Columns(4).HeaderText = "Product Name"
                .Columns(5).HeaderText = "Description"
                .Columns(6).HeaderText = "Price"
                .Columns(7).HeaderText = "Quantity"
                .Columns(8).HeaderText = "Total Price"
                .Columns(9).HeaderText = "Order Date"
                .Columns(10).HeaderText = "Due Date"
                .Columns(11).HeaderText = "Order Number"
            End With
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        update.ShowDialog()
        Loading()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        update.txtCustomerName.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        update.txtDescription.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
        update.txtPrice.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString()
        update.txtQuantity.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString()
        update.txtOrderNo.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString()
        orderholder = DataGridView1.CurrentRow.Cells(11).Value.ToString()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Query("Update Orders set visibility = '" & "Hide" & "'  where OrderID = '" & orderholder & "'")
        Catch myerror As System.InvalidCastException
            MessageBox.Show("Please select an order first")
        End Try
        Loading()
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

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Data_Load("select  c.CustomerName, c.Address, c.Email, c.Cp_No, p.ProductName, o.Description, p.Price, o.Quantity, o.TotalPrice, o.DateOrdered, o.DueDate, o.OrderID
         from orders as o join customers as c on c.CustomerID = o.CustomerID join products as p on p.ProductID = o.ProductID
        WHERE concat(c.CustomerName, c.Address, c.Email, c.Cp_No, p.ProductName, o.Description, p.Price, o.Quantity, o.TotalPrice, o.DateOrdered, o.DueDate, o.OrderID)
        like('%" & txtSearch.Text & "%')")
    End Sub

End Class