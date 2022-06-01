Public Class FrmLoginEmpleado
    Dim empleados As New LMBADataSetTableAdapters.EmpleadoTableAdapter

    Private Sub FrmLoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim emp = empleados.GetData()
        emp.Columns.Add("display", GetType(String), " primerNombre + ' ' + primerApellido + ' - ' + idEmpleado")
        cbxEmp.DataSource = emp
        cbxEmp.DisplayMember = "display"
        cbxEmp.ValueMember = "idEmpleado"
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim valido As Boolean
        Try
            valido = empleados.GetData.Select($"idEmpleado='{cbxEmp.SelectedValue}' AND PIN='{txtPIN.Text}'").Count > 0
            If (valido) Then
                MsgBox("Bienvenido!", MsgBoxStyle.MsgBoxHelp, "Éxito")
                FrmMarcarES.idEmp = cbxEmp.SelectedValue
                FrmMarcarES.Show()
                Me.Hide()
                txtPIN.Text = ""
            Else
                MsgBox("Inicio de sesión incorrecto", MsgBoxStyle.Critical, "Error")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class
