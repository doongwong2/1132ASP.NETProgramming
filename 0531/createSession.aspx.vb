Public Class WebForm1
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
        Session("Username") = "bob"
        Session("UserPw") = "12345"
        Session("Email") = "123@mail.com"
        Label1.Text = "session created!"
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'CheckSession()
        If Session("UserName") IsNot Nothing Then
            DropDownList1.Items.Add(Session("Username").ToString)
            DropDownList1.Items.Add(Session("UserPw").ToString)
            DropDownList1.Items.Add(Session("Email").ToString)
        Else
            Label1.Text = "session does not exist"
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedIndex As Integer = DropDownList1.SelectedIndex

        If selectedIndex >= 0 Then
            DropDownList1.Items.RemoveAt(selectedIndex)
        End If
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DropDownList1.Items.Clear()
        Session.Abandon()
        Label1.Text = "session abandoned successfully."
    End Sub
End Class