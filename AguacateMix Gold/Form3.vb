Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Public Class Form3
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\AguacateMixGold\AguacateMixGold-Database.mdf;Integrated Security=false"

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form1 As New Form1()
        form1.Show()
    End Sub


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




    Private Sub Mostrar2()
        Dim query As String = "SELECT TOP 0 Plato, Ingredientes, Precio FROM Platos WHERE Categoria = 'Hamburguesas'"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView2.DataSource = table
        End Using
        DataGridView2.Columns(0).Width = 130
        DataGridView2.Columns(1).Width = 200
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.Height = 60
        Next

        For Each column As DataGridViewColumn In DataGridView2.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarSumaPrecios()

        Mostrar2()

        Label3.Visible = False
        Label5.Visible = False
        TextBox1.Visible = False
        TextBox1.Text = "0"
    End Sub




    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

            Dim plato As String = DataGridView2.Rows(e.RowIndex).Cells("Plato").Value.ToString()
            Dim precio As String = DataGridView2.Rows(e.RowIndex).Cells("Precio").Value.ToString()


            If Not String.IsNullOrWhiteSpace(plato) AndAlso Not String.IsNullOrWhiteSpace(precio) Then

                Dim newRow As DataGridViewRow = DataGridView1.Rows(DataGridView1.Rows.Add())
                newRow.Cells("Plato").Value = plato
                newRow.Cells("Precio").Value = precio

            End If
        End If
        ActualizarSumaPrecios()
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If DataGridView1.Rows.Count >= 2 Then

            Dim index As Integer = DataGridView1.Rows.Count - 2
            DataGridView1.Rows.RemoveAt(index)
        End If
        ActualizarSumaPrecios()
    End Sub


    Private Sub ActualizarSumaPrecios()

        Dim totalPrecio As Decimal = 0

        For Each row As DataGridViewRow In DataGridView1.Rows

            If Not row.Cells("Precio").Value Is Nothing AndAlso Not String.IsNullOrEmpty(row.Cells("Precio").Value.ToString()) Then

                Dim precio As Decimal
                If Decimal.TryParse(row.Cells("Precio").Value.ToString(), precio) Then
                    totalPrecio += precio
                End If
            End If
        Next

        Label2.Text = totalPrecio.ToString()
    End Sub
    Dim Pago As String

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click




        If Pago = "" Then
            MessageBox.Show("Seleccione el metodo de pago.")
        Else

            If Pago = "Efectivo" Then

                Dim valorTotal As Integer = Integer.Parse(Label2.Text)
                Dim valorPago As Integer = Integer.Parse(TextBox1.Text)

                If valorPago < valorTotal Then
                    MessageBox.Show("El dinero no es suficiente para realizar la compra.")
                Else

                    If Label2.Text = "" Then
                        MessageBox.Show("No Hay nada seleccionado para la venta.")
                    Else
                        Dim platos As New Dictionary(Of String, Tuple(Of Integer, Integer))

                        Dim fechaActual As DateTime = DateTime.Now

                        For Each row As DataGridViewRow In DataGridView1.Rows
                            If Not row.IsNewRow Then
                                Dim plato As String = row.Cells("Plato").Value.ToString()
                                Dim precio As Integer = Convert.ToInt32(row.Cells("Precio").Value)

                                If platos.ContainsKey(plato) Then
                                    Dim cantidad As Integer = platos(plato).Item1 + 1
                                    Dim precioAcumulado As Integer = platos(plato).Item2 + precio
                                    platos(plato) = New Tuple(Of Integer, Integer)(cantidad, precioAcumulado)
                                Else
                                    platos.Add(plato, New Tuple(Of Integer, Integer)(1, precio))
                                End If
                            End If
                        Next

                        Using connection As New SqlConnection(connectionString)
                            connection.Open()
                            Dim transaction As SqlTransaction = connection.BeginTransaction()
                            Try
                                For Each kvp As KeyValuePair(Of String, Tuple(Of Integer, Integer)) In platos
                                    Dim plato As String = kvp.Key
                                    Dim cantidad As Integer = kvp.Value.Item1
                                    Dim precio As Integer = kvp.Value.Item2

                                    Dim query As String = "INSERT INTO Historial (Plato, Precio, Cantidad, Pago, Fecha) VALUES (@Plato, @Precio, @Cantidad, @Pago, @Fecha)"
                                    Using command As New SqlCommand(query, connection, transaction)
                                        command.Parameters.AddWithValue("@Plato", plato)
                                        command.Parameters.AddWithValue("@Precio", precio)
                                        command.Parameters.AddWithValue("@Cantidad", cantidad)
                                        command.Parameters.AddWithValue("@Pago", Pago)
                                        command.Parameters.AddWithValue("@Fecha", fechaActual)
                                        command.ExecuteNonQuery()
                                    End Using
                                Next

                                transaction.Commit()

                                MessageBox.Show("Venta realizada exitosamente.")
                                DataGridView1.Rows.Clear()
                                Label2.Text = "0"
                                TextBox1.Text = ""
                                Label5.Text = ""


                            Catch ex As Exception
                                transaction.Rollback()
                                MessageBox.Show("Error al insertar datos en el historial: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End Using
                    End If

                End If

            Else

                If Label2.Text = "" Then
                    MessageBox.Show("No Hay nada seleccionado para la venta.")
                Else
                    Dim platos As New Dictionary(Of String, Tuple(Of Integer, Integer))

                    Dim fechaActual As DateTime = DateTime.Now

                    For Each row As DataGridViewRow In DataGridView1.Rows
                        If Not row.IsNewRow Then
                            Dim plato As String = row.Cells("Plato").Value.ToString()
                            Dim precio As Integer = Convert.ToInt32(row.Cells("Precio").Value)

                            If platos.ContainsKey(plato) Then
                                Dim cantidad As Integer = platos(plato).Item1 + 1
                                Dim precioAcumulado As Integer = platos(plato).Item2 + precio
                                platos(plato) = New Tuple(Of Integer, Integer)(cantidad, precioAcumulado)
                            Else
                                platos.Add(plato, New Tuple(Of Integer, Integer)(1, precio))
                            End If
                        End If
                    Next

                    Using connection As New SqlConnection(connectionString)
                        connection.Open()
                        Dim transaction As SqlTransaction = connection.BeginTransaction()
                        Try
                            For Each kvp As KeyValuePair(Of String, Tuple(Of Integer, Integer)) In platos
                                Dim plato As String = kvp.Key
                                Dim cantidad As Integer = kvp.Value.Item1
                                Dim precio As Integer = kvp.Value.Item2

                                Dim query As String = "INSERT INTO Historial (Plato, Precio, Cantidad, Pago, Fecha) VALUES (@Plato, @Precio, @Cantidad, @Pago, @Fecha)"
                                Using command As New SqlCommand(query, connection, transaction)
                                    command.Parameters.AddWithValue("@Plato", plato)
                                    command.Parameters.AddWithValue("@Precio", precio)
                                    command.Parameters.AddWithValue("@Cantidad", cantidad)
                                    command.Parameters.AddWithValue("@Pago", Pago)
                                    command.Parameters.AddWithValue("@Fecha", fechaActual)
                                    command.ExecuteNonQuery()
                                End Using
                            Next

                            transaction.Commit()

                            MessageBox.Show("Venta realizada exitosamente.")
                            DataGridView1.Rows.Clear()
                            Label2.Text = "0"
                            TextBox1.Text = ""
                            Label5.Text = ""


                        Catch ex As Exception
                            transaction.Rollback()
                            MessageBox.Show("Error al insertar datos en el historial: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End Using
                End If

            End If

        End If























    End Sub




    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Pago = "Tarjeta"
        Button12.BackColor = Color.LightBlue
        Button13.BackColor = Color.LightGray
        Button14.BackColor = Color.LightGray
        Button17.BackColor = Color.LightGray
        Button18.BackColor = Color.LightGray
        Button19.BackColor = Color.LightGray
        Label3.Visible = False
        Label5.Visible = False
        TextBox1.Visible = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Pago = "Efectivo"
        Button13.BackColor = Color.LightBlue
        Button12.BackColor = Color.LightGray
        Button14.BackColor = Color.LightGray
        Button17.BackColor = Color.LightGray
        Button18.BackColor = Color.LightGray
        Button19.BackColor = Color.LightGray
        Label3.Visible = True
        Label5.Visible = True
        TextBox1.Visible = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Pago = "Trasferencia"
        Button14.BackColor = Color.LightBlue
        Button13.BackColor = Color.LightGray
        Button12.BackColor = Color.LightGray
        Button17.BackColor = Color.LightGray
        Button18.BackColor = Color.LightGray
        Button19.BackColor = Color.LightGray
        Label3.Visible = False
        Label5.Visible = False
        TextBox1.Visible = False
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Pago = "Credito"
        Button14.BackColor = Color.LightGray
        Button13.BackColor = Color.LightGray
        Button12.BackColor = Color.LightGray
        Button17.BackColor = Color.LightGray
        Button18.BackColor = Color.LightGray
        Button19.BackColor = Color.LightBlue
        Label3.Visible = False
        Label5.Visible = False
        TextBox1.Visible = False
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Pago = "UBER EATS"
        Button14.BackColor = Color.LightGray
        Button13.BackColor = Color.LightGray
        Button12.BackColor = Color.LightGray
        Button17.BackColor = Color.LightGray
        Button18.BackColor = Color.LightBlue
        Button19.BackColor = Color.LightGray
        Label3.Visible = False
        Label5.Visible = False
        TextBox1.Visible = False
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Pago = "Pedidos ya"
        Button14.BackColor = Color.LightGray
        Button13.BackColor = Color.LightGray
        Button12.BackColor = Color.LightGray
        Button17.BackColor = Color.LightBlue
        Button18.BackColor = Color.LightGray
        Button19.BackColor = Color.LightGray
        Label3.Visible = False
        Label5.Visible = False
        TextBox1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim query = "SELECT Plato, Ingredientes, Precio FROM Platos WHERE Categoria = 'hamburguesas'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView2.DataSource = table
        End Using
        DataGridView2.Columns(0).Width = 130
        DataGridView2.Columns(1).Width = 200
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.Height = 60
        Next

        For Each column As DataGridViewColumn In DataGridView2.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query = "SELECT Plato, Ingredientes, Precio FROM Platos WHERE Categoria = 'Churrascos'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView2.DataSource = table
        End Using
        DataGridView2.Columns(0).Width = 130
        DataGridView2.Columns(1).Width = 200
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.Height = 60
        Next

        For Each column As DataGridViewColumn In DataGridView2.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query = "SELECT Plato, Ingredientes, Precio FROM Platos WHERE Categoria = 'Completos'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView2.DataSource = table
        End Using
        DataGridView2.Columns(0).Width = 130
        DataGridView2.Columns(1).Width = 200
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.Height = 60
        Next

        For Each column As DataGridViewColumn In DataGridView2.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim query = "SELECT Plato, Ingredientes, Precio FROM Platos WHERE Categoria = 'Ass'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView2.DataSource = table
        End Using
        DataGridView2.Columns(0).Width = 130
        DataGridView2.Columns(1).Width = 200
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.Height = 60
        Next

        For Each column As DataGridViewColumn In DataGridView2.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim query = "SELECT Plato, Ingredientes, Precio FROM Platos WHERE Categoria = 'Fajitas'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView2.DataSource = table
        End Using
        DataGridView2.Columns(0).Width = 130
        DataGridView2.Columns(1).Width = 200
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.Height = 60
        Next

        For Each column As DataGridViewColumn In DataGridView2.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim query = "SELECT Plato, Ingredientes, Precio FROM Platos WHERE Categoria = 'Papas fritas'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView2.DataSource = table
        End Using
        DataGridView2.Columns(0).Width = 130
        DataGridView2.Columns(1).Width = 200
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.Height = 60
        Next

        For Each column As DataGridViewColumn In DataGridView2.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim query = "SELECT Plato, Ingredientes, Precio FROM Platos WHERE Categoria = 'Handrolls'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView2.DataSource = table
        End Using
        DataGridView2.Columns(0).Width = 130
        DataGridView2.Columns(1).Width = 200
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.Height = 60
        Next

        For Each column As DataGridViewColumn In DataGridView2.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim query As String = "SELECT Plato, Ingredientes, Precio FROM Platos WHERE Categoria = 'Bebestibles'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView2.DataSource = table
        End Using
        DataGridView2.Columns(0).Width = 130
        DataGridView2.Columns(1).Width = 200
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.Height = 60
        Next

        For Each column As DataGridViewColumn In DataGridView2.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim query As String = "SELECT Plato, Ingredientes, Precio FROM Platos WHERE Categoria = 'Agregados'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView2.DataSource = table
        End Using
        DataGridView2.Columns(0).Width = 130
        DataGridView2.Columns(1).Width = 200
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.Height = 60
        Next

        For Each column As DataGridViewColumn In DataGridView2.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim valorTotal As Integer = Integer.Parse(Label2.Text)
            Dim valorPago As Integer = Integer.Parse(TextBox1.Text)

            If valorPago < valorTotal Then
                Dim diferencia As Integer = valorTotal - valorPago
                Label5.Text = "Faltan $" & diferencia.ToString()
            Else
                Dim cambio As Integer = valorPago - valorTotal
                Label5.Text = "Cambio: $" & cambio.ToString()
            End If
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Close()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim rutaVideo As String = "C:\AguacateMixGold\Videos-ayuda\Form3.mp4"

        If System.IO.File.Exists(rutaVideo) Then

            Process.Start(New ProcessStartInfo() With {.FileName = rutaVideo, .UseShellExecute = True})
        Else

            MessageBox.Show("El archivo de video no se encuentra en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class