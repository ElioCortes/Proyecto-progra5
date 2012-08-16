<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoUsuario
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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BttnAceptar
        '
        Me.BttnAceptar.Location = New System.Drawing.Point(100, 64)
        Me.BttnAceptar.Name = "BttnAceptar"
        Me.BttnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BttnAceptar.TabIndex = 17
        Me.BttnAceptar.Text = "&Aceptar"
        Me.BttnAceptar.UseVisualStyleBackColor = True
        '
        'BttnSalir
        '
        Me.BttnSalir.Location = New System.Drawing.Point(12, 64)
        Me.BttnSalir.Name = "BttnSalir"
        Me.BttnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BttnSalir.TabIndex = 16
        Me.BttnSalir.Text = "&Salir"
        Me.BttnSalir.UseVisualStyleBackColor = True
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(59, 38)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(116, 20)
        Me.txtClave.TabIndex = 15
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Location = New System.Drawing.Point(7, 41)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(37, 13)
        Me.lblClave.TabIndex = 14
        Me.lblClave.Text = "Clave:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(59, 12)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(116, 20)
        Me.txtUsuario.TabIndex = 13
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(7, 15)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 12
        Me.lblUsuario.Text = "Usuario:"
        '
        'FrmNuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(189, 102)
        Me.Controls.Add(Me.BttnAceptar)
        Me.Controls.Add(Me.BttnSalir)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.lblClave)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblUsuario)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNuevoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BttnAceptar As System.Windows.Forms.Button
    Friend WithEvents BttnSalir As System.Windows.Forms.Button
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
End Class
