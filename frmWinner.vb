Public Class frmWinner
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Hide()
        frmMenu.Show()

    End Sub
    Private Sub Main()
        lblUser.Text = frmGame.TourneyWinner.ToUpper
        lblTournament.Text = frmTourneySetup.tournamentName.ToUpper

        lblUser.Left = ((Me.Width / 2) - (lblUser.Width / 2))
        lblTournament.Left = ((Me.Width / 2) - (lblTournament.Width / 2))
    End Sub
    Private Sub frmWinner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main()
        Me.Height = 720
        Me.Width = 1280

        'centre the form on the screen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
End Class