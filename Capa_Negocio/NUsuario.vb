﻿Imports Capa_Datos
Imports Capa_Entidades
Public Class NUsuario
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DUsuario
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Datos As New DUsuario
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Insertar(Obj As EUsuario) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Insertar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Actualizar(Obj As EUsuario) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DUsuario
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox("No se ha podido Eliminar el Usuario, Porque", vbOKOnly + vbInformation, "Falló la Eliminacion")
            Return False
        End Try
    End Function

End Class
