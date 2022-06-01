<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDpto
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDpto))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAddDpto = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEliminarDpto = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.modDpto = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.searchDpto = New System.Windows.Forms.ToolStripButton()
        Me.tbBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.dgvDpto = New System.Windows.Forms.DataGridView()
        Me.IdDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMBADataSet = New SCAP_LMBA_Tech.LMBADataSet()
        Me.gbDpto = New System.Windows.Forms.GroupBox()
        Me.DepartamentoTableAdapter = New SCAP_LMBA_Tech.LMBADataSetTableAdapters.DepartamentoTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvDpto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDpto.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAddDpto, Me.ToolStripSeparator1, Me.btnEliminarDpto, Me.ToolStripSeparator2, Me.modDpto, Me.ToolStripSeparator3, Me.searchDpto, Me.tbBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(772, 27)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAddDpto
        '
        Me.btnAddDpto.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_new_window_30
        Me.btnAddDpto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddDpto.Name = "btnAddDpto"
        Me.btnAddDpto.Size = New System.Drawing.Size(87, 24)
        Me.btnAddDpto.Text = "Agregar"
        Me.btnAddDpto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnEliminarDpto
        '
        Me.btnEliminarDpto.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_delete_24
        Me.btnEliminarDpto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarDpto.Name = "btnEliminarDpto"
        Me.btnEliminarDpto.Size = New System.Drawing.Size(87, 24)
        Me.btnEliminarDpto.Text = "Eliminar"
        Me.btnEliminarDpto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'modDpto
        '
        Me.modDpto.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_edit_production_order_32
        Me.modDpto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.modDpto.Name = "modDpto"
        Me.modDpto.Size = New System.Drawing.Size(97, 24)
        Me.modDpto.Text = "Modificar"
        Me.modDpto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'searchDpto
        '
        Me.searchDpto.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_search_24
        Me.searchDpto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.searchDpto.Name = "searchDpto"
        Me.searchDpto.Size = New System.Drawing.Size(76, 24)
        Me.searchDpto.Text = "Buscar"
        Me.searchDpto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'tbBuscar
        '
        Me.tbBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(200, 27)
        '
        'dgvDpto
        '
        Me.dgvDpto.AllowUserToAddRows = False
        Me.dgvDpto.AllowUserToDeleteRows = False
        Me.dgvDpto.AutoGenerateColumns = False
        Me.dgvDpto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDpto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDepartamentoDataGridViewTextBoxColumn, Me.NombreDepartamentoDataGridViewTextBoxColumn, Me.ExtDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.dgvDpto.DataSource = Me.DepartamentoBindingSource
        Me.dgvDpto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDpto.Location = New System.Drawing.Point(3, 17)
        Me.dgvDpto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvDpto.Name = "dgvDpto"
        Me.dgvDpto.ReadOnly = True
        Me.dgvDpto.RowHeadersWidth = 51
        Me.dgvDpto.RowTemplate.Height = 24
        Me.dgvDpto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDpto.Size = New System.Drawing.Size(717, 286)
        Me.dgvDpto.TabIndex = 0
        '
        'IdDepartamentoDataGridViewTextBoxColumn
        '
        Me.IdDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "idDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.HeaderText = "idDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDepartamentoDataGridViewTextBoxColumn.Name = "IdDepartamentoDataGridViewTextBoxColumn"
        Me.IdDepartamentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDepartamentoDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDepartamentoDataGridViewTextBoxColumn
        '
        Me.NombreDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "nombreDepartamento"
        Me.NombreDepartamentoDataGridViewTextBoxColumn.HeaderText = "nombreDepartamento"
        Me.NombreDepartamentoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDepartamentoDataGridViewTextBoxColumn.Name = "NombreDepartamentoDataGridViewTextBoxColumn"
        Me.NombreDepartamentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDepartamentoDataGridViewTextBoxColumn.Width = 125
        '
        'ExtDataGridViewTextBoxColumn
        '
        Me.ExtDataGridViewTextBoxColumn.DataPropertyName = "ext"
        Me.ExtDataGridViewTextBoxColumn.HeaderText = "ext"
        Me.ExtDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ExtDataGridViewTextBoxColumn.Name = "ExtDataGridViewTextBoxColumn"
        Me.ExtDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExtDataGridViewTextBoxColumn.Width = 125
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Width = 125
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewTextBoxColumn.Width = 125
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me.LMBADataSet
        '
        'LMBADataSet
        '
        Me.LMBADataSet.DataSetName = "LMBADataSet"
        Me.LMBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbDpto
        '
        Me.gbDpto.Controls.Add(Me.dgvDpto)
        Me.gbDpto.Location = New System.Drawing.Point(21, 52)
        Me.gbDpto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDpto.Name = "gbDpto"
        Me.gbDpto.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbDpto.Size = New System.Drawing.Size(723, 305)
        Me.gbDpto.TabIndex = 8
        Me.gbDpto.TabStop = False
        Me.gbDpto.Text = "Departamentos"
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'FrmDpto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 411)
        Me.Controls.Add(Me.gbDpto)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmDpto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departamentos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvDpto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDpto.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAddDpto As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnEliminarDpto As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents modDpto As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents searchDpto As ToolStripButton
    Friend WithEvents tbBuscar As ToolStripTextBox
    Friend WithEvents dgvDpto As DataGridView
    Friend WithEvents LMBADataSet As LMBADataSet
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As LMBADataSetTableAdapters.DepartamentoTableAdapter
    Friend WithEvents IdDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents gbDpto As GroupBox
End Class
