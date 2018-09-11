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
        Me.Eqsign = New System.Windows.Forms.Label()
        Me.Ans = New System.Windows.Forms.Label()
        Me.Operationcbo = New System.Windows.Forms.ComboBox()
        Me.TextNum1 = New System.Windows.Forms.TextBox()
        Me.TextNum2 = New System.Windows.Forms.TextBox()
        Me.Calcbtn = New System.Windows.Forms.Button()
        Me.Resetbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Eqsign
        '
        Me.Eqsign.AutoSize = True
        Me.Eqsign.Location = New System.Drawing.Point(358, 186)
        Me.Eqsign.Name = "Eqsign"
        Me.Eqsign.Size = New System.Drawing.Size(13, 13)
        Me.Eqsign.TabIndex = 0
        Me.Eqsign.Text = "="
        '
        'Ans
        '
        Me.Ans.AutoSize = True
        Me.Ans.Location = New System.Drawing.Point(377, 186)
        Me.Ans.Name = "Ans"
        Me.Ans.Size = New System.Drawing.Size(13, 13)
        Me.Ans.TabIndex = 1
        Me.Ans.Text = "0"
        '
        'Operationcbo
        '
        Me.Operationcbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Operationcbo.FormattingEnabled = True
        Me.Operationcbo.Items.AddRange(New Object() {"+", "-", "*", "/", "√"})
        Me.Operationcbo.Location = New System.Drawing.Point(224, 183)
        Me.Operationcbo.Name = "Operationcbo"
        Me.Operationcbo.Size = New System.Drawing.Size(32, 21)
        Me.Operationcbo.TabIndex = 2
        '
        'TextNum1
        '
        Me.TextNum1.Location = New System.Drawing.Point(108, 183)
        Me.TextNum1.Name = "TextNum1"
        Me.TextNum1.Size = New System.Drawing.Size(110, 20)
        Me.TextNum1.TabIndex = 3
        '
        'TextNum2
        '
        Me.TextNum2.Location = New System.Drawing.Point(262, 183)
        Me.TextNum2.Name = "TextNum2"
        Me.TextNum2.Size = New System.Drawing.Size(90, 20)
        Me.TextNum2.TabIndex = 4
        '
        'Calcbtn
        '
        Me.Calcbtn.Location = New System.Drawing.Point(204, 320)
        Me.Calcbtn.Name = "Calcbtn"
        Me.Calcbtn.Size = New System.Drawing.Size(75, 23)
        Me.Calcbtn.TabIndex = 5
        Me.Calcbtn.Text = "Calculate"
        Me.Calcbtn.UseVisualStyleBackColor = True
        '
        'Resetbtn
        '
        Me.Resetbtn.Location = New System.Drawing.Point(-1, 369)
        Me.Resetbtn.Name = "Resetbtn"
        Me.Resetbtn.Size = New System.Drawing.Size(75, 23)
        Me.Resetbtn.TabIndex = 6
        Me.Resetbtn.Text = "Reset"
        Me.Resetbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 391)
        Me.Controls.Add(Me.Resetbtn)
        Me.Controls.Add(Me.Calcbtn)
        Me.Controls.Add(Me.TextNum2)
        Me.Controls.Add(Me.TextNum1)
        Me.Controls.Add(Me.Operationcbo)
        Me.Controls.Add(Me.Ans)
        Me.Controls.Add(Me.Eqsign)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Eqsign As Label
    Friend WithEvents Ans As Label
    Friend WithEvents Operationcbo As ComboBox
    Friend WithEvents TextNum1 As TextBox
    Friend WithEvents TextNum2 As TextBox
    Friend WithEvents Calcbtn As Button
    Friend WithEvents Resetbtn As Button
End Class
