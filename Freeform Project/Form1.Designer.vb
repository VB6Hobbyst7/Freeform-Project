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
        Me.Rbtn = New System.Windows.Forms.Button()
        Me.selectbox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resbtn = New System.Windows.Forms.Button()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Rbtn
        '
        Me.Rbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtn.Location = New System.Drawing.Point(192, 177)
        Me.Rbtn.Name = "Rbtn"
        Me.Rbtn.Size = New System.Drawing.Size(153, 60)
        Me.Rbtn.TabIndex = 0
        Me.Rbtn.Text = "Randomize"
        Me.Rbtn.UseVisualStyleBackColor = True
        '
        'selectbox
        '
        Me.selectbox.FormattingEnabled = True
        Me.selectbox.Location = New System.Drawing.Point(207, 85)
        Me.selectbox.Name = "selectbox"
        Me.selectbox.Size = New System.Drawing.Size(121, 21)
        Me.selectbox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(182, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "What do you want to randomize?"
        '
        'resbtn
        '
        Me.resbtn.Location = New System.Drawing.Point(12, 462)
        Me.resbtn.Name = "resbtn"
        Me.resbtn.Size = New System.Drawing.Size(94, 33)
        Me.resbtn.TabIndex = 3
        Me.resbtn.Text = "Reset"
        Me.resbtn.UseVisualStyleBackColor = True
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(88, 416)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(100, 20)
        Me.tb2.TabIndex = 4
        '
        'tb4
        '
        Me.tb4.Location = New System.Drawing.Point(352, 416)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(100, 20)
        Me.tb4.TabIndex = 5
        '
        'tb3
        '
        Me.tb3.Location = New System.Drawing.Point(352, 303)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(100, 20)
        Me.tb3.TabIndex = 6
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(88, 303)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(100, 20)
        Me.tb1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 507)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.tb3)
        Me.Controls.Add(Me.tb4)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.resbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.selectbox)
        Me.Controls.Add(Me.Rbtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rbtn As Button
    Friend WithEvents selectbox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents resbtn As Button
    Friend WithEvents tb2 As TextBox
    Friend WithEvents tb4 As TextBox
    Friend WithEvents tb3 As TextBox
    Friend WithEvents tb1 As TextBox
End Class
