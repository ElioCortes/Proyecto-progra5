Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmUnidadMedida

    Dim Cambios, Nuevo As New Boolean
    Dim cDemo As New SqlConnection
    Dim cTransa As SqlTransaction

    Private Sub bnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnClear.Click
        txtCodigo.Clear()
        txtDescUM.Clear()
        txtCodigo.Focus()
        bnAdd.Enabled = False
        bnSave.Enabled = False
        Cambios = False
        Nuevo = True
        txtCodigo.Focus()
    End Sub

    Private Sub frmUnidadMedida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bnFirst.Enabled = True
        bnFirst.PerformClick()

    End Sub

    Private Sub bnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnAdd.Click
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        Try
            cDemo.ConnectionString = strconexion
            cDemo.Open()

            cTransa = cDemo.BeginTransaction

            With cmdtipo
                .Connection = cDemo
                .Parameters.Add("@codigo_unidad_medida", SqlDbType.VarChar)
                .Parameters.Add("@descripcion", SqlDbType.VarChar)
                .Parameters("@codigo_unidad_medida").Value = txtCodigo.Text
                .Parameters("@descripcion").Value = txtDescUM.Text
                .CommandText = "sp_Inserta_Unidad_Medida"
                .CommandType = CommandType.StoredProcedure
                .Transaction = cTransa
            End With

            datipo = New SqlDataAdapter
            datipo.SelectCommand = cmdtipo
            datipo.Fill(dstipo, "INSERTAUNIDADMEDIDA")
            cTransa.Commit()
            bnAdd.Enabled = True
            Cambios = False
            Nuevo = False
            txtCodigo.Focus()
            txtCodigo.SelectAll()

            '  MessageBox.Show("Unidad de Medida insertada", "QUITAR MENSAJE", MessageBoxButtons.OK)
        Catch ex As SqlException
            cTransa.Rollback()
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Insercion de Unidades de Medida", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
    End Sub

    Private Sub bnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnExit.Click
        Me.Close()
    End Sub

    Private Sub txtCodigo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigo.Validating
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        If txtCodigo.Text.Trim <> "" Then
            Try
                cDemo.ConnectionString = strconexion
                cDemo.Open()

                With cmdtipo
                    .Connection = cDemo
                    .Parameters.Add("@codigo_unidad_medida", SqlDbType.VarChar)
                    .Parameters("@codigo_unidad_medida").Value = txtCodigo.Text
                    .CommandText = "sp_Consulta_Unidad_Medida"
                    .CommandType = CommandType.StoredProcedure
                End With

                datipo = New SqlDataAdapter
                datipo.SelectCommand = cmdtipo
                datipo.Fill(dstipo, "CONSULTAUNIDADMEDIDA")

                If dstipo.Tables(0).Rows.Count > 0 Then
                    'txtCodigo.Text = dstipo.Tables(0).Rows(0).Item("codigo_unidad_medida")
                    txtDescUM.Text = dstipo.Tables(0).Rows(0).Item("descripcion")
                    bnSave.Enabled = True
                    bnAdd.Enabled = False
                    Cambios = False
                    'bnFirst.Enabled = True
                    'bnPrev.Enabled = True
                    'bnNext.Enabled = True
                    'bnLast.Enabled = True
                    'bnNext.Enabled = True
                    'bnRefresh.Enabled = True
                    'bnDelete.Enabled = True
                Else
                    bnSave.Enabled = False
                    bnAdd.Enabled = True
                    txtDescUM.Clear()
                End If

            Catch ex As SqlException
                MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Insercion de Unidades de Medida", MessageBoxButtons.OK)
            Finally
                cDemo.Close()
            End Try

        End If
    End Sub

    Private Sub txtDescUM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescUM.TextChanged
        Cambios = True
        bnSave.Enabled = True
    End Sub

    Private Sub bnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnDelete.Click
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet
        Dim Borrado As Boolean

        Try
            cDemo.ConnectionString = strconexion
            cDemo.Open()

            cTransa = cDemo.BeginTransaction

            With cmdtipo
                .Connection = cDemo
                .Parameters.Add("@codigo_unidad_medida", SqlDbType.VarChar)
                .Parameters("@codigo_unidad_medida").Value = txtCodigo.Text
                .CommandText = "sp_Elimina_Unidad_Medida"
                .CommandType = CommandType.StoredProcedure
                .Transaction = cTransa
            End With

            datipo = New SqlDataAdapter
            datipo.SelectCommand = cmdtipo
            datipo.Fill(dstipo, "ELIMINAUNIDADMEDIDA")
            cTransa.Commit()

            Borrado = True

            'MessageBox.Show("Unidad de Medida insertada", "QUITAR MENSAJE", MessageBoxButtons.OK)
        Catch ex As SqlException
            cTransa.Rollback()
            Borrado = False
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Eliminacion de Unidad de Medida", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try

        If Borrado Then
            bnClear.PerformClick()
            bnLast.PerformClick()
        End If
    End Sub

    Private Sub bnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnRefresh.Click
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        'bnClear.PerformClick()

        Try
            cDemo.ConnectionString = strconexion
            cDemo.Open()

            With cmdtipo
                .Connection = cDemo
                .Parameters.Add("@codigo_unidad_medida", SqlDbType.VarChar)
                .Parameters("@codigo_unidad_medida").Value = txtCodigo.Text
                .CommandText = "sp_Consulta_Unidad_Medida"
                .CommandType = CommandType.StoredProcedure
            End With

            datipo = New SqlDataAdapter
            datipo.SelectCommand = cmdtipo
            datipo.Fill(dstipo, "CONSULTAUNIDADMEDIDA")

            If dstipo.Tables(0).Rows.Count > 0 Then
                'txtCodigo.Text = dstipo.Tables(0).Rows(0).Item("codigo_unidad_medida")
                txtDescUM.Text = dstipo.Tables(0).Rows(0).Item("descripcion")
                bnFirst.Enabled = True
                bnPrev.Enabled = True
                bnNext.Enabled = True
                bnLast.Enabled = True
                bnNext.Enabled = True
                bnRefresh.Enabled = True
                bnDelete.Enabled = True
                Cambios = False
                txtCodigo.SelectAll()
                txtCodigo.Focus()
            Else
                bnClear.PerformClick()
            End If

        Catch ex As SqlException
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Insercion de Unidades de Medida", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
    End Sub

    Private Sub bnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnFirst.Click
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        bnClear.PerformClick()

        Try
            cDemo.ConnectionString = strconexion
            cDemo.Open()
            datipo = New SqlDataAdapter("SELECT TOP 1 * FROM UNIDAD_MEDIDA", cDemo)

            datipo.Fill(dstipo)

            If dstipo.Tables(0).Rows.Count > 0 Then
                txtCodigo.Text = dstipo.Tables(0).Rows(0).Item("codigo_unidad_medida")
                txtDescUM.Text = dstipo.Tables(0).Rows(0).Item("descripcion")
                txtCodigo.SelectAll()
                txtCodigo.Focus()
                bnFirst.Enabled = True
                bnPrev.Enabled = True
                bnNext.Enabled = True
                bnLast.Enabled = True
                bnNext.Enabled = True
                bnRefresh.Enabled = True
                bnDelete.Enabled = True
                Cambios = False
            Else
                bnFirst.Enabled = False
                bnClear.PerformClick()
            End If
        Catch ex As SqlException
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Insercion de Unidades de Medida", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
    End Sub

    Private Sub bnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnNext.Click
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        Try
            cDemo.ConnectionString = strconexion
            cDemo.Open()
            datipo = New SqlDataAdapter("SELECT TOP 1 * FROM UNIDAD_MEDIDA where codigo_unidad_medida > '" + txtCodigo.Text + "' order by codigo_unidad_medida ASC", cDemo)

            datipo.Fill(dstipo)

            If dstipo.Tables(0).Rows.Count > 0 Then
                txtCodigo.Text = dstipo.Tables(0).Rows(0).Item("codigo_unidad_medida")
                txtDescUM.Text = dstipo.Tables(0).Rows(0).Item("descripcion")
                bnFirst.Enabled = True
                bnPrev.Enabled = True
                bnNext.Enabled = True
                bnLast.Enabled = True
                bnNext.Enabled = True
                bnRefresh.Enabled = True
                bnDelete.Enabled = True
                txtCodigo.SelectAll()
                txtCodigo.Focus()
                Cambios = False
            Else
                'bnClear.PerformClick()
            End If
        Catch ex As SqlException
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Insercion de Unidades de Medida", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
    End Sub

    Private Sub bnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnLast.Click
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        bnClear.PerformClick()

        Try
            cDemo.ConnectionString = strconexion
            cDemo.Open()

            datipo = New SqlDataAdapter("select * from Unidad_Medida where codigo_unidad_medida = (Select max(codigo_unidad_medida) from Unidad_Medida) order by codigo_unidad_medida ASC", cDemo)
            datipo.Fill(dstipo)

            If dstipo.Tables(0).Rows.Count > 0 Then
                txtCodigo.Text = dstipo.Tables(0).Rows(0).Item("codigo_unidad_medida")
                txtDescUM.Text = dstipo.Tables(0).Rows(0).Item("descripcion")
                bnFirst.Enabled = True
                bnPrev.Enabled = True
                bnNext.Enabled = True
                bnLast.Enabled = True
                bnNext.Enabled = True
                bnRefresh.Enabled = True
                bnDelete.Enabled = True
                txtCodigo.SelectAll()
                txtCodigo.Focus()
                Cambios = False
            Else
                bnClear.PerformClick()
            End If
        Catch ex As SqlException
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Insercion de Unidades de Medida", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
    End Sub

    Private Sub bnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnPrev.Click
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        Try
            cDemo.ConnectionString = strconexion
            cDemo.Open()
            datipo = New SqlDataAdapter("SELECT TOP 1 * FROM UNIDAD_MEDIDA where codigo_unidad_medida < '" + txtCodigo.Text + "' order by codigo_unidad_medida DESC", cDemo)

            datipo.Fill(dstipo)

            If dstipo.Tables(0).Rows.Count > 0 Then
                txtCodigo.Text = dstipo.Tables(0).Rows(0).Item("codigo_unidad_medida")
                txtDescUM.Text = dstipo.Tables(0).Rows(0).Item("descripcion")
                bnFirst.Enabled = True
                bnPrev.Enabled = True
                bnNext.Enabled = True
                bnLast.Enabled = True
                bnNext.Enabled = True
                bnRefresh.Enabled = True
                bnDelete.Enabled = True
                txtCodigo.SelectAll()
                txtCodigo.Focus()
                Cambios = False
            Else
                'bnClear.PerformClick()
            End If
        Catch ex As SqlException
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Insercion de Unidades de Medida", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
    End Sub

    Private Sub bnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnSave.Click
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        Try
            cDemo.ConnectionString = strconexion
            cDemo.Open()

            cTransa = cDemo.BeginTransaction

            With cmdtipo
                .Connection = cDemo
                .Parameters.Add("@codigo_unidad_medida", SqlDbType.VarChar)
                .Parameters.Add("@descripcion", SqlDbType.VarChar)
                .Parameters("@codigo_unidad_medida").Value = txtCodigo.Text
                .Parameters("@descripcion").Value = txtDescUM.Text
                .CommandText = "sp_Modificar_Unidad_Medida"
                .CommandType = CommandType.StoredProcedure
                .Transaction = cTransa
            End With

            datipo = New SqlDataAdapter
            datipo.SelectCommand = cmdtipo
            datipo.Fill(dstipo, "MODIFICAUNIDADMEDIDA")
            cTransa.Commit()

            txtCodigo.SelectAll()
            txtCodigo.Focus()
            Cambios = False
            'MessageBox.Show("Unidad de Medida insertada", "QUITAR MENSAJE", MessageBoxButtons.OK)
        Catch ex As SqlException
            cTransa.Rollback()
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Actualiza Unidad de Medida", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
    End Sub

    Private Sub txtCodigo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyUp
        If e.KeyData = Keys.Home Then
            e.Handled = True
            bnFirst.PerformClick()
        ElseIf e.KeyData = Keys.End Then
            e.Handled = True
            bnLast.PerformClick()
        ElseIf e.KeyData = Keys.Prior Then
            e.Handled = True
            bnPrev.PerformClick()
        ElseIf e.KeyData = Keys.Next Then
            e.Handled = True
            bnNext.PerformClick()
        ElseIf e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmUnidadMedida_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resul As MsgBoxResult
        If Cambios Then
            resul = MessageBox.Show("Cambios sin guardar. Desea guardar?", "Cerrando", MessageBoxButtons.YesNoCancel)

            If resul = MsgBoxResult.Cancel Then
                e.Cancel = True
            ElseIf resul = MsgBoxResult.Yes Then
                bnSave.PerformClick()
            End If
        End If
    End Sub
End Class