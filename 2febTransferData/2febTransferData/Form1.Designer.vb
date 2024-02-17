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
        Me.IblTransfer = New System.Windows.Forms.Label()
        Me.txtVariable = New System.Windows.Forms.TextBox()
        Me.btntransfer = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'IblTransfer
        '
        Me.IblTransfer.AutoSize = True
        Me.IblTransfer.BackColor = System.Drawing.Color.Silver
        Me.IblTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IblTransfer.Location = New System.Drawing.Point(212, 60)
        Me.IblTransfer.Name = "IblTransfer"
        Me.IblTransfer.Size = New System.Drawing.Size(125, 24)
        Me.IblTransfer.TabIndex = 0
        Me.IblTransfer.Text = "Label Caption"
        '
        'txtVariable
        '
        Me.txtVariable.Location = New System.Drawing.Point(216, 132)
        Me.txtVariable.Multiline = True
        Me.txtVariable.Name = "txtVariable"
        Me.txtVariable.Size = New System.Drawing.Size(133, 33)
        Me.txtVariable.TabIndex = 1
        '
        'btntransfer
        '
        Me.btntransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntransfer.Location = New System.Drawing.Point(216, 229)
        Me.btntransfer.Name = "btntransfer"
        Me.btntransfer.Size = New System.Drawing.Size(133, 39)
        Me.btntransfer.TabIndex = 2
        Me.btntransfer.Text = "Transfer"
        Me.btntransfer.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(216, 192)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 31)
        Me.TextBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btntransfer)
        Me.Controls.Add(Me.txtVariable)
        Me.Controls.Add(Me.IblTransfer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IblTransfer As Label
    Friend WithEvents txtVariable As TextBox
    Friend WithEvents btntransfer As Button
    Friend WithEvents TextBox1 As TextBox
End Class
