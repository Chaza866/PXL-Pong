Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
''jaminima is gay
Public Class frmGame
#Region "Variables"
    Dim xDirection1 As Integer
    Dim yDirection1 As Integer
    Dim xVel As Single
    Dim yVel As Single
    Dim Inst As New Random() 'new random instance

    Dim rndIntbotlvl As Integer
    Dim botHit As Boolean = True
    Dim gameOver As Boolean = False
    Dim gameRun As Boolean = False
    Dim randomNumber1, randomNumber2 As Integer

    Dim wDown As Boolean
    Dim aDown As Boolean
    Dim sDown As Boolean
    Dim dDown As Boolean
    Dim leftDown As Boolean
    Dim rightDown As Boolean
    Dim upDown As Boolean
    Dim downDown As Boolean

    Dim p1Score As Integer = 0
    Dim p2Score As Integer = 0
    Public TourneyWinner As String

    Dim ballSpeed As Integer = 5
    Dim maxScore As Integer = frmMenu.maxPoints 'once this number is exceeded, game ends

    Dim stopWatch As New Stopwatch
#End Region

    Private Sub StartLocations()
        Dim ball1StartPos As Point = New Point(635, 355)
        Dim paddle1StartPos As Point = New Point(20, 260)
        Dim paddle2StartPos As Point = New Point(1240, 260)

        ball1.Location = ball1StartPos
        paddle1.Location = paddle1StartPos
        paddle2.Location = paddle2StartPos
    End Sub

    Sub Main()

        If frmMenu.gameModeSelected = frmMenu.gametype.Tournament Then
            If p1Score > maxScore Or p2Score > maxScore Then
                gameOver = True

                'when match is complete, upload match data
                playerStats()
                UploadData()
                If frmTourneyTransition.Pointer.ParentNode IsNot Nothing Then
                    'if match's node has a parent node

                    btnMatchFinished.Visible = True 'displays "next match" button
                    btnMatchFinished.Text = "Next Match"

                    If p1Score > p2Score Then ' if pl won
                        frmTourneyTransition.player1Won = True 'indicator used to pass players up tree
                        If frmTourneyTransition.Pointer Is frmTourneyTransition.Pointer.ParentNode.LeftNode Then
                            'if pointer node is left of its parent node
                            frmTourneyTransition.Pointer.ParentNode.Match.player1 = player1.UserName
                            'passes winners usename to parentNode match as player 1
                        Else
                            frmTourneyTransition.Pointer.ParentNode.Match.player2 = player1.UserName
                            'passes winners usename to parentNode match as player 2
                        End If

                    ElseIf p1Score < p2Score Then 'if p2 won
                        frmTourneyTransition.player1Won = False 'indicator shows player2 win
                        If frmTourneyTransition.Pointer Is frmTourneyTransition.Pointer.ParentNode.LeftNode Then
                            'if pointer node is left of its parent node
                            frmTourneyTransition.Pointer.ParentNode.Match.player1 = player2.UserName
                            'passes winners username to parentNode match as player1
                        Else
                            frmTourneyTransition.Pointer.ParentNode.Match.player2 = player2.UserName
                            'passes winners username to parentNode match as player2
                        End If
                    End If
                Else 'If pointer nodes parent node is nothing ie its the final match
                    If p1Score > p2Score Then 'if p1won
                        TourneyWinner = player1.UserName
                        'set tourneywinner variable to the winners name
                        UpdateTourneyWinner() 'updates winner information in db
                        frmWinner.Show() 'opens winner form
                        Me.Hide()
                        ClearControls() 'clears match information from frmGame
                    ElseIf p1Score < p2Score Then 'if p2won
                        TourneyWinner = player2.UserName
                        'set tourneywinner variable to the winners name
                        UpdateTourneyWinner() 'updates winner information in db 
                        frmWinner.Show() 'opens winner form
                        Me.Hide()
                        ClearControls() 'clears match information from frmGame
                    End If
                End If
            Else
                btnMatchFinished.Visible = False
            End If

        ElseIf frmMenu.gameModeSelected = frmMenu.gametype.PvP Then
            If p1Score > maxScore Or p2Score > maxScore Or p1Score = maxScore And p2Score = maxScore Then
                gameOver = True
                gameRun = False
                btnReMatch.Visible = True
                btnMatchFinished.Text = "Main Menu"
                btnMatchFinished.Visible = True

                If frmPVPSetupMenu.Friendly = False Then
                    playerStats()
                    UploadData()
                End If
            Else
                btnMatchFinished.Visible = False
            End If
        ElseIf frmMenu.gameModeSelected = frmMenu.gametype.Bot Then
            If p1Score > maxScore Then
                stopWatch.Stop()
                tmrStopWatch.Enabled = False
            End If
        End If
    End Sub
    Private Sub FrmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        playerStats()

        Me.Height = 720
        Me.Width = 1280

        StartLocations()

        p1Score = 0
        p2Score = 0

        If player1.UserName <> "" And player2.UserName <> "" Then
            lblPlayer1.Text = player1.UserName
            lblPlayer2.Text = player2.UserName

            lblPlayer1.Visible = True
            lblPlayer2.Visible = True
        End If

        'centre the form on the screen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub


    Private Sub tmrGame_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick


        'hides info labels 
        lblControls.Hide()
        lblControls2.Hide()
        lblControls3.Hide()

        ball1.Top = ball1.Top + yDirection1 'moves ball in randomized y direct decided as space is pressed
        ball1.Left = ball1.Left + xDirection1 'moves ball in randomized x direct decided as space is pressed

        If ball1.Top <= 0 Or ball1.Top >= Me.Height Then 'bounce ball ydir on collision with roof and floor
            yDirection1 = yDirection1 * -1
        End If


        If ball1.Bounds.IntersectsWith(paddle1.Bounds) Then
            If ball1.Top >= paddle1.Top And ball1.Bottom <= paddle1.Bottom Then
                xDirection1 = xDirection1 * -1 'bounce ball xdir on collision with paddle
                paddle1Bounce() 'prevents paddle1 moving when colliding with ball, this prevents ball passing through paddle
            Else 'if ball hits top or bottom of paddle1, then invert y direction
                yDirection1 = yDirection1 * -1
            End If
        ElseIf ball1.Bounds.IntersectsWith(paddle2.Bounds) Then
            If ball1.Top >= paddle2.Top And ball1.Bottom <= paddle2.Bottom Then
                xDirection1 = xDirection1 * -1 'bounce ball xdir on collision with paddle
                paddle2Bounce() 'prevents paddle2 moving when colliding with ball, this prevents ball passing through paddle
            Else 'if ball hits top or bottom of paddle2, then invert y direction
                yDirection1 = yDirection1 * -1
            End If
        End If

            Select Case ball1.Location.X 'if ball1's x pos goes of screen then reset ball to original location
            Case < 0
                If frmBotLvlMenu.botLvlSelected = frmBotLvlMenu.botLvl.unbeatable Then
                    tmrStopWatch.Enabled = False
                    stopWatch.Stop()
                    If tmrAutoPaddle.Enabled = True Then
                        lblNotice.Visible = True
                    End If
                End If

                gameRun = False
                p2Score = p2Score + 1
                lblP2Score.Text = p2Score
                Main()
                StartLocations()

            Case > Me.Width

                gameRun = False
                p1Score = p1Score + 1
                lblP1Score.Text = p1Score
                Main()
                StartLocations()
        End Select

        If gameRun = False Then
            StartLocations()
            tmrP1Move.Enabled = False
            tmrP2Move.Enabled = False
            tmrAutoPaddle.Enabled = False
            tmrGame.Enabled = False

            lblControls.Show()
            lblControls2.Show()
            lblControls3.Show()
        End If


        'paddle 1 boundaries - cant go off screen
        Select Case paddle1.Top
            Case < 0
                paddle1.Top = 0
            Case > Me.Height - paddle1.Height
                paddle1.Top = Me.Height - paddle1.Height
        End Select
        Select Case paddle1.Left
            Case < 0
                paddle1.Left = 0
            Case > Me.Width - paddle1.Width
                paddle1.Left = Me.Width - paddle1.Width
        End Select

        'paddle 2 boundaries - cant go off screen
        If tmrAutoPaddle.Enabled = True Then
        Else
            Select Case paddle2.Top
                Case < 0
                    paddle2.Top = 0
                Case > Me.Height - paddle2.Height
                    paddle2.Top = Me.Height - paddle2.Height
            End Select
            Select Case paddle2.Left
                Case < 0
                    paddle2.Left = 0
                Case > Me.Width - paddle2.Width
                    paddle2.Left = Me.Width - paddle2.Width
            End Select
        End If

    End Sub

    Private Sub paddle1Bounce() 'called when ball collides with paddle1, causes paddle to bounce in other direction and prevents paddle movinng through ball
        'all opposite directions to when key is pressed
        If wDown = True Then
            paddle1.Top = (paddle1.Top + 5)
            wDown = False
        End If
        If aDown = True Then
            paddle1.Left = (paddle1.Left + 5)
            aDown = False
        End If
        If sDown = True Then
            paddle1.Top = (paddle1.Top - 5)
            sDown = False
        End If
        If dDown = True Then
            paddle1.Left = (paddle1.Left - 5)
            dDown = False
        End If
    End Sub

    Private Sub paddle2Bounce() 'called when ball collides with paddle2, causes paddle to bounce in other direction and prevents paddle movinng through ball
        'all opposite directions to when key is pressed
        If leftDown = True Then
            paddle2.Left = (paddle2.Left + 5)
            leftDown = False
        End If
        If upDown = True Then
            paddle2.Top = (paddle2.Top + 5)
            upDown = False
        End If
        If rightDown = True Then
            paddle2.Left = (paddle2.Left - 5)
            rightDown = False
        End If
        If downDown = True Then
            paddle2.Top = (paddle2.Top - 5)
            downDown = False
        End If
    End Sub

    Private Sub tmrP1Move_Tick(sender As Object, e As EventArgs) Handles tmrP1Move.Tick
        If wDown = True Then
            paddle1.Top = paddle1.Top - 5
        End If
        If aDown = True Then
            paddle1.Left = paddle1.Left - 5
        End If
        If sDown = True Then
            paddle1.Top = paddle1.Top + 5
        End If
        If dDown = True Then
            paddle1.Left = paddle1.Left + 5
        End If

    End Sub
    Private Sub tmrP2Move_Tick(sender As Object, e As EventArgs) Handles tmrP2Move.Tick
        If leftDown = True Then
            paddle2.Left = paddle2.Left - 5
        End If
        If upDown = True Then
            paddle2.Top = paddle2.Top - 5
        End If
        If rightDown = True Then
            paddle2.Left = paddle2.Left + 5
        End If
        If downDown = True Then
            paddle2.Top = paddle2.Top + 5
        End If

    End Sub

    Private Sub frmGame_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.W 'keyboard press to control paddle1
                wDown = True
            Case Keys.A
                aDown = True
            Case Keys.S
                sDown = True
            Case Keys.D
                dDown = True
            Case Keys.Back 'backspace key takes to prior page

                If player1.UserName <> "" And player2.UserName <> "" Then
                    UploadData() 'if is game is exitted in the middle of match on competitive play, current scores uploaded to database
                End If

                frmMenu.Show() 'loads menu form and loads its main sub
                frmMenu.Main()
                gameRun = False
                tmrGame.Enabled = False
                tmrP1Move.Enabled = False
                tmrP2Move.Enabled = False
                ClearControls()
                Me.Hide()

        End Select

        If frmMenu.gameModeSelected = frmMenu.gametype.PvP Or frmMenu.gameModeSelected = frmMenu.gametype.Tournament Then 'if pvp is selected in menu then it disallows bot and allows players 2 keyboard controls
            Select Case e.KeyCode
                Case Keys.Up
                    upDown = True
                Case Keys.Left
                    leftDown = True
                Case Keys.Down
                    downDown = True
                Case Keys.Right
                    rightDown = True
            End Select
        End If
    End Sub

    Private Sub frmGame_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.W 'keyboard press to control paddle1
                wDown = False
            Case Keys.A
                aDown = False
            Case Keys.S
                sDown = False
            Case Keys.D
                dDown = False
        End Select

        If frmMenu.gameModeSelected = frmMenu.gametype.PvP Or frmMenu.gameModeSelected = frmMenu.gametype.Tournament Then 'if pvp is selected in menu then it disallows bot and allows players 2 keyboard controls
            Select Case e.KeyCode
                Case Keys.Up
                    upDown = False
                Case Keys.Left
                    leftDown = False
                Case Keys.Down
                    downDown = False
                Case Keys.Right
                    rightDown = False
            End Select
        End If
    End Sub

    Private Sub frmGame_KeyDown2(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        If gameRun = True Or gameOver = True Then 'prevents space causing problems when game is in play, such as changing ball dir
            Exit Sub
        End If
        Select Case e.KeyCode

            Case Keys.Space 'scacebar enables tmrgame
                'thus enabling timers
                ballSpeed = 5 'returns ballspeed back to default
                gameRun = True
                tmrGame.Enabled = True
                tmrP1Move.Enabled = True
                tmrP2Move.Enabled = True
                stopWatch.Reset()
                lblNotice.Visible = False

                If frmMenu.gameModeSelected = frmMenu.gametype.Bot Then
                    tmrAutoPaddle.Enabled = True
                Else
                    tmrAutoPaddle.Enabled =False
                End If


                If gameRun = True Then
                    Randomize()
                    randomNumber1 = (Int(Rnd() * 2))
                    randomNumber2 = (Int(Rnd() * 2))
                End If

                'chooses random angle, ballspeed * (min 5, max 9) <--- in radians
                xVel = Math.Cos(Inst.Next(5, 10) * ballSpeed)
                yVel = Math.Sin(Inst.Next(5, 10) * ballSpeed)


                'random numbers to declare starting direction for ball when space is pressed
                Select Case randomNumber1 'decides xdir = +or- ballspeed 
                    Case 1
                        xDirection1 = 1.3 * (+xVel + ballSpeed) 'ballspeed defaulted to 5 added to generated xvel
                    Case 0
                        xDirection1 = 1.3 * (-xVel - ballSpeed) 'random coefficient at the front to create reasonable speed
                End Select
                Select Case randomNumber2 'decides ydir = +or- ballspeed
                    Case 1
                        yDirection1 = 1.3 * (+yVel + ballSpeed) 'ballspeed defaulted to 5 added to generated yvel
                    Case 0
                        yDirection1 = 1.3 * (-yVel - ballSpeed)
                End Select
        End Select
    End Sub


    Private Sub tmrAutoPaddle_Tick(sender As Object, e As EventArgs) Handles tmrAutoPaddle.Tick


        botDifficulty()
        'sub to control auto paddle 
        Dim ball1pos As Point = New Point(ball1.Location)

        If ball1.Bounds.IntersectsWith(paddle1.Bounds) Then 'bounce on paddle1 regenerated random number to determine hit or miss for bot

            Randomize()
            rndIntbotlvl = CInt(Math.Ceiling(Rnd() * 10)) + 1 'chooses rnd number between 1 and 10
            botDifficulty() 'calls this sub
        End If




        'if game mode selected is bot then run as auto paddle otherwise exit sub for PVP
        If frmMenu.gameModeSelected = frmMenu.gametype.Bot Then

            If botHit = True Then 'allows bot to hit ball
                paddle2.Location = New Point(paddle2.Location.X, (ball1pos.Y - (paddle2.Height / 2))) 'causes paddle 2 to follow ball y pos so middle of paddle always hits
            ElseIf botHit = False Then 'disallows bot to hit ball
                paddle2.Location = New Point(paddle2.Location.X, (ball1pos.Y + 100)) 'moves paddle 100 units away from ball so its a miss
            End If
        Else
            Exit Sub 'if bot mode is not selected then the above is exitted and unneeded
        End If
    End Sub

    Class Player
        Property UserName As String
    End Class
    Dim player1 As New Player
    Dim player2 As New Player
    Public Sub playerStats()
        If frmMenu.gameModeSelected = frmMenu.gametype.PvP Then
            player1.UserName = frmPVPSetupMenu.Player1
            player2.UserName = frmPVPSetupMenu.Player2
        End If

        If frmMenu.gameModeSelected = frmMenu.gametype.Tournament Then
            player1.UserName = frmTourneyTransition.Pointer.Match.player1
            player2.UserName = frmTourneyTransition.Pointer.Match.player2
        End If
    End Sub

    Sub botDifficulty()

        Select Case frmBotLvlMenu.botLvlSelected
            Case frmBotLvlMenu.botLvl.easy 'selects easy bot outcomes
                If rndIntbotlvl <= 5 Then '50% miss rate
                    botHit = False
                Else botHit = True
                End If

            Case frmBotLvlMenu.botLvl.medium 'selects medium bot outcomes
                If rndIntbotlvl <= 3 Then '30% miss rate
                    botHit = False
                Else botHit = True
                End If


            Case frmBotLvlMenu.botLvl.difficult 'selects difficult bot outcomes

                If rndIntbotlvl <= 1 Then '10% miss rate
                    botHit = False
                Else botHit = True
                End If

            Case frmBotLvlMenu.botLvl.unbeatable 'selects unbeatable bot outcomes
                botHit = True '0% miss
                lblStopWatch.Visible = True
                tmrStopWatch.Start()
                stopWatch.Start()
        End Select
    End Sub

    Sub UploadData()

        Dim dbConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=UserData.accdb"
        Dim QRYString As String = "INSERT INTO [tblMatches] ([Player1],[Player2],[DateOfMatch],[Player1Score],[Player2Score],[TournamentName])
        VALUES (@player1,@player2,@date,@player1score,@player2score,@tournamentName)"

        Using dbConnection As New OleDbConnection(dbConnString) 'connects db to project

            Dim cmmd As OleDbCommand = New OleDbCommand(QRYString, dbConnection)
            dbConnection.Open()

            cmmd.Parameters.AddWithValue("@player1", player1.UserName)
            cmmd.Parameters.AddWithValue("@player2", player2.UserName)
            cmmd.Parameters.AddWithValue("@date", Today.ToShortDateString())
            cmmd.Parameters.AddWithValue("@player1score", p1Score)
            cmmd.Parameters.AddWithValue("@player2score", p2Score)
            If frmMenu.gameModeSelected = frmMenu.gametype.Tournament Then
                cmmd.Parameters.AddWithValue("@tournamentName", frmTourneySetup.tournamentName)
            Else
                cmmd.Parameters.AddWithValue("@tournamentName", "")
            End If

            cmmd.ExecuteNonQuery()

        End Using
    End Sub
    Private Sub btnReMatch_Click(sender As Object, e As EventArgs) Handles btnReMatch.Click
        If frmPVPSetupMenu.Friendly = True Then
        Else
            playerStats()
            UploadData()
        End If

        ClearControls()
        FrmGame_Load(e, e)
        gameOver = False

    End Sub

    Private Sub btnMatchFinished_Click(sender As Object, e As EventArgs) Handles btnMatchFinished.Click
        If btnMatchFinished.Text = "Main Menu" Then
            Me.Hide()
            ClearControls()
            frmMenu.Show()
        Else
            frmTourneyTransition.Show()
            frmTourneyTransition.lblTimer.Text = 5
            frmTourneyTransition.tmrTourneyStart.Enabled = True
            frmTourneyTransition.NextMatch()

            ClearControls()
            FrmGame_Load(e, e)
            Me.Hide()
        End If
        gameOver = False
    End Sub

    Private Sub tmrUnbeatableBot_Tick(sender As Object, e As EventArgs) Handles tmrStopWatch.Tick
        Dim elapsed As TimeSpan = stopWatch.Elapsed
        lblStopWatch.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds)
    End Sub

    Private Sub UpdateTourneyWinner()
        Dim dbConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=UserData.accdb"
        Dim QRYString As String = "UPDATE [tblTournaments] SET tblTournaments.Winner = @winner
        WHERE (((tblTournaments.TournamentName) = @tourneyName))"

        Using dbConnection As New OleDbConnection(dbConnString) 'connects db to project

            Dim cmmd As OleDbCommand = New OleDbCommand(QRYString, dbConnection)
            dbConnection.Open()

            cmmd.Parameters.AddWithValue("@winner", TourneyWinner)
            cmmd.Parameters.AddWithValue("@tourneyName", frmTourneySetup.tournamentName)

            cmmd.ExecuteNonQuery()

        End Using
    End Sub

    Public Sub ClearControls()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        p1Score = 0
        p2Score = 0
    End Sub
End Class

