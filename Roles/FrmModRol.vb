Public Class FrmModRol
    Public idRol As Integer
    Dim rol
    Dim DsRol As New LMBADataSetTableAdapters.tbl_rolTableAdapter

    Private Sub FrmModRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rol = DsRol.GetData.Select("id_rol='" & idRol & "'")(0)
        LlenarCampos()

    End Sub

    Private Sub LlenarCampos()
        txtID.Text = idRol
        txtRol.Text = rol("rol").ToString()

    End Sub
End Class