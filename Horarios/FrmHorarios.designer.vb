<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHorarios
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.addHor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEliminarHor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.modHor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.searchHor = New System.Windows.Forms.ToolStripButton()
        Me.tbBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.gbHorario = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvHorario = New System.Windows.Forms.DataGridView()
        Me.IdHorarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraEntradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMBADataSet = New SCAP_LMBA_Tech.LMBADataSet()
        Me.LMBADataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HorarioTableAdapter = New SCAP_LMBA_Tech.LMBADataSetTableAdapters.HorarioTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        Me.gbHorario.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMBADataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addHor, Me.ToolStripSeparator1, Me.btnEliminarHor, Me.ToolStripSeparator2, Me.modHor, Me.ToolStripSeparator3, Me.searchHor, Me.tbBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(773, 30)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'addHor
        '
        Me.addHor.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_new_window_30
        Me.addHor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.addHor.Name = "addHor"
        Me.addHor.Size = New System.Drawing.Size(87, 27)
        Me.addHor.Text = "Agregar"
        Me.addHor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'btnEliminarHor
        '
        Me.btnEliminarHor.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_delete_24
        Me.btnEliminarHor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminarHor.Name = "btnEliminarHor"
        Me.btnEliminarHor.Size = New System.Drawing.Size(87, 27)
        Me.btnEliminarHor.Text = "Eliminar"
        Me.btnEliminarHor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'modHor
        '
        Me.modHor.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_edit_production_order_32
        Me.modHor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.modHor.Name = "modHor"
        Me.modHor.Size = New System.Drawing.Size(97, 27)
        Me.modHor.Text = "Modificar"
        Me.modHor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 30)
        '
        'searchHor
        '
        Me.searchHor.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_search_24
        Me.searchHor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.searchHor.Name = "searchHor"
        Me.searchHor.Size = New System.Drawing.Size(76, 27)
        Me.searchHor.Text = "Buscar"
        Me.searchHor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'tbBuscar
        '
        Me.tbBuscar.AutoSize = False
        Me.tbBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(200, 30)
        '
        'gbHorario
        '
        Me.gbHorario.Controls.Add(Me.Panel1)
        Me.gbHorario.Location = New System.Drawing.Point(21, 52)
        Me.gbHorario.Name = "gbHorario"
        Me.gbHorario.Size = New System.Drawing.Size(722, 305)
        Me.gbHorario.TabIndex = 8
        Me.gbHorario.TabStop = False
        Me.gbHorario.Text = "Horarios"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvHorario)
        Me.Panel1.Location = New System.Drawing.Point(0, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(749, 348)
        Me.Panel1.TabIndex = 0
        '
        'dgvHorario
        '
        Me.dgvHorario.AutoGenerateColumns = False
        Me.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHorario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdHorarioDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.HoraEntradaDataGridViewTextBoxColumn, Me.HoraSalidaDataGridViewTextBoxColumn})
        Me.dgvHorario.DataSource = Me.HorarioBindingSource
        Me.dgvHorario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHorario.Location = New System.Drawing.Point(0, 0)
        Me.dgvHorario.Name = "dgvHorario"
        Me.dgvHorario.RowHeadersWidth = 51
        Me.dgvHorario.RowTemplate.Height = 24
        Me.dgvHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHorario.Size = New System.Drawing.Size(749, 348)
        Me.dgvHorario.TabIndex = 0
        '
        'IdHorarioDataGridViewTextBoxColumn
        '
        Me.IdHorarioDataGridViewTextBoxColumn.DataPropertyName = "idHorario"
        Me.IdHorarioDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdHorarioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdHorarioDataGridViewTextBoxColumn.Name = "IdHorarioDataGridViewTextBoxColumn"
        Me.IdHorarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdHorarioDataGridViewTextBoxColumn.Width = 125
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 125
        '
        'HoraEntradaDataGridViewTextBoxColumn
        '
        Me.HoraEntradaDataGridViewTextBoxColumn.DataPropertyName = "horaEntrada"
        Me.HoraEntradaDataGridViewTextBoxColumn.HeaderText = "Hora de entrada"
        Me.HoraEntradaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HoraEntradaDataGridViewTextBoxColumn.Name = "HoraEntradaDataGridViewTextBoxColumn"
        Me.HoraEntradaDataGridViewTextBoxColumn.Width = 125
        '
        'HoraSalidaDataGridViewTextBoxColumn
        '
        Me.HoraSalidaDataGridViewTextBoxColumn.DataPropertyName = "horaSalida"
        Me.HoraSalidaDataGridViewTextBoxColumn.HeaderText = "Hora de salida"
        Me.HoraSalidaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoraSalidaDataGridViewTextBoxColumn.Name = "HoraSalidaDataGridViewTextBoxColumn"
        Me.HoraSalidaDataGridViewTextBoxColumn.Width = 125
        '
        'HorarioBindingSource
        '
        Me.HorarioBindingSource.DataMember = "Horario"
        Me.HorarioBindingSource.DataSource = Me.LMBADataSet
        '
        'LMBADataSet
        '
        Me.LMBADataSet.DataSetName = "LMBADataSet"
        Me.LMBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LMBADataSetBindingSource
        '
        Me.LMBADataSetBindingSource.DataSource = Me.LMBADataSet
        Me.LMBADataSetBindingSource.Position = 0
        '
        'HorarioTableAdapter
        '
        Me.HorarioTableAdapter.ClearBeforeFill = True
        '
        'FrmHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 411)
        Me.Controls.Add(Me.gbHorario)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horarios de empleados"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbHorario.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvHorario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMBADataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents addHor As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnEliminarHor As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents modHor As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents searchHor As ToolStripButton
    Friend WithEvents tbBuscar As ToolStripTextBox
    Friend WithEvents gbHorario As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvHorario As DataGridView
    Friend WithEvents LMBADataSetBindingSource As BindingSource
    Friend WithEvents LMBADataSet As LMBADataSet
    Friend WithEvents HorarioBindingSource As BindingSource
    Friend WithEvents HorarioTableAdapter As LMBADataSetTableAdapters.HorarioTableAdapter
    Friend WithEvents IdHorarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraEntradaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraSalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
