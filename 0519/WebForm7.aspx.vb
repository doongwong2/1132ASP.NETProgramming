Public Class WebForm7
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Cookies("User")("Name") = Server.UrlEncode("John Wick")
        Response.Cookies("User")("ID") = "69420"
        Response.Cookies("User").Expires = DateAdd("D", 10, Today)
        Label1.Text = "created multivalue cookie"
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name, no As String
        If Request.Cookies("User") IsNot Nothing Then
            name = Server.UrlDecode(Request.Cookies("User")("Name"))
            no = Request.Cookies("User")("ID")
            Label1.Text = "name: " & name & "<br/>"
            Label1.Text &= "no: " & no & "<br/>"
        Else
            Label1.Text = "multivalue cookie does not exist!"
        End If
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dtDay As Date = DateAdd("D", -365, Today)
        Response.Cookies("User").Expires = dtDay
        Label1.Text = "multivalue cookie removed"
    End Sub
End Class