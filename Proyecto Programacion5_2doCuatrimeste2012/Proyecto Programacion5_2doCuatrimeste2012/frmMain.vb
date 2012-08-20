Public Class frmMain

    Private Sub ArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosToolStripMenuItem.Click
        FrmArticulo.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UnidadesDeMedidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnidadesDeMedidaToolStripMenuItem.Click
        frmUnidadMedida.ShowDialog()
    End Sub

    Private Sub ModificarCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmCambioContraseña.Show()
    End Sub

    Private Sub CrearCuentaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CrearCuentaToolStripMenuItem.Click
        FrmNuevoUsuario.Show()
    End Sub

    Private Sub BodegasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BodegasToolStripMenuItem.Click
        frmBodega.ShowDialog()
    End Sub
End Class