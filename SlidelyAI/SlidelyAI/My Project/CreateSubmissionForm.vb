Public Class Label
    Private stopwatchRunning As Boolean = False
    Private elapsedTime As TimeSpan = TimeSpan.Zero
    Private stopwatchStartTime As DateTime

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Example: Submit data to backend
        Dim name As String = Label1.Text
        Dim email As String = Label2.Text
        Dim phoneNumber As String = Label3.Text
        Dim githubLink As String = Label4.Text
        Dim stopwatchTime As String = lblStopwatchTime.Text

        ' You would typically send this data to your backend using API calls or other methods
        ' Example: Send data to backend
        ' BackendService.SubmitData(name, email, phoneNumber, githubLink, stopwatchTime)

        ' Optionally, close the form after submission
        Me.Close()
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblStopwatchTime.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If stopwatchRunning Then
            ' Pause the stopwatch
            stopwatchRunning = False
            stopwatchTimer.Stop()
        Else
            ' Start or resume the stopwatch
            stopwatchRunning = True
            stopwatchStartTime = DateTime.Now.Subtract(elapsedTime)
            stopwatchTimer.Start()
        End If
    End Sub

    Private Sub stopwatchTimer_Tick(sender As Object, e As EventArgs) Handles stopwatchTimer.Tick
        If stopwatchRunning Then
            elapsedTime = DateTime.Now.Subtract(stopwatchStartTime)
            lblStopwatchTime.Text = elapsedTime.ToString("hh\:mm\:ss")
        End If
    End Sub
End Class