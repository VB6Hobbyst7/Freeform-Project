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
        Me.Credscore = New System.Windows.Forms.TextBox()
        Me.TotInt = New System.Windows.Forms.TextBox()
        Me.CarValue = New System.Windows.Forms.TextBox()
        Me.yearbox = New System.Windows.Forms.TextBox()
        Me.Income = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Monthslbl = New System.Windows.Forms.Label()
        Me.Carlbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.APR = New System.Windows.Forms.TextBox()
        Me.Monthlypaytxt = New System.Windows.Forms.TextBox()
        Me.Totalcostbox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Debt = New System.Windows.Forms.TextBox()
        Me.Calcbtn = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'Credscore
        '
        Me.Credscore.Enabled = False
        Me.Credscore.Location = New System.Drawing.Point(53, 178)
        Me.Credscore.Name = "Credscore"
        Me.Credscore.Size = New System.Drawing.Size(100, 20)
        Me.Credscore.TabIndex = 0
        '
        'TotInt
        '
        Me.TotInt.Enabled = False
        Me.TotInt.Location = New System.Drawing.Point(53, 333)
        Me.TotInt.Name = "TotInt"
        Me.TotInt.ReadOnly = True
        Me.TotInt.Size = New System.Drawing.Size(100, 20)
        Me.TotInt.TabIndex = 1
        '
        'CarValue
        '
        Me.CarValue.Enabled = False
        Me.CarValue.Location = New System.Drawing.Point(53, 227)
        Me.CarValue.Name = "CarValue"
        Me.CarValue.Size = New System.Drawing.Size(100, 20)
        Me.CarValue.TabIndex = 5
        '
        'yearbox
        '
        Me.yearbox.Enabled = False
        Me.yearbox.Location = New System.Drawing.Point(53, 278)
        Me.yearbox.Name = "yearbox"
        Me.yearbox.Size = New System.Drawing.Size(100, 20)
        Me.yearbox.TabIndex = 6
        '
        'Income
        '
        Me.Income.Location = New System.Drawing.Point(304, 128)
        Me.Income.Name = "Income"
        Me.Income.Size = New System.Drawing.Size(113, 20)
        Me.Income.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Credit Score"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Total Interest"
        '
        'Monthslbl
        '
        Me.Monthslbl.AutoSize = True
        Me.Monthslbl.Location = New System.Drawing.Point(81, 262)
        Me.Monthslbl.Name = "Monthslbl"
        Me.Monthslbl.Size = New System.Drawing.Size(42, 13)
        Me.Monthslbl.TabIndex = 11
        Me.Monthslbl.Text = "Months"
        '
        'Carlbl
        '
        Me.Carlbl.AutoSize = True
        Me.Carlbl.Location = New System.Drawing.Point(76, 211)
        Me.Carlbl.Name = "Carlbl"
        Me.Carlbl.Size = New System.Drawing.Size(53, 13)
        Me.Carlbl.TabIndex = 12
        Me.Carlbl.Text = "Car Value"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(81, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(262, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 24)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Can you receive a loan?"
        '
        'APR
        '
        Me.APR.Location = New System.Drawing.Point(574, 437)
        Me.APR.Name = "APR"
        Me.APR.ReadOnly = True
        Me.APR.Size = New System.Drawing.Size(100, 20)
        Me.APR.TabIndex = 17
        '
        'Monthlypaytxt
        '
        Me.Monthlypaytxt.Location = New System.Drawing.Point(574, 348)
        Me.Monthlypaytxt.Name = "Monthlypaytxt"
        Me.Monthlypaytxt.ReadOnly = True
        Me.Monthlypaytxt.Size = New System.Drawing.Size(100, 20)
        Me.Monthlypaytxt.TabIndex = 18
        '
        'Totalcostbox
        '
        Me.Totalcostbox.Location = New System.Drawing.Point(574, 265)
        Me.Totalcostbox.Name = "Totalcostbox"
        Me.Totalcostbox.ReadOnly = True
        Me.Totalcostbox.Size = New System.Drawing.Size(100, 20)
        Me.Totalcostbox.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(601, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Total Cost"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(283, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 30)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Am I eligible for a Loan?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(611, 421)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "APR"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(581, 332)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Monthly Payment"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(345, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Debt"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(321, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Monthly Income"
        '
        'Debt
        '
        Me.Debt.Location = New System.Drawing.Point(304, 68)
        Me.Debt.Name = "Debt"
        Me.Debt.Size = New System.Drawing.Size(113, 20)
        Me.Debt.TabIndex = 7
        '
        'Calcbtn
        '
        Me.Calcbtn.Location = New System.Drawing.Point(288, 308)
        Me.Calcbtn.Name = "Calcbtn"
        Me.Calcbtn.Size = New System.Drawing.Size(152, 61)
        Me.Calcbtn.TabIndex = 26
        Me.Calcbtn.Text = "Calculate"
        Me.Calcbtn.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 532)
        Me.Controls.Add(Me.Calcbtn)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Totalcostbox)
        Me.Controls.Add(Me.Monthlypaytxt)
        Me.Controls.Add(Me.APR)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Carlbl)
        Me.Controls.Add(Me.Monthslbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Debt)
        Me.Controls.Add(Me.Income)
        Me.Controls.Add(Me.yearbox)
        Me.Controls.Add(Me.CarValue)
        Me.Controls.Add(Me.TotInt)
        Me.Controls.Add(Me.Credscore)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Credscore As TextBox
    Friend WithEvents TotInt As TextBox
    Friend WithEvents CarValue As TextBox
    Friend WithEvents yearbox As TextBox
    Friend WithEvents Income As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Monthslbl As Label
    Friend WithEvents Carlbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents APR As TextBox
    Friend WithEvents Monthlypaytxt As TextBox
    Friend WithEvents Totalcostbox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Debt As TextBox
    Friend WithEvents Calcbtn As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
