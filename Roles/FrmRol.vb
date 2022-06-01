Public Class FrmRol
    Dim query As String = "%"
    Dim rolActual As Integer
    Dim roldgv As New LMBADataSetTableAdapters.tbl_rolDgvTableAdapter
    Dim DsRol As New LMBADataSetTableAdapters.tbl_rolTableAdapter

    Private Sub FrmRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarRoles()
        BtnMod.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Sub ListarRoles()
        DgvRoles.DataSource = roldgv.GetData(query)
        DgvRoles.Columns(0).Visible = False
        DgvRoles.Columns(1).HeaderText = "Rol"
        DgvRoles.Columns(2).HeaderText = "Opciones"
        DgvRoles.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Public Sub Actualizar()
        DgvRoles.DataSource = roldgv.GetData(query)
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        query = TxtBuscar.Text + "%"
        Actualizar()
    End Sub

    Private Sub DgvRoles_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRoles.CellDoubleClick
        Dim row = DgvRoles.CurrentRow.Index
        Dim rol = DgvRoles.Rows(row)
        Dim id = rol.Cells(0).Value
        rolActual = id
        BtnMod.Enabled = True
        BtnEliminar.Enabled = True
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click
        FrmModRol.idRol = rolActual
        FrmModRol.Show()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Try
            Dim delete = MsgBox("¿Seguro que desea eliminar este rol?", MsgBoxStyle.YesNo, "Eliminar")

            If (delete = delete.Yes) Then
                DsRol.Eliminar(rolActual)
                MsgBox("Rol eliminado con éxito", MsgBoxStyle.Information, "Eliminar")
                Me.ListarRoles()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Eliminar")
        End Try

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

    End Sub
End Class