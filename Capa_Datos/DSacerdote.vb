Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class DSacerdote
    'heredacion
    Inherits conexion

    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("sacerdote_listar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("sacerdote_buscar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    '' Public Function Login(Email As String, Clave As String) As DataTable

    '' End Function"

    Public Sub Insertar(Obj As ESacerdote)
        Try
            Dim Comando As New SqlCommand("sacerdote_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idsacerdote", SqlDbType.Int).Value = Obj.IdSacerdote
            Comando.Parameters.Add("@sa_nombre", SqlDbType.VarChar).Value = Obj.Sacerdote_Nombre
            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar(Obj As ESacerdote)
        Try
            Dim Comando As New SqlCommand("sacerdote_actualizar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idsacerdote", SqlDbType.Int).Value = Obj.IdSacerdote
            Comando.Parameters.Add("@sa_nombre", SqlDbType.VarChar).Value = Obj.Sacerdote_Nombre
            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("sacerdote_eliminar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idsacerdote", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
