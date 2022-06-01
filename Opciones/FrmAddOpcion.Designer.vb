<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddOpcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddOpcion))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSaveOpc = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelarOpc = New System.Windows.Forms.ToolStripButton()
        Me.tbOpc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSaveOpc, Me.ToolStripSeparator1, Me.btnCancelarOpc})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(443, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSaveOpc
        '
        Me.btnSaveOpc.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_save_26
        Me.btnSaveOpc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveOpc.Name = "btnSaveOpc"
        Me.btnSaveOpc.Size = New System.Drawing.Size(69, 22)
        Me.btnSaveOpc.Text = "Guardar"
        Me.btnSaveOpc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnCancelarOpc
        '
        Me.btnCancelarOpc.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_cancel_50
        Me.btnCancelarOpc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelarOpc.Name = "btnCancelarOpc"
        Me.btnCancelarOpc.Size = New System.Drawing.Size(73, 22)
        Me.btnCancelarOpc.Text = "Cancelar"
        Me.btnCancelarOpc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'tbOpc
        '
        Me.tbOpc.Location = New System.Drawing.Point(188, 140)
        Me.tbOpc.Margin = New System.Windows.Forms.Padding(2)
        Me.tbOpc.Name = "tbOpc"
        Me.tbOpc.Size = New System.Drawing.Size(154, 20)
        Me.tbOpc.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nueva opción:"
        '
        'FrmAddOpcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 284)
        Me.Controls.Add(Me.tbOpc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAddOpcion"
        Me.Text = "Añadir Opción"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSaveOpc As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnCancelarOpc As ToolStripButton
    Friend WithEvents tbOpc As TextBox
    Friend WithEvents Label2 As Label
End Class
