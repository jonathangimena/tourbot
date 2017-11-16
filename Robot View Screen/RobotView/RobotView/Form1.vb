Imports VB = Microsoft.VisualBasic

Public Class RobotView

    Public Const ACTIVE As Boolean = True
    Public Const INACTIVE As Boolean = False
    Public Const IMG_MOVE As Integer = 50
    Public Const WAIT_TIME As Integer = 10

    Dim isInactive As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SpawnAnimal()
    End Sub

    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        If isInactive = ACTIVE Then
            isInactive = INACTIVE
        Else
            isInactive = ACTIVE
            SpawnAnimal()
        End If

        ChangeControls()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

    End Sub

    Public Sub SpawnAnimal()
        'Find background image size'
        Dim x_max As Integer = MapPictureBox.Size.Width - AnimalPictureBox.Size.Width
        Dim y_max As Integer = MapPictureBox.Size.Height - AnimalPictureBox.Size.Height

        Dim rnd_x As Integer = CInt(Int(x_max * Rnd()))
        Dim rnd_y As Integer = CInt(Int(y_max * Rnd()))

        'Always add the offset of the MapPictureBox'
        AnimalPictureBox.Left = rnd_x + MapPictureBox.Left
        AnimalPictureBox.Top = rnd_y + MapPictureBox.Top

        Debug.Print("AnimalPictureBox.Left: " + CStr(AnimalPictureBox.Left))
        Debug.Print("AnimalPictureBox.Top: " + CStr(AnimalPictureBox.Top))

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

    Private Sub UpButton_Click(sender As Object, e As EventArgs) Handles UpButton.Click
        ChangeLocation(0, -(IMG_MOVE))
    End Sub

    Private Sub DownButton_Click(sender As Object, e As EventArgs) Handles DownButton.Click
        ChangeLocation(0, IMG_MOVE)
    End Sub

    Private Sub LeftButton_Click(sender As Object, e As EventArgs) Handles LeftButton.Click
        ChangeLocation(-(IMG_MOVE), 0)
    End Sub

    Private Sub RightButton_Click(sender As Object, e As EventArgs) Handles RightButton.Click
        ChangeLocation(IMG_MOVE, 0)
    End Sub

    Public Sub ChangeLocation(x As Integer, y As Integer)
        'Change location of image; x and y are relative and added into the size'

        Dim leftX As Integer = 0
        Dim rightX As Integer = MapPictureBox.Width
        Dim topY As Integer = 0
        Dim bottomY As Integer = MapPictureBox.Height
        Dim panelX As Integer = RobotViewMap.Size.Width
        Dim panelY As Integer = RobotViewMap.Size.Height

        MapPictureBox.Left = MapPictureBox.Left - x
        MapPictureBox.Top = MapPictureBox.Top - y
        AnimalPictureBox.Left = AnimalPictureBox.Left - x
        AnimalPictureBox.Top = AnimalPictureBox.Top - y

        'Set Left and Top to minimum permitted'
        If (MapPictureBox.Left > leftX) Then
            Dim x_temp As Integer
            x_temp = leftX - MapPictureBox.Left
            MapPictureBox.Left = 0
            AnimalPictureBox.Left = AnimalPictureBox.Left + x_temp
        End If
        If (MapPictureBox.Top > topY) Then
            Dim y_temp As Integer
            y_temp = topY - MapPictureBox.Top
            MapPictureBox.Top = 0
            AnimalPictureBox.Top = AnimalPictureBox.Top + y_temp
        End If

        'Set Left and Top to maximum permitted'
        If (rightX < -(MapPictureBox.Left) + panelX) Then
            Dim x_temp As Integer
            x_temp = (-(MapPictureBox.Left) - (rightX - panelX))
            MapPictureBox.Left = -(rightX - panelX)
            AnimalPictureBox.Left = AnimalPictureBox.Left + x_temp
        End If
        If (bottomY < -(MapPictureBox.Top) + panelY) Then
            Dim y_temp As Integer
            y_temp = (-(MapPictureBox.Top) - (bottomY - panelY))
            MapPictureBox.Top = -(bottomY - panelY)
            AnimalPictureBox.Top = AnimalPictureBox.Top + y_temp
        End If

        'Debug.Print("MapPictureBox.Left = " + CStr(MapPictureBox.Left))'
        'Debug.Print("MapPictureBox.Top = " + CStr(MapPictureBox.Top))'
    End Sub



    Public Sub wait(ByVal seconds As Single)
        Static start As Single
        start = VB.Timer()
        Do While VB.Timer() < start + seconds
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub

End Class
