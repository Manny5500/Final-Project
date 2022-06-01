<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.comboCustomer = New System.Windows.Forms.ComboBox()
        Me.txtDueDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddtoList = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSaveOrder = New System.Windows.Forms.Button()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblOrderNoTrue = New System.Windows.Forms.Label()
        Me.txtAmountDue = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AccountReader = New System.Windows.Forms.Label()
        Me.ComboProducts = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comboCustomer
        '
        Me.comboCustomer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.comboCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboCustomer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCustomer.FormattingEnabled = True
        Me.comboCustomer.Location = New System.Drawing.Point(110, 68)
        Me.comboCustomer.Name = "comboCustomer"
        Me.comboCustomer.Size = New System.Drawing.Size(211, 21)
        Me.comboCustomer.TabIndex = 96
        '
        'txtDueDate
        '
        Me.txtDueDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDueDate.CustomFormat = "yyyy-MM-dd"
        Me.txtDueDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDueDate.Location = New System.Drawing.Point(110, 268)
        Me.txtDueDate.Name = "txtDueDate"
        Me.txtDueDate.Size = New System.Drawing.Size(211, 22)
        Me.txtDueDate.TabIndex = 95
        Me.txtDueDate.Value = New Date(2022, 4, 21, 0, 0, 0, 0)
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(110, 228)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(211, 21)
        Me.txtDescription.TabIndex = 94
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 228)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Description"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(110, 309)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(211, 21)
        Me.txtTotal.TabIndex = 92
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Total"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 268)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Due Date"
        '
        'txtQuantity
        '
        Me.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(110, 188)
        Me.txtQuantity.Multiline = True
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(211, 21)
        Me.txtQuantity.TabIndex = 89
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 188)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Quantity"
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(110, 148)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(211, 21)
        Me.txtPrice.TabIndex = 87
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Price"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Product Name"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDelete.Location = New System.Drawing.Point(177, 350)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 30)
        Me.btnDelete.TabIndex = 83
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAddtoList
        '
        Me.btnAddtoList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddtoList.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAddtoList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddtoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddtoList.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoList.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddtoList.Location = New System.Drawing.Point(72, 350)
        Me.btnAddtoList.Name = "btnAddtoList"
        Me.btnAddtoList.Size = New System.Drawing.Size(85, 30)
        Me.btnAddtoList.TabIndex = 80
        Me.btnAddtoList.Text = "Add to List"
        Me.btnAddtoList.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Costumer Name"
        '
        'btnSaveOrder
        '
        Me.btnSaveOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnSaveOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveOrder.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveOrder.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSaveOrder.Location = New System.Drawing.Point(477, 350)
        Me.btnSaveOrder.Name = "btnSaveOrder"
        Me.btnSaveOrder.Size = New System.Drawing.Size(83, 30)
        Me.btnSaveOrder.TabIndex = 99
        Me.btnSaveOrder.Text = "Save Order"
        Me.btnSaveOrder.UseVisualStyleBackColor = False
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintReceipt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintReceipt.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPrintReceipt.Location = New System.Drawing.Point(566, 350)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(83, 30)
        Me.btnPrintReceipt.TabIndex = 98
        Me.btnPrintReceipt.Text = "Print Receipt"
        Me.btnPrintReceipt.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(339, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(465, 276)
        Me.DataGridView1.TabIndex = 97
        '
        'lblOrderNoTrue
        '
        Me.lblOrderNoTrue.AutoSize = True
        Me.lblOrderNoTrue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNoTrue.Location = New System.Drawing.Point(383, 436)
        Me.lblOrderNoTrue.Name = "lblOrderNoTrue"
        Me.lblOrderNoTrue.Size = New System.Drawing.Size(0, 13)
        Me.lblOrderNoTrue.TabIndex = 102
        '
        'txtAmountDue
        '
        Me.txtAmountDue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountDue.Location = New System.Drawing.Point(459, 420)
        Me.txtAmountDue.Multiline = True
        Me.txtAmountDue.Name = "txtAmountDue"
        Me.txtAmountDue.Size = New System.Drawing.Size(211, 28)
        Me.txtAmountDue.TabIndex = 101
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(355, 423)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Amount Due"
        '
        'AccountReader
        '
        Me.AccountReader.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AccountReader.AutoSize = True
        Me.AccountReader.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountReader.Location = New System.Drawing.Point(346, 22)
        Me.AccountReader.Name = "AccountReader"
        Me.AccountReader.Size = New System.Drawing.Size(77, 30)
        Me.AccountReader.TabIndex = 103
        Me.AccountReader.Text = "Orders"
        '
        'ComboProducts
        '
        Me.ComboProducts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboProducts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboProducts.FormattingEnabled = True
        Me.ComboProducts.Location = New System.Drawing.Point(110, 108)
        Me.ComboProducts.Name = "ComboProducts"
        Me.ComboProducts.Size = New System.Drawing.Size(212, 21)
        Me.ComboProducts.TabIndex = 104
        '
        'frmOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 489)
        Me.Controls.Add(Me.ComboProducts)
        Me.Controls.Add(Me.AccountReader)
        Me.Controls.Add(Me.lblOrderNoTrue)
        Me.Controls.Add(Me.txtAmountDue)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSaveOrder)
        Me.Controls.Add(Me.btnPrintReceipt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.comboCustomer)
        Me.Controls.Add(Me.txtDueDate)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddtoList)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOrders"
        Me.Text = "frmOrders"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboCustomer As ComboBox
    Friend WithEvents txtDueDate As DateTimePicker
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAddtoList As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSaveOrder As Button
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblOrderNoTrue As Label
    Friend WithEvents txtAmountDue As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents AccountReader As Label
    Friend WithEvents ComboProducts As ComboBox
End Class
