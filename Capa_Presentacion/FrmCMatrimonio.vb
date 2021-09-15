Public Class FrmCMatrimonio
    Private Sub FrmCMatrimonio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.listar()
        Me.CargarParroquia()
        Me.CargarSacerdote()
        Me.CargarFoja()
        Me.CargarLibro()

    End Sub


    'Hever Lima
    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(1).Visible = False

        BtnEliminar.Visible = False
        ChkSeleccionar.Checked = False
        DgvListado.Columns(0).Width = 0
        DgvListado.Columns(1).Width = 100
        DgvListado.Columns(2).Width = 100
        DgvListado.Columns(3).Width = 100

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
        CboFoja.Text = ""
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
        If Me.ValidateChildren = True And TxtMa_NEsposo.Text <> "" And CboParroquia.Text <> "" Then
            Dim obj As New Capa_Entidades.ECMatrimonio
            Dim Negocio As New Capa_Negocio.NCMatrimonio
            'recibe datos


            obj.IdFoja = CboFoja.SelectedValue
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

    Private Sub TxtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtMa_NEsposo.Validating
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
            obj.IdFoja = CboFoja.SelectedValue
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



    Private Sub DgvListado_DoubleClick(sender As Object, e As EventArgs) Handles DgvListado.DoubleClick
        TxtId.Text = DgvListado.SelectedCells.Item(1).Value
        TxtMa_NEsposo.Text = DgvListado.SelectedCells.Item(2).Value
        BtnGuardar.Visible = False
        BtnActualizar.Visible = True
        TabGeneral.SelectedIndex = 1
    End Sub
End Class