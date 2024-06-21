<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        DataGridView1 = New DataGridView()
        Plato = New DataGridViewTextBoxColumn()
        Precio = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        DataGridView2 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Button11 = New Button()
        Button12 = New Button()
        Button13 = New Button()
        Button14 = New Button()
        Label3 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Panel1 = New Panel()
        Button15 = New Button()
        Button16 = New Button()
        Panel2 = New Panel()
        Button20 = New Button()
        Button17 = New Button()
        Button18 = New Button()
        Button19 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Plato, Precio})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Location = New Point(28, 89)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(226, 509)
        DataGridView1.TabIndex = 0
        ' 
        ' Plato
        ' 
        Plato.FillWeight = 130F
        Plato.HeaderText = "Plato"
        Plato.Name = "Plato"
        Plato.ReadOnly = True
        Plato.Width = 130
        ' 
        ' Precio
        ' 
        Precio.HeaderText = "Precio"
        Precio.Name = "Precio"
        Precio.ReadOnly = True
        Precio.Width = 56
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = My.Resources.Resources.Recurso_1
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(294, 19)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 100)
        Button1.TabIndex = 2
        Button1.Text = "Hamburguesas"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = My.Resources.Resources.Recurso_1
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(400, 19)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 100)
        Button2.TabIndex = 3
        Button2.Text = "Churrascos"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImage = My.Resources.Resources.Recurso_1
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button3.ForeColor = Color.Transparent
        Button3.Location = New Point(506, 19)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 100)
        Button3.TabIndex = 4
        Button3.Text = "Completos"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.BackgroundImage = My.Resources.Resources.Recurso_1
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button4.ForeColor = Color.Transparent
        Button4.Location = New Point(612, 19)
        Button4.Name = "Button4"
        Button4.Size = New Size(100, 100)
        Button4.TabIndex = 5
        Button4.Text = "Ass"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.BackgroundImage = My.Resources.Resources.Recurso_1
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button5.ForeColor = Color.Transparent
        Button5.Location = New Point(718, 19)
        Button5.Name = "Button5"
        Button5.Size = New Size(100, 100)
        Button5.TabIndex = 6
        Button5.Text = "Fajitas"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.BackgroundImage = My.Resources.Resources.Recurso_1
        Button6.FlatStyle = FlatStyle.Popup
        Button6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button6.ForeColor = Color.Transparent
        Button6.Location = New Point(294, 125)
        Button6.Name = "Button6"
        Button6.Size = New Size(100, 100)
        Button6.TabIndex = 7
        Button6.Text = "Papas fritas"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.BackgroundImage = My.Resources.Resources.Recurso_1
        Button7.FlatStyle = FlatStyle.Popup
        Button7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button7.ForeColor = Color.Transparent
        Button7.Location = New Point(400, 125)
        Button7.Name = "Button7"
        Button7.Size = New Size(100, 100)
        Button7.TabIndex = 8
        Button7.Text = "Handrolls"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Transparent
        Button8.BackgroundImage = My.Resources.Resources.Recurso_1
        Button8.FlatStyle = FlatStyle.Popup
        Button8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button8.ForeColor = Color.Transparent
        Button8.Location = New Point(506, 125)
        Button8.Name = "Button8"
        Button8.Size = New Size(100, 100)
        Button8.TabIndex = 9
        Button8.Text = "Bebestibles"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Transparent
        Button9.BackgroundImage = My.Resources.Resources.Recurso_1
        Button9.FlatStyle = FlatStyle.Popup
        Button9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button9.ForeColor = Color.Transparent
        Button9.Location = New Point(612, 125)
        Button9.Name = "Button9"
        Button9.Size = New Size(100, 100)
        Button9.TabIndex = 10
        Button9.Text = "Agregados"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.Transparent
        Button10.BackgroundImage = My.Resources.Resources.Recurso_1
        Button10.FlatStyle = FlatStyle.Popup
        Button10.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button10.ForeColor = Color.Transparent
        Button10.Location = New Point(718, 125)
        Button10.Name = "Button10"
        Button10.Size = New Size(100, 100)
        Button10.TabIndex = 11
        Button10.Text = "Anular"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(859, 16)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle2
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(470, 582)
        DataGridView2.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(294, 420)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 32)
        Label1.TabIndex = 13
        Label1.Text = "Precio Total: $"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(482, 403)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 65)
        Label2.TabIndex = 14
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.Transparent
        Button11.BackgroundImage = My.Resources.Resources.Recurso_1
        Button11.FlatStyle = FlatStyle.Popup
        Button11.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button11.ForeColor = Color.Transparent
        Button11.Location = New Point(294, 498)
        Button11.Name = "Button11"
        Button11.Size = New Size(524, 100)
        Button11.TabIndex = 15
        Button11.Text = "Generar venta"
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Button12
        ' 
        Button12.BackColor = Color.Transparent
        Button12.BackgroundImage = My.Resources.Resources.Recurso_1
        Button12.FlatStyle = FlatStyle.Popup
        Button12.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button12.ForeColor = Color.Transparent
        Button12.Location = New Point(294, 260)
        Button12.Name = "Button12"
        Button12.Size = New Size(168, 23)
        Button12.TabIndex = 16
        Button12.Text = "Debito"
        Button12.UseVisualStyleBackColor = False
        ' 
        ' Button13
        ' 
        Button13.BackColor = Color.Transparent
        Button13.BackgroundImage = My.Resources.Resources.Recurso_1
        Button13.FlatStyle = FlatStyle.Popup
        Button13.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button13.ForeColor = Color.Transparent
        Button13.Location = New Point(471, 260)
        Button13.Name = "Button13"
        Button13.Size = New Size(168, 23)
        Button13.TabIndex = 17
        Button13.Text = "Efectivo"
        Button13.UseVisualStyleBackColor = False
        ' 
        ' Button14
        ' 
        Button14.BackColor = Color.Transparent
        Button14.BackgroundImage = My.Resources.Resources.Recurso_1
        Button14.FlatStyle = FlatStyle.Popup
        Button14.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button14.ForeColor = Color.Transparent
        Button14.Location = New Point(650, 260)
        Button14.Name = "Button14"
        Button14.Size = New Size(168, 23)
        Button14.TabIndex = 18
        Button14.Text = "Transferencia"
        Button14.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLight
        Label3.Location = New Point(467, 296)
        Label3.Name = "Label3"
        Label3.Size = New Size(185, 25)
        Label3.TabIndex = 20
        Label3.Text = "Con cuanto cancela"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(612, 322)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 21)
        Label5.TabIndex = 22
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(506, 321)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 19
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLight
        Label4.Location = New Point(78, 38)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 21)
        Label4.TabIndex = 24
        Label4.Text = "Lista de Venta"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(45), CByte(29))
        Panel1.BackgroundImage = My.Resources.Resources.Recurso_1
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Button15)
        Panel1.Controls.Add(Button16)
        Panel1.Location = New Point(7, 8)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1334, 35)
        Panel1.TabIndex = 25
        ' 
        ' Button15
        ' 
        Button15.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button15.BackgroundImage = My.Resources.Resources.Icono_Minimizar
        Button15.BackgroundImageLayout = ImageLayout.Stretch
        Button15.FlatStyle = FlatStyle.Flat
        Button15.Location = New Point(1277, 4)
        Button15.Name = "Button15"
        Button15.Size = New Size(25, 25)
        Button15.TabIndex = 8
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Button16
        ' 
        Button16.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button16.BackgroundImage = My.Resources.Resources.Icono_cerrar_FN
        Button16.BackgroundImageLayout = ImageLayout.Stretch
        Button16.FlatStyle = FlatStyle.Flat
        Button16.Location = New Point(1304, 4)
        Button16.Name = "Button16"
        Button16.Size = New Size(25, 25)
        Button16.TabIndex = 7
        Button16.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Button20)
        Panel2.Controls.Add(Button17)
        Panel2.Controls.Add(Button18)
        Panel2.Controls.Add(Button19)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(DataGridView2)
        Panel2.Controls.Add(Button14)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Button13)
        Panel2.Controls.Add(Button10)
        Panel2.Controls.Add(Button6)
        Panel2.Controls.Add(Button9)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Button12)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Button11)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button7)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button8)
        Panel2.Location = New Point(7, 52)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1334, 617)
        Panel2.TabIndex = 26
        ' 
        ' Button20
        ' 
        Button20.BackColor = Color.Transparent
        Button20.BackgroundImage = CType(resources.GetObject("Button20.BackgroundImage"), Image)
        Button20.BackgroundImageLayout = ImageLayout.Zoom
        Button20.FlatAppearance.BorderSize = 0
        Button20.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button20.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button20.FlatStyle = FlatStyle.Flat
        Button20.ForeColor = Color.Transparent
        Button20.Location = New Point(28, 16)
        Button20.Name = "Button20"
        Button20.Size = New Size(44, 44)
        Button20.TabIndex = 28
        Button20.UseVisualStyleBackColor = False
        ' 
        ' Button17
        ' 
        Button17.BackColor = Color.Transparent
        Button17.BackgroundImage = My.Resources.Resources.Recurso_1
        Button17.FlatStyle = FlatStyle.Popup
        Button17.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button17.ForeColor = Color.Transparent
        Button17.Location = New Point(650, 231)
        Button17.Name = "Button17"
        Button17.Size = New Size(168, 23)
        Button17.TabIndex = 27
        Button17.Text = "Pedidos ya"
        Button17.UseVisualStyleBackColor = False
        ' 
        ' Button18
        ' 
        Button18.BackColor = Color.Transparent
        Button18.BackgroundImage = My.Resources.Resources.Recurso_1
        Button18.FlatStyle = FlatStyle.Popup
        Button18.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button18.ForeColor = Color.Transparent
        Button18.Location = New Point(471, 231)
        Button18.Name = "Button18"
        Button18.Size = New Size(168, 23)
        Button18.TabIndex = 26
        Button18.Text = "UBER EATS"
        Button18.UseVisualStyleBackColor = False
        ' 
        ' Button19
        ' 
        Button19.BackColor = Color.Transparent
        Button19.BackgroundImage = My.Resources.Resources.Recurso_1
        Button19.FlatStyle = FlatStyle.Popup
        Button19.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button19.ForeColor = Color.Transparent
        Button19.Location = New Point(294, 231)
        Button19.Name = "Button19"
        Button19.Size = New Size(168, 23)
        Button19.TabIndex = 25
        Button19.Text = "Credito"
        Button19.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(144), CByte(115), CByte(73))
        ClientSize = New Size(1350, 677)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Plato As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
End Class
