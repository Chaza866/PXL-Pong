<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWinner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWinner))
        Me.lblNotice = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblTournament = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNotice
        '
        Me.lblNotice.AccessibleName = ""
        Me.lblNotice.AutoSize = True
        Me.lblNotice.BackColor = System.Drawing.Color.Transparent
        Me.lblNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotice.ForeColor = System.Drawing.Color.White
        Me.lblNotice.Location = New System.Drawing.Point(420, 62)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(440, 216)
        Me.lblNotice.TabIndex = 13
        Me.lblNotice.Text = "WINNER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OF"
        Me.lblNotice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUser
        '
        Me.lblUser.AccessibleName = ""
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Magenta
        Me.lblUser.Location = New System.Drawing.Point(390, 495)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(510, 108)
        Me.lblUser.TabIndex = 14
        Me.lblUser.Text = "UserName"
        '
        'lblTournament
        '
        Me.lblTournament.AccessibleName = ""
        Me.lblTournament.AutoSize = True
        Me.lblTournament.BackColor = System.Drawing.Color.Transparent
        Me.lblTournament.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTournament.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblTournament.Location = New System.Drawing.Point(353, 293)
        Me.lblTournament.Name = "lblTournament"
        Me.lblTournament.Size = New System.Drawing.Size(571, 108)
        Me.lblTournament.TabIndex = 15
        Me.lblTournament.Text = "Tournament"
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Fuchsia
        Me.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(540, 624)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(200, 50)
        Me.btnMainMenu.TabIndex = 16
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AccessibleName = ""
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(572, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 108)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "is"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmWinner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblTournament)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblNotice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWinner"
        Me.Text = "frmWinner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNotice As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblTournament As Label
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents Label1 As Label
End Class
