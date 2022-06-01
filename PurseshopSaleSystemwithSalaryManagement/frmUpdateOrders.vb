Imports MySql.Data.MySqlClient
Imports System.Data
Public Class frmUpdateOrders
    Dim conn As MySqlConnection
    Dim SQL As String
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim Pos As Point
    Private Sub Panel3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
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
            txtOrderNo.Text = String.Empty
            txtCustomerName.Text = String.Empty
            txtDescription.Text = String.Empty
            txtPrice.Text = String.Empty
            txtQuantity.Text = String.Empty
            'Data_Load("SELECT * FROM Products")
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("error: " & myerror.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim haha As New frmListofOrders
        Try
            Query("Update orders set Quantity= '" & txtQuantity.Text & "', 
            DueDate = '" & txtDueDate.Text & "', TotalPrice = '" & txtQuantity.Text * txtPrice.Text & "'  where OrderID = '" & txtOrderNo.Text & "'")
        Catch myerror As System.InvalidCastException
            MessageBox.Show("Either fields are empty or wrong input data")
        End Try

    End Sub

    Private Sub frmUpdateOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class