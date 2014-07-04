Public Class Help

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Start_Window.Show()
    End Sub

    Private Sub Helpexit_Click(sender As Object, e As EventArgs) Handles Helpexit.Click
        If MessageBox.Show("Are you sure you want to quit app", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Form1.Close()
            About.Close()
            Start_Window.Close()
        End If
    End Sub
End Class