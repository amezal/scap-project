Public Class VwEmpleados
    Private Sub VwEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LMBADataSet.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.LMBADataSet.Empleado)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class