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
        Me.InputField = New System.Windows.Forms.TextBox()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.WebServiceButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InputField
        '
        Me.InputField.Location = New System.Drawing.Point(26, 88)
        Me.InputField.Name = "InputField"
        Me.InputField.Size = New System.Drawing.Size(163, 20)
        Me.InputField.TabIndex = 0
        '
        'GenerateButton
        '
        Me.GenerateButton.Location = New System.Drawing.Point(195, 86)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(75, 23)
        Me.GenerateButton.TabIndex = 1
        Me.GenerateButton.Text = "Generate!"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'ResultLabel
        '
        Me.ResultLabel.AutoSize = True
        Me.ResultLabel.Location = New System.Drawing.Point(26, 136)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(63, 13)
        Me.ResultLabel.TabIndex = 2
        Me.ResultLabel.Text = "Placeholder"
        '
        'WebServiceButton
        '
        Me.WebServiceButton.Location = New System.Drawing.Point(195, 115)
        Me.WebServiceButton.Name = "WebServiceButton"
        Me.WebServiceButton.Size = New System.Drawing.Size(75, 34)
        Me.WebServiceButton.TabIndex = 3
        Me.WebServiceButton.Text = "Call Web Service"
        Me.WebServiceButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.WebServiceButton)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.InputField)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputField As TextBox
    Friend WithEvents GenerateButton As Button
    Friend WithEvents ResultLabel As Label
    Friend WithEvents WebServiceButton As Button
End Class
