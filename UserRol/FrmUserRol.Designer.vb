<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserRol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserRol))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbUserRol = New System.Windows.Forms.GroupBox()
        Me.DgvUserRol = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnAddUR = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnDeleteUR = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnModUR = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.LMBADataSet = New SCAP_LMBA_Tech.LMBADataSet()
        Me.TbluserRolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_userRolTableAdapter = New SCAP_LMBA_Tech.LMBADataSetTableAdapters.tbl_userRolTableAdapter()
        Me.IdUserRolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.gbUserRol.SuspendLayout()
        CType(Me.DgvUserRol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbluserRolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gbUserRol)
        Me.Panel1.Location = New System.Drawing.Point(69, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(567, 297)
        Me.Panel1.TabIndex = 1
        '
        'gbUserRol
        '
        Me.gbUserRol.Controls.Add(Me.DgvUserRol)
        Me.gbUserRol.Location = New System.Drawing.Point(6, 3)
        Me.gbUserRol.Name = "gbUserRol"
        Me.gbUserRol.Size = New System.Drawing.Size(561, 294)
        Me.gbUserRol.TabIndex = 0
        Me.gbUserRol.TabStop = False
        Me.gbUserRol.Text = "GroupBox1"
        '
        'DgvUserRol
        '
        Me.DgvUserRol.AutoGenerateColumns = False
        Me.DgvUserRol.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgvUserRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUserRol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUserRolDataGridViewTextBoxColumn, Me.RolDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn})
        Me.DgvUserRol.DataSource = Me.TbluserRolBindingSource
        Me.DgvUserRol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvUserRol.Location = New System.Drawing.Point(3, 18)
        Me.DgvUserRol.Name = "DgvUserRol"
        Me.DgvUserRol.RowHeadersWidth = 51
        Me.DgvUserRol.RowTemplate.Height = 24
        Me.DgvUserRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvUserRol.Size = New System.Drawing.Size(555, 273)
        Me.DgvUserRol.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAddUR, Me.ToolStripSeparator1, Me.BtnDeleteUR, Me.ToolStripSeparator2, Me.BtnModUR, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 27)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnAddUR
        '
        Me.BtnAddUR.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_new_window_30
        Me.BtnAddUR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAddUR.Name = "BtnAddUR"
        Me.BtnAddUR.Size = New System.Drawing.Size(87, 24)
        Me.BtnAddUR.Text = "Agregar"
        Me.BtnAddUR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BtnDeleteUR
        '
        Me.BtnDeleteUR.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_delete_24
        Me.BtnDeleteUR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteUR.Name = "BtnDeleteUR"
        Me.BtnDeleteUR.Size = New System.Drawing.Size(87, 24)
        Me.BtnDeleteUR.Text = "Eliminar"
        Me.BtnDeleteUR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BtnModUR
        '
        Me.BtnModUR.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_edit_production_order_32
        Me.BtnModUR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnModUR.Name = "BtnModUR"
        Me.BtnModUR.Size = New System.Drawing.Size(97, 24)
        Me.BtnModUR.Text = "Modificar"
        Me.BtnModUR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'LMBADataSet
        '
        Me.LMBADataSet.DataSetName = "LMBADataSet"
        Me.LMBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbluserRolBindingSource
        '
        Me.TbluserRolBindingSource.DataMember = "tbl_userRol"
        Me.TbluserRolBindingSource.DataSource = Me.LMBADataSet
        '
        'Tbl_userRolTableAdapter
        '
        Me.Tbl_userRolTableAdapter.ClearBeforeFill = True
        '
        'IdUserRolDataGridViewTextBoxColumn
        '
        Me.IdUserRolDataGridViewTextBoxColumn.DataPropertyName = "id_UserRol"
        Me.IdUserRolDataGridViewTextBoxColumn.HeaderText = "id_UserRol"
        Me.IdUserRolDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdUserRolDataGridViewTextBoxColumn.Name = "IdUserRolDataGridViewTextBoxColumn"
        Me.IdUserRolDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdUserRolDataGridViewTextBoxColumn.Width = 125
        '
        'RolDataGridViewTextBoxColumn
        '
        Me.RolDataGridViewTextBoxColumn.DataPropertyName = "Rol"
        Me.RolDataGridViewTextBoxColumn.HeaderText = "Rol"
        Me.RolDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RolDataGridViewTextBoxColumn.Name = "RolDataGridViewTextBoxColumn"
        Me.RolDataGridViewTextBoxColumn.ReadOnly = True
        Me.RolDataGridViewTextBoxColumn.Width = 125
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Width = 125
        '
        'FrmUserRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUserRol"
        Me.Text = "UserRol"
        Me.Panel1.ResumeLayout(False)
        Me.gbUserRol.ResumeLayout(False)
        CType(Me.DgvUserRol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbluserRolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gbUserRol As GroupBox
    Friend WithEvents DgvUserRol As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnAddUR As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnDeleteUR As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BtnModUR As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents LMBADataSet As LMBADataSet
    Friend WithEvents TbluserRolBindingSource As BindingSource
    Friend WithEvents Tbl_userRolTableAdapter As LMBADataSetTableAdapters.tbl_userRolTableAdapter
    Friend WithEvents IdUserRolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
