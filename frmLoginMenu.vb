Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class frmLoginMenu
    Public Class User 'creates user class
        Property Name As String

    End Class

#Region "Variables"
    Dim uNameLogin As String
    Dim pWordLogin As String
    Dim hashedPWord As String

#End Region

    'creates all 6 possible users that can login
    Public User1 As New User
    Public User2 As New User
    Public User3 As New User
    Public User4 As New User
    Public User5 As New User
    Public User6 As New User


    Private Sub frmLoginMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblAlert.Hide() 'hides warning label 



        Me.Height = 720
        Me.Width = 1280

        'centre the form on the screen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

        'defaults all users names to ""
        User1.Name = ""
        User2.Name = ""
        User3.Name = ""
        User4.Name = ""
        User5.Name = ""
        User6.Name = ""

    End Sub

    Shared Function GetHash(inputPWord As String) As String 'hashed inputed password 'same hashing function as on signup

        Using hasher As MD5 = MD5.Create()    ' create hash object

            ' Converts pword to byte array and get hash
            Dim dbytes As Byte() =
             hasher.ComputeHash(Encoding.UTF8.GetBytes(inputPWord))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString() 'returns hashed password as a string
        End Using

    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        lblAlert.ForeColor = Color.Red ' default warning label colour

        '{examples of users on db to test }
        '{user: admin pass: admin }
        '{user: charlie pass: 1234 }

        uNameLogin = tbxUserName.Text
        pWordLogin = tbxPassword.Text

        If tbxUserName.Text = "" Or tbxPassword.Text = "" Then 'if nothing is entered in txt boxes

            lblAlert.Show()
            lblAlert.Text = "Please fill all empty boxes"
            lblAlert.ForeColor = Color.Red
        Else
            hashedPWord = GetHash(pWordLogin) 'hashedpword takes hash from hashing funtion

            Dim dbConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=UserData.accdb"
            Dim LoginQRYString As String = "Select tblUserData.UserName, tblUserData.HashedPassword, tblUserData.DateOfCreation
                From tblUserData
                Where (((tblUserData.UserName) = @UserN) And ((tblUserData.HashedPassword) = @HashedPWord));"  'command to check username and password variables match ones already in db

            Using dbConnection As New OleDbConnection(dbConnString) 'connects db to project
                Dim cmmd As OleDbCommand = New OleDbCommand(LoginQRYString, dbConnection)
                dbConnection.Open()

                cmmd.Parameters.AddWithValue("@UserN", uNameLogin)
                cmmd.Parameters.AddWithValue("@HashedPWord", hashedPWord)

                Dim dbReader As OleDbDataReader = cmmd.ExecuteReader()


                lblAlert.Show()

                If frmMenu.lblUser1.Text = uNameLogin Or frmMenu.lblUser2.Text = uNameLogin Or frmMenu.lblUser3.Text = uNameLogin Or frmMenu.lblUser4.Text = uNameLogin Or frmMenu.lblUser5.Text = uNameLogin Or frmMenu.lblUser6.Text = uNameLogin Then
                    'if username is displayed on main menu it means user is logged in currently so prevents them logging in >1 times
                    lblAlert.Text = "User Already Logged in"
                    lblAlert.ForeColor = Color.Red
                Else
                    If dbReader.Read() = True Then
                        lblAlert.Text = "Login Success"
                        lblAlert.ForeColor = Color.Green
                        tbxUserName.Text = ""
                        tbxPassword.Text = ""

                        'if login successful then the current username being used to login = name to display on menu as a logged in user
                        If User1.Name = "" Then
                            User1.Name = uNameLogin
                        ElseIf User2.Name = "" Then
                            User2.Name = uNameLogin
                        ElseIf User3.Name = "" Then
                            User3.Name = uNameLogin
                        ElseIf User4.Name = "" Then
                            User4.Name = uNameLogin
                        ElseIf User5.Name = "" Then
                            User5.Name = uNameLogin
                        ElseIf User6.Name = "" Then
                            User6.Name = uNameLogin
                        End If

                        Me.Hide() 'automatically opens menu form and runs main sub, to allow logged in names to show in labels
                        frmMenu.Show()
                        frmMenu.Main()
                        lblAlert.Hide()
                    Else
                        lblAlert.Text = "Login Failed"
                        tbxPassword.Clear()
                        lblAlert.ForeColor = Color.Red
                    End If
                End If
            End Using
        End If

        lblAlert.Left = (Me.Width / 2 - lblAlert.Width / 2) 'centres warning notice
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        lblAlert.Visible = False

        'loads menu form and loads its main sub
        frmMenu.Show()
        frmMenu.Main()
        Me.Hide()
    End Sub
End Class