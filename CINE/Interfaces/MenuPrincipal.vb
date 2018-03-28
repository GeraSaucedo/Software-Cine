Public Class MenuPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Frm_datos.Show()

    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ver si detecta cambios'

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        frm_productos.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        frm_proveedores.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        frm_ventas.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Dim frm_empleados As New Frm_datos
        frm_empleados.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnDevoluciones.Click
        frm_devoluciones.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnFunciones.Click
        frm_funciones.Show()
    End Sub

    Private Sub btnPeliculas_Click(sender As Object, e As EventArgs) Handles btnPeliculas.Click
        frm_peliculas.Show()
    End Sub

    Private Sub btnEstadisticas_Click(sender As Object, e As EventArgs) Handles btnEstadisticas.Click

    End Sub

    Private Sub btnBoletos_Click(sender As Object, e As EventArgs) Handles btnBoletos.Click
        frm_ventaBoletos.Show()
    End Sub
End Class