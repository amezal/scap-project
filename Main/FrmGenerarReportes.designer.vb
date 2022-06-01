<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerarReportes
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
        Me.btnVwEmpleado = New System.Windows.Forms.Button()
        Me.btnVwCargo = New System.Windows.Forms.Button()
        Me.btnVwDepartamento = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVwEmpleado
        '
        Me.btnVwEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnVwEmpleado.Location = New System.Drawing.Point(95, 100)
        Me.btnVwEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVwEmpleado.Name = "btnVwEmpleado"
        Me.btnVwEmpleado.Size = New System.Drawing.Size(317, 46)
        Me.btnVwEmpleado.TabIndex = 23
        Me.btnVwEmpleado.Text = "Reporte Empleado"
        Me.btnVwEmpleado.UseVisualStyleBackColor = True
        '
        'btnVwCargo
        '
        Me.btnVwCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnVwCargo.Location = New System.Drawing.Point(95, 192)
        Me.btnVwCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVwCargo.Name = "btnVwCargo"
        Me.btnVwCargo.Size = New System.Drawing.Size(317, 46)
        Me.btnVwCargo.TabIndex = 24
        Me.btnVwCargo.Text = "Reporte Cargo"
        Me.btnVwCargo.UseVisualStyleBackColor = True
        '
        'btnVwDepartamento
        '
        Me.btnVwDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnVwDepartamento.Location = New System.Drawing.Point(95, 282)
        Me.btnVwDepartamento.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVwDepartamento.Name = "btnVwDepartamento"
        Me.btnVwDepartamento.Size = New System.Drawing.Size(317, 46)
        Me.btnVwDepartamento.TabIndex = 25
        Me.btnVwDepartamento.Text = "Reporte Departamento"
        Me.btnVwDepartamento.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(13, 432)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 36)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmGenerarReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 481)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnVwDepartamento)
        Me.Controls.Add(Me.btnVwCargo)
        Me.Controls.Add(Me.btnVwEmpleado)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmGenerarReportes"
        Me.Text = "FrmGenerarReportes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVwEmpleado As Button
    Friend WithEvents btnVwCargo As Button
    Friend WithEvents btnVwDepartamento As Button
    Friend WithEvents Button1 As Button
End Class
