Imports System.Data.OleDb
Public Class Form14
    Dim con As New OleDbConnection
    Dim dr As OleDbDataReader
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click  
        'Id()
        Dim cmd As New OleDbCommand("select * from STUDENT where ID LIKE'%" & TextBox1.Text & "%'", con)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            Form15.ListBox1.Items.Add(dr.GetValue(0))
            Form15.ListBox2.Items.Add(dr.GetValue(1))
            Form15.ListBox3.Items.Add(dr.GetValue(2))
            Form15.ListBox4.Items.Add(dr.GetValue(3))
            Form15.ListBox5.Items.Add(dr.GetValue(4))
            Form15.ListBox6.Items.Add(dr.GetValue(5))
            Form15.Show()
            Me.Hide()
        Else
            MsgBox(" No such record found ")
        End If
        

    End Sub

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=MSDAORA.1;Password=oracle;User ID=system;Persist Security Info=True"
        con.Open()
        MsgBox("connected")
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'Name()
        Dim cmd As New OleDbCommand("select * from STUDENT where NAME LIKE'%" & TextBox1.Text & "%'", con)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            Form16.ListBox1.Items.Add(dr.GetValue(0))
            Form16.ListBox2.Items.Add(dr.GetValue(1))
            Form16.ListBox3.Items.Add(dr.GetValue(2))
            Form16.ListBox4.Items.Add(dr.GetValue(3))
            Form16.ListBox5.Items.Add(dr.GetValue(4))
            Form16.ListBox6.Items.Add(dr.GetValue(5))
            Form16.Show()
            Me.Hide()
        Else
            MsgBox(" No such record found ")
        End If
        
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Form13.Show()
        Me.Hide()
    End Sub
End Class