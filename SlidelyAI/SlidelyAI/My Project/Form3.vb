Public Class Form3
    Private stopwatchRunning As Boolean = False
    Private elapsedTime As TimeSpan = TimeSpan.Zero
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblStopwatch.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
    Private Sub stopwatchTimer_Tick(sender As Object, e As EventArgs) Handles stopwatchTimer.Tick
        If stopwatchRunning Then
            elapsedTime += TimeSpan.FromSeconds(1)
            lblStopwatch.Text = elapsedTime.ToString("hh\:mm\:ss")
        End If
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs)
        If stopwatchRunning Then
            ' Pause the stopwatch
            stopwatchTimer.Stop()
        Else
            ' Resume the stopwatch
            stopwatchTimer.Start()
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        End If
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class