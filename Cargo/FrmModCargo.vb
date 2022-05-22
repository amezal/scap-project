Public Class FrmModCargo
    Public idCar As Int32
    Public nombreDpto As String
    Public nombreCar As String
    Public desc As String
    Dim dpto As New LMBADataSetTableAdapters.DepartamentoTableAdapter

    Private Sub FrmModCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCargo.Text = nombreCar
        txtDesc.Text = desc
        llenarDpto()

    End Sub
    Sub llenarDpto()
        cbDto.DataSource = dpto.GetData
        cbDto.DisplayMember = "nombreDepartamento"
        cbDto.ValueMember = "idDepartamento"
        cbDto.SelectedValue = dpto.GetData().Select("nombreDepartamento='" & nombreDpto & "'")(0)("idDepartamento")
        cbDto.Refresh()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub
End Class