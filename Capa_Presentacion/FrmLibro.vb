Public Class FrmLibro
    Private Sub FrmLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim Negocio As New Capa_Negocio.NLibro
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
            Dim Negocio As New Capa_Negocio.NLibro
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
        TxtNumero.Text = ""
        TxtAnotaciones.Text = ""
    End Sub


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Me.ValidateChildren = True And TxtNumero.Text <> "" Then
            Dim obj As New Capa_Entidades.ELibro
            Dim Negocio As New Capa_Negocio.NLibro
            'recibe datos
            obj.Li_Numero = TxtNumero.Text
            obj.Li_Anotaciones = TxtAnotaciones.Text


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

    Private Sub TxtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtNumero.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Rellene los datos porfavor")
        End If
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        TxtId.Text = DgvListado.SelectedCells.Item(1).Value
        TxtNumero.Text = DgvListado.SelectedCells.Item(2).Value
        TxtAnotaciones.Text = DgvListado.SelectedCells.Item(3).Value
        BtnGuardar.Visible = False
        BtnActualizar.Visible = True
        TabGeneral.SelectedIndex = 1
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Me.ValidateChildren = True And TxtNumero.Text <> "" And TxtId.Text <> "" Then
            Dim obj As New Capa_Entidades.ELibro
            Dim Negocio As New Capa_Negocio.NLibro
            'recibe datos
            obj.IdLibro = TxtId.Text
            obj.Li_Numero = TxtNumero.Text
            obj.Li_Anotaciones = TxtAnotaciones.Text


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
                Dim Neg As New Capa_Negocio.NLibro
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("idlibro").Value)
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

    Private Sub TxtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumero.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TxtAnotaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAnotaciones.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUWVXYZ" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
End Class