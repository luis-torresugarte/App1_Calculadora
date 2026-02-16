Public Class Form1
    Dim Activo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles botonsumar.Click
        Dim Numero1 As Double = Double.Parse(Me.num1.Text)
        Dim Numero2 As Double = Double.Parse(num2.Text)

        Dim resultado As Double = Numero1 + Numero2

        yessir.Text = resultado.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles botonrestar.Click
        Dim Numero1 As Double = Double.Parse(Me.num1.Text)
        Dim Numero2 As Double = Double.Parse(num2.Text)

        Dim resultado As Double = Numero1 - Numero2

        yessir.Text = resultado.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles botonmultiplicar.Click
        Dim Numero1 As Double = Double.Parse(Me.num1.Text)
        Dim Numero2 As Double = Double.Parse(num2.Text)

        Dim resultado As Double = Numero1 * Numero2

        yessir.Text = resultado.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles botondividir.Click
        Dim Numero1 As Double = Double.Parse(Me.num1.Text)
        Dim Numero2 As Double = Double.Parse(num2.Text)

        Dim resultado As Double = Numero1 / Numero2

        yessir.Text = resultado.ToString()
    End Sub

    Private Sub botoncero_Click(sender As Object, e As EventArgs) Handles botoncero.Click
        Activo.Text = Activo.Text & "0"
    End Sub

    Private Sub boton1_Click(sender As Object, e As EventArgs) Handles boton1.Click
        Activo.Text = Activo.Text & "1"
    End Sub

    Private Sub boton2_Click(sender As Object, e As EventArgs) Handles boton2.Click
        Activo.Text = Activo.Text & "2"
    End Sub

    Private Sub boton3_Click(sender As Object, e As EventArgs) Handles boton3.Click
        Activo.Text = Activo.Text & "3"
    End Sub

    Private Sub boton4_Click(sender As Object, e As EventArgs) Handles boton4.Click
        Activo.Text = Activo.Text & "4"
    End Sub

    Private Sub boton5_Click(sender As Object, e As EventArgs) Handles boton5.Click
        Activo.Text = Activo.Text & "5"
    End Sub

    Private Sub boton6_Click(sender As Object, e As EventArgs) Handles boton6.Click
        Activo.Text = Activo.Text & "6"
    End Sub

    Private Sub boton7_Click(sender As Object, e As EventArgs) Handles boton7.Click
        Activo.Text = Activo.Text & "7"
    End Sub

    Private Sub boton8_Click(sender As Object, e As EventArgs) Handles boton8.Click
        Activo.Text = Activo.Text & "8"
    End Sub

    Private Sub boton9_Click(sender As Object, e As EventArgs) Handles boton9.Click
        Activo.Text = Activo.Text & "9"
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        Activo.Text = ""
    End Sub

    Private Sub botonpunto_Click(sender As Object, e As EventArgs) Handles botonpunto.Click
        Activo.Text = Activo.Text & "."
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Activo = num1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Activo = num2
    End Sub
End Class
