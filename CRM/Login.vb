Imports System.Data.SqlClient

Public Class Login

    Dim con As New SqlConnection("Data Source=DESKTOP-U7T6BFD;Initial Catalog=CRM;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        registration.Show()
        Me.Hide()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        cmd.Connection = con

        If txtusername.Text = "" And txtpassword.Text = "" Then
            MsgBox("Username and Password Required")
        Else
            con.Open()
            cmd.CommandText = "select username,password from regi where username='" & txtusername.Text & "' and password='" & txtpassword.Text & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Me.Hide()
                Dashboard.Show()


            Else
                MsgBox("Invalid Username or Password")
            End If
            con.Close()
        End If


    End Sub
End Class
