Imports System.Data
Imports System.Data.SqlClient

Public Class FrmDepartamento

    'VARIABLES DE CLASE
    Dim oradb As String = "Data Source=ELROND;Initial Catalog=ENERTROL;Integrated Security=True"  'Necesitamos leer de un archivo de configuración para establecer la cadena de conexion


    Private Sub BttnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmDepartamento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'CREAMOS UNA VARIABLE PARA ALMACENAR LA RESPUESTA DEL USUARIO
        Dim respuestaMensaje As MsgBoxResult
        respuestaMensaje = MessageBox.Show("¿Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (respuestaMensaje = MsgBoxResult.No) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Limpiar()
        'METODO PARA LIMPIAR Y POSICIONAR EL ENFOQUE EN CAMPO TEXTO: NOMBRE
        txtCantMaxEmp.Clear()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtNombre.Focus()
    End Sub

    Private Function VerificarCamposLlenos() As Boolean
        'NECESITAMOS VERIFICAR SI TODOS LOS CAMPOS ESTAN LLENOS, SOLO PARA PODER INCLUIR, DEBIDO A QUE TODOS LOS CAMPOS SON NECESARIOS
        If (txtCantMaxEmp.Text = String.Empty = True Or txtNombre.Text = String.Empty = True) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub LlenarCampoCodigo()
        'ESTE METODO TIENE LA FUNCION DE INICIALIZAR EL CAMPO CODIGO POR MEDIO DE UNA CONSULTA A LA BASE DE DATOS

    End Sub

    Private Sub BttnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BttnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnIncluir.Click
        'If Not (VerificarCamposLlenos()) Then
        '    MessageBox.Show("Hay campos vacios, favor verificar", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        '    conn.Open()
        '    Dim cmd As New OracleCommand("NUEVO_DEPARTAMENTO", conn)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("NOMBRE_DEP", OracleDbType.Varchar2)
        '    cmd.Parameters.Add("CANT_MAX_EMP_DEP", OracleDbType.Int32)
        '    cmd.ExecuteNonQuery()
        '    cmd.Dispose()
        '    'Dim dr As OracleDataReader = cmd.ExecuteReader()
        '    'dr.Read()
        '    conn.Close()
        'End If
    End Sub

    Private Sub FrmDepartamento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class