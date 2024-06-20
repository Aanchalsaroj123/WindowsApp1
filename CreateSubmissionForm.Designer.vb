<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(441, 67)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(195, 26)
        Me.txtName.TabIndex = 0
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(441, 135)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(195, 26)
        Me.txtEmail.TabIndex = 1
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(441, 214)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(195, 26)
        Me.txtPhone.TabIndex = 2
        '
        'txtGitHub
        '
        Me.txtGitHub.Location = New System.Drawing.Point(441, 283)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.Size = New System.Drawing.Size(195, 26)
        Me.txtGitHub.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Phone Num"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "GitHub"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(297, 391)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(207, 47)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(120, 337)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(170, 44)
        Me.btnToggleStopwatch.TabIndex = 10
        Me.btnToggleStopwatch.Text = "Start Stopwatch"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = True
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnToggleStopwatch As Button
End Class
