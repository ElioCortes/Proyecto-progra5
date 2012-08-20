Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmConsUM
    Public CodSelect, DescSelect As String
    Public Sekecciona As Boolean = False

    Dim cDemo As New SqlConnection

    Private Sub frmConsUM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmdtipo As New SqlCommand
        Dim datipo As SqlDataAdapter
        Dim dstipo As New DataSet

        CodSelect = ""
        DescSelect = ""


        Try
            cDemo.ConnectionString = StrConexion
            cDemo.Open()

            With cmdtipo
                .Connection = cDemo
                .CommandText = "sp_Consulta_Todas_Bodegas"
                .CommandType = CommandType.StoredProcedure
            End With

            datipo = New SqlDataAdapter
            datipo.SelectCommand = cmdtipo
            datipo.Fill(dstipo, "CONSULTATODASBODEGAS")

            If dstipo.Tables(0).Rows.Count > 0 Then


            Else
                'mostrar mensaje de que no hay bodegas y cerrar
                Me.Close()
            End If

        Catch ex As SqlException
            MessageBox.Show("Codigo de error(" & ex.ErrorCode & "): " & ex.Message, "Insercion de Unidades de Medida", MessageBoxButtons.OK)
        Finally
            cDemo.Close()
        End Try
    End Sub

End Class