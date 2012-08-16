Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FrmArticulo
    'desplegar UM en mayuscula
    'cambiar los taborder
    'dar tab y ver validaciones porque limpia algunos campos

    Dim Cambios, Nuevo As New Boolean
    Dim cDemo As New SqlConnection
    Dim cTransa As SqlTransaction
    Dim strconexion As String = "Data Source=ELROND;Initial Catalog=ENERTROL;Integrated Security=True"

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
                .Parameters.Add("@codigo_articulo", SqlDbType.VarChar)
                .Parameters.Add("@descripcion", SqlDbType.VarChar)
                .Parameters.Add("@impuesto_ventas", SqlDbType.Float)
                .Parameters.Add("@fecha_ultima_entrada", SqlDbType.DateTime)
                .Parameters.Add("@fecha_ultima_salida", SqlDbType.DateTime)
                .Parameters.Add("@costo_prom_act", SqlDbType.Float)
                .Parameters.Add("@costo_prom_ant", SqlDbType.Float)
                .Parameters.Add("@costo_ult_ent_act", SqlDbType.Float)
                .Parameters.Add("@costo_ult_ent_ant", SqlDbType.Float)
                .Parameters.Add("@codigo_unidad_medida", SqlDbType.VarChar)
                .Parameters("@codigo_articulo").Value = txtCodArt.Text
                .Parameters("@descripcion").Value = txtDescArt.Text
                .Parameters("@impuesto_ventas").Value = Convert.ToDouble(txtIV.Text)
                .Parameters("@fecha_ultima_entrada").Value = dtpUltEnt.Text
                .Parameters("@fecha_ultima_salida").Value = dtpUltSalida.Text
                .Parameters("@costo_prom_act").Value = Convert.ToDouble(txtCostPromAct.Text)
                .Parameters("@costo_prom_ant").Value = Convert.ToDouble(txtCostPromAnt.Text)
                .Parameters("@costo_ult_ent_act").Value = Convert.ToDouble(txtCostUltEntAct.Text)
                .Parameters("@costo_ult_ent_ant").Value = Convert.ToDouble(txtCostUltEntAnt.Text)
                .Parameters("@codigo_unidad_medida").Value = txtCodUM.Text

                .CommandText = "sp_Inserta_Articulo"
                .CommandType = CommandType.StoredProcedure
                .Transaction = cTransa
            End With


            datipo = New SqlDataAdapter
            datipo.SelectCommand = cmdtipo
            datipo.Fill(dstipo, "INSERTAARTICULO")
            cTransa.Commit()
            bnAdd.Enabled = True
            Cambios = False
            Nuevo = False

            'MessageBox.Show("Artículo insertado", "QUITAR MENSAJE", MessageBoxButtons.OK)
        Catch ex As SqlException
            cTransa.Rollback()
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Insercion de Articulo", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
    End Sub

    Private Sub FrmArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bnFirst.Enabled = True
        bnFirst.PerformClick()

        'Dim cmdtipo As New SqlCommand
        'Dim datipo As SqlDataAdapter
        'Dim dstipo As New DataSet

        'bnClear.PerformClick()

        'Try
        '    cDemo.ConnectionString = strconexion
        '    cDemo.Open()

        '    With cmdtipo
        '        .Connection = cDemo
        '        .CommandText = "sp_Consulta_Todos_Articulos"
        '        .CommandType = CommandType.StoredProcedure
        '    End With

        '    datipo = New SqlDataAdapter
        '    datipo.SelectCommand = cmdtipo
        '    datipo.Fill(dstipo, "CONSULTAUNIDADESMEDIDAS")

        '    If dstipo.Tables(0).Rows.Count > 0 Then
        '        txtCodArt.Text = dstipo.Tables(0).Rows(0).Item("codigo_articulo")
        '        '                txtDescUM.Text = dstipo.Tables(0).Rows(0).Item("descripcion")
        '        bnFirst.Enabled = True
        '        bnPrev.Enabled = True
        '        bnNext.Enabled = True
        '        bnLast.Enabled = True
        '        bnNext.Enabled = True
        '        bnRefresh.Enabled = True
        '        bnDelete.Enabled = True
        '        Cambios = False
        '    End If
        'Catch ex As SqlException
        '    MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Insercion de Unidades de Medida", MessageBoxButtons.OK)
        'Finally
        '    cDemo.Close()
        'End Try
    End Sub

    Private Sub bnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnExit.Click
        Me.Close()
    End Sub

    Private Sub txtCodArt_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodArt.Enter
        txtCodArt.SelectAll()
    End Sub

    Private Sub bnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnClear.Click
        txtCodArt.Clear()
        txtDescArt.Clear()
        txtCodUM.Clear()
        txtDescUM.Clear()
        txtIV.Text = Format(0.0, "##.00")
        txtCostPromAct.Text = "0.00"
        txtCostPromAnt.Text = "0.00"
        txtCostUltEntAct.Text = "0.00"
        txtCostUltEntAnt.Text = "0.00"

        txtCodArt.Focus()
        bnAdd.Enabled = False
        bnSave.Enabled = False
        Cambios = False
        Nuevo = True

    End Sub

    Private Sub txtCodArt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodArt.TextChanged, txtIV.TextChanged, txtDescArt.TextChanged, txtCodUM.TextChanged, dtpUltSalida.ValueChanged, dtpUltEnt.ValueChanged
        Cambios = True
        bnSave.Enabled = True
    End Sub

    Private Sub txtCodArt_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodArt.Validating
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet
        Dim Desp As Boolean = False

        If txtCodArt.Text.Trim <> "" Then
            Try
                cDemo.ConnectionString = strconexion
                cDemo.Open()

                With cmdtipo
                    .Connection = cDemo
                    .Parameters.Add("@codigo_articulo", SqlDbType.VarChar)
                    .Parameters("@codigo_articulo").Value = txtCodArt.Text
                    .CommandText = "sp_Consulta_Articulo"
                    .CommandType = CommandType.StoredProcedure
                End With

                datipo = New SqlDataAdapter
                datipo.SelectCommand = cmdtipo
                datipo.Fill(dstipo, "CONSULTAUNIDADMEDIDA")

                If dstipo.Tables(0).Rows.Count > 0 Then
                    txtCodArt.Text = dstipo.Tables(0).Rows(0).Item("codigo_articulo")
                    txtDescArt.Text = dstipo.Tables(0).Rows(0).Item("descripcion")
                    txtIV.Text = Format(dstipo.Tables(0).Rows(0).Item("impuesto_ventas"), "##.00")
                    dtpUltEnt.Text = dstipo.Tables(0).Rows(0).Item("fecha_ultima_entrada")
                    dtpUltSalida.Text = dstipo.Tables(0).Rows(0).Item("fecha_ultima_salida")
                    txtCostPromAct.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_prom_act"), "##.00")
                    txtCostPromAnt.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_prom_ant"), "##.00")
                    txtCostUltEntAct.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_ult_ent_act"), "##.00")
                    txtCostUltEntAnt.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_ult_ent_ant"), "##.00")
                    txtCodUM.Text = dstipo.Tables(0).Rows(0).Item("codigo_unidad_medida")

                    bnSave.Enabled = True
                    bnAdd.Enabled = False
                    Cambios = False
                    Desp = True
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
            If Desp Then
                Desp_UMDesc()
            End If
        End If
    End Sub

    Private Sub Desp_UMDesc()
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        Try
            cDemo.ConnectionString = strconexion
            cDemo.Open()

            With cmdtipo
                .Connection = cDemo
                .Parameters.Add("@codigo_unidad_medida", SqlDbType.VarChar)
                .Parameters("@codigo_unidad_medida").Value = txtCodUM.Text
                .CommandText = "sp_Consulta_Unidad_Medida"
                .CommandType = CommandType.StoredProcedure
            End With

            datipo = New SqlDataAdapter
            datipo.SelectCommand = cmdtipo
            datipo.Fill(dstipo, "CONSULTAUNIDADMEDIDA")

            If dstipo.Tables(0).Rows.Count > 0 Then
                txtDescUM.Text = dstipo.Tables(0).Rows(0).Item("descripcion")
            Else
                txtCodUM.Clear()
            End If

        Catch ex As SqlException
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Insercion de Unidades de Medida", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
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
                .Parameters.Add("@codigo_articulo", SqlDbType.VarChar)
                .Parameters("@codigo_articulo").Value = txtCodArt.Text
                .CommandText = "sp_Elimina_Articulo"
                .CommandType = CommandType.StoredProcedure
                .Transaction = cTransa
            End With

            datipo = New SqlDataAdapter
            datipo.SelectCommand = cmdtipo
            datipo.Fill(dstipo, "ELIMINAARTICULO")
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
        Dim Desp As Boolean = False

        'bnClear.PerformClick()

        Try
            cDemo.ConnectionString = strconexion
            cDemo.Open()

            With cmdtipo
                .Connection = cDemo
                .Parameters.Add("@codigo_articulo", SqlDbType.VarChar)
                .Parameters("@codigo_articulo").Value = txtCodArt.Text
                .CommandText = "sp_Consulta_Articulo"
                .CommandType = CommandType.StoredProcedure
            End With

            datipo = New SqlDataAdapter
            datipo.SelectCommand = cmdtipo
            datipo.Fill(dstipo, "CONSULTAARTICULO")

            If dstipo.Tables(0).Rows.Count > 0 Then
                txtCodArt.Text = dstipo.Tables(0).Rows(0).Item("codigo_articulo")
                txtDescArt.Text = dstipo.Tables(0).Rows(0).Item("descripcion")
                txtIV.Text = Format(dstipo.Tables(0).Rows(0).Item("impuesto_ventas"), "##.00")
                dtpUltEnt.Text = dstipo.Tables(0).Rows(0).Item("fecha_ultima_entrada")
                dtpUltSalida.Text = dstipo.Tables(0).Rows(0).Item("fecha_ultima_salida")
                txtCostPromAct.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_prom_act"), "##.00")
                txtCostPromAnt.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_prom_ant"), "##.00")
                txtCostUltEntAct.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_ult_ent_act"), "##.00")
                txtCostUltEntAnt.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_ult_ent_ant"), "##.00")
                txtCodUM.Text = dstipo.Tables(0).Rows(0).Item("codigo_unidad_medida")
                bnFirst.Enabled = True
                bnPrev.Enabled = True
                bnNext.Enabled = True
                bnLast.Enabled = True
                bnNext.Enabled = True
                bnRefresh.Enabled = True
                bnDelete.Enabled = True
                Cambios = False
                txtCodArt.SelectAll()
                txtCodArt.Focus()
                Desp = True
            Else
                bnClear.PerformClick()
            End If

        Catch ex As SqlException
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Insercion de Unidades de Medida", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
        If Desp Then
            Desp_UMDesc()
        End If
    End Sub

    Private Sub bnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnFirst.Click
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet
        Dim Desp As Boolean = False

        bnClear.PerformClick()

        Try
            cDemo.ConnectionString = strconexion
            cDemo.Open()
            datipo = New SqlDataAdapter("SELECT TOP 1 * FROM ARTICULO", cDemo)

            datipo.Fill(dstipo)

            If dstipo.Tables(0).Rows.Count > 0 Then
                txtCodArt.Text = dstipo.Tables(0).Rows(0).Item("codigo_articulo")
                txtDescArt.Text = dstipo.Tables(0).Rows(0).Item("descripcion")
                txtIV.Text = Format(dstipo.Tables(0).Rows(0).Item("impuesto_ventas"), "##.00")
                dtpUltEnt.Text = dstipo.Tables(0).Rows(0).Item("fecha_ultima_entrada")
                dtpUltSalida.Text = dstipo.Tables(0).Rows(0).Item("fecha_ultima_salida")
                txtCostPromAct.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_prom_act"), "##.00")
                txtCostPromAnt.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_prom_ant"), "##.00")
                txtCostUltEntAct.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_ult_ent_act"), "##.00")
                txtCostUltEntAnt.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_ult_ent_ant"), "##.00")
                txtCodUM.Text = dstipo.Tables(0).Rows(0).Item("codigo_unidad_medida")
                bnFirst.Enabled = True
                bnPrev.Enabled = True
                bnNext.Enabled = True
                bnLast.Enabled = True
                bnNext.Enabled = True
                bnRefresh.Enabled = True
                bnDelete.Enabled = True
                Cambios = False
                txtCodArt.Focus()
                txtCodArt.SelectAll()
                Desp = True
            Else
                bnClear.PerformClick()
            End If
        Catch ex As SqlException
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Primer Artículo", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
        If Desp Then
            Desp_UMDesc()
        End If
    End Sub

    Private Sub bnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnNext.Click
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet
        Dim Desp As Boolean = False

        Try
            cDemo.ConnectionString = strconexion
            cDemo.Open()
            datipo = New SqlDataAdapter("SELECT TOP 1 * FROM ARTICULO where codigo_articulo > '" + txtCodArt.Text + "' order by codigo_articulo ASC", cDemo)

            datipo.Fill(dstipo)

            If dstipo.Tables(0).Rows.Count > 0 Then
                txtCodArt.Text = dstipo.Tables(0).Rows(0).Item("codigo_articulo")
                txtDescArt.Text = dstipo.Tables(0).Rows(0).Item("descripcion")
                txtIV.Text = Format(dstipo.Tables(0).Rows(0).Item("impuesto_ventas"), "##.00")
                dtpUltEnt.Text = dstipo.Tables(0).Rows(0).Item("fecha_ultima_entrada")
                dtpUltSalida.Text = dstipo.Tables(0).Rows(0).Item("fecha_ultima_salida")
                txtCostPromAct.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_prom_act"), "##.00")
                txtCostPromAnt.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_prom_ant"), "##.00")
                txtCostUltEntAct.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_ult_ent_act"), "##.00")
                txtCostUltEntAnt.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_ult_ent_ant"), "##.00")
                txtCodUM.Text = dstipo.Tables(0).Rows(0).Item("codigo_unidad_medida")
                bnFirst.Enabled = True
                bnPrev.Enabled = True
                bnNext.Enabled = True
                bnLast.Enabled = True
                bnNext.Enabled = True
                bnRefresh.Enabled = True
                bnDelete.Enabled = True
                Cambios = False
                txtCodArt.Focus()
                txtCodArt.SelectAll()
                Desp = True
            Else
                'bnClear.PerformClick()
            End If
        Catch ex As SqlException
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Siguiente artículo", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
        If Desp Then
            Desp_UMDesc()
        End If
    End Sub

    Private Sub bnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnLast.Click
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet
        Dim Desp As Boolean = False

        bnClear.PerformClick()

        Try
            cDemo.ConnectionString = strconexion
            cDemo.Open()

            datipo = New SqlDataAdapter("select * from ARTICULO where codigo_articulo = (Select max(codigo_articulo) from ARTICULO) order by codigo_articulo ASC", cDemo)
            datipo.Fill(dstipo)

            If dstipo.Tables(0).Rows.Count > 0 Then
                txtCodArt.Text = dstipo.Tables(0).Rows(0).Item("codigo_articulo")
                txtDescArt.Text = dstipo.Tables(0).Rows(0).Item("descripcion")
                txtIV.Text = Format(dstipo.Tables(0).Rows(0).Item("impuesto_ventas"), "##.00")
                dtpUltEnt.Text = dstipo.Tables(0).Rows(0).Item("fecha_ultima_entrada")
                dtpUltSalida.Text = dstipo.Tables(0).Rows(0).Item("fecha_ultima_salida")
                txtCostPromAct.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_prom_act"), "##.00")
                txtCostPromAnt.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_prom_ant"), "##.00")
                txtCostUltEntAct.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_ult_ent_act"), "##.00")
                txtCostUltEntAnt.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_ult_ent_ant"), "##.00")
                txtCodUM.Text = dstipo.Tables(0).Rows(0).Item("codigo_unidad_medida")
                bnFirst.Enabled = True
                bnPrev.Enabled = True
                bnNext.Enabled = True
                bnLast.Enabled = True
                bnNext.Enabled = True
                bnRefresh.Enabled = True
                bnDelete.Enabled = True
                Cambios = False
                txtCodArt.Focus()
                txtCodArt.SelectAll()
                Desp = True
            Else
                bnClear.PerformClick()
            End If
        Catch ex As SqlException
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Ultimo Artículo", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
        If Desp Then
            Desp_UMDesc()
        End If
    End Sub

    Private Sub bnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnPrev.Click
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet
        Dim Desp As Boolean = False

        Try
            cDemo.ConnectionString = strconexion
            cDemo.Open()
            datipo = New SqlDataAdapter("SELECT TOP 1 * FROM ARTICULO where codigo_articulo < '" + txtCodArt.Text + "' order by codigo_articulo DESC", cDemo)

            datipo.Fill(dstipo)

            If dstipo.Tables(0).Rows.Count > 0 Then
                txtCodArt.Text = dstipo.Tables(0).Rows(0).Item("codigo_articulo")
                txtDescArt.Text = dstipo.Tables(0).Rows(0).Item("descripcion")
                txtIV.Text = Format(dstipo.Tables(0).Rows(0).Item("impuesto_ventas"), "##.00")
                dtpUltEnt.Text = dstipo.Tables(0).Rows(0).Item("fecha_ultima_entrada")
                dtpUltSalida.Text = dstipo.Tables(0).Rows(0).Item("fecha_ultima_salida")
                txtCostPromAct.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_prom_act"), "##.00")
                txtCostPromAnt.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_prom_ant"), "##.00")
                txtCostUltEntAct.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_ult_ent_act"), "##.00")
                txtCostUltEntAnt.Text = Format(dstipo.Tables(0).Rows(0).Item("costo_ult_ent_ant"), "##.00")
                txtCodUM.Text = dstipo.Tables(0).Rows(0).Item("codigo_unidad_medida")
                bnFirst.Enabled = True
                bnPrev.Enabled = True
                bnNext.Enabled = True
                bnLast.Enabled = True
                bnNext.Enabled = True
                bnRefresh.Enabled = True
                bnDelete.Enabled = True
                Cambios = False
                txtCodArt.Focus()
                txtCodArt.SelectAll()
                Desp = True
            Else
                'bnClear.PerformClick()
            End If
        Catch ex As SqlException
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Articulo Anterior", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
        If Desp Then
            Desp_UMDesc()
        End If
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
                .Parameters.Add("@codigo_articulo", SqlDbType.VarChar)
                .Parameters.Add("@descripcion", SqlDbType.VarChar)
                .Parameters.Add("@impuesto_ventas", SqlDbType.Float)
                .Parameters.Add("@fecha_ultima_entrada", SqlDbType.DateTime)
                .Parameters.Add("@fecha_ultima_salida", SqlDbType.DateTime)
                .Parameters.Add("@costo_prom_act", SqlDbType.Float)
                .Parameters.Add("@costo_prom_ant", SqlDbType.Float)
                .Parameters.Add("@costo_ult_ent_act", SqlDbType.Float)
                .Parameters.Add("@costo_ult_ent_ant", SqlDbType.Float)
                .Parameters.Add("@codigo_unidad_medida", SqlDbType.VarChar)
                .Parameters("@codigo_articulo").Value = txtCodArt.Text
                .Parameters("@descripcion").Value = txtDescArt.Text
                .Parameters("@impuesto_ventas").Value = Convert.ToDouble(txtIV.Text)
                .Parameters("@fecha_ultima_entrada").Value = dtpUltEnt.Text
                .Parameters("@fecha_ultima_salida").Value = dtpUltSalida.Text
                .Parameters("@costo_prom_act").Value = Convert.ToDouble(txtCostPromAct.Text)
                .Parameters("@costo_prom_ant").Value = Convert.ToDouble(txtCostPromAnt.Text)
                .Parameters("@costo_ult_ent_act").Value = Convert.ToDouble(txtCostUltEntAct.Text)
                .Parameters("@costo_ult_ent_ant").Value = Convert.ToDouble(txtCostUltEntAnt.Text)
                .Parameters("@codigo_unidad_medida").Value = txtCodUM.Text
                .CommandText = "sp_Modificar_Articulo"
                .CommandType = CommandType.StoredProcedure
                .Transaction = cTransa
            End With

            datipo = New SqlDataAdapter
            datipo.SelectCommand = cmdtipo
            datipo.Fill(dstipo, "MODIFICAARTICULO")
            cTransa.Commit()

            txtCodArt.SelectAll()
            txtCodArt.Focus()
            Cambios = False
            'MessageBox.Show("Unidad de Medida insertada", "QUITAR MENSAJE", MessageBoxButtons.OK)
        Catch ex As SqlException
            cTransa.Rollback()
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Modificar artículo", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
    End Sub

    Private Sub txtCodArt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodArt.KeyUp
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

    Private Sub FrmArticulo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resul As MsgBoxResult
        If Cambios Then
            resul = MessageBox.Show("Cambios sin guardar. Desea guardarlos?", "Cerrando", MessageBoxButtons.YesNoCancel)

            If resul = MsgBoxResult.Cancel Then
                e.Cancel = True
            ElseIf resul = MsgBoxResult.Yes Then
                bnSave.PerformClick()
            End If
        End If
    End Sub

    Private Sub txtCodUM_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodUM.Validating
        Desp_UMDesc()
    End Sub
End Class