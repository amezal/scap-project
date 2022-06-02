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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgvRegistros = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnJustificar, Me.ToolStripSeparator3, Me.BtnBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1157, 27)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnJustificar
        '
        Me.BtnJustificar.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_new_window_30
        Me.BtnJustificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnJustificar.Name = "BtnJustificar"
        Me.BtnJustificar.Size = New System.Drawing.Size(90, 24)
        Me.BtnJustificar.Text = "Justificar"
        Me.BtnJustificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_search_24
        Me.BtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(76, 24)
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'CbxBuscar
        '
        Me.CbxBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxBuscar.FormattingEnabled = True
        Me.CbxBuscar.Location = New System.Drawing.Point(209, 2)
        Me.CbxBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbxBuscar.Name = "CbxBuscar"
        Me.CbxBuscar.Size = New System.Drawing.Size(397, 24)
        Me.CbxBuscar.TabIndex = 5
        '
        'TxtID
        '
        Me.TxtID.AutoSize = True
        Me.TxtID.Location = New System.Drawing.Point(16, 38)
        Me.TxtID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(26, 16)
        Me.TxtID.TabIndex = 6
        Me.TxtID.Text = "ID: "
        '
        'TxtEmpleado
        '
        Me.TxtEmpleado.AutoSize = True
        Me.TxtEmpleado.Location = New System.Drawing.Point(96, 38)
        Me.TxtEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtEmpleado.Name = "TxtEmpleado"
        Me.TxtEmpleado.Size = New System.Drawing.Size(73, 16)
        Me.TxtEmpleado.TabIndex = 7
        Me.TxtEmpleado.Text = "Empleado:"
        '
        'TxtCargo
        '
        Me.TxtCargo.AutoSize = True
        Me.TxtCargo.Location = New System.Drawing.Point(460, 38)
        Me.TxtCargo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(50, 16)
        Me.TxtCargo.TabIndex = 8
        Me.TxtCargo.Text = "Cargo: "
        '
        'TxtDpto
        '
        Me.TxtDpto.AutoSize = True
        Me.TxtDpto.Location = New System.Drawing.Point(689, 38)
        Me.TxtDpto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtDpto.Name = "TxtDpto"
        Me.TxtDpto.Size = New System.Drawing.Size(96, 16)
        Me.TxtDpto.TabIndex = 9
        Me.TxtDpto.Text = "Departamento:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.DgvRegistros)
        Me.Panel1.Location = New System.Drawing.Point(0, 70)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1157, 498)
        Me.Panel1.TabIndex = 10
        '
        'DgvRegistros
        '
        Me.DgvRegistros.AllowUserToAddRows = False
        Me.DgvRegistros.AllowUserToDeleteRows = False
        Me.DgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRegistros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRegistros.Location = New System.Drawing.Point(0, 0)
        Me.DgvRegistros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DgvRegistros.Name = "DgvRegistros"
        Me.DgvRegistros.ReadOnly = True
        Me.DgvRegistros.RowHeadersWidth = 51
        Me.DgvRegistros.Size = New System.Drawing.Size(1157, 498)
        Me.DgvRegistros.TabIndex = 0
        '
        'FrmRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 566)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtDpto)
        Me.Controls.Add(Me.TxtCargo)
        Me.Controls.Add(Me.TxtEmpleado)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.CbxBuscar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmRegistros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registros"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DgvRegistros As DataGridView
End Class
