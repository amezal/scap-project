Public Class FrmHorarios

    Dim horario As New LMBADataSetTableAdapters.HorarioTableAdapter
    Dim idHor As New Int32
    Dim nombreHor As String
    Dim horIn As TimeSpan
    Dim horFin As TimeSpan
    Dim horAl As TimeSpan



    Sub llenarGrid()
        dgvHorario.DataSource = horario.GetData
        dgvHorario.Refresh()
        dgvHorario.Columns(0).Visible = False
        gbHorario.Text = "Mostrando horarios: " & dgvHorario.Rows.Count.ToString
    End Sub

    Private Sub FrmHorarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'LMBADataSet.Horario' Puede moverla o quitarla según sea necesario.
        Me.HorarioTableAdapter.Fill(Me.LMBADataSet.Horario)
        llenarGrid()
        modHor.Enabled = False
        btnEliminarHor.Enabled = False

    End Sub

    Private Sub addHor_Click(sender As Object, e As EventArgs) Handles addHor.Click
        FrmAddHor.Show()
    End Sub

    Private Sub searchHor_Click(sender As Object, e As EventArgs) Handles searchHor.Click
        Try
            Dim data As String = tbBuscar.Text & "%"
            dgvHorario.DataSource = horario.BuscarPorNombre(data)
            dgvHorario.Refresh()

            gbHorario.Text = "Horarios encontrados: " & dgvHorario.Rows.Count.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvHorario_DoubleClick(sender As Object, e As EventArgs) Handles dgvHorario.DoubleClick
        modHor.Enabled = True
        btnEliminarHor.Enabled = True
        Dim row As Integer = dgvHorario.CurrentRow.Index
        Dim hor = dgvHorario.Rows(row)
        Dim id = hor.Cells(0).Value
        idHor = id
        nombreHor = hor.Cells(1).Value
        horIn = hor.Cells(2).Value
        horFin = hor.Cells(3).Value
        horAl = hor.Cells(4).Value

    End Sub

    Private Sub modHor_Click(sender As Object, e As EventArgs) Handles modHor.Click
        FrmModHor.idHor = idHor
        FrmModHor.nombreHor = nombreHor
        FrmModHor.horIn = horIn
        FrmModHor.horFin = horFin
        FrmModHor.horAl = horAl
        FrmModHor.Show()
    End Sub

    Private Sub btnEliminarHor_Click(sender As Object, e As EventArgs) Handles btnEliminarHor.Click
        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                horario.DeleteHorario(idHor)
                llenarGrid()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class