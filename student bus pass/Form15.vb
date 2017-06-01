Imports System.Data.OleDb
Public Class Form15
    Dim con As New OleDbConnection
    Dim dr As OleDbDataReader
    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=MSDAORA.1;Password=oracle;User ID=system;Persist Security Info=True"
        con.Open()
        MsgBox("connected")
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Form13.Show()
        Me.Hide()
    End Sub
End Class