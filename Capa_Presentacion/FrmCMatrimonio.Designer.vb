<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCMatrimonio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabGeneral = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DgvListado = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ChkSeleccionar = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.BtnEliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtValor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblTotal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtMa_NFoja = New System.Windows.Forms.TextBox()
        Me.TxtMa_AnotacionesTextuales = New System.Windows.Forms.TextBox()
        Me.TxtNumeroCasado = New System.Windows.Forms.TextBox()
        Me.CboLibro = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DateMa_FMatrimonio = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.TxtMa_LMatrimonio = New System.Windows.Forms.TextBox()
        Me.TxtMa_NPadrino = New System.Windows.Forms.TextBox()
        Me.TxtMa_NMadreEsposa = New System.Windows.Forms.TextBox()
        Me.TxtMa_NMadreEsposo = New System.Windows.Forms.TextBox()
        Me.TxtMa_NPadreEsposa = New System.Windows.Forms.TextBox()
        Me.TxtMa_NPadreEsposo = New System.Windows.Forms.TextBox()
        Me.TxtMa_LEsposa = New System.Windows.Forms.TextBox()
        Me.DateMa_FNEsposa = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.TxtMa_LEsposo = New System.Windows.Forms.TextBox()
        Me.DateMa_FNEsposo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.TxtMa_NEsposa = New System.Windows.Forms.TextBox()
        Me.TxtMa_NEsposo = New System.Windows.Forms.TextBox()
        Me.CboSacerdote = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CboParroquia = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnActualizar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabGeneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2ControlBox1.BorderRadius = 1
        Me.Guna2ControlBox1.CustomIconSize = 15.0!
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1150, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(73, 44)
        Me.Guna2ControlBox1.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1223, 44)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "DIGITALIZAR CARTA DE MATRIMONIO"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabGeneral
        '
        Me.TabGeneral.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.ItemSize = New System.Drawing.Size(180, 40)
        Me.TabGeneral.Location = New System.Drawing.Point(12, 50)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(1199, 705)
        Me.TabGeneral.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TabGeneral.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabGeneral.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabGeneral.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TabGeneral.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabGeneral.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TabGeneral.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabGeneral.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabGeneral.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TabGeneral.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabGeneral.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TabGeneral.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabGeneral.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabGeneral.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TabGeneral.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabGeneral.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.TabGeneral.TabIndex = 55
        Me.TabGeneral.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Controls.Add(Me.ChkSeleccionar)
        Me.TabPage1.Controls.Add(Me.BtnEliminar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.TxtValor)
        Me.TabPage1.Controls.Add(Me.LblTotal)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1011, 697)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.AllowUserToOrderColumns = True
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.DgvListado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvListado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DgvListado.ColumnHeadersHeight = 27
        Me.DgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvListado.DefaultCellStyle = DataGridViewCellStyle15
        Me.DgvListado.EnableHeadersVisualStyles = False
        Me.DgvListado.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvListado.Location = New System.Drawing.Point(6, 108)
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.RowHeadersVisible = False
        Me.DgvListado.RowHeadersWidth = 51
        Me.DgvListado.RowTemplate.Height = 24
        Me.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListado.Size = New System.Drawing.Size(971, 476)
        Me.DgvListado.TabIndex = 49
        Me.DgvListado.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvListado.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvListado.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvListado.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvListado.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvListado.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DgvListado.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvListado.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvListado.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvListado.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvListado.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvListado.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvListado.ThemeStyle.HeaderStyle.Height = 27
        Me.DgvListado.ThemeStyle.ReadOnly = True
        Me.DgvListado.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvListado.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvListado.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvListado.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvListado.ThemeStyle.RowsStyle.Height = 24
        Me.DgvListado.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvListado.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.MinimumWidth = 6
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'ChkSeleccionar
        '
        Me.ChkSeleccionar.AutoSize = True
        Me.ChkSeleccionar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkSeleccionar.CheckedState.BorderRadius = 0
        Me.ChkSeleccionar.CheckedState.BorderThickness = 0
        Me.ChkSeleccionar.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkSeleccionar.Location = New System.Drawing.Point(39, 625)
        Me.ChkSeleccionar.Name = "ChkSeleccionar"
        Me.ChkSeleccionar.Size = New System.Drawing.Size(104, 21)
        Me.ChkSeleccionar.TabIndex = 48
        Me.ChkSeleccionar.Text = "Seleccionar"
        Me.ChkSeleccionar.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkSeleccionar.UncheckedState.BorderRadius = 0
        Me.ChkSeleccionar.UncheckedState.BorderThickness = 0
        Me.ChkSeleccionar.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'BtnEliminar
        '
        Me.BtnEliminar.CheckedState.Parent = Me.BtnEliminar
        Me.BtnEliminar.CustomImages.Parent = Me.BtnEliminar
        Me.BtnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnEliminar.DisabledState.Parent = Me.BtnEliminar
        Me.BtnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.HoverState.Parent = Me.BtnEliminar
        Me.BtnEliminar.Location = New System.Drawing.Point(162, 625)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.ShadowDecoration.Parent = Me.BtnEliminar
        Me.BtnEliminar.Size = New System.Drawing.Size(129, 36)
        Me.BtnEliminar.TabIndex = 47
        Me.BtnEliminar.Text = "Eliminar"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.CheckedState.Parent = Me.BtnBuscar
        Me.BtnBuscar.CustomImages.Parent = Me.BtnBuscar
        Me.BtnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnBuscar.DisabledState.Parent = Me.BtnBuscar
        Me.BtnBuscar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.HoverState.Parent = Me.BtnBuscar
        Me.BtnBuscar.Location = New System.Drawing.Point(632, 36)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.ShadowDecoration.Parent = Me.BtnBuscar
        Me.BtnBuscar.Size = New System.Drawing.Size(345, 36)
        Me.BtnBuscar.TabIndex = 46
        Me.BtnBuscar.Text = "Buscar"
        '
        'TxtValor
        '
        Me.TxtValor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtValor.DefaultText = ""
        Me.TxtValor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtValor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtValor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtValor.DisabledState.Parent = Me.TxtValor
        Me.TxtValor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtValor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtValor.FocusedState.Parent = Me.TxtValor
        Me.TxtValor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtValor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtValor.HoverState.Parent = Me.TxtValor
        Me.TxtValor.Location = New System.Drawing.Point(6, 36)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtValor.PlaceholderText = ""
        Me.TxtValor.SelectedText = ""
        Me.TxtValor.ShadowDecoration.Parent = Me.TxtValor
        Me.TxtValor.Size = New System.Drawing.Size(620, 36)
        Me.TxtValor.TabIndex = 45
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblTotal.Location = New System.Drawing.Point(843, 625)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(37, 18)
        Me.LblTotal.TabIndex = 1
        Me.LblTotal.Text = "Total: "
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.TxtMa_NFoja)
        Me.TabPage2.Controls.Add(Me.TxtMa_AnotacionesTextuales)
        Me.TabPage2.Controls.Add(Me.TxtNumeroCasado)
        Me.TabPage2.Controls.Add(Me.CboLibro)
        Me.TabPage2.Controls.Add(Me.DateMa_FMatrimonio)
        Me.TabPage2.Controls.Add(Me.TxtMa_LMatrimonio)
        Me.TabPage2.Controls.Add(Me.TxtMa_NPadrino)
        Me.TabPage2.Controls.Add(Me.TxtMa_NMadreEsposa)
        Me.TabPage2.Controls.Add(Me.TxtMa_NMadreEsposo)
        Me.TabPage2.Controls.Add(Me.TxtMa_NPadreEsposa)
        Me.TabPage2.Controls.Add(Me.TxtMa_NPadreEsposo)
        Me.TabPage2.Controls.Add(Me.TxtMa_LEsposa)
        Me.TabPage2.Controls.Add(Me.DateMa_FNEsposa)
        Me.TabPage2.Controls.Add(Me.TxtMa_LEsposo)
        Me.TabPage2.Controls.Add(Me.DateMa_FNEsposo)
        Me.TabPage2.Controls.Add(Me.TxtMa_NEsposa)
        Me.TabPage2.Controls.Add(Me.TxtMa_NEsposo)
        Me.TabPage2.Controls.Add(Me.CboSacerdote)
        Me.TabPage2.Controls.Add(Me.CboParroquia)
        Me.TabPage2.Controls.Add(Me.TxtId)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.BtnGuardar)
        Me.TabPage2.Controls.Add(Me.BtnActualizar)
        Me.TabPage2.Controls.Add(Me.BtnCancelar)
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1011, 697)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Registrar"
        '
        'TxtMa_NFoja
        '
        Me.TxtMa_NFoja.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.TxtMa_NFoja.Location = New System.Drawing.Point(145, 627)
        Me.TxtMa_NFoja.Multiline = True
        Me.TxtMa_NFoja.Name = "TxtMa_NFoja"
        Me.TxtMa_NFoja.Size = New System.Drawing.Size(92, 36)
        Me.TxtMa_NFoja.TabIndex = 81
        '
        'TxtMa_AnotacionesTextuales
        '
        Me.TxtMa_AnotacionesTextuales.Location = New System.Drawing.Point(520, 513)
        Me.TxtMa_AnotacionesTextuales.Multiline = True
        Me.TxtMa_AnotacionesTextuales.Name = "TxtMa_AnotacionesTextuales"
        Me.TxtMa_AnotacionesTextuales.Size = New System.Drawing.Size(427, 94)
        Me.TxtMa_AnotacionesTextuales.TabIndex = 80
        '
        'TxtNumeroCasado
        '
        Me.TxtNumeroCasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.TxtNumeroCasado.Location = New System.Drawing.Point(265, 627)
        Me.TxtNumeroCasado.Multiline = True
        Me.TxtNumeroCasado.Name = "TxtNumeroCasado"
        Me.TxtNumeroCasado.Size = New System.Drawing.Size(109, 36)
        Me.TxtNumeroCasado.TabIndex = 79
        '
        'CboLibro
        '
        Me.CboLibro.BackColor = System.Drawing.Color.Transparent
        Me.CboLibro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CboLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLibro.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboLibro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboLibro.FocusedState.Parent = Me.CboLibro
        Me.CboLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold)
        Me.CboLibro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CboLibro.HoverState.Parent = Me.CboLibro
        Me.CboLibro.ItemHeight = 30
        Me.CboLibro.ItemsAppearance.Parent = Me.CboLibro
        Me.CboLibro.Location = New System.Drawing.Point(46, 627)
        Me.CboLibro.Name = "CboLibro"
        Me.CboLibro.ShadowDecoration.Parent = Me.CboLibro
        Me.CboLibro.Size = New System.Drawing.Size(93, 36)
        Me.CboLibro.TabIndex = 77
        '
        'DateMa_FMatrimonio
        '
        Me.DateMa_FMatrimonio.CheckedState.Parent = Me.DateMa_FMatrimonio
        Me.DateMa_FMatrimonio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateMa_FMatrimonio.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateMa_FMatrimonio.HoverState.Parent = Me.DateMa_FMatrimonio
        Me.DateMa_FMatrimonio.Location = New System.Drawing.Point(47, 552)
        Me.DateMa_FMatrimonio.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateMa_FMatrimonio.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateMa_FMatrimonio.Name = "DateMa_FMatrimonio"
        Me.DateMa_FMatrimonio.ShadowDecoration.Parent = Me.DateMa_FMatrimonio
        Me.DateMa_FMatrimonio.Size = New System.Drawing.Size(310, 36)
        Me.DateMa_FMatrimonio.TabIndex = 76
        Me.DateMa_FMatrimonio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DateMa_FMatrimonio.Value = New Date(2021, 9, 8, 15, 36, 24, 541)
        '
        'TxtMa_LMatrimonio
        '
        Me.TxtMa_LMatrimonio.Location = New System.Drawing.Point(209, 485)
        Me.TxtMa_LMatrimonio.Multiline = True
        Me.TxtMa_LMatrimonio.Name = "TxtMa_LMatrimonio"
        Me.TxtMa_LMatrimonio.Size = New System.Drawing.Size(271, 26)
        Me.TxtMa_LMatrimonio.TabIndex = 75
        '
        'TxtMa_NPadrino
        '
        Me.TxtMa_NPadrino.Location = New System.Drawing.Point(50, 446)
        Me.TxtMa_NPadrino.Multiline = True
        Me.TxtMa_NPadrino.Name = "TxtMa_NPadrino"
        Me.TxtMa_NPadrino.Size = New System.Drawing.Size(427, 26)
        Me.TxtMa_NPadrino.TabIndex = 74
        '
        'TxtMa_NMadreEsposa
        '
        Me.TxtMa_NMadreEsposa.Location = New System.Drawing.Point(520, 387)
        Me.TxtMa_NMadreEsposa.Multiline = True
        Me.TxtMa_NMadreEsposa.Name = "TxtMa_NMadreEsposa"
        Me.TxtMa_NMadreEsposa.Size = New System.Drawing.Size(427, 26)
        Me.TxtMa_NMadreEsposa.TabIndex = 73
        '
        'TxtMa_NMadreEsposo
        '
        Me.TxtMa_NMadreEsposo.Location = New System.Drawing.Point(50, 387)
        Me.TxtMa_NMadreEsposo.Multiline = True
        Me.TxtMa_NMadreEsposo.Name = "TxtMa_NMadreEsposo"
        Me.TxtMa_NMadreEsposo.Size = New System.Drawing.Size(427, 26)
        Me.TxtMa_NMadreEsposo.TabIndex = 72
        '
        'TxtMa_NPadreEsposa
        '
        Me.TxtMa_NPadreEsposa.Location = New System.Drawing.Point(520, 307)
        Me.TxtMa_NPadreEsposa.Multiline = True
        Me.TxtMa_NPadreEsposa.Name = "TxtMa_NPadreEsposa"
        Me.TxtMa_NPadreEsposa.Size = New System.Drawing.Size(427, 26)
        Me.TxtMa_NPadreEsposa.TabIndex = 71
        '
        'TxtMa_NPadreEsposo
        '
        Me.TxtMa_NPadreEsposo.Location = New System.Drawing.Point(47, 307)
        Me.TxtMa_NPadreEsposo.Multiline = True
        Me.TxtMa_NPadreEsposo.Name = "TxtMa_NPadreEsposo"
        Me.TxtMa_NPadreEsposo.Size = New System.Drawing.Size(427, 26)
        Me.TxtMa_NPadreEsposo.TabIndex = 70
        '
        'TxtMa_LEsposa
        '
        Me.TxtMa_LEsposa.Location = New System.Drawing.Point(815, 217)
        Me.TxtMa_LEsposa.Multiline = True
        Me.TxtMa_LEsposa.Name = "TxtMa_LEsposa"
        Me.TxtMa_LEsposa.Size = New System.Drawing.Size(132, 36)
        Me.TxtMa_LEsposa.TabIndex = 69
        '
        'DateMa_FNEsposa
        '
        Me.DateMa_FNEsposa.CheckedState.Parent = Me.DateMa_FNEsposa
        Me.DateMa_FNEsposa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateMa_FNEsposa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateMa_FNEsposa.HoverState.Parent = Me.DateMa_FNEsposa
        Me.DateMa_FNEsposa.Location = New System.Drawing.Point(520, 217)
        Me.DateMa_FNEsposa.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateMa_FNEsposa.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateMa_FNEsposa.Name = "DateMa_FNEsposa"
        Me.DateMa_FNEsposa.ShadowDecoration.Parent = Me.DateMa_FNEsposa
        Me.DateMa_FNEsposa.Size = New System.Drawing.Size(166, 36)
        Me.DateMa_FNEsposa.TabIndex = 68
        Me.DateMa_FNEsposa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DateMa_FNEsposa.Value = New Date(2021, 9, 8, 15, 36, 24, 541)
        '
        'TxtMa_LEsposo
        '
        Me.TxtMa_LEsposo.Location = New System.Drawing.Point(345, 217)
        Me.TxtMa_LEsposo.Multiline = True
        Me.TxtMa_LEsposo.Name = "TxtMa_LEsposo"
        Me.TxtMa_LEsposo.Size = New System.Drawing.Size(132, 36)
        Me.TxtMa_LEsposo.TabIndex = 67
        '
        'DateMa_FNEsposo
        '
        Me.DateMa_FNEsposo.CheckedState.Parent = Me.DateMa_FNEsposo
        Me.DateMa_FNEsposo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateMa_FNEsposo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateMa_FNEsposo.HoverState.Parent = Me.DateMa_FNEsposo
        Me.DateMa_FNEsposo.Location = New System.Drawing.Point(46, 217)
        Me.DateMa_FNEsposo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateMa_FNEsposo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateMa_FNEsposo.Name = "DateMa_FNEsposo"
        Me.DateMa_FNEsposo.ShadowDecoration.Parent = Me.DateMa_FNEsposo
        Me.DateMa_FNEsposo.Size = New System.Drawing.Size(157, 36)
        Me.DateMa_FNEsposo.TabIndex = 66
        Me.DateMa_FNEsposo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DateMa_FNEsposo.Value = New Date(2021, 9, 8, 15, 36, 24, 541)
        '
        'TxtMa_NEsposa
        '
        Me.TxtMa_NEsposa.Location = New System.Drawing.Point(520, 153)
        Me.TxtMa_NEsposa.Multiline = True
        Me.TxtMa_NEsposa.Name = "TxtMa_NEsposa"
        Me.TxtMa_NEsposa.Size = New System.Drawing.Size(427, 26)
        Me.TxtMa_NEsposa.TabIndex = 65
        '
        'TxtMa_NEsposo
        '
        Me.TxtMa_NEsposo.Location = New System.Drawing.Point(47, 153)
        Me.TxtMa_NEsposo.Multiline = True
        Me.TxtMa_NEsposo.Name = "TxtMa_NEsposo"
        Me.TxtMa_NEsposo.Size = New System.Drawing.Size(427, 26)
        Me.TxtMa_NEsposo.TabIndex = 64
        '
        'CboSacerdote
        '
        Me.CboSacerdote.BackColor = System.Drawing.Color.Transparent
        Me.CboSacerdote.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CboSacerdote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSacerdote.FillColor = System.Drawing.Color.Beige
        Me.CboSacerdote.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboSacerdote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboSacerdote.FocusedState.Parent = Me.CboSacerdote
        Me.CboSacerdote.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CboSacerdote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CboSacerdote.HoverState.Parent = Me.CboSacerdote
        Me.CboSacerdote.ItemHeight = 30
        Me.CboSacerdote.ItemsAppearance.Parent = Me.CboSacerdote
        Me.CboSacerdote.Location = New System.Drawing.Point(520, 80)
        Me.CboSacerdote.Name = "CboSacerdote"
        Me.CboSacerdote.ShadowDecoration.Parent = Me.CboSacerdote
        Me.CboSacerdote.Size = New System.Drawing.Size(427, 36)
        Me.CboSacerdote.TabIndex = 63
        '
        'CboParroquia
        '
        Me.CboParroquia.BackColor = System.Drawing.Color.Transparent
        Me.CboParroquia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CboParroquia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboParroquia.FillColor = System.Drawing.Color.Beige
        Me.CboParroquia.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboParroquia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CboParroquia.FocusedState.Parent = Me.CboParroquia
        Me.CboParroquia.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CboParroquia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CboParroquia.HoverState.Parent = Me.CboParroquia
        Me.CboParroquia.ItemHeight = 30
        Me.CboParroquia.ItemsAppearance.Parent = Me.CboParroquia
        Me.CboParroquia.Location = New System.Drawing.Point(49, 80)
        Me.CboParroquia.Name = "CboParroquia"
        Me.CboParroquia.ShadowDecoration.Parent = Me.CboParroquia
        Me.CboParroquia.Size = New System.Drawing.Size(427, 36)
        Me.CboParroquia.TabIndex = 62
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(847, 24)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 22)
        Me.TxtId.TabIndex = 61
        Me.TxtId.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(517, 476)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 17)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "Anotaciones"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(46, 197)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(160, 17)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "Fecha de Nacimiento (*)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(526, 197)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(160, 17)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Fecha de Nacimiento (*)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(47, 532)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(159, 17)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Fecha de Matrimonio (*)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(46, 488)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 17)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Lugar de Matrimonio (*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(46, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Padrino (*)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(517, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Madre esposa (*)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(517, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Padre esposa (*)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(46, 349)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 17)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Madre del esposo (*)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(46, 271)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 17)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Padre del esposo (*)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(517, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(260, 17)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Nombre del sacerdote de Matrimonio (*)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(46, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(182, 17)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Parroquia de Matrimonio (*)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(517, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 17)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Nombre esposa (*)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(46, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Nombre esposo (*)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(262, 603)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "N° Casado (*)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(145, 603)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "N° Foja (*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(44, 603)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "N° Libro (*)"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.CheckedState.Parent = Me.BtnGuardar
        Me.BtnGuardar.CustomImages.Parent = Me.BtnGuardar
        Me.BtnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnGuardar.DisabledState.Parent = Me.BtnGuardar
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.HoverState.Parent = Me.BtnGuardar
        Me.BtnGuardar.Location = New System.Drawing.Point(665, 627)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.ShadowDecoration.Parent = Me.BtnGuardar
        Me.BtnGuardar.Size = New System.Drawing.Size(282, 45)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.CheckedState.Parent = Me.BtnActualizar
        Me.BtnActualizar.CustomImages.Parent = Me.BtnActualizar
        Me.BtnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnActualizar.DisabledState.Parent = Me.BtnActualizar
        Me.BtnActualizar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.HoverState.Parent = Me.BtnActualizar
        Me.BtnActualizar.Location = New System.Drawing.Point(665, 627)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.ShadowDecoration.Parent = Me.BtnActualizar
        Me.BtnActualizar.Size = New System.Drawing.Size(282, 45)
        Me.BtnActualizar.TabIndex = 7
        Me.BtnActualizar.Text = "Actualizar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.CheckedState.Parent = Me.BtnCancelar
        Me.BtnCancelar.CustomImages.Parent = Me.BtnCancelar
        Me.BtnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCancelar.DisabledState.Parent = Me.BtnCancelar
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.HoverState.Parent = Me.BtnCancelar
        Me.BtnCancelar.Location = New System.Drawing.Point(520, 627)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.ShadowDecoration.Parent = Me.BtnCancelar
        Me.BtnCancelar.Size = New System.Drawing.Size(124, 45)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Cancelar"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'FrmCMatrimonio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1223, 784)
        Me.Controls.Add(Me.TabGeneral)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCMatrimonio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCMatrimonio"
        Me.TabGeneral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TabGeneral As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ChkSeleccionar As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents BtnEliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtValor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblTotal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnActualizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DgvListado As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TxtId As TextBox
    Friend WithEvents CboParroquia As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CboSacerdote As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtMa_NEsposo As TextBox
    Friend WithEvents TxtMa_NEsposa As TextBox
    Friend WithEvents DateMa_FNEsposo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents TxtMa_LEsposo As TextBox
    Friend WithEvents DateMa_FNEsposa As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents TxtMa_LEsposa As TextBox
    Friend WithEvents TxtMa_NPadreEsposo As TextBox
    Friend WithEvents TxtMa_NPadreEsposa As TextBox
    Friend WithEvents TxtMa_NMadreEsposo As TextBox
    Friend WithEvents TxtMa_NMadreEsposa As TextBox
    Friend WithEvents TxtMa_NPadrino As TextBox
    Friend WithEvents TxtMa_LMatrimonio As TextBox
    Friend WithEvents DateMa_FMatrimonio As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents CboLibro As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TxtNumeroCasado As TextBox
    Friend WithEvents TxtMa_AnotacionesTextuales As TextBox
    Friend WithEvents TxtMa_NFoja As TextBox
End Class
