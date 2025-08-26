Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Title = "ch4_2"
        showEvent("Page_Load event triggered<br/>")
    End Sub

    Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Title = "ch4_2"
        showEvent("Page_PreInit event triggered<br/>")
    End Sub

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Title = "ch4_2"
        showEvent("Page_PreRender event triggered<br/>")
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Page.Title = "ch4_2"
        showEvent("Page_Unload event triggered<br/>")
    End Sub

    Sub showEvent(str As String)
        Label1.Text &= str
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height As Double = CDbl(TextBox4.Text) / 100
        Dim weight As Double = CDbl(TextBox3.Text)

        Label2.Text = ""
        Label2.Text &= TextBox1.Text & "<br/>"
        Label2.Text &= TextBox2.Text & "<br/>"
        Label2.Text &= Format((weight / (height * height)), ".00") & "<br/>"
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Text = "<hr/>" & Now & "<br/>"
        Label3.Text &= "said" & Replace(TextBox5.Text, vbNewLine, "<br/>")
    End Sub
End Class