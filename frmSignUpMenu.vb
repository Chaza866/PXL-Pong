Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text

Public Class frmSignUpMenu
    Private Sub frmSignUpMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblAlert.Hide() 'hides warning label 

        Me.Height = 720
        Me.Width = 1280

        'centre the form on the screen
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

    End Sub

    Shared Function GetHash(inputPWord As String) As String 'hashed inputed password

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



    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        lblAlert.ForeColor = Color.Red ' default warning label colour

#Region "Variables"
        Dim uNameSignUp As String
        Dim pWordSignUp As String
        Dim pwordSignUpCfrm As String
        Dim dateOfCreation As Date = Today
        Dim hashedPWord As String
#End Region

        uNameSignUp = tbxUserName.Text
        pWordSignUp = tbxPassword.Text
        pwordSignUpCfrm = tbxPasswordCfrm.Text

        hashedPWord = GetHash(pWordSignUp) 'hashedpword takes hash from hashing funtion


        If tbxUserName.Text = "" Or tbxPassword.Text = "" Or tbxPasswordCfrm.Text = "" Then
            lblAlert.Show()
            lblAlert.Text = "Please fill all empty boxes"

        ElseIf tbxPassword.Text <> tbxPasswordCfrm.Text Then
            lblAlert.Show()
            lblAlert.Text = "Passwords do not match"

        Else
            Dim dbConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=UserData.accdb"
            Dim UserCheckQRY As String = "SELECT tblUserData.UserName, tblUserData.HashedPassword, tblUserData.DateOfCreation
            FROM tblUserData
            WHERE (((tblUserData.UserName) = @UName)) ;"

            Using dbConnection As New OleDbConnection(dbConnString) 'connects db to project

                Dim cmmd As OleDbCommand = New OleDbCommand(UserCheckQRY, dbConnection)
                dbConnection.Open()

                cmmd.Parameters.AddWithValue("@UName", uNameSignUp)
                Dim dbReader As OleDbDataReader = cmmd.ExecuteReader()


                lblAlert.Show()
                If dbReader.HasRows Then
                    lblAlert.Text = "User Already Exists"
                    tbxUserName.Text = ""
                    tbxPassword.Text = ""
                    tbxPasswordCfrm.Text = ""
                    dbConnection.Close()
                Else

                    Try
                        Dim SignupQRY As String = "INSERT INTO [tblUserData] ([UserName],[HashedPassword],[DateOfCreation]) VALUES (@uNameSignUp,@hashedPWord,@date)"
                        Dim query As New OleDbCommand(SignupQRY, dbConnection)

                        query.Parameters.AddWithValue("@uNameSignUp", uNameSignUp)
                        query.Parameters.AddWithValue("@hashedPWord", hashedPWord)
                        query.Parameters.AddWithValue("@date", dateOfCreation.ToShortDateString())

                        query.ExecuteNonQuery()
                        dbConnection.Close()

                        lblAlert.Text = "Signup Successful"
                        lblAlert.ForeColor = Color.Green
                        tbxUserName.Text = ""
                        tbxPassword.Text = ""
                        tbxPasswordCfrm.Text = ""

                    Catch ex As Exception
                        lblAlert.Text = "Signup Failed"
                    End Try
                End If
            End Using

        End If
        lblAlert.Left = (Me.Width / 2 - lblAlert.Width / 2) 'centres warning notice
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'loads menu form and loads its main sub
        frmMenu.Show()
        frmMenu.Main()
        Me.Hide()
    End Sub


End Class