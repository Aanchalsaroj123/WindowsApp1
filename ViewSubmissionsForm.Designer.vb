<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblSubmissionDetails = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Moccasin
        Me.btnNext.Location = New System.Drawing.Point(477, 301)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(165, 84)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "btnNext"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPrevious.Location = New System.Drawing.Point(179, 301)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(177, 84)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "btnPrevious"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'lblSubmissionDetails
        '
        Me.lblSubmissionDetails.AutoSize = True
        Me.lblSubmissionDetails.Location = New System.Drawing.Point(351, 56)
        Me.lblSubmissionDetails.Name = "lblSubmissionDetails"
        Me.lblSubmissionDetails.Size = New System.Drawing.Size(155, 20)
        Me.lblSubmissionDetails.TabIndex = 2
        Me.lblSubmissionDetails.Text = "lblSubmissionDetails"
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSubmissionDetails)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblSubmissionDetails As Label
End Class
