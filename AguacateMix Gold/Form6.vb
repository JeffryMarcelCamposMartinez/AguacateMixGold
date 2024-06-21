Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form6

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\AguacateMixGold\AguacateMixGold-Database.mdf;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub

    Private Sub Form6_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            Dim id As String = TextBox1.Text
            Dim query As String = "SELECT Ingrediente, Cantidades, Medida FROM Inventario WHERE id = @id"

            Try
                connection.Open()
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", id)
                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    TextBox2.Text = reader("Ingrediente").ToString()
                    Label1.Text = reader("Medida").ToString()
                Else
                    limpiar()
                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error al obtener los datos: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    Function limpiar()
        TextBox2.Text = ""
        NumericUpDown1.Text = "0"
        Label1.Text = ""
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            Dim id As String = TextBox1.Text
            Dim cantidad As Integer = Convert.ToInt32(NumericUpDown1.Value)

            Try
                connection.Open()
                Dim query As String = "UPDATE Inventario SET Cantidades = Cantidades + @cantidad WHERE id = @id"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@cantidad", cantidad)
                command.Parameters.AddWithValue("@id", id)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Cantidad actualizada correctamente.")
                Else
                    MessageBox.Show("No se encontró ningún registro con el ID proporcionado.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al actualizar la cantidad: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Por favor ingrese un ID.")
        End If
        TextBox1.Select()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form5 As New Form5()
        form5.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            Dim id As String = TextBox1.Text
            Dim cantidad As Integer = Convert.ToInt32(NumericUpDown1.Value)

            Try
                connection.Open()

                Dim queryCheck As String = "SELECT Cantidades FROM Inventario WHERE id = @id"
                Dim commandCheck As New SqlCommand(queryCheck, connection)
                commandCheck.Parameters.AddWithValue("@id", id)
                Dim cantidadActual As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

                If cantidad > cantidadActual Then
                    MessageBox.Show("No tiene suficiente stock para hacer un retiro.")
                Else
                    Dim queryUpdate As String = "UPDATE Inventario SET Cantidades = Cantidades - @cantidad WHERE id = @id"
                    Dim commandUpdate As New SqlCommand(queryUpdate, connection)
                    commandUpdate.Parameters.AddWithValue("@cantidad", cantidad)
                    commandUpdate.Parameters.AddWithValue("@id", id)
                    Dim rowsAffected As Integer = commandUpdate.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Cantidad actualizada correctamente.")
                    Else
                        MessageBox.Show("No se encontró ningún registro con el ID proporcionado.")
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("Error al actualizar la cantidad: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Por favor ingrese un ID.")
        End If
        TextBox1.Select()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown1.Minimum = 0
        NumericUpDown1.Maximum = 1000000
        TextBox1.Select()


        Try
            Dim query As String = "SELECT id, Ingrediente FROM Inventario"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()

                    Dim index As Integer = 0
                    Dim rowHeight As Integer = 40
                    Dim colWidth As Integer = 150
                    Dim buttonsPerRow As Integer = 3
                    Dim buttonsPerColumn As Integer = 3
                    Dim currentCol As Integer = 0
                    Dim currentRow As Integer = 0

                    While reader.Read()
                        Dim id As String = reader("id").ToString()
                        Dim ingrediente As String = reader("Ingrediente").ToString()


                        Dim x As Integer = currentCol * colWidth + 10
                        Dim y As Integer = currentRow * rowHeight + 10


                        Dim btn As New Button()
                        btn.Name = "BotonProducto" & index.ToString()
                        btn.Text = ingrediente
                        btn.Tag = id
                        btn.Width = colWidth
                        btn.Height = rowHeight
                        btn.Location = New Point(x, y)
                        btn.BackColor = Color.White
                        AddHandler btn.Click, AddressOf BotonProducto_Click
                        Panel5.Controls.Add(btn)

                        index += 1


                        currentRow += 1
                        If currentRow >= buttonsPerColumn Then
                            currentRow = 0
                            currentCol += 1
                        End If
                    End While

                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los botones: " & ex.Message)
        End Try
    End Sub

    Private Sub BotonProducto_Click(sender As Object, e As EventArgs)

        TextBox1.Text = ""
        Dim btn As Button = CType(sender, Button)
        TextBox1.Text = btn.Tag.ToString()
        TextBox1.Select()

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = True
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox1.Select()
    End Sub








End Class
