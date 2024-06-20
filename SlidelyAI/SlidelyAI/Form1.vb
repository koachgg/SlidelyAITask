


Public Class Form1
    Private Sub btnViewSubmission_Click(sender As Object, e As EventArgs) Handles btnViewSubmission.Click
        Dim viewSubmissionsForm As New Form3()
        viewSubmissionsForm.Show()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createSubmissionForm As New Label
        createSubmissionForm.Show()
    End Sub
End Class
