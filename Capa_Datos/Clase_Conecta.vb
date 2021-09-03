Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Clase_Conecta
    Private oConex As SqlConnection

    Public Function ConexionActual() As SqlConnection
        Return oConex
    End Function

    Public Function AbrirTransaccion() As SqlTransaction
        AbrirTransaccion = oConex.BeginTransaction()

    End Function

    Public Sub AbrirConexion()
        Dim C As SqlCommand

        oConex.Open()
        C = oConex.CreateCommand()
        C.CommandText = "SET DATEFORMAT DMY"
        C.ExecuteNonQuery()
        C = Nothing
    End Sub

    Public Function DameConexion() As SqlConnection
        Dim C As SqlCommand

        'DESARROLLO
        oConex = New SqlConnection("Initial Catalog=BD_Parroquia;Data Source=(local);Integrated Security = true")
        oConex.Open()
        C = oConex.CreateCommand()
        C.CommandText = "SET DATEFORMAT DMY"
        C.ExecuteNonQuery()
        C = Nothing

        Return oConex
    End Function

    Private Function ObtenerServidorBaseDeDatos() As String
        Dim lsServidorBD As String = ""
        Dim objStreamReader As StreamReader

        objStreamReader = New StreamReader(My.Application.Info.DirectoryPath & "\ConfigService.ini")
        lsServidorBD = objStreamReader.ReadLine

        Return lsServidorBD

    End Function


    Public Sub CierraConexion()
        oConex.Close()
        oConex = Nothing

    End Sub
End Class
