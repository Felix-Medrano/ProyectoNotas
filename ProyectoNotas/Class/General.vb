Public Class General

    Dim x As Integer = 0
    Dim y As Integer = 0

    Sub MouseDown(e As MouseEventArgs)
        x = e.X
        y = e.Y
    End Sub

    Sub MouseMove(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            sender.Left = (sender.Left + e.X) - x
            sender.Top = (sender.Top + e.Y) - y
        End If
    End Sub

    Sub MouseMove(sender As Object, e As MouseEventArgs, minimizado As Boolean)
        If e.Button = MouseButtons.Left Then
            If minimizado Then
                sender.Top = (sender.Top + e.Y) - y
            Else
                sender.Left = (sender.Left + e.X) - x
                sender.Top = (sender.Top + e.Y) - y
            End If
        End If
    End Sub

End Class
