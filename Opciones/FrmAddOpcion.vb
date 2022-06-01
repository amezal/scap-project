Public Class FrmAddOpcion
    Dim opc As New LMBADataSetTableAdapters.tbl_opcionTableAdapter
    Dim estado As Boolean


    Private Function Validar() As Boolean
        If (String.IsNullOrEmpty(tbOpc.Text)) Then
            MsgBox("El campo no puede quedar vacío", MsgBoxStyle.Critical, "ERROR")
            tbOpc.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnSaveOpc_Click(sender As Object, e As EventArgs) Handles btnSaveOpc.Click
        If (Not Validar()) Then
            Exit Sub
        End If
        Try
            Dim newOpc As String = tbOpc.Text.Trim
            opc.AgregarOpcion(newOpc, estado)
            FrmOpcion.llenarGrid()
            MessageBox.Show("Guardado con éxito", "Opción registrada", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelarOpc_Click(sender As Object, e As EventArgs) Handles btnCancelarOpc.Click
        Me.Hide()
    End Sub
End Class