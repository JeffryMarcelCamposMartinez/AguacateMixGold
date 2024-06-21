Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Diagnostics
Public Class Form4


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



    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\AguacateMixGold\AguacateMixGold-Database.mdf;Integrated Security=false"
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mostrar()

    End Sub

    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Function mostrar()




        Dim query As String = "SELECT Plato, Precio, Cantidad, Pago, Fecha FROM Historial"


        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)


                DataGridView1.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error al cargar los datos de la tabla Historial: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        DataGridView1.Columns(0).Width = 130
    End Function

    Dim Plato As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Plato = "" Then
            MessageBox.Show("No tiene ventas o no ha seleccionado una venta de su historial.")
        Else
            Dim query = "DELETE FROM Historial WHERE Plato = @Plato"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)

                    command.Parameters.AddWithValue("@Plato", Plato)

                    Try
                        connection.Open()
                        Dim rowsAffected = command.ExecuteNonQuery
                        If rowsAffected > 0 Then
                            MessageBox.Show("Se borro correctamente registro del historial.")

                        Else
                            MessageBox.Show("No se encontró ningún plato con el nombre especificado para eliminar.")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error al eliminar el plato de la tabla Platos: " & ex.Message)
                    End Try
                End Using
            End Using
            mostrar()
        End If



    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count > 0 Then

            Dim filaSeleccionada = DataGridView1.SelectedRows(0)

            Plato = filaSeleccionada.Cells("Plato").Value.ToString

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim rutaVideo As String = "C:\AguacateMixGold\Videos-ayuda\Form4.mp4"

        If System.IO.File.Exists(rutaVideo) Then

            Process.Start(New ProcessStartInfo() With {.FileName = rutaVideo, .UseShellExecute = True})
        Else

            MessageBox.Show("El archivo de video no se encuentra en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class