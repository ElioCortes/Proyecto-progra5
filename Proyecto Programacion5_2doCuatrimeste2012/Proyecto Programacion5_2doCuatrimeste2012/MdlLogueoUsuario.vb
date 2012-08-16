Imports System
Imports System.Data.Odbc
Imports System.Data.SqlClient
Module MdlLogueoUsuario

    Dim cDemo As New SqlConnection
    'Dim cODBC As New Odbc.OdbcConnection
    Dim strConexion As String = "Data Source=localhost;Initial Catalog=dbactivos2;Integrated Security=True"

    Public Function consultar_clave(ByVal claveEnc As String, ByVal usuario As String, ByRef intentos As Integer) As Boolean
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        Dim clave As String

        cDemo.ConnectionString = strConexion
        cDemo.Open()

        With cmdtipo
            .Connection = cDemo
            .Parameters.Add("@User_name", SqlDbType.Char)
            .Parameters("@User_name").Value = usuario
            .CommandText = "SP_VERIFICAR_USUARIO"
            .CommandType = CommandType.StoredProcedure
        End With

        datipo = New SqlDataAdapter
        datipo.SelectCommand = cmdtipo
        datipo.Fill(dstipo, "CONSULTAR_CLAVE_ENC")

        If dstipo.Tables(0).Rows.Count > 0 Then
            clave = dstipo.Tables(0).Rows(0).Item("clave")
            If (clave = claveEnc) Then
                MessageBox.Show("Logueo satisfactorio", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Else
                cDemo.Close()
                If (verificarUsuarioBloquedo(usuario)) Then
                    MessageBox.Show("Lo sentimos su cuenta ha sido bloqueada, consulte a su administrador de usuarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                Else
                    cDemo.Close()
                    intentos = intentos + 1
                    MessageBox.Show("La cuenta no concuerda, tienes: " & intentos & " intentos de 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                    If (intentos = 3) Then
                        bloquearUsuario(usuario)
                    End If
                End If
            End If
        Else
            MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        cDemo.Close()
    End Function

    Private Function verificarUsuarioBloquedo(ByVal usuaro As String) As Boolean

        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        Dim bloqueado As Integer

        cDemo.ConnectionString = strConexion
        cDemo.Open()

        With cmdtipo
            .Connection = cDemo
            .Parameters.Add("@User_name", SqlDbType.Char)
            .Parameters("@User_name").Value = usuaro
            .CommandText = "SP_VERIFICAR_USUARIO_BLOQUEADO "
            .CommandType = CommandType.StoredProcedure
        End With

        datipo = New SqlDataAdapter
        datipo.SelectCommand = cmdtipo
        datipo.Fill(dstipo, "CONSULTAR_CLAVE_ENC")

        If dstipo.Tables(0).Rows.Count > 0 Then
            bloqueado = dstipo.Tables(0).Rows(0).Item("bloqueado")
            If (bloqueado = 1) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
        cDemo.Close()
    End Function

    Private Sub bloquearUsuario(ByVal usuario As String)
        'variable: permite almacenar el código del tipo_activo consultado por el usuario

        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        cDemo.ConnectionString = strConexion
        cDemo.Open()

        With cmdtipo
            .Connection = cDemo
            .Parameters.Add("@User_name", SqlDbType.Char)
            .Parameters("@User_name").Value = usuario
            .CommandText = "SP_BLOQUEAR_USUARIO"
            .CommandType = CommandType.StoredProcedure
        End With
        Try

            datipo = New SqlDataAdapter
            datipo.SelectCommand = cmdtipo
            datipo.Fill(dstipo, "BLOQUEAR_USUARIO")
            MessageBox.Show("El usuario:" & usuario & ", se ha bloqueado satisfactoriamente")

        Catch ex As SqlException
            MessageBox.Show("No se pudo bloquear el usuario, se ha originado el siguiente error: " & ex.Message, "Error Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cDemo.Close()

    End Sub

    Public Sub incluirUsuario(ByVal usuario As String, ByVal clave As String)

        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        usuario = Trim(usuario)
        clave = Trim(clave)

        clave = MdlMD5.getMd5Hash(clave)

        cDemo.ConnectionString = strConexion
        cDemo.Open()

        With cmdtipo
            .Connection = cDemo
            .Parameters.Add("@User_name", SqlDbType.Char)
            .Parameters.Add("@Clave", SqlDbType.VarChar)
            .Parameters("@User_name").Value = usuario
            .Parameters("@Clave").Value = clave
            .CommandText = "SP_INCLUIR_CUENTA"
            .CommandType = CommandType.StoredProcedure
        End With
        Try
            datipo = New SqlDataAdapter
            datipo.SelectCommand = cmdtipo
            datipo.Fill(dstipo, "INCLUIR_CUENTA_USUARIO")

            MessageBox.Show("Se ha agregado satisfactoriamente")

        Catch ex As SqlException
            MessageBox.Show("No se pudo incluir el usuario, se ha originado el siguiente error: " & ex.Message, "Error Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cDemo.Close()

    End Sub


    Public Sub ModificarClave(ByVal usuario As String, ByVal claveVieja As String, ByVal claveNueva As String)
        'variable: permite almacenar el código del tipo_activo consultado por el usuario

        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        cDemo.ConnectionString = strConexion
        cDemo.Open()

        With cmdtipo
            .Connection = cDemo
            .Parameters.Add("@User_name", SqlDbType.Char)
            .Parameters("@User_name").Value = Trim(usuario)
            .Parameters.Add("@clave", SqlDbType.Char)
            .Parameters("@clave").Value = Trim(claveVieja)
            .Parameters.Add("@claveNueva", SqlDbType.Char)
            .Parameters("@claveNueva").Value = Trim(claveNueva)
            .CommandText = "SP_MODIFICAR_CLAVE_USUARIO"
            .CommandType = CommandType.StoredProcedure
        End With
        Try
            datipo = New SqlDataAdapter
            datipo.SelectCommand = cmdtipo
            datipo.Fill(dstipo, "MODIFICAR_CLAVE_USUARIO")
            MessageBox.Show("El usuario:" & usuario & ", se le ha modificado la clave satisfactoriamente")

        Catch ex As SqlException
            MessageBox.Show("No se pudo actualizar la cuenta del usuario: " & ex.Message, "Error: Modificar-cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cDemo.Close()

    End Sub
End Module
