Public Class FrmAddHor

    Dim hor As New LMBADataSetTableAdapters.HorarioTableAdapter

    Private Sub saveAdd_Click(sender As Object, e As EventArgs) Handles saveAdd.Click
        Dim nombre As String = txtNombre.Text.Trim
        Dim horIn As Date = txtHorIn.Text.Trim
        Dim horFin As Date = txtHorFin.Text.Trim
        hor.InsertHorario(nombre, horIn, horFin)
        FrmHorarios.llenarGrid()
        txtNombre.Text = ""
        txtHorFin.Clear()
        txtHorIn.Clear()
        txtNombre.Focus()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class