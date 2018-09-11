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
        Me.resbtn = New System.Windows.Forms.Button()
        Me.Box2 = New System.Windows.Forms.TextBox()
        Me.Box4 = New System.Windows.Forms.TextBox()
        Me.Box3 = New System.Windows.Forms.TextBox()
        Me.Box1 = New System.Windows.Forms.TextBox()
        Me.NBox1 = New System.Windows.Forms.TextBox()
        Me.NBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Min = New System.Windows.Forms.Label()
        Me.Max = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Rbtn
        '
        Me.Rbtn.Enabled = False
        Me.Rbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbtn.Location = New System.Drawing.Point(194, 175)
        Me.Rbtn.Name = "Rbtn"
        Me.Rbtn.Size = New System.Drawing.Size(151, 60)
        Me.Rbtn.TabIndex = 0
        Me.Rbtn.Text = "Randomize"
        Me.Rbtn.UseVisualStyleBackColor = True
        '
        'selectbox
        '
        Me.selectbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectbox.FormattingEnabled = True
        Me.selectbox.Items.AddRange(New Object() {"Numbers", "Input"})
        Me.selectbox.Location = New System.Drawing.Point(208, 123)
        Me.selectbox.Name = "selectbox"
        Me.selectbox.Size = New System.Drawing.Size(121, 21)
        Me.selectbox.TabIndex = 1
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
        'Box2
        '
        Me.Box2.Location = New System.Drawing.Point(88, 416)
        Me.Box2.Name = "Box2"
        Me.Box2.Size = New System.Drawing.Size(100, 20)
        Me.Box2.TabIndex = 4
        Me.Box2.Visible = False
        '
        'Box4
        '
        Me.Box4.Location = New System.Drawing.Point(352, 416)
        Me.Box4.Name = "Box4"
        Me.Box4.Size = New System.Drawing.Size(100, 20)
        Me.Box4.TabIndex = 5
        Me.Box4.Visible = False
        '
        'Box3
        '
        Me.Box3.Location = New System.Drawing.Point(352, 303)
        Me.Box3.Name = "Box3"
        Me.Box3.Size = New System.Drawing.Size(100, 20)
        Me.Box3.TabIndex = 6
        Me.Box3.Visible = False
        '
        'Box1
        '
        Me.Box1.Location = New System.Drawing.Point(88, 303)
        Me.Box1.Name = "Box1"
        Me.Box1.Size = New System.Drawing.Size(100, 20)
        Me.Box1.TabIndex = 7
        Me.Box1.Visible = False
        '
        'NBox1
        '
        Me.NBox1.Location = New System.Drawing.Point(115, 360)
        Me.NBox1.Name = "NBox1"
        Me.NBox1.Size = New System.Drawing.Size(100, 20)
        Me.NBox1.TabIndex = 8
        Me.NBox1.Visible = False
        '
        'NBox2
        '
        Me.NBox2.Location = New System.Drawing.Point(324, 360)
        Me.NBox2.Name = "NBox2"
        Me.NBox2.Size = New System.Drawing.Size(100, 20)
        Me.NBox2.TabIndex = 9
        Me.NBox2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "What do you want to randomize?"
        '
        'Min
        '
        Me.Min.AutoSize = True
        Me.Min.Location = New System.Drawing.Point(140, 344)
        Me.Min.Name = "Min"
        Me.Min.Size = New System.Drawing.Size(48, 13)
        Me.Min.TabIndex = 10
        Me.Min.Text = "Minimum"
        Me.Min.Visible = False
        '
        'Max
        '
        Me.Max.AutoSize = True
        Me.Max.Location = New System.Drawing.Point(349, 344)
        Me.Max.Name = "Max"
        Me.Max.Size = New System.Drawing.Size(51, 13)
        Me.Max.TabIndex = 11
        Me.Max.Text = "Maximum"
        Me.Max.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 507)
        Me.Controls.Add(Me.Max)
        Me.Controls.Add(Me.Min)
        Me.Controls.Add(Me.Rbtn)
        Me.Controls.Add(Me.NBox2)
        Me.Controls.Add(Me.NBox1)
        Me.Controls.Add(Me.Box1)
        Me.Controls.Add(Me.Box3)
        Me.Controls.Add(Me.Box4)
        Me.Controls.Add(Me.Box2)
        Me.Controls.Add(Me.resbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.selectbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rbtn As Button
    Friend WithEvents selectbox As ComboBox
    Friend WithEvents resbtn As Button
    Friend WithEvents Box2 As TextBox
    Friend WithEvents Box4 As TextBox
    Friend WithEvents Box3 As TextBox
    Friend WithEvents Box1 As TextBox
    Friend WithEvents NBox1 As TextBox
    Friend WithEvents NBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Min As Label
    Friend WithEvents Max As Label
End Class
