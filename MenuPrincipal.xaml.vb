Imports System.Collections.ObjectModel

Class MenuPrincipal
    Private Sub btnInicio_Click(sender As Object, e As RoutedEventArgs) Handles btnInicio.Click
        Dim menuPrincipalPage As New Uri("MenuPrincipal.xaml", UriKind.Relative)
        Me.NavigationService.Navigate(menuPrincipalPage)
    End Sub

    Private Sub MenuPrincipal_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Try
            Dim TuColeccionDeDatos As New ObservableCollection(Of Clientes) From {
                New Clientes() With {.IDCliente = 1, .DescCliente = "Cliente A", .FechaAlta = DateTime.Now},
                New Clientes() With {.IDCliente = 2, .DescCliente = "Cliente B", .FechaAlta = DateTime.Now}
            }
            Me.GridClientes.ItemsSource = TuColeccionDeDatos
            Me.GridClientes.AutoGenerateColumns = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class

Public Class Clientes
    Public IDCliente As String
    Public DescCliente As String
    Public FechaAlta As DateTime
End Class
