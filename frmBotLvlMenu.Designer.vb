<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBotLvlMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBotLvlMenu))
        Me.btnBotEasy = New System.Windows.Forms.Button()
        Me.btnBotUnbeatable = New System.Windows.Forms.Button()
        Me.btnBotDifficult = New System.Windows.Forms.Button()
        Me.btnBotMedium = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBotEasy
        '
        Me.btnBotEasy.BackColor = System.Drawing.Color.Fuchsia
        Me.btnBotEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBotEasy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBotEasy.Location = New System.Drawing.Point(540, 392)
        Me.btnBotEasy.Name = "btnBotEasy"
        Me.btnBotEasy.Size = New System.Drawing.Size(200, 50)
        Me.btnBotEasy.TabIndex = 2
        Me.btnBotEasy.Text = "Easy Bot"
        Me.btnBotEasy.UseVisualStyleBackColor = False
        '
        'btnBotUnbeatable
        '
        Me.btnBotUnbeatable.BackColor = System.Drawing.Color.Fuchsia
        Me.btnBotUnbeatable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBotUnbeatable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBotUnbeatable.Location = New System.Drawing.Point(540, 560)
        Me.btnBotUnbeatable.Name = "btnBotUnbeatable"
        Me.btnBotUnbeatable.Size = New System.Drawing.Size(200, 50)
        Me.btnBotUnbeatable.TabIndex = 3
        Me.btnBotUnbeatable.Text = "Unbeatable Bot"
        Me.btnBotUnbeatable.UseVisualStyleBackColor = False
        '
        'btnBotDifficult
        '
        Me.btnBotDifficult.BackColor = System.Drawing.Color.Fuchsia
        Me.btnBotDifficult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBotDifficult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBotDifficult.Location = New System.Drawing.Point(540, 504)
        Me.btnBotDifficult.Name = "btnBotDifficult"
        Me.btnBotDifficult.Size = New System.Drawing.Size(200, 50)
        Me.btnBotDifficult.TabIndex = 4
        Me.btnBotDifficult.Text = "Difficult Bot"
        Me.btnBotDifficult.UseVisualStyleBackColor = False
        '
        'btnBotMedium
        '
        Me.btnBotMedium.BackColor = System.Drawing.Color.Fuchsia
        Me.btnBotMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBotMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBotMedium.Location = New System.Drawing.Point(540, 448)
        Me.btnBotMedium.Name = "btnBotMedium"
        Me.btnBotMedium.Size = New System.Drawing.Size(200, 50)
        Me.btnBotMedium.TabIndex = 5
        Me.btnBotMedium.Text = "Medium Bot"
        Me.btnBotMedium.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Fuchsia
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 658)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(200, 50)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmBotLvlMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnBotMedium)
        Me.Controls.Add(Me.btnBotDifficult)
        Me.Controls.Add(Me.btnBotUnbeatable)
        Me.Controls.Add(Me.btnBotEasy)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBotLvlMenu"
        Me.Text = "frmBotLvlMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBotEasy As Button
    Friend WithEvents btnBotUnbeatable As Button
    Friend WithEvents btnBotDifficult As Button
    Friend WithEvents btnBotMedium As Button
    Friend WithEvents btnBack As Button
End Class
