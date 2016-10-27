Public Class DashboardNew

    Private Sub btndashexit_Click(sender As Object, e As EventArgs) Handles btndashexit.Click
        Environment.Exit(0)
    End Sub

    Private Sub btndashmax_Click(sender As Object, e As EventArgs) Handles btndashmax.Click
        Me.WindowState = FormWindowState.Maximized
        btndashrestore.Show()
    End Sub

    Private Sub btndashmin_Click(sender As Object, e As EventArgs) Handles btndashmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btndashrestore_Click(sender As Object, e As EventArgs) Handles btndashrestore.Click
        Me.WindowState = FormWindowState.Normal
        btndashrestore.Hide()
    End Sub

    Private Sub DashboardNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        btndashrestore.Hide()
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
    End Sub

End Class