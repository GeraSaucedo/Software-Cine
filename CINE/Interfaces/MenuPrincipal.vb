Public Class MenuPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_datos.Show()

    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ver si detecta cambios'
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frm_productos.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_proveedores.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frm_ventas.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm_empleados As New Frm_datos
        frm_empleados.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frm_devoluciones.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class