Public Class FrmAddRol
    Dim Dsrol As New LMBADataSetTableAdapters.tbl_rolTableAdapter

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim guardado As Boolean = False

        Try
            guardado = Dsrol.Nuevo(txtRol.Text) > 0

            If (guardado) Then
                MsgBox("Rol agregado correctamente", MsgBoxStyle.MsgBoxRight, "Éxito")
                FrmRol.Actualizar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class