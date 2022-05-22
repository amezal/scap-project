<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegistros
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnJustificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.CbxBuscar = New System.Windows.Forms.ComboBox()
        Me.TxtID = New System.Windows.Forms.Label()
        Me.TxtEmpleado = New System.Windows.Forms.Label()
        Me.TxtCargo = New System.Windows.Forms.Label()
        Me.TxtDpto = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnJustificar, Me.ToolStripSeparator3, Me.BtnBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(686, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnJustificar
        '
        Me.BtnJustificar.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_new_window_30
        Me.BtnJustificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnJustificar.Name = "BtnJustificar"
        Me.BtnJustificar.Size = New System.Drawing.Size(73, 22)
        Me.BtnJustificar.Text = "Justificar"
        Me.BtnJustificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_search_24
        Me.BtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(62, 22)
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'CbxBuscar
        '
        Me.CbxBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxBuscar.FormattingEnabled = True
        Me.CbxBuscar.Location = New System.Drawing.Point(157, 2)
        Me.CbxBuscar.Name = "CbxBuscar"
        Me.CbxBuscar.Size = New System.Drawing.Size(299, 21)
        Me.CbxBuscar.TabIndex = 5
        '
        'TxtID
        '
        Me.TxtID.AutoSize = True
        Me.TxtID.Location = New System.Drawing.Point(12, 31)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(36, 13)
        Me.TxtID.TabIndex = 6
        Me.TxtID.Text = "ID: 88"
        '
        'TxtEmpleado
        '
        Me.TxtEmpleado.AutoSize = True
        Me.TxtEmpleado.Location = New System.Drawing.Point(72, 31)
        Me.TxtEmpleado.Name = "TxtEmpleado"
        Me.TxtEmpleado.Size = New System.Drawing.Size(213, 13)
        Me.TxtEmpleado.TabIndex = 7
        Me.TxtEmpleado.Text = "Empleado: Armando Alexander Meza Lopez"
        '
        'TxtCargo
        '
        Me.TxtCargo.AutoSize = True
        Me.TxtCargo.Location = New System.Drawing.Point(345, 31)
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(138, 13)
        Me.TxtCargo.TabIndex = 8
        Me.TxtCargo.Text = "Cargo: Analista de Sistemas"
        '
        'TxtDpto
        '
        Me.TxtDpto.AutoSize = True
        Me.TxtDpto.Location = New System.Drawing.Point(517, 31)
        Me.TxtDpto.Name = "TxtDpto"
        Me.TxtDpto.Size = New System.Drawing.Size(127, 13)
        Me.TxtDpto.TabIndex = 9
        Me.TxtDpto.Text = "Departamento: Desarrollo"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Location = New System.Drawing.Point(0, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 403)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'FrmRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 460)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtDpto)
        Me.Controls.Add(Me.TxtCargo)
        Me.Controls.Add(Me.TxtEmpleado)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.CbxBuscar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmRegistros"
        Me.Text = "FrmRegistros"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnJustificar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BtnBuscar As ToolStripButton
    Friend WithEvents CbxBuscar As ComboBox
    Friend WithEvents TxtID As Label
    Friend WithEvents TxtEmpleado As Label
    Friend WithEvents TxtCargo As Label
    Friend WithEvents TxtDpto As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
