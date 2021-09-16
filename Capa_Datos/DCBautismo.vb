Imports Capa_Entidades
Imports System.Data.SqlClient
Public Class DCBautismo
    Inherits conexion

    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("bautismo_listar", MyBase.conn)
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
            Dim Comando As New SqlCommand("bautismo_buscar", MyBase.conn)
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


    Public Sub Insertar(Obj As ECBautismo)
        Try
            Dim Comando As New SqlCommand("bautismo_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure

            Comando.Parameters.Add("@IdLibro", SqlDbType.Int).Value = Obj.IdLibro
            Comando.Parameters.Add("@IdFoja", SqlDbType.Int).Value = Obj.IdFoja
            Comando.Parameters.Add("@Ba_Numero", SqlDbType.Int).Value = Obj.Ba_Numero
            Comando.Parameters.Add("@Ba_Nombre", SqlDbType.VarChar).Value = Obj.Ba_Nombre
            Comando.Parameters.Add("@Ba_LNacimiento", SqlDbType.VarChar).Value = Obj.Ba_LNacimiento
            Comando.Parameters.Add("@Ba_FNacimiento", SqlDbType.Date).Value = Obj.Ba_FNacimiento
            Comando.Parameters.Add("@idsacerdote", SqlDbType.Int).Value = Obj.Idsacerdote
            Comando.Parameters.Add("@IdParroquiaBautizado", SqlDbType.Int).Value = Obj.IdParroquiaBautizado
            Comando.Parameters.Add("@Ba_NPadre ", SqlDbType.VarChar).Value = Obj.Ba_NPadre
            Comando.Parameters.Add("@Ba_NMadre", SqlDbType.VarChar).Value = Obj.Ba_NMadre
            Comando.Parameters.Add("@Ba_NPadrino", SqlDbType.VarChar).Value = Obj.Ba_NPadrino
            Comando.Parameters.Add("@Ba_LBautismo", SqlDbType.VarChar).Value = Obj.Ba_LBautismo
            Comando.Parameters.Add("@Ba_FBautismo", SqlDbType.Date).Value = Obj.Ba_FBautismo
            Comando.Parameters.Add("@Ba_AnotacionesTextuales", SqlDbType.VarChar).Value = Obj.Ba_AnotacionesTextuales


            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar(Obj As ECBautismo)
        Try
            Dim Comando As New SqlCommand("bautismo_actualizar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure

            Comando.Parameters.Add("@IdPBautismo", SqlDbType.Int).Value = Obj.IdPBautismo
            Comando.Parameters.Add("@Ba_Numero", SqlDbType.Int).Value = Obj.Ba_Numero
            Comando.Parameters.Add("@Ba_Nombre", SqlDbType.VarChar).Value = Obj.Ba_Nombre
            Comando.Parameters.Add("@Ba_LNacimiento", SqlDbType.VarChar).Value = Obj.Ba_LNacimiento
            Comando.Parameters.Add("@Ba_FNacimiento", SqlDbType.Date).Value = Obj.Ba_FNacimiento
            Comando.Parameters.Add("@Ba_NPadre ", SqlDbType.VarChar).Value = Obj.Ba_NPadre
            Comando.Parameters.Add("@Ba_NMadre", SqlDbType.VarChar).Value = Obj.Ba_NMadre
            Comando.Parameters.Add("@Ba_NPadrino", SqlDbType.VarChar).Value = Obj.Ba_NPadrino
            Comando.Parameters.Add("@Ba_LBautismo", SqlDbType.VarChar).Value = Obj.Ba_LBautismo
            Comando.Parameters.Add("@Ba_FBautismo", SqlDbType.Date).Value = Obj.Ba_FBautismo
            Comando.Parameters.Add("@Ba_AnotacionesTextuales", SqlDbType.VarChar).Value = Obj.Ba_AnotacionesTextuales

            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("bautismo_eliminar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@IdPBautismo", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
