Option Strict On

Imports MetroSuite

Public Class MainForm
    Inherits MetroForm

    Dim SpigotJar As String = ""
    Dim PatchJar As String = ""
    Dim OutputJar As String = ""

    Private Sub MainForm_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        For Each path In files
            If SpigotJar = "" Then
                SpigotJar = path
                HelpLabel.Text = "Now drop the patch.bps file"
            ElseIf PatchJar = "" Then
                PatchJar = path
                HelpLabel.Text = "Now select a place to save the output jar"
                DropImage.Visible = False

            End If
        Next
    End Sub

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(327, 393)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        SaveJarDialog.ShowDialog()

        OutputJar = SaveJarDialog.FileName

        SaveButton.Hide()
    End Sub

    Private Sub PatchFile()

    End Sub
End Class
