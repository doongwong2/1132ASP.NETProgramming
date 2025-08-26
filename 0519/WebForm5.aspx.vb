Public Class WebForm5
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = "John"

        Response.Cookies("User").Value = Server.UrlEncode(name)
        Dim dtDay As Date = DateAdd("D", 10, Today)
        Response.Cookies("User").Expires = dtDay
        Label1.Text = "cookie created"
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("WebForm6.aspx")
    End Sub
End Class