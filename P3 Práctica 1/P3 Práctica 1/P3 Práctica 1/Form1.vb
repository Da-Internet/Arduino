Imports System.IO.Ports
Imports System.Text

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort1.Open()
    End Sub

    Private Sub Encender_Click(sender As Object, e As EventArgs) Handles Encender.Click
        Dim variable As Byte() = Encoding.ASCII.GetBytes("Encendido")
        SerialPort1.Write(variable, 0, variable.Length)
    End Sub

    Private Sub Puerto_Click(sender As Object, e As EventArgs) Handles Puerto.Click
        SerialPort1.Close()
    End Sub

    Private Sub Apagar_Click(sender As Object, e As EventArgs) Handles Apagar.Click
        Dim variable As Byte() = Encoding.ASCII.GetBytes("Apagado")
        SerialPort1.Write(variable, 0, variable.Length)
    End Sub
End Class