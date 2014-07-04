Public Class Form1

    Public Bleh As Integer
    Public Vict As Integer
    Public turn As Integer
    Public mark(15) As Integer

    Private Sub Show_MSbox()
        If (Vict = 1) Then
            MessageBox.Show("Player 1 WON!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If (Vict = 2) Then
            MessageBox.Show("Player 2 WON!", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If (Vict = 4) Then
            MessageBox.Show("Dead Heat", "draw", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If MessageBox.Show("Are you sure you want to quit app", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Start_Window.Close()
            Help.Close()
            About.Close()
        End If
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Grid1.Text = ""
        Grid2.Text = ""
        Grid3.Text = ""
        Grid4.Text = ""
        grid5.Text = ""
        Grid6.Text = ""
        Grid7.Text = ""
        Grid8.Text = ""
        Grid9.Text = ""
        turn = 0
        TextBox1.Text = ""
        Vict = 0
        For i As Integer = 1 To 9
            mark(i) = 0
        Next
    End Sub

    Private Sub Victory()
        If Grid1.Text = "X" And Grid2.Text = "X" And Grid3.Text = "X" Then
            Vict = 1
        End If
        If Grid1.Text = "X" And grid5.Text = "X" And Grid9.Text = "X" Then
            Vict = 1
        End If
        If Grid1.Text = "X" And Grid4.Text = "X" And Grid7.Text = "X" Then
            Vict = 1
        End If
        If Grid3.Text = "X" And grid5.Text = "X" And Grid7.Text = "X" Then
            Vict = 1
        End If
        If Grid3.Text = "X" And Grid6.Text = "X" And Grid9.Text = "X" Then
            Vict = 1
        End If
        If Grid7.Text = "X" And Grid8.Text = "X" And Grid9.Text = "X" Then
            Vict = 1
        End If
        If Grid2.Text = "X" And grid5.Text = "X" And Grid8.Text = "X" Then
            Vict = 1
        End If
        If Grid4.Text = "X" And grid5.Text = "X" And Grid6.Text = "X" Then
            Vict = 1
        End If

        If Grid1.Text = "0" And Grid2.Text = "0" And Grid3.Text = "0" Then
            Vict = 2
        End If
        If Grid1.Text = "0" And grid5.Text = "0" And Grid9.Text = "0" Then
            Vict = 2
        End If
        If Grid1.Text = "0" And Grid4.Text = "0" And Grid7.Text = "0" Then
            Vict = 2
        End If
        If Grid3.Text = "0" And grid5.Text = "0" And Grid7.Text = "0" Then
            Vict = 2
        End If
        If Grid3.Text = "0" And Grid6.Text = "0" And Grid9.Text = "0" Then
            Vict = 2
        End If
        If Grid7.Text = "0" And Grid8.Text = "0" And Grid9.Text = "0" Then
            Vict = 2
        End If
        If Grid2.Text = "0" And grid5.Text = "0" And Grid8.Text = "0" Then
            Vict = 2
        End If
        If Grid4.Text = "0" And grid5.Text = "0" And Grid6.Text = "0" Then
            Vict = 2
        End If
        If Grid1.Text <> "" And Grid2.Text <> "" And Grid3.Text <> "" And Grid4.Text <> "" And grid5.Text <> "" And Grid6.Text <> "" And Grid7.Text <> "" And Grid8.Text <> "" And Grid9.Text <> "" And Vict = 0 Then
            TextBox1.Text = "Dead Heat"
            Vict = 4
        End If
    End Sub

    Private Sub Grid1_Click(sender As Object, e As EventArgs) Handles Grid1.Click
        If mark(1) = 1 Then
            Exit Sub
        Else
            mark(1) = 1
        End If
        turn += 1
        If turn Mod 2 = 1 Then
            PlayerTurn.Text = "Player 2"
        Else
            PlayerTurn.Text = "Player 1"
        End If
        If turn Mod 2 = 1 Then
            Grid1.Text = "X"
        Else
            Grid1.Text = "0"
        End If
        Victory()
        If Vict = 1 Then
            TextBox1.Text = "Player 1 WON!"
            Show_MSbox()
        End If
        If Vict = 2 Then
            TextBox1.Text = "Player 2 WON!"
            Show_MSbox()
        End If
        If Vict = 4 Then
            Show_MSbox()
        End If
    End Sub

    Private Sub Grid2_Click(sender As Object, e As EventArgs) Handles Grid2.Click
        If mark(2) = 1 Then
            Exit Sub
        Else
            mark(2) = 1
        End If

        turn += 1
        If turn Mod 2 = 1 Then
            PlayerTurn.Text = "Player 2"
        Else
            PlayerTurn.Text = "Player 1"
        End If
        If turn Mod 2 = 1 Then
            Grid2.Text = "X"
        Else
            Grid2.Text = "0"
        End If
        Victory()
        If Vict = 1 Then
            TextBox1.Text = "Player 1 WON!"
            Show_MSbox()
        End If
        If Vict = 2 Then
            TextBox1.Text = "Player 2 WON!"
            Show_MSbox()
        End If
        If Vict = 4 Then
            Show_MSbox()
        End If
    End Sub

    Private Sub Grid3_Click(sender As Object, e As EventArgs) Handles Grid3.Click
        If mark(3) = 1 Then
            Exit Sub
        Else
            mark(3) = 1
        End If

        turn += 1
        If turn Mod 2 = 1 Then
            PlayerTurn.Text = "Player 2"
        Else
            PlayerTurn.Text = "Player 1"
        End If
        If turn Mod 2 = 1 Then
            Grid3.Text = "X"
        Else
            Grid3.Text = "0"
        End If
        Victory()
        If Vict = 1 Then
            TextBox1.Text = "Player 1 WON!"
            Show_MSbox()
        End If
        If Vict = 2 Then
            TextBox1.Text = "Player 2 WON!"
            Show_MSbox()
        End If
        If (Vict = 4) Then
            Show_MSbox()
        End If
    End Sub

    Private Sub Grid4_Click(sender As Object, e As EventArgs) Handles Grid4.Click
        If mark(4) = 1 Then
            Exit Sub
        Else
            mark(4) = 1
        End If

        turn += 1
        If turn Mod 2 = 1 Then
            PlayerTurn.Text = "Player 2"
        Else
            PlayerTurn.Text = "Player 1"
        End If
        If turn Mod 2 = 1 Then
            Grid4.Text = "X"
        Else
            Grid4.Text = "0"
        End If
        Victory()
        If Vict = 1 Then
            TextBox1.Text = "Player 1 WON!"
            Show_MSbox()
        End If
        If Vict = 2 Then
            TextBox1.Text = "Player 2 WON!"
            Show_MSbox()
        End If
        If Vict = 4 Then
            Show_MSbox()
        End If
    End Sub

    Private Sub grid5_Click(sender As Object, e As EventArgs) Handles grid5.Click
        If mark(5) = 1 Then
            Exit Sub
        Else
            mark(5) = 1
        End If

        turn += 1
        If turn Mod 2 = 1 Then
            PlayerTurn.Text = "Player 2"
        Else
            PlayerTurn.Text = "Player 1"
        End If
        If turn Mod 2 = 1 Then
            grid5.Text = "X"
        Else
            grid5.Text = "0"
        End If
        Victory()
        If Vict = 1 Then
            TextBox1.Text = "Player 1 WON!"
            Show_MSbox()
        End If
        If Vict = 2 Then
            TextBox1.Text = "Player 2 WON!"
            Show_MSbox()
        End If
        If Vict = 4 Then
            Show_MSbox()
        End If
    End Sub

    Private Sub Grid6_Click(sender As Object, e As EventArgs) Handles Grid6.Click
        If mark(6) = 1 Then
            Exit Sub
        Else
            mark(6) = 1
        End If

        turn += 1
        If turn Mod 2 = 1 Then
            PlayerTurn.Text = "Player 2"
        Else
            PlayerTurn.Text = "Player 1"
        End If
        If turn Mod 2 = 1 Then
            Grid6.Text = "X"
        Else
            Grid6.Text = "0"
        End If
        Victory()
        If Vict = 1 Then
            TextBox1.Text = "Player 1 WON!"
            Show_MSbox()
        End If
        If Vict = 2 Then
            TextBox1.Text = "Player 2 WON!"
            Show_MSbox()
        End If
        If Vict = 4 Then
            Show_MSbox()
        End If
    End Sub

    Private Sub Grid7_Click(sender As Object, e As EventArgs) Handles Grid7.Click
        If mark(7) = 1 Then
            Exit Sub
        Else
            mark(7) = 1
        End If

        turn += 1
        If turn Mod 2 = 1 Then
            PlayerTurn.Text = "Player 2"
        Else
            PlayerTurn.Text = "Player 1"
        End If
        If turn Mod 2 = 1 Then
            Grid7.Text = "X"
        Else
            Grid7.Text = "0"
        End If
        Victory()
        If Vict = 1 Then
            TextBox1.Text = "Player 1 WON!"
            Show_MSbox()
        End If
        If Vict = 2 Then
            TextBox1.Text = "Player 2 WON!"
            Show_MSbox()
        End If
        If Vict = 4 Then
            Show_MSbox()
        End If
    End Sub

    Private Sub Grid8_Click(sender As Object, e As EventArgs) Handles Grid8.Click
        If mark(8) = 1 Then
            Exit Sub
        Else
            mark(8) = 1
        End If

        turn += 1
        If turn Mod 2 = 1 Then
            PlayerTurn.Text = "Player 2"
        Else
            PlayerTurn.Text = "Player 1"
        End If
        If turn Mod 2 = 1 Then
            Grid8.Text = "X"
        Else
            Grid8.Text = "0"
        End If
        Victory()
        If Vict = 1 Then
            TextBox1.Text = "Player 1 WON!"
            Show_MSbox()
        End If
        If Vict = 2 Then
            TextBox1.Text = "Player 2 WON!"
            Show_MSbox()
        End If
        If Vict = 4 Then
            Show_MSbox()
        End If
    End Sub

    Private Sub Grid9_Click(sender As Object, e As EventArgs) Handles Grid9.Click
        If mark(9) = 1 Then
            Exit Sub
        Else
            mark(9) = 1
        End If

        turn += 1
        If turn Mod 2 = 1 Then
            PlayerTurn.Text = "Player 2"
        Else
            PlayerTurn.Text = "Player 1"
        End If
        If turn Mod 2 = 1 Then
            Grid9.Text = "X"
        Else
            Grid9.Text = "0"
        End If
        Victory()
        If Vict = 1 Then
            TextBox1.Text = "Player 1 WON!"
            Show_MSbox()
        End If
        If Vict = 2 Then
            TextBox1.Text = "Player 2 WON!"
            Show_MSbox()
        End If
        If Vict = 4 Then
            Show_MSbox()
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Start_Window.Show()
        Me.Hide()
    End Sub
End Class
