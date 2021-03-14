Public Class Notas

    Dim General As New General
    Dim ultimaX As Integer = 0
    Dim notasMinimizado As Boolean = False

    Private Sub Notas_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        General.MouseDown(e)
    End Sub

    Private Sub Notas_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        General.MouseMove(sender, e)
    End Sub

    Private Sub imgClip_MouseDown(sender As Object, e As MouseEventArgs) Handles imgClip.MouseDown
        General.MouseDown(e)
    End Sub

    Private Sub imgClip_MouseMove(sender As Object, e As MouseEventArgs) Handles imgClip.MouseMove
        If notasMinimizado Then
            General.MouseMove(Me, e, notasMinimizado)
        Else
            General.MouseMove(Me, e)
        End If
    End Sub

    Private Sub imgClip_DoubleClick(sender As Object, e As EventArgs) Handles imgClip.DoubleClick
        notasMinimizado = Not notasMinimizado
        If notasMinimizado Then
            ultimaX = Me.Left
            Me.Size = imgClip.Size
            Me.Left = 0
        Else
            Me.Size = New Point(250, 250)
            Me.Left = ultimaX
        End If
    End Sub
End Class
