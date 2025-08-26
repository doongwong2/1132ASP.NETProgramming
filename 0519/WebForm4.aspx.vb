Public Class WebForm4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim h, w As Double
            Dim txt As TextBox
            txt = PreviousPage.FindControl("TextBox1")
            w = CDbl(txt.Text)
            txt = PreviousPage.FindControl("TextBox2")
            h = CDbl(txt.Text) / 100.0
            Label1.Text = "BMI: " & Format((w / h / h), ".00")
        End If
    End Sub

End Class