Public Class frmBotLvlMenu
    Public botLvlSelected As botLvl
    Public Enum botLvl
        easy
        medium
        difficult
        unbeatable
    End Enum

    Private Sub frmBotLvlMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Height = 720
        Me.Width = 1280

        'centre the form on the screen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

    End Sub


#Region "Bot lvl btns clicked"
    Private Sub btnBotEasy_Click(sender As Object, e As EventArgs) Handles btnBotEasy.Click
        frmGame.Show() 'opens game form
        Me.Hide()
        botLvlSelected = botLvl.easy 'sets easy as public variable for bot difficulty
    End Sub

    Private Sub btnBotMedium_Click(sender As Object, e As EventArgs) Handles btnBotMedium.Click
        frmGame.Show() 'opens game form
        Me.Hide()
        botLvlSelected = botLvl.medium 'sets medium as public variable for bot difficulty
    End Sub

    Private Sub btnBotDifficult_Click(sender As Object, e As EventArgs) Handles btnBotDifficult.Click
        frmGame.Show() 'opens game form
        Me.Hide()
        botLvlSelected = botLvl.difficult 'sets difficult as public variable for bot difficulty
    End Sub

    Private Sub btnBotUnbeatable_Click(sender As Object, e As EventArgs) Handles btnBotUnbeatable.Click
        frmGame.Show() 'opens game form
        Me.Hide()
        botLvlSelected = botLvl.unbeatable 'sets unbeatable as public variable for bot difficulty
    End Sub
#End Region

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'loads menu form and loads its main sub
        frmMenu.Show()
        frmMenu.Main()
        Me.Hide()
    End Sub


End Class