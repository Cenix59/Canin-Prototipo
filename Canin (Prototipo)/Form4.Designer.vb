<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NuevoForo = New System.Windows.Forms.FlowLayoutPanel()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Foro = New System.Windows.Forms.Button()
        Me.Perfil = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.NuevoForo)
        Me.Panel1.Controls.Add(Me.Salir)
        Me.Panel1.Controls.Add(Me.Foro)
        Me.Panel1.Controls.Add(Me.Perfil)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(194, 451)
        Me.Panel1.TabIndex = 0
        '
        'NuevoForo
        '
        Me.NuevoForo.Location = New System.Drawing.Point(28, 209)
        Me.NuevoForo.Name = "NuevoForo"
        Me.NuevoForo.Size = New System.Drawing.Size(136, 180)
        Me.NuevoForo.TabIndex = 4
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(28, 414)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(136, 23)
        Me.Salir.TabIndex = 3
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Foro
        '
        Me.Foro.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Foro.Location = New System.Drawing.Point(28, 172)
        Me.Foro.Name = "Foro"
        Me.Foro.Size = New System.Drawing.Size(136, 23)
        Me.Foro.TabIndex = 2
        Me.Foro.Text = "+Foro"
        Me.Foro.UseVisualStyleBackColor = False
        '
        'Perfil
        '
        Me.Perfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Perfil.Location = New System.Drawing.Point(28, 127)
        Me.Perfil.Name = "Perfil"
        Me.Perfil.Size = New System.Drawing.Size(136, 23)
        Me.Perfil.TabIndex = 1
        Me.Perfil.Text = "Perfil"
        Me.Perfil.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Canin__Prototipo_.My.Resources.Resources._1467646262_522853_1467646344_noticia_normal
        Me.PictureBox1.Location = New System.Drawing.Point(28, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ComboBox3)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Location = New System.Drawing.Point(606, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(194, 451)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.Location = New System.Drawing.Point(26, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 85)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Esta seccion se encuntra en mantenimiento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Filtros"
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(40, 352)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(40, 289)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(40, 209)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(229, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 61)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Prueba1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form4"
        Me.Text = "Canin"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Salir As Button
    Friend WithEvents Foro As Button
    Friend WithEvents Perfil As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents NuevoForo As FlowLayoutPanel
    Friend WithEvents Label2 As Label
End Class
