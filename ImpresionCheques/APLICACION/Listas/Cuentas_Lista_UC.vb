Public Class Cuentas_Lista_UC

    Private Sub Lista_Cheques_UC_Load(sender As Object, e As EventArgs) Handles Me.Load, BtnActualizar.Click
        Try
            Cargar_datos()
            Buscar()
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Try
            _Cuenta_Detalle.Actual = New cuenta With {.id_cuenta = -1}
            animation_vertical.ShowSync(_Cuenta_Detalle)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Sub Ubicar_detalle()
        Try
            _Cuenta_Detalle.Left = (Me.Width / 2) - (_Cuenta_Detalle.Width / 2)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub Lista_Cheques_UC_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            Ubicar_detalle()
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub _Cheque_detalle_Cancelar(sender As Object, e As cuenta) Handles _Cuenta_Detalle.Cancelar
        Try
            animation_vertical.HideSync(_Cuenta_Detalle)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Sub Buscar(Optional texto As String = "")
        Try
            Dim query =
                From c In _lista_cuentas
                Join b In _lista_bancos On b.id_banco Equals c.id_banco
                Where c.numero.Trim.ToLower.Contains(texto.Trim.ToLower)
                Order By c.numero Ascending
                Select New With {.id_cuenta = c.id_cuenta, .numero = c.numero, .banco = b.nombre}

            With Dgv_Entidades
                .DataSource = query.ToList
                If .RowCount > 0 Then
                    .Columns("id_cuenta").Visible = False
                End If
                .ClearSelection()
            End With

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub Cargar_datos()
        Try
            _lista_cuentas = _cuentaAcceso.recuperar
            Buscar()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub _Cheque_detalle_Guardar(sender As Object, e As cuenta) Handles _Cuenta_Detalle.Guardar
        Try
            If Validar(e) Then
                If e.id_cuenta <> -1 Then
                    _cuentaAcceso.actualizar(e)
                Else
                    _cuentaAcceso.insertar(e)
                End If
                Cargar_datos()
                animation_vertical.HideSync(_Cuenta_Detalle)
            End If
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Function Validar(e As cuenta) As Boolean
        Try
            If e.numero.Trim = "" Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click, Dgv_Entidades.CellDoubleClick
        Try
            If Dgv_Entidades.SelectedRows.Count = 1 Then
                _Cuenta_Detalle.Actual = _lista_cuentas.Find(Function(x) x.id_cuenta = Dgv_Entidades.SelectedRows(0).Cells("id_cuenta").Value)
                animation_vertical.ShowSync(_Cuenta_Detalle)
            End If
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If Dgv_Entidades.SelectedRows.Count = 1 Then


                pregunta_Frm.buttonColor = pregunta_Frm.colorOK.ROJO
                pregunta_Frm.Mensaje = "¿Eliminar la cuenta actual?"
                pregunta_Frm.ubicacion = Get_Control_Location(BtnEliminar, -175, 70)

                If pregunta_Frm.ShowDialog() = DialogResult.OK Then
                    _cuentaAcceso.eliminacion_fisica(Dgv_Entidades.SelectedRows(0).Cells("id_cuenta").Value)
                    Cargar_datos()
                End If

            End If
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub Buscar_UC11_Buscando(sender As Object, e As String) Handles Buscar_UC11.Buscando
        Try
            Buscar(Buscar_UC11.Text)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

End Class
