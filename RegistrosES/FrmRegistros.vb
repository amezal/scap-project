Public Class FrmRegistros

    Dim empleado As New LMBADataSetTableAdapters.EmpleadosDgvTableAdapter

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

    Private Sub CbxBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxBuscar.SelectedIndexChanged
        Dim emp = empleado.GetData().Item(CbxBuscar.SelectedIndex)
        TxtID.Text = "ID: " & emp.ID
        TxtEmpleado.Text = "Nombres: " & emp.Nombres & " " & emp.Apellidos
        TxtCargo.Text = "Cargo: " & emp.Cargo
        TxtDpto.Text = "Departamento: " & emp.Departamento
    End Sub
End Class