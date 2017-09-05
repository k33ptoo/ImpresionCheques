Public Class Cuenta_detalle

    Public Event Guardar(sender As Object, e As cuenta)
    Public Event Cancelar(sender As Object, e As cuenta)

    Dim _actual As New cuenta
    Public Property Actual As cuenta
        Get
            Return _actual
        End Get
        Set(value As cuenta)
            _actual = value

            Txt_Nombre.Text = _actual.numero
            Txt_Observaciones.Text = _actual.observaciones
            Cmb_Banco.SelectedValue = _actual.id_banco

        End Set
    End Property

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            _actual.numero = Txt_Nombre.Text
            _actual.observaciones = Txt_Observaciones.Text
            _actual.id_banco = Cmb_Banco.SelectedValue

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

    Private Sub Cuenta_detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If DesignMode = False Then
                Cargar_combo()
            End If
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Sub Cargar_combo()
        Try
            Cmb_Banco.DataSource = _lista_bancos
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
