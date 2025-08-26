Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = TextBox1.Text
        Dim pw As String = TextBox2.Text

        Response.Redirect("Webform2.aspx?User=" & Server.UrlEncode(name) & "&pw=" & pw)
    End Sub
End Class