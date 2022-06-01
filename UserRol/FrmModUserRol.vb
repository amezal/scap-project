Public Class FrmModUserRol

    Public idUserRol As Integer
    Public username As String
    Public rol As String

    Dim us As New LMBADataSetTableAdapters.tbl_userTableAdapter
    Dim trol As New LMBADataSetTableAdapters.tbl_rolTableAdapter

    Dim regUR As New LMBADataSetTableAdapters.tbl_userRolTableAdapter

    Private Sub FrmModUserRol_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarUser()
        llenarRol()
    End Sub

    Sub llenarUser()
        cbxUser.DataSource = us.GetData
        cbxUser.DisplayMember = "username"
        cbxUser.ValueMember = "id_user"

        cbxUser.SelectedValue = us.GetData().Select("username ='" & username & "'")(0)("id_user")
        cbxUser.Refresh()

    End Sub

    Sub llenarRol()
        cbxRol.DataSource = trol.GetData
        cbxRol.DisplayMember = "Rol"
        cbxRol.ValueMember = "id_rol"
        cbxRol.SelectedValue = trol.GetData().Select("Rol ='" & rol & "'")(0)("id_rol")
        cbxRol.Refresh()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim idrol As Integer = CInt(cbxRol.SelectedValue)
        Dim idUser As Integer = CInt(cbxUser.SelectedValue)
        regUR.UpdateUserRol(idrol, idUser, idUserRol)
        MsgBox("UserRol modificado", MsgBoxStyle.Information, "Éxito")
        Me.Close()
        FrmCargo.llenarGrid()
    End Sub
End Class