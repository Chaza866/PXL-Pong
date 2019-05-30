<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignUpMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignUpMenu))
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.tbxPassword = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.tbxUserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxPasswordCfrm = New System.Windows.Forms.TextBox()
        Me.lblAlert = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Fuchsia
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.Location = New System.Drawing.Point(540, 608)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(200, 50)
        Me.btnSignUp.TabIndex = 10
        Me.btnSignUp.Text = "SignUp"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Black
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(580, 461)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(119, 25)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "PassWord"
        '
        'tbxPassword
        '
        Me.tbxPassword.BackColor = System.Drawing.Color.Black
        Me.tbxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPassword.ForeColor = System.Drawing.Color.White
        Me.tbxPassword.Location = New System.Drawing.Point(540, 488)
        Me.tbxPassword.Name = "tbxPassword"
        Me.tbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPassword.Size = New System.Drawing.Size(200, 31)
        Me.tbxPassword.TabIndex = 8
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Black
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(579, 392)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(121, 25)
        Me.lblUserName.TabIndex = 7
        Me.lblUserName.Text = "UserName"
        '
        'tbxUserName
        '
        Me.tbxUserName.BackColor = System.Drawing.Color.Black
        Me.tbxUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUserName.ForeColor = System.Drawing.Color.White
        Me.tbxUserName.Location = New System.Drawing.Point(540, 419)
        Me.tbxUserName.Name = "tbxUserName"
        Me.tbxUserName.Size = New System.Drawing.Size(200, 31)
        Me.tbxUserName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(540, 532)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Confirm Password"
        '
        'tbxPasswordCfrm
        '
        Me.tbxPasswordCfrm.BackColor = System.Drawing.Color.Black
        Me.tbxPasswordCfrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPasswordCfrm.ForeColor = System.Drawing.Color.White
        Me.tbxPasswordCfrm.Location = New System.Drawing.Point(540, 560)
        Me.tbxPasswordCfrm.Name = "tbxPasswordCfrm"
        Me.tbxPasswordCfrm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPasswordCfrm.Size = New System.Drawing.Size(200, 31)
        Me.tbxPasswordCfrm.TabIndex = 9
        '
        'lblAlert
        '
        Me.lblAlert.AutoSize = True
        Me.lblAlert.BackColor = System.Drawing.Color.Black
        Me.lblAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlert.ForeColor = System.Drawing.Color.Red
        Me.lblAlert.Location = New System.Drawing.Point(499, 661)
        Me.lblAlert.Name = "lblAlert"
        Me.lblAlert.Size = New System.Drawing.Size(288, 25)
        Me.lblAlert.TabIndex = 13
        Me.lblAlert.Text = "Please fill all empty boxes"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Fuchsia
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 658)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(200, 50)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmSignUpMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblAlert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxPasswordCfrm)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.tbxPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.tbxUserName)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSignUpMenu"
        Me.Text = "frmSignUpMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSignUp As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents tbxPassword As TextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents tbxUserName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxPasswordCfrm As TextBox
    Friend WithEvents lblAlert As Label
    Friend WithEvents btnBack As Button
End Class
