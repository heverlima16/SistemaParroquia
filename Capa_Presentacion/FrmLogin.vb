Public Class FrmLogin
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        End
    End Sub

    Private Sub btn_IniciarSesion_Click(sender As Object, e As EventArgs) Handles btn_IniciarSesion.Click
        Try
            Dim Usuario As String, Clave As String
            Dim Obj As New Capa_Entidades.EUsuario
            Dim Neg As New Capa_Negocio.NUsuario
            Usuario = Txt_Usuario.Text.Trim()
            Clave = Txt_Clave.Text.Trim()
            Obj = Neg.Login(Usuario, Clave)
            If (Obj Is Nothing) Then
                MsgBox("No existe un usuario con ese email o clave", vbOKOnly + vbCritical, "Datos incorrectos")
            Else
                Me.Hide()
                FrmHome.IdUsuario = Obj.IdUsuario
                'aki capturamos
                Variables2.IdUsuario = Obj.IdUsuario
                FrmHome.IdRol = Obj.IdRol
                FrmHome.Rol = Obj.Usuario_Rol
                FrmHome.Nombre = Obj.Usuario_Nombre
                FrmHome.Show()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class