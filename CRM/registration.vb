Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic






Public Class registration

    Dim con As New SqlConnection("Data Source=DESKTOP-U7T6BFD;Initial Catalog=CRM;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim gender As String


    Private Sub registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Connection = con


    End Sub
    'Private Sub BrowsePic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim ImageDialogue As OpenFileDialog = New OpenFileDialog()

    '    ImageDialogue.Title = "Select your Image."
    '    ImageDialogue.InitialDirectory = "C:\"
    '    ImageDialogue.Filter = "Image Files|*.gif;*.jpg;*.png;*.bmp;"
    '    ImageDialogue.RestoreDirectory = False

    '    If ImageDialogue.ShowDialog() = DialogResult.OK Then
    '        PictureBox.Image = Image.FromFile(ImageDialogue.FileName)
    '    End If

    'End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim email As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Dim cemail As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Dim num As New Regex("^([+][9][1]|[9][1]|[0]){0,1}([7-9]{1})([0-9]{9})$")

        If txtname.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Or txtcnfpassword.Text = "" Then
            MsgBox("Required Fields are Empty")


        ElseIf txtpassword.Text = txtcnfpassword.Text Then

            If email.IsMatch(txtemail.Text) Or txtemail.Text = "" Then
                If num.IsMatch(txtmobile.Text) Or txtmobile.Text = "" Then

                    con.Open()
                    cmd.CommandText = "insert into regi(name,gender,dob,add1,add2,city,state,country,email,mobile,telephone,fax,c_name,c_contact,c_add1,c_add2,c_city,c_state,c_email,website,username,password) values('" & txtname.Text & "','" & gender & "','" & DateTimePicker1.Value.Date & "','" & txtaddressline1.Text & "' ,'" & txtaddressline2.Text & "', '" & txtcity.Text & "','" & txtstate.Text & "','" & txtcountry.Text & "','" & txtemail.Text & "', '" & txtmobile.Text & "', '" & txttelnumber.Text & "','" & txtfax.Text & "', '" & txtcompanyname.Text & "','" & txtcompanycontact.Text & "','" & txtcomaddline1.Text & "','" & txtcomaddline2.Text & "','" & txtcompcity.Text & "','" & txtcompstate.Text & "','" & txtcompanyemail.Text & "','" & txtwebsite.Text & "', '" & txtusername.Text & "','" & txtpassword.Text & "')"
                    cmd.ExecuteNonQuery()
                    MsgBox("Registration Successfully Completed")
                    Me.Close()

                    Login.Show()
                Else
                    MsgBox("Invalid number")
                End If
            Else
                    MsgBox("Invalid Email")
            End If
        Else
                MsgBox("Password Does not Match")

        End If

    End Sub

    Private Sub rbtnmale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnmale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub rbtnfemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnfemale.CheckedChanged
        gender = "Female"
    End Sub



    'Private Sub txtmobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmobile.KeyPress
    '    If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
    '        e.Handled = False
    '        MsgBox("Numbers Only")
    '    End If
    'End Sub
End Class