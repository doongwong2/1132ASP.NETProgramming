Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim title As String = "asp programming"
        Response.Write(title & "<br/>")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Page.IsValid Then
            Label1.Text = ""
            Label1.Text &= TextBox1.Text
        End If
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox6.Text.EndsWith("_") Then
            CustomValidator1.IsValid = False
        End If
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Response.Redirect(TextBox7.Text)
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label3.Text = Request.ServerVariables(TextBox8.Text)
        Label3.Text &= "<br/>" & Server.MapPath(Request.ServerVariables(TextBox8.Text))
        'Server.Transfer("http://www.hinet.net") only for own webpage(virtual webpage) 
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Const BR = "<br/>"
        Dim hbc As HttpBrowserCapabilities = Request.Browser
        Label3.Text = ""
        Label3.Text = "Browser Type: " & hbc.Type & BR
        Label3.Text &= "Browser Name: " & hbc.Browser & BR
        Label3.Text &= "Version: " & hbc.Version & BR
        Label3.Text &= "Major Version: " & hbc.MajorVersion & BR
        Label3.Text &= "Minor Version: " & hbc.MinorVersion & BR
        Label3.Text &= "Platform: " & hbc.Platform & BR
        Label3.Text &= "Supports Frames: " & hbc.Frames & BR
        Label3.Text &= "Supports Tables: " & hbc.Tables & BR
        Label3.Text &= "Supports Cookies: " & hbc.Cookies & BR
        Label3.Text &= "Supports VBScript: " & hbc.VBScript & BR
        Label3.Text &= "Supports JavaScript: " & hbc.JavaScript & BR
        Label3.Text &= "Supports JavaApplets: " & hbc.JavaApplets & BR
        Label3.Text &= "Supports ActiveX Controls: " & hbc.ActiveXControls & BR

    End Sub

    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim x, y, result As Integer
        x = CInt(TextBox9.Text)
        y = CInt(TextBox10.Text)
        Try
            result = x / y
            Label4.Text &= "x/y" & result & "<br/>"
        Catch ex As Exception
            Label4.Text &= "program error" & ex.ToString() & "<br>"

        Finally
            Label4.Text &= "test x= " & x & "test y = " & y

        End Try

    End Sub
End Class