Public Class Form1

    Private Sub ProblemBintangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProblemBintangToolStripMenuItem.Click
        Problembintang.MdiParent = Me
        Problembintang.Show()
    End Sub

    Private Sub MatriksKalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriksKalkulatorToolStripMenuItem.Click
        CalMatrix.MdiParent = Me
        CalMatrix.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Environment.Exit(0)
    End Sub
End Class
