<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArticulo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodArt = New System.Windows.Forms.TextBox()
        Me.txtDescArt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpUltEnt = New System.Windows.Forms.DateTimePicker()
        Me.dtpUltSalida = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bnAdd = New System.Windows.Forms.ToolStripButton()
        Me.bnDelete = New System.Windows.Forms.ToolStripButton()
        Me.bnFirst = New System.Windows.Forms.ToolStripButton()
        Me.bnPrev = New System.Windows.Forms.ToolStripButton()
        Me.bnNext = New System.Windows.Forms.ToolStripButton()
        Me.bnLast = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.bnClear = New System.Windows.Forms.ToolStripButton()
        Me.bnSave = New System.Windows.Forms.ToolStripButton()
        Me.bnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.bnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDescUM = New System.Windows.Forms.TextBox()
        Me.txtCodUM = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCostPromAnt = New System.Windows.Forms.TextBox()
        Me.txtCostPromAct = New System.Windows.Forms.TextBox()
        Me.txtCostUltEntAct = New System.Windows.Forms.TextBox()
        Me.txtCostUltEntAnt = New System.Windows.Forms.TextBox()
        Me.txtIV = New System.Windows.Forms.TextBox()
        CType(Me.bNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'txtCodArt
        '
        Me.txtCodArt.Location = New System.Drawing.Point(15, 55)
        Me.txtCodArt.Name = "txtCodArt"
        Me.txtCodArt.Size = New System.Drawing.Size(100, 20)
        Me.txtCodArt.TabIndex = 1
        '
        'txtDescArt
        '
        Me.txtDescArt.Location = New System.Drawing.Point(121, 55)
        Me.txtDescArt.Name = "txtDescArt"
        Me.txtDescArt.Size = New System.Drawing.Size(316, 20)
        Me.txtDescArt.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Imp. Ventas:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fecha ultima entrada"
        '
        'dtpUltEnt
        '
        Me.dtpUltEnt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpUltEnt.Location = New System.Drawing.Point(87, 146)
        Me.dtpUltEnt.Name = "dtpUltEnt"
        Me.dtpUltEnt.Size = New System.Drawing.Size(96, 20)
        Me.dtpUltEnt.TabIndex = 6
        '
        'dtpUltSalida
        '
        Me.dtpUltSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpUltSalida.Location = New System.Drawing.Point(197, 146)
        Me.dtpUltSalida.Name = "dtpUltSalida"
        Me.dtpUltSalida.Size = New System.Drawing.Size(106, 20)
        Me.dtpUltSalida.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(194, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "fecha ultima salida:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Costo promedio:"
        '
        'bNavigator
        '
        Me.bNavigator.AddNewItem = Me.bnAdd
        Me.bNavigator.CountItem = Nothing
        Me.bNavigator.DeleteItem = Me.bnDelete
        Me.bNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bnFirst, Me.bnPrev, Me.bnNext, Me.bnLast, Me.BindingNavigatorSeparator5, Me.bnClear, Me.bnAdd, Me.bnDelete, Me.bnSave, Me.bnRefresh, Me.bnExit})
        Me.bNavigator.Location = New System.Drawing.Point(0, 0)
        Me.bNavigator.MoveFirstItem = Me.bnFirst
        Me.bNavigator.MoveLastItem = Me.bnLast
        Me.bNavigator.MoveNextItem = Me.bnNext
        Me.bNavigator.MovePreviousItem = Me.bnPrev
        Me.bNavigator.Name = "bNavigator"
        Me.bNavigator.PositionItem = Nothing
        Me.bNavigator.Size = New System.Drawing.Size(523, 25)
        Me.bNavigator.TabIndex = 42
        Me.bNavigator.Text = "BindingNavigator2"
        '
        'bnAdd
        '
        Me.bnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnAdd.Image = CType(resources.GetObject("bnAdd.Image"), System.Drawing.Image)
        Me.bnAdd.Name = "bnAdd"
        Me.bnAdd.RightToLeftAutoMirrorImage = True
        Me.bnAdd.Size = New System.Drawing.Size(23, 22)
        Me.bnAdd.Text = "Add new"
        '
        'bnDelete
        '
        Me.bnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnDelete.Image = CType(resources.GetObject("bnDelete.Image"), System.Drawing.Image)
        Me.bnDelete.Name = "bnDelete"
        Me.bnDelete.RightToLeftAutoMirrorImage = True
        Me.bnDelete.Size = New System.Drawing.Size(23, 22)
        Me.bnDelete.Text = "Delete"
        '
        'bnFirst
        '
        Me.bnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnFirst.Image = CType(resources.GetObject("bnFirst.Image"), System.Drawing.Image)
        Me.bnFirst.Name = "bnFirst"
        Me.bnFirst.RightToLeftAutoMirrorImage = True
        Me.bnFirst.Size = New System.Drawing.Size(23, 22)
        Me.bnFirst.Text = "Move first"
        '
        'bnPrev
        '
        Me.bnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnPrev.Image = CType(resources.GetObject("bnPrev.Image"), System.Drawing.Image)
        Me.bnPrev.Name = "bnPrev"
        Me.bnPrev.RightToLeftAutoMirrorImage = True
        Me.bnPrev.Size = New System.Drawing.Size(23, 22)
        Me.bnPrev.Text = "Move previous"
        '
        'bnNext
        '
        Me.bnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnNext.Image = CType(resources.GetObject("bnNext.Image"), System.Drawing.Image)
        Me.bnNext.Name = "bnNext"
        Me.bnNext.RightToLeftAutoMirrorImage = True
        Me.bnNext.Size = New System.Drawing.Size(23, 22)
        Me.bnNext.Text = "Move next"
        '
        'bnLast
        '
        Me.bnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnLast.Image = CType(resources.GetObject("bnLast.Image"), System.Drawing.Image)
        Me.bnLast.Name = "bnLast"
        Me.bnLast.RightToLeftAutoMirrorImage = True
        Me.bnLast.Size = New System.Drawing.Size(23, 22)
        Me.bnLast.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'bnClear
        '
        Me.bnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnClear.Image = Global.Proyecto_Programacion5_2doCuatrimeste2012.My.Resources.Resources.Clear
        Me.bnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnClear.Name = "bnClear"
        Me.bnClear.Size = New System.Drawing.Size(23, 22)
        Me.bnClear.Text = "ToolStripButton1"
        '
        'bnSave
        '
        Me.bnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnSave.Image = Global.Proyecto_Programacion5_2doCuatrimeste2012.My.Resources.Resources.icon_save1
        Me.bnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnSave.Margin = New System.Windows.Forms.Padding(0, 1, 0, 1)
        Me.bnSave.Name = "bnSave"
        Me.bnSave.Size = New System.Drawing.Size(23, 23)
        Me.bnSave.Text = "ToolStripButton3"
        '
        'bnRefresh
        '
        Me.bnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnRefresh.Image = CType(resources.GetObject("bnRefresh.Image"), System.Drawing.Image)
        Me.bnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnRefresh.Name = "bnRefresh"
        Me.bnRefresh.Size = New System.Drawing.Size(23, 22)
        Me.bnRefresh.Text = "ToolStripButton1"
        '
        'bnExit
        '
        Me.bnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bnExit.Image = Global.Proyecto_Programacion5_2doCuatrimeste2012.My.Resources.Resources.Log_Out
        Me.bnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnExit.Name = "bnExit"
        Me.bnExit.Size = New System.Drawing.Size(23, 22)
        Me.bnExit.Text = "ToolStripButton2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(190, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Costo Ultima Entrada:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Anterior:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Actual:"
        '
        'txtDescUM
        '
        Me.txtDescUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescUM.Location = New System.Drawing.Point(121, 98)
        Me.txtDescUM.Name = "txtDescUM"
        Me.txtDescUM.ReadOnly = True
        Me.txtDescUM.Size = New System.Drawing.Size(316, 20)
        Me.txtDescUM.TabIndex = 4
        Me.txtDescUM.TabStop = False
        '
        'txtCodUM
        '
        Me.txtCodUM.Location = New System.Drawing.Point(15, 98)
        Me.txtCodUM.Name = "txtCodUM"
        Me.txtCodUM.Size = New System.Drawing.Size(100, 20)
        Me.txtCodUM.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Unidad de Medida:"
        '
        'txtCostPromAnt
        '
        Me.txtCostPromAnt.BackColor = System.Drawing.Color.Tan
        Me.txtCostPromAnt.Location = New System.Drawing.Point(69, 196)
        Me.txtCostPromAnt.Name = "txtCostPromAnt"
        Me.txtCostPromAnt.ReadOnly = True
        Me.txtCostPromAnt.Size = New System.Drawing.Size(95, 20)
        Me.txtCostPromAnt.TabIndex = 52
        Me.txtCostPromAnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostPromAct
        '
        Me.txtCostPromAct.BackColor = System.Drawing.Color.Tan
        Me.txtCostPromAct.Location = New System.Drawing.Point(69, 229)
        Me.txtCostPromAct.Name = "txtCostPromAct"
        Me.txtCostPromAct.ReadOnly = True
        Me.txtCostPromAct.Size = New System.Drawing.Size(95, 20)
        Me.txtCostPromAct.TabIndex = 53
        Me.txtCostPromAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostUltEntAct
        '
        Me.txtCostUltEntAct.BackColor = System.Drawing.Color.Tan
        Me.txtCostUltEntAct.Location = New System.Drawing.Point(193, 229)
        Me.txtCostUltEntAct.Name = "txtCostUltEntAct"
        Me.txtCostUltEntAct.ReadOnly = True
        Me.txtCostUltEntAct.Size = New System.Drawing.Size(95, 20)
        Me.txtCostUltEntAct.TabIndex = 55
        Me.txtCostUltEntAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCostUltEntAnt
        '
        Me.txtCostUltEntAnt.BackColor = System.Drawing.Color.Tan
        Me.txtCostUltEntAnt.Location = New System.Drawing.Point(193, 196)
        Me.txtCostUltEntAnt.Name = "txtCostUltEntAnt"
        Me.txtCostUltEntAnt.ReadOnly = True
        Me.txtCostUltEntAnt.Size = New System.Drawing.Size(95, 20)
        Me.txtCostUltEntAnt.TabIndex = 54
        Me.txtCostUltEntAnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIV
        '
        Me.txtIV.Location = New System.Drawing.Point(15, 146)
        Me.txtIV.Name = "txtIV"
        Me.txtIV.Size = New System.Drawing.Size(63, 20)
        Me.txtIV.TabIndex = 56
        Me.txtIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 277)
        Me.Controls.Add(Me.txtIV)
        Me.Controls.Add(Me.txtCostUltEntAct)
        Me.Controls.Add(Me.txtCostUltEntAnt)
        Me.Controls.Add(Me.txtCostPromAct)
        Me.Controls.Add(Me.txtCostPromAnt)
        Me.Controls.Add(Me.txtDescUM)
        Me.Controls.Add(Me.txtCodUM)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.bNavigator)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpUltSalida)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpUltEnt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescArt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodArt)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulos"
        CType(Me.bNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bNavigator.ResumeLayout(False)
        Me.bNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodArt As System.Windows.Forms.TextBox
    Friend WithEvents txtDescArt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpUltEnt As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpUltSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents bNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents bnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnFirst As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnPrev As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnLast As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents bnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDescUM As System.Windows.Forms.TextBox
    Friend WithEvents txtCodUM As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents bnClear As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtCostPromAnt As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPromAct As System.Windows.Forms.TextBox
    Friend WithEvents txtCostUltEntAct As System.Windows.Forms.TextBox
    Friend WithEvents txtCostUltEntAnt As System.Windows.Forms.TextBox
    Friend WithEvents txtIV As System.Windows.Forms.TextBox
End Class
