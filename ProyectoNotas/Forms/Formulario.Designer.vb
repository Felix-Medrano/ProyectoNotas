<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario))
        Me.icoNotas = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.contMenuNotas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Nueva = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Titulo = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.PictureBox()
        Me.Desc = New System.Windows.Forms.RichTextBox()
        Me.contMenuNotas.SuspendLayout()
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'icoNotas
        '
        Me.icoNotas.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.icoNotas.BalloonTipText = "Crea Notas Flotantes"
        Me.icoNotas.BalloonTipTitle = "Notas Flotantes"
        Me.icoNotas.ContextMenuStrip = Me.contMenuNotas
        Me.icoNotas.Icon = CType(resources.GetObject("icoNotas.Icon"), System.Drawing.Icon)
        Me.icoNotas.Text = "Notas Flotantes"
        Me.icoNotas.Visible = True
        '
        'contMenuNotas
        '
        Me.contMenuNotas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nueva, Me.ToolStripSeparator1, Me.Salir})
        Me.contMenuNotas.Name = "contMenuNotas"
        Me.contMenuNotas.Size = New System.Drawing.Size(138, 54)
        '
        'Nueva
        '
        Me.Nueva.Name = "Nueva"
        Me.Nueva.Size = New System.Drawing.Size(137, 22)
        Me.Nueva.Text = "Nueva Nota"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(134, 6)
        '
        'Salir
        '
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(137, 22)
        Me.Salir.Text = "Salir"
        '
        'Titulo
        '
        Me.Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Titulo.Location = New System.Drawing.Point(12, 12)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.PlaceholderText = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(226, 23)
        Me.Titulo.TabIndex = 1
        Me.Titulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnOk
        '
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.Location = New System.Drawing.Point(50, 288)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(50, 50)
        Me.btnOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnOk.TabIndex = 3
        Me.btnOk.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(150, 288)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(50, 50)
        Me.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.TabStop = False
        '
        'Desc
        '
        Me.Desc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Desc.Location = New System.Drawing.Point(12, 41)
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(226, 241)
        Me.Desc.TabIndex = 5
        Me.Desc.Text = ""
        '
        'Formulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(250, 350)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formulario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario"
        Me.contMenuNotas.ResumeLayout(False)
        CType(Me.btnOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents icoNotas As NotifyIcon
    Friend WithEvents contMenuNotas As ContextMenuStrip
    Friend WithEvents Nueva As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Salir As ToolStripMenuItem
    Friend WithEvents Titulo As TextBox
    Friend WithEvents btnOk As PictureBox
    Friend WithEvents btnCancelar As PictureBox
    Friend WithEvents Desc As RichTextBox
End Class
