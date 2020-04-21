Public Class Form1

    'declare variables
    Dim Dog As Integer = 0
    Dim Cat As Integer = 0
    Dim Fish As Integer = 0
    Dim Bird As Integer = 0
    Dim Votes As String
    Dim Done As Boolean
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'test to get user votes
        'test to see if they are done voting
        Do
            'show user input box and ask to vote for favorite pet
            Votes = InputBox("Vote for your favorite pet. Vote a for Dog. Vote b for Cat. Vote c for Fish. Vote d for Bird. Press e to exit.")
            If (Votes = "a") Or (Votes = "A") Then
                Dog = Dog + 1

            ElseIf (Votes = "b") Or (Votes = "B") Then
                Cat = Cat + 1

            ElseIf (Votes = "c") Or (Votes = "C") Then
                Fish = Fish + 1

            ElseIf (Votes = "d") Or (Votes = "D") Then
                Bird = Bird + 1

            ElseIf (Votes = "e") Or (Votes = "E") Then
                Done = True
            ElseIf (Votes <> "e") Or (Votes <> "E") Or (Votes <> "a") Or (Votes <> "A") Or (Votes <> "b") Or (Votes <> "B") Or (Votes <> "c") Or (Votes <> "C") Or (Votes <> "d") Or (Votes <> "D") Then
                MessageBox.Show("Vote for your favorite pet. Vote a for Dog. Vote b for Cat. Vote c for Fish. Vote d for bird. Vote e to exit.")

            End If


            'use an if statement to capture the vote and update vote count for each pet
            If (Votes = "d") Or (Votes = "D") Then
                lstOut.Items.Add("Bird - 1")
                Bird = Bird + 1
            End If
            If (Votes = "c") Or (Votes = "C") Then
                lstOut.Items.Add("Fish - 1")
                Fish = Fish + 1
            End If
            If (Votes = "b") Or (Votes = "B") Then
                lstOut.Items.Add("Cat - 1")
                Cat = Cat + 1
            End If
            If (Votes = "a") Or (Votes = "A") Then
                lstOut.Items.Add("Dog - 1")
                Dog = Dog + 1
            End If

        Loop Until (Done = True)

        'add if statement with > and visible property and display picture of winner
        If Dog > Cat And Dog > Fish And Dog > Bird Then
            picDog.Visible = True
            picBird.Visible = False
            picCat.Visible = False
            picFish.Visible = False
        End If
        If Cat > Dog And Cat > Fish And Cat > Bird Then
            picCat.Visible = True
            picDog.Visible = False
            picFish.Visible = False
            picBird.Visible = False
        End If
        If Fish > Dog And Fish > Cat And Fish > Bird Then
            picFish.Visible = True
            picBird.Visible = False
            picCat.Visible = False
            picDog.Visible = False
        End If
        If Bird > Dog And Bird > Cat And Bird > Fish Then
            picBird.Visible = True
            picDog.Visible = False
            picFish.Visible = False
            picCat.Visible = False
        End If


        'display total votes for each pet
        lblPointsdog.Text = CStr(Dog)
        lblPointscat.Text = CStr(Cat)
        lblPointsfish.Text = CStr(Fish)
        lblPointsbird.Text = CStr(Bird)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear labels listboxes and set all pet images to visible and reset all variables to 0
        lblPointsdog.Text = 0
        lblPointscat.Text = 0
        lblPointsbird.Text = 0
        lblPointsfish.Text = 0
        picBird.Visible = True
        picCat.Visible = True
        picDog.Visible = True
        picFish.Visible = True
        lstOut.Items.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit application
        Application.Exit()
    End Sub
End Class
