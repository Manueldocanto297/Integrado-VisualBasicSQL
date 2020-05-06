Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim conexion As MySqlConnection
        conexion = New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim ds As DataSet = New DataSet
        Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter

        conexion.ConnectionString = "server=localhost; database=encuesta; Uid=root; pwd=135790;"
        If (txtNombre.Text <> "") And (txtApellido.Text <> "") And (cboxSerie.Text <> "") Then
            Try
                conexion.Open()
                cmd.Connection = conexion

                cmd.CommandText = "INSERT INTO encuesta_series(nombre, apellido, serie_favorita) VALUES (@nombre, @apellido, @serie)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@apellido", txtApellido.Text)
                cmd.Parameters.AddWithValue("@serie", cboxSerie.Text)
                cmd.ExecuteNonQuery()

                conexion.Close()
                MsgBox("Se han registrado correctamente los datos")
                txtNombre.Clear()
                txtNombre.Focus()
                txtApellido.Clear()
                cboxSerie.SelectedIndex = -1
                cmd.CommandText = "SELECT * FROM encuesta_series ORDER BY id ASC"
                adaptador.SelectCommand = cmd
                adaptador.Fill(ds, "Tabla")
                grdEncuesta.DataSource = ds
                grdEncuesta.DataMember = "Tabla"

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Por favor rellene los datos necesarios")
        End If
    End Sub
End Class
