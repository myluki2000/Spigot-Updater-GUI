Imports MetroSuite

Public Class MsgBox
    Inherits MetroForm

    Dim Main As New Main

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        If MainForm.FilePatching = True Then
            Main.PatchFile()
        End If

        Me.Close()
    End Sub

    Private Sub MsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(420, 115)
    End Sub
End Class