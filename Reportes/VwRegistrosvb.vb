Public Class VwRegistrosvb
    Private Sub VwRegistrosvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LMBADataSet.registroES' Puede moverla o quitarla según sea necesario.
        Me.RegistroESTableAdapter.Fill(Me.LMBADataSet.registroES)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class