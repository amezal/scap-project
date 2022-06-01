Public Class FrmConfig
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmPwd.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmHorarios.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FrmCargo.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FrmDpto.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmRol.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrmOpcion.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmMenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub userRol_Click(sender As Object, e As EventArgs) Handles userRol.Click
        FrmUserRol.Show()
    End Sub
End Class