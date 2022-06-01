<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnTasks = New System.Windows.Forms.Button()
        Me.btnOrderlist = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnChangePassword)
        Me.Panel1.Controls.Add(Me.btnReports)
        Me.Panel1.Controls.Add(Me.btnTasks)
        Me.Panel1.Controls.Add(Me.btnOrderlist)
        Me.Panel1.Controls.Add(Me.btnOrders)
        Me.Panel1.Controls.Add(Me.btnCustomers)
        Me.Panel1.Controls.Add(Me.btnProducts)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 621)
        Me.Panel1.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 582)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(235, 39)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "  Log-out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnChangePassword.FlatAppearance.BorderSize = 0
        Me.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnChangePassword.Image = CType(resources.GetObject("btnChangePassword.Image"), System.Drawing.Image)
        Me.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangePassword.Location = New System.Drawing.Point(0, 350)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnChangePassword.Size = New System.Drawing.Size(235, 34)
        Me.btnChangePassword.TabIndex = 9
        Me.btnChangePassword.Text = "  Change Password"
        Me.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnReports.Image = CType(resources.GetObject("btnReports.Image"), System.Drawing.Image)
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(0, 317)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnReports.Size = New System.Drawing.Size(235, 33)
        Me.btnReports.TabIndex = 8
        Me.btnReports.Text = "  Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnTasks
        '
        Me.btnTasks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTasks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTasks.FlatAppearance.BorderSize = 0
        Me.btnTasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTasks.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTasks.Image = CType(resources.GetObject("btnTasks.Image"), System.Drawing.Image)
        Me.btnTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTasks.Location = New System.Drawing.Point(0, 284)
        Me.btnTasks.Name = "btnTasks"
        Me.btnTasks.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnTasks.Size = New System.Drawing.Size(235, 33)
        Me.btnTasks.TabIndex = 7
        Me.btnTasks.Text = "  Tasks"
        Me.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTasks.UseVisualStyleBackColor = True
        '
        'btnOrderlist
        '
        Me.btnOrderlist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrderlist.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrderlist.FlatAppearance.BorderSize = 0
        Me.btnOrderlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnOrderlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrderlist.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOrderlist.Image = CType(resources.GetObject("btnOrderlist.Image"), System.Drawing.Image)
        Me.btnOrderlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrderlist.Location = New System.Drawing.Point(0, 251)
        Me.btnOrderlist.Name = "btnOrderlist"
        Me.btnOrderlist.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnOrderlist.Size = New System.Drawing.Size(235, 33)
        Me.btnOrderlist.TabIndex = 6
        Me.btnOrderlist.Text = "  Order List"
        Me.btnOrderlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrderlist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOrderlist.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrders.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrders.FlatAppearance.BorderSize = 0
        Me.btnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrders.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOrders.Image = CType(resources.GetObject("btnOrders.Image"), System.Drawing.Image)
        Me.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrders.Location = New System.Drawing.Point(0, 218)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnOrders.Size = New System.Drawing.Size(235, 33)
        Me.btnOrders.TabIndex = 5
        Me.btnOrders.Text = "  Orders"
        Me.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCustomers.Image = CType(resources.GetObject("btnCustomers.Image"), System.Drawing.Image)
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.Location = New System.Drawing.Point(0, 185)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnCustomers.Size = New System.Drawing.Size(235, 33)
        Me.btnCustomers.TabIndex = 4
        Me.btnCustomers.Text = "  Customers"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProducts.Image = CType(resources.GetObject("btnProducts.Image"), System.Drawing.Image)
        Me.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.Location = New System.Drawing.Point(0, 152)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnProducts.Size = New System.Drawing.Size(235, 33)
        Me.btnProducts.TabIndex = 3
        Me.btnProducts.Text = "  Products"
        Me.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 37)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(235, 115)
        Me.Panel4.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(64, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(235, 37)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(235, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(949, 37)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(905, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(235, 37)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(949, 584)
        Me.Panel5.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1184, 621)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnTasks As Button
    Friend WithEvents btnOrderlist As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
End Class
