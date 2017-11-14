<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RobotView
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
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.RobotViewMap = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.RightButton = New System.Windows.Forms.Button()
        Me.UpButton = New System.Windows.Forms.Button()
        Me.DownButton = New System.Windows.Forms.Button()
        Me.LeftButton = New System.Windows.Forms.Button()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MainPanel.Controls.Add(Me.DownButton)
        Me.MainPanel.Controls.Add(Me.UpButton)
        Me.MainPanel.Controls.Add(Me.LeftButton)
        Me.MainPanel.Controls.Add(Me.RightButton)
        Me.MainPanel.Controls.Add(Me.BackButton)
        Me.MainPanel.Controls.Add(Me.RobotViewMap)
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1585, 863)
        Me.MainPanel.TabIndex = 0
        '
        'RobotViewMap
        '
        Me.RobotViewMap.BackColor = System.Drawing.SystemColors.Window
        Me.RobotViewMap.Location = New System.Drawing.Point(13, 13)
        Me.RobotViewMap.Name = "RobotViewMap"
        Me.RobotViewMap.Size = New System.Drawing.Size(1560, 700)
        Me.RobotViewMap.TabIndex = 0
        '
        'BackButton
        '
        Me.BackButton.BackgroundImage = Global.RobotView.My.Resources.Resources.Zoo_Map_PREV
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackButton.Location = New System.Drawing.Point(13, 719)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(287, 130)
        Me.BackButton.TabIndex = 1
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'RightButton
        '
        Me.RightButton.BackgroundImage = Global.RobotView.My.Resources.Resources.right
        Me.RightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RightButton.Location = New System.Drawing.Point(1532, 764)
        Me.RightButton.Name = "RightButton"
        Me.RightButton.Size = New System.Drawing.Size(40, 40)
        Me.RightButton.TabIndex = 2
        Me.RightButton.UseVisualStyleBackColor = True
        '
        'UpButton
        '
        Me.UpButton.BackgroundImage = Global.RobotView.My.Resources.Resources.up
        Me.UpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpButton.Location = New System.Drawing.Point(1488, 719)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(40, 40)
        Me.UpButton.TabIndex = 2
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'DownButton
        '
        Me.DownButton.BackgroundImage = Global.RobotView.My.Resources.Resources.down
        Me.DownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DownButton.Location = New System.Drawing.Point(1488, 809)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(40, 40)
        Me.DownButton.TabIndex = 2
        Me.DownButton.UseVisualStyleBackColor = True
        '
        'LeftButton
        '
        Me.LeftButton.BackgroundImage = Global.RobotView.My.Resources.Resources.left
        Me.LeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LeftButton.Location = New System.Drawing.Point(1442, 764)
        Me.LeftButton.Name = "LeftButton"
        Me.LeftButton.Size = New System.Drawing.Size(40, 40)
        Me.LeftButton.TabIndex = 2
        Me.LeftButton.UseVisualStyleBackColor = True
        '
        'RobotView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 861)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RobotView"
        Me.Text = "Form1"
        Me.MainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents RobotViewMap As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents DownButton As Button
    Friend WithEvents UpButton As Button
    Friend WithEvents LeftButton As Button
    Friend WithEvents RightButton As Button
End Class
