<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPwd
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPwd))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnMod = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.gbUser = New System.Windows.Forms.GroupBox()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TbluserBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMBADataSet1 = New SCAP_LMBA_Tech.LMBADataSet()
        Me.TbluserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LMBADataSet = New SCAP_LMBA_Tech.LMBADataSet()
        Me.Tbl_userTableAdapter = New SCAP_LMBA_Tech.LMBADataSetTableAdapters.tbl_userTableAdapter()
        Me.DepartamentoTableAdapter1 = New SCAP_LMBA_Tech.LMBADataSetTableAdapters.DepartamentoTableAdapter()
        Me.ToolStrip1.SuspendLayout()
        Me.gbUser.SuspendLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TbluserBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMBADataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.ToolStripSeparator1, Me.btnDelete, Me.ToolStripSeparator2, Me.btnMod, Me.ToolStripSeparator3, Me.btnSearch, Me.txtSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1035, 27)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_new_window_30
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 24)
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnDelete
        '
        Me.btnDelete.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_delete_24
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 24)
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'btnMod
        '
        Me.btnMod.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_edit_production_order_32
        Me.btnMod.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(97, 24)
        Me.btnMod.Text = "Modificar"
        Me.btnMod.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_search_24
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(76, 24)
        Me.btnSearch.Text = "Buscar"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 27)
        '
        'gbUser
        '
        Me.gbUser.Controls.Add(Me.dgvUser)
        Me.gbUser.Location = New System.Drawing.Point(0, 2)
        Me.gbUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbUser.Name = "gbUser"
        Me.gbUser.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbUser.Size = New System.Drawing.Size(1020, 446)
        Me.gbUser.TabIndex = 10
        Me.gbUser.TabStop = False
        Me.gbUser.Text = "Usuarios"
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUser.Location = New System.Drawing.Point(3, 17)
        Me.dgvUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.RowHeadersWidth = 51
        Me.dgvUser.RowTemplate.Height = 24
        Me.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUser.Size = New System.Drawing.Size(1014, 427)
        Me.dgvUser.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gbUser)
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1023, 450)
        Me.Panel1.TabIndex = 11
        '
        'TbluserBindingSource1
        '
        Me.TbluserBindingSource1.DataMember = "tbl_user"
        Me.TbluserBindingSource1.DataSource = Me.LMBADataSet1
        '
        'LMBADataSet1
        '
        Me.LMBADataSet1.DataSetName = "LMBADataSet"
        Me.LMBADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbluserBindingSource
        '
        Me.TbluserBindingSource.DataMember = "tbl_user"
        Me.TbluserBindingSource.DataSource = Me.LMBADataSet
        '
        'LMBADataSet
        '
        Me.LMBADataSet.DataSetName = "LMBADataSet"
        Me.LMBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_userTableAdapter
        '
        Me.Tbl_userTableAdapter.ClearBeforeFill = True
        '
        'DepartamentoTableAdapter1
        '
        Me.DepartamentoTableAdapter1.ClearBeforeFill = True
        '
        'FrmPwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 506)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmPwd"
        Me.Text = "Usuarios"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbUser.ResumeLayout(False)
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TbluserBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMBADataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbluserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnMod As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnSearch As ToolStripButton
    Friend WithEvents txtSearch As ToolStripTextBox
    Friend WithEvents gbUser As GroupBox
    Friend WithEvents dgvUser As DataGridView
    Friend WithEvents LMBADataSet As LMBADataSet
    Friend WithEvents TbluserBindingSource As BindingSource
    Friend WithEvents Tbl_userTableAdapter As LMBADataSetTableAdapters.tbl_userTableAdapter
    Friend WithEvents DepartamentoTableAdapter1 As LMBADataSetTableAdapters.DepartamentoTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LMBADataSet1 As LMBADataSet
    Friend WithEvents TbluserBindingSource1 As BindingSource
End Class
