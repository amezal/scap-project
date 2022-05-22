Public Class FrmAddEmp

    Dim cargos As New LMBADataSetTableAdapters.CargoTableAdapter
    Dim dptos As New LMBADataSetTableAdapters.DepartamentoTableAdapter
    Dim horarios As New LMBADataSetTableAdapters.HorarioTableAdapter

    Private Sub FrmAddEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbxCargo.DataSource = cargos.GetData()
        CbxCargo.DisplayMember = "nombreCargo"
        CbxCargo.ValueMember = "idCargo"

        CbxDpto.DataSource = dptos.GetData()
        CbxDpto.DisplayMember = "nombreDepartamento"
        CbxDpto.ValueMember = "idDepartamento"

        CbxHorario.DataSource = horarios.GetData()
        CbxHorario.DisplayMember = "nombre"
        CbxHorario.ValueMember = "idHorario"

        CbxSexo.Items.Add("Hombre")
        CbxSexo.Items.Add("Mujer")
    End Sub
End Class