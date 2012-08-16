<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDepartamento
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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCantMaxEmp = New System.Windows.Forms.TextBox()
        Me.lblCantMaxEmp = New System.Windows.Forms.Label()
        Me.BttnUltimo = New System.Windows.Forms.Button()
        Me.BttnAtras = New System.Windows.Forms.Button()
        Me.BttnSiguiente = New System.Windows.Forms.Button()
        Me.BttnPrimero = New System.Windows.Forms.Button()
        Me.BttnIncluir = New System.Windows.Forms.Button()
        Me.BttnConsultar = New System.Windows.Forms.Button()
        Me.BttnEliminar = New System.Windows.Forms.Button()
        Me.BttnModificar = New System.Windows.Forms.Button()
        Me.BttnLimpiar = New System.Windows.Forms.Button()
        Me.BttnSalir = New System.Windows.Forms.Button()
        Me.TlStrpDepartamento = New System.Windows.Forms.ToolStrip()
        Me.TlStrpBttnAgregar = New System.Windows.Forms.ToolStripButton()
        Me.TlStrpBttnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.TlStrpBttnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.TlStrpBttnModificar = New System.Windows.Forms.ToolStripButton()
        Me.TlStrpBttnLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.TlStrpBttnSalir = New System.Windows.Forms.ToolStripButton()
        Me.TlStrpDepartamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(12, 33)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(15, 49)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(63, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(88, 33)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(91, 49)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(184, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtCantMaxEmp
        '
        Me.txtCantMaxEmp.Location = New System.Drawing.Point(281, 49)
        Me.txtCantMaxEmp.Name = "txtCantMaxEmp"
        Me.txtCantMaxEmp.Size = New System.Drawing.Size(139, 20)
        Me.txtCantMaxEmp.TabIndex = 5
        '
        'lblCantMaxEmp
        '
        Me.lblCantMaxEmp.AutoSize = True
        Me.lblCantMaxEmp.Location = New System.Drawing.Point(278, 33)
        Me.lblCantMaxEmp.Name = "lblCantMaxEmp"
        Me.lblCantMaxEmp.Size = New System.Drawing.Size(142, 13)
        Me.lblCantMaxEmp.TabIndex = 4
        Me.lblCantMaxEmp.Text = "Cant. máxima de empleados:"
        '
        'BttnUltimo
        '
        Me.BttnUltimo.Location = New System.Drawing.Point(132, 85)
        Me.BttnUltimo.Name = "BttnUltimo"
        Me.BttnUltimo.Size = New System.Drawing.Size(33, 23)
        Me.BttnUltimo.TabIndex = 38
        Me.BttnUltimo.Text = ">|"
        Me.BttnUltimo.UseVisualStyleBackColor = True
        '
        'BttnAtras
        '
        Me.BttnAtras.Location = New System.Drawing.Point(54, 85)
        Me.BttnAtras.Name = "BttnAtras"
        Me.BttnAtras.Size = New System.Drawing.Size(33, 23)
        Me.BttnAtras.TabIndex = 37
        Me.BttnAtras.Text = "<"
        Me.BttnAtras.UseVisualStyleBackColor = True
        '
        'BttnSiguiente
        '
        Me.BttnSiguiente.Location = New System.Drawing.Point(93, 85)
        Me.BttnSiguiente.Name = "BttnSiguiente"
        Me.BttnSiguiente.Size = New System.Drawing.Size(33, 23)
        Me.BttnSiguiente.TabIndex = 36
        Me.BttnSiguiente.Text = ">"
        Me.BttnSiguiente.UseVisualStyleBackColor = True
        '
        'BttnPrimero
        '
        Me.BttnPrimero.Location = New System.Drawing.Point(15, 85)
        Me.BttnPrimero.Name = "BttnPrimero"
        Me.BttnPrimero.Size = New System.Drawing.Size(33, 23)
        Me.BttnPrimero.TabIndex = 35
        Me.BttnPrimero.Text = "|<"
        Me.BttnPrimero.UseVisualStyleBackColor = True
        '
        'BttnIncluir
        '
        Me.BttnIncluir.Location = New System.Drawing.Point(15, 130)
        Me.BttnIncluir.Name = "BttnIncluir"
        Me.BttnIncluir.Size = New System.Drawing.Size(50, 23)
        Me.BttnIncluir.TabIndex = 34
        Me.BttnIncluir.Text = "&Incluir"
        Me.BttnIncluir.UseVisualStyleBackColor = True
        '
        'BttnConsultar
        '
        Me.BttnConsultar.Location = New System.Drawing.Point(71, 130)
        Me.BttnConsultar.Name = "BttnConsultar"
        Me.BttnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BttnConsultar.TabIndex = 33
        Me.BttnConsultar.Text = "&Consultar"
        Me.BttnConsultar.UseVisualStyleBackColor = True
        '
        'BttnEliminar
        '
        Me.BttnEliminar.Location = New System.Drawing.Point(152, 130)
        Me.BttnEliminar.Name = "BttnEliminar"
        Me.BttnEliminar.Size = New System.Drawing.Size(60, 23)
        Me.BttnEliminar.TabIndex = 32
        Me.BttnEliminar.Text = "&Eliminar"
        Me.BttnEliminar.UseVisualStyleBackColor = True
        '
        'BttnModificar
        '
        Me.BttnModificar.Location = New System.Drawing.Point(218, 130)
        Me.BttnModificar.Name = "BttnModificar"
        Me.BttnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BttnModificar.TabIndex = 31
        Me.BttnModificar.Text = "&Modificar"
        Me.BttnModificar.UseVisualStyleBackColor = True
        '
        'BttnLimpiar
        '
        Me.BttnLimpiar.Location = New System.Drawing.Point(299, 130)
        Me.BttnLimpiar.Name = "BttnLimpiar"
        Me.BttnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BttnLimpiar.TabIndex = 30
        Me.BttnLimpiar.Text = "&Limpiar"
        Me.BttnLimpiar.UseVisualStyleBackColor = True
        '
        'BttnSalir
        '
        Me.BttnSalir.Location = New System.Drawing.Point(380, 130)
        Me.BttnSalir.Name = "BttnSalir"
        Me.BttnSalir.Size = New System.Drawing.Size(50, 23)
        Me.BttnSalir.TabIndex = 29
        Me.BttnSalir.Text = "&Salir"
        Me.BttnSalir.UseVisualStyleBackColor = True
        '
        'TlStrpDepartamento
        '
        Me.TlStrpDepartamento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlStrpBttnAgregar, Me.TlStrpBttnConsultar, Me.TlStrpBttnEliminar, Me.TlStrpBttnModificar, Me.TlStrpBttnLimpiar, Me.TlStrpBttnSalir})
        Me.TlStrpDepartamento.Location = New System.Drawing.Point(0, 0)
        Me.TlStrpDepartamento.Name = "TlStrpDepartamento"
        Me.TlStrpDepartamento.Size = New System.Drawing.Size(435, 25)
        Me.TlStrpDepartamento.TabIndex = 39
        Me.TlStrpDepartamento.Text = "ToolStrip1"
        '
        'TlStrpBttnAgregar
        '
        Me.TlStrpBttnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TlStrpBttnAgregar.Image = Global.Proyecto_Programacion5_2doCuatrimeste2012.My.Resources.Resources.Add
        Me.TlStrpBttnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlStrpBttnAgregar.Name = "TlStrpBttnAgregar"
        Me.TlStrpBttnAgregar.Size = New System.Drawing.Size(23, 22)
        '
        'TlStrpBttnConsultar
        '
        Me.TlStrpBttnConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TlStrpBttnConsultar.Image = Global.Proyecto_Programacion5_2doCuatrimeste2012.My.Resources.Resources.query
        Me.TlStrpBttnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlStrpBttnConsultar.Name = "TlStrpBttnConsultar"
        Me.TlStrpBttnConsultar.Size = New System.Drawing.Size(23, 22)
        '
        'TlStrpBttnEliminar
        '
        Me.TlStrpBttnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TlStrpBttnEliminar.Image = Global.Proyecto_Programacion5_2doCuatrimeste2012.My.Resources.Resources.Delete
        Me.TlStrpBttnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlStrpBttnEliminar.Name = "TlStrpBttnEliminar"
        Me.TlStrpBttnEliminar.Size = New System.Drawing.Size(23, 22)
        '
        'TlStrpBttnModificar
        '
        Me.TlStrpBttnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TlStrpBttnModificar.Image = Global.Proyecto_Programacion5_2doCuatrimeste2012.My.Resources.Resources.Edit
        Me.TlStrpBttnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlStrpBttnModificar.Name = "TlStrpBttnModificar"
        Me.TlStrpBttnModificar.Size = New System.Drawing.Size(23, 22)
        '
        'TlStrpBttnLimpiar
        '
        Me.TlStrpBttnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TlStrpBttnLimpiar.Image = Global.Proyecto_Programacion5_2doCuatrimeste2012.My.Resources.Resources.Clear
        Me.TlStrpBttnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlStrpBttnLimpiar.Name = "TlStrpBttnLimpiar"
        Me.TlStrpBttnLimpiar.Size = New System.Drawing.Size(23, 22)
        '
        'TlStrpBttnSalir
        '
        Me.TlStrpBttnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TlStrpBttnSalir.Image = Global.Proyecto_Programacion5_2doCuatrimeste2012.My.Resources.Resources.Log_Out
        Me.TlStrpBttnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlStrpBttnSalir.Name = "TlStrpBttnSalir"
        Me.TlStrpBttnSalir.Size = New System.Drawing.Size(23, 22)
        '
        'FrmDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 165)
        Me.Controls.Add(Me.TlStrpDepartamento)
        Me.Controls.Add(Me.BttnUltimo)
        Me.Controls.Add(Me.BttnAtras)
        Me.Controls.Add(Me.BttnSiguiente)
        Me.Controls.Add(Me.BttnPrimero)
        Me.Controls.Add(Me.BttnIncluir)
        Me.Controls.Add(Me.BttnConsultar)
        Me.Controls.Add(Me.BttnEliminar)
        Me.Controls.Add(Me.BttnModificar)
        Me.Controls.Add(Me.BttnLimpiar)
        Me.Controls.Add(Me.BttnSalir)
        Me.Controls.Add(Me.txtCantMaxEmp)
        Me.Controls.Add(Me.lblCantMaxEmp)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDepartamento"
        Me.Text = "Departamento"
        Me.TlStrpDepartamento.ResumeLayout(False)
        Me.TlStrpDepartamento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCantMaxEmp As System.Windows.Forms.TextBox
    Friend WithEvents lblCantMaxEmp As System.Windows.Forms.Label
    Friend WithEvents BttnUltimo As System.Windows.Forms.Button
    Friend WithEvents BttnAtras As System.Windows.Forms.Button
    Friend WithEvents BttnSiguiente As System.Windows.Forms.Button
    Friend WithEvents BttnPrimero As System.Windows.Forms.Button
    Friend WithEvents BttnIncluir As System.Windows.Forms.Button
    Friend WithEvents BttnConsultar As System.Windows.Forms.Button
    Friend WithEvents BttnEliminar As System.Windows.Forms.Button
    Friend WithEvents BttnModificar As System.Windows.Forms.Button
    Friend WithEvents BttnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BttnSalir As System.Windows.Forms.Button
    Friend WithEvents TlStrpDepartamento As System.Windows.Forms.ToolStrip
    Friend WithEvents TlStrpBttnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlStrpBttnConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlStrpBttnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlStrpBttnModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlStrpBttnLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TlStrpBttnSalir As System.Windows.Forms.ToolStripButton
End Class
