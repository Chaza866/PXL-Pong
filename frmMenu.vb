Public Class frmMenu
    Public gameModeSelected As gametype
    Public Enum gametype 'lets each form see what game mode is selected of the two
        Bot
        PvP
        Tournament
    End Enum
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Height = 720
        Me.Width = 1280

        'centre the form on the screen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

    End Sub

    Sub Main()

        '2D array of variables used for following if statement
        Dim arrayOfUsers As Object(,) = New Object(,) {
            {lblUser1, pbxUser1, frmLoginMenu.User1},
            {lblUser2, pbxUser2, frmLoginMenu.User2},
            {lblUser3, pbxUser3, frmLoginMenu.User3},
            {lblUser4, pbxUser4, frmLoginMenu.User4},
            {lblUser5, pbxUser5, frmLoginMenu.User5},
            {lblUser6, pbxUser6, frmLoginMenu.User6}
        }

        'if statement for if user.name <> "" then show the labels and write the username text into the menu label 
        For i = 0 To arrayOfUsers.GetLength(0) - 1 'if one of the users is already displayed on main menu, use next label
            If arrayOfUsers(i, 2).Name <> "" Then 'if next users name isnt blank
                arrayOfUsers(i, 0).Show() 'shows corresponding users label 
                arrayOfUsers(i, 1).Show() 'shows corresponding users icon
                arrayOfUsers(i, 0).Text = arrayOfUsers(i, 2).Name 'puts users name into corresponding label
            End If
        Next


    End Sub
#Region "Main navigation buttons clicked"
    Private Sub btnBotPlay_Click(sender As Object, e As EventArgs) Handles btnBotPlay.Click
        frmBotLvlMenu.Show() 'opens bot lvl menu
        Me.Hide()
        gameModeSelected = gametype.Bot 'selected gamemode bot as public variable
    End Sub

    Private Sub btnPVPPlay_Click(sender As Object, e As EventArgs) Handles btnToPvPMenu.Click
        frmPVPSetupMenu.Show() 'opens game form
        gameModeSelected = gametype.PvP 'selected gamemode pvp as public variable

    End Sub

    Private Sub btnToLoginMenu_Click(sender As Object, e As EventArgs) Handles btnToLoginMenu.Click
        frmLoginMenu.Show() 'opens login menu
        Me.Hide()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        frmSignUpMenu.Show() 'opens signup menu
        Me.Hide()
    End Sub


    Private Sub btnToTourneySetup_Click(sender As Object, e As EventArgs) Handles btnToTourneySetup.Click
        frmTourneySetup.Show() 'opens tourneysetup menu
        gameModeSelected = gametype.Tournament
        frmTourneySetup.noOfPlayers = 0
        frmTourneyTransition.currentMatchNo = 1

    End Sub

    Private Sub btnExitGame_Click(sender As Object, e As EventArgs) Handles btnExitGame.Click
        Application.Exit() 'closes application
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim arrayForSignOut As Object(,) = New Object(,) {
        {btnSignOut, lblUser1, pbxUser1, frmLoginMenu.User1},
        {btnSignOut, lblUser2, pbxUser2, frmLoginMenu.User2},
        {btnSignOut, lblUser3, pbxUser3, frmLoginMenu.User3},
        {btnSignOut, lblUser4, pbxUser4, frmLoginMenu.User4},
        {btnSignOut, lblUser5, pbxUser5, frmLoginMenu.User5},
        {btnSignOut, lblUser6, pbxUser6, frmLoginMenu.User6}
        }

        For i As Integer = 0 To arrayForSignOut.GetLength(0) - 1 'if signout btn clicked, removes users label and picture box from menu
            If arrayForSignOut(i, 0).Location.Y = arrayForSignOut(i, 1).Location.Y Then 'depending on the height of the signout button
                arrayForSignOut(i, 1).Text = "" 'wipes corresponding label text
                arrayForSignOut(i, 3).Name = "" 'wipes corresponding users data
                arrayForSignOut(i, 2).Visible = False 'hides corresponding icon
                btnSignOut.Hide() 'hides signout button
            End If
        Next

    End Sub
#End Region

#Region "clicking user labels"
    Private Sub lblUser1_DoubleClick(sender As Object, e As EventArgs) Handles lblUser1.DoubleClick
        'when main menu user label is doubleclicked 
        btnSignOut.Location = New Point(1038, 686)
        btnSignOut.Show()
    End Sub

    Private Sub lblUser2_DoubleClick(sender As Object, e As EventArgs) Handles lblUser2.DoubleClick
        'when main menu user label is doubleclicked  
        btnSignOut.Location = New Point(1038, 646)
        btnSignOut.Show()
    End Sub

    Private Sub lblUser3_DoubleClick(sender As Object, e As EventArgs) Handles lblUser3.DoubleClick
        'when main menu user label is doubleclicked 
        btnSignOut.Location = New Point(1038, 606)
        btnSignOut.Show()
    End Sub

    Private Sub lblUser4_DoubleClick(sender As Object, e As EventArgs) Handles lblUser4.DoubleClick
        'when main menu user label is doubleclicked 
        btnSignOut.Location = New Point(1038, 566)
        btnSignOut.Show()
    End Sub

    Private Sub lblUser5_DoubleClick(sender As Object, e As EventArgs) Handles lblUser5.DoubleClick
        'when main menu user label is doubleclicked  
        btnSignOut.Location = New Point(1038, 526)
        btnSignOut.Show()
    End Sub

    Private Sub lblUser6_DoubleClick(sender As Object, e As EventArgs) Handles lblUser6.DoubleClick
        'when main menu user label is doubleclicked 
        btnSignOut.Location = New Point(1038, 486)
        btnSignOut.Show()
    End Sub

    Private Sub frmMenu_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        btnSignOut.Hide() 'hides signout button when user clicks anywhere on screen
    End Sub

    Public maxPoints As Integer = 5
    Private Sub btnEnterPoints_Click(sender As Object, e As EventArgs) Handles btnEnterPoints.Click
        If IsNumeric(tbxNoOfPoints.Text) Then
            If tbxNoOfPoints.Text > 0 And tbxNoOfPoints.Text < 1000 Then
                maxPoints = tbxNoOfPoints.Text - 1
                lblCurrentPointsSet.Text = tbxNoOfPoints.Text
            End If
        Else
            lblCurrentPointsSet.Text = "Invalid Input, Defaulted to 5"
        End If
    End Sub


#End Region
End Class

