Imports Newtonsoft.Json
Imports System.Net
Imports System.Diagnostics

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnToggleStopwatch.Text = "Resume"
        Else
            stopwatch.Start()
            btnToggleStopwatch.Text = "Pause"
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim client As New WebClient()
        client.Headers(HttpRequestHeader.ContentType) = "application/json"
        Dim submission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GitHubLink = txtGitHub.Text,
            .StopwatchTime = stopwatch.Elapsed.TotalSeconds
        }
        Dim json As String = JsonConvert.SerializeObject(submission)
        client.UploadString("http://localhost:3000/submit", "POST", json)
        MessageBox.Show("Submission successful!")
    End Sub

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GitHubLink As String
        Public Property StopwatchTime As Double
    End Class
End Class
