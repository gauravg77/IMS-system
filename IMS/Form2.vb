Imports Microsoft.Data.SqlClient

Public Class Form2
    Dim connection As New SqlConnection("Data Source = THEG \ SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True")
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim username As String = TextBoxusername.Text
        Dim password As String = TextBoxpassword.Text
        Dim confirmpassword As String = TextBoxConfirmpassword.Text
        If TextBoxConfirmpassword.Text = TextBoxpassword.Text Then
            Dim command As New SqlCommand("insert into tblsignup(Adminusername,Password)values ('" & TextBoxusername.Text & "','" & TextBoxpassword.Text & "')", connection) 'sqlcommand lai duita parameter chaincha, one is query ani another is the variable for sql connection
            connection.Open()
            MessageBox.Show("Admin Added")
            If TextBoxConfirmpassword.Text <> TextBoxpassword.Text Then
                MessageBox.Show("PASSWORD IS NOT CORRECT")
            End If

        End If
        connection.Close()
        MessageBox.Show("user not added")

    End Sub




End Class