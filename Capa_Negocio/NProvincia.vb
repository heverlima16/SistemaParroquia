Imports Capa_Datos
Imports Capa_Entidades
Public Class NProvincia
    Public Function Listar() As DataTable
        Try
            Dim Datos As New DProvincia
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
            Dim Datos As New DProvincia
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Insertar(Obj As EProvincia) As Boolean
        Try
            Dim Datos As New DProvincia
            Datos.Insertar(Obj)
            Return True
        Catch ex As Exception

            MsgBox("El dato que intenta registrar ya existe", vbOKOnly + vbCritical, "No se ha podido Guardar")
            Return False

            'MsgBox(ex.Message)
            'Return False

        End Try
    End Function

    Public Function Actualizar(Obj As EProvincia) As Boolean
        Try
            Dim Datos As New DProvincia
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DProvincia
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox("No se ha podido Eliminar", vbOKOnly + vbInformation, "Falló la Eliminacion")
            Return False
        End Try
    End Function



    Public Function Seleccionar() As DataTable
        Try
            Dim Datos As New DProvincia
            Dim Tabla As New DataTable
            Tabla = Datos.Seleccionar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
