Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class Main
    Public Function GetMD5(ByVal filePath As String)
        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
        Dim f As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)

        f = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        md5.ComputeHash(f)
        f.Close()

        Dim hash As Byte() = md5.Hash
        Dim buff As StringBuilder = New StringBuilder
        Dim hashByte As Byte

        For Each hashByte In hash
            buff.Append(String.Format("{0:X2}", hashByte))
        Next

        Dim md5string As String
        md5string = buff.ToString()

        Return md5string

    End Function

    Public Sub PatchFile()
        MainForm.HelpLabel.Text = "Patching your file, please wait..."

        Process.Start("cmd", "/c java -jar " + MainForm.PatcherJar + " " + MainForm.SpigotJar + " " + MainForm.PatchJar + " " + MainForm.OutputJar)

        MainForm.HelpLabel.Text = "Your file has been patched!"
    End Sub

    Public Sub DroppedFile(e As DragEventArgs)
        Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        For Each filepath In files
            If MainForm.PatcherJar = "" AndAlso Path.GetExtension(filepath) = ".jar" Then
                MainForm.PatcherJar = filepath
                MainForm.HelpLabel.Text = "Drop the spigot-1649.jar here"
            ElseIf MainForm.SpigotJar = "" Then
                Dim md5hash As String = CStr(GetMD5(filepath))

                If md5hash <> "F2EDC09C45B1F80237602DC0D1B05969" Then

                    MainForm.FilePatching = False
                    MsgBox.Label1.Text = "The MD5 hash of the file you dropped doesn't match the Hash of the official spigot-1649.jar file!"
                    MsgBox.ShowDialog()
                    Return
                End If


                MainForm.SpigotJar = filepath
                MainForm.HelpLabel.Text = "Now drop the patch.bps file here"
            ElseIf MainForm.PatchJar = "" Then
                MainForm.PatchJar = filepath
                MainForm.HelpLabel.Text = "Now select a location for the patched jar"
                MainForm.DropImage.Visible = False
            End If
        Next
    End Sub
End Class
