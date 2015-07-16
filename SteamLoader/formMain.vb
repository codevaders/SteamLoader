Public Class formMain
    Private Sub formMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        outStatus.Text = "Loading..."
        trayMain.Visible = True
        outStatus.Text = "Loaded"
        Hide()
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        trayMain.Visible = False
        End
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        trayMain.Visible = False
        End
    End Sub

    Private Sub trayMain_MouseClick(sender As Object, e As MouseEventArgs) Handles trayMain.MouseClick
        Select Case e.Button
            Case MouseButtons.Right
                menuQuit.Show(Cursor.Position)
        End Select
    End Sub

    Private Sub trayMain_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles trayMain.MouseDoubleClick
        Select Case e.Button
            Case MouseButtons.Left
                Show()
        End Select
    End Sub
End Class
