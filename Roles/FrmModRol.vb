Public Class FrmModRol
    Public idRol As Integer
    Dim rol
    Dim DsRol As New LMBADataSetTableAdapters.tbl_rolTableAdapter
    Dim DsOpcion As New LMBADataSetTableAdapters.tbl_opcionTableAdapter
    Dim DsRolOpcion As New LMBADataSetTableAdapters.tbl_rolOpcionTableAdapter

    Private Sub FrmModRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rol = DsRol.GetData.Select("id_rol='" & idRol & "'")(0)
        LlenarCampos()

    End Sub

    Private Sub LlenarCampos()
        txtID.Text = idRol
        txtRol.Text = rol("rol").ToString()

        cbxOpcion.DataSource = DsOpcion.GetData()
        cbxOpcion.DisplayMember = "Opcion"
        cbxOpcion.ValueMember = "id_opcion"

        DgvOpcion.DataSource = DsRolOpcion.ListarRolOpcion(idRol)
        DgvOpcion.Columns(0).Visible = False
        DgvOpcion.Columns(1).Visible = False
        DgvOpcion.Columns(2).Visible = False
        DgvOpcion.Columns("Opcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim existe As Boolean = False
        Dim id As Int32 = Convert.ToInt32(cbxOpcion.SelectedValue)
        Dim nombre As String = cbxOpcion.Text
        Dim dt = DsRolOpcion.ListarRolOpcion(idRol)
        Dim row As DataRow = dt.NewRow()
        row.Item(1) = id
        row.Item(2) = idRol
        row.Item(3) = nombre
        dt.Addtbl_rolOpcionRow(row)
        DgvOpcion.DataSource = dt
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim guardado As Boolean = False

        Try
            guardado = DsRol.ModificarRol(txtRol.Text, idRol) > 0

            For i = 0 To DgvOpcion.Rows.Count - 1 Step 1
                Dim existe As Boolean = DsRolOpcion.Existe(idRol, DgvOpcion.Item(1, i).Value).Rows.Count > 0
                If (Not existe) Then
                    DsRolOpcion.Nuevo(DgvOpcion.Item(1, i).Value, idRol)
                End If
            Next

            If (guardado) Then
                MsgBox("Rol modificado correctamente", MsgBoxStyle.MsgBoxRight, "Éxito")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idOpcion As Int32 = cbxOpcion.SelectedValue

        For i = 0 To DgvOpcion.Rows.Count - 1 Step 1
            Dim id = DgvOpcion.Item(1, i).Value
            If (id.Equals(idOpcion)) Then
                DgvOpcion.Rows.RemoveAt(i)
            End If
        Next
    End Sub
End Class