<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.movement = New System.Windows.Forms.Timer(Me.components)
        Me.Animation_Right = New System.Windows.Forms.Timer(Me.components)
        Me.Animation_Up = New System.Windows.Forms.Timer(Me.components)
        Me.Animation_Down = New System.Windows.Forms.Timer(Me.components)
        Me.Animation_Left = New System.Windows.Forms.Timer(Me.components)
        Me.Bounds = New System.Windows.Forms.Timer(Me.components)
        Me.bullet_movement = New System.Windows.Forms.Timer(Me.components)
        Me.Spawn = New System.Windows.Forms.Timer(Me.components)
        Me.Test = New System.Windows.Forms.PictureBox()
        Me.Bottom_boundary = New System.Windows.Forms.PictureBox()
        Me.Top_boundary = New System.Windows.Forms.PictureBox()
        Me.Left_boundary = New System.Windows.Forms.PictureBox()
        Me.Right_boundary = New System.Windows.Forms.PictureBox()
        Me.C1 = New System.Windows.Forms.PictureBox()
        Me.CreateEnemy = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Test, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bottom_boundary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Top_boundary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Left_boundary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Right_boundary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Bounds
        '
        Me.Bounds.Enabled = True
        Me.Bounds.Interval = 1
        '
        'bullet_movement
        '
        Me.bullet_movement.Enabled = True
        Me.bullet_movement.Interval = 1
        '
        'Spawn
        '
        Me.Spawn.Interval = 2000
        '
        'Test
        '
        Me.Test.BackColor = System.Drawing.Color.Transparent
        Me.Test.Image = Global.SpriteMovement.My.Resources.Resources.mario1
        Me.Test.Location = New System.Drawing.Point(725, 199)
        Me.Test.Name = "Test"
        Me.Test.Size = New System.Drawing.Size(36, 50)
        Me.Test.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Test.TabIndex = 5
        Me.Test.TabStop = False
        '
        'Bottom_boundary
        '
        Me.Bottom_boundary.Location = New System.Drawing.Point(-6, 478)
        Me.Bottom_boundary.Name = "Bottom_boundary"
        Me.Bottom_boundary.Size = New System.Drawing.Size(830, 10)
        Me.Bottom_boundary.TabIndex = 4
        Me.Bottom_boundary.TabStop = False
        '
        'Top_boundary
        '
        Me.Top_boundary.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Top_boundary.Location = New System.Drawing.Point(-6, -9)
        Me.Top_boundary.Name = "Top_boundary"
        Me.Top_boundary.Size = New System.Drawing.Size(830, 10)
        Me.Top_boundary.TabIndex = 3
        Me.Top_boundary.TabStop = False
        '
        'Left_boundary
        '
        Me.Left_boundary.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Left_boundary.Location = New System.Drawing.Point(-9, -2)
        Me.Left_boundary.Name = "Left_boundary"
        Me.Left_boundary.Size = New System.Drawing.Size(10, 489)
        Me.Left_boundary.TabIndex = 2
        Me.Left_boundary.TabStop = False
        '
        'Right_boundary
        '
        Me.Right_boundary.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Right_boundary.Location = New System.Drawing.Point(814, -105)
        Me.Right_boundary.Name = "Right_boundary"
        Me.Right_boundary.Size = New System.Drawing.Size(10, 1039)
        Me.Right_boundary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Right_boundary.TabIndex = 1
        Me.Right_boundary.TabStop = False
        '
        'C1
        '
        Me.C1.BackColor = System.Drawing.Color.Transparent
        Me.C1.Image = Global.SpriteMovement.My.Resources.Resources.Pokemon_Down_1
        Me.C1.Location = New System.Drawing.Point(386, 199)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(29, 38)
        Me.C1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.C1.TabIndex = 0
        Me.C1.TabStop = False
        '
        'CreateEnemy
        '
        Me.CreateEnemy.Interval = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(816, 480)
        Me.Controls.Add(Me.Test)
        Me.Controls.Add(Me.Bottom_boundary)
        Me.Controls.Add(Me.Top_boundary)
        Me.Controls.Add(Me.Left_boundary)
        Me.Controls.Add(Me.Right_boundary)
        Me.Controls.Add(Me.C1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "    "
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.Test, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bottom_boundary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Top_boundary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Left_boundary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Right_boundary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1 As PictureBox
    Friend WithEvents movement As Timer
    Friend WithEvents Animation_Right As Timer
    Friend WithEvents Animation_Up As Timer
    Friend WithEvents Animation_Down As Timer
    Friend WithEvents Animation_Left As Timer
    Friend WithEvents Right_boundary As PictureBox
    Friend WithEvents Bounds As Timer
    Friend WithEvents Left_boundary As PictureBox
    Friend WithEvents Top_boundary As PictureBox
    Friend WithEvents Bottom_boundary As PictureBox
    Friend WithEvents bullet_movement As Timer
    Friend WithEvents Spawn As Timer
    Friend WithEvents Test As PictureBox
    Friend WithEvents CreateEnemy As Timer
    Friend WithEvents Timer1 As Timer
End Class
