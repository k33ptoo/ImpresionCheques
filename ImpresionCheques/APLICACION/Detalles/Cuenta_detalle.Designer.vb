<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cuenta_detalle
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.Txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Cmb_Banco = New System.Windows.Forms.ComboBox()
        Me.Txt_Observaciones = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.BackColor = System.Drawing.Color.White
        Me.Txt_Nombre.Font = New System.Drawing.Font("Century Gothic", 16.5!)
        Me.Txt_Nombre.ForeColor = System.Drawing.Color.Black
        Me.Txt_Nombre.Location = New System.Drawing.Point(30, 45)
        Me.Txt_Nombre.MaxLength = 255
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(255, 34)
        Me.Txt_Nombre.TabIndex = 14
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(30, 20)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(119, 21)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Tipo / Número"
        '
        'Cmb_Banco
        '
        Me.Cmb_Banco.BackColor = System.Drawing.Color.White
        Me.Cmb_Banco.DisplayMember = "nombre"
        Me.Cmb_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Banco.Font = New System.Drawing.Font("Century Gothic", 16.5!)
        Me.Cmb_Banco.ForeColor = System.Drawing.Color.Black
        Me.Cmb_Banco.FormattingEnabled = True
        Me.Cmb_Banco.Location = New System.Drawing.Point(295, 45)
        Me.Cmb_Banco.Name = "Cmb_Banco"
        Me.Cmb_Banco.Size = New System.Drawing.Size(375, 33)
        Me.Cmb_Banco.TabIndex = 128
        Me.Cmb_Banco.ValueMember = "id_banco"
        '
        'Txt_Observaciones
        '
        Me.Txt_Observaciones.BackColor = System.Drawing.Color.White
        Me.Txt_Observaciones.Font = New System.Drawing.Font("Century Gothic", 16.5!)
        Me.Txt_Observaciones.ForeColor = System.Drawing.Color.Black
        Me.Txt_Observaciones.Location = New System.Drawing.Point(30, 120)
        Me.Txt_Observaciones.MaxLength = 255
        Me.Txt_Observaciones.Multiline = True
        Me.Txt_Observaciones.Name = "Txt_Observaciones"
        Me.Txt_Observaciones.Size = New System.Drawing.Size(640, 70)
        Me.Txt_Observaciones.TabIndex = 134
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(30, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 21)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Observaciones"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(295, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 21)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Banco"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Location = New System.Drawing.Point(520, 216)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(150, 40)
        Me.BtnGuardar.TabIndex = 153
        Me.BtnGuardar.Text = "GUARDAR"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.BackColor = System.Drawing.Color.DarkGray
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(365, 216)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(150, 40)
        Me.BtnCancelar.TabIndex = 154
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'Cuenta_detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_Observaciones)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cmb_Banco)
        Me.Controls.Add(Me.Txt_Nombre)
        Me.Controls.Add(Me.Label31)
        Me.Name = "Cuenta_detalle"
        Me.Size = New System.Drawing.Size(710, 286)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Nombre As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Cmb_Banco As ComboBox
    Friend WithEvents Txt_Observaciones As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label4 As Label
End Class
