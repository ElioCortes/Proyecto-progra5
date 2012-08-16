<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngreso
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
        Me.BttnAceptar = New System.Windows.Forms.Button()
        Me.BttnSalir = New System.Windows.Forms.Button()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BttnAceptar
        '
        Me.BttnAceptar.Location = New System.Drawing.Point(130, 79)
        Me.BttnAceptar.Name = "BttnAceptar"
        Me.BttnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BttnAceptar.TabIndex = 12
        Me.BttnAceptar.Text = "&Aceptar"
        Me.BttnAceptar.UseVisualStyleBackColor = True
        '
        'BttnSalir
        '
        Me.BttnSalir.Location = New System.Drawing.Point(11, 79)
        Me.BttnSalir.Name = "BttnSalir"
        Me.BttnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BttnSalir.TabIndex = 11
        Me.BttnSalir.Text = "&Salir"
        Me.BttnSalir.UseVisualStyleBackColor = True
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(60, 53)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(145, 20)
        Me.txtClave.TabIndex = 10
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Location = New System.Drawing.Point(8, 56)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(37, 13)
        Me.lblClave.TabIndex = 9
        Me.lblClave.Text = "Clave:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(60, 27)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(145, 20)
        Me.txtUsuario.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(217, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoUsuarioToolStripMenuItem
        '
        Me.NuevoUsuarioToolStripMenuItem.Name = "NuevoUsuarioToolStripMenuItem"
        Me.NuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.NuevoUsuarioToolStripMenuItem.Text = "&Nuevo usuario"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(8, 30)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 7
        Me.lblUsuario.Text = "Usuario:"
        '
        'FrmIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 111)
        Me.Controls.Add(Me.BttnAceptar)
        Me.Controls.Add(Me.BttnSalir)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.lblClave)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblUsuario)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmIngreso"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BttnAceptar As System.Windows.Forms.Button
    Friend WithEvents BttnSalir As System.Windows.Forms.Button
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NuevoUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
End Class
