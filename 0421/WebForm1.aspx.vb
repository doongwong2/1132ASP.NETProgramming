Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack Then
            Label1.Text = ""
            If TextBox2.Text <> "" Then
                Label1.Text &= "welcome," & TextBox2.Text
            End If
        Else
            TextBox2.Text = "bob"
        End If
    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim total As Integer = 0
        Dim quantity As Integer
        quantity = CInt(TextBox3.Text)
        If CheckBox1.Checked Then
            total += 100 * quantity
        End If
        If CheckBox2.Checked Then
            total += 200 * quantity
        End If
        Label2.Text = ""
        Label2.Text &= total.ToString("C")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton1.Checked Then
            Label3.Text = "rare"
        ElseIf RadioButton2.Checked Then
            Label3.Text = "medium"
        ElseIf RadioButton3.Checked Then
            Label3.Text = "well done"
        End If

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DropDownList1.SelectedIndex > -1 Then
            Label4.Text = ""
            Label4.Text = DropDownList1.SelectedItem.Text & _DropDownList1.SelectedItem.Value
        End If
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As Integer
        For i = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(i).Selected Then
                Label5.Text = ""
                Label5.Text = ListBox1.Items(i).Text & "<br/>"
            End If
        Next
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DropDownList2.Items.Add(TextBox4.Text)
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DropDownList2.Items.Remove(TextBox4.Text)
    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DropDownList2.Items.Clear()
    End Sub

    Protected Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DropDownList2.Items.RemoveAt(0)
    End Sub

    Protected Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        DropDownList2.Items.RemoveAt(DropDownList2.Items.Count - 1)
    End Sub

    Protected Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim i As Integer
        Label6.Text = ""
        For i = 0 To ListBox2.Items.Count - 1
            If ListBox2.Items(i).Selected Then

                Label6.Text &= ListBox2.Items(i).Text & "<br/>"
            End If
        Next
    End Sub

    Protected Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        ListBox3.Items.Clear()
        If CheckBox3.Checked Then
            ListBox3.Items.Add(CheckBox3.Text)
        End If
        If CheckBox4.Checked Then
            ListBox3.Items.Add(CheckBox4.Text)
        End If
        If CheckBox5.Checked Then
            ListBox3.Items.Add(CheckBox5.Text)
        End If
        If CheckBox6.Checked Then
            ListBox3.Items.Add(CheckBox6.Text)
        End If
    End Sub

    Protected Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Protected Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim s As String
        While ListBox4.SelectedIndex > -1
            s = ListBox4.SelectedItem.Text
            ListBox5.Items.Add(s)
            ListBox4.Items.Remove(s)
        End While

    End Sub

    Protected Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim s As String
        While ListBox5.SelectedIndex > -1
            s = ListBox5.SelectedItem.Text
            ListBox4.Items.Add(s)
            ListBox5.Items.Remove(s)
        End While
    End Sub
End Class