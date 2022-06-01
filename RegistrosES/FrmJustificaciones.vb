Public Class FrmJustificaciones
    Public idEmp
    Dim just As New LMBADataSetTableAdapters.JustificacionTableAdapter
    Dim reg As New LMBADataSetTableAdapters.registroESTableAdapter
    Public ids As New ArrayList


    Private Sub TxtInicioGotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtInicio.GotFocus
        If TxtInicio.Text = "HH:MM:SS" Then
            TxtInicio.ForeColor = Color.Black
            TxtInicio.Text = ""
        End If
    End Sub
    Private Sub TxtInicioLostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtInicio.LostFocus
        If TxtInicio.Text = Nothing Then
            TxtInicio.ForeColor = Color.Gray
            TxtInicio.Text = "HH:MM:SS"
        End If
    End Sub
    Private Sub TxtFinGotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtFin.GotFocus
        If TxtFin.Text = "HH:MM:SS" Then
            TxtFin.ForeColor = Color.Black
            TxtFin.Text = ""
        End If
    End Sub
    Private Sub TxtFinLostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtFin.LostFocus
        If TxtFin.Text = Nothing Then
            TxtFin.ForeColor = Color.Gray
            TxtFin.Text = "HH:MM:SS"
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim guardar = Validar()
        If (guardar) Then
            GuardarJustificacion()
        End If
    End Sub

    Private Function Validar() As Boolean
        If (Not IsDate(TxtInicio.Text)) Then
            MsgBox("Hora de entrada inválida", MsgBoxStyle.Critical, "ERROR")
            TxtInicio.Focus()
            Return False
        End If

        If (Not IsDate(TxtFin.Text)) Then
            MsgBox("Hora de salida inválida", MsgBoxStyle.Critical, "ERROR")
            TxtFin.Focus()
            Return False
        End If

        If (String.IsNullOrEmpty(TxtDesc.Text)) Then
            MsgBox("La justificación no puede quedar vacía", MsgBoxStyle.Critical, "ERROR")
            TxtDesc.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub GuardarJustificacion()
        Dim fechaInicio = DtpInicio.Value.Date
        Dim horaInicio = TxtInicio.Text 'DateTime.Parse(TxtInicio.Text).ToString
        Dim fechaFin = DtpFin.Value.Date
        Dim horaFin = TxtFin.Text 'DateTime.Parse(TxtFin.Text).ToString
        Dim descripcion = TxtDesc.Text.Trim()
        Label1.Text = horaInicio.ToString()
        just.InsertQuery(1, descripcion, fechaInicio, fechaFin, horaInicio, horaFin)
        Dim idJustificacion As Integer = just.Last.Value
        Label1.Text = idJustificacion
        Console.WriteLine(idJustificacion)
        For Each idRegistro As Int32 In ids
            reg.Justificar(idJustificacion, idRegistro)
        Next

        MsgBox("Justificación guardada", MsgBoxStyle.Information, "Éxito")
        FrmRegistros.llenarDgv()
        Me.Close()
    End Sub

End Class