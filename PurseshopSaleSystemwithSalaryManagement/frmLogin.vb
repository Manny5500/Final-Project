Imports MySql.Data.MySqlClient
Imports System.Data

Public Class frmLogin
    Dim Pos As Point
    Dim con As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim rd As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AccountFormat.username = txtUsername.Text
        Try
            con = New MySqlConnection()
            con.ConnectionString = "server=localhost; userid=root; password=12345; database=purseshop"
            cmd.Connection = con
            cmd.CommandText = "SELECT username,password FROM accounts WHERE username = @user and password = @pass;"

            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUsername.Text
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPassword.Text
            con.Open()
            rd = cmd.ExecuteReader
            With rd
                If .Read Then
                    If StrComp(txtPassword.Text, rd.GetValue(1), 0) = 0 Then
                        MessageBox.Show("Logged-in successfully", "Log-in", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Form1.Show()
                        Me.Close()
                    Else
                        MessageBox.Show("Wrong Password", "Can't log-in ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Invalid username or password", "Can't log-in ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message.ToString)
        Finally
            cmd.Parameters.Clear()
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim addaccount As New frmAddAccount
        addaccount.Show()
        Me.Close()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Panel3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
End Class

'--------------------This code is for case sensitive password and username---------------------------'
