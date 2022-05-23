Public Class FrmModPwd

    Dim regUser As New LMBADataSetTableAdapters.tbl_userTableAdapter
    Public idUser As Integer
    Public username As String
    Public pwd As String

    Private Sub btnCancelMod_Click(sender As Object, e As EventArgs) Handles btnCancelMod.Click
        Me.Close()
    End Sub

    Private Sub FrmModPwd_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtPwd.Text = pwd
        txtUser.Text = username

    End Sub

    Private Sub btnSaveMod_Click(sender As Object, e As EventArgs) Handles btnSaveMod.Click
        If (String.IsNullOrEmpty(txtPwd.Text)) Then
            MsgBox("La contraseña no puede quedar vacía", MsgBoxStyle.Critical, "ERROR")
            txtPwd.Focus()
            Exit Sub
        End If

        Dim pwd As String = txtPwd.Text.Trim
        regUser.UpdateUser(pwd, idUser)
        FrmPwd.llenarGrid()
    End Sub
End Class