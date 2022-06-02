Public Class VwDepartamento
    Private Sub VwDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LMBADataSet.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.LMBADataSet.Departamento)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class