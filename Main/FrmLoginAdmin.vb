Public Class FrmLoginAdmin
    Dim users As New LMBADataSetTableAdapters.tbl_userTableAdapter

    Private Sub FrmLoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim usr = users.GetData()
        cbxUser.DataSource = usr
        cbxUser.DisplayMember = "username"
        cbxUser.ValueMember = "id_user"
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim valido As Boolean
        Try
            valido = users.GetData.Select($"username='{cbxUser.Text}' AND pwd='{txtPIN.Text}'").Count > 0
            If (valido) Then
                MsgBox("Bienvenido!", MsgBoxStyle.MsgBoxHelp, "Éxito")
                FrmMenuAdmin.Show()
                Me.Hide()
                txtPIN.Text = ""
            Else
                MsgBox("Inicio de sesión incorrecto", MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class