Imports System
Imports System.Data.Odbc
Imports System.Data.SqlClient

Public Class FrmNuevoUsuario
    Private Sub Limpiar()
        txtClave.Clear()
        txtUsuario.Clear()
    End Sub

    Private Sub BttnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnAceptar.Click
        MdlLogueoUsuario.incluirUsuario(txtUsuario.Text, txtClave.Text)
        Limpiar()
    End Sub

    Private Sub BttnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnSalir.Click
        Me.Close()
    End Sub
End Class