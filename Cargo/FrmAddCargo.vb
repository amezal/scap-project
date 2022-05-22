Public Class FrmAddCargo
    Dim dpto As New LMBADataSetTableAdapters.DepartamentoTableAdapter
    Dim car As New LMBADataSetTableAdapters.CargoTableAdapter

    Sub llenarDpto()
        cbDto.DataSource = dpto.GetData
        cbDto.DisplayMember = "nombreDepartamento"
        cbDto.ValueMember = "idDepartamento"

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim idDpto As Integer = CInt(cbDto.SelectedValue)
            Dim newCargo As String = txtCargo.Text.Trim
            Dim desc As String = txtDesc.Text.Trim
            car.InsertQuery(newCargo, desc, idDpto)
            FrmCargo.llenarGrid()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmAddCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDpto()
    End Sub


End Class