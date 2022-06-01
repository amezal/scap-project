Public Class FrmAddCargo
    Dim dpto As New LMBADataSetTableAdapters.DepartamentoTableAdapter
    Dim car As New LMBADataSetTableAdapters.CargoTableAdapter

    Sub llenarDpto()
        cbDto.DataSource = dpto.GetData
        cbDto.DisplayMember = "nombreDepartamento"
        cbDto.ValueMember = "idDepartamento"

    End Sub
    Private Function Validar() As Boolean
        If (String.IsNullOrEmpty(txtCargo.Text)) Then
            MsgBox("El campo no puede quedar vacío", MsgBoxStyle.Critical, "ERROR")
            txtCargo.Focus()
            Return False
        End If

        If (String.IsNullOrEmpty(txtDesc.Text)) Then
            MsgBox("La descripción no puede quedar vacía", MsgBoxStyle.Critical, "ERROR")
            txtDesc.Focus()
            Return False

        End If
        Return True


    End Function
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (Not validar()) Then
            Exit Sub
        End If

        Try
            Dim idDpto As Integer = CInt(cbDto.SelectedValue)
            Dim newCargo As String = txtCargo.Text.Trim
            Dim desc As String = txtDesc.Text.Trim
            car.InsertarCargo(newCargo, desc, idDpto)
            FrmCargo.llenarGrid()
            MessageBox.Show("Guardado con éxito", "Cargo registrado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub FrmAddCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDpto()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class