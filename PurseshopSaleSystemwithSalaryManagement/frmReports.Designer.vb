<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.AccountReader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPay.FlatAppearance.BorderSize = 0
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPay.Location = New System.Drawing.Point(417, 229)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(85, 30)
        Me.btnPay.TabIndex = 47
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'btnSales
        '
        Me.btnSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSales.Location = New System.Drawing.Point(315, 229)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(85, 30)
        Me.btnSales.TabIndex = 46
        Me.btnSales.Text = "Sales"
        Me.btnSales.UseVisualStyleBackColor = False
        '
        'AccountReader
        '
        Me.AccountReader.AutoSize = True
        Me.AccountReader.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountReader.Location = New System.Drawing.Point(365, 22)
        Me.AccountReader.Name = "AccountReader"
        Me.AccountReader.Size = New System.Drawing.Size(85, 30)
        Me.AccountReader.TabIndex = 62
        Me.AccountReader.Text = "Reports"
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 489)
        Me.Controls.Add(Me.AccountReader)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReports"
        Me.Text = "frmReports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPay As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents AccountReader As Label
End Class
