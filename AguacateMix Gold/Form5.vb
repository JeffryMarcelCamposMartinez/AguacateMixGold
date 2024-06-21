Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Diagnostics

Public Class Form5
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\AguacateMixGold\AguacateMixGold-Database.mdf;Integrated Security=True"

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 130
        DataGridView1.Columns(3).Width = 60

        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
    End Sub

    Private Sub Mostrar()
        Dim query As String = "SELECT * FROM Inventario"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("No se pueden dejar casillas sin rellenar.")
        Else
            Dim id As String = TextBox1.Text
            Dim ingrediente As String = TextBox2.Text
            Dim cantidad As String = TextBox3.Text
            Dim medida As String = ComboBox1.Text

            If Not IdExiste(id) Then
                Dim query As String = "INSERT INTO Inventario (id, Ingrediente, Cantidades, Medida) VALUES (@id, @Ingrediente, @Cantidades, @Medida)"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@id", id)
                        command.Parameters.AddWithValue("@Ingrediente", ingrediente)
                        command.Parameters.AddWithValue("@Cantidades", cantidad)
                        command.Parameters.AddWithValue("@Medida", medida)

                        Try
                            connection.Open()
                            command.ExecuteNonQuery()
                            MessageBox.Show("Datos insertados correctamente en la tabla Inventario.")
                            Mostrar()
                        Catch ex As Exception
                            MessageBox.Show("Error al insertar datos en la tabla Inventario: " & ex.Message)
                        End Try
                    End Using
                End Using
            Else
                MessageBox.Show("El ID ya existe en la base de datos. No se pueden ingresar datos duplicados.")
            End If

            LimpiarCampos()
        End If
    End Sub

    Private Function IdExiste(id As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Inventario WHERE id = @id"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", id)
                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0
                Catch ex As Exception
                    MessageBox.Show("Error al verificar el ID en la base de datos: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Function IngredienteExiste(ingrediente As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Inventario WHERE id = @id"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", ingrediente)
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LimpiarCampos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim id As String = TextBox1.Text
            Dim ingrediente As String = TextBox2.Text
            Dim cantidad As String = TextBox3.Text
            Dim medida As String = ComboBox1.Text
            Dim query As String = "UPDATE Inventario SET Cantidades = @Cantidades, Medida = @Medida, Ingrediente = @Ingrediente WHERE id = @id"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", id)
                    command.Parameters.AddWithValue("@Ingrediente", ingrediente)
                    command.Parameters.AddWithValue("@Cantidades", cantidad)
                    command.Parameters.AddWithValue("@Medida", medida)

                    Try
                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Datos actualizados correctamente en la tabla Inventario.")
                            Mostrar()
                        Else
                            MessageBox.Show("No se encontró ningún ingrediente con el nombre especificado para actualizar.")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error al actualizar datos en la tabla Inventario: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Seleccione una fila para actualizar.")
        End If
    End Sub

    Private Sub Form5_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form1 As New Form1()
        Form6.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim id As String = TextBox1.Text

            Dim query As String = "DELETE FROM Inventario WHERE id = @id"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", id)

                    Try
                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("El ingrediente se ha eliminado correctamente de la tabla Inventario.")
                            Mostrar()
                        Else
                            MessageBox.Show("No se encontró ningún ingrediente con el nombre especificado para eliminar.")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error al eliminar el ingrediente de la tabla Inventario: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Seleccione una fila para eliminar.")
        End If
    End Sub

    Private Sub LimpiarCampos()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim rutaVideo As String = "C:\AguacateMixGold\Videos-ayuda\Form5.mp4"

        If System.IO.File.Exists(rutaVideo) Then
            Process.Start(New ProcessStartInfo() With {.FileName = rutaVideo, .UseShellExecute = True})
        Else
            MessageBox.Show("El archivo de video no se encuentra en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DataGridView1.SelectedRows(0)
            TextBox1.Text = filaSeleccionada.Cells("id").Value.ToString()
            TextBox2.Text = filaSeleccionada.Cells("Ingrediente").Value.ToString()
            TextBox3.Text = filaSeleccionada.Cells("Cantidades").Value.ToString()
            ComboBox1.Text = filaSeleccionada.Cells("Medida").Value.ToString()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class