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
        Me.ye = New System.Windows.Forms.Label()
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.botonsumar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.y = New System.Windows.Forms.Label()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.yes = New System.Windows.Forms.Label()
        Me.yessir = New System.Windows.Forms.Label()
        Me.botonrestar = New System.Windows.Forms.Button()
        Me.botonmultiplicar = New System.Windows.Forms.Button()
        Me.botondividir = New System.Windows.Forms.Button()
        Me.botoncero = New System.Windows.Forms.Button()
        Me.boton1 = New System.Windows.Forms.Button()
        Me.boton4 = New System.Windows.Forms.Button()
        Me.boton5 = New System.Windows.Forms.Button()
        Me.boton3 = New System.Windows.Forms.Button()
        Me.boton2 = New System.Windows.Forms.Button()
        Me.boton6 = New System.Windows.Forms.Button()
        Me.boton9 = New System.Windows.Forms.Button()
        Me.boton8 = New System.Windows.Forms.Button()
        Me.boton7 = New System.Windows.Forms.Button()
        Me.borrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ye
        '
        Me.ye.AutoSize = True
        Me.ye.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ye.Location = New System.Drawing.Point(1, 66)
        Me.ye.Name = "ye"
        Me.ye.Size = New System.Drawing.Size(101, 20)
        Me.ye.TabIndex = 0
        Me.ye.Text = "NUMERO 1"
        '
        'num1
        '
        Me.num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num1.Location = New System.Drawing.Point(145, 68)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(152, 29)
        Me.num1.TabIndex = 1
        '
        'botonsumar
        '
        Me.botonsumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonsumar.Location = New System.Drawing.Point(373, 12)
        Me.botonsumar.Name = "botonsumar"
        Me.botonsumar.Size = New System.Drawing.Size(126, 67)
        Me.botonsumar.TabIndex = 2
        Me.botonsumar.Text = "+"
        Me.botonsumar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 3
        '
        'y
        '
        Me.y.AutoSize = True
        Me.y.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.y.Location = New System.Drawing.Point(1, 140)
        Me.y.Name = "y"
        Me.y.Size = New System.Drawing.Size(101, 20)
        Me.y.TabIndex = 4
        Me.y.Text = "NUMERO 2"
        '
        'num2
        '
        Me.num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num2.Location = New System.Drawing.Point(147, 140)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(152, 29)
        Me.num2.TabIndex = 5
        '
        'yes
        '
        Me.yes.AutoSize = True
        Me.yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yes.Location = New System.Drawing.Point(1, 245)
        Me.yes.Name = "yes"
        Me.yes.Size = New System.Drawing.Size(122, 20)
        Me.yes.TabIndex = 6
        Me.yes.Text = "RESULTADO:"
        '
        'yessir
        '
        Me.yessir.AutoSize = True
        Me.yessir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yessir.Location = New System.Drawing.Point(143, 245)
        Me.yessir.Name = "yessir"
        Me.yessir.Size = New System.Drawing.Size(0, 20)
        Me.yessir.TabIndex = 7
        '
        'botonrestar
        '
        Me.botonrestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonrestar.Location = New System.Drawing.Point(505, 12)
        Me.botonrestar.Name = "botonrestar"
        Me.botonrestar.Size = New System.Drawing.Size(126, 67)
        Me.botonrestar.TabIndex = 8
        Me.botonrestar.Text = "-"
        Me.botonrestar.UseVisualStyleBackColor = True
        '
        'botonmultiplicar
        '
        Me.botonmultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonmultiplicar.Location = New System.Drawing.Point(637, 12)
        Me.botonmultiplicar.Name = "botonmultiplicar"
        Me.botonmultiplicar.Size = New System.Drawing.Size(126, 67)
        Me.botonmultiplicar.TabIndex = 9
        Me.botonmultiplicar.Text = "*"
        Me.botonmultiplicar.UseVisualStyleBackColor = True
        '
        'botondividir
        '
        Me.botondividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botondividir.Location = New System.Drawing.Point(505, 85)
        Me.botondividir.Name = "botondividir"
        Me.botondividir.Size = New System.Drawing.Size(126, 67)
        Me.botondividir.TabIndex = 10
        Me.botondividir.Text = "/"
        Me.botondividir.UseVisualStyleBackColor = True
        '
        'botoncero
        '
        Me.botoncero.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botoncero.Location = New System.Drawing.Point(533, 373)
        Me.botoncero.Name = "botoncero"
        Me.botoncero.Size = New System.Drawing.Size(71, 54)
        Me.botoncero.TabIndex = 11
        Me.botoncero.Text = "0"
        Me.botoncero.UseVisualStyleBackColor = True
        '
        'boton1
        '
        Me.boton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton1.Location = New System.Drawing.Point(456, 313)
        Me.boton1.Name = "boton1"
        Me.boton1.Size = New System.Drawing.Size(71, 54)
        Me.boton1.TabIndex = 12
        Me.boton1.Text = "1"
        Me.boton1.UseVisualStyleBackColor = True
        '
        'boton4
        '
        Me.boton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton4.Location = New System.Drawing.Point(456, 256)
        Me.boton4.Name = "boton4"
        Me.boton4.Size = New System.Drawing.Size(71, 54)
        Me.boton4.TabIndex = 13
        Me.boton4.Text = "4"
        Me.boton4.UseVisualStyleBackColor = True
        '
        'boton5
        '
        Me.boton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton5.Location = New System.Drawing.Point(533, 256)
        Me.boton5.Name = "boton5"
        Me.boton5.Size = New System.Drawing.Size(71, 54)
        Me.boton5.TabIndex = 14
        Me.boton5.Text = "5"
        Me.boton5.UseVisualStyleBackColor = True
        '
        'boton3
        '
        Me.boton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton3.Location = New System.Drawing.Point(610, 313)
        Me.boton3.Name = "boton3"
        Me.boton3.Size = New System.Drawing.Size(71, 54)
        Me.boton3.TabIndex = 15
        Me.boton3.Text = "3"
        Me.boton3.UseVisualStyleBackColor = True
        '
        'boton2
        '
        Me.boton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton2.Location = New System.Drawing.Point(533, 313)
        Me.boton2.Name = "boton2"
        Me.boton2.Size = New System.Drawing.Size(71, 54)
        Me.boton2.TabIndex = 16
        Me.boton2.Text = "2"
        Me.boton2.UseVisualStyleBackColor = True
        '
        'boton6
        '
        Me.boton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton6.Location = New System.Drawing.Point(610, 256)
        Me.boton6.Name = "boton6"
        Me.boton6.Size = New System.Drawing.Size(71, 54)
        Me.boton6.TabIndex = 17
        Me.boton6.Text = "6"
        Me.boton6.UseVisualStyleBackColor = True
        '
        'boton9
        '
        Me.boton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton9.Location = New System.Drawing.Point(610, 196)
        Me.boton9.Name = "boton9"
        Me.boton9.Size = New System.Drawing.Size(71, 54)
        Me.boton9.TabIndex = 18
        Me.boton9.Text = "9"
        Me.boton9.UseVisualStyleBackColor = True
        '
        'boton8
        '
        Me.boton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton8.Location = New System.Drawing.Point(533, 196)
        Me.boton8.Name = "boton8"
        Me.boton8.Size = New System.Drawing.Size(71, 54)
        Me.boton8.TabIndex = 19
        Me.boton8.Text = "8"
        Me.boton8.UseVisualStyleBackColor = True
        '
        'boton7
        '
        Me.boton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton7.Location = New System.Drawing.Point(456, 196)
        Me.boton7.Name = "boton7"
        Me.boton7.Size = New System.Drawing.Size(71, 54)
        Me.boton7.TabIndex = 20
        Me.boton7.Text = "7"
        Me.boton7.UseVisualStyleBackColor = True
        '
        'borrar
        '
        Me.borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrar.Location = New System.Drawing.Point(610, 373)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(71, 54)
        Me.borrar.TabIndex = 21
        Me.borrar.Text = "X"
        Me.borrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.boton7)
        Me.Controls.Add(Me.boton8)
        Me.Controls.Add(Me.boton9)
        Me.Controls.Add(Me.boton6)
        Me.Controls.Add(Me.boton2)
        Me.Controls.Add(Me.boton3)
        Me.Controls.Add(Me.boton5)
        Me.Controls.Add(Me.boton4)
        Me.Controls.Add(Me.boton1)
        Me.Controls.Add(Me.botoncero)
        Me.Controls.Add(Me.botondividir)
        Me.Controls.Add(Me.botonmultiplicar)
        Me.Controls.Add(Me.botonrestar)
        Me.Controls.Add(Me.yessir)
        Me.Controls.Add(Me.yes)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.y)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.botonsumar)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.ye)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ye As Label
    Friend WithEvents num1 As TextBox
    Friend WithEvents botonsumar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents y As Label
    Friend WithEvents num2 As TextBox
    Friend WithEvents yes As Label
    Friend WithEvents yessir As Label
    Friend WithEvents botonrestar As Button
    Friend WithEvents botonmultiplicar As Button
    Friend WithEvents botondividir As Button
    Friend WithEvents botoncero As Button
    Friend WithEvents boton1 As Button
    Friend WithEvents boton4 As Button
    Friend WithEvents boton5 As Button
    Friend WithEvents boton3 As Button
    Friend WithEvents boton2 As Button
    Friend WithEvents boton6 As Button
    Friend WithEvents boton9 As Button
    Friend WithEvents boton8 As Button
    Friend WithEvents boton7 As Button
    Friend WithEvents borrar As Button
End Class
