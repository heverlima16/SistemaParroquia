﻿Imports System.Windows.Forms

Public Class FrmHome

    'muestra el roly y nombre
    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''  Handles MyBase.MouseMove '' aca puedes agregar mas controles que quieras usar para mover el formulario ej: label1.MouseMove


        'mostrara el menu principal de estado habitaciones
        ''Dim frm As New FrmMostrarEstadoHabitacion
        ''frm.MdiParent = Me
        ''frm.Show()"

        NombreDelUsuarioSegunSuRolToolStripMenuItem.Text = "Bienvenido " & Me.Rol + " " + Me.Nombre

        If (Me.Rol = "Padre") Then
            MenuRegistro.Enabled = True
            MenuUsuarios.Enabled = True
        ElseIf (Me.Rol = "Secretaria") Then
            MenuRegistro.Enabled = False
            MenuUsuarios.Enabled = False
        Else
            MenuRegistro.Enabled = False
            MenuUsuarios.Enabled = False
        End If
    End Sub
    ' Fin mostrar el roly y nombre

    'desabilitar el boton cerrar de form'
    Dim _enabledCerrar As Boolean = False
    <System.ComponentModel.DefaultValue(False), System.ComponentModel.Description("Define si se habilita el botón cerrar en el formulario")>
    Public Property EnabledCerrar() As Boolean
        Get
            Return _enabledCerrar
        End Get
        Set(ByVal Value As Boolean)
            If _enabledCerrar <> Value Then
                _enabledCerrar = Value
            End If
        End Set
    End Property
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If _enabledCerrar = False Then
                Const CS_NOCLOSE As Integer = &H200
                cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            End If
            Return cp
        End Get
    End Property
    'fin   desabilitar el boton cerrar de form'
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles UsuariosParroquiaToolStripMenuItem.Click
        Dim frm As New FrmUsuario
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer


    'enfoca a login'

    Private _IdUsuario As String
    Private _IdRol As String
    Private _Rol As String
    Private _Nombre As String

    Public Property IdUsuario As String
        Get
            Return _IdUsuario
        End Get
        Set(value As String)
            _IdUsuario = value
        End Set
    End Property

    Public Property IdRol As String
        Get
            Return _IdRol
        End Get
        Set(value As String)
            _IdRol = value
        End Set
    End Property

    Public Property Rol As String
        Get
            Return _Rol
        End Get
        Set(value As String)
            _Rol = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property



    Private Sub IconButtonCerrarSesion_Click(sender As Object, e As EventArgs) Handles IconButtonCerrarSesion.Click
        If (MsgBox("CERRAR SESIÓN", vbYesNo + vbExclamation, "Cerrar Sistema Parroquia") = vbYes) Then
            Me.Close()
            End
        End If
    End Sub


    'fin de login '
End Class
