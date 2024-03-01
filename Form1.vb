Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles mom_btn.Click
        mom_pnl.Visible = True
        dad_pnl.Visible = False
        patya_pnl.Visible = False
        raj_pnl.Visible = False
        geetika_pnl.Visible = False
        tan_pnl.Visible = False
        divija_pnl.Visible = False
        yash_pnl.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles dad_btn.Click
        mom_pnl.Visible = False
        dad_pnl.Visible = True
        patya_pnl.Visible = False
        raj_pnl.Visible = False
        geetika_pnl.Visible = False
        tan_pnl.Visible = False
        divija_pnl.Visible = False
        yash_pnl.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles patya_btn.Click
        mom_pnl.Visible = False
        dad_pnl.Visible = False
        patya_pnl.Visible = True
        raj_pnl.Visible = False
        geetika_pnl.Visible = False
        tan_pnl.Visible = False
        divija_pnl.Visible = False
        yash_pnl.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles raj_btn.Click
        mom_pnl.Visible = False
        dad_pnl.Visible = False
        patya_pnl.Visible = False
        raj_pnl.Visible = True
        geetika_pnl.Visible = False
        tan_pnl.Visible = False
        divija_pnl.Visible = False
        yash_pnl.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles geetika_btn.Click
        mom_pnl.Visible = False
        dad_pnl.Visible = False
        patya_pnl.Visible = False
        raj_pnl.Visible = False
        geetika_pnl.Visible = True
        tan_pnl.Visible = False
        divija_pnl.Visible = False
        yash_pnl.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles tan_btn.Click
        mom_pnl.Visible = False
        dad_pnl.Visible = False
        patya_pnl.Visible = False
        raj_pnl.Visible = False
        geetika_pnl.Visible = False
        tan_pnl.Visible = True
        divija_pnl.Visible = False
        yash_pnl.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles divija_btn.Click
        mom_pnl.Visible = False
        dad_pnl.Visible = False
        patya_pnl.Visible = False
        raj_pnl.Visible = False
        geetika_pnl.Visible = False
        tan_pnl.Visible = False
        divija_pnl.Visible = True
        yash_pnl.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles yash_btn.Click
        mom_pnl.Visible = False
        dad_pnl.Visible = False
        patya_pnl.Visible = False
        raj_pnl.Visible = False
        geetika_pnl.Visible = False
        tan_pnl.Visible = False
        divija_pnl.Visible = False
        yash_pnl.Visible = True
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub min_btn_Click(sender As Object, e As EventArgs) Handles min_btn.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub max_btn_Click(sender As Object, e As EventArgs) Handles max_btn.Click
        If Me.WindowState = WindowState.Normal Then
            Call CenterToScreen()
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = Me.WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub
End Class
