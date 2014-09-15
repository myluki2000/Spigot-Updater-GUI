Option Strict On

Imports MetroSuite
Imports System.IO

Public Class MainForm
    Inherits MetroForm

    Public SpigotJar As String = ""
    Public PatcherJar As String = ""
    Public PatchBps As String = ""
    Public OutputJar As String = ""

    Public FilePatching As Boolean = False

    Dim Main As New Main

    Private Sub MainForm_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

        For Each filepath In files
            If Path.GetExtension(filepath) = ".jar" OrElse Path.GetExtension(filepath) = ".bps" Then
                Main.DroppedFile(e)
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

        FilePatching = True
        MsgBox.Label1.Text = "After you click ok, a console window will open. It will close itself after it's done."
        MsgBox.ShowDialog()
    End Sub

    

    
End Class
