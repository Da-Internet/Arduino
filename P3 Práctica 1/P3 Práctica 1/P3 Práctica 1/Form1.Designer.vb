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
        Me.Encender = New System.Windows.Forms.Button()
        Me.Puerto = New System.Windows.Forms.Button()
        Me.Apagar = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'Encender
        '
        Me.Encender.Cursor = System.Windows.Forms.Cursors.Default
        Me.Encender.Location = New System.Drawing.Point(120, 103)
        Me.Encender.Name = "Encender"
        Me.Encender.Size = New System.Drawing.Size(75, 23)
        Me.Encender.TabIndex = 0
        Me.Encender.Text = "Encender"
        Me.Encender.UseVisualStyleBackColor = True
        '
        'Puerto
        '
        Me.Puerto.Location = New System.Drawing.Point(342, 103)
        Me.Puerto.Name = "Puerto"
        Me.Puerto.Size = New System.Drawing.Size(75, 23)
        Me.Puerto.TabIndex = 1
        Me.Puerto.Text = "Puerto"
        Me.Puerto.UseVisualStyleBackColor = True
        '
        'Apagar
        '
        Me.Apagar.Location = New System.Drawing.Point(558, 103)
        Me.Apagar.Name = "Apagar"
        Me.Apagar.Size = New System.Drawing.Size(75, 23)
        Me.Apagar.TabIndex = 2
        Me.Apagar.Text = "Apagar"
        Me.Apagar.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Apagar)
        Me.Controls.Add(Me.Puerto)
        Me.Controls.Add(Me.Encender)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Encender As Button
    Friend WithEvents Puerto As Button
    Friend WithEvents Apagar As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
