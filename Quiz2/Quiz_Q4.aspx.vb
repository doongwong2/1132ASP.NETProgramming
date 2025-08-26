
Partial Class Quiz_Q4
    Inherits System.Web.UI.Page

    Protected Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim totalPrice As Integer = 0
        Dim totalItems As Integer = 0
        Dim deliveryFee As Integer = 0

        For i = 0 To Options.Items.Count - 1
            If Options.Items(i).Selected Then
                totalPrice += CInt(Options.Items(i).Value)
                totalItems += 1
            End If
        Next i

        deliveryFee = CInt(DeliveryOptions.SelectedItem.Value)
        totalPrice = totalPrice * (1 + deliveryFee / 100)

        Dim itemString As String = " Item<br/>"
        If totalItems > 1 Then itemString = " Items<br/>"

        Output.Text = "Total Cost : $" + totalPrice.ToString + " - Total " + totalItems.ToString + itemString
    End Sub
End Class

