Public Class FrmAddPwd
    Dim RegUser As New LMBADataSetTableAdapters.tbl_userTableAdapter

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub



    Private Sub FrmAddPwd_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub

    Private Function Validar() As Boolean
        If (String.IsNullOrEmpty(TxtNombre.Text)) Then
            MsgBox("No puede quedar vacío el nombre", MsgBoxStyle.Critical, "ERROR")
            TxtNombre.Focus()
            Return False
        End If
        If (String.IsNullOrEmpty(TxtApellido.Text)) Then
            MsgBox("No puede quedar vacío el apellido", MsgBoxStyle.Critical, "ERROR")
            TxtApellido.Focus()
            Return False
        End If
        If (String.IsNullOrEmpty(TxtEmail.Text)) Then
            MsgBox("No puede quedar vacío el email", MsgBoxStyle.Critical, "ERROR")
            TxtEmail.Focus()
            Return False
        End If
        If (String.IsNullOrEmpty(TxtUser.Text)) Then
            MsgBox("No puede quedar vacío el user", MsgBoxStyle.Critical, "ERROR")
            TxtUser.Focus()
            Return False
        End If

        If (String.IsNullOrEmpty(TxtPwd.Text)) Then
            MsgBox("Debe añadir una contraseña", MsgBoxStyle.Critical, "ERROR")
            TxtPwd.Focus()
            Return False
        End If
        If (Not TxtPwd.Text.Equals(TxtPwd2.Text)) Then
            MsgBox("Las contraseñas deben coincidir", MsgBoxStyle.Critical, "ERROR")
            TxtPwd2.Focus()
            Return False
        End If
        Return True

        If (TxtPwd2.TextLength = 0) Then
            MsgBox("Debe confirmar la contraseña", MsgBoxStyle.Critical, "ERROR")
            TxtPwd.Focus()
            Return False
        End If
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (Not Validar()) Then
            Exit Sub
        End If

        RegUser.InsertUser(
            TxtUser.Text,
            TxtPwd.Text,
            TxtNombre.Text.Trim,
            TxtApellido.Text.Trim,
            TxtEmail.Text.Trim,
            If(ChkEstado.Checked, 1, 0))

        MsgBox("Empleado añadido", MsgBoxStyle.Information, "Éxito")
        Me.Close()
        FrmPwd.llenarGrid()
    End Sub

    Private Sub BtnPwd_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnPwd.MouseDown
        TxtPwd.PasswordChar = ""
    End Sub

    Private Sub BtnPwd_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnPwd.MouseUp
        TxtPwd.PasswordChar = "*"
    End Sub

    Private Sub BtnPw2_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnPw2.MouseDown
        TxtPwd2.PasswordChar = ""
    End Sub

    Private Sub BtnPw2_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnPw2.MouseUp
        TxtPwd2.PasswordChar = "*"
    End Sub
End Class