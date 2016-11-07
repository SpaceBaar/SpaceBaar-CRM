Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Dashboard
    'Connection
    Dim con As New SqlConnection("Data Source=TECHCHUMS;Initial Catalog=CRM;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader

    'PageLoad
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CRMDataSet4.Contacts' table. You can move, or remove it, as needed.
        Me.ContactsTableAdapter2.Fill(Me.CRMDataSet4.Contacts)
        'TODO: This line of code loads data into the 'CRMDataSetLeads.leads' table. You can move, or remove it, as needed.
        Me.LeadsTableAdapter.Fill(Me.CRMDataSetLeads.leads)
        'TODO: This line of code loads data into the 'CRMDataSet3.Contacts' table. You can move, or remove it, as needed.
        'Me.ContactsTableAdapter1.Fill(Me.CRMDataSet3.Contacts)
        'TODO: This line of code loads data into the 'CRMDataSet2.Contacts' table. You can move, or remove it, as needed.
        'Me.ContactsTableAdapter.Fill(Me.CRMDataSet2.Contacts)
        'TODO: This line of code loads data into the 'CRMDataSet1.regi' table. You can move, or remove it, as needed.
        'Me.RegiTableAdapter.Fill(Me.CRMDataSet1.regi)
        'Panelcreate.Hide()
        CrtLeads.Hide()
        cmd.Connection = con
    End Sub


    'Start of Contact tab Coding
    Private Sub btncreatecontact_Click(sender As Object, e As EventArgs) Handles btncreatecontact.Click
        Panelcreate.Show()
    End Sub




    Private Sub chkalt_CheckedChanged(sender As Object, e As EventArgs) Handles chkalt.CheckedChanged
        If chkalt.Checked = True Then
            txtaltcity.Text = concity.Text
            txtaltcountry.Text = concountry.Text
            txtaltpost.Text = concode.Text
            txtaltstate.Text = constate.Text
            txtaltstreet.Text = constreet.Text
        End If
        If chkalt.Checked = False Then
            txtaltcity.Text = ""
            txtaltcountry.Text = ""
            txtaltpost.Text = ""
            txtaltstate.Text = ""
            txtaltstreet.Text = ""
        End If
    End Sub
    Private Sub btnconsave_Click(sender As Object, e As EventArgs) Handles btnconsave.Click
        Dim num As New Regex("^([+][9][1]|[9][1]|[0]){0,1}([7-9]{1})([0-9]{9})$")
        Dim email As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        If confirstname.Text = "" Or conmobile.Text = "" Then
            MsgBox("Required Fields are Empty")
        Else

            If email.IsMatch(conemail.Text) Or conemail.Text = "" Then
                If num.IsMatch(conmobile.Text) Then
                    con.Open()
                    cmd.CommandText = "insert into Contacts(fname,street,city,state,code,country,email,phone,mobile,altstreet,altcity,altstate,altcode,altcountry,profession,designation,cname,cadd,website) values('" & confirstname.Text & "','" & constreet.Text & "','" & concity.Text & "', '" & constate.Text & "','" & concode.Text & "','" & concountry.Text & "','" & conemail.Text & "',
'" & conphone.Text & "','" & conmobile.Text & "','" & txtaltstreet.Text & "','" & txtaltcity.Text & "','" & txtaltstate.Text & "','" & txtaltpost.Text & "','" & txtaltcountry.Text & "',
'" & ComboBox1.SelectedText.ToString() & "','" & condesi.Text & "','" & concomname.Text & "','" & conadd.Text & "','" & conweb.Text & "')"

                    cmd.ExecuteNonQuery()
                    MsgBox("Contact Save Successfully")
                    confirstname.Text = ""
                    conemail.Text = ""
                    constreet.Text = ""
                    concity.Text = ""
                    constate.Text = ""
                    concode.Text = ""
                    concountry.Text = ""
                    conphone.Text = ""
                    conmobile.Text = ""
                    txtaltstreet.Text = ""
                    txtaltcity.Text = ""
                    txtaltstate.Text = ""
                    txtaltpost.Text = ""
                    txtaltcountry.Text = ""
                    ComboBox1.SelectedIndex = -1
                    condesi.Text = ""
                    concomname.Text = ""
                    conadd.Text = ""
                    conweb.Text = ""

                Else
                    MsgBox("Invalid Mobile Number")
                End If
            Else
                MsgBox("Invalid Email")
            End If

        End If
        con.Close()
    End Sub

    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles conlistbox.SelectedValueChanged
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from Contacts where fname='" & conlistbox.SelectedValue & "'"
        dr = cmd.ExecuteReader()
        If dr.HasRows() Then
            dr.Read()
            confirstname.Text = dr.Item("fname")
            conemail.Text = dr.Item("email")
            constreet.Text = dr.Item("street")
            concity.Text = dr.Item("city")
            constate.Text = dr.Item("state")
            concode.Text = dr.Item("code")
            concountry.Text = dr.Item("country")
            conphone.Text = dr.Item("phone")
            conmobile.Text = dr.Item("mobile")
            txtaltstreet.Text = dr.Item("altstreet")
            txtaltcity.Text = dr.Item("altcity")
            txtaltstate.Text = dr.Item("altstate")
            txtaltpost.Text = dr.Item("altcode")
            txtaltcountry.Text = dr.Item("altcountry")
            ComboBox1.SelectedText = dr.Item("profession")
            condesi.Text = dr.Item("designation")
            concomname.Text = dr.Item("cname")
            conadd.Text = dr.Item("cadd")
            conweb.Text = dr.Item("website")
            dr.Close()
        End If
        con.Close()
    End Sub
    Private Sub btnconupdate1_Click(sender As Object, e As EventArgs) Handles btnconupdate1.Click

    End Sub
    Private Sub btnconreset_Click(sender As Object, e As EventArgs) Handles btnconreset.Click
        confirstname.Text = ""
        conemail.Text = ""
        constreet.Text = ""
        concity.Text = ""
        constate.Text = ""
        concode.Text = ""
        concountry.Text = ""
        conphone.Text = ""
        conmobile.Text = ""
        txtaltstreet.Text = ""
        txtaltcity.Text = ""
        txtaltstate.Text = ""
        txtaltpost.Text = ""
        txtaltcountry.Text = ""
        ComboBox1.SelectedIndex = -1
        condesi.Text = ""
        concomname.Text = ""
        conadd.Text = ""
        conweb.Text = ""

    End Sub

    Private Sub btncondelete_Click(sender As Object, e As EventArgs) Handles btncondelete.Click
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "delete from Contacts where fname='" & conlistbox.SelectedValue & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Contact Deleted.")

        con.Close()
    End Sub

    'End of Contact tab Coding


    'Start of Lead Tab Coding
    Private Sub btncleads_Click(sender As Object, e As EventArgs)
        CrtLeads.Show()
    End Sub

    Private Sub btnleads_Click(sender As Object, e As EventArgs) Handles btnleads.Click
        CrtLeads.Show()
    End Sub


    Private Sub btnldcancel_Click(sender As Object, e As EventArgs) Handles btnldcancel.Click
        CrtLeads.Hide()
    End Sub

    Private Sub btncanclead_Click(sender As Object, e As EventArgs)
        CrtLeads.Hide()
    End Sub

    Private Sub btnldsave_Click(sender As Object, e As EventArgs) Handles btnldsave.Click
        con.Open()
        cmd.CommandText = "insert into leads(f_name,dept,website,p_addstreet,p_city,p_state,p_poscode,p_country,email,profession,designation,co_name,co_add,co_website,office_no,mob_no,a_addstreet,a_city,a_state,a_poscode,a_country,a_samepadd,lead_status,lead_source,emp_name,lead_desc,do_not_call) values('" & ldfname.Text & "','" & lddept.Text & "','" & ldwebsite.Text & "', '" & ldaddstreet.Text & "','" & ldcity.Text & "','" & ldstate.Text & "','" & ldposcode.Text & "',
'" & ldcountry.Text & "','" & ldemail.Text & "','" & ldprofession.SelectedItem.ToString() & "','" & lddesign.Text & "','" & ldconm.Text & "','" & ldcoadd.Text & "','" & ldcowsite.Text & "',
'" & ldoffno.Text & "','" & ldmobno.Text & "','" & ldaltaddstreet.Text & "','" & ldaltcity.Text & "','" & ldaltstate.Text & "','" & ldaltposcode.Text & "','" & ldaltcountry.Text & "','" & ldchkaltpadd.CheckState & "','" & ldstatus.SelectedItem.ToString() & "','" & ldsource.SelectedItem.ToString() & "','" & ldempnm.Text & "','" & lddesc.Text & "','" & ldchknotcall.CheckState & "')"

        cmd.ExecuteNonQuery()
        MsgBox("Contact Save Successfully")

        con.Close()
    End Sub

    Private Sub ldchkaltpadd_CheckedChanged(sender As Object, e As EventArgs) Handles ldchkaltpadd.CheckedChanged
        ldaltaddstreet.Text = ldaddstreet.Text
        ldaltcity.Text = ldcity.Text
        ldaltstate.Text = ldstate.Text
        ldaltposcode.Text = ldposcode.Text
        ldaltcountry.Text = ldcountry.Text
    End Sub
    'End of Lead Tab Coding




End Class