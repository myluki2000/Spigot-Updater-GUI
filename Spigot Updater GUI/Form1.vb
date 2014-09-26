Option Strict On

Imports MetroSuite
Imports System.IO

Public Class MainForm
    Inherits MetroForm

    Public SpigotJar As String = ""
    Public PatcherJar As String = ""
    Public PatchBps As String = ""
    Public OutputJar As String = ""

    Public DrawDropImage As Boolean = True
    Public DrawPatchedImage As Boolean = False

    Public FilePatching As Boolean = False

    Dim DropFileImage As New Bitmap(My.Resources.drop_file)
    Dim PatchingDoneImage As New Bitmap(My.Resources.patching_done)

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
        MsgBox.Label1.Text = "After you click ok, a console window will open. It will close itself if it patched the file without errors. If it stays open, please consider looking on the Spigot Forums for help!"
        MsgBox.ShowDialog()
    End Sub

    Private Sub MainForm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If DrawDropImage Then
            e.Graphics.DrawImage(DropFileImage, New Rectangle(0, 38, 327, 290))
        ElseIf DrawPatchedImage Then
            e.Graphics.DrawImage(PatchingDoneImage, New Rectangle(0, 38, 327, 290))
        End If
    End Sub

    Private Sub SaveJarDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveJarDialog.FileOk
        SaveButton.Visible = False
    End Sub
End Class
