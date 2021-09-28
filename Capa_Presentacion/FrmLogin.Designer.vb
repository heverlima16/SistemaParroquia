<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Txt_Usuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Txt_Clave = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_IniciarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 25
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.TransparentWhileDrag = True
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Usuario.Animated = True
        Me.Txt_Usuario.BorderRadius = 13
        Me.Txt_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Usuario.DefaultText = ""
        Me.Txt_Usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_Usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_Usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Usuario.DisabledState.Parent = Me.Txt_Usuario
        Me.Txt_Usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Usuario.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Txt_Usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Usuario.FocusedState.Parent = Me.Txt_Usuario
        Me.Txt_Usuario.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Usuario.ForeColor = System.Drawing.SystemColors.Window
        Me.Txt_Usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Usuario.HoverState.Parent = Me.Txt_Usuario
        Me.Txt_Usuario.Location = New System.Drawing.Point(667, 280)
        Me.Txt_Usuario.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Usuario.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.Txt_Usuario.PlaceholderText = "Digite Su Usuario"
        Me.Txt_Usuario.SelectedText = ""
        Me.Txt_Usuario.ShadowDecoration.Parent = Me.Txt_Usuario
        Me.Txt_Usuario.Size = New System.Drawing.Size(367, 41)
        Me.Txt_Usuario.TabIndex = 115
        Me.Txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Clave
        '
        Me.Txt_Clave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Clave.Animated = True
        Me.Txt_Clave.BorderRadius = 13
        Me.Txt_Clave.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Clave.DefaultText = ""
        Me.Txt_Clave.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_Clave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_Clave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Clave.DisabledState.Parent = Me.Txt_Clave
        Me.Txt_Clave.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_Clave.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Txt_Clave.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Clave.FocusedState.Parent = Me.Txt_Clave
        Me.Txt_Clave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Clave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Txt_Clave.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Clave.HoverState.Parent = Me.Txt_Clave
        Me.Txt_Clave.Location = New System.Drawing.Point(667, 338)
        Me.Txt_Clave.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Txt_Clave.Name = "Txt_Clave"
        Me.Txt_Clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Clave.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.Txt_Clave.PlaceholderText = "Contraseña"
        Me.Txt_Clave.SelectedText = ""
        Me.Txt_Clave.ShadowDecoration.Parent = Me.Txt_Clave
        Me.Txt_Clave.Size = New System.Drawing.Size(367, 41)
        Me.Txt_Clave.TabIndex = 116
        Me.Txt_Clave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_IniciarSesion
        '
        Me.btn_IniciarSesion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_IniciarSesion.Animated = True
        Me.btn_IniciarSesion.BorderRadius = 18
        Me.btn_IniciarSesion.CheckedState.Parent = Me.btn_IniciarSesion
        Me.btn_IniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_IniciarSesion.CustomImages.Parent = Me.btn_IniciarSesion
        Me.btn_IniciarSesion.DisabledState.Parent = Me.btn_IniciarSesion
        Me.btn_IniciarSesion.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btn_IniciarSesion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btn_IniciarSesion.ForeColor = System.Drawing.Color.White
        Me.btn_IniciarSesion.HoverState.Parent = Me.btn_IniciarSesion
        Me.btn_IniciarSesion.Location = New System.Drawing.Point(781, 397)
        Me.btn_IniciarSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_IniciarSesion.Name = "btn_IniciarSesion"
        Me.btn_IniciarSesion.ShadowDecoration.Parent = Me.btn_IniciarSesion
        Me.btn_IniciarSesion.Size = New System.Drawing.Size(253, 53)
        Me.btn_IniciarSesion.TabIndex = 118
        Me.btn_IniciarSesion.Text = "Iniciar Sesión"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BorderRadius = 18
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.DisabledState.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(667, 397)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(107, 53)
        Me.Guna2Button1.TabIndex = 119
        Me.Guna2Button1.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(749, 472)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 19)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Parroquia San Pedro de Pampas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 481)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Dios es Amor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(58, 424)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(384, 35)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Parroquia San Pedro de Pampas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(176, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 35)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Bienvenido"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Silver
        Me.PictureBox2.Image = Global.Capa_Presentacion.My.Resources.Resources.user
        Me.PictureBox2.Location = New System.Drawing.Point(732, 88)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(232, 171)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 123
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.PictureBox1.Image = Global.Capa_Presentacion.My.Resources.Resources.iglesia
        Me.PictureBox1.Location = New System.Drawing.Point(124, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 309)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 121
        Me.PictureBox1.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(530, 596)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1147, 596)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btn_IniciarSesion)
        Me.Controls.Add(Me.Txt_Clave)
        Me.Controls.Add(Me.Txt_Usuario)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1920, 1020)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso al sistema"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btn_IniciarSesion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Txt_Clave As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Txt_Usuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
