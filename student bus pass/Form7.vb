Imports System.Windows
Imports System.Drawing.Printing
Imports System.Drawing
Imports Microsoft.VisualBasic.Devices.Computer
Imports System.Data.OleDb
Public Class Form7
    Dim con As New OleDbConnection
    Dim dr As OleDbDataReader
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(TextBox1.Text, TextBox1.Font, Brushes.Red, 183, 139)
        e.Graphics.DrawString(TextBox2.Text, TextBox2.Font, Brushes.Red, 183, 192)
        e.Graphics.DrawString(TextBox3.Text, TextBox3.Font, Brushes.Red, 183, 249)
        e.Graphics.DrawString(TextBox4.Text, TextBox4.Font, Brushes.Red, 183, 315)
        e.Graphics.DrawString(TextBox5.Text, TextBox5.Font, Brushes.Red, 183, 382)
        e.Graphics.DrawString(TextBox6.Text, TextBox6.Font, Brushes.Red, 183, 453)
        e.Graphics.DrawString(TextBox7.Text, TextBox7.Font, Brushes.Red, 559, 455)
        e.Graphics.DrawString(Label2.Text, Label2.Font, Brushes.Red, 27, 142)
        e.Graphics.DrawString(Label3.Text, Label3.Font, Brushes.Red, 27, 192)
        e.Graphics.DrawString(Label4.Text, Label4.Font, Brushes.Red, 15, 249)
        e.Graphics.DrawString(Label5.Text, Label5.Font, Brushes.Red, 27, 315)
        e.Graphics.DrawString(Label6.Text, Label6.Font, Brushes.Red, 27, 382)
        e.Graphics.DrawString(Label7.Text, Label7.Font, Brushes.Red, 5, 453)
        e.Graphics.DrawString(Label8.Text, Label8.Font, Brushes.Red, 405, 456)
        e.Graphics.DrawString(Label9.Text, Label9.Font, Brushes.Red, 256, 79)
        e.Graphics.DrawImage(PictureBox2.Image, 496, 139)


    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Form8.Show()
        Me.Close()
        
    End Sub
End Class