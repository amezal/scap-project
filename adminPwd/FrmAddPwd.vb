Public Class FrmAddPwd
    Dim RegUser As New LMBADataSetTableAdapters.tbl_userTableAdapter

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim userame As String = cbxUsername.SelectedValue
            Dim newPwd As String = txtPwd.Text.Trim

            RegUser.InsertUser(newPwd)
            FrmPwd.llenarGrid()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub FrmAddPwd_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbxUsername.DataSource = RegUser.GetData
        cbxUsername.DisplayMember = "username"

    End Sub
End Class