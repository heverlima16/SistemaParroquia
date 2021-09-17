Public Class FrmCBautismo
    Private Sub FrmCBautismo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.listar()
        Me.CargarParroquia()
        Me.CargarSacerdote()
        Me.CargarFoja()
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
        DgvListado.Columns(5).Visible = True
        DgvListado.Columns(6).Visible = False
        DgvListado.Columns(7).Visible = False
        DgvListado.Columns(8).Visible = False
        DgvListado.Columns(9).Visible = False
        DgvListado.Columns(10).Visible = False
        DgvListado.Columns(11).Visible = False
        DgvListado.Columns(12).Visible = False










        BtnEliminar.Visible = False
        ChkSeleccionar.Checked = False








    End Sub
    Private Sub listar()
        Try
            Dim Negocio As New Capa_Negocio.NCBautismo
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
            Dim Negocio As New Capa_Negocio.NCBautismo
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

        TxtBa_Numero.Text = ""
        TxtBa_Nombre.Text = ""
        TxtBa_Apellido.Text = ""

        TxtBa_LNacimiento.Text = ""
        DateBa_FNacimiento.Text = ""
        CboSacerdote.Text = ""
        CboParroquia.Text = ""

        TxtBa_NPadre.Text = ""
        TxtBa_NMadre.Text = ""
        TxtBa_NPadrino.Text = ""
        TxtBa_LBautismo.Text = ""
        DateBa_FBautismo.Text = ""
        TxtBa_AnotacionesTextuales.Text = ""

    End Sub

    Private Sub DgvListado_DoubleClick(sender As Object, e As EventArgs) Handles DgvListado.DoubleClick

        TxtId.Text = DgvListado.SelectedCells.Item(1).Value
        DateBa_FBautismo.Text = DgvListado.SelectedCells.Item(2).Value
        TxtBa_Nombre.Text = DgvListado.SelectedCells.Item(3).Value
        TxtBa_Apellido.Text = DgvListado.SelectedCells.Item(4).Value

        TxtBa_NPadrino.Text = DgvListado.SelectedCells.Item(5).Value
        TxtBa_Numero.Text = DgvListado.SelectedCells.Item(6).Value
        TxtBa_LNacimiento.Text = DgvListado.SelectedCells.Item(7).Value
        DateBa_FNacimiento.Text = DgvListado.SelectedCells.Item(8).Value
        TxtBa_NPadre.Text = DgvListado.SelectedCells.Item(9).Value
        TxtBa_NMadre.Text = DgvListado.SelectedCells.Item(10).Value
        TxtBa_LBautismo.Text = DgvListado.SelectedCells.Item(11).Value
        TxtBa_AnotacionesTextuales.Text = DgvListado.SelectedCells.Item(12).Value



        CboParroquia.Visible = False
        Label11.Visible = False
        CboLibro.Visible = False
        CboFoja.Visible = False
        TxtBa_Numero.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        CboSacerdote.Visible = False
        Label12.Visible = False
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

    Private Sub CargarFoja()
        Try
            Dim Negocio As New Capa_Negocio.NFoja
            CboFoja.DataSource = Negocio.Seleccionar
            CboFoja.ValueMember = "idfoja"
            CboFoja.DisplayMember = "fo_numero"
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
        If Me.ValidateChildren = True And TxtBa_Nombre.Text <> "" And CboParroquia.Text <> "" Then
            Dim obj As New Capa_Entidades.ECBautismo
            Dim Negocio As New Capa_Negocio.NCBautismo
            'recibe datos


            obj.IdFoja = CboFoja.SelectedValue
            obj.IdLibro = CboLibro.SelectedValue
            obj.Ba_Numero = TxtBa_Numero.Text
            obj.Ba_Nombre = TxtBa_Nombre.Text
            obj.Ba_Apellido = TxtBa_Apellido.Text
            obj.Ba_LNacimiento = TxtBa_LNacimiento.Text
            obj.Ba_FNacimiento = DateBa_FNacimiento.Text
            obj.Idsacerdote = CboSacerdote.SelectedValue
            obj.IdParroquiaBautizado = CboParroquia.SelectedValue
            obj.Ba_NPadre = TxtBa_NPadre.Text
            obj.Ba_NMadre = TxtBa_NMadre.Text
            obj.Ba_NPadrino = TxtBa_NPadrino.Text
            obj.Ba_LBautismo = TxtBa_LBautismo.Text
            obj.Ba_FBautismo = DateBa_FBautismo.Text
            obj.Ba_AnotacionesTextuales = TxtBa_AnotacionesTextuales.Text


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
        If Me.ValidateChildren = True And TxtBa_Nombre.Text <> "" And TxtId.Text <> "" Then
            Dim obj As New Capa_Entidades.ECBautismo
            Dim Negocio As New Capa_Negocio.NCBautismo

            obj.IdPBautismo = TxtId.Text

            obj.Ba_Numero = TxtBa_Numero.Text
            obj.Ba_Nombre = TxtBa_Nombre.Text
            obj.Ba_Apellido = TxtBa_Apellido.Text

            obj.Ba_LNacimiento = TxtBa_LNacimiento.Text
            obj.Ba_FNacimiento = DateBa_FNacimiento.Text

            obj.Ba_NPadre = TxtBa_NPadre.Text
            obj.Ba_NMadre = TxtBa_NMadre.Text
            obj.Ba_NPadrino = TxtBa_NPadrino.Text
            obj.Ba_LBautismo = TxtBa_LBautismo.Text
            obj.Ba_FBautismo = DateBa_FBautismo.Text
            obj.Ba_AnotacionesTextuales = TxtBa_AnotacionesTextuales.Text

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
                Dim Neg As New Capa_Negocio.NCBautismo
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


End Class