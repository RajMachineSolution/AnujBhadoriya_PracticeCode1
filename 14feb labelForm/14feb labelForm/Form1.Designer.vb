﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.UserControl11 = New _14feb_label_UserControl.UserControl1()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'UserControl11
        '
        Me.UserControl11.AutoSize = True
        Me.UserControl11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UserControl11.ConsecutiveNumber = 20
        Me.UserControl11.Location = New System.Drawing.Point(63, 89)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(112, 43)
        Me.UserControl11.StartAt = 0
        Me.UserControl11.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UserControl11)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserControl11 As _14feb_label_UserControl.UserControl1
    Friend WithEvents Timer1 As Timer
End Class
