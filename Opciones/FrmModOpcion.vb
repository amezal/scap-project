Public Class FrmModOpcion
    Dim opc As New LMBADataSetTableAdapters.tbl_opcionTableAdapter
    Public idOpcion As Integer
    Public nombreOpcion As String
    Dim estado As Boolean

    Private Sub FrmModOpcion_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbOpc.Text = nombreOpcion
    End Sub

    Private Sub btnCancelOpc_Click(sender As Object, e As EventArgs) Handles btnCancelOpc.Click
        Me.Hide()
    End Sub

    Private Sub btnSaveOpc_Click(sender As Object, e As EventArgs) Handles btnSaveOpc.Click
        If (String.IsNullOrEmpty(tbOpc.Text)) Then
            MsgBox("Este campo no puede quedar vacío", MsgBoxStyle.Critical, "ERROR")
            tbOpc.Focus()
            Exit Sub
        End If
        Try
            Dim nombreOpc As String = tbOpc.Text.Trim
            opc.ModificarOpcion(nombreOpc, estado, idOpcion)
            FrmOpcion.llenarGrid()
            MessageBox.Show("Guardado con éxito", "Opción registrada", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
End Class