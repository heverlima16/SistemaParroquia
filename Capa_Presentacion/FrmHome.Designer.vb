<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHome))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuRegistro = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarNumeroLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarSacerdoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosParroquiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NombreDelUsuarioSegunSuRolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton8 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuRegistro, Me.MenuUsuarios, Me.NombreDelUsuarioSegunSuRolToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.MenuUsuarios
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1371, 31)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MenuRegistro
        '
        Me.MenuRegistro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.RegistrarNumeroLibroToolStripMenuItem, Me.RegistrarSacerdoteToolStripMenuItem})
        Me.MenuRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.MenuRegistro.Image = Global.Capa_Presentacion.My.Resources.Resources.editar
        Me.MenuRegistro.Name = "MenuRegistro"
        Me.MenuRegistro.Size = New System.Drawing.Size(118, 27)
        Me.MenuRegistro.Text = "REGISTROS"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.icono
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.OptionsToolStripMenuItem.Text = "Registrar Iglesias"
        '
        'RegistrarNumeroLibroToolStripMenuItem
        '
        Me.RegistrarNumeroLibroToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.editar
        Me.RegistrarNumeroLibroToolStripMenuItem.Name = "RegistrarNumeroLibroToolStripMenuItem"
        Me.RegistrarNumeroLibroToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.RegistrarNumeroLibroToolStripMenuItem.Text = "Registrar Numero Libro"
        '
        'RegistrarSacerdoteToolStripMenuItem
        '
        Me.RegistrarSacerdoteToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.cliente
        Me.RegistrarSacerdoteToolStripMenuItem.Name = "RegistrarSacerdoteToolStripMenuItem"
        Me.RegistrarSacerdoteToolStripMenuItem.Size = New System.Drawing.Size(247, 26)
        Me.RegistrarSacerdoteToolStripMenuItem.Text = "Registrar Sacerdote"
        '
        'MenuUsuarios
        '
        Me.MenuUsuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosParroquiaToolStripMenuItem})
        Me.MenuUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.MenuUsuarios.Image = Global.Capa_Presentacion.My.Resources.Resources.candado
        Me.MenuUsuarios.Name = "MenuUsuarios"
        Me.MenuUsuarios.Size = New System.Drawing.Size(113, 27)
        Me.MenuUsuarios.Text = "&USUARIOS"
        '
        'UsuariosParroquiaToolStripMenuItem
        '
        Me.UsuariosParroquiaToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.usuario
        Me.UsuariosParroquiaToolStripMenuItem.Name = "UsuariosParroquiaToolStripMenuItem"
        Me.UsuariosParroquiaToolStripMenuItem.Size = New System.Drawing.Size(317, 26)
        Me.UsuariosParroquiaToolStripMenuItem.Text = "Administrar Usuarios de Parroquia"
        '
        'NombreDelUsuarioSegunSuRolToolStripMenuItem
        '
        Me.NombreDelUsuarioSegunSuRolToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.NombreDelUsuarioSegunSuRolToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.NombreDelUsuarioSegunSuRolToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.usuario
        Me.NombreDelUsuarioSegunSuRolToolStripMenuItem.Name = "NombreDelUsuarioSegunSuRolToolStripMenuItem"
        Me.NombreDelUsuarioSegunSuRolToolStripMenuItem.Size = New System.Drawing.Size(304, 27)
        Me.NombreDelUsuarioSegunSuRolToolStripMenuItem.Text = "Nombre del usuario segun su rol"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripStatusLabel1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 671)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1371, 26)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(349, 20)
        Me.ToolStripStatusLabel.Text = "Todos los derechos Parroquia San Pedro de Pampas"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.IconButton3)
        Me.PanelMenu.Controls.Add(Me.IconButton1)
        Me.PanelMenu.Controls.Add(Me.IconButton8)
        Me.PanelMenu.Controls.Add(Me.IconButton4)
        Me.PanelMenu.Controls.Add(Me.IconButton6)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 31)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(283, 640)
        Me.PanelMenu.TabIndex = 11
        '
        'IconButton3
        '
        Me.IconButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconButton3.IconColor = System.Drawing.Color.Red
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 32
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(0, 390)
        Me.IconButton3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Padding = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.IconButton3.Size = New System.Drawing.Size(283, 60)
        Me.IconButton3.TabIndex = 22
        Me.IconButton3.Text = "Cerrar Sesión"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.IconButton1.IconColor = System.Drawing.Color.Orange
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 32
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 330)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.IconButton1.Size = New System.Drawing.Size(283, 60)
        Me.IconButton1.TabIndex = 21
        Me.IconButton1.Text = "Generar Partida de Matrimonio"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconButton8
        '
        Me.IconButton8.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton8.FlatAppearance.BorderSize = 0
        Me.IconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton8.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.IconButton8.IconColor = System.Drawing.Color.Gold
        Me.IconButton8.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton8.IconSize = 32
        Me.IconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton8.Location = New System.Drawing.Point(0, 270)
        Me.IconButton8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconButton8.Name = "IconButton8"
        Me.IconButton8.Padding = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.IconButton8.Size = New System.Drawing.Size(283, 60)
        Me.IconButton8.TabIndex = 19
        Me.IconButton8.Text = "Generar Partida de Bautismo"
        Me.IconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton8.UseVisualStyleBackColor = True
        '
        'IconButton4
        '
        Me.IconButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Keyboard
        Me.IconButton4.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 32
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(0, 210)
        Me.IconButton4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Padding = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.IconButton4.Size = New System.Drawing.Size(283, 60)
        Me.IconButton4.TabIndex = 17
        Me.IconButton4.Text = "Digitalizar Bautizados"
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'IconButton6
        '
        Me.IconButton6.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton6.FlatAppearance.BorderSize = 0
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.Keyboard
        Me.IconButton6.IconColor = System.Drawing.Color.Lime
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton6.IconSize = 32
        Me.IconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.Location = New System.Drawing.Point(0, 150)
        Me.IconButton6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Padding = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.IconButton6.Size = New System.Drawing.Size(283, 60)
        Me.IconButton6.TabIndex = 11
        Me.IconButton6.Text = "Digitalizar Matrimonio"
        Me.IconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton6.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(283, 150)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Capa_Presentacion.My.Resources.Resources.iglesia
        Me.PictureBox1.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 697)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmHome"
        Me.Text = "SISTEMA  - PARROQUIA SAN PEDRO DE PAMPAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsuariosParroquiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuRegistro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarNumeroLibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NombreDelUsuarioSegunSuRolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents RegistrarSacerdoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton8 As FontAwesome.Sharp.IconButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
