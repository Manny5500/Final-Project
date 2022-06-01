Imports MySql.Data.MySqlClient
Imports System.Data
Public Class frmAddAccount
    Dim con As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim Pos As Point
    Private Sub Panel3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtRetype.Text = txtPassword.Text Then
            Try
                con = New MySqlConnection()
                con.ConnectionString = "server=localhost; userid=root; password=12345; database=purseshop"
                cmd.Connection = con
                cmd.CommandText = ("SELECT username,password FROM accounts WHERE username = @user and password = @pass;")
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUsername.Text
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPassword.Text
                da.SelectCommand = cmd
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MessageBox.Show("Username and password already existed", "Can't added", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf txtUsername.Text = "" Or txtPassword.Text = "" Or txtRetype.Text = "" Then
                    MessageBox.Show("Empty Fields", "Please fill out", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    cmd.CommandText = ("insert into accounts(username,password) values " & "('" & txtUsername.Text & "','" & txtRetype.Text & "')")
                    da.SelectCommand = cmd
                    da.Fill(dt)
                    MessageBox.Show("Successfully added, Redirecting to Login-Page", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim login As New frmLogin
                    login.Show()
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message.ToString)
            Finally
                cmd.Parameters.Clear()
                dt.Clear()
            End Try
        Else
            MessageBox.Show("Password Didn't Match", "Please Retype", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub frmAddAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class