Public Class FrmUserRol

    Dim regUserRol As New LMBADataSetTableAdapters.tbl_userRolTableAdapter
    Dim idUserRol As Int32
    Dim username As String
    Dim rol As String



    Sub llenarGrid()
        DgvUserRol.DataSource = regUserRol.GetData
        DgvUserRol.Refresh()
        DgvUserRol.Columns(0).Visible = False
        gbUserRol.Text = "Mostrando registros: " & DgvUserRol.Rows.Count.ToString
    End Sub

    Private Sub FrmUserRol_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'LMBADataSet.tbl_userRol' Puede moverla o quitarla según sea necesario.
        Me.Tbl_userRolTableAdapter.Fill(Me.LMBADataSet.tbl_userRol)
        llenarGrid()
        BtnModUR.Enabled = False
        BtnDeleteUR.Enabled = False
    End Sub



    Private Sub BtnDeleteUR_Click(sender As Object, e As EventArgs) Handles BtnDeleteUR.Click

        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                regUserRol.DeleteUserRol(idUserRol)
                llenarGrid()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub DgvUserRol_DoubleClick(sender As Object, e As EventArgs) Handles DgvUserRol.DoubleClick
        BtnModUR.Enabled = True
        BtnDeleteUR.Enabled = True
        Dim row = DgvUserRol.CurrentRow.Index
        Dim userRol = DgvUserRol.Rows(row)
        Dim id = userRol.Cells(0).Value
        idUserRol = id
        rol = userRol.Cells(1).Value
        username = userRol.Cells(2).Value
    End Sub

    Private Sub BtnAddUR_Click(sender As Object, e As EventArgs) Handles BtnAddUR.Click
        FrmAddUserRol.Show()
    End Sub

    Private Sub BtnModUR_Click(sender As Object, e As EventArgs) Handles BtnModUR.Click
        FrmModUserRol.idUserRol = idUserRol
        FrmModUserRol.rol = rol
        FrmModUserRol.username = username
        FrmModUserRol.Show()
    End Sub
End Class