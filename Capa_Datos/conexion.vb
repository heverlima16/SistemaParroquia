Imports System.Data.SqlClient
Public Class conexion

    Public con As SqlConnection

    Public Sub Cerrar()
        con.Close()
    End Sub
    Public Function Abrir() As SqlConnection
        Try
            Dim sql As String
            sql = "Data Source = (Local); Initial Catalog = DB_Hospedaje; Integrated Security = true"
            con = New SqlConnection(sql)
            con.Open()
            conx = 0
        Catch ex As Exception
            conx = 1
        End Try
        Return con
    End Function
End Class
