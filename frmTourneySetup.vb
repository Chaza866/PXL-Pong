Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class frmTourneySetup
    Private Sub frmTourneySetup_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Height = 720
        Me.Width = 1280

        'centre the form on the screen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Public noOfPlayers As Integer
    Public tournamentName As String


    Public arrayOfPlayerNames As String() = New String(6) {} 'playernames array all dimmed with empty strings - max 6 players



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMenu.Show()
        frmMenu.Main()
        Me.Hide()

        tbxTournamentName.Text = ""

        For Each Obj As Control In Controls
            If Obj.Name.Contains("lblUser") Or Obj.Name.Contains("pbxUser") Or Obj.Name.Contains("OutlineUser") Then
                Obj.Visible = False 'closes all user info
            End If

            btnClear.Visible = False
            lblNotice.Visible = False
            noOfPlayers = 0
        Next
    End Sub


    Private Sub btnUserSelectTournament_Click(sender As Object, e As EventArgs) Handles btnUserSelectTournament.Click

        'creates object array filled by menu forms User's labels and the current forms user labels and picture boxes
        Dim arrayOflabels As Object(,) = New Object(,) {
           {frmMenu.lblUser1, pbxUser1, lblUser1},
           {frmMenu.lblUser2, pbxUser2, lblUser2},
           {frmMenu.lblUser3, pbxUser3, lblUser3},
           {frmMenu.lblUser4, pbxUser4, lblUser4},
           {frmMenu.lblUser5, pbxUser5, lblUser5},
           {frmMenu.lblUser6, pbxUser6, lblUser6}
       }

        For i = 0 To arrayOflabels.GetLength(0) - 1 'iterate loop up to length of array
            If arrayOflabels(i, 0).Visible = True Then 'if a users label is visible on menu form then

                arrayOflabels(i, 1).Visible = True 'show corresponding user pbx on this form 
                arrayOflabels(i, 2).Visible = True 'show corresponding user label on this form
                arrayOflabels(i, 2).Text = arrayOflabels(i, 0).Text 'user label on this form = username from menu
                btnClear.Visible = True
                lblNotice.Visible = True
            End If
        Next
        frmMenu.Hide() 'closes menu form because it's not needed anymore
    End Sub

    Private Sub lblUser1_DoubleClick(sender As Object, e As EventArgs) Handles lblUser1.DoubleClick
        'when users label is double clicked
        OutlineUser1.Visible = True 'display an outline around selected user
        noOfPlayers = noOfPlayers + 1 'increment noOfPlayers var, this will be used to creat a binary tree
        arrayOfPlayerNames(0) = lblUser1.Text 'adds this users name to first position in array
    End Sub

    Private Sub lblUser2_DoubleClick(sender As Object, e As EventArgs) Handles lblUser2.DoubleClick
        OutlineUser2.Visible = True
        noOfPlayers = noOfPlayers + 1
        arrayOfPlayerNames(1) = lblUser2.Text
    End Sub

    Private Sub lblUser3_DoubleClick(sender As Object, e As EventArgs) Handles lblUser3.DoubleClick
        OutlineUser3.Visible = True
        noOfPlayers = noOfPlayers + 1
        arrayOfPlayerNames(2) = lblUser3.Text
    End Sub

    Private Sub lblUser4_DoubleClick(sender As Object, e As EventArgs) Handles lblUser4.DoubleClick
        OutlineUser4.Visible = True
        noOfPlayers = noOfPlayers + 1
        arrayOfPlayerNames(3) = lblUser4.Text
    End Sub

    Private Sub lblUser5_DoubleClick(sender As Object, e As EventArgs) Handles lblUser5.DoubleClick
        OutlineUser5.Visible = True
        noOfPlayers = noOfPlayers + 1
        arrayOfPlayerNames(4) = lblUser5.Text
    End Sub

    Private Sub lblUser6_DoubleClick(sender As Object, e As EventArgs) Handles lblUser6.DoubleClick
        OutlineUser6.Visible = True
        noOfPlayers = noOfPlayers + 1
        arrayOfPlayerNames(5) = lblUser6.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        noOfPlayers = 0 'resets number of selected players
        For Each Obj As Control In Controls
            If Obj.Name.Contains("Outline") Then 'searches for objects with mane containing "Outline"
                Obj.Visible = False 'closes all outlines
            End If
        Next
    End Sub

    Private Sub btnPlayTournament_Click(sender As Object, e As EventArgs) Handles btnPlayTournament.Click
        If noOfPlayers > 6 Or noOfPlayers < 3 Then
            lblNotice.Text = "Minimum = 3 Players
Maximum = 6 Player"
        ElseIf tbxTournamentName.Text = "" Then
            lblNotice.Text = "Enter a Valid Tournament Name"
        Else
            Try
                tournamentName = tbxTournamentName.Text

                Dim dbConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=UserData.accdb"
                Dim QRYString As String = "INSERT INTO [tblTournaments] ([TournamentName],[NumberOfPlayers],[Winner])
        VALUES (@tournamentName, @noOfPlayers, @winner)"

                Using dbConnection As New OleDbConnection(dbConnString) 'connects db to project

                    Dim cmmd As OleDbCommand = New OleDbCommand(QRYString, dbConnection)
                    dbConnection.Open()

                    cmmd.Parameters.AddWithValue("@tournamentName", tournamentName)
                    cmmd.Parameters.AddWithValue("@noOfPlayers", noOfPlayers)
                    cmmd.Parameters.AddWithValue("@winner", "")

                    cmmd.ExecuteNonQuery()

                End Using

                frmTourneyTransition.noOfPlayers = noOfPlayers
                frmTourneyTransition.Show()
                Me.Controls.Clear() 'removes all the controls on the form
                InitializeComponent() 'load all the controls again
                Me.Hide()
                '^calls sub in trasition form to load form, neccessary if tournament has already been played before
            Catch ex As Exception
                lblNotice.Text = "Tounament Id Already Exists"
            End Try
        End If


    End Sub
End Class


