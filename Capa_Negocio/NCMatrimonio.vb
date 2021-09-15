Imports Capa_Datos
Imports Capa_Entidades
Public Class NCMatrimonio
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DCMatrimonio
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
            Dim Datos As New DCMatrimonio
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Insertar(Obj As ECMatrimonio) As Boolean
        Try
            Dim Datos As New DCMatrimonio
            Datos.Insertar(Obj)
            Return True
        Catch ex As Exception

            MsgBox("El dato que intenta registrar ya existe", vbOKOnly + vbCritical, "No se ha podido Guardar")
            Return False

            'MsgBox(ex.Message)
            'Return False

        End Try
    End Function

    Public Function Actualizar(Obj As ECMatrimonio) As Boolean
        Try
            Dim Datos As New DCMatrimonio
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DCMatrimonio
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox("No se ha podido Eliminar", vbOKOnly + vbInformation, "Falló la Eliminacion")
            Return False
        End Try
    End Function

End Class
