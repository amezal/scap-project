Public Class FrmModEmp

    Public idEmp As New Int32
    Dim empleado As New LMBADataSetTableAdapters.EmpleadoTableAdapter
    Dim cargos As New LMBADataSetTableAdapters.CargoTableAdapter
    Dim dptos As New LMBADataSetTableAdapters.DepartamentoTableAdapter
    Dim horarios As New LMBADataSetTableAdapters.HorarioTableAdapter
    Dim tblEmp As New LMBADataSet.EmpleadoDataTable


    Private Sub FrmModEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCedula.Select()
        tblEmp = empleado.GetEmpleado(idEmp)
        fillCampos()
    End Sub

    Private Sub fillCampos()
        Dim emp = tblEmp.Item(0)
        txtID.Text = emp.idEmpleado
        TxtCedula.Text = emp.numCedula
        TxtPrimerNombre.Text = emp.primerNombre
        TxtSegundoNombre.Text = If(emp.IsNull("segundoNombre"), "", emp.segundoNombre)
        TxtPrimerApellido.Text = emp.primerApellido
        TxtSegundoApellido.Text = If(emp.IsNull("segundoApellido"), "", emp.segundoApellido)

        'cargo y dpto
        CbxCargo.DataSource = cargos.GetData()
        CbxCargo.DisplayMember = "nombreCargo"
        CbxCargo.ValueMember = "idCargo"
        CbxCargo.SelectedValue = emp.idCargo

        CbxDpto.DataSource = dptos.GetData()
        CbxDpto.DisplayMember = "nombreDepartamento"
        CbxDpto.ValueMember = "idDepartamento"
        CbxDpto.SelectedValue = cargos.GetData().Select("idCargo='" & emp.idCargo & "'")(0)("idDepartamento")
        '

        TxtEmailCorp.Text = emp.emailCorporativo
        TxtEmail.Text = If(emp.IsNull("emailPersonal"), "", emp.emailPersonal)
        TxtTelefono.Text = emp.telefono

        'sexo y horario
        CbxSexo.Items.Add("Hombre")
        CbxSexo.Items.Add("Mujer")
        CbxSexo.SelectedText = If(emp.sexo, "Hombre", "Mujer")

        CbxHorario.DataSource = horarios.GetData()
        CbxHorario.DisplayMember = "nombre"
        CbxHorario.ValueMember = "idHorario"
        CbxHorario.SelectedValue = emp.idHorario
        '

        ChkEstado.Checked = emp.estado
        TxtPIN.Text = emp.PIN
        TxtDireccion.Text = emp.direccion
        TxtObservacion.Text = If(emp.IsNull("observacion"), "", emp.observacion)
        'fechas
        DtpIngreso.Value = If(emp.IsNull("fechaIngreso"), Date.Today, emp.fechaIngreso)
        DtpNac.Value = emp.fechaNacimiento
    End Sub

    Private Sub BtnPIN_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnPIN.MouseDown
        TxtPIN.PasswordChar = ""
    End Sub

    Private Sub BtnPIN_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnPIN.MouseUp
        TxtPIN.PasswordChar = "*"
    End Sub

    Private Sub BtnPIN2_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnPIN2.MouseDown
        TxtPIN2.PasswordChar = ""
    End Sub

    Private Sub BtnPIN2_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnPIN2.MouseUp
        TxtPIN2.PasswordChar = "*"
    End Sub
End Class