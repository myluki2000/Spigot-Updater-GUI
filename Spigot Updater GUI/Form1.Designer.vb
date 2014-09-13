<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MetroControlBox1 = New MetroSuite.MetroControlBox()
        Me.SuspendLayout()
        '
        'MetroControlBox1
        '
        Me.MetroControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.MetroControlBox1.FormHeight = 0
        Me.MetroControlBox1.FormWidth = 0
        Me.MetroControlBox1.Location = New System.Drawing.Point(424, 0)
        Me.MetroControlBox1.Name = "MetroControlBox1"
        Me.MetroControlBox1.Size = New System.Drawing.Size(110, 26)
        Me.MetroControlBox1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 282)
        Me.Controls.Add(Me.MetroControlBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroControlBox1 As MetroSuite.MetroControlBox

End Class
