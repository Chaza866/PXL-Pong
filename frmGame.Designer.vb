<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.paddle1 = New System.Windows.Forms.PictureBox()
        Me.paddle2 = New System.Windows.Forms.PictureBox()
        Me.ball1 = New System.Windows.Forms.PictureBox()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAutoPaddle = New System.Windows.Forms.Timer(Me.components)
        Me.lblControls = New System.Windows.Forms.Label()
        Me.lblControls3 = New System.Windows.Forms.Label()
        Me.lblControls2 = New System.Windows.Forms.Label()
        Me.lblP1Score = New System.Windows.Forms.Label()
        Me.lblP2Score = New System.Windows.Forms.Label()
        Me.btnMatchFinished = New System.Windows.Forms.Button()
        Me.btnReMatch = New System.Windows.Forms.Button()
        Me.tmrP1Move = New System.Windows.Forms.Timer(Me.components)
        Me.tmrP2Move = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStopWatch = New System.Windows.Forms.Timer(Me.components)
        Me.lblStopWatch = New System.Windows.Forms.Label()
        Me.lblNotice = New System.Windows.Forms.Label()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        CType(Me.paddle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paddle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'paddle1
        '
        Me.paddle1.BackColor = System.Drawing.Color.White
        Me.paddle1.Location = New System.Drawing.Point(20, 260)
        Me.paddle1.Name = "paddle1"
        Me.paddle1.Size = New System.Drawing.Size(30, 200)
        Me.paddle1.TabIndex = 0
        Me.paddle1.TabStop = False
        '
        'paddle2
        '
        Me.paddle2.BackColor = System.Drawing.Color.White
        Me.paddle2.Location = New System.Drawing.Point(1230, 260)
        Me.paddle2.Name = "paddle2"
        Me.paddle2.Size = New System.Drawing.Size(30, 200)
        Me.paddle2.TabIndex = 1
        Me.paddle2.TabStop = False
        '
        'ball1
        '
        Me.ball1.BackColor = System.Drawing.Color.White
        Me.ball1.Location = New System.Drawing.Point(635, 355)
        Me.ball1.Name = "ball1"
        Me.ball1.Size = New System.Drawing.Size(10, 10)
        Me.ball1.TabIndex = 2
        Me.ball1.TabStop = False
        '
        'tmrGame
        '
        Me.tmrGame.Interval = 10
        '
        'tmrAutoPaddle
        '
        Me.tmrAutoPaddle.Interval = 10
        '
        'lblControls
        '
        Me.lblControls.AutoSize = True
        Me.lblControls.BackColor = System.Drawing.Color.Transparent
        Me.lblControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblControls.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControls.ForeColor = System.Drawing.Color.White
        Me.lblControls.Location = New System.Drawing.Point(20, 9)
        Me.lblControls.Name = "lblControls"
        Me.lblControls.Size = New System.Drawing.Size(105, 52)
        Me.lblControls.TabIndex = 3
        Me.lblControls.Text = "W A S D" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To Move" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblControls.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblControls3
        '
        Me.lblControls3.AutoSize = True
        Me.lblControls3.BackColor = System.Drawing.Color.Transparent
        Me.lblControls3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblControls3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControls3.ForeColor = System.Drawing.Color.White
        Me.lblControls3.Location = New System.Drawing.Point(1127, 9)
        Me.lblControls3.Name = "lblControls3"
        Me.lblControls3.Size = New System.Drawing.Size(133, 52)
        Me.lblControls3.TabIndex = 4
        Me.lblControls3.Text = "Arrow Keys" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To Move" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblControls3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblControls2
        '
        Me.lblControls2.AutoSize = True
        Me.lblControls2.BackColor = System.Drawing.Color.Transparent
        Me.lblControls2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblControls2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControls2.ForeColor = System.Drawing.Color.White
        Me.lblControls2.Location = New System.Drawing.Point(573, 9)
        Me.lblControls2.Name = "lblControls2"
        Me.lblControls2.Size = New System.Drawing.Size(132, 77)
        Me.lblControls2.TabIndex = 5
        Me.lblControls2.Text = "BackSpace" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblControls2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblP1Score
        '
        Me.lblP1Score.AutoSize = True
        Me.lblP1Score.BackColor = System.Drawing.Color.Transparent
        Me.lblP1Score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblP1Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Score.ForeColor = System.Drawing.Color.White
        Me.lblP1Score.Location = New System.Drawing.Point(377, 34)
        Me.lblP1Score.Name = "lblP1Score"
        Me.lblP1Score.Size = New System.Drawing.Size(27, 27)
        Me.lblP1Score.TabIndex = 6
        Me.lblP1Score.Text = "0"
        Me.lblP1Score.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblP2Score
        '
        Me.lblP2Score.AutoSize = True
        Me.lblP2Score.BackColor = System.Drawing.Color.Transparent
        Me.lblP2Score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblP2Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Score.ForeColor = System.Drawing.Color.White
        Me.lblP2Score.Location = New System.Drawing.Point(875, 34)
        Me.lblP2Score.Name = "lblP2Score"
        Me.lblP2Score.Size = New System.Drawing.Size(27, 27)
        Me.lblP2Score.TabIndex = 7
        Me.lblP2Score.Text = "0"
        Me.lblP2Score.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnMatchFinished
        '
        Me.btnMatchFinished.BackColor = System.Drawing.Color.Fuchsia
        Me.btnMatchFinished.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatchFinished.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatchFinished.Location = New System.Drawing.Point(1068, 658)
        Me.btnMatchFinished.Name = "btnMatchFinished"
        Me.btnMatchFinished.Size = New System.Drawing.Size(200, 50)
        Me.btnMatchFinished.TabIndex = 11
        Me.btnMatchFinished.Text = "Next Match"
        Me.btnMatchFinished.UseVisualStyleBackColor = False
        Me.btnMatchFinished.Visible = False
        '
        'btnReMatch
        '
        Me.btnReMatch.BackColor = System.Drawing.Color.Fuchsia
        Me.btnReMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReMatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReMatch.Location = New System.Drawing.Point(539, 658)
        Me.btnReMatch.Name = "btnReMatch"
        Me.btnReMatch.Size = New System.Drawing.Size(200, 50)
        Me.btnReMatch.TabIndex = 12
        Me.btnReMatch.Text = "ReMatch"
        Me.btnReMatch.UseVisualStyleBackColor = False
        Me.btnReMatch.Visible = False
        '
        'tmrP1Move
        '
        Me.tmrP1Move.Interval = 10
        '
        'tmrP2Move
        '
        Me.tmrP2Move.Interval = 10
        '
        'tmrStopWatch
        '
        Me.tmrStopWatch.Interval = 1
        '
        'lblStopWatch
        '
        Me.lblStopWatch.AutoSize = True
        Me.lblStopWatch.BackColor = System.Drawing.Color.Transparent
        Me.lblStopWatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStopWatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopWatch.ForeColor = System.Drawing.Color.White
        Me.lblStopWatch.Location = New System.Drawing.Point(564, 147)
        Me.lblStopWatch.Name = "lblStopWatch"
        Me.lblStopWatch.Size = New System.Drawing.Size(152, 27)
        Me.lblStopWatch.TabIndex = 13
        Me.lblStopWatch.Text = "00:00:00:000"
        Me.lblStopWatch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblStopWatch.Visible = False
        '
        'lblNotice
        '
        Me.lblNotice.AccessibleName = ""
        Me.lblNotice.AutoSize = True
        Me.lblNotice.BackColor = System.Drawing.Color.Transparent
        Me.lblNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNotice.Location = New System.Drawing.Point(492, 99)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(300, 39)
        Me.lblNotice.TabIndex = 16
        Me.lblNotice.Text = "You Survived For"
        Me.lblNotice.Visible = False
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.ForeColor = System.Drawing.Color.White
        Me.lblPlayer1.Location = New System.Drawing.Point(303, 683)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(83, 27)
        Me.lblPlayer1.TabIndex = 17
        Me.lblPlayer1.Text = "User 1"
        Me.lblPlayer1.Visible = False
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2.ForeColor = System.Drawing.Color.White
        Me.lblPlayer2.Location = New System.Drawing.Point(890, 683)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(83, 27)
        Me.lblPlayer2.TabIndex = 18
        Me.lblPlayer2.Text = "User 2"
        Me.lblPlayer2.Visible = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.lblNotice)
        Me.Controls.Add(Me.lblStopWatch)
        Me.Controls.Add(Me.btnReMatch)
        Me.Controls.Add(Me.btnMatchFinished)
        Me.Controls.Add(Me.lblP2Score)
        Me.Controls.Add(Me.lblP1Score)
        Me.Controls.Add(Me.lblControls2)
        Me.Controls.Add(Me.lblControls3)
        Me.Controls.Add(Me.lblControls)
        Me.Controls.Add(Me.ball1)
        Me.Controls.Add(Me.paddle2)
        Me.Controls.Add(Me.paddle1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGame"
        Me.Text = "frmGame"
        CType(Me.paddle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paddle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents paddle1 As PictureBox
    Friend WithEvents paddle2 As PictureBox
    Friend WithEvents ball1 As PictureBox
    Friend WithEvents tmrGame As Timer
    Friend WithEvents tmrAutoPaddle As Timer
    Friend WithEvents lblControls As Label
    Friend WithEvents lblControls3 As Label
    Friend WithEvents lblControls2 As Label
    Friend WithEvents lblP1Score As Label
    Friend WithEvents lblP2Score As Label
    Friend WithEvents btnMatchFinished As Button
    Friend WithEvents btnReMatch As Button
    Friend WithEvents tmrP1Move As Timer
    Friend WithEvents tmrP2Move As Timer
    Friend WithEvents tmrStopWatch As Timer
    Friend WithEvents lblStopWatch As Label
    Friend WithEvents lblNotice As Label
    Friend WithEvents lblPlayer1 As Label
    Friend WithEvents lblPlayer2 As Label
End Class
