<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGivePartBautis
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
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.BtnSearchUser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(72, 134)
        Me.TxtDNI.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(304, 22)
        Me.TxtDNI.TabIndex = 2
        '
        'BtnSearchUser
        '
        Me.BtnSearchUser.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.BtnSearchUser.AutoSize = True
        Me.BtnSearchUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSearchUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSearchUser.Location = New System.Drawing.Point(396, 119)
        Me.BtnSearchUser.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnSearchUser.Name = "BtnSearchUser"
        Me.BtnSearchUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSearchUser.Size = New System.Drawing.Size(175, 58)
        Me.BtnSearchUser.TabIndex = 3
        Me.BtnSearchUser.Text = "Buscar"
        Me.BtnSearchUser.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingrese Nombre del Interesado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "GENERAR PARTIDA DE BAUTISMO"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DataGridView1.Location = New System.Drawing.Point(70, 187)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(1028, 312)
        Me.DataGridView1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(70, 537)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(287, 85)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "ABRIR FOLDER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(381, 504)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(631, 49)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Pasos para  Generar el Documento:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(430, 537)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(265, 60)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "1. Ingrese el nombre a buscar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. As click en el icono buscar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. Seleccione al " &
    "usuario."
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(367, 606)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(719, 65)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nota: Al Seleccionar, va salir un mensaje con la cual esta confirmando que se gen" &
    "ero satisfactoriamente!!." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1064, 0)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
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
        Me.Label10.Size = New System.Drawing.Size(1160, 54)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Generar Partida de Bautismo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me
        '
        'FrmGivePartBautis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1160, 680)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSearchUser)
        Me.Controls.Add(Me.TxtDNI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmGivePartBautis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmGivePartBautis"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents BtnSearchUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
