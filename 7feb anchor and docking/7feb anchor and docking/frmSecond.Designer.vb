<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecond
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optUpperCase = New System.Windows.Forms.RadioButton()
        Me.optLowerCase = New System.Windows.Forms.RadioButton()
        Me.optProperCase = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(47, 235)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(183, 235)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Change Case"
        '
        'optUpperCase
        '
        Me.optUpperCase.AutoSize = True
        Me.optUpperCase.Location = New System.Drawing.Point(78, 94)
        Me.optUpperCase.Name = "optUpperCase"
        Me.optUpperCase.Size = New System.Drawing.Size(78, 17)
        Me.optUpperCase.TabIndex = 3
        Me.optUpperCase.TabStop = True
        Me.optUpperCase.Text = "UpperCase"
        Me.optUpperCase.UseVisualStyleBackColor = True
        '
        'optLowerCase
        '
        Me.optLowerCase.AutoSize = True
        Me.optLowerCase.Location = New System.Drawing.Point(78, 131)
        Me.optLowerCase.Name = "optLowerCase"
        Me.optLowerCase.Size = New System.Drawing.Size(78, 17)
        Me.optLowerCase.TabIndex = 4
        Me.optLowerCase.TabStop = True
        Me.optLowerCase.Text = "LowerCase"
        Me.optLowerCase.UseVisualStyleBackColor = True
        '
        'optProperCase
        '
        Me.optProperCase.AutoSize = True
        Me.optProperCase.Location = New System.Drawing.Point(78, 171)
        Me.optProperCase.Name = "optProperCase"
        Me.optProperCase.Size = New System.Drawing.Size(80, 17)
        Me.optProperCase.TabIndex = 5
        Me.optProperCase.TabStop = True
        Me.optProperCase.Text = "ProperCase"
        Me.optProperCase.UseVisualStyleBackColor = True
        '
        'frmSecond
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.optProperCase)
        Me.Controls.Add(Me.optLowerCase)
        Me.Controls.Add(Me.optUpperCase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "frmSecond"
        Me.Text = "frmSecond"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents optUpperCase As RadioButton
    Friend WithEvents optLowerCase As RadioButton
    Friend WithEvents optProperCase As RadioButton
End Class
