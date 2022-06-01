Public Class FrmGenerarReportes
    Private Sub btnVwEmpleado_Click(sender As Object, e As EventArgs) Handles btnVwEmpleado.Click
        VwEmpleados.Show()
    End Sub

    Private Sub btnVwCargo_Click(sender As Object, e As EventArgs) Handles btnVwCargo.Click
        VwCargo.Show()
    End Sub

    Private Sub btnVwDepartamento_Click(sender As Object, e As EventArgs) Handles btnVwDepartamento.Click
        VwDepartamento.Show()
    End Sub
End Class