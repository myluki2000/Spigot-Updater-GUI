﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits MetroSuite.MetroForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim MainColorScheme2 As MetroSuite.MetroButton.MainColorScheme = New MetroSuite.MetroButton.MainColorScheme()
        Me.MetroControlBox1 = New MetroSuite.MetroControlBox()
        Me.DropImage = New System.Windows.Forms.PictureBox()
        Me.HelpLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New MetroSuite.MetroButton()
        Me.SaveJarDialog = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DropImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroControlBox1
        '
        Me.MetroControlBox1.AllowDrop = True
        Me.MetroControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.MetroControlBox1.FormHeight = 0
        Me.MetroControlBox1.FormWidth = 0
        Me.MetroControlBox1.Location = New System.Drawing.Point(217, 0)
        Me.MetroControlBox1.Name = "MetroControlBox1"
        Me.MetroControlBox1.Size = New System.Drawing.Size(110, 26)
        Me.MetroControlBox1.TabIndex = 0
        '
        'DropImage
        '
        Me.DropImage.Image = CType(resources.GetObject("DropImage.Image"), System.Drawing.Image)
        Me.DropImage.Location = New System.Drawing.Point(0, 61)
        Me.DropImage.Name = "DropImage"
        Me.DropImage.Size = New System.Drawing.Size(327, 270)
        Me.DropImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DropImage.TabIndex = 1
        Me.DropImage.TabStop = False
        '
        'HelpLabel
        '
        Me.HelpLabel.AllowDrop = True
        Me.HelpLabel.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpLabel.Location = New System.Drawing.Point(36, 334)
        Me.HelpLabel.Name = "HelpLabel"
        Me.HelpLabel.Size = New System.Drawing.Size(255, 50)
        Me.HelpLabel.TabIndex = 2
        Me.HelpLabel.Text = "Drop the spigot-1649.jar here"
        Me.HelpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SaveButton
        '
        MainColorScheme2.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        MainColorScheme2.BackgroundColorNormal = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        MainColorScheme2.BackgroundColorPressed = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        MainColorScheme2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        MainColorScheme2.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(79, Byte), Integer))
        MainColorScheme2.BorderColorPressed = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.SaveButton.ColorScheme = MainColorScheme2
        Me.SaveButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SaveButton.ForeColor = System.Drawing.Color.Black
        Me.SaveButton.Location = New System.Drawing.Point(100, 177)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(128, 40)
        Me.SaveButton.TabIndex = 3
        Me.SaveButton.Text = "Save"
        '
        'SaveJarDialog
        '
        Me.SaveJarDialog.FileName = "output.jar"
        Me.SaveJarDialog.Filter = "jar File|*.jar"
        '
        'MainForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 393)
        Me.Controls.Add(Me.HelpLabel)
        Me.Controls.Add(Me.MetroControlBox1)
        Me.Controls.Add(Me.DropImage)
        Me.Controls.Add(Me.SaveButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.Text = "Form1"
        CType(Me.DropImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroControlBox1 As MetroSuite.MetroControlBox
    Friend WithEvents DropImage As System.Windows.Forms.PictureBox
    Friend WithEvents HelpLabel As System.Windows.Forms.Label
    Friend WithEvents SaveButton As MetroSuite.MetroButton
    Friend WithEvents SaveJarDialog As System.Windows.Forms.SaveFileDialog

End Class
