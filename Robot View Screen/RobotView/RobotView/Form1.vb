Public Class RobotView

    Public Const ACTIVE As Boolean = True
    Public Const INACTIVE As Boolean = False

    Dim isInactive As Boolean

    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click

        If isInactive = ACTIVE Then
            isInactive = INACTIVE
        Else
            isInactive = ACTIVE
        End If

        ChangeControls()

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

    End Sub

    Public Sub ChangeControls()
        'Set U.I. depending on isInactive state'
        'Much easier to utilize Boolean function of isInactive for things like button Enabled'

        UpButton.Enabled = isInactive
        DownButton.Enabled = isInactive
        LeftButton.Enabled = isInactive
        RightButton.Enabled = isInactive

        If isInactive = ACTIVE Then
            'Do active things'
            ToolStripStatusLabel1.Text = "User is active!"
        Else
            'Do inactive things'
            ToolStripStatusLabel1.Text = "User is inactive!"
        End If

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        isInactive = INACTIVE
        ChangeControls()

        ToolStripStatusLabel1.Text = "Hello! Press 'Enter Queue' to start!"
    End Sub

End Class
