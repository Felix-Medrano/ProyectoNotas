Public Class Notas

    Dim General As New General
    Dim ultimaX As Integer = 0
    Dim notasMinimizado As Boolean = False



    Sub _CerrarMenu()
        btnCerrarMenu.Visible = False
        btnAbrirMenu.Visible = True
        Menu.Visible = False
        If notasMinimizado Then
            Me.Height = 25
        Else
            Me.Height = 250
        End If

    End Sub

    Sub _AbrirMenu()
        btnAbrirMenu.Visible = False
        btnCerrarMenu.Visible = True
        Menu.Visible = True
        Me.Height = 350
    End Sub




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
            _CerrarMenu()
            btnAbrirMenu.Visible = False
        Else
            Me.Size = New Point(250, 250)
            Me.Left = ultimaX
            btnAbrirMenu.Visible = True
        End If
    End Sub

    Private Sub imgClip_MouseHover(sender As Object, e As EventArgs) Handles imgClip.MouseHover
        Me.Width = 250
    End Sub

    Private Sub imgClip_MouseLeave(sender As Object, e As EventArgs) Handles imgClip.MouseLeave
        If notasMinimizado Then
            Me.Width = 25
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        MsgBox("ok")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEdit.Visible = False
        btnCancelar.Visible = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnEdit.Visible = True
        btnCancelar.Visible = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        MsgBox("eliminar")
    End Sub

    Private Sub btnCerrarMenu_Click(sender As Object, e As EventArgs) Handles btnCerrarMenu.Click
        _CerrarMenu()
    End Sub

    Private Sub btnAbrirMenu_Click(sender As Object, e As EventArgs) Handles btnAbrirMenu.Click
        _AbrirMenu()
    End Sub

    Private Sub Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 250
        Menu.Visible = False
    End Sub
End Class
