Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class DUsuario


    Private _con As New conexion
    Private _com As New SqlCommand
    Dim dttabla As New DataTable


    Public Function VericarConexion() As Integer
        _con.Abrir()
        Return conx
    End Function


    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("usuario_listar", _con.Abrir)
            Comando.CommandType = CommandType.StoredProcedure
            _com.Connection = _con.Abrir
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            _con.Cerrar()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("usuario_buscar", _con.Abrir)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor
            _com.Connection = _con.Abrir
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            _con.Cerrar()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Login(Email As String, Clave As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("usuario_login", _con.Abrir)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Email
            Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Clave
            _com.Connection = _con.Abrir
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            _con.Cerrar()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Insertar(Obj As EUsuario)
        Try
            Dim Comando As New SqlCommand("usuario_insertar", _con.Abrir)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = Obj.IdRol
            Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento
            Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = Obj.NumDocumento
            Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion
            Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono
            Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email
            Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Obj.Clave
            _com.Connection = _con.Abrir
            Comando.ExecuteNonQuery()
            _con.Cerrar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar(Obj As EUsuario)
        Try
            Dim Comando As New SqlCommand("usuario_actualizar", _con.Abrir)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Obj.IdUsuario
            Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = Obj.IdRol
            Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento
            Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = Obj.NumDocumento
            Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion
            Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono
            Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email
            Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Obj.Clave
            _com.Connection = _con.Abrir
            Comando.ExecuteNonQuery()
            _con.Cerrar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("usuario_eliminar", _con.Abrir)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id
            _com.Connection = _con.Abrir
            Comando.ExecuteNonQuery()
            _con.Cerrar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Desactivar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("usuario_desactivar", _con.Abrir)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id
            _com.Connection = _con.Abrir
            Comando.ExecuteNonQuery()
            _con.Cerrar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Activar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("usuario_activar", _con.Abrir)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id
            _com.Connection = _con.Abrir
            Comando.ExecuteNonQuery()
            _con.Cerrar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
