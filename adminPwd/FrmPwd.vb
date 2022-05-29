Public Class FrmPwd
    Dim regUser As New LMBADataSetTableAdapters.tbl_userTableAdapter
    Dim idUser As Int32


    Sub llenarGrid()

        dgvUser.DataSource = regUser.GetData
        dgvUser.Columns("id_user").Visible = False
        dgvUser.Columns(0).Visible = False
        gbUser.Text = "Mostrando usuarios: " & dgvUser.Rows.Count.ToString
        dgvUser.Refresh()


    End Sub

    Private Sub FrmPwd_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'LMBADataSet1.tbl_user' Puede moverla o quitarla según sea necesario.
        Me.Tbl_userTableAdapter.Fill(Me.LMBADataSet1.tbl_user)
        llenarGrid()
        btnDelete.Enabled = False
        btnMod.Enabled = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim data As String = txtSearch.Text & "%"
            dgvUser.DataSource = regUser.buscarPorUser(data)
            dgvUser.Refresh()

            gbUser.Text = "Usuarios encontrados: " & dgvUser.Rows.Count.ToString

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FrmAddPwd.Show()
    End Sub

    Private Sub dgvUser_DoubleClick(sender As Object, e As EventArgs) Handles dgvUser.DoubleClick
        btnMod.Enabled = True
        btnDelete.Enabled = True
        Dim row = dgvUser.CurrentRow.Index
        Dim user = dgvUser.Rows(row)
        Dim id = user.Cells(0).Value
        idUser = id

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim resp As VariantType
            resp = (MsgBox("Desea eliminar el registro?", vbQuestion + vbYesNo, "Eliminar"))
            If (resp = vbYes) Then
                regUser.DeleteUser(idUser)
                llenarGrid()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        FrmModPwd.idUser = idUser
        FrmModPwd.Show()
    End Sub


End Class