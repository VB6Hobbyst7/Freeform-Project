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
        Me.movement = New System.Windows.Forms.Timer(Me.components)
        Me.Animation = New System.Windows.Forms.Timer(Me.components)
        Me.C1 = New System.Windows.Forms.PictureBox()
        CType(Me.C1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'movement
        '
        Me.movement.Interval = 10
        '
        'Animation
        '
        Me.Animation.Interval = 80
        '
        'C1
        '
        Me.C1.Image = Global.SpriteMovement.My.Resources.Resources.mario1
        Me.C1.Location = New System.Drawing.Point(214, 126)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(116, 202)
        Me.C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.C1.TabIndex = 0
        Me.C1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 480)
        Me.Controls.Add(Me.C1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.C1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1 As PictureBox
    Friend WithEvents movement As Timer
    Friend WithEvents Animation As Timer
End Class
