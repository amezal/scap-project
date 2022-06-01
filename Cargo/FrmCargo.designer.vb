<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargo))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnAddCar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDeleteCar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnModCar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSearchCar = New System.Windows.Forms.ToolStripButton()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgvCargo = New System.Windows.Forms.DataGridView()
        Me.idCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCargoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMBADataSet = New SCAP_LMBA_Tech.LMBADataSet()
        Me.CargoTableAdapter = New SCAP_LMBA_Tech.LMBADataSetTableAdapters.CargoTableAdapter()
        Me.DepartamentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentoTableAdapter = New SCAP_LMBA_Tech.LMBADataSetTableAdapters.DepartamentoTableAdapter()
        Me.GbCargo = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCargo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAddCar, Me.ToolStripSeparator1, Me.BtnDeleteCar, Me.ToolStripSeparator2, Me.BtnModCar, Me.ToolStripSeparator3, Me.BtnSearchCar, Me.txtSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(600, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnAddCar
        '
        Me.BtnAddCar.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_new_window_30
        Me.BtnAddCar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddCar.Name = "BtnAddCar"
        Me.BtnAddCar.Size = New System.Drawing.Size(69, 22)
        Me.BtnAddCar.Text = "Agregar"
        Me.BtnAddCar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnDeleteCar
        '
        Me.BtnDeleteCar.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_delete_24
        Me.BtnDeleteCar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteCar.Name = "BtnDeleteCar"
        Me.BtnDeleteCar.Size = New System.Drawing.Size(70, 22)
        Me.BtnDeleteCar.Text = "Eliminar"
        Me.BtnDeleteCar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BtnModCar
        '
        Me.BtnModCar.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_edit_production_order_32
        Me.BtnModCar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnModCar.Name = "BtnModCar"
        Me.BtnModCar.Size = New System.Drawing.Size(78, 22)
        Me.BtnModCar.Text = "Modificar"
        Me.BtnModCar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BtnSearchCar
        '
        Me.BtnSearchCar.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_search_24
        Me.BtnSearchCar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSearchCar.Name = "BtnSearchCar"
        Me.BtnSearchCar.Size = New System.Drawing.Size(62, 22)
        Me.BtnSearchCar.Text = "Buscar"
        Me.BtnSearchCar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'txtSearch
        '
        Me.txtSearch.AutoSize = False
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 23)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DgvCargo)
        Me.Panel1.Location = New System.Drawing.Point(4, 16)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(563, 284)
        Me.Panel1.TabIndex = 14
        '
        'DgvCargo
        '
        Me.DgvCargo.AllowUserToAddRows = False
        Me.DgvCargo.AllowUserToDeleteRows = False
        Me.DgvCargo.AutoGenerateColumns = False
        Me.DgvCargo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvCargo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCargo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCargo, Me.NombreCargoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.Departamento})
        Me.DgvCargo.DataSource = Me.CargoBindingSource
        Me.DgvCargo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCargo.Location = New System.Drawing.Point(0, 0)
        Me.DgvCargo.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvCargo.Name = "DgvCargo"
        Me.DgvCargo.ReadOnly = True
        Me.DgvCargo.RowTemplate.Height = 24
        Me.DgvCargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCargo.Size = New System.Drawing.Size(563, 284)
        Me.DgvCargo.TabIndex = 0
        '
        'idCargo
        '
        Me.idCargo.DataPropertyName = "idCargo"
        Me.idCargo.HeaderText = "ID"
        Me.idCargo.Name = "idCargo"
        Me.idCargo.ReadOnly = True
        Me.idCargo.Width = 43
        '
        'NombreCargoDataGridViewTextBoxColumn
        '
        Me.NombreCargoDataGridViewTextBoxColumn.DataPropertyName = "nombreCargo"
        Me.NombreCargoDataGridViewTextBoxColumn.HeaderText = "Cargo"
        Me.NombreCargoDataGridViewTextBoxColumn.Name = "NombreCargoDataGridViewTextBoxColumn"
        Me.NombreCargoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreCargoDataGridViewTextBoxColumn.Width = 60
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 86
        '
        'Departamento
        '
        Me.Departamento.DataPropertyName = "Departamento"
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.Name = "Departamento"
        Me.Departamento.ReadOnly = True
        Me.Departamento.Width = 99
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "Cargo"
        Me.CargoBindingSource.DataSource = Me.LMBADataSet
        '
        'LMBADataSet
        '
        Me.LMBADataSet.DataSetName = "LMBADataSet"
        Me.LMBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'DepartamentoBindingSource
        '
        Me.DepartamentoBindingSource.DataMember = "Departamento"
        Me.DepartamentoBindingSource.DataSource = Me.LMBADataSet
        '
        'DepartamentoTableAdapter
        '
        Me.DepartamentoTableAdapter.ClearBeforeFill = True
        '
        'GbCargo
        '
        Me.GbCargo.Controls.Add(Me.Panel1)
        Me.GbCargo.Location = New System.Drawing.Point(9, 34)
        Me.GbCargo.Margin = New System.Windows.Forms.Padding(2)
        Me.GbCargo.Name = "GbCargo"
        Me.GbCargo.Padding = New System.Windows.Forms.Padding(2)
        Me.GbCargo.Size = New System.Drawing.Size(572, 304)
        Me.GbCargo.TabIndex = 15
        Me.GbCargo.TabStop = False
        Me.GbCargo.Text = "Cargos de Empleados"
        '
        'FrmCargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 348)
        Me.Controls.Add(Me.GbCargo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmCargo"
        Me.Text = "Cargo"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCargo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnAddCar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnDeleteCar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BtnModCar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BtnSearchCar As ToolStripButton
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DgvCargo As DataGridView
    Friend WithEvents LMBADataSet As LMBADataSet
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents CargoTableAdapter As LMBADataSetTableAdapters.CargoTableAdapter
    Friend WithEvents DepartamentoBindingSource As BindingSource
    Friend WithEvents DepartamentoTableAdapter As LMBADataSetTableAdapters.DepartamentoTableAdapter
    Friend WithEvents GbCargo As GroupBox
    Friend WithEvents IdDepartamentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents idCargo As DataGridViewTextBoxColumn
    Friend WithEvents NombreCargoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Departamento As DataGridViewTextBoxColumn
End Class
