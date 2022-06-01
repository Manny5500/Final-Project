Imports MySql.Data.MySqlClient
Imports System.Data
Public Class frmChangePassword
    Dim con As MySqlConnection
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If txtRetype.Text <> txtNewPass.Text Then
            MessageBox.Show("Password Don't Match", "Can't changed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf AccountFormat.username = "" Or txtCurrentPass.Text = "" Or txtNewPass.Text = "" Or txtRetype.Text = "" Then
            MessageBox.Show("Empty Fields", "Please fill out", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                con = New MySqlConnection()
                con.ConnectionString = "server=localhost; userid=root; password=12345; database=purseshop"
                cmd.Connection = con
                ' cmd.CommandText = "SELECT id FROM accounts WHERE username = @user;"
                cmd.CommandText = ("SELECT userid FROM accounts WHERE username = @user and password= @pass; Update accounts set password = '" & txtRetype.Text & "' where username=@user and password = @pass;")

                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = AccountFormat.username
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtCurrentPass.Text
                da.SelectCommand = cmd

                da.Fill(dt)

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("Invalid Username / Password", "Can't changed", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    MessageBox.Show("Password Changed", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCurrentPass.Clear()
                    txtNewPass.Clear()
                    txtRetype.Clear()

                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message.ToString)
            Finally
                cmd.Parameters.Clear()
                dt.Clear()
            End Try
        End If
    End Sub

    Private Sub txtRetype_TextChanged(sender As Object, e As EventArgs) Handles txtRetype.TextChanged

    End Sub
End Class