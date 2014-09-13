Option Strict On

Imports MetroSuite
Imports System.IO

Public Class MainForm
    Inherits MetroForm

    Dim SpigotJar As String = ""
    Dim PatcherJar As String = ""
    Dim PatchJar As String = ""
    Dim OutputJar As String = ""


    Private Sub MainForm_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        For Each filepath In files
            If Path.GetExtension(filepath) = ".jar" OrElse Path.GetExtension(filepath) = ".bps" Then
                DroppedFile(e)
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

        PatchFile()
    End Sub

    Private Sub PatchFile()
        HelpLabel.Text = "Patching your file, please wait..."

        Process.Start("cmd", "/c java -jar " + PatcherJar + " " + SpigotJar + " " + PatchJar + " " + OutputJar)

        HelpLabel.Text = "Your file has been patched!"
    End Sub

    Private Sub DroppedFile(e As DragEventArgs)
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        For Each filepath In files
            If PatcherJar = "" AndAlso Path.GetExtension(filepath) = ".jar" Then
                PatcherJar = filepath
                HelpLabel.Text = "Drop the spigot-1649.jar here"
            ElseIf SpigotJar = "" Then
                SpigotJar = filepath
                HelpLabel.Text = "Now drop the patch.bps file here"
            ElseIf PatchJar = "" Then
                PatchJar = filepath
                HelpLabel.Text = "Now select a location for the patched jar"
                DropImage.Visible = False
            End If
        Next
    End Sub
End Class
