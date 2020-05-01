<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboxSerie = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(150, 65)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(206, 20)
        Me.txtNombre.TabIndex = 0
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(151, 91)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(206, 20)
        Me.txtApellido.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingrese los datos correspondientes:"
        '
        'cboxSerie
        '
        Me.cboxSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSerie.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxSerie.FormattingEnabled = True
        Me.cboxSerie.Items.AddRange(New Object() {"La Casa de Papel", "Poco Ortodoxa", "Game of Thrones", "Stranger Things", "Ninguna de las anteriores"})
        Me.cboxSerie.Location = New System.Drawing.Point(150, 118)
        Me.cboxSerie.Name = "cboxSerie"
        Me.cboxSerie.Size = New System.Drawing.Size(207, 24)
        Me.cboxSerie.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(102, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Serie:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(212, 145)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(492, 198)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboxSerie)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "Form1"
        Me.Text = "Encuesta Sobre Series"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboxSerie As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAceptar As Button
End Class
