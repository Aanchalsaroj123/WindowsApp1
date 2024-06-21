Imports Newtonsoft.Json
Imports System.Net
Imports System.Diagnostics
Imports System.Threading.Tasks

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

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Log the values being submitted
        Debug.WriteLine("Name: " & txtName.Text)
        Debug.WriteLine("Email: " & txtEmail.Text)
        Debug.WriteLine("Phone: " & txtPhone.Text)
        Debug.WriteLine("GitHub: " & txtGitHub.Text)
        Debug.WriteLine("Stopwatch Time: " & stopwatch.Elapsed.TotalSeconds)

        Dim submission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GitHubLink = txtGitHub.Text,
            .StopwatchTime = stopwatch.Elapsed.TotalSeconds
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Debug.WriteLine("Serialized JSON: " & json)

        Using client As New WebClient()
            client.Headers(HttpRequestHeader.ContentType) = "application/json"
            Try
                Debug.WriteLine("Submitting JSON: " & json)
                Await client.UploadStringTaskAsync("http://localhost:3000/submit", "POST", json)
                MessageBox.Show("Submission successful!")
            Catch ex As Exception
                MessageBox.Show("Submission failed: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GitHubLink As String
        Public Property StopwatchTime As Double
    End Class
End Class
