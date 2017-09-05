Public Class Cheque_detalle

    Public Event Guardar(sender As Object, e As cheque)
    Public Event Cancelar(sender As Object, e As cheque)

    Dim _actual As New cheque
    Public Property Actual As cheque
        Get
            Return _actual
        End Get
        Set(value As cheque)
            _actual = value

            Txt_Numero.Text = _actual.Numero
            Txt_Importe.Text = _actual.Importe
            TxtProveedor.Text = _actual.Id_proveedor

        End Set
    End Property

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            RaiseEvent Guardar(sender, _actual)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            RaiseEvent Cancelar(sender, Nothing)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub Cheque_detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cargar_combo()
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Sub Cargar_combo()
        Try

            Dim query =
                From c In _lista_cuentas
                Join b In _lista_bancos On c.id_banco Equals b.id_banco
                Select New With {.id_cuenta = c.id_cuenta, .numero = c.numero & " (" & b.nombre & ")"}


            Cmb_Cuenta.DataSource = query.ToList
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
