<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParroquia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.TabGeneral = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ChkSeleccionar = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.BtnEliminar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtValor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LblTotal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DgvListado = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnActualizar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtParroquia = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TabGeneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label10.Size = New System.Drawing.Size(824, 44)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Parroquias"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(751, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(73, 44)
        Me.Guna2ControlBox1.TabIndex = 51
        '
        'TabGeneral
        '
        Me.TabGeneral.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.ItemSize = New System.Drawing.Size(180, 40)
        Me.TabGeneral.Location = New System.Drawing.Point(13, 61)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(799, 496)
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
        Me.TabGeneral.TabIndex = 52
        Me.TabGeneral.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.ChkSeleccionar)
        Me.TabPage1.Controls.Add(Me.BtnEliminar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.TxtValor)
        Me.TabPage1.Controls.Add(Me.LblTotal)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(611, 488)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        '
        'ChkSeleccionar
        '
        Me.ChkSeleccionar.AutoSize = True
        Me.ChkSeleccionar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkSeleccionar.CheckedState.BorderRadius = 0
        Me.ChkSeleccionar.CheckedState.BorderThickness = 0
        Me.ChkSeleccionar.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkSeleccionar.Location = New System.Drawing.Point(41, 409)
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
        Me.BtnEliminar.Location = New System.Drawing.Point(164, 409)
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
        Me.BtnBuscar.Location = New System.Drawing.Point(384, 14)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.ShadowDecoration.Parent = Me.BtnBuscar
        Me.BtnBuscar.Size = New System.Drawing.Size(198, 36)
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
        Me.TxtValor.Location = New System.Drawing.Point(16, 14)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtValor.PlaceholderText = ""
        Me.TxtValor.SelectedText = ""
        Me.TxtValor.ShadowDecoration.Parent = Me.TxtValor
        Me.TxtValor.Size = New System.Drawing.Size(362, 36)
        Me.TxtValor.TabIndex = 45
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblTotal.Location = New System.Drawing.Point(317, 409)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(37, 18)
        Me.LblTotal.TabIndex = 1
        Me.LblTotal.Text = "Total: "
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DgvListado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvListado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvListado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvListado.ColumnHeadersHeight = 27
        Me.DgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvListado.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgvListado.EnableHeadersVisualStyles = False
        Me.DgvListado.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvListado.Location = New System.Drawing.Point(16, 74)
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.RowHeadersVisible = False
        Me.DgvListado.RowHeadersWidth = 51
        Me.DgvListado.RowTemplate.Height = 24
        Me.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListado.Size = New System.Drawing.Size(566, 295)
        Me.DgvListado.TabIndex = 0
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
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.BtnGuardar)
        Me.TabPage2.Controls.Add(Me.BtnActualizar)
        Me.TabPage2.Controls.Add(Me.TxtParroquia)
        Me.TabPage2.Controls.Add(Me.TxtId)
        Me.TabPage2.Controls.Add(Me.BtnCancelar)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(611, 488)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Registrar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PictureBox1.Image = Global.Capa_Presentacion.My.Resources.Resources.iglesia
        Me.PictureBox1.Location = New System.Drawing.Point(195, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 122
        Me.PictureBox1.TabStop = False
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
        Me.BtnGuardar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.HoverState.Parent = Me.BtnGuardar
        Me.BtnGuardar.Location = New System.Drawing.Point(337, 350)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.ShadowDecoration.Parent = Me.BtnGuardar
        Me.BtnGuardar.Size = New System.Drawing.Size(195, 45)
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
        Me.BtnActualizar.Location = New System.Drawing.Point(337, 350)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.ShadowDecoration.Parent = Me.BtnActualizar
        Me.BtnActualizar.Size = New System.Drawing.Size(195, 45)
        Me.BtnActualizar.TabIndex = 7
        Me.BtnActualizar.Text = "Actualizar"
        '
        'TxtParroquia
        '
        Me.TxtParroquia.Location = New System.Drawing.Point(88, 270)
        Me.TxtParroquia.Multiline = True
        Me.TxtParroquia.Name = "TxtParroquia"
        Me.TxtParroquia.Size = New System.Drawing.Size(444, 38)
        Me.TxtParroquia.TabIndex = 6
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(432, 233)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 22)
        Me.TxtId.TabIndex = 5
        Me.TxtId.Visible = False
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
        Me.BtnCancelar.Location = New System.Drawing.Point(88, 350)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.ShadowDecoration.Parent = Me.BtnCancelar
        Me.BtnCancelar.Size = New System.Drawing.Size(219, 45)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(85, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Parroquia (*)"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me
        '
        'FrmParroquia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 598)
        Me.Controls.Add(Me.TabGeneral)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmParroquia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmParroquia"
        Me.TabGeneral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents TabGeneral As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ChkSeleccionar As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents BtnEliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBuscar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtValor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LblTotal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DgvListado As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnActualizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtParroquia As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PictureBox1 As PictureBox
End Class
