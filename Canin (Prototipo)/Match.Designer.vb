<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Match
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
        Me.Titulo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Volver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(132, 77)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(71, 25)
        Me.Titulo.TabIndex = 1
        Me.Titulo.Text = "Match"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(316, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "+ Maria te dio Me Gusta en el foro Prueba 1"
        '
        'Volver
        '
        Me.Volver.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Volver.Location = New System.Drawing.Point(128, 327)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(75, 23)
        Me.Volver.TabIndex = 10
        Me.Volver.Text = "volver"
        Me.Volver.UseVisualStyleBackColor = False
        '
        'Match
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(334, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Titulo)
        Me.Name = "Match"
        Me.Text = "Canin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Volver As Button
End Class
