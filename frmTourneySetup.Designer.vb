<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTourneySetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTourneySetup))
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.tbxTournamentName = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblNotice = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPlayTournament = New System.Windows.Forms.Button()
        Me.pbxUser2 = New System.Windows.Forms.PictureBox()
        Me.pbxUser3 = New System.Windows.Forms.PictureBox()
        Me.pbxUser4 = New System.Windows.Forms.PictureBox()
        Me.pbxUser5 = New System.Windows.Forms.PictureBox()
        Me.pbxUser6 = New System.Windows.Forms.PictureBox()
        Me.pbxUser1 = New System.Windows.Forms.PictureBox()
        Me.lblUser6 = New System.Windows.Forms.Label()
        Me.lblUser2 = New System.Windows.Forms.Label()
        Me.lblUser3 = New System.Windows.Forms.Label()
        Me.lblUser4 = New System.Windows.Forms.Label()
        Me.lblUser5 = New System.Windows.Forms.Label()
        Me.lblUser1 = New System.Windows.Forms.Label()
        Me.btnUserSelectTournament = New System.Windows.Forms.Button()
        Me.OutlineUser1 = New System.Windows.Forms.PictureBox()
        Me.OutlineUser3 = New System.Windows.Forms.PictureBox()
        Me.OutlineUser5 = New System.Windows.Forms.PictureBox()
        Me.OutlineUser6 = New System.Windows.Forms.PictureBox()
        Me.OutlineUser4 = New System.Windows.Forms.PictureBox()
        Me.OutlineUser2 = New System.Windows.Forms.PictureBox()
        CType(Me.pbxUser2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxUser3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxUser4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxUser5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxUser6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxUser1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutlineUser1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutlineUser3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutlineUser5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutlineUser6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutlineUser4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutlineUser2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(557, 392)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(165, 25)
        Me.lblUserName.TabIndex = 7
        Me.lblUserName.Text = "Tourney Name"
        '
        'tbxTournamentName
        '
        Me.tbxTournamentName.BackColor = System.Drawing.Color.Black
        Me.tbxTournamentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTournamentName.ForeColor = System.Drawing.Color.White
        Me.tbxTournamentName.Location = New System.Drawing.Point(540, 419)
        Me.tbxTournamentName.Name = "tbxTournamentName"
        Me.tbxTournamentName.Size = New System.Drawing.Size(200, 31)
        Me.tbxTournamentName.TabIndex = 6
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Fuchsia
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 658)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(200, 50)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblNotice
        '
        Me.lblNotice.AutoSize = True
        Me.lblNotice.BackColor = System.Drawing.Color.Transparent
        Me.lblNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice.ForeColor = System.Drawing.Color.White
        Me.lblNotice.Location = New System.Drawing.Point(434, 666)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(403, 50)
        Me.lblNotice.TabIndex = 59
        Me.lblNotice.Text = "Double Click On Any Logged in User " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To Select Them For Tournament"
        Me.lblNotice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNotice.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Fuchsia
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1068, 571)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(200, 50)
        Me.btnClear.TabIndex = 58
        Me.btnClear.Text = "Re-Select Players"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnPlayTournament
        '
        Me.btnPlayTournament.BackColor = System.Drawing.Color.Fuchsia
        Me.btnPlayTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayTournament.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayTournament.Location = New System.Drawing.Point(1068, 658)
        Me.btnPlayTournament.Name = "btnPlayTournament"
        Me.btnPlayTournament.Size = New System.Drawing.Size(200, 50)
        Me.btnPlayTournament.TabIndex = 54
        Me.btnPlayTournament.Text = "Start Tournament"
        Me.btnPlayTournament.UseVisualStyleBackColor = False
        '
        'pbxUser2
        '
        Me.pbxUser2.BackColor = System.Drawing.Color.Red
        Me.pbxUser2.Location = New System.Drawing.Point(669, 531)
        Me.pbxUser2.Name = "pbxUser2"
        Me.pbxUser2.Size = New System.Drawing.Size(25, 25)
        Me.pbxUser2.TabIndex = 53
        Me.pbxUser2.TabStop = False
        Me.pbxUser2.Visible = False
        '
        'pbxUser3
        '
        Me.pbxUser3.BackColor = System.Drawing.Color.Lime
        Me.pbxUser3.Location = New System.Drawing.Point(502, 571)
        Me.pbxUser3.Name = "pbxUser3"
        Me.pbxUser3.Size = New System.Drawing.Size(25, 25)
        Me.pbxUser3.TabIndex = 52
        Me.pbxUser3.TabStop = False
        Me.pbxUser3.Visible = False
        '
        'pbxUser4
        '
        Me.pbxUser4.BackColor = System.Drawing.Color.Yellow
        Me.pbxUser4.Location = New System.Drawing.Point(669, 571)
        Me.pbxUser4.Name = "pbxUser4"
        Me.pbxUser4.Size = New System.Drawing.Size(25, 25)
        Me.pbxUser4.TabIndex = 51
        Me.pbxUser4.TabStop = False
        Me.pbxUser4.Visible = False
        '
        'pbxUser5
        '
        Me.pbxUser5.BackColor = System.Drawing.Color.Fuchsia
        Me.pbxUser5.Location = New System.Drawing.Point(502, 611)
        Me.pbxUser5.Name = "pbxUser5"
        Me.pbxUser5.Size = New System.Drawing.Size(25, 25)
        Me.pbxUser5.TabIndex = 50
        Me.pbxUser5.TabStop = False
        Me.pbxUser5.Visible = False
        '
        'pbxUser6
        '
        Me.pbxUser6.AccessibleName = ""
        Me.pbxUser6.BackColor = System.Drawing.Color.Orange
        Me.pbxUser6.Location = New System.Drawing.Point(669, 611)
        Me.pbxUser6.Name = "pbxUser6"
        Me.pbxUser6.Size = New System.Drawing.Size(25, 25)
        Me.pbxUser6.TabIndex = 49
        Me.pbxUser6.TabStop = False
        Me.pbxUser6.Visible = False
        '
        'pbxUser1
        '
        Me.pbxUser1.BackColor = System.Drawing.Color.Aqua
        Me.pbxUser1.Location = New System.Drawing.Point(502, 531)
        Me.pbxUser1.Name = "pbxUser1"
        Me.pbxUser1.Size = New System.Drawing.Size(25, 25)
        Me.pbxUser1.TabIndex = 48
        Me.pbxUser1.TabStop = False
        Me.pbxUser1.Visible = False
        '
        'lblUser6
        '
        Me.lblUser6.AccessibleName = ""
        Me.lblUser6.AutoSize = True
        Me.lblUser6.BackColor = System.Drawing.Color.Transparent
        Me.lblUser6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser6.ForeColor = System.Drawing.Color.White
        Me.lblUser6.Location = New System.Drawing.Point(700, 611)
        Me.lblUser6.Name = "lblUser6"
        Me.lblUser6.Size = New System.Drawing.Size(81, 25)
        Me.lblUser6.TabIndex = 47
        Me.lblUser6.Text = "User 6"
        Me.lblUser6.Visible = False
        '
        'lblUser2
        '
        Me.lblUser2.AutoSize = True
        Me.lblUser2.BackColor = System.Drawing.Color.Transparent
        Me.lblUser2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser2.ForeColor = System.Drawing.Color.White
        Me.lblUser2.Location = New System.Drawing.Point(700, 531)
        Me.lblUser2.Name = "lblUser2"
        Me.lblUser2.Size = New System.Drawing.Size(81, 25)
        Me.lblUser2.TabIndex = 45
        Me.lblUser2.Text = "User 2"
        Me.lblUser2.Visible = False
        '
        'lblUser3
        '
        Me.lblUser3.AutoSize = True
        Me.lblUser3.BackColor = System.Drawing.Color.Transparent
        Me.lblUser3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser3.ForeColor = System.Drawing.Color.White
        Me.lblUser3.Location = New System.Drawing.Point(533, 571)
        Me.lblUser3.Name = "lblUser3"
        Me.lblUser3.Size = New System.Drawing.Size(81, 25)
        Me.lblUser3.TabIndex = 44
        Me.lblUser3.Text = "User 3"
        Me.lblUser3.Visible = False
        '
        'lblUser4
        '
        Me.lblUser4.AutoSize = True
        Me.lblUser4.BackColor = System.Drawing.Color.Transparent
        Me.lblUser4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser4.ForeColor = System.Drawing.Color.White
        Me.lblUser4.Location = New System.Drawing.Point(700, 571)
        Me.lblUser4.Name = "lblUser4"
        Me.lblUser4.Size = New System.Drawing.Size(81, 25)
        Me.lblUser4.TabIndex = 43
        Me.lblUser4.Text = "User 4"
        Me.lblUser4.Visible = False
        '
        'lblUser5
        '
        Me.lblUser5.AutoSize = True
        Me.lblUser5.BackColor = System.Drawing.Color.Transparent
        Me.lblUser5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser5.ForeColor = System.Drawing.Color.White
        Me.lblUser5.Location = New System.Drawing.Point(533, 611)
        Me.lblUser5.Name = "lblUser5"
        Me.lblUser5.Size = New System.Drawing.Size(81, 25)
        Me.lblUser5.TabIndex = 42
        Me.lblUser5.Text = "User 5"
        Me.lblUser5.Visible = False
        '
        'lblUser1
        '
        Me.lblUser1.AutoSize = True
        Me.lblUser1.BackColor = System.Drawing.Color.Transparent
        Me.lblUser1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser1.ForeColor = System.Drawing.Color.White
        Me.lblUser1.Location = New System.Drawing.Point(533, 531)
        Me.lblUser1.Name = "lblUser1"
        Me.lblUser1.Size = New System.Drawing.Size(81, 25)
        Me.lblUser1.TabIndex = 46
        Me.lblUser1.Text = "User 1"
        Me.lblUser1.Visible = False
        '
        'btnUserSelectTournament
        '
        Me.btnUserSelectTournament.BackColor = System.Drawing.Color.Fuchsia
        Me.btnUserSelectTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserSelectTournament.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserSelectTournament.Location = New System.Drawing.Point(540, 456)
        Me.btnUserSelectTournament.Name = "btnUserSelectTournament"
        Me.btnUserSelectTournament.Size = New System.Drawing.Size(200, 50)
        Me.btnUserSelectTournament.TabIndex = 41
        Me.btnUserSelectTournament.Text = "Select Logged in Users For Tournament" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnUserSelectTournament.UseVisualStyleBackColor = False
        '
        'OutlineUser1
        '
        Me.OutlineUser1.BackColor = System.Drawing.Color.Transparent
        Me.OutlineUser1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutlineUser1.Location = New System.Drawing.Point(494, 523)
        Me.OutlineUser1.Name = "OutlineUser1"
        Me.OutlineUser1.Size = New System.Drawing.Size(133, 40)
        Me.OutlineUser1.TabIndex = 60
        Me.OutlineUser1.TabStop = False
        Me.OutlineUser1.Visible = False
        '
        'OutlineUser3
        '
        Me.OutlineUser3.BackColor = System.Drawing.Color.Transparent
        Me.OutlineUser3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutlineUser3.Location = New System.Drawing.Point(494, 563)
        Me.OutlineUser3.Name = "OutlineUser3"
        Me.OutlineUser3.Size = New System.Drawing.Size(133, 40)
        Me.OutlineUser3.TabIndex = 61
        Me.OutlineUser3.TabStop = False
        Me.OutlineUser3.Visible = False
        '
        'OutlineUser5
        '
        Me.OutlineUser5.BackColor = System.Drawing.Color.Transparent
        Me.OutlineUser5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutlineUser5.Location = New System.Drawing.Point(494, 603)
        Me.OutlineUser5.Name = "OutlineUser5"
        Me.OutlineUser5.Size = New System.Drawing.Size(133, 40)
        Me.OutlineUser5.TabIndex = 62
        Me.OutlineUser5.TabStop = False
        Me.OutlineUser5.Visible = False
        '
        'OutlineUser6
        '
        Me.OutlineUser6.BackColor = System.Drawing.Color.Transparent
        Me.OutlineUser6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutlineUser6.Location = New System.Drawing.Point(661, 603)
        Me.OutlineUser6.Name = "OutlineUser6"
        Me.OutlineUser6.Size = New System.Drawing.Size(133, 40)
        Me.OutlineUser6.TabIndex = 63
        Me.OutlineUser6.TabStop = False
        Me.OutlineUser6.Visible = False
        '
        'OutlineUser4
        '
        Me.OutlineUser4.BackColor = System.Drawing.Color.Transparent
        Me.OutlineUser4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutlineUser4.Location = New System.Drawing.Point(661, 563)
        Me.OutlineUser4.Name = "OutlineUser4"
        Me.OutlineUser4.Size = New System.Drawing.Size(133, 40)
        Me.OutlineUser4.TabIndex = 64
        Me.OutlineUser4.TabStop = False
        Me.OutlineUser4.Visible = False
        '
        'OutlineUser2
        '
        Me.OutlineUser2.BackColor = System.Drawing.Color.Transparent
        Me.OutlineUser2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OutlineUser2.Location = New System.Drawing.Point(661, 523)
        Me.OutlineUser2.Name = "OutlineUser2"
        Me.OutlineUser2.Size = New System.Drawing.Size(133, 40)
        Me.OutlineUser2.TabIndex = 65
        Me.OutlineUser2.TabStop = False
        Me.OutlineUser2.Visible = False
        '
        'frmTourneySetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.lblUser2)
        Me.Controls.Add(Me.pbxUser2)
        Me.Controls.Add(Me.pbxUser1)
        Me.Controls.Add(Me.lblUser1)
        Me.Controls.Add(Me.lblNotice)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPlayTournament)
        Me.Controls.Add(Me.pbxUser3)
        Me.Controls.Add(Me.pbxUser4)
        Me.Controls.Add(Me.pbxUser5)
        Me.Controls.Add(Me.pbxUser6)
        Me.Controls.Add(Me.lblUser6)
        Me.Controls.Add(Me.lblUser3)
        Me.Controls.Add(Me.lblUser4)
        Me.Controls.Add(Me.lblUser5)
        Me.Controls.Add(Me.btnUserSelectTournament)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.tbxTournamentName)
        Me.Controls.Add(Me.OutlineUser1)
        Me.Controls.Add(Me.OutlineUser3)
        Me.Controls.Add(Me.OutlineUser5)
        Me.Controls.Add(Me.OutlineUser2)
        Me.Controls.Add(Me.OutlineUser4)
        Me.Controls.Add(Me.OutlineUser6)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTourneySetup"
        Me.Text = "frmTourneySetup"
        CType(Me.pbxUser2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxUser3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxUser4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxUser5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxUser6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxUser1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutlineUser1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutlineUser3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutlineUser5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutlineUser6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutlineUser4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutlineUser2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserName As Label
    Friend WithEvents tbxTournamentName As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblNotice As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPlayTournament As Button
    Friend WithEvents pbxUser2 As PictureBox
    Friend WithEvents pbxUser3 As PictureBox
    Friend WithEvents pbxUser4 As PictureBox
    Friend WithEvents pbxUser5 As PictureBox
    Friend WithEvents pbxUser6 As PictureBox
    Friend WithEvents pbxUser1 As PictureBox
    Friend WithEvents lblUser6 As Label
    Friend WithEvents lblUser2 As Label
    Friend WithEvents lblUser3 As Label
    Friend WithEvents lblUser4 As Label
    Friend WithEvents lblUser5 As Label
    Friend WithEvents lblUser1 As Label
    Friend WithEvents btnUserSelectTournament As Button
    Friend WithEvents OutlineUser1 As PictureBox
    Friend WithEvents OutlineUser3 As PictureBox
    Friend WithEvents OutlineUser5 As PictureBox
    Friend WithEvents OutlineUser6 As PictureBox
    Friend WithEvents OutlineUser4 As PictureBox
    Friend WithEvents OutlineUser2 As PictureBox
End Class
