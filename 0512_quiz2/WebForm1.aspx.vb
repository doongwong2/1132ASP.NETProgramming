Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'If Page.IsPostBack Then
        'Dim date_ = "<span style= 'color:blue;'>" & DateTime.Now.ToString("yyyy/M/dd") & "</span>"
        'Dim userName = "<span style= 'color:red;'><b><u>" & TextBox1.Text & "</u></b></span>"
        'Response.Write(date_ + " welcome, " + userName + "!</br>" + "current session id: " + Session.SessionID + "</br>")

        'End If
    End Sub

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim HBC As HttpBrowserCapabilities = Request.Browser
        Label1.Text = ""
        If ListBox1.SelectedItem.Text = "browserType" Then
            Label1.Text &= "BrowserType: " & HBC.Type
        ElseIf ListBox1.SelectedItem.Text = "browserName" Then
            Label1.Text &= "BrowserName: " & HBC.Browser
        ElseIf ListBox1.SelectedItem.Text = "browserVersion" Then
            Label1.Text &= "BrowserVersion: " & HBC.Version
        ElseIf ListBox1.SelectedItem.Text = "OSversion" Then
            Label1.Text &= "OSVersion: " & HBC.Platform
        ElseIf ListBox1.SelectedItem.Text = "showAll" Then
            Label1.Text &= "BrowserType: " & HBC.Type & "</br>"
            Label1.Text &= "BrowserName: " & HBC.Browser & "</br>"
            Label1.Text &= "BrowserVersion: " & HBC.Version & "</br>"
            Label1.Text &= "OSVersion: " & HBC.Platform
        End If


    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        If DropDownList1.SelectedIndex > 0 Then
            DropDownList2.Enabled = True
            DropDownList2.Items.Clear()

            If DropDownList1.SelectedIndex = 1 Then ' sunny
                DropDownList2.Items.Add("play ball")
                DropDownList2.Items.Add("swimming")
                DropDownList3.Items.Clear()

            ElseIf DropDownList1.SelectedIndex = 2 Then ' rainy
                DropDownList2.Items.Add("shopping")
                DropDownList2.Items.Add("stay at home")
                            DropDownList3.Items.Clear()
            End If
        Else
            DropDownList2.Enabled = False
            DropDownList2.Items.Clear()
            DropDownList3.Enabled = False
            DropDownList3.Items.Clear()
        End If
    End Sub

    Protected Sub DropDownList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged

        If DropDownList2.SelectedIndex > -1 Then
            DropDownList3.Enabled = True
            DropDownList3.Items.Clear()

            If DropDownList2.SelectedItem.ToString = "play ball" Then
                DropDownList3.Items.Add("basketball")
                DropDownList3.Items.Add("volleyball")
            End If
            If DropDownList2.SelectedItem.ToString = "swimming" Then
                DropDownList3.Items.Add("freestyle")
                DropDownList3.Items.Add("breastroke")
            End If
            If DropDownList2.SelectedItem.ToString = "shopping" Then
                DropDownList3.Items.Add("big mall")
                DropDownList3.Items.Add("shopping district")
            End If
            If DropDownList2.SelectedItem.ToString = "stay at home" Then
                DropDownList3.Items.Add("gaming")
                DropDownList3.Items.Add("sleep")
            End If
        Else
            DropDownList3.Enabled = False
            DropDownList3.Items.Clear()
        End If
    End Sub

End Class