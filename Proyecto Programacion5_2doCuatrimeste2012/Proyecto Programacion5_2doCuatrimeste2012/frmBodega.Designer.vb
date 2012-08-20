<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBodega
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBodega))
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.bNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bnAdd = New System.Windows.Forms.ToolStripButton()
        Me.bnDelete = New System.Windows.Forms.ToolStripButton()
        Me.bnFirst = New System.Windows.Forms.ToolStripButton()
        Me.bnPrev = New System.Windows.Forms.ToolStripButton()
        Me.bnNext = New System.Windows.Forms.ToolStripButton()
        Me.bnLast = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.bnConsulta = New System.Windows.Forms.ToolStripButton()
        Me.bnReporte = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bnClear = New System.Windows.Forms.ToolStripButton()
        Me.bnSave = New System.Windows.Forms.ToolStripButton()
        Me.bnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.bnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.bNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(12, 53)
        Me.txtCodigo.MaxLength = 3
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(80, 20)
        Me.txtCodigo.TabIndex = 48
        '
        'bNavigator
        '
        Me.bNavigator.AddNewItem = Me.bnAdd
        Me.bNavigator.CountItem = Nothing
        Me.bNavigator.DeleteItem = Me.bnDelete
        Me.bNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bnFirst, Me.bnPrev, Me.bnNext, Me.bnLast, Me.BindingNavigatorSeparator5, Me.bnConsulta, Me.bnReporte, Me.ToolStripSeparator1, Me.bnClear, Me.bnAdd, Me.bnDelete, Me.bnSave, Me.bnRefresh, Me.bnExit})
        Me.bNavigator.Location = New System.Drawing.Point(0, 0)
        Me.bNavigator.MoveFirstItem = Me.bnFirst
        Me.bNavigator.MoveLastItem = Me.bnLast
        Me.bNavigator.MoveNextItem = Me.bnNext
        Me.bNavigator.MovePreviousItem = Me.bnPrev
        Me.bNavigator.Name = "bNavigator"
        Me.bNavigator.PositionItem = Nothing
        Me.bNavigator.Size = New System.Drawing.Size(352, 25)
        Me.bNavigator.TabIndex = 52
        Me.bNavigator.Text = "BindingNavigator2"
        '
        'bnAdd
        '
        Me.bnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnAdd.Image = CType(resources.GetObject("bnAdd.Image"), System.Drawing.Image)
        Me.bnAdd.Name = "bnAdd"
        Me.bnAdd.RightToLeftAutoMirrorImage = True
        Me.bnAdd.Size = New System.Drawing.Size(23, 22)
        Me.bnAdd.Text = "Insertar"
        '
        'bnDelete
        '
        Me.bnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnDelete.Image = CType(resources.GetObject("bnDelete.Image"), System.Drawing.Image)
        Me.bnDelete.Name = "bnDelete"
        Me.bnDelete.RightToLeftAutoMirrorImage = True
        Me.bnDelete.Size = New System.Drawing.Size(23, 22)
        Me.bnDelete.Text = "Eliminar"
        '
        'bnFirst
        '
        Me.bnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnFirst.Image = CType(resources.GetObject("bnFirst.Image"), System.Drawing.Image)
        Me.bnFirst.Name = "bnFirst"
        Me.bnFirst.RightToLeftAutoMirrorImage = True
        Me.bnFirst.Size = New System.Drawing.Size(23, 22)
        Me.bnFirst.Text = "Primero"
        '
        'bnPrev
        '
        Me.bnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnPrev.Image = CType(resources.GetObject("bnPrev.Image"), System.Drawing.Image)
        Me.bnPrev.Name = "bnPrev"
        Me.bnPrev.RightToLeftAutoMirrorImage = True
        Me.bnPrev.Size = New System.Drawing.Size(23, 22)
        Me.bnPrev.Text = "Anterior"
        '
        'bnNext
        '
        Me.bnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnNext.Image = CType(resources.GetObject("bnNext.Image"), System.Drawing.Image)
        Me.bnNext.Name = "bnNext"
        Me.bnNext.RightToLeftAutoMirrorImage = True
        Me.bnNext.Size = New System.Drawing.Size(23, 22)
        Me.bnNext.Text = "Siguiente"
        '
        'bnLast
        '
        Me.bnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnLast.Image = CType(resources.GetObject("bnLast.Image"), System.Drawing.Image)
        Me.bnLast.Name = "bnLast"
        Me.bnLast.RightToLeftAutoMirrorImage = True
        Me.bnLast.Size = New System.Drawing.Size(23, 22)
        Me.bnLast.Text = "Ultimo"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'bnConsulta
        '
        Me.bnConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnConsulta.Image = Global.Proyecto_Programacion5_2doCuatrimeste2012.My.Resources.Resources.search
        Me.bnConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnConsulta.Name = "bnConsulta"
        Me.bnConsulta.Size = New System.Drawing.Size(23, 22)
        Me.bnConsulta.Text = "ToolStripButton1"
        '
        'bnReporte
        '
        Me.bnReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnReporte.Image = Global.Proyecto_Programacion5_2doCuatrimeste2012.My.Resources.Resources.document_print_preview_3
        Me.bnReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnReporte.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.bnReporte.Name = "bnReporte"
        Me.bnReporte.Size = New System.Drawing.Size(23, 23)
        Me.bnReporte.Text = "Reporte"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'bnClear
        '
        Me.bnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnClear.Image = Global.Proyecto_Programacion5_2doCuatrimeste2012.My.Resources.Resources.Clear
        Me.bnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnClear.Name = "bnClear"
        Me.bnClear.Size = New System.Drawing.Size(23, 22)
        Me.bnClear.Text = "Limpiar"
        '
        'bnSave
        '
        Me.bnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnSave.Image = Global.Proyecto_Programacion5_2doCuatrimeste2012.My.Resources.Resources.icon_save1
        Me.bnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnSave.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.bnSave.Name = "bnSave"
        Me.bnSave.Size = New System.Drawing.Size(23, 23)
        Me.bnSave.Text = "Guardar"
        '
        'bnRefresh
        '
        Me.bnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnRefresh.Image = CType(resources.GetObject("bnRefresh.Image"), System.Drawing.Image)
        Me.bnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnRefresh.Name = "bnRefresh"
        Me.bnRefresh.Size = New System.Drawing.Size(23, 22)
        Me.bnRefresh.Text = "Refrescar"
        '
        'bnExit
        '
        Me.bnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnExit.Image = Global.Proyecto_Programacion5_2doCuatrimeste2012.My.Resources.Resources.Log_Out
        Me.bnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnExit.Name = "bnExit"
        Me.bnExit.Size = New System.Drawing.Size(23, 22)
        Me.bnExit.Text = "Salir"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(115, 53)
        Me.txtDesc.MaxLength = 30
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(220, 20)
        Me.txtDesc.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Código:"
        '
        'frmBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 121)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.bNavigator)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBodega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bodegas"
        CType(Me.bNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bNavigator.ResumeLayout(False)
        Me.bNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents bNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents bnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnPrev As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bnConsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
