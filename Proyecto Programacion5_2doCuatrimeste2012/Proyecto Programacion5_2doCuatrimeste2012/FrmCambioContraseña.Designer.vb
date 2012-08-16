<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambioContraseña
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BttnGuardar = New System.Windows.Forms.Button()
        Me.txtContraseñaActual = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNuevaContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BttnLimpiar = New System.Windows.Forms.Button()
        Me.BttnSalir = New System.Windows.Forms.Button()
        Me.txtConfirmacionContraseña = New System.Windows.Forms.TextBox()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 186)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(229, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BttnGuardar)
        Me.GroupBox1.Controls.Add(Me.txtContraseñaActual)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNuevaContraseña)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BttnLimpiar)
        Me.GroupBox1.Controls.Add(Me.BttnSalir)
        Me.GroupBox1.Controls.Add(Me.txtConfirmacionContraseña)
        Me.GroupBox1.Controls.Add(Me.lblClave)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 141)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contraseña"
        '
        'BttnGuardar
        '
        Me.BttnGuardar.Location = New System.Drawing.Point(139, 108)
        Me.BttnGuardar.Name = "BttnGuardar"
        Me.BttnGuardar.Size = New System.Drawing.Size(55, 23)
        Me.BttnGuardar.TabIndex = 5
        Me.BttnGuardar.Text = "&Guardar"
        Me.BttnGuardar.UseVisualStyleBackColor = True
        '
        'txtContraseñaActual
        '
        Me.txtContraseñaActual.Location = New System.Drawing.Point(84, 16)
        Me.txtContraseñaActual.Name = "txtContraseñaActual"
        Me.txtContraseñaActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseñaActual.Size = New System.Drawing.Size(110, 20)
        Me.txtContraseñaActual.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Actual:"
        '
        'txtNuevaContraseña
        '
        Me.txtNuevaContraseña.Location = New System.Drawing.Point(84, 42)
        Me.txtNuevaContraseña.Name = "txtNuevaContraseña"
        Me.txtNuevaContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNuevaContraseña.Size = New System.Drawing.Size(110, 20)
        Me.txtNuevaContraseña.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nueva:"
        '
        'BttnLimpiar
        '
        Me.BttnLimpiar.Location = New System.Drawing.Point(78, 108)
        Me.BttnLimpiar.Name = "BttnLimpiar"
        Me.BttnLimpiar.Size = New System.Drawing.Size(55, 23)
        Me.BttnLimpiar.TabIndex = 4
        Me.BttnLimpiar.Text = "&Limpiar"
        Me.BttnLimpiar.UseVisualStyleBackColor = True
        '
        'BttnSalir
        '
        Me.BttnSalir.Location = New System.Drawing.Point(17, 108)
        Me.BttnSalir.Name = "BttnSalir"
        Me.BttnSalir.Size = New System.Drawing.Size(55, 23)
        Me.BttnSalir.TabIndex = 3
        Me.BttnSalir.Text = "&Salir"
        Me.BttnSalir.UseVisualStyleBackColor = True
        '
        'txtConfirmacionContraseña
        '
        Me.txtConfirmacionContraseña.Location = New System.Drawing.Point(84, 68)
        Me.txtConfirmacionContraseña.Name = "txtConfirmacionContraseña"
        Me.txtConfirmacionContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmacionContraseña.Size = New System.Drawing.Size(110, 20)
        Me.txtConfirmacionContraseña.TabIndex = 2
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Location = New System.Drawing.Point(12, 75)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(71, 13)
        Me.lblClave.TabIndex = 6
        Me.lblClave.Text = "Confirmacion:"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(96, 8)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(110, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(26, 11)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario:"
        '
        'FrmCambioContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 208)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblUsuario)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCambioContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de contraseña"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BttnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtContraseñaActual As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNuevaContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BttnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BttnSalir As System.Windows.Forms.Button
    Friend WithEvents txtConfirmacionContraseña As System.Windows.Forms.TextBox
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
End Class
