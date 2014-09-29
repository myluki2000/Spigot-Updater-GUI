Imports MetroSuite

Public Class SettingsForm
    Inherits MetroForm

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set size of the window
        Me.Size = New Size(314, 200)

        ' Put Location of files into Textboxes
        SpigotJarTB.Text = My.Settings.SpigotJarLoc
        PatcherJarTB.Text = My.Settings.PatcherJarLoc
    End Sub

    Private Sub SettingsSaveButton_Click(sender As Object, e As EventArgs) Handles SettingsSaveButton.Click
        ' Save Location of files from Textboxes
        My.Settings.SpigotJarLoc = SpigotJarTB.Text
        My.Settings.PatcherJarLoc = PatcherJarTB.Text

        ' Save Settings
        My.Settings.Save()
    End Sub

    Private Sub SpigotSelectButton_Click(sender As Object, e As EventArgs) Handles SpigotSelectButton.Click
        ' Clear old file path if there is one
        FileSelector.FileName = ""

        ' Open the Open-Dialog
        FileSelector.ShowDialog()

        ' set the text of the Textbox to the selected file path
        SpigotJarTB.Text = FileSelector.FileName
    End Sub

    Private Sub PatcherSelectButton_Click(sender As Object, e As EventArgs) Handles PatcherSelectButton.Click
        ' Clear old file path if there is one
        FileSelector.FileName = ""

        ' Open the Open-Dialog
        FileSelector.ShowDialog()

        ' set the text of the Textbox to the selected file path
        PatcherJarTB.Text = FileSelector.FileName
    End Sub
End Class