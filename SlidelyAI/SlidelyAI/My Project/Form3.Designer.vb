<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.stopwatchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(148, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 85)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Previous (CTRL + P)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(456, 342)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 77)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "NEXT (CTRL + N)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(228, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(356, 26)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Belo Abhigyan, Slidely Task -2 View Submission"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(415, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(130, 26)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "John Doe"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(415, 135)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(169, 26)
        Me.TextBox8.TabIndex = 9
        Me.TextBox8.Text = "johndoe@gmail.com"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(415, 183)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(130, 26)
        Me.TextBox9.TabIndex = 10
        Me.TextBox9.Text = "9876543210"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(415, 234)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(151, 26)
        Me.TextBox11.TabIndex = 12
        Me.TextBox11.Text = "github.com/koachgg"
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Location = New System.Drawing.Point(452, 292)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(71, 20)
        Me.lblStopwatch.TabIndex = 13
        Me.lblStopwatch.Text = "00:00:00"
        '
        'stopwatchTimer
        '
        Me.stopwatchTimer.Interval = 1000
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(61, 288)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(279, 44)
        Me.btnToggleStopwatch.TabIndex = 14
        Me.btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Phone num"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "GitHub Link for Task - 2"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "ViewSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents lblStopwatch As Windows.Forms.Label
    Friend WithEvents stopwatchTimer As Timer
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
End Class
