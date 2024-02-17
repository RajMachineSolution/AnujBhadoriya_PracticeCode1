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
        Me.TxtEnd = New System.Windows.Forms.TextBox()
        Me.TxtStart = New System.Windows.Forms.TextBox()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'TxtEnd
        '
        Me.TxtEnd.Location = New System.Drawing.Point(402, 121)
        Me.TxtEnd.Multiline = True
        Me.TxtEnd.Name = "TxtEnd"
        Me.TxtEnd.Size = New System.Drawing.Size(100, 34)
        Me.TxtEnd.TabIndex = 0
        '
        'TxtStart
        '
        Me.TxtStart.Location = New System.Drawing.Point(402, 62)
        Me.TxtStart.Multiline = True
        Me.TxtStart.Name = "TxtStart"
        Me.TxtStart.Size = New System.Drawing.Size(100, 30)
        Me.TxtStart.TabIndex = 1
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(281, 135)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(59, 20)
        Me.lblEnd.TabIndex = 2
        Me.lblEnd.Text = "EndAt"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(281, 72)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(64, 20)
        Me.lblStart.TabIndex = 3
        Me.lblStart.Text = "startAt"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(356, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(280, 264)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(222, 95)
        Me.ListBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.TxtStart)
        Me.Controls.Add(Me.TxtEnd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtEnd As TextBox
    Friend WithEvents TxtStart As TextBox
    Friend WithEvents lblEnd As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
End Class
