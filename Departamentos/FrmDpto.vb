Public Class FrmDpto

    Dim Dpto As New LMBADataSetTableAdapters.DepartamentoTableAdapter
    Dim idDpto As New Int32
    Dim nombreDpto As String
    Dim ext As String
    Dim email As String

    Sub llenarGrid()
        dgvDpto.DataSource = Dpto.GetData
        dgvDpto.Refresh()
        dgvDpto.Columns(0).Visible = False
        gbDpto.Text = "Mostrando horarios: " & dgvDpto.Rows.Count.ToString
    End Sub
        'Aqui se carga
    Private Sub FrmDpto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LMBADataSet.Departamento' Puede moverla o quitarla según sea necesario.
        Me.DepartamentoTableAdapter.Fill(Me.LMBADataSet.Departamento)
        llenarGrid()
        modDpto.Enabled = False
        btnEliminarDpto.Enabled = False
    End Sub
    Private Sub btnAddDpto_Click(sender As Object, e As EventArgs) Handles btnAddDpto.Click
        FrmAddDpto.Show()
    End Sub

    Private Sub searchDpto_Click(sender As Object, e As EventArgs) Handles searchDpto.Click
        Try
            Dim data As String = tbBuscar.Text & "%"
            dgvDpto.DataSource = Dpto.BuscarPorDpto(data)
            dgvDpto.Refresh()

            gbDpto.Text = "Horarios encontrados: " & dgvDpto.Rows.Count.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvDpto_DoubleClick(sender As Object, e As EventArgs) Handles dgvDpto.DoubleClick
        modDpto.Enabled = True
        btnEliminarDpto.Enabled = True
        Dim row As Integer = dgvDpto.CurrentRow.Index
        Dim Dpto = dgvDpto.Rows(row)
        Dim id = Dpto.Cells(0).Value
        idDpto = id
        nombreDpto = Dpto.Cells(1).Value
        ext = Dpto.Cells(2).Value
        email = Dpto.Cells(3).Value


    End Sub

    Private Sub modDpto_Click(sender As Object, e As EventArgs) Handles modDpto.Click
        FrmModDpto.idDpto = idDpto
        FrmModDpto.nombreDpto = nombreDpto
        FrmModDpto.ext = ext
        FrmModDpto.email = email
        FrmModDpto.Show()
    End Sub
    Private Sub btnEliminarDpto_Click(sender As Object, e As EventArgs) Handles btnEliminarDpto.Click
        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                Dpto.DeleteDpto(idDpto)
                llenarGrid()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
