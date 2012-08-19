Public Class FrmCambioContraseña

    Private Function confirmarNuevaContraseña() As Boolean
        If (txtConfirmacionContraseña.Text = txtNuevaContraseña.Text) Then
            Return True
        Else
            txtContraseñaActual.Focus()
            Return False
        End If
    End Function

    Private Sub Limpiar()
        txtConfirmacionContraseña.Clear()
        txtContraseñaActual.Clear()
        txtNuevaContraseña.Clear()
        txtUsuario.Clear()
        txtUsuario.Focus()
    End Sub

    Private Function espaciosVacios() As Boolean
        If (txtConfirmacionContraseña.Text = String.Empty) Or (txtContraseñaActual.Text = String.Empty) Or (txtNuevaContraseña.Text = String.Empty) Or (txtUsuario.Text = String.Empty) Then
            txtUsuario.Focus()
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub BttnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnSalir.Click
        Me.Close()
    End Sub

    Private Sub validarClave(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNuevaContraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNuevaContraseña.KeyPress
        validarClave(e)
    End Sub

    Private Sub BttnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnGuardar.Click
        'Primero verificamos que todos los espacios este llenos, eso lo hacemos con la funcion espaciosVacions()
        If (espaciosVacios()) Then
            MessageBox.Show("Error: todos los campos son requeridos", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (Not confirmarNuevaContraseña()) Then
                MessageBox.Show("Error: las contraseñas no concuerdan", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Dim mds_clave As ClssMD5
                mds_clave = New ClssMD5

                Dim claveEnc = txtContraseñaActual.Text
                Dim claveEnc2 = txtNuevaContraseña.Text
                claveEnc = mds_clave.getMd5Hash(claveEnc)
                claveEnc2 = mds_clave.getMd5Hash(claveEnc2)
                MdlLogueoUsuario.ModificarClave(txtUsuario.Text, claveEnc, claveEnc2)
            End If
        End If
    End Sub

    Private Sub BttnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnLimpiar.Click
        Limpiar()
    End Sub
End Class