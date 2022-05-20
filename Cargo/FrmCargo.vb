Public Class FrmAdminPwd
    Private Sub FrmCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnAddCar_Click(sender As Object, e As EventArgs) Handles BtnAddCar.Click
        FrmAddCargo.MdiParent = Me.MdiParent
        FrmAddCargo.Show()

    End Sub

    Private Sub BtnModCar_Click(sender As Object, e As EventArgs) Handles BtnModCar.Click
        FrmModCargo.Show()

    End Sub
End Class
