
Partial Class Quiz_Q5
    Inherits System.Web.UI.Page

    Protected Sub Faculty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Faculty.SelectedIndexChanged
        Chosen.Text = Faculty.SelectedItem.Text
    End Sub
    Protected Sub SchoolArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SchoolArea.SelectedIndexChanged
        Chosen.Text = ""
        If SchoolArea.SelectedItem.Value = "School" Then
            Faculty.Items.Clear()
            Faculty.Items.Add("Social Culture Faculty")
            Faculty.Items.Add("Life Science Faculty")
        ElseIf SchoolArea.SelectedItem.Value = "Binhai" Then
            Faculty.Items.Clear()
            Faculty.Items.Add("Computer Electrical Faculty")
            Faculty.Items.Add("Engineering Faculty")
        Else
            Faculty.Items.Clear()
        End If
    End Sub
End Class
