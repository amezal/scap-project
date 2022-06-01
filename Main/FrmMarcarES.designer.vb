<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMarcarES
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.labelBienvenida = New System.Windows.Forms.Label()
        Me.reloj = New System.Windows.Forms.TextBox()
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.btnSalida = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'labelBienvenida
        '
        Me.labelBienvenida.AutoSize = True
        Me.labelBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.labelBienvenida.Location = New System.Drawing.Point(9, 6)
        Me.labelBienvenida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelBienvenida.Name = "labelBienvenida"
        Me.labelBienvenida.Size = New System.Drawing.Size(168, 15)
        Me.labelBienvenida.TabIndex = 0
        Me.labelBienvenida.Text = "*Mensaje de bienvenida*"
        '
        'reloj
        '
        Me.reloj.BackColor = System.Drawing.SystemColors.Control
        Me.reloj.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.reloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold)
        Me.reloj.ForeColor = System.Drawing.Color.Black
        Me.reloj.Location = New System.Drawing.Point(80, 73)
        Me.reloj.Margin = New System.Windows.Forms.Padding(2)
        Me.reloj.Name = "reloj"
        Me.reloj.Size = New System.Drawing.Size(224, 55)
        Me.reloj.TabIndex = 21
        Me.reloj.Text = "00:00:00"
        Me.reloj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEntrada
        '
        Me.btnEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnEntrada.Location = New System.Drawing.Point(22, 169)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(155, 63)
        Me.btnEntrada.TabIndex = 22
        Me.btnEntrada.Text = "Entrada"
        Me.btnEntrada.UseVisualStyleBackColor = True
        '
        'btnSalida
        '
        Me.btnSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnSalida.Location = New System.Drawing.Point(206, 169)
        Me.btnSalida.Name = "btnSalida"
        Me.btnSalida.Size = New System.Drawing.Size(155, 63)
        Me.btnSalida.TabIndex = 22
        Me.btnSalida.Text = "Salida"
        Me.btnSalida.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(12, 290)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 23
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'FrmMarcarES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 325)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnSalida)
        Me.Controls.Add(Me.btnEntrada)
        Me.Controls.Add(Me.reloj)
        Me.Controls.Add(Me.labelBienvenida)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmMarcarES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMarcarES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

<<<<<<< HEAD
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
=======
    Friend WithEvents labelBienvenida As Label
    Friend WithEvents reloj As TextBox
    Friend WithEvents btnEntrada As Button
    Friend WithEvents btnSalida As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Timer1 As Timer
>>>>>>> bc2a099e9a7ff2bc4ac405b85b03493a419f70ab
End Class
