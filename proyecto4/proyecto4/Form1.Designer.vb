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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.y = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.yes = New System.Windows.Forms.Label()
        Me.yessir = New System.Windows.Forms.Label()
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(145, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(368, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 67)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "SUMAR"
        Me.Button1.UseVisualStyleBackColor = True
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(147, 140)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(152, 20)
        Me.TextBox2.TabIndex = 5
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.yessir)
        Me.Controls.Add(Me.yes)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.y)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ye)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ye As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents y As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents yes As Label
    Friend WithEvents yessir As Label
End Class
