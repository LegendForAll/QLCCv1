Public Class FormMenu
    Private Sub btn_cay_Click(sender As Object, e As EventArgs) Handles btn_cay.Click
        Caycanh.BringToFront()
    End Sub

    Private Sub btn_lich_Click(sender As Object, e As EventArgs) Handles btn_lich.Click
        Lichchamsoc.BringToFront()
    End Sub

    Private Sub btn_tracuu_Click(sender As Object, e As EventArgs) Handles btn_tracuu.Click
        Tracuucay.BringToFront()
    End Sub

    Private Sub btn_phieumua_Click(sender As Object, e As EventArgs) Handles btn_phieumua.Click
        Vattu.BringToFront()
    End Sub

    Private Sub btn_baocao_Click(sender As Object, e As EventArgs) Handles btn_baocao.Click
        Baocao.BringToFront()
    End Sub

    Private Sub btn_quidinh_Click(sender As Object, e As EventArgs) Handles btn_quidinh.Click
        Quidinh.BringToFront()
    End Sub
End Class