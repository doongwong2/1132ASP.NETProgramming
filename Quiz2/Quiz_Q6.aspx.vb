
Partial Class Quiz_Q6
    Inherits System.Web.UI.Page

    Protected Sub toRight_Click(sender As Object, e As EventArgs) Handles toRight.Click
        For i = 0 To LeftBox.Items.Count - 1
            If LeftBox.Items(i).Selected Then
                RightBox.Items.Add(LeftBox.Items(i))
            End If
        Next i

        For i = LeftBox.Items.Count - 1 To 0 Step -1
            If LeftBox.Items(i).Selected Then
                LeftBox.Items.RemoveAt(i)
            End If
        Next i
    End Sub
    Protected Sub toLeft_Click(sender As Object, e As EventArgs) Handles toLeft.Click
        For i = 0 To RightBox.Items.Count - 1
            If RightBox.Items(i).Selected Then
                LeftBox.Items.Add(RightBox.Items(i))
            End If
        Next i

        For i = RightBox.Items.Count - 1 To 0 Step -1
            If RightBox.Items(i).Selected Then
                RightBox.Items.RemoveAt(i)
            End If
        Next i
    End Sub
End Class

