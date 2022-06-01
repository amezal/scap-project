Public Class FrmAddHor

    Dim hor As New LMBADataSetTableAdapters.HorarioTableAdapter

    Private Sub saveAdd_Click(sender As Object, e As EventArgs) Handles saveAdd.Click
        Dim nombreHor As String = txtNombre.Text.Trim
        Dim horIn = TimeSpan.Parse(txtHorIn.Text.Trim).ToString
        Dim horFin = TimeSpan.Parse(txtHorIn.Text.Trim).ToString
        Dim horAl = TimeSpan.Parse(txtAlmuerzo.Text.Trim).ToString
        hor.InsertHorario(nombreHor, horIn, horFin, horAl)
        MsgBox("Horario añadido", MsgBoxStyle.Information, "Éxito")
        Me.Close()
        FrmHorarios.llenarGrid()
        txtNombre.Text = ""
        txtHorFin.Clear()
        txtHorIn.Clear()
        txtAlmuerzo.Clear()
        txtNombre.Focus()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtHorIn_TextChanged(sender As Object, e As EventArgs) Handles txtHorIn.TextChanged

    End Sub

    Private Sub txtHorFin_TextChanged(sender As Object, e As EventArgs) Handles txtHorFin.TextChanged

    End Sub

    Private Sub txtAlmuerzo_TextChanged(sender As Object, e As EventArgs) Handles txtAlmuerzo.TextChanged

    End Sub
End Class