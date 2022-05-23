<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModHor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModHor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHorIn = New System.Windows.Forms.TextBox()
        Me.txtHorFin = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSaveModHor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cancelModHor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hora de inicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hora de fin:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(149, 73)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(247, 22)
        Me.txtName.TabIndex = 5
        '
        'txtHorIn
        '
        Me.txtHorIn.Location = New System.Drawing.Point(149, 127)
        Me.txtHorIn.Name = "txtHorIn"
        Me.txtHorIn.Size = New System.Drawing.Size(247, 22)
        Me.txtHorIn.TabIndex = 6
        '
        'txtHorFin
        '
        Me.txtHorFin.Location = New System.Drawing.Point(149, 179)
        Me.txtHorFin.Name = "txtHorFin"
        Me.txtHorFin.Size = New System.Drawing.Size(247, 22)
        Me.txtHorFin.TabIndex = 7
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSaveModHor, Me.ToolStripSeparator1, Me.cancelModHor})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(495, 27)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSaveModHor
        '
        Me.btnSaveModHor.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_save_26
        Me.btnSaveModHor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveModHor.Name = "btnSaveModHor"
        Me.btnSaveModHor.Size = New System.Drawing.Size(86, 24)
        Me.btnSaveModHor.Text = "Guardar"
        Me.btnSaveModHor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'cancelModHor
        '
        Me.cancelModHor.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_cancel_50
        Me.cancelModHor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cancelModHor.Name = "cancelModHor"
        Me.cancelModHor.Size = New System.Drawing.Size(90, 24)
        Me.cancelModHor.Text = "Cancelar"
        Me.cancelModHor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'FrmModHor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 317)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtHorFin)
        Me.Controls.Add(Me.txtHorIn)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmModHor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmModHor"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtHorIn As TextBox
    Friend WithEvents txtHorFin As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSaveModHor As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cancelModHor As ToolStripButton
End Class
