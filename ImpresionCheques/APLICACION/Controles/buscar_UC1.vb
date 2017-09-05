Public Class Buscar_UC1

    Public Event Buscando(sender As Object, e As String)

    Public Overrides Property Text As String
        Get
            If TextBox1.Text = "Buscar..." Then
                Return ""
            Else
                Return TextBox1.Text
            End If
        End Get
        Set(value As String)
            TextBox1.Text = value
        End Set
    End Property

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        Try
            If Panel1.Visible Then
                animation_horizontal.Hide(Panel1)
            Else
                animation_horizontal.Show(Panel1)
            End If
            TextBox1.Text = "Buscar..."
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            animation_horizontal.Hide(Panel1)
            TextBox1.Text = "Buscar..."
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles TextBox1.MouseEnter
        Try
            If TextBox1.Text = "Buscar..." Then
                TextBox1.Text = ""
            End If
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles TextBox1.MouseLeave
        Try
            If TextBox1.Text = "" Then
                TextBox1.Text = "Buscar..."
            End If
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            RaiseEvent Buscando(sender, sender.text)
        Catch ex As Exception
            Report_exeption(ex)
        End Try
    End Sub

End Class
