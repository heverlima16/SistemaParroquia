Imports Capa_Entidades
Imports System.Data.SqlClient

Public Class DCMatrimonio
    Inherits conexion

    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("matrimonio_listar", MyBase.conn)
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
            Dim Comando As New SqlCommand("matrimonio_buscar", MyBase.conn)
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


    Public Sub Insertar(Obj As ECMatrimonio)
        Try
            Dim Comando As New SqlCommand("matrimonio_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure

            Comando.Parameters.Add("@IdLibro", SqlDbType.Int).Value = Obj.IdLibro
            Comando.Parameters.Add("@IdFoja", SqlDbType.Int).Value = Obj.IdFoja
            Comando.Parameters.Add("@Ma_Numero", SqlDbType.Int).Value = Obj.Ma_Numero
            Comando.Parameters.Add("@Ma_NEsposo", SqlDbType.VarChar).Value = Obj.Ma_NEsposo
            Comando.Parameters.Add("@Ma_LEsposo", SqlDbType.VarChar).Value = Obj.Ma_LEsposo
            Comando.Parameters.Add("@Ma_FNEsposo", SqlDbType.Date).Value = Obj.Ma_FNEsposo
            Comando.Parameters.Add("@Ma_NEsposa", SqlDbType.VarChar).Value = Obj.Ma_NEsposa
            Comando.Parameters.Add("@Ma_LEsposa", SqlDbType.VarChar).Value = Obj.Ma_LEsposa
            Comando.Parameters.Add("@Ma_FNEsposa", SqlDbType.Date).Value = Obj.Ma_FNEsposa
            Comando.Parameters.Add("@idsacerdote", SqlDbType.Int).Value = Obj.Idsacerdote
            Comando.Parameters.Add("@IdParroquiaBautizado", SqlDbType.Int).Value = Obj.IdParroquiaBautizado
            Comando.Parameters.Add("@Ma_NPadreEsposo", SqlDbType.VarChar).Value = Obj.Ma_NPadreEsposo
            Comando.Parameters.Add("@Ma_NPadreEsposa", SqlDbType.VarChar).Value = Obj.Ma_NPadreEsposa
            Comando.Parameters.Add("@Ma_NMadreEsposo", SqlDbType.VarChar).Value = Obj.Ma_NMadreEsposo
            Comando.Parameters.Add("@Ma_NMadreEsposa", SqlDbType.VarChar).Value = Obj.Ma_NMadreEsposa
            Comando.Parameters.Add("@Ma_NPadrino", SqlDbType.VarChar).Value = Obj.Ma_NPadrino
            Comando.Parameters.Add("@Ma_LMatrimonio", SqlDbType.VarChar).Value = Obj.Ma_LMatrimonio
            Comando.Parameters.Add("@Ma_FMatrimonio", SqlDbType.Date).Value = Obj.Ma_FMatrimonio
            Comando.Parameters.Add("@Ma_AnotacionesTextuales", SqlDbType.VarChar).Value = Obj.Ma_AnotacionesTextuales


            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar(Obj As ECMatrimonio)
        Try
            Dim Comando As New SqlCommand("matrimonio_actualizar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure

            Comando.Parameters.Add("@IdPMatrimonio", SqlDbType.Int).Value = Obj.IdPMatrimonio

            Comando.Parameters.Add("@Ma_Numero", SqlDbType.Int).Value = Obj.Ma_Numero
            Comando.Parameters.Add("@Ma_NEsposo", SqlDbType.VarChar).Value = Obj.Ma_NEsposo
            Comando.Parameters.Add("@Ma_LEsposo", SqlDbType.VarChar).Value = Obj.Ma_LEsposo
            Comando.Parameters.Add("@Ma_FNEsposo", SqlDbType.Date).Value = Obj.Ma_FNEsposo
            Comando.Parameters.Add("@Ma_NEsposa", SqlDbType.VarChar).Value = Obj.Ma_NEsposa
            Comando.Parameters.Add("@Ma_LEsposa", SqlDbType.VarChar).Value = Obj.Ma_LEsposa
            Comando.Parameters.Add("@Ma_FNEsposa", SqlDbType.Date).Value = Obj.Ma_FNEsposa

            Comando.Parameters.Add("@Ma_NPadreEsposo", SqlDbType.VarChar).Value = Obj.Ma_NPadreEsposo
            Comando.Parameters.Add("@Ma_NPadreEsposa", SqlDbType.VarChar).Value = Obj.Ma_NPadreEsposa
            Comando.Parameters.Add("@Ma_NMadreEsposo", SqlDbType.VarChar).Value = Obj.Ma_NMadreEsposo
            Comando.Parameters.Add("@Ma_NMadreEsposa", SqlDbType.VarChar).Value = Obj.Ma_NMadreEsposa
            Comando.Parameters.Add("@Ma_NPadrino", SqlDbType.VarChar).Value = Obj.Ma_NPadrino
            Comando.Parameters.Add("@Ma_LMatrimonio", SqlDbType.VarChar).Value = Obj.Ma_LMatrimonio
            Comando.Parameters.Add("@Ma_FMatrimonio", SqlDbType.Date).Value = Obj.Ma_FMatrimonio
            Comando.Parameters.Add("@Ma_AnotacionesTextuales", SqlDbType.VarChar).Value = Obj.Ma_AnotacionesTextuales

            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("matrimonio_eliminar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@IdPMatrimonio", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Comando.ExecuteReader()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
