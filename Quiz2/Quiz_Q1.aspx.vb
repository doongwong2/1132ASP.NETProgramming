Partial Class Quiz_Q1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dt As Date = Today
        If Page.IsPostBack And Input.Text <> "" Then
            Response.Write("<span style = 'color:blue'>" + dt.ToString("yyyy/M/d") + "</span> <span style = 'color:red'><b><u>" + Input.Text + "</b></u></span> Welcome to the Website!<br/>Current session id = " + Session.SessionID)
        End If

    End Sub
End Class
