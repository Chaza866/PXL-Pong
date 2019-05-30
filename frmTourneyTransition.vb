Public Class frmTourneyTransition

    Public noOfPlayers As Integer
    Public player1Won As Boolean
    Dim treeCreated As Boolean = False
    Public currentMatchNo As Integer = 1

    Public arrayOfPlayerNames As String() = frmTourneySetup.arrayOfPlayerNames




    'Function to shuffle array of names, this shuffles the initial layout of players across match bracket
    Private Function ShuffleArray(ByVal Unshuffled As String()) As String() 'unshuffled is arrayofplayernames
        Unshuffled = RemoveNulls(Unshuffled) 'calls shuffle function to shuffle arrayofplayernames
        Dim ShuffledList As List(Of String) = New List(Of String)() 'creates new list for shuffled names
        Dim Rnd As Random = New Random()
        Dim UnshuffledList As List(Of String) = Unshuffled.ToList() 'transfers unshuffledarray to list

        While UnshuffledList.Count <> 0 'while array has values
            Dim RandomPosition As Integer = Rnd.[Next](0, UnshuffledList.Count)
            'creates variable as random number between 0 and unshuffledlist
            ShuffledList.Add(UnshuffledList(RandomPosition))
            'adds item in random poistion to ShuffledList 
            UnshuffledList.RemoveAt(RandomPosition)
            'clears item in same location of unshuffledList, slowly clears unshuffledlist
        End While

        Return ShuffledList.ToArray() 'returns shuffledlist as array
    End Function

    'removes null values from arrayOfPlayerNames
    Private Shared Function RemoveNulls(ByVal ArrayWithNulls As String()) As String()
        Dim ListWithNulls As List(Of String) = ArrayWithNulls.ToList() 'creates a list from arraywithnulls
        Dim ListWithoutNulls As List(Of String) = New List(Of String)() 'creates a list for the player arraywithoutnulls
        While ListWithNulls.Count <> 0 'if listwithnulls has items

            If ListWithNulls(0) IsNot Nothing Then 'if first item of list isnt null
                ListWithoutNulls.Add(ListWithNulls(0)) 'adds item to new list
            End If

            ListWithNulls.RemoveAt(0) 'removes this item from original list and loops
        End While

        Return ListWithoutNulls.ToArray() 'returns an array without nulls
    End Function



    Private Sub frmTourneyTransition_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Main()

        lblMatchPlayer1.Left = (Me.Width / 2) - (lblMatchPlayer1.Width / 2)
        lblMatchPlayer2.Left = (Me.Width / 2) - (lblMatchPlayer2.Width / 2)
        lblAnd.Left = (Me.Width / 2) - (lblAnd.Width / 2)

        Me.Height = 720
        Me.Width = 1280

        'centre the form on the screen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        lblTimer.Text = "5" 'default countdown value
        tmrTourneyStart.Enabled = True



        Dim arrayOflabels As Object(,) = New Object(,) {
           {frmTourneySetup.arrayOfPlayerNames(0), pbxUser1, lblUser1},
           {frmTourneySetup.arrayOfPlayerNames(1), pbxUser2, lblUser2},
           {frmTourneySetup.arrayOfPlayerNames(2), pbxUser3, lblUser3},
           {frmTourneySetup.arrayOfPlayerNames(3), pbxUser4, lblUser4},
           {frmTourneySetup.arrayOfPlayerNames(4), pbxUser5, lblUser5},
           {frmTourneySetup.arrayOfPlayerNames(5), pbxUser6, lblUser6}
       }

        For i = 0 To arrayOflabels.GetLength(0) - 1
            If arrayOflabels(i, 0) <> "" Then 'if playername exists as variable from frmtourneysetup

                arrayOflabels(i, 1).Visible = True 'show user pbx on this form 
                arrayOflabels(i, 2).Visible = True 'show user label on this form
                arrayOflabels(i, 2).Text = arrayOflabels(i, 0) 'user label on this form = player names
            End If
        Next

        frmTourneySetup.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrTourneyStart.Tick
        lblTimer.Text = lblTimer.Text - 1 'each tick, take 1 from the lbl's text

        If lblTimer.Text = 0 Then 'when timer reaches 0
            frmGame.Show() 'show game form
            Me.Hide() ' hide transition form
            tmrTourneyStart.Enabled = False 'disable timer
        End If
    End Sub


    Public Class Node 'creates node class 
        Public i As Integer 'used to indicate numbering of the nodes for the debug
        Public ParentNode As Node 'identifies the node above any node in tree
        Public LeftNode As Node 'identifies daughter node left of any node
        Public RightNode As Node 'identifies daughter node right of any node
        Public Match As Match 'adds match as a property of node

        Public Sub New(ParentNode As Node) 'creates a new match for each parentnode
            Match = New Match
            Me.ParentNode = ParentNode
        End Sub
    End Class

    Public Class Match 'creates match class
        '2 players in each match
        Property player1 As String
        Property player2 As String
    End Class

    Function NextNode(Optional StartNode As Node = Nothing) As Node
        'function determines the next node to go to, creates a post-order tree traversal

        If StartNode IsNot Nothing Then
            CurrentNode = StartNode 'starting from current node
            'if no match has been played yet(start of the tournament) then the following code deals with this
            'because current node is defined as source node from main sub before this function is called, defaulted to source
        End If

        If CurrentNode.LeftNode Is Nothing And CurrentNode.RightNode Is Nothing Then
            'if currentnode has no daughter nodes
            If CurrentNode.ParentNode Is Nothing Then 'if current node is source node ie first node
                CurrentNode = Nothing 'removes node from tree
            ElseIf CurrentNode.ParentNode.LeftNode Is CurrentNode Then
                'if current node is left of its parent

                CurrentNode.ParentNode.LeftNode = Nothing
                'removes node from tree

                If CurrentNode.ParentNode IsNot Nothing Then
                    'if current node has a parent
                    'if current node is right of parent
                    If CurrentNode.ParentNode.RightNode Is Nothing Then
                        CurrentNode = CurrentNode.ParentNode
                        'traverses tree upwards, next node is the parent
                    Else 'if current node is left of parent
                        CurrentNode = CurrentNode.ParentNode.RightNode
                        'traverses to the right, next node is parents rightnode
                    End If
                End If
                'else if current node is already right of parent
            ElseIf CurrentNode.ParentNode.RightNode Is CurrentNode Then
                CurrentNode.ParentNode.RightNode = Nothing 'remove node from tree
                CurrentNode = CurrentNode.ParentNode 'traverse upwards, next node is parent
            End If
        Else 'if current node has daughters

            While CurrentNode.LeftNode IsNot Nothing
                CurrentNode = CurrentNode.LeftNode
                'while current node has left daughter
                'current node = left daughter
                'sets current node to furthest left/bottom node
            End While
            While CurrentNode.RightNode IsNot Nothing
                CurrentNode = CurrentNode.RightNode
                'while current node has right daughter
                'current node = right daughter
                'sets current node to futhest right/bottom node
                'the order these while loops run always allows for bottom left node first
            End While
        End If
        Return CurrentNode 'returns the next node of the tree when traversed in post order, each time its run. 
    End Function

    'function poulates tournaments initial matches
    Private Sub PopulatePlayers(ByVal ThisNode As Node, ByRef CurrentPlayer As Integer)
        'thisNode's first value is sourceNode, currentPlayer is integer value starting at 0 before incrementing

        'calls shuffleArray function to randomise which players populate
        Dim shuffledArrayOfPlayerNames As String() = ShuffleArray(arrayOfPlayerNames)

        If ThisNode.LeftNode Is Nothing Then 'if thisNode.leftnode (thisNode starting from source node) is null
            ThisNode.Match.player1 = shuffledArrayOfPlayerNames(CurrentPlayer)
            'random player (from position 'currentplayer' in array) added to thisnode.match as player1
            CurrentPlayer += 1 'increments, used to iterate through positions in shuffled array of names
        Else
            PopulatePlayers(ThisNode.LeftNode, CurrentPlayer) 'recursively calls itself unil most left node is found
            'now thisnode = thisnode.leftnode ie it is iterating through nodes to find bottom left
        End If

        If ThisNode.RightNode Is Nothing Then 'if current thisNode has no rightnode then
            ThisNode.Match.player2 = shuffledArrayOfPlayerNames(CurrentPlayer)
            'random player (from position 'currentplayer' in array) added to thisnode.match as player2
            CurrentPlayer += 1 'incremented
        Else
            PopulatePlayers(ThisNode.RightNode, CurrentPlayer)
            'again calls itself recursively to find bottom right node from thisNode
        End If
    End Sub

    Dim CurrentNode As Node
    Dim SourceNode As Node = New Node(Nothing) 'creates initial node of tree, to build from

    Sub Main()
        If treeCreated = False Then
            'source node always first/top node of the tree, ie final node/match
            SourceNode.i = 1 'i used to indicate number of node, useful in debug and testing
            CurrentNode = SourceNode.LeftNode 'current node starts left of source
            'if more players were allowed, then current node would be changed, allowing for a more complex tree

            If noOfPlayers >= 3 Then
                'if players > 3 then second node will be left of source
                SourceNode.LeftNode = New Node(SourceNode) 'creates second node left of source
                SourceNode.LeftNode.i = 2

                If noOfPlayers = 4 Then
                    'if players = 4 then 3rd node will be right of source
                    SourceNode.RightNode = New Node(SourceNode) 'creates the third node right of source
                    SourceNode.RightNode.i = 3

                ElseIf noOfPlayers >= 5 Then
                    'if players > 5 then 3rd node will left of second node
                    CurrentNode = SourceNode.LeftNode 'current node remains second node

                    CurrentNode.LeftNode = New Node(CurrentNode) 'creates the 3rd node as left of current
                    CurrentNode.LeftNode.i = 3

                    If noOfPlayers = 5 Then
                        'if players = 5 then 4th node will be right of sourcenode
                        SourceNode.RightNode = New Node(SourceNode) 'creates the fourth node right of source
                        SourceNode.RightNode.i = 4
                    ElseIf noOfPlayers = 6 Then
                        'if players = 6 then 4th node will be right of secondnode
                        'and 5th node will right of soure node
                        CurrentNode.RightNode = New Node(CurrentNode) 'creates the fourth node right of current
                        CurrentNode.RightNode.i = 4
                        SourceNode.RightNode = New Node(SourceNode) 'creates the 5th node as right of source
                        SourceNode.RightNode.i = 5
                    End If
                End If
            End If
            Dim temp As Integer = 0 'temp used to step through array picking players
            PopulatePlayers(SourceNode, temp) 'calls Populate function with variables sourceNode and temp
            treeCreated = True 'prevents tree/match brackets being created again during tournament
        End If

        CurrentNode = SourceNode 'used to start tree travesal from the top in nextnode function

        NextMatch() 'calls next match function --> effectively calling nextode fucntion
    End Sub

    Public Pointer As Node

    Public Sub NextMatch()
        Pointer = NextNode()

        lblMatchPlayer1.Text = Pointer.Match.player1 'displays the two users playing the coming match
        lblMatchPlayer2.Text = Pointer.Match.player2

        lblTotalMatches.Text = noOfPlayers - 1 'displays total games to play this tournament
        lblCurrentMatch.Text = currentMatchNo 'displays the current match of the tournament

        If currentMatchNo <= noOfPlayers - 1 Then 'checks the "current game" is not more than the "Total number of games" in tournament 
            currentMatchNo = currentMatchNo + 1 'then increments the "current match no" variable each time this function is run
        End If
    End Sub



End Class
