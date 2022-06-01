<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAddEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddEmp))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.DtpNac = New System.Windows.Forms.DateTimePicker()
        Me.DtpIngreso = New System.Windows.Forms.DateTimePicker()
        Me.ChkEstado = New System.Windows.Forms.CheckBox()
        Me.BtnPIN2 = New System.Windows.Forms.Button()
        Me.BtnPIN = New System.Windows.Forms.Button()
        Me.CbxSexo = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPIN2 = New System.Windows.Forms.TextBox()
        Me.TxtPIN = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtEmailCorp = New System.Windows.Forms.TextBox()
        Me.TxtObservacion = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CbxDpto = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CbxHorario = New System.Windows.Forms.ComboBox()
        Me.CbxCargo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.TxtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.TxtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label0 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnGuardar, Me.ToolStripSeparator1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(631, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.SCAP_LMBA_Tech.My.Resources.Resources.icons8_cancel_50
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButton2.Text = "Cancelar"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'DtpNac
        '
        Me.DtpNac.Location = New System.Drawing.Point(125, 424)
        Me.DtpNac.Name = "DtpNac"
        Me.DtpNac.Size = New System.Drawing.Size(209, 20)
        Me.DtpNac.TabIndex = 66
        '
        'DtpIngreso
        '
        Me.DtpIngreso.Location = New System.Drawing.Point(125, 389)
        Me.DtpIngreso.Name = "DtpIngreso"
        Me.DtpIngreso.Size = New System.Drawing.Size(209, 20)
        Me.DtpIngreso.TabIndex = 65
        '
        'ChkEstado
        '
        Me.ChkEstado.AutoSize = True
        Me.ChkEstado.Location = New System.Drawing.Point(125, 278)
        Me.ChkEstado.Name = "ChkEstado"
        Me.ChkEstado.Size = New System.Drawing.Size(15, 14)
        Me.ChkEstado.TabIndex = 62
        Me.ChkEstado.UseVisualStyleBackColor = True
        '
        'BtnPIN2
        '
        Me.BtnPIN2.Location = New System.Drawing.Point(536, 278)
        Me.BtnPIN2.Name = "BtnPIN2"
        Me.BtnPIN2.Size = New System.Drawing.Size(64, 20)
        Me.BtnPIN2.TabIndex = 61
        Me.BtnPIN2.Text = "Ver"
        Me.BtnPIN2.UseVisualStyleBackColor = True
        '
        'BtnPIN
        '
        Me.BtnPIN.Location = New System.Drawing.Point(536, 242)
        Me.BtnPIN.Name = "BtnPIN"
        Me.BtnPIN.Size = New System.Drawing.Size(64, 20)
        Me.BtnPIN.TabIndex = 59
        Me.BtnPIN.Text = "Ver"
        Me.BtnPIN.UseVisualStyleBackColor = True
        '
        'CbxSexo
        '
        Me.CbxSexo.FormattingEnabled = True
        Me.CbxSexo.Location = New System.Drawing.Point(437, 203)
        Me.CbxSexo.Name = "CbxSexo"
        Me.CbxSexo.Size = New System.Drawing.Size(163, 21)
        Me.CbxSexo.TabIndex = 56
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(125, 37)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(163, 20)
        Me.txtID.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(90, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "ID:"
        '
        'TxtPIN2
        '
        Me.TxtPIN2.Location = New System.Drawing.Point(437, 278)
        Me.TxtPIN2.MaxLength = 4
        Me.TxtPIN2.Name = "TxtPIN2"
        Me.TxtPIN2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPIN2.Size = New System.Drawing.Size(93, 20)
        Me.TxtPIN2.TabIndex = 60
        '
        'TxtPIN
        '
        Me.TxtPIN.Location = New System.Drawing.Point(437, 242)
        Me.TxtPIN.MaxLength = 4
        Me.TxtPIN.Name = "TxtPIN"
        Me.TxtPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPIN.Size = New System.Drawing.Size(93, 20)
        Me.TxtPIN.TabIndex = 58
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(437, 171)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(163, 20)
        Me.TxtEmail.TabIndex = 54
        '
        'TxtEmailCorp
        '
        Me.TxtEmailCorp.Location = New System.Drawing.Point(125, 168)
        Me.TxtEmailCorp.Name = "TxtEmailCorp"
        Me.TxtEmailCorp.Size = New System.Drawing.Size(163, 20)
        Me.TxtEmailCorp.TabIndex = 53
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Location = New System.Drawing.Point(125, 349)
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(472, 20)
        Me.TxtObservacion.TabIndex = 64
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(125, 314)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(472, 20)
        Me.TxtDireccion.TabIndex = 63
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(17, 427)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 13)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "Fecha Nacimiento"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(346, 282)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 13)
        Me.Label16.TabIndex = 85
        Me.Label16.Text = "Confirmar PIN:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(125, 205)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(163, 20)
        Me.TxtTelefono.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(395, 245)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 13)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "PIN:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbxDpto
        '
        Me.CbxDpto.Enabled = False
        Me.CbxDpto.FormattingEnabled = True
        Me.CbxDpto.Location = New System.Drawing.Point(437, 132)
        Me.CbxDpto.Name = "CbxDpto"
        Me.CbxDpto.Size = New System.Drawing.Size(163, 21)
        Me.CbxDpto.TabIndex = 52
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 392)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 13)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "Fecha de Ingreso:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(344, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Email Personal:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(64, 278)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "Estado: "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(64, 242)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "Horario: "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbxHorario
        '
        Me.CbxHorario.FormattingEnabled = True
        Me.CbxHorario.Location = New System.Drawing.Point(125, 239)
        Me.CbxHorario.Name = "CbxHorario"
        Me.CbxHorario.Size = New System.Drawing.Size(163, 21)
        Me.CbxHorario.TabIndex = 57
        '
        'CbxCargo
        '
        Me.CbxCargo.FormattingEnabled = True
        Me.CbxCargo.Location = New System.Drawing.Point(125, 132)
        Me.CbxCargo.Name = "CbxCargo"
        Me.CbxCargo.Size = New System.Drawing.Size(163, 21)
        Me.CbxCargo.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Email Corporativo:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 352)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Observación:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(389, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Sexo:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(55, 317)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Dirección:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Teléfono:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(346, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Departamento:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Cargo:"
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(437, 37)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(163, 20)
        Me.TxtCedula.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(380, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Cedula:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPrimerApellido
        '
        Me.TxtPrimerApellido.Location = New System.Drawing.Point(125, 97)
        Me.TxtPrimerApellido.Name = "TxtPrimerApellido"
        Me.TxtPrimerApellido.Size = New System.Drawing.Size(163, 20)
        Me.TxtPrimerApellido.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(333, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Segundo Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Primer Apellido"
        '
        'TxtSegundoApellido
        '
        Me.TxtSegundoApellido.Location = New System.Drawing.Point(437, 97)
        Me.TxtSegundoApellido.Name = "TxtSegundoApellido"
        Me.TxtSegundoApellido.Size = New System.Drawing.Size(163, 20)
        Me.TxtSegundoApellido.TabIndex = 50
        '
        'TxtSegundoNombre
        '
        Me.TxtSegundoNombre.Location = New System.Drawing.Point(437, 67)
        Me.TxtSegundoNombre.Name = "TxtSegundoNombre"
        Me.TxtSegundoNombre.Size = New System.Drawing.Size(163, 20)
        Me.TxtSegundoNombre.TabIndex = 48
        '
        'TxtPrimerNombre
        '
        Me.TxtPrimerNombre.Location = New System.Drawing.Point(125, 67)
        Me.TxtPrimerNombre.Name = "TxtPrimerNombre"
        Me.TxtPrimerNombre.Size = New System.Drawing.Size(163, 20)
        Me.TxtPrimerNombre.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(330, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Segundo Nombre:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label0
        '
        Me.Label0.AutoSize = True
        Me.Label0.Location = New System.Drawing.Point(32, 67)
        Me.Label0.Name = "Label0"
        Me.Label0.Size = New System.Drawing.Size(79, 13)
        Me.Label0.TabIndex = 67
        Me.Label0.Text = "Primer Nombre:"
        Me.Label0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmAddEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 520)
        Me.Controls.Add(Me.DtpNac)
        Me.Controls.Add(Me.DtpIngreso)
        Me.Controls.Add(Me.ChkEstado)
        Me.Controls.Add(Me.BtnPIN2)
        Me.Controls.Add(Me.BtnPIN)
        Me.Controls.Add(Me.CbxSexo)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtPIN2)
        Me.Controls.Add(Me.TxtPIN)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtEmailCorp)
        Me.Controls.Add(Me.TxtObservacion)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.CbxDpto)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CbxHorario)
        Me.Controls.Add(Me.CbxCargo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPrimerApellido)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSegundoApellido)
        Me.Controls.Add(Me.TxtSegundoNombre)
        Me.Controls.Add(Me.TxtPrimerNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label0)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAddEmp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Empleado"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents DtpNac As DateTimePicker
    Friend WithEvents DtpIngreso As DateTimePicker
    Friend WithEvents ChkEstado As CheckBox
    Friend WithEvents BtnPIN2 As Button
    Friend WithEvents BtnPIN As Button
    Friend WithEvents CbxSexo As ComboBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtPIN2 As TextBox
    Friend WithEvents TxtPIN As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtEmailCorp As TextBox
    Friend WithEvents TxtObservacion As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CbxDpto As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CbxHorario As ComboBox
    Friend WithEvents CbxCargo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPrimerApellido As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSegundoApellido As TextBox
    Friend WithEvents TxtSegundoNombre As TextBox
    Friend WithEvents TxtPrimerNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label0 As Label
End Class
