Imports System.Data.SqlClient

Class MainWindow
    Private Sub BtnAceptar_Click(sender As Object, e As RoutedEventArgs) Handles btnAceptar.Click
        Try
            'If ExisteOperario(Me.txtOperario.Text) = True Then

            'End If




        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Shared Function ExisteOperario(ByVal IDOperario As String) As Boolean
        Try
            'If String.IsNullOrEmpty(IDOperario) Then Return False

            'Dim connectionString As String = System.Configuration.ConfigurationManager.ConnectionStrings("Conexion").ConnectionString
            'Using conexion As New SqlConnection(connectionString)
            '    Using Comando As New SqlCommand("SELECT COUNT(*) FROM tbMaestroOperario WHERE IDOperario = @IDOperario", conexion)
            '        Comando.Parameters.AddWithValue("@IDOperario", IDOperario)
            '        conexion.Open()

            '        Dim resultado As Integer = CInt(Comando.ExecuteScalar())
            '        Return resultado > 0
            '    End Using
            'End Using


        Catch ex As SqlException
            GenerarExcepcion(ex.Message)
            Return False
        Catch ex As Exception
            GenerarExcepcion(ex.Message)
            Return False
        End Try
    End Function
End Class
