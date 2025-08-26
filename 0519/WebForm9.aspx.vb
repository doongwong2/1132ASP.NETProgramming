Public Class WebForm9
    Inherits System.Web.UI.Page
    Sub CheckSession()
        Dim name, pw As String
        If Session("UserName") IsNot Nothing Then
            name = Session("Username")
            pw = Session("UserPw")
            Label1.Text = "Session ID: " & Session.SessionID & "<br/>"
            Label1.Text &= "name: " & name & "<br/>" & "pw: " & pw & "<br/>"
        Else
            Label1.Text = "session does not exist"
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'CheckSession()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Session.Abandon()
        Label1.Text = "session abandoned successfully."
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckSession()
    End Sub
End Class