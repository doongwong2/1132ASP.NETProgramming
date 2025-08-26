Public Class WebForm10
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Application.Lock()
        Application("Page_Counter") = Application("Page_Counter") + 1
        Application.UnLock()
        Label1.Text = "this page has loaded " & Application("Page_Counter") & " times"
    End Sub

End Class