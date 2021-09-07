Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class DProvincia
    Inherits conexion

    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("provincia_listar", MyBase.conn)
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
            Dim Comando As New SqlCommand("provincia_buscar", MyBase.conn)
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


    Public Sub Insertar(Obj As EProvincia)
        Try
            Dim Comando As New SqlCommand("provincia_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@iddepartamento", SqlDbType.Int).Value = Obj.IdDepartamento
            Comando.Parameters.Add("@pro_nombre", SqlDbType.VarChar).Value = Obj.Pro_Nombre
            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar(Obj As EProvincia)
        Try
            Dim Comando As New SqlCommand("provincia_actualizar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idprovincia", SqlDbType.Int).Value = Obj.IdProvincia
            Comando.Parameters.Add("@iddepartamento", SqlDbType.Int).Value = Obj.IdDepartamento
            Comando.Parameters.Add("@pro_nombre", SqlDbType.VarChar).Value = Obj.Pro_Nombre
            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("provincia_eliminar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idprovincia", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Seleccionar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("provincia_seleccionar", MyBase.conn)
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
End Class
