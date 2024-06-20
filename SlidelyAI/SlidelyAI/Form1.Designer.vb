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
        Me.btnCreateNewSubmission = New System.Windows.Forms.Button()
        Me.btnViewSubmission = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCreateNewSubmission
        '
        Me.btnCreateNewSubmission.Location = New System.Drawing.Point(153, 275)
        Me.btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        Me.btnCreateNewSubmission.Size = New System.Drawing.Size(492, 122)
        Me.btnCreateNewSubmission.TabIndex = 1
        Me.btnCreateNewSubmission.Text = "&Create New Submission (CRTL + N)"
        Me.btnCreateNewSubmission.UseVisualStyleBackColor = True
        '
        'btnViewSubmission
        '
        Me.btnViewSubmission.Location = New System.Drawing.Point(153, 139)
        Me.btnViewSubmission.Name = "btnViewSubmission"
        Me.btnViewSubmission.Size = New System.Drawing.Size(492, 110)
        Me.btnViewSubmission.TabIndex = 2
        Me.btnViewSubmission.Text = "&View Submissions (CRTL + V)"
        Me.btnViewSubmission.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(188, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(399, 26)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Belo Abhigyan , Slidely Task - 2 Slidely Form App "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnViewSubmission)
        Me.Controls.Add(Me.btnCreateNewSubmission)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents btnViewSubmission As Button
    Friend WithEvents TextBox1 As TextBox
End Class
