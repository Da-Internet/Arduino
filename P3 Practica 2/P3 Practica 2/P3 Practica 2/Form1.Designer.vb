<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ON1 = New System.Windows.Forms.Button()
        Me.ON2 = New System.Windows.Forms.Button()
        Me.OFF1 = New System.Windows.Forms.Button()
        Me.OFF2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM4"
        '
        'Timer1
        '
        '
        'ON1
        '
        Me.ON1.Location = New System.Drawing.Point(123, 159)
        Me.ON1.Name = "ON1"
        Me.ON1.Size = New System.Drawing.Size(77, 23)
        Me.ON1.TabIndex = 0
        Me.ON1.Text = "Encendido 1"
        Me.ON1.UseVisualStyleBackColor = True
        '
        'ON2
        '
        Me.ON2.Location = New System.Drawing.Point(398, 159)
        Me.ON2.Name = "ON2"
        Me.ON2.Size = New System.Drawing.Size(75, 23)
        Me.ON2.TabIndex = 1
        Me.ON2.Text = "Encendido 2"
        Me.ON2.UseVisualStyleBackColor = True
        '
        'OFF1
        '
        Me.OFF1.Location = New System.Drawing.Point(123, 225)
        Me.OFF1.Name = "OFF1"
        Me.OFF1.Size = New System.Drawing.Size(77, 23)
        Me.OFF1.TabIndex = 2
        Me.OFF1.Text = "Apagado 1"
        Me.OFF1.UseVisualStyleBackColor = True
        Me.OFF1.Visible = False
        '
        'OFF2
        '
        Me.OFF2.Location = New System.Drawing.Point(397, 224)
        Me.OFF2.Name = "OFF2"
        Me.OFF2.Size = New System.Drawing.Size(75, 23)
        Me.OFF2.TabIndex = 3
        Me.OFF2.Text = "Apagado 2"
        Me.OFF2.UseVisualStyleBackColor = True
        Me.OFF2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OFF2)
        Me.Controls.Add(Me.OFF1)
        Me.Controls.Add(Me.ON2)
        Me.Controls.Add(Me.ON1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ON1 As Button
    Friend WithEvents ON2 As Button
    Friend WithEvents OFF1 As Button
    Friend WithEvents OFF2 As Button
End Class
