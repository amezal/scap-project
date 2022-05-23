Public Class FrmModHor

    Public idHor As Int32
    Public nombreHor As String
    Public horIn As TimeSpan
    Public horFin As TimeSpan

    Dim horario As New LMBADataSetTableAdapters.HorarioTableAdapter

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub FrmModHor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = nombreHor
        txtHorIn.Text = horIn.ToString
        txtHorFin.Text = horFin.ToString
    End Sub

    Private Sub cancelModHor_Click(sender As Object, e As EventArgs) Handles cancelModHor.Click
        Me.Close()
    End Sub

    Private Sub btnSaveModHor_Click(sender As Object, e As EventArgs) Handles btnSaveModHor.Click
        If (String.IsNullOrEmpty(txtName.Text)) Then
            MsgBox("El nombre no puede quedar vacìo", MsgBoxStyle.Critical, "ERROR")
            txtName.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(txtHorIn.Text)) Then
            MsgBox("La hora de entrada de debe quedar vacía", MsgBoxStyle.Critical, "ERROR")
            txtHorIn.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(txtHorFin.Text)) Then
            MsgBox("La hora de salida no puede quedar vacía", MsgBoxStyle.Critical, "ERROR")
            txtHorFin.Focus()
            Exit Sub
        End If
        Dim nombreHor As String = txtName.Text.Trim
        Dim horIn As String = txtHorIn.Text.Trim
        Dim horFin As String = txtHorIn.Text.Trim
        horario.UpdateHorario(nombreHor, horIn, horFin, idHor)
        'car.ActualizarRegistro(nombreCarg, des, estado, idDepto, idCar)
        FrmHorarios.llenarGrid()
    End Sub
End Class