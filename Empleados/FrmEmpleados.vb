Public Class FrmEmpleados

    Dim empleados As New LMBADataSetTableAdapters.EmpleadosDgvTableAdapter
    Dim idEmp As New Int32

    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
    End Sub

    Sub llenarGrid()
        DgvEmpleados.DataSource = empleados.GetData()
        DgvEmpleados.Columns("idDepartamento").Visible = False
        DgvEmpleados.Refresh()
    End Sub

    Private Sub DgvEmpleados_DoubleClick(sender As Object, e As EventArgs) Handles DgvEmpleados.DoubleClick
        Dim row = DgvEmpleados.CurrentRow.Index
        Dim emp = DgvEmpleados.Rows(row)
        Dim id = emp.Cells(0).Value
        idEmp = id
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click
        FrmModEmp.idEmp = idEmp
        FrmModEmp.Show()
    End Sub
End Class