Imports System.IO.Ports
Imports System.Text

Public Class Form1
    Dim Ale As Char
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Open()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Ale = SerialPort1.ReadExisting()

        Select Case Ale
            Case "E"
                ON1.Visible = True
                ON2.Visible = True
                OFF1.Visible = False
                OFF2.Visible = False
            Case "A"
                ON1.Visible = False
                ON2.Visible = False
                OFF1.Visible = True
                OFF2.Visible = True
        End Select
    End Sub
End Class