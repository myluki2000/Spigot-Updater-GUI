Imports MetroSuite

Public Class MainForm
    Inherits MetroForm

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(500, 500)
    End Sub
End Class
