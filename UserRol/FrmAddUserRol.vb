Public Class FrmAddUserRol
    Dim us As New LMBADataSetTableAdapters.tbl_userTableAdapter
    Dim rol As New LMBADataSetTableAdapters.tbl_rolTableAdapter
    Dim regUR As New LMBADataSetTableAdapters.tbl_userRolTableAdapter

    Sub llenarUser()
        cbxUser.DataSource = us.GetData
        cbxUser.DisplayMember = "username"
        cbxUser.ValueMember = "id_user"
    End Sub

    Sub llenarRol()
        cbxRol.DataSource = rol.GetData
        cbxRol.DisplayMember = "rol"
        cbxRol.ValueMember = "id_rol"
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            Dim idRol As Integer = CInt(cbxRol.SelectedValue)
            Dim idUser As Integer = CInt(cbxUser.SelectedValue)
            regUR.InsertUserRol(idRol, idUser)
            MsgBox("UserRol añadido", MsgBoxStyle.Information, "Éxito")
            Me.Close()
            FrmUserRol.llenarGrid()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmAddUserRol_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarRol()
        llenarUser()
    End Sub
End Class