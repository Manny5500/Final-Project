<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTasks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTasks))
        Me.txtAddWorker = New System.Windows.Forms.Button()
        Me.btnEditInfo = New System.Windows.Forms.Button()
        Me.btnAddTask = New System.Windows.Forms.Button()
        Me.btnPrintPay = New System.Windows.Forms.Button()
        Me.btnDeleteTask = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AccountReader = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAddWorker
        '
        Me.txtAddWorker.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.txtAddWorker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtAddWorker.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddWorker.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAddWorker.Location = New System.Drawing.Point(112, 385)
        Me.txtAddWorker.Name = "txtAddWorker"
        Me.txtAddWorker.Size = New System.Drawing.Size(85, 30)
        Me.txtAddWorker.TabIndex = 59
        Me.txtAddWorker.Text = "Add Worker"
        Me.txtAddWorker.UseVisualStyleBackColor = False
        '
        'btnEditInfo
        '
        Me.btnEditInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnEditInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditInfo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEditInfo.Location = New System.Drawing.Point(357, 385)
        Me.btnEditInfo.Name = "btnEditInfo"
        Me.btnEditInfo.Size = New System.Drawing.Size(85, 30)
        Me.btnEditInfo.TabIndex = 58
        Me.btnEditInfo.Text = "Edit Task"
        Me.btnEditInfo.UseVisualStyleBackColor = False
        '
        'btnAddTask
        '
        Me.btnAddTask.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTask.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTask.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddTask.Location = New System.Drawing.Point(236, 385)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(85, 30)
        Me.btnAddTask.TabIndex = 57
        Me.btnAddTask.Text = "Add Task"
        Me.btnAddTask.UseVisualStyleBackColor = False
        '
        'btnPrintPay
        '
        Me.btnPrintPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnPrintPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintPay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPay.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPrintPay.Location = New System.Drawing.Point(602, 385)
        Me.btnPrintPay.Name = "btnPrintPay"
        Me.btnPrintPay.Size = New System.Drawing.Size(85, 30)
        Me.btnPrintPay.TabIndex = 56
        Me.btnPrintPay.Text = "Print Pay Slip"
        Me.btnPrintPay.UseVisualStyleBackColor = False
        '
        'btnDeleteTask
        '
        Me.btnDeleteTask.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnDeleteTask.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteTask.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteTask.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDeleteTask.Location = New System.Drawing.Point(484, 385)
        Me.btnDeleteTask.Name = "btnDeleteTask"
        Me.btnDeleteTask.Size = New System.Drawing.Size(85, 30)
        Me.btnDeleteTask.TabIndex = 55
        Me.btnDeleteTask.Text = "Delete Task"
        Me.btnDeleteTask.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Location = New System.Drawing.Point(51, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(713, 237)
        Me.DataGridView1.TabIndex = 54
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(51, 69)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(211, 28)
        Me.txtSearch.TabIndex = 53
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(255, 69)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'AccountReader
        '
        Me.AccountReader.AutoSize = True
        Me.AccountReader.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountReader.Location = New System.Drawing.Point(365, 22)
        Me.AccountReader.Name = "AccountReader"
        Me.AccountReader.Size = New System.Drawing.Size(66, 30)
        Me.AccountReader.TabIndex = 61
        Me.AccountReader.Text = "Tasks"
        '
        'frmTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 489)
        Me.Controls.Add(Me.AccountReader)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtAddWorker)
        Me.Controls.Add(Me.btnEditInfo)
        Me.Controls.Add(Me.btnAddTask)
        Me.Controls.Add(Me.btnPrintPay)
        Me.Controls.Add(Me.btnDeleteTask)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTasks"
        Me.Text = "frmTasks"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAddWorker As Button
    Friend WithEvents btnEditInfo As Button
    Friend WithEvents btnAddTask As Button
    Friend WithEvents btnPrintPay As Button
    Friend WithEvents btnDeleteTask As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AccountReader As Label
End Class
