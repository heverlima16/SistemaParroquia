Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class DUsuario
    'heredacion
    Inherits conexion

    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("usuario_listar", MyBase.conn)
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
            Dim Comando As New SqlCommand("usuario_buscar", MyBase.conn)
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

    Public Function Login(Nickname As String, Clave As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("usuario_login", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@usu_nickname", SqlDbType.VarChar).Value = Nickname
            Comando.Parameters.Add("@usu_clave", SqlDbType.VarChar).Value = Clave
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Insertar(Obj As EUsuario)
        Try
            Dim Comando As New SqlCommand("usuario_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = Obj.IdRol
            Comando.Parameters.Add("@usu_nombre", SqlDbType.VarChar).Value = Obj.Usuario_Nombre
            Comando.Parameters.Add("@usu_nickname", SqlDbType.VarChar).Value = Obj.Usuario_NickName
            Comando.Parameters.Add("@usu_clave", SqlDbType.VarChar).Value = Obj.Usuario_Clave
            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar(Obj As EUsuario)
        Try
            Dim Comando As New SqlCommand("usuario_actualizar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Obj.IdUsuario
            Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = Obj.IdRol
            Comando.Parameters.Add("@usu_nombre", SqlDbType.VarChar).Value = Obj.Usuario_Nombre
            Comando.Parameters.Add("@usu_nickname", SqlDbType.VarChar).Value = Obj.Usuario_NickName
            Comando.Parameters.Add("@usu_clave", SqlDbType.VarChar).Value = Obj.Usuario_Clave
            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("usuario_eliminar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
