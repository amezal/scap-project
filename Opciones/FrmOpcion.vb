Public Class FrmOpcion

    Dim opc As New LMBADataSetTableAdapters.tbl_opcionTableAdapter
    Dim idOpc As Integer
    Dim opci As String

    Private Sub FrmOpcion_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarGrid()
        BtnDeleteOpc.Enabled = False
        BtnModOpc.Enabled = False
    End Sub
    Private Sub BtnAddOpc_Click(sender As Object, e As EventArgs) Handles BtnAddOpc.Click
        ' FrmAddOpcion.MdiParent = Me.MdiParent'
        FrmAddOpcion.Show()
    End Sub

    Sub llenarGrid()
        DgvOpcion.DataSource = opc.GetData
        DgvOpcion.Refresh()
        DgvOpcion.Columns(0).Visible = False
        GbOpcion.Text = "Mostrando registros: " & DgvOpcion.Rows.Count.ToString
    End Sub
    Private Sub BtnModOpc_Click(sender As Object, e As EventArgs) Handles BtnModOpc.Click
        FrmModOpcion.idOpcion = idOpc
        FrmModOpcion.nombreOpcion = opci
        FrmModOpcion.Show()

    End Sub

    Private Sub BtnDeleteOpc_Click(sender As Object, e As EventArgs) Handles BtnDeleteOpc.Click
        Try
            Dim resp As VariantType
            resp = (MsgBox("¿Desea eliminar esta opción?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                opc.EliminarOpcion(idOpc)
                llenarGrid()
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub BtnSearchOpc_Click(sender As Object, e As EventArgs) Handles BtnSearchOpc.Click
        Try
            Dim dato As String = TbSearchOpc.Text & "%"
            DgvOpcion.DataSource = opc.BuscarOpcion(dato)
            DgvOpcion.Refresh()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DgvOpcion_DoubleClick(sender As Object, e As EventArgs) Handles DgvOpcion.DoubleClick
        Dim opcion As String
        BtnModOpc.Enabled = True
        BtnDeleteOpc.Enabled = True
        Dim row = DgvOpcion.CurrentRow.Index
        Dim opc = DgvOpcion.Rows(row)
        Dim id = opc.Cells(0).Value
        idOpc = id
        opcion = opc.Cells(1).Value
    End Sub
End Class