<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timerlbl = New System.Windows.Forms.Label()
        Me.Startbtn = New System.Windows.Forms.Button()
        Me.Stopbtn = New System.Windows.Forms.Button()
        Me.TimTime = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Timerlbl
        '
        Me.Timerlbl.AutoSize = True
        Me.Timerlbl.Location = New System.Drawing.Point(222, 132)
        Me.Timerlbl.Name = "Timerlbl"
        Me.Timerlbl.Size = New System.Drawing.Size(0, 13)
        Me.Timerlbl.TabIndex = 0
        '
        'Startbtn
        '
        Me.Startbtn.Location = New System.Drawing.Point(97, 213)
        Me.Startbtn.Name = "Startbtn"
        Me.Startbtn.Size = New System.Drawing.Size(75, 23)
        Me.Startbtn.TabIndex = 1
        Me.Startbtn.Text = "Start"
        Me.Startbtn.UseVisualStyleBackColor = True
        '
        'Stopbtn
        '
        Me.Stopbtn.Location = New System.Drawing.Point(288, 213)
        Me.Stopbtn.Name = "Stopbtn"
        Me.Stopbtn.Size = New System.Drawing.Size(75, 23)
        Me.Stopbtn.TabIndex = 2
        Me.Stopbtn.Text = "Stop"
        Me.Stopbtn.UseVisualStyleBackColor = True
        '
        'TimTime
        '
        Me.TimTime.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 428)
        Me.Controls.Add(Me.Stopbtn)
        Me.Controls.Add(Me.Startbtn)
        Me.Controls.Add(Me.Timerlbl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timerlbl As Label
    Friend WithEvents Startbtn As Button
    Friend WithEvents Stopbtn As Button
    Friend WithEvents TimTime As Timer
End Class
