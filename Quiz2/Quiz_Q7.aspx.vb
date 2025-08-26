
Partial Class Quiz_Q7
    Inherits System.Web.UI.Page

    Protected Sub First_SelectedIndexChanged(sender As Object, e As EventArgs) Handles First.SelectedIndexChanged
        Second.Items.Clear()
        Second.Items.Add("")
        Third.Items.Clear()
        Third.Items.Add("")
        If First.SelectedItem.Text = "Sunny" Then
            Second.Items.Add("Play Ball")
            Second.Items.Add("Go Swimming")
        ElseIf First.SelectedItem.Text = "Rainy" Then
            Second.Items.Add("Go Strolling")
            Second.Items.Add("Stay At Home")
        End If
    End Sub
    Protected Sub Second_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Second.SelectedIndexChanged
        Third.Items.Clear()
        Third.Items.Add("")
        If Second.SelectedItem.Text = "Play Ball" Then
            Third.Items.Add("Basketball")
            Third.Items.Add("Volleyball")
        ElseIf Second.SelectedItem.Text = "Go Swimming" Then
            Third.Items.Add("Freestyle")
            Third.Items.Add("Frog-style")
        ElseIf Second.SelectedItem.Text = "Go Strolling" Then
            Third.Items.Add("Department Store")
            Third.Items.Add("Big Market Place")
        ElseIf Second.SelectedItem.Text = "Stay At Home" Then
            Third.Items.Add("Play Online Game")
            Third.Items.Add("Sleep")
        End If
    End Sub
End Class