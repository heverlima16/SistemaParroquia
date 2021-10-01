Imports System.Data.SqlClient
Public Class FrmCMatrimonio


    Private Sub FrmCMatrimonio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.listar()
        Me.CargarParroquia()
        Me.CargarSacerdote()

        Me.CargarLibro()

    End Sub


    'Hever Lima
    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(1).Visible = False
        DgvListado.Columns(2).Visible = True
        DgvListado.Columns(3).Visible = True

        DgvListado.Columns(4).Visible = True

        DgvListado.Columns(5).Visible = False
        DgvListado.Columns(6).Visible = False

        DgvListado.Columns(7).Visible = False
        DgvListado.Columns(8).Visible = False
        DgvListado.Columns(9).Visible = False
        DgvListado.Columns(10).Visible = False
        DgvListado.Columns(11).Visible = False
        DgvListado.Columns(12).Visible = False
        DgvListado.Columns(13).Visible = False
        DgvListado.Columns(14).Visible = False
        DgvListado.Columns(15).Visible = False
        DgvListado.Columns(16).Visible = False
        DgvListado.Columns(17).Visible = False
        DgvListado.Columns(18).Visible = False
        DgvListado.Columns(19).Visible = False








        BtnEliminar.Visible = False
        ChkSeleccionar.Checked = False








    End Sub
    Private Sub listar()
        Try
            Dim Negocio As New Capa_Negocio.NCMatrimonio
            DgvListado.DataSource = Negocio.Listar()
            LblTotal.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Buscar()
        Try
            Dim Negocio As New Capa_Negocio.NCMatrimonio
            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Negocio.Buscar(Valor)
            LblTotal.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub Limpiar()
        BtnGuardar.Visible = True
        BtnActualizar.Visible = False
        TxtValor.Text = ""

        TxtId.Text = ""
        TxtMa_NFoja.Text = ""
        CboLibro.Text = ""
        TxtNumeroCasado.Text = ""
        TxtMa_NEsposo.Text = ""
        TxtMa_LEsposo.Text = ""
        DateMa_FNEsposo.Text = ""
        TxtMa_NEsposa.Text = ""
        TxtMa_LEsposa.Text = ""
        DateMa_FNEsposa.Text = ""
        CboSacerdote.Text = ""
        CboParroquia.Text = ""
        TxtMa_NPadreEsposo.Text = ""
        TxtMa_NMadreEsposo.Text = ""
        TxtMa_NPadreEsposa.Text = ""
        TxtMa_NMadreEsposa.Text = ""
        TxtMa_NPadrino.Text = ""
        TxtMa_LMatrimonio.Text = ""
        DateMa_FMatrimonio.Text = ""
        TxtMa_AnotacionesTextuales.Text = ""

    End Sub

    Private Sub DgvListado_DoubleClick(sender As Object, e As EventArgs) Handles DgvListado.DoubleClick

        TxtId.Text = DgvListado.SelectedCells.Item(1).Value
        DateMa_FMatrimonio.Text = DgvListado.SelectedCells.Item(2).Value
        TxtMa_NEsposo.Text = DgvListado.SelectedCells.Item(3).Value
        TxtMa_NEsposa.Text = DgvListado.SelectedCells.Item(4).Value
        TxtMa_LMatrimonio.Text = DgvListado.SelectedCells.Item(5).Value
        TxtNumeroCasado.Text = DgvListado.SelectedCells.Item(6).Value

        DateMa_FNEsposo.Text = DgvListado.SelectedCells.Item(7).Value
        TxtMa_LEsposo.Text = DgvListado.SelectedCells.Item(8).Value
        DateMa_FNEsposa.Text = DgvListado.SelectedCells.Item(9).Value

        TxtMa_LEsposa.Text = DgvListado.SelectedCells.Item(10).Value
        TxtMa_NPadrino.Text = DgvListado.SelectedCells.Item(11).Value

        TxtMa_LMatrimonio.Text = DgvListado.SelectedCells.Item(12).Value
        DateMa_FMatrimonio.Text = DgvListado.SelectedCells.Item(13).Value

        TxtMa_NPadreEsposo.Text = DgvListado.SelectedCells.Item(14).Value
        TxtMa_NMadreEsposo.Text = DgvListado.SelectedCells.Item(15).Value
        TxtMa_NPadreEsposa.Text = DgvListado.SelectedCells.Item(16).Value
        TxtMa_NMadreEsposa.Text = DgvListado.SelectedCells.Item(17).Value
        TxtMa_AnotacionesTextuales.Text = DgvListado.SelectedCells.Item(18).Value
        TxtMa_NFoja.Text = DgvListado.SelectedCells.Item(19).Value






        CboParroquia.Visible = False
        CboSacerdote.Visible = False
        CboLibro.Visible = False

        Label12.Visible = False
        Label11.Visible = False
        Label5.Visible = False

        TxtId.Visible = False
        BtnGuardar.Visible = False
        BtnActualizar.Visible = True
        TabGeneral.SelectedIndex = 1
    End Sub

    Private Sub CargarParroquia()
        Try
            Dim Negocio As New Capa_Negocio.NParroquia
            CboParroquia.DataSource = Negocio.Seleccionar
            CboParroquia.ValueMember = "idparroquia"
            CboParroquia.DisplayMember = "pa_nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CargarSacerdote()
        Try
            Dim Negocio As New Capa_Negocio.NSacerdote
            CboSacerdote.DataSource = Negocio.Seleccionar
            CboSacerdote.ValueMember = "idsacerdote"
            CboSacerdote.DisplayMember = "sa_nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargarLibro()
        Try
            Dim Negocio As New Capa_Negocio.NLibro
            CboLibro.DataSource = Negocio.Seleccionar
            CboLibro.ValueMember = "idlibro"
            CboLibro.DisplayMember = "li_numero"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click


        If Me.ValidateChildren = True And TxtMa_NEsposo.Text <> "" And CboParroquia.Text <> "" Then
            Dim obj As New Capa_Entidades.ECMatrimonio
            Dim Negocio As New Capa_Negocio.NCMatrimonio
            'recibe datos


            obj.Ma_NFoja = TxtMa_NFoja.Text
            obj.IdLibro = CboLibro.SelectedValue
            obj.Ma_Numero = TxtNumeroCasado.Text
            obj.Ma_NEsposo = TxtMa_NEsposo.Text
            obj.Ma_LEsposo = TxtMa_LEsposo.Text
            obj.Ma_FNEsposo = DateMa_FNEsposo.Text
            obj.Ma_NEsposa = TxtMa_NEsposa.Text
            obj.Ma_LEsposa = TxtMa_LEsposa.Text
            obj.Ma_FNEsposa = DateMa_FNEsposa.Text
            obj.Idsacerdote = CboSacerdote.SelectedValue
            obj.IdParroquiaBautizado = CboParroquia.SelectedValue
            obj.Ma_NPadreEsposo = TxtMa_NPadreEsposo.Text
            obj.Ma_NMadreEsposo = TxtMa_NMadreEsposo.Text
            obj.Ma_NPadreEsposa = TxtMa_NPadreEsposa.Text
            obj.Ma_NMadreEsposa = TxtMa_NMadreEsposa.Text
            obj.Ma_NPadrino = TxtMa_NPadrino.Text
            obj.Ma_LMatrimonio = TxtMa_LMatrimonio.Text
            obj.Ma_FMatrimonio = DateMa_FMatrimonio.Text
            obj.Ma_AnotacionesTextuales = TxtMa_AnotacionesTextuales.Text


            If (Negocio.Insertar(obj)) Then
                MsgBox("Se registró correctamente", vbOKOnly + vbInformation, "Registro Exitoso")
                Me.listar()
            Else
                MsgBox("No se registró", vbOKOnly + vbCritical, "Registro Fallido")

            End If
            TabGeneral.SelectedIndex = 0

        Else
            MsgBox("Rellene todo los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta rellenar datos")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()
        TabGeneral.SelectedIndex = 0
    End Sub

    Private Sub TxtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Rellene los datos porfavor")
        End If
    End Sub





    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Me.ValidateChildren = True And TxtMa_NEsposo.Text <> "" And TxtId.Text <> "" Then
            Dim obj As New Capa_Entidades.ECMatrimonio
            Dim Negocio As New Capa_Negocio.NCMatrimonio

            obj.IdPMatrimonio = TxtId.Text
            obj.Ma_NFoja = TxtMa_NFoja.Text
            obj.IdLibro = CboLibro.SelectedValue
            obj.Ma_Numero = TxtNumeroCasado.Text
            obj.Ma_NEsposo = TxtMa_NEsposo.Text
            obj.Ma_LEsposo = TxtMa_LEsposo.Text
            obj.Ma_FNEsposo = DateMa_FNEsposo.Text
            obj.Ma_NEsposa = TxtMa_NEsposa.Text
            obj.Ma_LEsposa = TxtMa_LEsposa.Text
            obj.Ma_FNEsposa = DateMa_FNEsposa.Text
            obj.Idsacerdote = CboSacerdote.SelectedValue
            obj.IdParroquiaBautizado = CboParroquia.SelectedValue
            obj.Ma_NPadreEsposo = TxtMa_NPadreEsposo.Text
            obj.Ma_NMadreEsposo = TxtMa_NMadreEsposo.Text
            obj.Ma_NPadreEsposa = TxtMa_NPadreEsposa.Text
            obj.Ma_NMadreEsposa = TxtMa_NMadreEsposa.Text
            obj.Ma_NPadrino = TxtMa_NPadrino.Text
            obj.Ma_LMatrimonio = TxtMa_LMatrimonio.Text
            obj.Ma_FMatrimonio = DateMa_FMatrimonio.Text
            obj.Ma_AnotacionesTextuales = TxtMa_AnotacionesTextuales.Text

            If (Negocio.Actualizar(obj)) Then
                MsgBox("Se actualizado correctamente", vbOKOnly + vbInformation, "Actualización Exitoso")
                Me.listar()
            Else
                MsgBox("No se actualizó", vbOKOnly + vbCritical, "Actualización Fallido")

            End If
            TabGeneral.SelectedIndex = 0

        Else
            MsgBox("Rellene todo los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta rellenar datos")

        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (MsgBox("Desea eliminar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registros") = vbYes) Then
            Try
                Dim Neg As New Capa_Negocio.NCMatrimonio
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("idPMatrimonio").Value)
                        Neg.Eliminar(OneKey)
                    End If
                Next
                Me.listar()
                Me.Formato()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ChkSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSeleccionar.CheckedChanged
        If ChkSeleccionar.CheckState = CheckState.Checked Then
            DgvListado.Columns.Item("Seleccionar").Visible = True
            BtnEliminar.Visible = True

        Else
            DgvListado.Columns.Item("Seleccionar").Visible = False
            BtnEliminar.Visible = False

        End If
    End Sub




    Private Sub DgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentClick
        If e.ColumnIndex = DgvListado.Columns.Item("Seleccionar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = DgvListado.Rows(e.RowIndex).Cells("Seleccionar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub TxtMa_NEsposo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMa_NEsposo.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtMa_NEsposa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMa_NEsposa.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtMa_LEsposo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMa_LEsposo.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtMa_LEsposa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMa_LEsposa.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtMa_NPadreEsposo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMa_NPadreEsposo.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtMa_NPadreEsposa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMa_NPadreEsposa.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtMa_NMadreEsposo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMa_NMadreEsposo.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtMa_NMadreEsposa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMa_NMadreEsposa.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtMa_NPadrino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMa_NPadrino.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtMa_LMatrimonio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMa_LMatrimonio.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtMa_AnotacionesTextuales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMa_AnotacionesTextuales.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ.1234567890" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtMa_NFoja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMa_NFoja.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtNumeroCasado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumeroCasado.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtMa_NEsposo_MouseDown(sender As Object, e As MouseEventArgs) Handles TxtMa_NEsposo.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            MIMENU()
        End If
    End Sub

    Private Sub MIMENU()

        Dim MENU As New ContextMenu

        Dim COPIAR As New MenuItem("COPIAR")
        AddHandler COPIAR.Click, AddressOf COPIAR_Click

        Dim PEGAR As New MenuItem("PEGAR")
        AddHandler PEGAR.Click, AddressOf PEGAR_Click

        Dim CORTAR As New MenuItem("CORTAR")
        AddHandler CORTAR.Click, AddressOf CORTAR_Click

        MENU.MenuItems.Add(COPIAR)
        MENU.MenuItems.Add(PEGAR)
        MENU.MenuItems.Add(CORTAR)

        TxtMa_NEsposo.ContextMenu = MENU


    End Sub

    Private Sub COPIAR_Click()
        TxtMa_NEsposo.Copy()

    End Sub

    Private Sub PEGAR_Click()
        TxtMa_NEsposo.Paste()

    End Sub

    Private Sub CORTAR_Click()
        TxtMa_NEsposo.Cut()

    End Sub

End Class