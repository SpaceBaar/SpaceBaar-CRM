Public Class DashboardNew
    Private Sub btndashexit_Click(sender As Object, e As EventArgs) Handles btndashexit.Click
        Me.Close()
    End Sub

    Private Sub btndashmax_Click(sender As Object, e As EventArgs) Handles btndashmax.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub byndashmin_Click(sender As Object, e As EventArgs) Handles byndashmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btndashrestore_Click(sender As Object, e As EventArgs) Handles btndashrestore.Click
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class