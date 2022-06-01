Imports MySql.Data.MySqlClient
Imports System.Data
Public Class frmCustomers
    Dim conn As MySqlConnection
    Dim SQL As String
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Sub Query(ByVal data As String)
        Try
            conn.Open()
            SQL = data
            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()
            txtCustomerName.Text = String.Empty
            txtAddress.Text = String.Empty
            txtCp_No.Text = String.Empty
            txtEmail.Text = String.Empty
            Data_Load("SELECT CustomerName, Address, Email, Cp_No FROM Customers")
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

            With DataGridView1
                .DataSource = myData
                .Columns(0).HeaderText = "CustomerName"
                .Columns(1).HeaderText = "Address"
                .Columns(2).HeaderText = "Email"
                .Columns(3).HeaderText = "Cp_No"
            End With
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Data_Load("SELECT CustomerName, Address, Email, Cp_No FROM Customers")
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtCustomerName.Text = "" Or txtEmail.Text = "" Or txtCp_No.Text = "" Or txtAddress.Text = "" Then
                MessageBox.Show("Please fill all fields")
            Else
                Query("insert into Customers (CustomerName, Address, Email, Cp_No) values" &
        "('" & txtCustomerName.Text & "','" & txtAddress.Text & "', '" & txtEmail.Text & "', '" & txtCp_No.Text & "' )")
            End If
        Catch myerror As System.InvalidCastException
            MessageBox.Show("Price only accepts numbers and should not have whitespace or characters!")
        End Try
        frmOrders.Loading()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Query("Update customers set CustomerName = '" & txtCustomerName.Text & "', Address= '" & txtAddress.Text & "', 
            Email = '" & txtEmail.Text & "'  where Cp_No = '" & txtCp_No.Text & "'")
        Catch myerror As System.InvalidCastException
            MessageBox.Show("Either fields are empty or wrong input data")
        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Data_Load("SELECT CustomerName, Address, Email, Cp_No FROM Customers WHERE concat(CustomerName, Address, Email, Cp_No) like('%" & txtSearch.Text & "%')")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Query("delete from customers where CustomerName = '" & txtCustomerName.Text & "'")
        MessageBox.Show("Customer Deleted")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtCustomerName.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txtAddress.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtEmail.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtCp_No.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
    End Sub

End Class