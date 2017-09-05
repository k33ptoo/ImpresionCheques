Public Class Main

    Private Sub BtnMenu_Cerrar_Click(sender As Object, e As EventArgs) Handles BtnMenu_Cerrar.Click
        Try
            animation_horizontal.HideSync(Panel_menu)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnMenu_Abrir_Click(sender As Object, e As EventArgs) Handles BtnMenu_Abrir.Click
        Try
            animation_horizontal.ShowSync(Panel_menu)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub Btn_Prueba_Impresion_Click(sender As Object, e As EventArgs) Handles Btn_Prueba_Impresion.Click
        Try
            _print(True)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Try
            Application.Exit()
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Inicializar_aplicacion()
            Btn_Cheques_Click(Nothing, Nothing)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub Btn_Cheques_Click(sender As Object, e As EventArgs) Handles Btn_Cheques.Click
        Try
            Panel_Main.Controls.Clear()
            Panel_Main.Controls.Add(New Cheques_Lista_UC With {.Dock = DockStyle.Fill})
            animation_horizontal.HideSync(Panel_menu)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub Btn_Proveedores_Click(sender As Object, e As EventArgs) Handles Btn_Proveedores.Click

    End Sub

    Private Sub Btn_Bancos_Click(sender As Object, e As EventArgs) Handles Btn_Bancos.Click
        Try
            Panel_Main.Controls.Clear()
            Panel_Main.Controls.Add(New Bancos_Lista_UC With {.Dock = DockStyle.Fill})
            animation_horizontal.HideSync(Panel_menu)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub Btn_Cuentas_Click(sender As Object, e As EventArgs) Handles Btn_Cuentas.Click
        Try
            Panel_Main.Controls.Clear()
            Panel_Main.Controls.Add(New Cuentas_Lista_UC With {.Dock = DockStyle.Fill})
            animation_horizontal.HideSync(Panel_menu)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

End Class
