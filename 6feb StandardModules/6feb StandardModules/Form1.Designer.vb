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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnFileName = New System.Windows.Forms.Button()
        Me.txtFileNames = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnGetAllFileNames = New System.Windows.Forms.Button()
        Me.btnGetRandomFile = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(124, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnFileName
        '
        Me.btnFileName.Location = New System.Drawing.Point(246, 130)
        Me.btnFileName.Name = "btnFileName"
        Me.btnFileName.Size = New System.Drawing.Size(100, 23)
        Me.btnFileName.TabIndex = 2
        Me.btnFileName.Text = "Get All FilePath"
        Me.btnFileName.UseVisualStyleBackColor = True
        '
        'txtFileNames
        '
        Me.txtFileNames.FormattingEnabled = True
        Me.txtFileNames.Location = New System.Drawing.Point(212, 159)
        Me.txtFileNames.Name = "txtFileNames"
        Me.txtFileNames.Size = New System.Drawing.Size(198, 147)
        Me.txtFileNames.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(425, 159)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(165, 147)
        Me.ListBox1.TabIndex = 4
        '
        'btnGetAllFileNames
        '
        Me.btnGetAllFileNames.Location = New System.Drawing.Point(463, 116)
        Me.btnGetAllFileNames.Name = "btnGetAllFileNames"
        Me.btnGetAllFileNames.Size = New System.Drawing.Size(75, 23)
        Me.btnGetAllFileNames.TabIndex = 5
        Me.btnGetAllFileNames.Text = "getAll Files"
        Me.btnGetAllFileNames.UseVisualStyleBackColor = True
        '
        'btnGetRandomFile
        '
        Me.btnGetRandomFile.Location = New System.Drawing.Point(646, 116)
        Me.btnGetRandomFile.Name = "btnGetRandomFile"
        Me.btnGetRandomFile.Size = New System.Drawing.Size(75, 23)
        Me.btnGetRandomFile.TabIndex = 6
        Me.btnGetRandomFile.Text = "RandomFile"
        Me.btnGetRandomFile.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(636, 159)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 147)
        Me.ListBox2.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(42, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "getFile Extension"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(42, 211)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(120, 95)
        Me.ListBox3.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(30, 354)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "getAll Files and Folder"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(206, 343)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(204, 95)
        Me.ListBox4.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.btnGetRandomFile)
        Me.Controls.Add(Me.btnGetAllFileNames)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtFileNames)
        Me.Controls.Add(Me.btnFileName)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnFileName As Button
    Friend WithEvents txtFileNames As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnGetAllFileNames As Button
    Friend WithEvents btnGetRandomFile As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ListBox4 As ListBox
End Class
