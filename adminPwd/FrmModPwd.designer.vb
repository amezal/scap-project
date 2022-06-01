<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModPwd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModPwd))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSaveMod = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelMod = New System.Windows.Forms.ToolStripButton()
        Me.LMBADataSet = New SCAP_LMBA_Tech.LMBADataSet()
        Me.BtnPw2 = New System.Windows.Forms.Button()
        Me.BtnPwd = New System.Windows.Forms.Button()
        Me.TxtPwd2 = New System.Windows.Forms.TextBox()
        Me.TxtPwd = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.ChkEstado = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSaveMod, Me.ToolStripSeparator1, Me.btnCancelMod})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 27)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSaveMod
        '
        Me.btnSaveMod.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_save_26
        Me.btnSaveMod.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveMod.Name = "btnSaveMod"
        Me.btnSaveMod.Size = New System.Drawing.Size(86, 24)
        Me.btnSaveMod.Text = "Guardar"
        Me.btnSaveMod.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnCancelMod
        '
        Me.btnCancelMod.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_cancel_50
        Me.btnCancelMod.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelMod.Name = "btnCancelMod"
        Me.btnCancelMod.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelMod.Text = "Cancelar"
        Me.btnCancelMod.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'LMBADataSet
        '
        Me.LMBADataSet.DataSetName = "LMBADataSet"
        Me.LMBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnPw2
        '
        Me.BtnPw2.Location = New System.Drawing.Point(496, 330)
        Me.BtnPw2.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPw2.Name = "BtnPw2"
        Me.BtnPw2.Size = New System.Drawing.Size(85, 25)
        Me.BtnPw2.TabIndex = 8
        Me.BtnPw2.Text = "Ver"
        Me.BtnPw2.UseVisualStyleBackColor = True
        '
        'BtnPwd
        '
        Me.BtnPwd.Location = New System.Drawing.Point(496, 286)
        Me.BtnPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPwd.Name = "BtnPwd"
        Me.BtnPwd.Size = New System.Drawing.Size(85, 25)
        Me.BtnPwd.TabIndex = 6
        Me.BtnPwd.Text = "Ver"
        Me.BtnPwd.UseVisualStyleBackColor = True
        '
        'TxtPwd2
        '
        Me.TxtPwd2.Location = New System.Drawing.Point(364, 330)
        Me.TxtPwd2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPwd2.MaxLength = 4
        Me.TxtPwd2.Name = "TxtPwd2"
        Me.TxtPwd2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPwd2.Size = New System.Drawing.Size(123, 22)
        Me.TxtPwd2.TabIndex = 7
        '
        'TxtPwd
        '
        Me.TxtPwd.Location = New System.Drawing.Point(364, 286)
        Me.TxtPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPwd.MaxLength = 4
        Me.TxtPwd.Name = "TxtPwd"
        Me.TxtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPwd.Size = New System.Drawing.Size(123, 22)
        Me.TxtPwd.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(157, 331)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(148, 17)
        Me.Label16.TabIndex = 121
        Me.Label16.Text = "Confirmar contraseña:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(220, 291)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 17)
        Me.Label15.TabIndex = 120
        Me.Label15.Text = "Contraseña:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(364, 80)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(216, 22)
        Me.txtID.TabIndex = 112
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(280, 82)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 17)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "ID:"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(364, 201)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(216, 22)
        Me.TxtEmail.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 205)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Email:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(364, 153)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(216, 22)
        Me.TxtApellido.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(243, 160)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Apellido:"
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(364, 245)
        Me.TxtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(216, 22)
        Me.TxtUser.TabIndex = 4
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(364, 116)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(216, 22)
        Me.TxtNombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 249)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "User:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Location = New System.Drawing.Point(243, 121)
        Me.Label0.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(62, 17)
        Me.Label0.TabIndex = 110
        Me.Label0.Text = "Nombre:"
        Me.Label0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkEstado
        '
        Me.ChkEstado.AutoSize = True
        Me.ChkEstado.Location = New System.Drawing.Point(364, 367)
        Me.ChkEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkEstado.Name = "ChkEstado"
        Me.ChkEstado.Size = New System.Drawing.Size(18, 17)
        Me.ChkEstado.TabIndex = 9
        Me.ChkEstado.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(245, 367)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 17)
        Me.Label17.TabIndex = 123
        Me.Label17.Text = "Estado: "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmModPwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ChkEstado)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.BtnPw2)
        Me.Controls.Add(Me.BtnPwd)
        Me.Controls.Add(Me.TxtPwd2)
        Me.Controls.Add(Me.TxtPwd)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label0)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmModPwd"
        Me.Text = "Modificar Usuario"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.LMBADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSaveMod As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnCancelMod As ToolStripButton
    Friend WithEvents LMBADataSet As LMBADataSet
    Friend WithEvents BtnPw2 As Button
    Friend WithEvents BtnPwd As Button
    Friend WithEvents TxtPwd2 As TextBox
    Friend WithEvents TxtPwd As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label0 As Label
    Friend WithEvents ChkEstado As CheckBox
    Friend WithEvents Label17 As Label
End Class
