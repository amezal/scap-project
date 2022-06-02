Public Class VwCargo
    Private Sub VwCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LMBADataSet.Cargo' Puede moverla o quitarla según sea necesario.
        Me.CargoTableAdapter.Fill(Me.LMBADataSet.Cargo)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class