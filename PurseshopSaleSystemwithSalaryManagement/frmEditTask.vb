Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.DataTable
Public Class frmEditTask
    Dim conn As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim SQL As String
    Public taskholder As String
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
            dt.Clear()
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = data
            cmd.Connection = conn
            cmd.CommandText = SQL
            da.SelectCommand = cmd
            da.Fill(dt)
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Sub Query(ByVal data As String)
        Try
            conn = New MySqlConnection()
            conn.ConnectionString = "server=localhost;user id=root;" &
            "password=12345; database=purseshop"
            conn.Open()
            SQL = data
            cmd.Connection = conn
            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()
            'Data_Load("select CustomerID, ProductID,  Description, Quantity, DueDate, TotalPrice from temporders")
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("error: " & myerror.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmTasks.Loading()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Query("Update tasks set Quantity= '" & txtQuantity.Text & "', 
            DueDate = '" & txtDueDate.Text & "', Salary = '" & txtSalary.Text & "', Deductions = '" & txtDeductions.Text & "',
            TotalSalary = '" & txtSalary.Text - txtDeductions.Text & "', 
            dateprocessed = '" & Today.ToString("yyyy-MM-dd") & "', visibility = '" & "Show" & "' where taskID = '" & taskholder & "'")
        Catch myerror As Exception
            MessageBox.Show("Deductions, quantity and salary should be  numbers")
        End Try
    End Sub

    Private Sub frmEditTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class