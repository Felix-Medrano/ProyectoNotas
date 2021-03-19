Public Class Formulario
    Private Sub Formulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Formulario_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Hide()
    End Sub

    Private Sub Nueva_Click(sender As Object, e As EventArgs) Handles Nueva.Click
        Me.Show()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub Formulario_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
        End If
    End Sub

    Private Sub icoNotas_DoubleClick(sender As Object, e As EventArgs) Handles icoNotas.DoubleClick
        Me.Show()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Titulo.Text = ""
        Desc.Text = ""
        Me.Hide()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim frmNota As New Notas
        frmNota.Titulo.Text = Titulo.Text
        frmNota.Desc.Text = Desc.Text
        Titulo.Text = ""
        Titulo.Focus()
        Desc.Text = ""
        frmNota.Show()
        Me.Hide()

    End Sub
End Class