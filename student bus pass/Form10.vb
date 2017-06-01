Imports System.Windows
Imports System.Drawing.Printing
Imports System.Drawing
Imports Microsoft.VisualBasic.Devices.Computer
Imports System.Data.OleDb
Public Class Form10
    Dim con As New OleDbConnection
    Dim dr As OleDbDataReader
    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=MSDAORA.1;Password=oracle;User ID=system;Persist Security Info=True"
        con.Open()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'PRI()
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'PIC()
        Dim a As New OpenFileDialog
        Dim pic As String
        a.Filter = Nothing
        pic = a.FileName
        a.ShowDialog()
        PictureBox2.Image = Image.FromFile(a.FileName)
        TextBox7.Text = TextBox5.Text * TextBox6.Text
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(TextBox1.Text, TextBox1.Font, Brushes.Red, 223, 151)
        e.Graphics.DrawString(TextBox2.Text, TextBox2.Font, Brushes.Red, 223, 225)
        e.Graphics.DrawString(TextBox3.Text, TextBox3.Font, Brushes.Red, 223, 292)
        e.Graphics.DrawString(TextBox4.Text, TextBox4.Font, Brushes.Red, 223, 361)
        e.Graphics.DrawString(TextBox5.Text, TextBox5.Font, Brushes.Red, 86, 474)
        e.Graphics.DrawString(TextBox6.Text, TextBox6.Font, Brushes.Red, 329, 478)
        e.Graphics.DrawString(TextBox7.Text, TextBox7.Font, Brushes.Red, 536, 478)
        e.Graphics.DrawString(Label2.Text, Label2.Font, Brushes.Red, 40, 154)
        e.Graphics.DrawString(Label3.Text, Label3.Font, Brushes.Red, 40, 225)
        e.Graphics.DrawString(Label4.Text, Label4.Font, Brushes.Red, 104, 436)
        e.Graphics.DrawString(Label5.Text, Label5.Font, Brushes.Red, 343, 436)
        e.Graphics.DrawString(Label6.Text, Label6.Font, Brushes.Red, 554, 436)
        e.Graphics.DrawString(Label7.Text, Label7.Font, Brushes.Red, 40, 292)
        e.Graphics.DrawString(Label8.Text, Label8.Font, Brushes.Red, 40, 361)
        e.Graphics.DrawString(Label9.Text, Label9.Font, Brushes.Red, 233, 69)
        e.Graphics.DrawImage(PictureBox2.Image, 510, 151)

    End Sub
End Class