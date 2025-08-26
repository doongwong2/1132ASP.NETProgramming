Public Class WebForm8
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Session("Username") = TextBox1.Text
        Session("UserPw") = TextBox2.Text
        Response.Redirect("Webform9.aspx")
    End Sub
End Class