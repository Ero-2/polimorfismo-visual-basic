Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim perro As animal = New PERRO()
        MessageBox.Show(perro.HacerSonido())
        Dim gato As animal = New gato()
        MessageBox.Show(gato.HacerSonido())
    End Sub
End Class
