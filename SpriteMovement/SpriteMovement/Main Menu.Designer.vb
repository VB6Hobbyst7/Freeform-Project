<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Me.Startbtn = New System.Windows.Forms.Button()
        Me.Start = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Startbtn
        '
        Me.Startbtn.Location = New System.Drawing.Point(12, 167)
        Me.Startbtn.Name = "Startbtn"
        Me.Startbtn.Size = New System.Drawing.Size(101, 40)
        Me.Startbtn.TabIndex = 0
        Me.Startbtn.Text = "START"
        Me.Startbtn.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(270, 167)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(107, 40)
        Me.Start.TabIndex = 1
        Me.Start.Text = "EXIT"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "*GAME NAME GOES HERE*"
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 302)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Startbtn)
        Me.Name = "Main_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main_Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Startbtn As Button
    Friend WithEvents Start As Button
    Friend WithEvents Label1 As Label
End Class
