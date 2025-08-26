Imports System.Data.SqlClient
Public Class dataRead
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Change()
        End If
    End Sub

    Sub Change()
        ListBox1.Items.Clear()

        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"

        Using conn As New SqlConnection(connString)
            conn.Open()

            If RadioButton1.Checked Then
                Dim query As String = "SELECT name FROM instructor"
                Using cmd As New SqlCommand(query, conn)
                    Using reader1 As SqlDataReader = cmd.ExecuteReader()
                        While reader1.Read()
                            Dim instructorName As String = reader1("name").ToString()
                            ListBox1.Items.Add(instructorName)
                        End While
                    End Using
                End Using
            ElseIf RadioButton2.Checked Then
                Dim query As String = "SELECT title FROM courses"
                Using cmd As New SqlCommand(query, conn)
                    Using reader1 As SqlDataReader = cmd.ExecuteReader()
                        While reader1.Read()
                            Dim instructorName As String = reader1("title").ToString()
                            ListBox1.Items.Add(instructorName)
                        End While
                    End Using
                End Using
            End If

        End Using
    End Sub
End Class