<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModRol
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.cbxOpcion = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.DgvOpcion = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DgvOpcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnGuardar, Me.ToolStripSeparator1, Me.BtnCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(549, 25)
        Me.ToolStrip1.TabIndex = 30
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "ID:"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_save_26
        Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_cancel_50
        Me.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(73, 22)
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Rol:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Opcion:"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(110, 72)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(161, 20)
        Me.txtID.TabIndex = 34
        '
        'txtRol
        '
        Me.txtRol.Location = New System.Drawing.Point(110, 132)
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(161, 20)
        Me.txtRol.TabIndex = 35
        '
        'cbxOpcion
        '
        Me.cbxOpcion.FormattingEnabled = True
        Me.cbxOpcion.Location = New System.Drawing.Point(110, 187)
        Me.cbxOpcion.Name = "cbxOpcion"
        Me.cbxOpcion.Size = New System.Drawing.Size(161, 21)
        Me.cbxOpcion.TabIndex = 36
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(110, 227)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 37
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(196, 227)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 38
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'DgvOpcion
        '
        Me.DgvOpcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOpcion.Location = New System.Drawing.Point(328, 28)
        Me.DgvOpcion.Name = "DgvOpcion"
        Me.DgvOpcion.Size = New System.Drawing.Size(184, 268)
        Me.DgvOpcion.TabIndex = 39
        '
        'FrmModRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 325)
        Me.Controls.Add(Me.DgvOpcion)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.cbxOpcion)
        Me.Controls.Add(Me.txtRol)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmModRol"
        Me.Text = "FrmModRol"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DgvOpcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnCancelar As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtRol As TextBox
    Friend WithEvents cbxOpcion As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents DgvOpcion As DataGridView
End Class
