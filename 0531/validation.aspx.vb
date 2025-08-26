Public Class WebForm3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Protected Sub CustomValidator1_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles CustomValidator1.ServerValidate
        Dim username As String = TextBox1.Text.ToString()

        If username.ToLower().Contains("admin") Or username.StartsWith("0") Then
            args.IsValid = False
            Label1.Text = ""
        Else
            args.IsValid = True
            Label1.Text = "your username is: " & username
        End If
    End Sub
End Class