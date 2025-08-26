Public Class WebForm6
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim name As String
        If Request.Cookies("User") IsNot Nothing Then
            name = Server.UrlDecode(Request.Cookies("User").Value)
            Label1.Text = "Cookie value: " & name
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dtDay As Date = DateAdd("D", -365, Today)
        Response.Cookies("User").Expires = dtDay ' delete cookie
        Response.Redirect("WebForm5.aspx")
    End Sub
End Class