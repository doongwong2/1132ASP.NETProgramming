Imports System.Data.SqlClient
Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadData()
        End If
    End Sub

    Sub LoadData()
        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"
        Dim query As String = "SELECT * FROM [Table]"

        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim ds As New DataSet()

                adapter.Fill(ds, "Students") ' Fill dataset with table named "Students"

                Dim sb As New StringBuilder()

                ' Check if dataset has table and rows
                If ds.Tables.Contains("Students") AndAlso ds.Tables("Students").Rows.Count > 0 Then
                    For Each row As DataRow In ds.Tables("Students").Rows
                        sb.AppendLine($"{row("sid")} - {row("name")} - {row("telephone")} - {Convert.ToDateTime(row("birthday")).ToString("yyyy/MM/dd")} - {row("major")}")
                    Next
                Else
                    sb.AppendLine("No records found.")
                End If

                Label1.Text = sb.ToString().Replace(Environment.NewLine, "<br />")
            End Using
        End Using
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class