﻿'En esta pantalla no se podra registrar usuarios, solo el admin podra registrar usuarios dentro de su interfaz'
Public Class Login
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        MenuPrincipal.Show()
        Me.Close()



    End Sub
End Class
