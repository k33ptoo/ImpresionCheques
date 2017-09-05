<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cheque_detalle
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cheque_detalle))
        Me.Txt_Numero = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Cmb_Cuenta = New System.Windows.Forms.ComboBox()
        Me.dtpOrdenFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Txt_Importe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuiOSSwitch1 = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuiOSSwitch2 = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_Numero
        '
        Me.Txt_Numero.BackColor = System.Drawing.Color.White
        Me.Txt_Numero.Font = New System.Drawing.Font("Century Gothic", 16.5!)
        Me.Txt_Numero.ForeColor = System.Drawing.Color.Black
        Me.Txt_Numero.Location = New System.Drawing.Point(33, 125)
        Me.Txt_Numero.MaxLength = 255
        Me.Txt_Numero.Name = "Txt_Numero"
        Me.Txt_Numero.Size = New System.Drawing.Size(315, 34)
        Me.Txt_Numero.TabIndex = 14
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(33, 100)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 21)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Número"
        '
        'Cmb_Cuenta
        '
        Me.Cmb_Cuenta.BackColor = System.Drawing.Color.White
        Me.Cmb_Cuenta.DisplayMember = "numero"
        Me.Cmb_Cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Cuenta.Font = New System.Drawing.Font("Century Gothic", 16.5!)
        Me.Cmb_Cuenta.ForeColor = System.Drawing.Color.Black
        Me.Cmb_Cuenta.FormattingEnabled = True
        Me.Cmb_Cuenta.Location = New System.Drawing.Point(355, 125)
        Me.Cmb_Cuenta.Name = "Cmb_Cuenta"
        Me.Cmb_Cuenta.Size = New System.Drawing.Size(315, 33)
        Me.Cmb_Cuenta.TabIndex = 128
        Me.Cmb_Cuenta.ValueMember = "id_cuenta"
        '
        'dtpOrdenFecha
        '
        Me.dtpOrdenFecha.Font = New System.Drawing.Font("Century Gothic", 16.5!)
        Me.dtpOrdenFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrdenFecha.Location = New System.Drawing.Point(30, 55)
        Me.dtpOrdenFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpOrdenFecha.Name = "dtpOrdenFecha"
        Me.dtpOrdenFecha.Size = New System.Drawing.Size(155, 34)
        Me.dtpOrdenFecha.TabIndex = 129
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 21)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Emisión"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(190, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 21)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Vencimiento"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Century Gothic", 16.5!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(190, 55)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(155, 34)
        Me.DateTimePicker1.TabIndex = 131
        '
        'Txt_Importe
        '
        Me.Txt_Importe.BackColor = System.Drawing.Color.White
        Me.Txt_Importe.Font = New System.Drawing.Font("Century Gothic", 16.5!)
        Me.Txt_Importe.ForeColor = System.Drawing.Color.Black
        Me.Txt_Importe.Location = New System.Drawing.Point(355, 195)
        Me.Txt_Importe.MaxLength = 255
        Me.Txt_Importe.Name = "Txt_Importe"
        Me.Txt_Importe.Size = New System.Drawing.Size(315, 34)
        Me.Txt_Importe.TabIndex = 134
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(355, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 21)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Importe"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuiOSSwitch1
        '
        Me.BunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuiOSSwitch1.BackgroundImage = CType(resources.GetObject("BunifuiOSSwitch1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuiOSSwitch1.Location = New System.Drawing.Point(290, 265)
        Me.BunifuiOSSwitch1.Name = "BunifuiOSSwitch1"
        Me.BunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray
        Me.BunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BunifuiOSSwitch1.Size = New System.Drawing.Size(35, 20)
        Me.BunifuiOSSwitch1.TabIndex = 135
        Me.BunifuiOSSwitch1.Value = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(355, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 21)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Cuenta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(210, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 21)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Cruzado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(45, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 21)
        Me.Label6.TabIndex = 139
        Me.Label6.Text = "No a la orden"
        '
        'BunifuiOSSwitch2
        '
        Me.BunifuiOSSwitch2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuiOSSwitch2.BackgroundImage = CType(resources.GetObject("BunifuiOSSwitch2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuiOSSwitch2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuiOSSwitch2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuiOSSwitch2.Location = New System.Drawing.Point(160, 265)
        Me.BunifuiOSSwitch2.Name = "BunifuiOSSwitch2"
        Me.BunifuiOSSwitch2.OffColor = System.Drawing.Color.Gray
        Me.BunifuiOSSwitch2.OnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BunifuiOSSwitch2.Size = New System.Drawing.Size(35, 20)
        Me.BunifuiOSSwitch2.TabIndex = 138
        Me.BunifuiOSSwitch2.Value = True
        '
        'TxtProveedor
        '
        Me.TxtProveedor.BackColor = System.Drawing.Color.White
        Me.TxtProveedor.Font = New System.Drawing.Font("Century Gothic", 16.5!)
        Me.TxtProveedor.ForeColor = System.Drawing.Color.Black
        Me.TxtProveedor.Location = New System.Drawing.Point(35, 195)
        Me.TxtProveedor.MaxLength = 255
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(315, 34)
        Me.TxtProveedor.TabIndex = 141
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(35, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 21)
        Me.Label7.TabIndex = 140
        Me.Label7.Text = "Proveedor"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(520, 255)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(150, 40)
        Me.BtnGuardar.TabIndex = 153
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.DarkGray
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(365, 255)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(150, 40)
        Me.BtnCancelar.TabIndex = 154
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox5)
        Me.Panel1.Controls.Add(Me.CheckBox4)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Location = New System.Drawing.Point(355, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 34)
        Me.Panel1.TabIndex = 155
        '
        'CheckBox5
        '
        Me.CheckBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox5.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CheckBox5.FlatAppearance.BorderSize = 0
        Me.CheckBox5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.CheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox5.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.CheckBox5.Location = New System.Drawing.Point(250, 0)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(65, 34)
        Me.CheckBox5.TabIndex = 159
        Me.CheckBox5.Text = "+150d"
        Me.CheckBox5.UseVisualStyleBackColor = False
        '
        'CheckBox4
        '
        Me.CheckBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox4.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CheckBox4.FlatAppearance.BorderSize = 0
        Me.CheckBox4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.CheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.CheckBox4.Location = New System.Drawing.Point(180, 0)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(65, 34)
        Me.CheckBox4.TabIndex = 158
        Me.CheckBox4.Text = "+120d"
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CheckBox3.FlatAppearance.BorderSize = 0
        Me.CheckBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.CheckBox3.Location = New System.Drawing.Point(120, 0)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(55, 34)
        Me.CheckBox3.TabIndex = 157
        Me.CheckBox3.Text = "+90d"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CheckBox2.FlatAppearance.BorderSize = 0
        Me.CheckBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.CheckBox2.Location = New System.Drawing.Point(60, 0)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(55, 34)
        Me.CheckBox2.TabIndex = 156
        Me.CheckBox2.Text = "+60d"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CheckBox1.FlatAppearance.BorderSize = 0
        Me.CheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(0, 0)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(55, 34)
        Me.CheckBox1.TabIndex = 155
        Me.CheckBox1.Text = "+30d"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(355, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 21)
        Me.Label8.TabIndex = 156
        Me.Label8.Text = "Autogenerar"
        '
        'Cheque_detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtProveedor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BunifuiOSSwitch2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuiOSSwitch1)
        Me.Controls.Add(Me.Txt_Importe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpOrdenFecha)
        Me.Controls.Add(Me.Cmb_Cuenta)
        Me.Controls.Add(Me.Txt_Numero)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Cheque_detalle"
        Me.Size = New System.Drawing.Size(710, 325)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Numero As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Cmb_Cuenta As ComboBox
    Friend WithEvents dtpOrdenFecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Txt_Importe As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuiOSSwitch2 As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuiOSSwitch1 As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckBox5 As CheckBox
End Class
