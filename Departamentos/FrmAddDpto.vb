Public Class FrmAddDpto

    Dim dp As New LMBADataSetTableAdapters.DepartamentoTableAdapter
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            Dim newDp As String = tbDepto.Text.Trim
            Dim email As String = tbEmail.Text.Trim
            Dim ext As Int32 = tbExt.Text.Trim
            dp.InsertarDpto(newDp, ext, email)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class