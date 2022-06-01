Public Class Form1
    Dim Pos As Point 'for making the form draggable
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Panel5.Controls.Clear()
        frmLogin.Show()
        Panel5.Controls.Clear()
        AllClose()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Panel5.Controls.Clear()
        AllClose()
        With frmProducts
            .TopLevel = False
            Panel5.Controls.Add(frmProducts)

            .BringToFront()

            .Anchor = AnchorStyles.Bottom
            .Anchor = AnchorStyles.Top
            .Anchor = AnchorStyles.Left
            .Anchor = AnchorStyles.Right
            Dock = DockStyle.Fill
            .Show()

        End With

    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Panel5.Controls.Clear()
        AllClose()
        With frmCustomers
            .TopLevel = False
            Panel5.Controls.Add(frmCustomers)
            .BringToFront()
            .Anchor = AnchorStyles.Bottom
            .Anchor = AnchorStyles.Top
            .Anchor = AnchorStyles.Left
            .Anchor = AnchorStyles.Right
            Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        Panel5.Controls.Clear()
        AllClose()
        With frmOrders
            .TopLevel = False
            Panel5.Controls.Add(frmOrders)
            .BringToFront()
            .Anchor = AnchorStyles.Bottom
            .Anchor = AnchorStyles.Top
            .Anchor = AnchorStyles.Left
            .Anchor = AnchorStyles.Right
            Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub btnOrderlist_Click(sender As Object, e As EventArgs) Handles btnOrderlist.Click
        Panel5.Controls.Clear()
        frmListofOrders.Loading()
        With frmListofOrders
            .TopLevel = False
            Panel5.Controls.Add(frmListofOrders)
            .BringToFront()
            .Anchor = AnchorStyles.Bottom
            .Anchor = AnchorStyles.Top
            .Anchor = AnchorStyles.Left
            .Anchor = AnchorStyles.Right
            Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub btnTasks_Click(sender As Object, e As EventArgs) Handles btnTasks.Click
        Panel5.Controls.Clear()
        frmTasks.Loading()
        With frmTasks
            .TopLevel = False
            Panel5.Controls.Add(frmTasks)
            .BringToFront()
            .Anchor = AnchorStyles.Bottom
            .Anchor = AnchorStyles.Top
            .Anchor = AnchorStyles.Left
            .Anchor = AnchorStyles.Right
            Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Panel5.Controls.Clear()
        With frmReports
            .TopLevel = False
            Panel5.Controls.Add(frmReports)
            .BringToFront()
            .Anchor = AnchorStyles.Bottom
            .Anchor = AnchorStyles.Top
            .Anchor = AnchorStyles.Left
            .Anchor = AnchorStyles.Right
            Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel5.Controls.Clear()
        With frmProducts
            .TopLevel = False
            Panel5.Controls.Add(frmProducts)

            .BringToFront()

            .Anchor = AnchorStyles.Bottom
            .Anchor = AnchorStyles.Top
            .Anchor = AnchorStyles.Left
            .Anchor = AnchorStyles.Right
            Dock = DockStyle.Fill
            .Show()

        End With
        Label1.Text = AccountFormat.username
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Panel5.Controls.Clear()
        With frmChangePassword
            .TopLevel = False
            Panel5.Controls.Add(frmChangePassword)
            .BringToFront()
            .Anchor = AnchorStyles.Bottom
            .Anchor = AnchorStyles.Top
            .Anchor = AnchorStyles.Left
            .Anchor = AnchorStyles.Right
            Dock = DockStyle.Fill
            .Show()
        End With
    End Sub
    Sub AllClose()
        frmProducts.Close()
        frmTasks.Close()
        frmChangePassword.Close()
        frmCustomers.Close()
        frmReports.Close()
        frmOrders.Close()
        frmListofOrders.Close()
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove, Panel2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

End Class
