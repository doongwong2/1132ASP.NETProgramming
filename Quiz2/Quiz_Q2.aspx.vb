
Partial Class Quiz_Q2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        For i = 0 To Options.Items.Count - 1
            If Options.Items(i).Selected Then
                If Output.Visible = False Then Output.Visible = True
                If Options.Items(i).Value = "Type" Then
                    Output.Text = "Chrome113"
                ElseIf Options.Items(i).Value = "Name" Then
                    Output.Text = "Chrome"
                ElseIf Options.Items(i).Value = "Version" Then
                    Output.Text = "113.0"
                ElseIf Options.Items(i).Value = "Platform" Then
                    Output.Text = "WinNT"
                ElseIf Options.Items(i).Value = "Show" Then
                    Output.Text = "Browser Type = Chrome113<br/>Browser Name = Chrome<br/>Browser Version = 113.0<br/>Operating System Platform = WinNT<br/>"
                End If
            End If
        Next i

    End Sub
End Class