<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Buscar_UC1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Buscar_UC1))
        Me.BtnActualizar = New Bunifu.Framework.UI.BunifuTileButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Buscar = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnActualizar.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnActualizar.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActualizar.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImagePosition = 6
        Me.BtnActualizar.ImageZoom = 60
        Me.BtnActualizar.LabelPosition = 0
        Me.BtnActualizar.LabelText = ""
        Me.BtnActualizar.Location = New System.Drawing.Point(220, 10)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(6)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(25, 27)
        Me.BtnActualizar.TabIndex = 124
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(10, 8)
        Me.TextBox1.MaxLength = 8
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 30)
        Me.TextBox1.TabIndex = 126
        Me.TextBox1.Text = "Buscar..."
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.BtnActualizar)
        Me.Panel1.Location = New System.Drawing.Point(55, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 50)
        Me.Panel1.TabIndex = 127
        Me.Panel1.Visible = False
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Btn_Buscar.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Btn_Buscar.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Buscar.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.Btn_Buscar.ForeColor = System.Drawing.Color.White
        Me.Btn_Buscar.Image = CType(resources.GetObject("Btn_Buscar.Image"), System.Drawing.Image)
        Me.Btn_Buscar.ImagePosition = 7
        Me.Btn_Buscar.ImageZoom = 60
        Me.Btn_Buscar.LabelPosition = 0
        Me.Btn_Buscar.LabelText = ""
        Me.Btn_Buscar.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Buscar.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(55, 50)
        Me.Btn_Buscar.TabIndex = 128
        '
        'Buscar_UC1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Btn_Buscar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Buscar_UC1"
        Me.Size = New System.Drawing.Size(310, 50)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnActualizar As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Buscar As Bunifu.Framework.UI.BunifuTileButton
End Class
