Imports System.Data.OleDb
Public Class Form9
    Dim con As New OleDbConnection
    Dim dr As OleDbDataReader
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form17.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        
    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=MSDAORA.1;Password=oracle;User ID=system;Persist Security Info=True"
        con.Open()
        MsgBox("MONTHLY EXPIRED TICKETS LIST IS GENERATING.PLEASE CLICK TO VIEW")
        Dim cmd As New OleDbCommand("select * from BUSPASS where MT <=(select sysdate from dual)", con)
        dr = cmd.ExecuteReader()
        While dr.Read
            ListBox1.Items.Add(dr.GetValue(0))
            ListBox2.Items.Add(dr.GetValue(1))
            ListBox3.Items.Add(dr.GetValue(2))
            ListBox4.Items.Add(dr.GetValue(3))
            ListBox5.Items.Add(dr.GetValue(4))
            ListBox6.Items.Add(dr.GetValue(7))
            ListBox7.Items.Add(dr.GetValue(8))
        End While
    End Sub
End Class