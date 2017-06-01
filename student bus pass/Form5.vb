Imports System.Data.OleDb
Public Class Form5
    Dim con As New OleDbConnection
    Dim dr As OleDbDataReader
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=MSDAORA.1;Password=oracle;User ID=system;Persist Security Info=True"
        con.Open()
        MsgBox("connected")
        Dim cmd As New OleDbCommand("select * from STUDENT", con)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            TextBox1.Text = dr.GetValue(0)
            TextBox2.Text = dr.GetValue(1)
            TextBox3.Text = dr.GetValue(2)
            TextBox4.Text = dr.GetValue(3)
            TextBox5.Text = dr.GetValue(4)
            TextBox6.Text = dr.GetValue(5)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'NEXT
        If dr.Read Then
            TextBox1.Text = dr.GetValue(0)
            TextBox2.Text = dr.GetValue(1)
            TextBox3.Text = dr.GetValue(2)
            TextBox4.Text = dr.GetValue(3)
            TextBox5.Text = dr.GetValue(4)
            TextBox6.Text = dr.GetValue(5)
        Else
            MsgBox("last record")
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'INSERT
        Dim cmd As New OleDbCommand("insert into STUDENT values('" & (TextBox1.Text) & "','" & (TextBox2.Text) & "'," & Val(TextBox3.Text) & ",'" & (TextBox4.Text) & "','" & (TextBox5.Text) & "','" & (TextBox6.Text) & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("record Inserted ")
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        'SEARCH
        Dim cmd As New OleDbCommand(" Select * from STUDENT where ID LIKE'%" & TextBox7.Text & "%'", con)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            TextBox1.Text = dr.GetValue(0)
            TextBox2.Text = dr.GetValue(1)
            TextBox3.Text = dr.GetValue(2)
            TextBox4.Text = dr.GetValue(3)
            TextBox5.Text = dr.GetValue(4)
            TextBox6.Text = dr.GetValue(5)
        Else
            MsgBox(" No such record found ")
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        'DELETE
       
        Dim cmd As New OleDbCommand(" DELETE STUDENT where ID LIKE'%" & TextBox7.Text & "%'", con)

        cmd.ExecuteNonQuery()
        MsgBox("Record Deleted ")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'UPDATE
        Dim cmd As New OleDbCommand("update STUDENT set NAME = '" & (TextBox2.Text) & " ',AGE = " & Val(TextBox3.Text) & ", COURSE = '" & (TextBox4.Text) & "', COLLEGE = '" & (TextBox5.Text) & "',ADDRESS='" & (TextBox6.Text) & "' where ID = '" & (TextBox1.Text) & "'", con)
        cmd.ExecuteNonQuery()
        MsgBox(" Record UPDATED ")
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        'CLEAR
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Form11.Show()
        Me.Hide()
    End Sub
End Class