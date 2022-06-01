Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.DataTable
Imports System.Drawing.Printing
Public Class frmOrders
    Dim conn As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim mydata2 As New DataTable
    Dim mydata3 As New DataTable
    Dim SQL As String
    Dim tot As Integer = 0
    Dim Today As Date = Date.Today
    Dim Now As Date = Date.Now()
    Public customerID As Integer 'To insert to order table, used in myreader
    Public productID As Integer 'To insert to products table, used in myreader
    Dim products As New frmProducts 'Testing
    '-----------Variable for Receipt Printing------------------'
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As String
    Dim hey As Integer
    Dim invoicereceipt As String
    '------------End of Variable for Receipt Printing-----------'

    '-----------For Number Generating Purposes---------------------
    Dim x As String = ""
    Dim rand As Random = New Random()
    Dim container As String
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
    Private Sub btnAddtoList_Click(sender As Object, e As EventArgs) Handles btnAddtoList.Click
        generate()
        Dim z As String
        z = container
        Try
            If comboCustomer.Text = "" Or ComboProducts.Text = "" Or txtQuantity.Text = "" Or txtDueDate.Text = "" Or txtTotal.Text = "" Then
                MessageBox.Show("Please fill all fields")

            Else
                Query("insert into temporders (CustomerID, ProductID, DateOrdered, DueDate,  TotalPrice,Description, Quantity, invoice_number, status, cashier, visibility, productname, price) values" &
              "('" & customerID & "','" & productID & "', '" & Today.ToString("yyyy-MM-dd") & "', '" & txtDueDate.Text & "',
           '" & txtTotal.Text & "' , '" & txtDescription.Text & "', '" & txtQuantity.Text & "', '" & container & "', '" & "SOLD" & "',
            '" & AccountFormat.username & "', '" & "SHOW" & "', '" & ComboProducts.Text & "', '" & txtPrice.Text & "')")
            End If
        Catch myerror As System.InvalidCastException
            MessageBox.Show("Price, Quantity, and Total only accepts numbers and should not have whitespace or characters!")
        End Try
        Loading()
        Cleared()
    End Sub
    'just a method to simply code 
    Private Sub Cleared()
        'txtProductID.Clear()
        ' txtProductName.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        txtTotal.Clear()
        txtDescription.Clear()
    End Sub
    'just a method to simply code
    Sub Loading()
        Data_Load("Select t.ProductID, p.ProductName, t.Description, p.Price, Quantity, TotalPrice
        from temporders as t join products as p on t.ProductID = p.ProductID ")
    End Sub
    'data load method which means it is the one that fetch data from mysql to vb.net form
    Private Sub Data_Load(ByVal data As String)
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
                .Columns(0).HeaderText = "Product ID"
                .Columns(1).HeaderText = "Product Name"
                .Columns(2).HeaderText = "Description"
                .Columns(3).HeaderText = "Price"
                .Columns(4).HeaderText = "Quantity"
                .Columns(5).HeaderText = "Total Price"
            End With
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
        Try
            Dim max As Integer = DataGridView1.Rows.Count - 1
            For Each row As DataGridViewRow In DataGridView1.Rows
                tot += row.Cells(5).Value
            Next
            txtAmountDue.Text = tot
            hey = Convert.ToInt32(txtAmountDue.Text)
            tot = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'txtCustomerID when doubleclick will prompt the txtcustomername, txtaddress, txtemail, txtcpno to have data
    Public Sub combo(sender As Object, e As EventArgs) Handles comboCustomer.TextChanged
        Try
            conn = New MySqlConnection()
            conn.ConnectionString = "Data source=localhost;port=3306;database=purseshop;user id=root;password=12345"
            cmd.Connection = conn
            cmd.CommandText = "Select * from customers where CustomerName=@parm1 ;"
            conn.Open()
            cmd.Parameters.AddWithValue("@parm1", comboCustomer.Text)
            Dim myreader As MySqlDataReader = cmd.ExecuteReader
            If (myreader.Read()) Then
                customerID = myreader("CustomerID")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message.ToString)
        End Try
        cmd.Parameters.Clear()
    End Sub

    'txtProduct when double click will prompt the txtproductname and txtprice to have data
    Private Sub txtProductID_TextChanged(sender As Object, e As EventArgs) Handles ComboProducts.TextChanged
        Try
            conn = New MySqlConnection()
            conn.ConnectionString = "Data source=localhost;port=3306;database=purseshop;user id=root;password=12345"
            cmd.Connection = conn
            cmd.CommandText = "Select *  from products where ProductName=@parm1 ;"
            conn.Open()
            cmd.Parameters.AddWithValue("@parm1", ComboProducts.Text)
            Dim myreader As MySqlDataReader = cmd.ExecuteReader
            If (myreader.Read()) Then
                productID = myreader("ProductID")
                txtPrice.Text = myreader("Price")
            Else
                Cleared()
            End If
            conn.Close()
        Catch ex As Exception
        End Try
        cmd.Parameters.Clear()
    End Sub
    Private Sub btnSaveOrder_Click(sender As Object, e As EventArgs) Handles btnSaveOrder.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to print the receipt", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then
            printingallinone()
        End If
        Try
            Query("insert into tempinvoice (invoice_number) value" &
          "('" & container & "' )")
            Query("insert into orders (CustomerID, ProductID, Description, Quantity, DateOrdered, DueDate, TotalPrice, invoice_number, status, cashier, visibility, productname, price) select
            CustomerID, ProductID, Description, Quantity, DateOrdered, DueDate, TotalPrice, t.invoice_number, status, cashier, visibility, productname, price from temporders, tempinvoice as t")

            Query("truncate table temporders")
            Query("truncate table tempinvoice")
            Loading()
        Catch myerror As System.InvalidCastException
        Finally
            MessageBox.Show("Orders are put in the database")
        End Try

    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        Try
            txtTotal.Text = txtPrice.Text * txtQuantity.Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            productID = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            ComboProducts.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            txtDescription.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            txtPrice.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            txtQuantity.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Query("delete from temporders where ProductID = '" & productID & "' and Description = '" & txtDescription.Text & "'  and
            TotalPrice = '" & txtTotal.Text & "' ")
        MessageBox.Show("Item Removed")
        Loading()
    End Sub

    Private Sub frmOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Loading()
        generate()
        fillCustomer()
        fillProducts()

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

        e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 60)
        e.Graphics.DrawString(" :", f8, Brushes.Black, 0, 60)
        e.Graphics.DrawString(container, f8, Brushes.Black, 70, 60) 'Kailangan

        e.Graphics.DrawString("Cashier", f8, Brushes.Black, 0, 75)
        e.Graphics.DrawString(" :", f8, Brushes.Black, 50, 75)
        e.Graphics.DrawString("Gandara Chaka", f8, Brushes.Black, 70, 75)

        e.Graphics.DrawString(Now, f8, Brushes.Black, 0, 90)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 100)

        Dim height As Integer 'DGV Position
        Dim i As Long
        DataGridView1.AllowUserToAddRows = False

        e.Graphics.DrawString("Qty", f10, Brushes.Black, 0, 110)
        e.Graphics.DrawString("Item", f10, Brushes.Black, 25, 110)
        e.Graphics.DrawString("Price", f10, Brushes.Black, rightmargin, 110, right)

        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(4).Value.ToString, f10, Brushes.Black, 0, 110 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 25, 110 + height)
            i = DataGridView1.Rows(row).Cells(3).Value
            DataGridView1.Rows(row).Cells(3).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(3).Value, f10, Brushes.Black, rightmargin, 110 + height, right)

        Next
        Dim height2 As Integer
        height2 = 120 + height
        'sumprice() 'calling the method
        Loading()
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total: " & Format(hey, "###,##0"), f10b, Brushes.Black, rightmargin, 15 + height2, right)
        'e.Graphics.DrawString("Total", f10b, Brushes.Black, 0, 15 + height2) ' If want sa left
        e.Graphics.DrawString("Qty", f10b, Brushes.Black, 0, 15 + height2)

        e.Graphics.DrawString("~ Thanks for shopping ~", f10, Brushes.Black, centermargin, 40 + height2, center)
        e.Graphics.DrawString("~ Purse Shop ~", f10, Brushes.Black, centermargin, 50 + height2, center)

    End Sub
    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click
        printingallinone()
    End Sub

    Sub printingallinone()
        changelongpaper()
        PPD.Document = PD
        PPD.StartPosition = FormStartPosition.CenterScreen
        PPD.ShowDialog()
        Loading()
    End Sub
    '--------------------End of Receipt Printing --------------- section 

    '-------------------Number Generating section ---------------------------
    Sub generate()

        For y As Integer = 1 To 6
            x = Date.Now.Year
            If y = 6 Then
                x += "000"
            End If
        Next
        For y As Integer = 1 To 6
            x += Convert.ToString(rand.Next(0, 9))

        Next
        container = x
        If container = x Then
            x = Nothing
        End If
    End Sub
    '-----------------------for filling the combobox
    Sub fillCustomer()
        Data_Load2("select * from customers ")
        comboCustomer.DataSource = mydata2
        comboCustomer.ValueMember = "CustomerID"
        comboCustomer.DisplayMember = "CustomerName"
    End Sub
    Sub Data_Load2(ByVal data As String)
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
            "password=12345; database=purseshop"
        Try
            mydata2.Clear()
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = data
            cmd.Connection = conn
            cmd.CommandText = SQL
            da.SelectCommand = cmd
            da.Fill(mydata2)
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Sub fillProducts()
        Data_Load3("select * from products ")
        ComboProducts.DataSource = mydata3
        ComboProducts.ValueMember = "ProductID"
        ComboProducts.DisplayMember = "ProductName"
    End Sub
    Sub Data_Load3(ByVal data As String)
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;" &
            "password=12345; database=purseshop"
        Try
            mydata3.Clear()
            If conn.State = ConnectionState.Closed Then conn.Open()
            SQL = data
            cmd.Connection = conn
            cmd.CommandText = SQL
            da.SelectCommand = cmd
            da.Fill(mydata3)
            conn.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub comboCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCustomer.SelectedIndexChanged

    End Sub
End Class