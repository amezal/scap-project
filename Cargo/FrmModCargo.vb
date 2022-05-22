Public Class FrmModCargo
  
    Public idCar As Integer
    Public nombreDpto As String
    Public nombreCar As String
    Public desc As String
    Dim estado As Boolean
    Dim dpto As New LMBADataSetTableAdapters.DepartamentoTableAdapter
    Dim car As New LMBADataSetTableAdapters.CargoTableAdapter

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
    

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (String.IsNullOrEmpty(txtCargo.Text)) Then
            MsgBox("El cargo no puede quedar vacío", MsgBoxStyle.Critical, "ERROR")
            txtCargo.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(txtCargo.Text)) Then
            MsgBox("La descripción no puede quedar vacía", MsgBoxStyle.Critical, "ERROR")
            txtCargo.Focus()
            Exit Sub
        End If
        Dim nombreCarg As String = txtCargo.Text.Trim
        Dim des As String = txtDesc.Text.Trim
        Dim idDepto As Integer = CInt(cbDto.SelectedValue)
        car.ActualizarRegistro(nombreCarg, des, estado, idDepto, idCar)
        FrmCargo.llenarGrid()
    End Sub
End Class