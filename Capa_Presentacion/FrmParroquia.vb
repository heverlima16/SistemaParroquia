Public Class FrmParroquia
    Private Sub FrmParroquia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.listar()
    End Sub

    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        BtnEliminar.Visible = False
        ChkSeleccionar.Checked = False
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(1).Visible = False


    End Sub
    Private Sub listar()
        Try
            Dim Negocio As New Capa_Negocio.NParroquia
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
            Dim Negocio As New Capa_Negocio.NParroquia
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
        TxtParroquia.Text = ""
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Me.ValidateChildren = True And TxtParroquia.Text <> "" Then
            Dim obj As New Capa_Entidades.EParroquia
            Dim Negocio As New Capa_Negocio.NParroquia
            'recibe datos
            obj.Pa_Nombre = TxtParroquia.Text



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

    Private Sub TxtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtParroquia.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Rellene los datos porfavor")
        End If
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        TxtId.Text = DgvListado.SelectedCells.Item(1).Value
        TxtParroquia.Text = DgvListado.SelectedCells.Item(2).Value
        BtnGuardar.Visible = False
        BtnActualizar.Visible = True
        TabGeneral.SelectedIndex = 1
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Me.ValidateChildren = True And TxtParroquia.Text <> "" And TxtId.Text <> "" Then
            Dim obj As New Capa_Entidades.EParroquia
            Dim Negocio As New Capa_Negocio.NParroquia
            'recibe datos
            obj.Idparroquia = TxtId.Text
            obj.Pa_Nombre = TxtParroquia.Text


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
                Dim Neg As New Capa_Negocio.NParroquia
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("idparroquia").Value)
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

    Private Sub TxtParroquia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtParroquia.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ.1234567890" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtParroquia_MouseDown(sender As Object, e As MouseEventArgs) Handles TxtParroquia.MouseDown
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

        TxtParroquia.ContextMenu = MENU


    End Sub

    Private Sub COPIAR_Click()
        TxtParroquia.Copy()

    End Sub

    Private Sub PEGAR_Click()
        TxtParroquia.Paste()

    End Sub

    Private Sub CORTAR_Click()
        TxtParroquia.Cut()

    End Sub
End Class