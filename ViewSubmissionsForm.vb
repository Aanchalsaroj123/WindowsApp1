Imports Newtonsoft.Json
Imports System.Net

Public Class ViewSubmissionsForm
    Private currentSubmissionIndex As Integer = 0
    Private submissions As List(Of Submission)

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmissions()
        DisplaySubmission()
    End Sub

    Private Sub LoadSubmissions()
        Try
            Dim client As New WebClient()
            Dim response As String = client.DownloadString("http://localhost:3000/submissions")
            submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(response)
            If submissions.Count = 0 Then
                MessageBox.Show("No submissions found.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading submissions: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            lblSubmissionDetails.Text = $"Name: {submissions(currentSubmissionIndex).Name}" & vbCrLf &
                                        $"Email: {submissions(currentSubmissionIndex).Email}" & vbCrLf &
                                        $"Phone: {submissions(currentSubmissionIndex).Phone}" & vbCrLf &
                                        $"GitHub: {submissions(currentSubmissionIndex).GitHubLink}" & vbCrLf &
                                        $"Time: {submissions(currentSubmissionIndex).StopwatchTime}"
        Else
            lblSubmissionDetails.Text = "No submissions found."
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentSubmissionIndex > 0 Then
            currentSubmissionIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentSubmissionIndex < submissions.Count - 1 Then
            currentSubmissionIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GitHubLink As String
        Public Property StopwatchTime As Double
    End Class
End Class
