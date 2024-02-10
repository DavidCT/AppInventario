Imports System.Data.SqlClient

Class MainWindow
    Private Sub BtnAceptar_Click(sender As Object, e As RoutedEventArgs) Handles btnAceptar.Click
        Try
            Dim IDOperario As String = Nothing
            Dim connectionString As String = "Data Source=nombre_servidor;Initial Catalog=nombre_base_datos;Integrated Security=True"
            Using conexion As New SqlConnection(connectionString)
                Using Comando As New SqlCommand("SELECT * FROM tbMaestroOperario WHERE IDOperario = @IDOperario", conexion)
                    Comando.Parameters.AddWithValue("@IDOperario", IDOperario)


                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Shared Function ExisteOperario(ByVal IDOperario As String) As Boolean
        Try
            If String.IsNullOrEmpty(IDOperario) Then Return False

            Dim connectionString As String = "Data Source=nombre_servidor;Initial Catalog=nombre_base_datos;Integrated Security=True"
            Using conexion As New SqlConnection(connectionString)
                Using Comando As New SqlCommand("SELECT COUNT(*) FROM tbMaestroOperario WHERE IDOperario = @IDOperario", conexion)
                    Comando.Parameters.AddWithValue("@IDOperario", IDOperario)
                    Dim resultado As Integer = CInt(Comando.ExecuteScalar())
                    If resultado > 0 Then Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
End Class
