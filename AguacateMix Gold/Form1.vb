Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Diagnostics

Public Class Form1

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
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

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2 As New Form2
        AddHandler form2.Load, AddressOf FormCargado
        form2.Show
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form3 As New Form3()
        AddHandler form3.Load, AddressOf FormCargado
        form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form4 As New Form4()
        AddHandler form4.Load, AddressOf FormCargado
        form4.Show()
    End Sub

    Private Sub FormCargado(sender As Object, e As EventArgs)
        Dim formularioActual As Form = DirectCast(sender, Form)
        Me.Hide()
    End Sub

    Private Sub RedondearEsquinasButton(ByRef button As Button, ByVal radio As Integer)

        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radio * 2, radio * 2, 180, 90)
        path.AddLine(radio, 0, button.Width - radio, 0)
        path.AddArc(button.Width - radio * 2, 0, radio * 2, radio * 2, 270, 90)
        path.AddLine(button.Width, radio, button.Width, button.Height - radio)
        path.AddArc(button.Width - radio * 2, button.Height - radio * 2, radio * 2, radio * 2, 0, 90)
        path.AddLine(button.Width - radio, button.Height, radio, button.Height)
        path.AddArc(0, button.Height - radio * 2, radio * 2, radio * 2, 90, 90)
        path.AddLine(0, button.Height - radio, 0, radio)
        button.Region = New Region(path)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RedondearEsquinasButton(Button1, 60)
        RedondearEsquinasButton(Button2, 60)
        RedondearEsquinasButton(Button3, 60)
        RedondearEsquinasButton(Button6, 60)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim form6 As New Form6()
        AddHandler form6.Load, AddressOf FormCargado
        form6.Show()
    End Sub
End Class
