<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadesDeMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EiminarCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.TablasToolStripMenuItem, Me.SeguridadToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(569, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatosToolStripMenuItem
        '
        Me.DatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosToolStripMenuItem})
        Me.DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        Me.DatosToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.DatosToolStripMenuItem.Text = "&Datos"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ArticulosToolStripMenuItem.Text = "&Artículos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "&Reportes"
        '
        'TablasToolStripMenuItem
        '
        Me.TablasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnidadesDeMedidaToolStripMenuItem})
        Me.TablasToolStripMenuItem.Name = "TablasToolStripMenuItem"
        Me.TablasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.TablasToolStripMenuItem.Text = "&Tablas"
        '
        'UnidadesDeMedidaToolStripMenuItem
        '
        Me.UnidadesDeMedidaToolStripMenuItem.Name = "UnidadesDeMedidaToolStripMenuItem"
        Me.UnidadesDeMedidaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.UnidadesDeMedidaToolStripMenuItem.Text = "&Unidades de Medida"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem1})
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SeguridadToolStripMenuItem.Text = "&Seguridad"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "&Herramientas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'UsuarioToolStripMenuItem1
        '
        Me.UsuarioToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarCuentaToolStripMenuItem, Me.EiminarCuentaToolStripMenuItem})
        Me.UsuarioToolStripMenuItem1.Name = "UsuarioToolStripMenuItem1"
        Me.UsuarioToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.UsuarioToolStripMenuItem1.Text = "&Usuario"
        '
        'ModificarCuentaToolStripMenuItem
        '
        Me.ModificarCuentaToolStripMenuItem.Name = "ModificarCuentaToolStripMenuItem"
        Me.ModificarCuentaToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ModificarCuentaToolStripMenuItem.Text = "&Modificar cuenta"
        '
        'EiminarCuentaToolStripMenuItem
        '
        Me.EiminarCuentaToolStripMenuItem.Name = "EiminarCuentaToolStripMenuItem"
        Me.EiminarCuentaToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EiminarCuentaToolStripMenuItem.Text = "&Eiminar cuenta"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 269)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENERTROL S.A."
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnidadesDeMedidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EiminarCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
