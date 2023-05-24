Imports System.DirectoryServices.ActiveDirectory
Imports System.Text.RegularExpressions

Public Class Form4
    Private Sub txtN1_TextChanged(sender As Object, e As EventArgs) Handles txtN1.TextChanged
        txtN1.Text = Regex.Replace(txtN1.Text, "[^0-9]", "");
    End Sub

    Private Sub txtN2_TextChanged(sender As Object, e As EventArgs) Handles txtN2.TextChanged
        txtN2.Text = Regex.Replace(txtN2.Text, "[^0-9]", "");

    End Sub
End Class


