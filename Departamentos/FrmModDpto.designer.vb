<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModDpto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModDpto))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSaveModDpto = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cancelModDpto = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbExt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbDpto = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSaveModDpto, Me.ToolStripSeparator1, Me.cancelModDpto})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(495, 27)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSaveModDpto
        '
        Me.btnSaveModDpto.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_save_26
        Me.btnSaveModDpto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveModDpto.Name = "btnSaveModDpto"
        Me.btnSaveModDpto.Size = New System.Drawing.Size(86, 24)
        Me.btnSaveModDpto.Text = "Guardar"
        Me.btnSaveModDpto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'cancelModDpto
        '
        Me.cancelModDpto.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_cancel_50
        Me.cancelModDpto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cancelModDpto.Name = "cancelModDpto"
        Me.cancelModDpto.Size = New System.Drawing.Size(90, 24)
        Me.cancelModDpto.Text = "Cancelar"
        Me.cancelModDpto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Email:"
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(204, 204)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(215, 22)
        Me.tbEmail.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Extensión de tel.:"
        '
        'tbExt
        '
        Me.tbExt.Location = New System.Drawing.Point(204, 145)
        Me.tbExt.Name = "tbExt"
        Me.tbExt.Size = New System.Drawing.Size(215, 22)
        Me.tbExt.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Departamento:"
        '
        'tbDpto
        '
        Me.tbDpto.Location = New System.Drawing.Point(204, 90)
        Me.tbDpto.Name = "tbDpto"
        Me.tbDpto.Size = New System.Drawing.Size(215, 22)
        Me.tbDpto.TabIndex = 14
        '
        'FrmModDpto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 317)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbExt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbDpto)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmModDpto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Departamento"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSaveModDpto As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cancelModDpto As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbExt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbDpto As TextBox
End Class
