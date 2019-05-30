Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class frmPVPSetupMenu
    Public Friendly As Boolean = False

    Public Player1 As String = ""
    Public Player2 As String = ""

    Dim player1Wins As Integer
    Dim player2Wins As Integer
    Dim player1and2Ties As Integer


    Private Sub frmPVPSetupMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Height = 720
        Me.Width = 1280

        'centre the form on the screen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
    Private Sub btnFriendlyPVP_Click(sender As Object, e As EventArgs) Handles btnNoLoginPVP.Click
        Friendly = True
        frmGame.Show()
        Me.Hide()
        frmMenu.Hide()
    End Sub

    Public Sub btnUserSelectPvP_Click(sender As Object, e As EventArgs) Handles btnUserSelectPvP.Click


        Dim arrayOflabels As Object(,) = New Object(,) {
            {frmMenu.lblUser1, pbxUser1, lblUser1},
            {frmMenu.lblUser2, pbxUser2, lblUser2},
            {frmMenu.lblUser3, pbxUser3, lblUser3},
            {frmMenu.lblUser4, pbxUser4, lblUser4},
            {frmMenu.lblUser5, pbxUser5, lblUser5},
            {frmMenu.lblUser6, pbxUser6, lblUser6}
        }

        For i = 0 To arrayOflabels.GetLength(0) - 1
            If arrayOflabels(i, 0).Visible = True Then 'if user label shows on menu form
                arrayOflabels(i, 1).Visible = True 'show user pbx on this form 
                arrayOflabels(i, 2).Visible = True 'show user label on this form
                arrayOflabels(i, 2).Text = arrayOflabels(i, 0).Text 'user label on this form = username from menu

                btnClearSlelectedUsers.Visible = True
                lblNotice.Visible = True
            End If
        Next

        frmMenu.Hide() ' hide frmmenu
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'loads menu form and loads its main sub

        frmMenu.Show()
        frmMenu.Main()
        Me.Hide()



        For Each Obj As Control In Controls
            If Obj.Name.Contains("lblUser") Or Obj.Name.Contains("pbxUser") Or Obj.Name.Contains("OutlineUser") Then
                Obj.Visible = False 'closes all user info
            End If

            btnClearSlelectedUsers.Visible = False
            lblNotice.Visible = False
        Next
    End Sub


    Private Sub btnPlayUserPVP_Click(sender As Object, e As EventArgs) Handles btnPlayUserPVP.Click

        If Player1 = "" Or Player2 = "" Then
            Exit Sub
        Else
            frmGame.Show()
            Me.Hide()
        End If

    End Sub

    Sub MatchData()
        If Player1 = "" Or Player2 = "" Then
            Exit Sub
        Else
            lblMatchUpP1.Text = Player1
            lblMatchUpP2.Text = Player2

            pnlMatchUp.Visible = True
            Dim dbConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=UserData.accdb"

#Region "Get Player1Wins"

            Dim player1WinsQRY As String = "SELECT Count(tblMatches.ID) AS CountOfID, tblMatches.Player1, tblMatches.Player2, tblMatches.Player1Score, tblMatches.Player2Score
            FROM tblMatches
            GROUP BY tblMatches.Player1, tblMatches.Player2, tblMatches.Player1Score, tblMatches.Player2Score
            HAVING (((tblMatches.Player1)=@player1) 
            AND ((tblMatches.Player2)=@player2) 
            AND ((tblMatches.Player1Score)>[tblMatches].[Player2Score])) 
            OR (((tblMatches.Player1)= @player2) 
            AND ((tblMatches.Player2)=@player1) 
            AND ((tblMatches.Player2Score)>[tblMatches].[Player1Score]));"
            'Counts the rows in which player 1 has beaten player 2 in all cases
            Try
                Using dbConnection As New OleDbConnection(dbConnString) 'connects db to project

                    Dim cmmd As OleDbCommand = New OleDbCommand(player1WinsQRY, dbConnection)
                    dbConnection.Open()

                    cmmd.Parameters.AddWithValue("@player1", Player1) 'inputs player 1 and 2
                    cmmd.Parameters.AddWithValue("@player2", Player2)


                    Dim Results As OleDbDataReader = cmmd.ExecuteReader()
                    While (Results.Read())
                        player1Wins = player1Wins + Integer.Parse(Results.GetValue(0).ToString())
                        'creates player1wins as a value
                    End While
                End Using
            Catch ex As Exception
                player1Wins = 0
            End Try
#End Region
#Region "Get Player2Wins"
            Dim player2WinsQRY As String = "SELECT Count(tblMatches.ID) AS CountOfID, tblMatches.Player1, tblMatches.Player2, tblMatches.Player1Score, tblMatches.Player2Score
            FROM tblMatches
            GROUP BY tblMatches.Player1, tblMatches.Player2, tblMatches.Player1Score, tblMatches.Player2Score
            HAVING (((tblMatches.Player1)=@player1) 
            AND ((tblMatches.Player2)=@player2) 
            AND ((tblMatches.Player2Score)>[tblMatches].[Player1Score])) 
            OR (((tblMatches.Player1)= @player2) 
            AND ((tblMatches.Player2)=@player1) 
            AND ((tblMatches.Player1Score)>[tblMatches].[Player2Score]));"
            'Counts the rows in which player 2 has beaten player 1 in all cases
            Try
                Using dbConnection As New OleDbConnection(dbConnString) 'connects db to project

                    Dim cmmd As OleDbCommand = New OleDbCommand(player2WinsQRY, dbConnection)
                    dbConnection.Open()

                    cmmd.Parameters.AddWithValue("@player1", Player1) 'inputs player 1 and 2
                    cmmd.Parameters.AddWithValue("@player2", Player2)

                    Dim Results As OleDbDataReader = cmmd.ExecuteReader()
                    While (Results.Read())
                        player2Wins = player2Wins + Integer.Parse(Results.GetValue(0).ToString())
                        'creates player2wins as a value
                    End While

                End Using
            Catch ex As Exception
                player2Wins = 0
            End Try
#End Region
#Region "Get Ties"
            Dim playerTiesQRY As String = "SELECT Count(tblMatches.ID) AS CountOfID, tblMatches.Player1, tblMatches.Player2, tblMatches.Player1Score, tblMatches.Player2Score
            FROM tblMatches
            GROUP BY tblMatches.Player1, tblMatches.Player2, tblMatches.Player1Score, tblMatches.Player2Score
            HAVING (((tblMatches.Player1)=@player1) 
            AND ((tblMatches.Player2)=@player2) 
            AND ((tblMatches.Player2Score)=[tblMatches].[Player1Score])
            AND ((tblMatches.Player1Score)=[tblMatches].[Player2Score]));"
            'Counts the rows in which player 2 has tied player 1 in all cases
            Try
                Using dbConnection As New OleDbConnection(dbConnString) 'connects db to project

                    Dim cmmd As OleDbCommand = New OleDbCommand(playerTiesQRY, dbConnection)
                    dbConnection.Open()

                    cmmd.Parameters.AddWithValue("@player1", Player1) 'inputs player 1 and 2
                    cmmd.Parameters.AddWithValue("@player2", Player2)


                    Dim Results As OleDbDataReader = cmmd.ExecuteReader()
                    While (Results.Read())
                        player1and2Ties = player1and2Ties + Integer.Parse(Results.GetValue(0).ToString())
                        'creates playerties as a value
                    End While
                End Using
            Catch ex As Exception
                player1and2Ties = 0
            End Try
        End If
#End Region

        lblMatchUpP1W.Text = player1Wins
        lblMatchUpP2L.Text = player1Wins

        lblMatchUpP2W.Text = player2Wins
        lblMatchUpP1L.Text = player2Wins

        lblMatchUpTie.Text = player1and2Ties
    End Sub

#Region "Selecting Users"

    Private Sub lblUser1_DoubleClick(sender As Object, e As EventArgs) Handles lblUser1.DoubleClick
        If Player1 = "" Then
            Player1 = lblUser1.Text
            OutlineUser1.Visible = True
        ElseIf Player2 = "" Then
            Player2 = lblUser1.Text
            OutlineUser1.Visible = True
        End If

        MatchData()
    End Sub

    Private Sub lblUser2_DoubleClick(sender As Object, e As EventArgs) Handles lblUser2.DoubleClick
        If Player1 = "" Then
            Player1 = lblUser2.Text
            OutlineUser2.Visible = True
        ElseIf Player2 = "" Then
            Player2 = lblUser2.Text
            OutlineUser2.Visible = True
        End If

        MatchData()
    End Sub

    Private Sub lblUser3_DoubleClick(sender As Object, e As EventArgs) Handles lblUser3.DoubleClick
        If Player1 = "" Then
            Player1 = lblUser3.Text
            OutlineUser3.Visible = True
        ElseIf Player2 = "" Then
            Player2 = lblUser3.Text
            OutlineUser3.Visible = True
        End If

        MatchData()
    End Sub

    Private Sub lblUser4_DoubleClick(sender As Object, e As EventArgs) Handles lblUser4.DoubleClick
        If Player1 = "" Then
            Player1 = lblUser4.Text
            OutlineUser4.Visible = True
        ElseIf Player2 = "" Then
            Player2 = lblUser4.Text
            OutlineUser4.Visible = True
        End If

        MatchData()
    End Sub

    Private Sub lblUser5_DoubleClick(sender As Object, e As EventArgs) Handles lblUser5.DoubleClick
        If Player1 = "" Then
            Player1 = lblUser5.Text
            OutlineUser5.Visible = True
        ElseIf Player2 = "" Then
            Player2 = lblUser5.Text
            OutlineUser5.Visible = True
        End If

        MatchData()
    End Sub

    Private Sub lblUser6_DoubleClick(sender As Object, e As EventArgs) Handles lblUser6.DoubleClick
        If Player1 = "" Then
            Player1 = lblUser6.Text
            OutlineUser6.Visible = True
        ElseIf Player2 = "" Then
            Player2 = lblUser6.Text
            OutlineUser6.Visible = True
        End If

        MatchData()
    End Sub

    Private Sub btnClearSlelectedUsers_Click(sender As Object, e As EventArgs) Handles btnClearSlelectedUsers.Click
        Player1 = ""
        Player2 = ""

        For Each Obj As Control In Controls
            If Obj.Name.Contains("Outline") Then
                Obj.Visible = False 'closes all outlines
            End If
        Next

        pnlMatchUp.Visible = False

        player1Wins = 0
        player2Wins = 0
        player1and2Ties = 0
    End Sub
#End Region
End Class