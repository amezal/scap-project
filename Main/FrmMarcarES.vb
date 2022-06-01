Public Class FrmMarcarES

    Public idEmp As Integer
    Public registroExiste As Boolean
    Dim emp As New LMBADataSetTableAdapters.EmpleadoTableAdapter
    Dim reg As New LMBADataSetTableAdapters.registroESTableAdapter
    Dim empReg As New LMBADataSetTableAdapters.empleadoRegistroTableAdapter

    Private Sub FrmMarcarES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hoy = DateTime.Now
        hoy.TimeOfDay.ToString.Split("."c)(0).ToString()
        Timer1.Interval = 1000
        Timer1.Start()

        registroExiste = reg.Existe(idEmp, hoy.Date).Rows.Count > 0

        If (registroExiste) Then
            btnEntrada.Enabled = False
            btnSalida.Enabled = True
        Else
            btnEntrada.Enabled = True
            btnSalida.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        reloj.Text = DateTime.Now.TimeOfDay.ToString.Split("."c)(0).ToString()
    End Sub

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click

        Dim guardado As Boolean = False
        Dim idReg As Integer
        Try
            guardado = reg.Nuevo(DateTime.Now.Date, DateTime.Now) > 0
            idReg = reg.Last()
            guardado = empReg.Nuevo(idReg, idEmp) > 0

            If (guardado) Then
                MsgBox("Registro guardado correctamente", MsgBoxStyle.MsgBoxRight, "Éxito")
                btnEntrada.Enabled = False
                btnSalida.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnSalida_Click(sender As Object, e As EventArgs) Handles btnSalida.Click
        Dim guardado As Boolean = False
        Try
            Dim idReg = reg.Last()
            guardado = reg.MarcarSalida(DateTime.Now, idReg) > 0

            If (guardado) Then
                MsgBox("Registro guardado correctamente", MsgBoxStyle.MsgBoxRight, "Éxito")
                btnSalida.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        FrmLoginEmpleado.Show()
        Me.Hide()
    End Sub
End Class