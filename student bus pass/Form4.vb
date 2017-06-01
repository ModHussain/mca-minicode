Imports System.Data.OleDb
Public Class Form4
    Dim con As New OleDbConnection
    Dim dr As OleDbDataReader
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=MSDAORA.1;Password=oracle;User ID=system;Persist Security Info=True"
        con.Open()
        MsgBox("connected")
        Dim cmd As New OleDbCommand("select * from COLL", con)
        dr = cmd.ExecuteReader()
        While dr.Read
            ListBox1.Items.Add(dr.GetValue(0))
            ListBox2.Items.Add(dr.GetValue(1))
            ListBox3.Items.Add(dr.GetValue(2))
            ListBox4.Items.Add(dr.GetValue(3))
            ListBox5.Items.Add(dr.GetValue(4))
        End While
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Form2.Show()
        Me.Close()

    End Sub
End Class