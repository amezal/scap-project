<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfig
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button4.Location = New System.Drawing.Point(12, 367)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 34)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "REGRESAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button3.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button3.Location = New System.Drawing.Point(135, 180)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(240, 34)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "CARGOS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button2.Location = New System.Drawing.Point(135, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 34)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "HORARIOS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button1.Location = New System.Drawing.Point(135, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 34)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "ADMINISTRAR CONTRASEÑAS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button5.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button5.Location = New System.Drawing.Point(135, 248)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(240, 34)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "DEPARTAMENTOS"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'FrmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 413)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConfig"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
End Class
