'Imports System
'Imports System.Data.Odbc
'Imports System.Data.SqlClient
Public Class FrmIngreso
    'Dim cDemo As New SqlConnection
    ''Dim cODBC As New Odbc.OdbcConnection
    'Dim strConexion As String = "Data Source=localhost;Initial Catalog=DBACTIVOS;Integrated Security=True"
    'conexion a database'
    Dim intentos As Integer

    Private Sub BttnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnAceptar.Click
        Dim claveEnc, usuario As String
        claveEnc = Trim(txtClave.Text)
        usuario = Trim(txtUsuario.Text)

        Dim mds_clave As ClssMD5
        mds_clave = New ClssMD5

        claveEnc = mds_clave.getMd5Hash(claveEnc) 'Llamamos al metodo getMd5Hash para encriptar nuestra variable
        If (MdlLogueoUsuario.consultar_clave(claveEnc, usuario, intentos)) Then  'Llamamos al metodo de nuestro módulo MdlLogueoUsuario, este desencadela los demás metodos que se encargan de loguear o bloquear el usario
            Me.Hide()
            frmMain.Show()
        Else
            Limpiar()
        End If
    End Sub

    Private Sub FrmIngreso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        intentos = 0
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        FrmNuevoUsuario.ShowDialog()
    End Sub

    Private Sub BttnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnSalir.Click
        Me.Close()
    End Sub

    Private Sub Limpiar()
        txtClave.Clear()
        txtUsuario.Clear()
        txtUsuario.Focus()
    End Sub

    Private Sub ModificarClaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmCambioContraseña.ShowDialog()
    End Sub

    Private Sub txtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClave.TextChanged

    End Sub
End Class