Public Class FrmModDpto

    Public idDpto As Int32
    Public nombreDpto As String
    Public email As String
    Public ext As Int32
    Public estado As Boolean

    Dim Dpto As New LMBADataSetTableAdapters.DepartamentoTableAdapter

    Private Sub FrmModDpto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbDpto.Text = nombreDpto
        tbEmail.Text = email
        tbExt.Text = ext.ToString

    End Sub

    Private Sub cancelModDpto_Click(sender As Object, e As EventArgs) Handles cancelModDpto.Click
        Me.Close()
    End Sub

    Private Sub btnSaveModDpto_Click(sender As Object, e As EventArgs) Handles btnSaveModDpto.Click
        If (String.IsNullOrEmpty(tbDpto.Text)) Then
            MsgBox("Departamento no puede quedar vacío", MsgBoxStyle.Critical, "ERROR")
            tbDpto.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(tbEmail.Text)) Then
            MsgBox("Email no puede quedar vacío", MsgBoxStyle.Critical, "ERROR")
            tbEmail.Focus()
            Exit Sub
        End If
        If (String.IsNullOrEmpty(tbExt.Text)) Then
            MsgBox("La extencion no puede quedar vacío", MsgBoxStyle.Critical, "ERROR")
            tbExt.Focus()
            Exit Sub
        End If
        Dim nombreDpto As String = tbDpto.Text.Trim
        Dim email As String = tbEmail.Text.Trim
        Dim ext As Int32 = (tbExt.Text.Trim).ToString
        Dpto.UpdateDepartamento(nombreDpto, ext, email, estado, idDpto)
        MsgBox("Departamento modificado", MsgBoxStyle.Information, "Éxito")
        Me.Close()
        FrmDpto.llenarGrid()
    End Sub

End Class