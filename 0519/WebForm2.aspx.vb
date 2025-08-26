Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim name, pw As String
        name = Server.UrlDecode(Request.QueryString("User"))
        pw = Request.QueryString("pw")
        Label1.Text = "name: " & name & "<br/>" & "pw: " & pw & "<br/>"
    End Sub

End Class