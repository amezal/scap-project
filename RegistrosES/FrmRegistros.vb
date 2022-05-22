Public Class FrmRegistros

    Dim empleado As New LMBADataSetTableAdapters.EmpleadosDgvTableAdapter
    Dim registros As New LMBADataSetTableAdapters.registroESTableAdapter

    Private Sub FrmRegistros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCbx()
    End Sub

    Private Sub llenarCbx()
        Dim emp = empleado.GetData()
        emp.Columns.Add("display", GetType(String), " Nombres + ' ' + Apellidos + ' - ' + ID")
        CbxBuscar.DataSource = emp
        CbxBuscar.DisplayMember = "display"
        CbxBuscar.ValueMember = "ID"
    End Sub

    Private Sub llenarTxt()
        Dim emp = empleado.GetData().Item(CbxBuscar.SelectedIndex)
        TxtID.Text = "ID: " & emp.ID
        TxtEmpleado.Text = "Nombres: " & emp.Nombres & " " & emp.Apellidos
        TxtCargo.Text = "Cargo: " & emp.Cargo
        TxtDpto.Text = "Departamento: " & emp.Departamento
    End Sub

    Private Sub llenarDgv()
        Dim reg = registros.GetDataDgv(CbxBuscar.SelectedValue)
        'reg.Columns.Add("Entrada", GetType(String), )
        DgvRegistros.DataSource = reg

        DgvRegistros.Columns("idRegistro").HeaderText = "ID"
        DgvRegistros.Columns("estado").Visible = False
        DgvRegistros.Columns("fecha").HeaderText = "Fecha"
        DgvRegistros.Columns("horaEntrada").HeaderText = "Entrada"
        DgvRegistros.Columns("horaSalida").HeaderText = "Salida"
        DgvRegistros.Columns("idJustificacion").Visible = False

        DgvRegistros.Columns("idRegistro").Width = 30
        DgvRegistros.Columns("fecha").Width = 120
        DgvRegistros.Columns("fecha").DefaultCellStyle.Format = "dddd dd-MM-yyyy"
        DgvRegistros.Columns("horaEntrada").DefaultCellStyle.Format = "hh:mm:sstt"
        DgvRegistros.Columns("horaSalida").DefaultCellStyle.Format = "hh:mm:sstt"



    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        llenarTxt()
        llenarDgv()
    End Sub
End Class