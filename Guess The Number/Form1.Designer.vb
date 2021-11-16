<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuess
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
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.lblGuess = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGuess
        '
        Me.btnGuess.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnGuess.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGuess.Location = New System.Drawing.Point(158, 85)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(263, 47)
        Me.btnGuess.TabIndex = 0
        Me.btnGuess.Text = "Guess The Number"
        Me.btnGuess.UseVisualStyleBackColor = False
        '
        'lblGuess
        '
        Me.lblGuess.AutoSize = True
        Me.lblGuess.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGuess.ForeColor = System.Drawing.Color.Green
        Me.lblGuess.Location = New System.Drawing.Point(73, 9)
        Me.lblGuess.Name = "lblGuess"
        Me.lblGuess.Size = New System.Drawing.Size(478, 26)
        Me.lblGuess.TabIndex = 1
        Me.lblGuess.Text = "Welcome To Ashley's Guess The Number Program"
        '
        'frmGuess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(587, 159)
        Me.Controls.Add(Me.lblGuess)
        Me.Controls.Add(Me.btnGuess)
        Me.Name = "frmGuess"
        Me.Text = "Guess The Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuess As Button
    Friend WithEvents lblGuess As Label
End Class
