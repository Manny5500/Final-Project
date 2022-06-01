Imports MySql.Data.MySqlClient
Imports System.Data
Public Class frmProducts
    Dim conn As MySqlConnection
    Dim SQL As String
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable

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
                .Columns(0).HeaderText = "Product ID"
                .Columns(1).HeaderText = "Product Name"
                .Columns(2).HeaderText = "Description"
                .Columns(3).HeaderText = "Price"
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
            myCommand.Connection = conn
            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()
            txtProductID.Text = String.Empty
            txtProductName.Text = String.Empty
            txtDescription.Text = String.Empty
            txtPrice.Text = String.Empty
            Data_Load("SELECT * FROM Products")
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("error: " & myerror.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub frameProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Data_Load("SELECT ProductID, ProductName, Description,Price FROM Products")
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Query("insert into Products ( Price, ProductName, Description) values" &
          "('" & txtPrice.Text & "', '" & txtProductName.Text & "', '" & txtDescription.Text & "' )")
        Catch myerror As System.InvalidCastException
            MessageBox.Show("Price only accepts numbers and should not have whitespace or characters!")
        Catch myerror As MySqlException
            MessageBox.Show("Price should be a number", "Can't added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Query("Update Products set Price = '" & txtPrice.Text & "', ProductName= '" & txtProductName.Text & "', 
            Description = '" & txtDescription.Text & "'  where ProductID = '" & txtProductID.Text & "'")
        Catch myerror As System.InvalidCastException
            MessageBox.Show("Either fields are empty or wrong input data")
        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Data_Load("SELECT * FROM Products WHERE concat(ProductID, Price, ProductName, Description) like('%" & txtSearch.Text & "%')")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Query("delete from Products where ProductID = '" & txtProductID.Text & "'")
        MessageBox.Show("Successfully Deleted", "Deleting the Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtProductID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        txtPrice.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        txtProductName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        txtDescription.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        frmProductsReport.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class