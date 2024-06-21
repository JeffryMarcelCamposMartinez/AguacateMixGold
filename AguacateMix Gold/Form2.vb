Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Public Class Form2

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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load





        Anchos()
        Mostrar()
        DataGridView1.Columns(0).Width = 130
        DataGridView1.Columns(1).Width = 200


        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
    End Sub
    Private Sub Mostrar()
        Dim query As String = "SELECT * FROM Platos"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub

    Private Sub Anchos()
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Height = 60
        Next
    End Sub
    Private Sub Blanco()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
    End Sub


    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        If DataGridView1.SelectedRows.Count > 0 Then

            Dim filaSeleccionada As DataGridViewRow = DataGridView1.SelectedRows(0)

            TextBox1.Text = filaSeleccionada.Cells("Plato").Value.ToString()
            TextBox2.Text = filaSeleccionada.Cells("Ingredientes").Value.ToString()
            TextBox3.Text = filaSeleccionada.Cells("Precio").Value.ToString()
            ComboBox1.Text = filaSeleccionada.Cells("Categoria").Value.ToString()
        End If
        Anchos()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("No se pueden dejar casillas sin rellenar.")
        Else
            Dim plato As String = TextBox1.Text
            Dim ingredientes As String = TextBox2.Text
            Dim precio As Integer = Integer.Parse(TextBox3.Text)
            Dim categoria As String = ComboBox1.Text


            Dim platoExistente As Boolean = False
            Dim query As String = "SELECT COUNT(*) FROM Platos WHERE Plato = @Plato"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Plato", plato)

                    Try
                        connection.Open()
                        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                        platoExistente = count > 0
                    Catch ex As Exception
                        MessageBox.Show("Error al verificar el plato en la base de datos: " & ex.Message)
                    End Try
                End Using
            End Using

            If Not platoExistente Then
                query = "INSERT INTO Platos (Plato, Ingredientes, Precio, Categoria) VALUES (@Plato, @Ingredientes, @Precio, @Categoria)"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Plato", plato)
                        command.Parameters.AddWithValue("@Ingredientes", ingredientes)
                        command.Parameters.AddWithValue("@Precio", precio)
                        command.Parameters.AddWithValue("@Categoria", categoria)

                        Try
                            connection.Open()
                            command.ExecuteNonQuery()
                            MessageBox.Show("Datos insertados correctamente en la tabla Platos.")
                            Mostrar()
                        Catch ex As Exception
                            MessageBox.Show("Error al insertar datos en la tabla Platos: " & ex.Message)
                        End Try
                    End Using
                End Using
                Blanco()
                Anchos()
            Else
                MessageBox.Show("El plato ya existe en la base de datos. Por favor, ingresa un plato diferente.")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Blanco()
        Anchos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("No se pueden dejar casillas sin rellenar.")
        Else
            Dim plato As String = TextBox1.Text
            Dim ingredientes As String = TextBox2.Text
            Dim precio As Integer = Integer.Parse(TextBox3.Text)
            Dim categoria As String = ComboBox1.Text

            Dim query As String = "UPDATE Platos SET Ingredientes = @Ingredientes, Precio = @Precio, Categoria = @Categoria WHERE Plato = @Plato"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)

                    command.Parameters.AddWithValue("@Plato", plato)
                    command.Parameters.AddWithValue("@Ingredientes", ingredientes)
                    command.Parameters.AddWithValue("@Precio", precio)
                    command.Parameters.AddWithValue("@Categoria", categoria)

                    Try
                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Datos actualizados correctamente en la tabla Platos.")
                            Mostrar()
                        Else
                            MessageBox.Show("No se encontró ningún plato con el nombre especificado para actualizar.")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error al actualizar datos en la tabla Platos: " & ex.Message)
                    End Try
                End Using
            End Using
            Anchos()

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("No se pueden dejar casillas sin rellenar.")
        Else
            Dim plato = TextBox1.Text

            Dim query = "DELETE FROM Platos WHERE Plato = @Plato"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)

                    command.Parameters.AddWithValue("@Plato", plato)

                    Try
                        connection.Open()
                        Dim rowsAffected = command.ExecuteNonQuery
                        If rowsAffected > 0 Then
                            MessageBox.Show("El plato se ha eliminado correctamente de la tabla Platos.")
                            Mostrar()
                        Else
                            MessageBox.Show("No se encontró ningún plato con el nombre especificado para eliminar.")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error al eliminar el plato de la tabla Platos: " & ex.Message)
                    End Try
                End Using
            End Using

            Anchos()

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim rutaVideo As String = "C:\AguacateMixGold\Videos-ayuda\Form2.mp4"

        If System.IO.File.Exists(rutaVideo) Then

            Process.Start(New ProcessStartInfo() With {.FileName = rutaVideo, .UseShellExecute = True})
        Else

            MessageBox.Show("El archivo de video no se encuentra en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



End Class