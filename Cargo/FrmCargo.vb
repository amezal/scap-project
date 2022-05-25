Public Class FrmCargo

    Dim regCar As New LMBADataSetTableAdapters.CargoTableAdapter
    Dim idCar As Int32
    Dim nombreDepto As String
    Dim nombreCar As String
    Dim desc As String

    Private Sub FrmCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        BtnDeleteCar.Enabled = False
        BtnModCar.Enabled = False
    End Sub
    Private Sub BtnAddCar_Click(sender As Object, e As EventArgs) Handles BtnAddCar.Click
        ' FrmAddCargo.MdiParent = Me.MdiParent'
        FrmAddCargo.Show()

    End Sub

    Sub llenarGrid()
        DgvCargo.DataSource = regCar.GetData
        DgvCargo.Refresh()
        DgvCargo.Columns(0).Visible = False
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

    Private Sub BtnDeleteCar_Click(sender As Object, e As EventArgs) Handles BtnDeleteCar.Click
        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                regCar.EliminarRegistro(idCar)
                llenarGrid()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DgvCargo_DoubleClick(sender As Object, e As EventArgs) Handles DgvCargo.DoubleClick
        BtnModCar.Enabled = True
        BtnDeleteCar.Enabled = True
        Dim row = DgvCargo.CurrentRow.Index
        Dim car = DgvCargo.Rows(row)
        Dim id = car.Cells(0).Value
        idCar = id
        nombreCar = car.Cells(1).Value
        desc = car.Cells(2).Value
        nombreDepto = car.Cells(3).Value
    End Sub
    Private Sub BtnModCar_Click(sender As Object, e As EventArgs) Handles BtnModCar.Click
        FrmModCargo.idCar = idCar
        FrmModCargo.nombreDpto = nombreDepto
        FrmModCargo.nombreCar = nombreCar
        FrmModCargo.desc = desc
        FrmModCargo.Show()

    End Sub
End Class
