Public Class FrmCargo

    Dim regCar As New LMBADataSetTableAdapters.CargoTableAdapter

    Private Sub FrmCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
    End Sub
    Private Sub BtnAddCar_Click(sender As Object, e As EventArgs) Handles BtnAddCar.Click
        ' FrmAddCargo.MdiParent = Me.MdiParent'
        FrmAddCargo.Show()

    End Sub

    Private Sub BtnModCar_Click(sender As Object, e As EventArgs) Handles BtnModCar.Click
        FrmModCargo.Show()

    End Sub

    Sub llenarGrid()
        DgvCargo.DataSource = regCar.GetData
        DgvCargo.Refresh()
        GbCargo.Text = "Mostrando registros: " & DgvCargo.Rows.Count.ToString
    End Sub

    Private Sub BtnSearchCar_Click(sender As Object, e As EventArgs) Handles BtnSearchCar.Click
        Try
            Dim dato As String = txtSearch.Text & "%"
            DgvCargo.DataSource = regCar.BuscarPorCargo(dato)
            DgvCargo.Refresh()

        Catch ex As Exception

        End Try
    End Sub

End Class
