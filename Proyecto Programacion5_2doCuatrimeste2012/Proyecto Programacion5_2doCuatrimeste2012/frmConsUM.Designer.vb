<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsUM
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
        Me.dgvBodegas = New System.Windows.Forms.DataGridView()
        Me.colCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBodegas
        '
        Me.dgvBodegas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCod, Me.colDesc})
        Me.dgvBodegas.Location = New System.Drawing.Point(13, 21)
        Me.dgvBodegas.Name = "dgvBodegas"
        Me.dgvBodegas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvBodegas.Size = New System.Drawing.Size(393, 170)
        Me.dgvBodegas.TabIndex = 0
        '
        'colCod
        '
        Me.colCod.Frozen = True
        Me.colCod.HeaderText = "Código"
        Me.colCod.Name = "colCod"
        Me.colCod.ReadOnly = True
        '
        'colDesc
        '
        Me.colDesc.Frozen = True
        Me.colDesc.HeaderText = "Descripción"
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Width = 250
        '
        'frmConsUM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 212)
        Me.Controls.Add(Me.dgvBodegas)
        Me.Name = "frmConsUM"
        Me.Text = "Consulta Unidad de Medida"
        CType(Me.dgvBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvBodegas As System.Windows.Forms.DataGridView
    Friend WithEvents colCod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDesc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
