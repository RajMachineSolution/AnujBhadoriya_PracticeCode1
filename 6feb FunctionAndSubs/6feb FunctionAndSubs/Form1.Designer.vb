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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtFirstNumber = New System.Windows.Forms.TextBox()
        Me.txtSecondNumber = New System.Windows.Forms.TextBox()
        Me.btnCheckEmail = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.txtFunction = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtFirstNumber
        '
        Me.TxtFirstNumber.Location = New System.Drawing.Point(37, 12)
        Me.TxtFirstNumber.Name = "TxtFirstNumber"
        Me.TxtFirstNumber.Size = New System.Drawing.Size(100, 20)
        Me.TxtFirstNumber.TabIndex = 1
        '
        'txtSecondNumber
        '
        Me.txtSecondNumber.Location = New System.Drawing.Point(164, 12)
        Me.txtSecondNumber.Name = "txtSecondNumber"
        Me.txtSecondNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtSecondNumber.TabIndex = 2
        '
        'btnCheckEmail
        '
        Me.btnCheckEmail.Location = New System.Drawing.Point(113, 169)
        Me.btnCheckEmail.Name = "btnCheckEmail"
        Me.btnCheckEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckEmail.TabIndex = 3
        Me.btnCheckEmail.Text = "Check Email"
        Me.btnCheckEmail.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(87, 133)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 20)
        Me.TextBox1.TabIndex = 4
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(113, 274)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 5
        Me.btnReturn.Text = "return Value"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'txtFunction
        '
        Me.txtFunction.Location = New System.Drawing.Point(99, 236)
        Me.txtFunction.Name = "txtFunction"
        Me.txtFunction.Size = New System.Drawing.Size(133, 20)
        Me.txtFunction.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtFunction)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCheckEmail)
        Me.Controls.Add(Me.txtSecondNumber)
        Me.Controls.Add(Me.TxtFirstNumber)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TxtFirstNumber As TextBox
    Friend WithEvents txtSecondNumber As TextBox
    Friend WithEvents btnCheckEmail As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents txtFunction As TextBox
End Class
