
Partial Class Quiz_Q3
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None
    End Sub


    Protected Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignUp.Click
        If Page.IsValid Then
            Dim name As String = Username.Text
            Dim pass As String = Password.Text
            Response.Cookies("User")("Name") = Server.UrlEncode(name)
            Response.Cookies("User")("Pass") = Server.UrlEncode(pass)
            Response.Cookies("User").Expires = DateAdd("D", 10, Today)
            Response.Redirect("Quiz_Q3_1.aspx")
        End If
    End Sub
End Class
