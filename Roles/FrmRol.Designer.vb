<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRol
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnAgregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnMod = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.TxtBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.DgvRoles = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DgvRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnAgregar, Me.ToolStripSeparator1, Me.BtnEliminar, Me.ToolStripSeparator2, Me.BtnMod, Me.ToolStripSeparator3, Me.BtnBuscar, Me.TxtBuscar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(559, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_new_window_30
        Me.BtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(69, 22)
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_delete_24
        Me.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(70, 22)
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BtnMod
        '
        Me.BtnMod.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_edit_production_order_32
        Me.BtnMod.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnMod.Name = "BtnMod"
        Me.BtnMod.Size = New System.Drawing.Size(78, 22)
        Me.BtnMod.Text = "Modificar"
        Me.BtnMod.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(150, 25)
        '
        'DgvRoles
        '
        Me.DgvRoles.AllowUserToAddRows = False
        Me.DgvRoles.AllowUserToDeleteRows = False
        Me.DgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRoles.Location = New System.Drawing.Point(0, 25)
        Me.DgvRoles.Name = "DgvRoles"
        Me.DgvRoles.ReadOnly = True
        Me.DgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRoles.Size = New System.Drawing.Size(559, 425)
        Me.DgvRoles.TabIndex = 2
        '
        'FrmRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 450)
        Me.Controls.Add(Me.DgvRoles)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmRol"
        Me.Text = "FrmRol"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DgvRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnAgregar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnEliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BtnMod As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BtnBuscar As ToolStripButton
    Friend WithEvents TxtBuscar As ToolStripTextBox
    Friend WithEvents DgvRoles As DataGridView
End Class
