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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RobotView))
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.EnterButton = New System.Windows.Forms.Button()
        Me.ControlBox = New System.Windows.Forms.GroupBox()
        Me.RobotViewMap = New System.Windows.Forms.Panel()
        Me.UpButton = New System.Windows.Forms.Button()
        Me.RightButton = New System.Windows.Forms.Button()
        Me.DownButton = New System.Windows.Forms.Button()
        Me.LeftButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.AnimalPictureBox = New System.Windows.Forms.PictureBox()
        Me.MapPictureBox = New System.Windows.Forms.PictureBox()
        Me.MainPanel.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ControlBox.SuspendLayout()
        Me.RobotViewMap.SuspendLayout()
        CType(Me.AnimalPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MapPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.AutoSize = True
        Me.MainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MainPanel.Controls.Add(Me.StatusStrip1)
        Me.MainPanel.Controls.Add(Me.EnterButton)
        Me.MainPanel.Controls.Add(Me.ControlBox)
        Me.MainPanel.Controls.Add(Me.BackButton)
        Me.MainPanel.Controls.Add(Me.RobotViewMap)
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1585, 863)
        Me.MainPanel.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 841)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1585, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'EnterButton
        '
        Me.EnterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterButton.Location = New System.Drawing.Point(1165, 689)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(230, 142)
        Me.EnterButton.TabIndex = 5
        Me.EnterButton.Text = "Enter Queue"
        Me.EnterButton.UseVisualStyleBackColor = True
        '
        'ControlBox
        '
        Me.ControlBox.Controls.Add(Me.UpButton)
        Me.ControlBox.Controls.Add(Me.RightButton)
        Me.ControlBox.Controls.Add(Me.DownButton)
        Me.ControlBox.Controls.Add(Me.LeftButton)
        Me.ControlBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlBox.Location = New System.Drawing.Point(1401, 679)
        Me.ControlBox.Name = "ControlBox"
        Me.ControlBox.Size = New System.Drawing.Size(142, 159)
        Me.ControlBox.TabIndex = 4
        Me.ControlBox.TabStop = False
        Me.ControlBox.Text = "Controls"
        '
        'RobotViewMap
        '
        Me.RobotViewMap.BackColor = System.Drawing.SystemColors.Window
        Me.RobotViewMap.Controls.Add(Me.AnimalPictureBox)
        Me.RobotViewMap.Controls.Add(Me.MapPictureBox)
        Me.RobotViewMap.Location = New System.Drawing.Point(72, 71)
        Me.RobotViewMap.Name = "RobotViewMap"
        Me.RobotViewMap.Size = New System.Drawing.Size(1440, 549)
        Me.RobotViewMap.TabIndex = 0
        '
        'UpButton
        '
        Me.UpButton.BackgroundImage = CType(resources.GetObject("UpButton.BackgroundImage"), System.Drawing.Image)
        Me.UpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpButton.Location = New System.Drawing.Point(53, 22)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(40, 40)
        Me.UpButton.TabIndex = 2
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'RightButton
        '
        Me.RightButton.BackgroundImage = CType(resources.GetObject("RightButton.BackgroundImage"), System.Drawing.Image)
        Me.RightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RightButton.Location = New System.Drawing.Point(97, 67)
        Me.RightButton.Name = "RightButton"
        Me.RightButton.Size = New System.Drawing.Size(40, 40)
        Me.RightButton.TabIndex = 2
        Me.RightButton.UseVisualStyleBackColor = True
        '
        'DownButton
        '
        Me.DownButton.BackgroundImage = CType(resources.GetObject("DownButton.BackgroundImage"), System.Drawing.Image)
        Me.DownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DownButton.Location = New System.Drawing.Point(53, 112)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(40, 40)
        Me.DownButton.TabIndex = 2
        Me.DownButton.UseVisualStyleBackColor = True
        '
        'LeftButton
        '
        Me.LeftButton.BackgroundImage = CType(resources.GetObject("LeftButton.BackgroundImage"), System.Drawing.Image)
        Me.LeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LeftButton.Location = New System.Drawing.Point(7, 67)
        Me.LeftButton.Name = "LeftButton"
        Me.LeftButton.Size = New System.Drawing.Size(40, 40)
        Me.LeftButton.TabIndex = 2
        Me.LeftButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.BackgroundImage = CType(resources.GetObject("BackButton.BackgroundImage"), System.Drawing.Image)
        Me.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BackButton.Location = New System.Drawing.Point(13, 699)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(287, 130)
        Me.BackButton.TabIndex = 1
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'AnimalPictureBox
        '
        Me.AnimalPictureBox.Image = Global.RobotView.My.Resources.Resources.placeholder
        Me.AnimalPictureBox.Location = New System.Drawing.Point(479, 225)
        Me.AnimalPictureBox.Name = "AnimalPictureBox"
        Me.AnimalPictureBox.Size = New System.Drawing.Size(273, 171)
        Me.AnimalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AnimalPictureBox.TabIndex = 1
        Me.AnimalPictureBox.TabStop = False
        '
        'MapPictureBox
        '
        Me.MapPictureBox.Image = Global.RobotView.My.Resources.Resources.zoo1
        Me.MapPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.MapPictureBox.Name = "MapPictureBox"
        Me.MapPictureBox.Size = New System.Drawing.Size(1600, 1199)
        Me.MapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.MapPictureBox.TabIndex = 0
        Me.MapPictureBox.TabStop = False
        '
        'RobotView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 861)
        Me.Controls.Add(Me.MainPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RobotView"
        Me.Text = "Form1"
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ControlBox.ResumeLayout(False)
        Me.RobotViewMap.ResumeLayout(False)
        Me.RobotViewMap.PerformLayout()
        CType(Me.AnimalPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MapPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents RobotViewMap As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents DownButton As Button
    Friend WithEvents UpButton As Button
    Friend WithEvents LeftButton As Button
    Friend WithEvents RightButton As Button
    Friend WithEvents ControlBox As GroupBox
    Friend WithEvents EnterButton As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents MapPictureBox As PictureBox
    Friend WithEvents AnimalPictureBox As PictureBox
End Class
