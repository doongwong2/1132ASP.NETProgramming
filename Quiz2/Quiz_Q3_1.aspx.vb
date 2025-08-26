
Partial Class Quiz_Q3_1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Request.Cookies("User") IsNot Nothing Then
            Dim Username As String = Server.UrlDecode(Request.Cookies("User")("Name"))
            Dim Password As String = Server.UrlDecode(Request.Cookies("User")("Pass"))
            Output.Text = "Username = " + Username + "<br/>Password = " + Password
        End If
    End Sub

    Protected Sub Erase_Click(sender As Object, e As EventArgs) Handles [Erase].Click
        Dim dtDay As Date = DateAdd("D", -365, Today)
        Response.Cookies("User").Expires = dtDay
        Output.Text = "Username =<br/>Password =<br/>"
    End Sub
End Class
