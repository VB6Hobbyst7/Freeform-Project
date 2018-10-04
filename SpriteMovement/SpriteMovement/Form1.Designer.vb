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
        Me.Animation_Right = New System.Windows.Forms.Timer(Me.components)
        Me.Animation_Up = New System.Windows.Forms.Timer(Me.components)
        Me.Animation_Down = New System.Windows.Forms.Timer(Me.components)
        Me.Animation_Left = New System.Windows.Forms.Timer(Me.components)
        Me.C1 = New System.Windows.Forms.PictureBox()
        Me.Object1 = New System.Windows.Forms.PictureBox()
        Me.left_bounds = New System.Windows.Forms.Timer(Me.components)
        Me.right_bounds = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.C1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Object1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'movement
        '
        Me.movement.Interval = 10
        '
        'Animation_Right
        '
        Me.Animation_Right.Interval = 80
        '
        'Animation_Up
        '
        Me.Animation_Up.Interval = 80
        '
        'Animation_Down
        '
        Me.Animation_Down.Interval = 80
        '
        'Animation_Left
        '
        Me.Animation_Left.Interval = 80
        '
        'C1
        '
        Me.C1.Image = Global.SpriteMovement.My.Resources.Resources.Pokemon_right_1
        Me.C1.Location = New System.Drawing.Point(214, 126)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(29, 38)
        Me.C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.C1.TabIndex = 0
        Me.C1.TabStop = False
        '
        'Object1
        '
        Me.Object1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Object1.Location = New System.Drawing.Point(814, -2)
        Me.Object1.Name = "Object1"
        Me.Object1.Size = New System.Drawing.Size(10, 489)
        Me.Object1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Object1.TabIndex = 1
        Me.Object1.TabStop = False
        '
        'left_bounds
        '
        Me.left_bounds.Enabled = True
        Me.left_bounds.Interval = 1
        '
        'right_bounds
        '
        Me.right_bounds.Enabled = True
        Me.right_bounds.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 489)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 480)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Object1)
        Me.Controls.Add(Me.C1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.C1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Object1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1 As PictureBox
    Friend WithEvents movement As Timer
    Friend WithEvents Animation_Right As Timer
    Friend WithEvents Animation_Up As Timer
    Friend WithEvents Animation_Down As Timer
    Friend WithEvents Animation_Left As Timer
    Friend WithEvents Object1 As PictureBox
    Friend WithEvents left_bounds As Timer
    Friend WithEvents right_bounds As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
