<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTourneyTransition
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTourneyTransition))
        Me.lblNotice1 = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.tmrTourneyStart = New System.Windows.Forms.Timer(Me.components)
        Me.lblMatchBetween = New System.Windows.Forms.Label()
        Me.lblMatchPlayer1 = New System.Windows.Forms.Label()
        Me.lblMatchPlayer2 = New System.Windows.Forms.Label()
        Me.lblMatchNo = New System.Windows.Forms.Label()
        Me.lblUser2 = New System.Windows.Forms.Label()
        Me.pbxUser2 = New System.Windows.Forms.PictureBox()
        Me.pbxUser1 = New System.Windows.Forms.PictureBox()
        Me.lblUser1 = New System.Windows.Forms.Label()
        Me.pbxUser3 = New System.Windows.Forms.PictureBox()
        Me.pbxUser4 = New System.Windows.Forms.PictureBox()
        Me.pbxUser5 = New System.Windows.Forms.PictureBox()
        Me.pbxUser6 = New System.Windows.Forms.PictureBox()
        Me.lblUser6 = New System.Windows.Forms.Label()
        Me.lblUser3 = New System.Windows.Forms.Label()
        Me.lblUser4 = New System.Windows.Forms.Label()
        Me.lblUser5 = New System.Windows.Forms.Label()
        Me.lblAnd = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblCurrentMatch = New System.Windows.Forms.Label()
        Me.lblTotalMatches = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.pbxUser2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxUser1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxUser3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxUser4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxUser5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxUser6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNotice1
        '
        Me.lblNotice1.AutoSize = True
        Me.lblNotice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice1.ForeColor = System.Drawing.Color.White
        Me.lblNotice1.Location = New System.Drawing.Point(556, 183)
        Me.lblNotice1.Name = "lblNotice1"
        Me.lblNotice1.Size = New System.Drawing.Size(165, 50)
        Me.lblNotice1.TabIndex = 0
        Me.lblNotice1.Text = "Match Starting" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in"
        Me.lblNotice1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.Location = New System.Drawing.Point(587, 290)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(99, 108)
        Me.lblTimer.TabIndex = 1
        Me.lblTimer.Text = "5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmrTourneyStart
        '
        Me.tmrTourneyStart.Interval = 1000
        '
        'lblMatchBetween
        '
        Me.lblMatchBetween.AutoSize = True
        Me.lblMatchBetween.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatchBetween.ForeColor = System.Drawing.Color.White
        Me.lblMatchBetween.Location = New System.Drawing.Point(546, 486)
        Me.lblMatchBetween.Name = "lblMatchBetween"
        Me.lblMatchBetween.Size = New System.Drawing.Size(180, 25)
        Me.lblMatchBetween.TabIndex = 2
        Me.lblMatchBetween.Text = "Match Between:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMatchBetween.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMatchPlayer1
        '
        Me.lblMatchPlayer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMatchPlayer1.AutoSize = True
        Me.lblMatchPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatchPlayer1.ForeColor = System.Drawing.Color.White
        Me.lblMatchPlayer1.Location = New System.Drawing.Point(584, 537)
        Me.lblMatchPlayer1.Name = "lblMatchPlayer1"
        Me.lblMatchPlayer1.Size = New System.Drawing.Size(74, 25)
        Me.lblMatchPlayer1.TabIndex = 4
        Me.lblMatchPlayer1.Text = "User1"
        '
        'lblMatchPlayer2
        '
        Me.lblMatchPlayer2.AutoSize = True
        Me.lblMatchPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatchPlayer2.ForeColor = System.Drawing.Color.White
        Me.lblMatchPlayer2.Location = New System.Drawing.Point(584, 641)
        Me.lblMatchPlayer2.Name = "lblMatchPlayer2"
        Me.lblMatchPlayer2.Size = New System.Drawing.Size(74, 25)
        Me.lblMatchPlayer2.TabIndex = 5
        Me.lblMatchPlayer2.Text = "User2"
        Me.lblMatchPlayer2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMatchNo
        '
        Me.lblMatchNo.AutoSize = True
        Me.lblMatchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatchNo.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblMatchNo.Location = New System.Drawing.Point(600, 29)
        Me.lblMatchNo.Name = "lblMatchNo"
        Me.lblMatchNo.Size = New System.Drawing.Size(76, 25)
        Me.lblMatchNo.TabIndex = 6
        Me.lblMatchNo.Text = "Match"
        Me.lblMatchNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUser2
        '
        Me.lblUser2.AutoSize = True
        Me.lblUser2.BackColor = System.Drawing.Color.Transparent
        Me.lblUser2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser2.ForeColor = System.Drawing.Color.White
        Me.lblUser2.Location = New System.Drawing.Point(60, 144)
        Me.lblUser2.Name = "lblUser2"
        Me.lblUser2.Size = New System.Drawing.Size(81, 25)
        Me.lblUser2.TabIndex = 69
        Me.lblUser2.Text = "User 2"
        Me.lblUser2.Visible = False
        '
        'pbxUser2
        '
        Me.pbxUser2.BackColor = System.Drawing.Color.Red
        Me.pbxUser2.Location = New System.Drawing.Point(29, 144)
        Me.pbxUser2.Name = "pbxUser2"
        Me.pbxUser2.Size = New System.Drawing.Size(25, 25)
        Me.pbxUser2.TabIndex = 77
        Me.pbxUser2.TabStop = False
        Me.pbxUser2.Visible = False
        '
        'pbxUser1
        '
        Me.pbxUser1.BackColor = System.Drawing.Color.Aqua
        Me.pbxUser1.Location = New System.Drawing.Point(29, 29)
        Me.pbxUser1.Name = "pbxUser1"
        Me.pbxUser1.Size = New System.Drawing.Size(25, 25)
        Me.pbxUser1.TabIndex = 72
        Me.pbxUser1.TabStop = False
        Me.pbxUser1.Visible = False
        '
        'lblUser1
        '
        Me.lblUser1.AutoSize = True
        Me.lblUser1.BackColor = System.Drawing.Color.Transparent
        Me.lblUser1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser1.ForeColor = System.Drawing.Color.White
        Me.lblUser1.Location = New System.Drawing.Point(60, 29)
        Me.lblUser1.Name = "lblUser1"
        Me.lblUser1.Size = New System.Drawing.Size(81, 25)
        Me.lblUser1.TabIndex = 70
        Me.lblUser1.Text = "User 1"
        Me.lblUser1.Visible = False
        '
        'pbxUser3
        '
        Me.pbxUser3.BackColor = System.Drawing.Color.Lime
        Me.pbxUser3.Location = New System.Drawing.Point(29, 69)
        Me.pbxUser3.Name = "pbxUser3"
        Me.pbxUser3.Size = New System.Drawing.Size(25, 25)
        Me.pbxUser3.TabIndex = 76
        Me.pbxUser3.TabStop = False
        Me.pbxUser3.Visible = False
        '
        'pbxUser4
        '
        Me.pbxUser4.BackColor = System.Drawing.Color.Yellow
        Me.pbxUser4.Location = New System.Drawing.Point(29, 183)
        Me.pbxUser4.Name = "pbxUser4"
        Me.pbxUser4.Size = New System.Drawing.Size(25, 25)
        Me.pbxUser4.TabIndex = 75
        Me.pbxUser4.TabStop = False
        Me.pbxUser4.Visible = False
        '
        'pbxUser5
        '
        Me.pbxUser5.BackColor = System.Drawing.Color.Fuchsia
        Me.pbxUser5.Location = New System.Drawing.Point(29, 108)
        Me.pbxUser5.Name = "pbxUser5"
        Me.pbxUser5.Size = New System.Drawing.Size(25, 25)
        Me.pbxUser5.TabIndex = 74
        Me.pbxUser5.TabStop = False
        Me.pbxUser5.Visible = False
        '
        'pbxUser6
        '
        Me.pbxUser6.AccessibleName = ""
        Me.pbxUser6.BackColor = System.Drawing.Color.Orange
        Me.pbxUser6.Location = New System.Drawing.Point(29, 222)
        Me.pbxUser6.Name = "pbxUser6"
        Me.pbxUser6.Size = New System.Drawing.Size(25, 25)
        Me.pbxUser6.TabIndex = 73
        Me.pbxUser6.TabStop = False
        Me.pbxUser6.Visible = False
        '
        'lblUser6
        '
        Me.lblUser6.AccessibleName = ""
        Me.lblUser6.AutoSize = True
        Me.lblUser6.BackColor = System.Drawing.Color.Transparent
        Me.lblUser6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser6.ForeColor = System.Drawing.Color.White
        Me.lblUser6.Location = New System.Drawing.Point(60, 222)
        Me.lblUser6.Name = "lblUser6"
        Me.lblUser6.Size = New System.Drawing.Size(81, 25)
        Me.lblUser6.TabIndex = 71
        Me.lblUser6.Text = "User 6"
        Me.lblUser6.Visible = False
        '
        'lblUser3
        '
        Me.lblUser3.AutoSize = True
        Me.lblUser3.BackColor = System.Drawing.Color.Transparent
        Me.lblUser3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser3.ForeColor = System.Drawing.Color.White
        Me.lblUser3.Location = New System.Drawing.Point(60, 69)
        Me.lblUser3.Name = "lblUser3"
        Me.lblUser3.Size = New System.Drawing.Size(81, 25)
        Me.lblUser3.TabIndex = 68
        Me.lblUser3.Text = "User 3"
        Me.lblUser3.Visible = False
        '
        'lblUser4
        '
        Me.lblUser4.AutoSize = True
        Me.lblUser4.BackColor = System.Drawing.Color.Transparent
        Me.lblUser4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser4.ForeColor = System.Drawing.Color.White
        Me.lblUser4.Location = New System.Drawing.Point(60, 183)
        Me.lblUser4.Name = "lblUser4"
        Me.lblUser4.Size = New System.Drawing.Size(81, 25)
        Me.lblUser4.TabIndex = 67
        Me.lblUser4.Text = "User 4"
        Me.lblUser4.Visible = False
        '
        'lblUser5
        '
        Me.lblUser5.AutoSize = True
        Me.lblUser5.BackColor = System.Drawing.Color.Transparent
        Me.lblUser5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser5.ForeColor = System.Drawing.Color.White
        Me.lblUser5.Location = New System.Drawing.Point(60, 108)
        Me.lblUser5.Name = "lblUser5"
        Me.lblUser5.Size = New System.Drawing.Size(81, 25)
        Me.lblUser5.TabIndex = 66
        Me.lblUser5.Text = "User 5"
        Me.lblUser5.Visible = False
        '
        'lblAnd
        '
        Me.lblAnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAnd.AutoSize = True
        Me.lblAnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnd.ForeColor = System.Drawing.Color.White
        Me.lblAnd.Location = New System.Drawing.Point(600, 589)
        Me.lblAnd.Name = "lblAnd"
        Me.lblAnd.Size = New System.Drawing.Size(51, 25)
        Me.lblAnd.TabIndex = 78
        Me.lblAnd.Text = "and"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(512, 525)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 46)
        Me.PictureBox1.TabIndex = 79
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(682, 630)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(66, 46)
        Me.PictureBox2.TabIndex = 80
        Me.PictureBox2.TabStop = False
        '
        'lblCurrentMatch
        '
        Me.lblCurrentMatch.AutoSize = True
        Me.lblCurrentMatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentMatch.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblCurrentMatch.Location = New System.Drawing.Point(584, 69)
        Me.lblCurrentMatch.Name = "lblCurrentMatch"
        Me.lblCurrentMatch.Size = New System.Drawing.Size(27, 25)
        Me.lblCurrentMatch.TabIndex = 81
        Me.lblCurrentMatch.Text = "X"
        Me.lblCurrentMatch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTotalMatches
        '
        Me.lblTotalMatches.AutoSize = True
        Me.lblTotalMatches.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMatches.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblTotalMatches.Location = New System.Drawing.Point(666, 69)
        Me.lblTotalMatches.Name = "lblTotalMatches"
        Me.lblTotalMatches.Size = New System.Drawing.Size(28, 25)
        Me.lblTotalMatches.TabIndex = 82
        Me.lblTotalMatches.Text = "N"
        Me.lblTotalMatches.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label3.Location = New System.Drawing.Point(617, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 25)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "OF"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmTourneyTransition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotalMatches)
        Me.Controls.Add(Me.lblCurrentMatch)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblAnd)
        Me.Controls.Add(Me.lblUser2)
        Me.Controls.Add(Me.pbxUser2)
        Me.Controls.Add(Me.pbxUser1)
        Me.Controls.Add(Me.lblUser1)
        Me.Controls.Add(Me.pbxUser3)
        Me.Controls.Add(Me.pbxUser4)
        Me.Controls.Add(Me.pbxUser5)
        Me.Controls.Add(Me.pbxUser6)
        Me.Controls.Add(Me.lblUser6)
        Me.Controls.Add(Me.lblUser3)
        Me.Controls.Add(Me.lblUser4)
        Me.Controls.Add(Me.lblUser5)
        Me.Controls.Add(Me.lblMatchNo)
        Me.Controls.Add(Me.lblMatchPlayer2)
        Me.Controls.Add(Me.lblMatchPlayer1)
        Me.Controls.Add(Me.lblMatchBetween)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblNotice1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTourneyTransition"
        Me.Text = "frmTourneyTransition"
        CType(Me.pbxUser2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxUser1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxUser3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxUser4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxUser5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxUser6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNotice1 As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents tmrTourneyStart As Timer
    Friend WithEvents lblMatchBetween As Label
    Friend WithEvents lblMatchPlayer1 As Label
    Friend WithEvents lblMatchPlayer2 As Label
    Friend WithEvents lblMatchNo As Label
    Friend WithEvents lblUser2 As Label
    Friend WithEvents pbxUser2 As PictureBox
    Friend WithEvents pbxUser1 As PictureBox
    Friend WithEvents lblUser1 As Label
    Friend WithEvents pbxUser3 As PictureBox
    Friend WithEvents pbxUser4 As PictureBox
    Friend WithEvents pbxUser5 As PictureBox
    Friend WithEvents pbxUser6 As PictureBox
    Friend WithEvents lblUser6 As Label
    Friend WithEvents lblUser3 As Label
    Friend WithEvents lblUser4 As Label
    Friend WithEvents lblUser5 As Label
    Friend WithEvents lblAnd As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblCurrentMatch As Label
    Friend WithEvents lblTotalMatches As Label
    Friend WithEvents Label3 As Label
End Class
