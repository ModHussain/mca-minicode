Imports System.Data.OleDb
Public Class Form8
    Dim con As New OleDbConnection
    Dim dr As OleDbDataReader
    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=MSDAORA.1;Password=oracle;User ID=system;Persist Security Info=True"
        con.Open()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'GENERATE ID
        Dim cmd As New OleDbCommand(" Select * from BUSPASS where ID LIKE'%" & TextBox1.Text & "%'", con)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            Form7.TextBox1.Text = dr.GetValue(0)
            Form7.TextBox2.Text = dr.GetValue(1)
            Form7.TextBox3.Text = dr.GetValue(2)
            Form7.TextBox4.Text = dr.GetValue(3)
            Form7.TextBox5.Text = dr.GetValue(4)
            Form7.TextBox6.Text = dr.GetValue(5)
            Form7.TextBox7.Text = dr.GetValue(6)
        Else
            MsgBox(" No such record found ")
        End If
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form17.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        'GENERATE TICKET
        Dim cmd As New OleDbCommand(" Select * from BUSPASS where ID LIKE'%" & TextBox1.Text & "%'", con)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            Form10.TextBox1.Text = dr.GetValue(0)
            Form10.TextBox2.Text = dr.GetValue(1)
            Form10.TextBox3.Text = dr.GetValue(7)
            Form10.TextBox4.Text = dr.GetValue(8)

        Else
            MsgBox(" No such record found ")
        End If
        Form10.Show()
        Me.Hide()
    End Sub
End Class