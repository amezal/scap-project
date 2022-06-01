Public Class FrmRegistros

    Dim empleados As New LMBADataSetTableAdapters.EmpleadosDgvTableAdapter
    Dim registros As New LMBADataSetTableAdapters.registroESTableAdapter
    Dim horarios As New LMBADataSetTableAdapters.HorarioTableAdapter


    Private Sub FrmRegistros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCbx()
    End Sub

    Private Sub llenarCbx()
        Dim emp = empleados.GetData()

        emp.Columns.Add("display", GetType(String), " Nombres + ' ' + Apellidos + ' - ' + ID")
        CbxBuscar.DataSource = emp
        CbxBuscar.DisplayMember = "display"
        CbxBuscar.ValueMember = "ID"

    End Sub

    Private Sub llenarTxt()
        Dim emp = empleados.GetData().Item(CbxBuscar.SelectedIndex)

        TxtID.Text = "ID: " & emp.ID
        TxtEmpleado.Text = "Nombres: " & emp.Nombres & " " & emp.Apellidos
        TxtCargo.Text = "Cargo: " & emp.Cargo
        TxtDpto.Text = "Departamento: " & emp.Departamento
    End Sub

    Public Sub llenarDgv()
        Dim reg = registros.GetDataDgv(CbxBuscar.SelectedValue)
        Dim emp = empleados.GetData().Select("ID='" & CbxBuscar.SelectedValue & "'")(0)
        Dim horario = horarios.GetData().Select("idHorario='" & emp("idHorario") & "'")(0)
        reg.Columns.Add("horasTrabajadas")
        reg.Columns.Add("horasExtra")

        DgvRegistros.DataSource = reg

        DgvRegistros.Columns("idRegistro").HeaderText = "ID"
        DgvRegistros.Columns("estado").Visible = False
        DgvRegistros.Columns("fecha").HeaderText = "Fecha"
        DgvRegistros.Columns("horaEntrada").HeaderText = "Entrada"
        DgvRegistros.Columns("horaSalida").HeaderText = "Salida"
        DgvRegistros.Columns("idJustificacion").Visible = False
        DgvRegistros.Columns("horasTrabajadas").HeaderText = "Horas Trabajadas"
        DgvRegistros.Columns("horasExtra").HeaderText = "Horas Extra"

        DgvRegistros.Columns("idRegistro").Width = 30
        DgvRegistros.Columns("fecha").Width = 120
        DgvRegistros.Columns("fecha").DefaultCellStyle.Format = "dddd dd-MM-yyyy"
        DgvRegistros.Columns("horaEntrada").DefaultCellStyle.Format = "HH:mm:ss"
        DgvRegistros.Columns("horaSalida").DefaultCellStyle.Format = "HH:mm:ss"
        DgvRegistros.Columns(0).Visible = False

        'Dim entrada As Date = DgvRegistros.Item("horaEntrada", 0).Value
        'Dim salida As Date = DgvRegistros.Item("horaSalida", 0).Value
        'TxtCargo.Text = salida.Subtract(entrada).ToString()

        For Each row In DgvRegistros.Rows
            Dim entrada As Date = row.Cells("horaEntrada").Value
            Dim salida As Date = row.Cells("horaSalida").Value
            Dim almuerzo = horario("almuerzo")
            Dim entradaH = horario("horaEntrada")
            Dim salidaH = horario("horaSalida")
            Dim horasNecesitadas = salidaH.Subtract(entradaH).Subtract(almuerzo)
            Dim horasTrabajadas = salida.Subtract(entrada).Subtract(almuerzo)
            Dim extras = horasTrabajadas.Subtract(horasNecesitadas)

            row.Cells("horasTrabajadas").Value = extras
            row.Cells("horasExtra").Value = horasTrabajadas
        Next
        DgvRegistros.Columns("Justificacion").DisplayIndex = 8
        DgvRegistros.Columns("Justificacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        llenarTxt()
        llenarDgv()
    End Sub

    Private Sub BtnJustificar_Click(sender As Object, e As EventArgs) Handles BtnJustificar.Click
        FrmJustificaciones.idEmp = CbxBuscar.SelectedValue
        Dim ids As New ArrayList
        Dim i As Integer

        For i = 0 To DgvRegistros.Rows.Count - 1 Step 1
            ids.Add(DgvRegistros.Item(0, i).Value)
        Next

        FrmJustificaciones.ids = ids
        FrmJustificaciones.Show()
    End Sub
End Class