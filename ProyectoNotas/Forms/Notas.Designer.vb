<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notas))
        Me.imgClip = New System.Windows.Forms.PictureBox()
        Me.Menu = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New System.Windows.Forms.PictureBox()
        Me.btnOk = New System.Windows.Forms.PictureBox()
        Me.btnEdit = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.PictureBox()
        Me.btnAbrirMenu = New System.Windows.Forms.PictureBox()
        Me.btnCerrarMenu = New System.Windows.Forms.PictureBox()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.Desc = New System.Windows.Forms.Label()
        CType(Me.imgClip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAbrirMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrarMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgClip
        '
        Me.imgClip.Image = CType(resources.GetObject("imgClip.Image"), System.Drawing.Image)
        Me.imgClip.Location = New System.Drawing.Point(0, 0)
        Me.imgClip.Name = "imgClip"
        Me.imgClip.Size = New System.Drawing.Size(25, 25)
        Me.imgClip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgClip.TabIndex = 0
        Me.imgClip.TabStop = False
        '
        'Menu
        '
        Me.Menu.Controls.Add(Me.btnEliminar)
        Me.Menu.Controls.Add(Me.btnOk)
        Me.Menu.Controls.Add(Me.btnEdit)
        Me.Menu.Controls.Add(Me.btnCancelar)
        Me.Menu.Location = New System.Drawing.Point(0, 252)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(250, 100)
        Me.Menu.TabIndex = 1
        Me.Menu.TabStop = False
        Me.Menu.Text = "Menu"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(175, 30)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(50, 50)
        Me.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.TabStop = False
        '
        'btnOk
        '
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.Location = New System.Drawing.Point(25, 30)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(50, 50)
        Me.btnOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnOk.TabIndex = 0
        Me.btnOk.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(100, 30)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(50, 50)
        Me.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(100, 30)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(50, 50)
        Me.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Visible = False
        '
        'btnAbrirMenu
        '
        Me.btnAbrirMenu.Image = CType(resources.GetObject("btnAbrirMenu.Image"), System.Drawing.Image)
        Me.btnAbrirMenu.Location = New System.Drawing.Point(225, 0)
        Me.btnAbrirMenu.Name = "btnAbrirMenu"
        Me.btnAbrirMenu.Size = New System.Drawing.Size(25, 25)
        Me.btnAbrirMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAbrirMenu.TabIndex = 5
        Me.btnAbrirMenu.TabStop = False
        '
        'btnCerrarMenu
        '
        Me.btnCerrarMenu.Image = CType(resources.GetObject("btnCerrarMenu.Image"), System.Drawing.Image)
        Me.btnCerrarMenu.Location = New System.Drawing.Point(225, 0)
        Me.btnCerrarMenu.Name = "btnCerrarMenu"
        Me.btnCerrarMenu.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrarMenu.TabIndex = 6
        Me.btnCerrarMenu.TabStop = False
        Me.btnCerrarMenu.Visible = False
        '
        'Titulo
        '
        Me.Titulo.AutoSize = True
        Me.Titulo.Location = New System.Drawing.Point(95, 5)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(41, 15)
        Me.Titulo.TabIndex = 7
        Me.Titulo.Text = "Label1"
        Me.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Desc
        '
        Me.Desc.AutoSize = True
        Me.Desc.Location = New System.Drawing.Point(0, 43)
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(41, 15)
        Me.Desc.TabIndex = 8
        Me.Desc.Text = "Label2"
        Me.Desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Notas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 350)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.btnCerrarMenu)
        Me.Controls.Add(Me.btnAbrirMenu)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.imgClip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Notas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.imgClip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAbrirMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrarMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgClip As PictureBox
    Friend WithEvents Menu As GroupBox
    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents btnOk As PictureBox
    Friend WithEvents btnEdit As PictureBox
    Friend WithEvents btnCancelar As PictureBox
    Friend WithEvents btnAbrirMenu As PictureBox
    Friend WithEvents btnCerrarMenu As PictureBox
    Friend WithEvents Titulo As Label
    Friend WithEvents Desc As Label
End Class
