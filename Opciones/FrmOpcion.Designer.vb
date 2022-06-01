<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpcion))
        Me.GbOpcion = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgvOpcion = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblopcionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMBADataSet = New SCAP_LMBA_Tech.LMBADataSet()
        Me.Tbl_opcionTableAdapter = New SCAP_LMBA_Tech.LMBADataSetTableAdapters.tbl_opcionTableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnAddOpc = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDeleteOpc = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnModOpc = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSearchOpc = New System.Windows.Forms.ToolStripButton()
        Me.TbSearchOpc = New System.Windows.Forms.TextBox()
        Me.GbOpcion.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblopcionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbOpcion
        '
        Me.GbOpcion.Controls.Add(Me.Panel1)
        Me.GbOpcion.Location = New System.Drawing.Point(12, 28)
        Me.GbOpcion.Name = "GbOpcion"
        Me.GbOpcion.Size = New System.Drawing.Size(458, 275)
        Me.GbOpcion.TabIndex = 16
        Me.GbOpcion.TabStop = False
        Me.GbOpcion.Text = "GroupBox1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DgvOpcion)
        Me.Panel1.Location = New System.Drawing.Point(0, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(449, 237)
        Me.Panel1.TabIndex = 0
        '
        'DgvOpcion
        '
        Me.DgvOpcion.AutoGenerateColumns = False
        Me.DgvOpcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvOpcion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvOpcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOpcion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.OpcionDataGridViewTextBoxColumn})
        Me.DgvOpcion.DataSource = Me.TblopcionBindingSource
        Me.DgvOpcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvOpcion.Location = New System.Drawing.Point(0, 0)
        Me.DgvOpcion.Name = "DgvOpcion"
        Me.DgvOpcion.Size = New System.Drawing.Size(449, 237)
        Me.DgvOpcion.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_opcion"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'OpcionDataGridViewTextBoxColumn
        '
        Me.OpcionDataGridViewTextBoxColumn.DataPropertyName = "opcion"
        Me.OpcionDataGridViewTextBoxColumn.HeaderText = "Opción"
        Me.OpcionDataGridViewTextBoxColumn.Name = "OpcionDataGridViewTextBoxColumn"
        Me.OpcionDataGridViewTextBoxColumn.Width = 66
        '
        'TblopcionBindingSource
        '
        Me.TblopcionBindingSource.DataMember = "tbl_opcion"
        Me.TblopcionBindingSource.DataSource = Me.LMBADataSet
        '
        'LMBADataSet
        '
        Me.LMBADataSet.DataSetName = "LMBADataSet"
        Me.LMBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_opcionTableAdapter
        '
        Me.Tbl_opcionTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAddOpc, Me.ToolStripSeparator1, Me.BtnDeleteOpc, Me.ToolStripSeparator2, Me.BtnModOpc, Me.ToolStripSeparator3, Me.BtnSearchOpc})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(477, 25)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnAddOpc
        '
        Me.BtnAddOpc.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_new_window_30
        Me.BtnAddOpc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddOpc.Name = "BtnAddOpc"
        Me.BtnAddOpc.Size = New System.Drawing.Size(69, 22)
        Me.BtnAddOpc.Text = "Agregar"
        Me.BtnAddOpc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnDeleteOpc
        '
        Me.BtnDeleteOpc.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_delete_24
        Me.BtnDeleteOpc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteOpc.Name = "BtnDeleteOpc"
        Me.BtnDeleteOpc.Size = New System.Drawing.Size(70, 22)
        Me.BtnDeleteOpc.Text = "Eliminar"
        Me.BtnDeleteOpc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BtnModOpc
        '
        Me.BtnModOpc.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_edit_production_order_32
        Me.BtnModOpc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnModOpc.Name = "BtnModOpc"
        Me.BtnModOpc.Size = New System.Drawing.Size(78, 22)
        Me.BtnModOpc.Text = "Modificar"
        Me.BtnModOpc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BtnSearchOpc
        '
        Me.BtnSearchOpc.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_search_24
        Me.BtnSearchOpc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSearchOpc.Name = "BtnSearchOpc"
        Me.BtnSearchOpc.Size = New System.Drawing.Size(62, 22)
        Me.BtnSearchOpc.Text = "Buscar"
        '
        'TbSearchOpc
        '
        Me.TbSearchOpc.Location = New System.Drawing.Point(311, 2)
        Me.TbSearchOpc.Name = "TbSearchOpc"
        Me.TbSearchOpc.Size = New System.Drawing.Size(159, 20)
        Me.TbSearchOpc.TabIndex = 18
        '
        'FrmOpcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 319)
        Me.Controls.Add(Me.TbSearchOpc)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GbOpcion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOpcion"
        Me.Text = "Opciones"
        Me.GbOpcion.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvOpcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblopcionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GbOpcion As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DgvOpcion As DataGridView
    Friend WithEvents LMBADataSet As LMBADataSet
    Friend WithEvents TblopcionBindingSource As BindingSource
    Friend WithEvents Tbl_opcionTableAdapter As LMBADataSetTableAdapters.tbl_opcionTableAdapter
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnAddOpc As ToolStripButton
    Friend WithEvents BtnDeleteOpc As ToolStripButton
    Friend WithEvents BtnModOpc As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BtnSearchOpc As ToolStripButton
    Friend WithEvents TbSearchOpc As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents OpcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
