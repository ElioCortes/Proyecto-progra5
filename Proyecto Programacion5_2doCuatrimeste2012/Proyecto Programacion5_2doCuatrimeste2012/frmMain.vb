Public Class frmMain

    Private Sub ArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosToolStripMenuItem.Click
        'validar derechos para entrar a articulos
        'FrmArticulo.Created
        FrmArticulo.ShowDialog()
        'FrmArticulo.Dispose()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UnidadesDeMedidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnidadesDeMedidaToolStripMenuItem.Click
        frmUnidadMedida.ShowDialog()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ModificarCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmCambioContraseña.Show()
    End Sub
End Class