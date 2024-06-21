<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        HScrollBar1 = New HScrollBar()
        Panel5 = New Panel()
        Button3 = New Button()
        Panel3 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        NumericUpDown1 = New NumericUpDown()
        TextBox2 = New TextBox()
        Panel2 = New Panel()
        Button5 = New Button()
        Button6 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.MaderaFondo2
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(HScrollBar1)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(12, 54)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(776, 473)
        Panel1.TabIndex = 0
        ' 
        ' HScrollBar1
        ' 
        HScrollBar1.Location = New Point(36, 152)
        HScrollBar1.Name = "HScrollBar1"
        HScrollBar1.Size = New Size(706, 17)
        HScrollBar1.TabIndex = 7
        ' 
        ' Panel5
        ' 
        Panel5.Location = New Point(36, 11)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(706, 135)
        Panel5.TabIndex = 6
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = My.Resources.Resources.Recurso_1
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Image = My.Resources.Resources.Recurso_1
        Button3.Location = New Point(36, 376)
        Button3.Name = "Button3"
        Button3.Size = New Size(706, 77)
        Button3.TabIndex = 5
        Button3.Text = "Ingresar nuevos productos a inventario"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = My.Resources.Resources.Recurso_1
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(NumericUpDown1)
        Panel3.Controls.Add(TextBox2)
        Panel3.Location = New Point(154, 176)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(485, 182)
        Panel3.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(256, 33)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 17)
        Label4.TabIndex = 8
        Label4.Text = "Cantidad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(163, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 17)
        Label3.TabIndex = 7
        Label3.Text = "Producto"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(62, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 17)
        Label2.TabIndex = 6
        Label2.Text = "Codigo "
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Image = My.Resources.Resources.Recurso_1
        Button2.Location = New Point(244, 116)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 36)
        Button2.TabIndex = 5
        Button2.Text = "Retiro"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources.Recurso_1
        Button1.Location = New Point(163, 116)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 36)
        Button1.TabIndex = 4
        Button1.Text = "Ingresar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(366, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 32)
        Label1.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(38, 63)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(250, 63)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(72, 23)
        NumericUpDown1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(144, 63)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.Recurso_1
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button6)
        Panel2.Location = New Point(15, 6)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(773, 42)
        Panel2.TabIndex = 1
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button5.BackgroundImage = My.Resources.Resources.Icono_Minimizar
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(705, 9)
        Button5.Name = "Button5"
        Button5.Size = New Size(25, 25)
        Button5.TabIndex = 10
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button6.BackgroundImage = My.Resources.Resources.Icono_cerrar_FN
        Button6.BackgroundImageLayout = ImageLayout.Stretch
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(736, 9)
        Button6.Name = "Button6"
        Button6.Size = New Size(25, 25)
        Button6.TabIndex = 9
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.FromArgb(CByte(144), CByte(115), CByte(73))
        ClientSize = New Size(800, 539)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form6"
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents HScrollBar1 As HScrollBar
End Class
