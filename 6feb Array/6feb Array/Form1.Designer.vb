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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.txtStringArray0 = New System.Windows.Forms.TextBox()
        Me.txtStringArray1 = New System.Windows.Forms.TextBox()
        Me.txtStringArray2 = New System.Windows.Forms.TextBox()
        Me.txtStringArray3 = New System.Windows.Forms.TextBox()
        Me.txtStringArray4 = New System.Windows.Forms.TextBox()
        Me.txtStringArray5 = New System.Windows.Forms.TextBox()
        Me.txtTimes = New System.Windows.Forms.TextBox()
        Me.txtStartAt = New System.Windows.Forms.TextBox()
        Me.txtEndAt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(131, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "result"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(63, 258)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(235, 160)
        Me.ListBox1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(478, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "StringArray"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(409, 258)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(229, 160)
        Me.ListBox2.TabIndex = 3
        '
        'txtStringArray0
        '
        Me.txtStringArray0.Location = New System.Drawing.Point(665, 79)
        Me.txtStringArray0.Name = "txtStringArray0"
        Me.txtStringArray0.Size = New System.Drawing.Size(100, 20)
        Me.txtStringArray0.TabIndex = 4
        '
        'txtStringArray1
        '
        Me.txtStringArray1.Location = New System.Drawing.Point(665, 105)
        Me.txtStringArray1.Name = "txtStringArray1"
        Me.txtStringArray1.Size = New System.Drawing.Size(100, 20)
        Me.txtStringArray1.TabIndex = 5
        '
        'txtStringArray2
        '
        Me.txtStringArray2.Location = New System.Drawing.Point(665, 131)
        Me.txtStringArray2.Name = "txtStringArray2"
        Me.txtStringArray2.Size = New System.Drawing.Size(100, 20)
        Me.txtStringArray2.TabIndex = 6
        '
        'txtStringArray3
        '
        Me.txtStringArray3.Location = New System.Drawing.Point(665, 157)
        Me.txtStringArray3.Name = "txtStringArray3"
        Me.txtStringArray3.Size = New System.Drawing.Size(100, 20)
        Me.txtStringArray3.TabIndex = 7
        '
        'txtStringArray4
        '
        Me.txtStringArray4.Location = New System.Drawing.Point(665, 183)
        Me.txtStringArray4.Name = "txtStringArray4"
        Me.txtStringArray4.Size = New System.Drawing.Size(100, 20)
        Me.txtStringArray4.TabIndex = 8
        '
        'txtStringArray5
        '
        Me.txtStringArray5.Location = New System.Drawing.Point(665, 209)
        Me.txtStringArray5.Name = "txtStringArray5"
        Me.txtStringArray5.Size = New System.Drawing.Size(100, 20)
        Me.txtStringArray5.TabIndex = 9
        '
        'txtTimes
        '
        Me.txtTimes.Location = New System.Drawing.Point(106, 61)
        Me.txtTimes.Name = "txtTimes"
        Me.txtTimes.Size = New System.Drawing.Size(100, 20)
        Me.txtTimes.TabIndex = 10
        '
        'txtStartAt
        '
        Me.txtStartAt.Location = New System.Drawing.Point(106, 105)
        Me.txtStartAt.Name = "txtStartAt"
        Me.txtStartAt.Size = New System.Drawing.Size(100, 20)
        Me.txtStartAt.TabIndex = 11
        '
        'txtEndAt
        '
        Me.txtEndAt.Location = New System.Drawing.Point(106, 145)
        Me.txtEndAt.Name = "txtEndAt"
        Me.txtEndAt.Size = New System.Drawing.Size(100, 20)
        Me.txtEndAt.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "which times table?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "StartAt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "EndAt"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEndAt)
        Me.Controls.Add(Me.txtStartAt)
        Me.Controls.Add(Me.txtTimes)
        Me.Controls.Add(Me.txtStringArray5)
        Me.Controls.Add(Me.txtStringArray4)
        Me.Controls.Add(Me.txtStringArray3)
        Me.Controls.Add(Me.txtStringArray2)
        Me.Controls.Add(Me.txtStringArray1)
        Me.Controls.Add(Me.txtStringArray0)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents txtStringArray0 As TextBox
    Friend WithEvents txtStringArray1 As TextBox
    Friend WithEvents txtStringArray2 As TextBox
    Friend WithEvents txtStringArray3 As TextBox
    Friend WithEvents txtStringArray4 As TextBox
    Friend WithEvents txtStringArray5 As TextBox
    Friend WithEvents txtTimes As TextBox
    Friend WithEvents txtStartAt As TextBox
    Friend WithEvents txtEndAt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
