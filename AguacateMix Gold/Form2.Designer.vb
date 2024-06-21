<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Button5 = New Button()
        Button6 = New Button()
        Panel2 = New Panel()
        Button7 = New Button()
        ComboBox1 = New ComboBox()
        Button4 = New Button()
        Label1 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(45), CByte(29))
        Panel1.BackgroundImage = My.Resources.Resources.Recurso_1
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button6)
        Panel1.Location = New Point(6, 7)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1132, 35)
        Panel1.TabIndex = 15
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button5.BackgroundImage = My.Resources.Resources.Icono_Minimizar
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(1054, 5)
        Button5.Name = "Button5"
        Button5.Size = New Size(25, 25)
        Button5.TabIndex = 8
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button6.BackgroundImage = My.Resources.Resources.Icono_cerrar_FN
        Button6.BackgroundImageLayout = ImageLayout.Stretch
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(1085, 5)
        Button6.Name = "Button6"
        Button6.Size = New Size(25, 25)
        Button6.TabIndex = 7
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Button7)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Location = New Point(6, 45)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1132, 694)
        Panel2.TabIndex = 30
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), Image)
        Button7.BackgroundImageLayout = ImageLayout.Zoom
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button7.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button7.FlatStyle = FlatStyle.Flat
        Button7.ForeColor = Color.Transparent
        Button7.Location = New Point(1068, 634)
        Button7.Name = "Button7"
        Button7.Size = New Size(44, 44)
        Button7.TabIndex = 0
        Button7.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Hamburguesas", "Churrascos", "Completos", "Ass", "Fajitas", "Papas fritas", "Handrolls", "Bebestibles", "Agregados"})
        ComboBox1.Location = New Point(1012, 59)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(100, 23)
        ComboBox1.TabIndex = 42
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.BackgroundImage = My.Resources.Resources.Recurso_1
        Button4.BackgroundImageLayout = ImageLayout.None
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button4.ForeColor = SystemColors.Info
        Button4.Location = New Point(999, 88)
        Button4.Name = "Button4"
        Button4.Size = New Size(113, 36)
        Button4.TabIndex = 41
        Button4.Text = "Eliminar"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Black", 9F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Info
        Label1.Location = New Point(645, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 17)
        Label1.TabIndex = 34
        Label1.Text = "Platos"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImage = My.Resources.Resources.Recurso_1
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.Info
        Button3.Location = New Point(866, 88)
        Button3.Name = "Button3"
        Button3.Size = New Size(113, 36)
        Button3.TabIndex = 40
        Button3.Text = "Actualizar"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = My.Resources.Resources.Recurso_1
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.Info
        Button2.Location = New Point(732, 87)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 36)
        Button2.TabIndex = 39
        Button2.Text = "Nuevo"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = My.Resources.Resources.Recurso_1
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.Info
        Button1.Location = New Point(598, 87)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 36)
        Button1.TabIndex = 38
        Button1.Text = "Ingresar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Black", 9F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.Info
        Label4.Location = New Point(1027, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 17)
        Label4.TabIndex = 37
        Label4.Text = "Categoria"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Arial Black", 9F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Info
        Label3.Location = New Point(934, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 17)
        Label3.TabIndex = 36
        Label3.Text = "Precio"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial Black", 9F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Info
        Label2.Location = New Point(770, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 17)
        Label2.TabIndex = 35
        Label2.Text = "Ingredientes"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(906, 59)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 33
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(731, 58)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(169, 23)
        TextBox2.TabIndex = 32
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(598, 58)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(127, 23)
        TextBox1.TabIndex = 31
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.None
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Location = New Point(21, 32)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(571, 631)
        DataGridView1.TabIndex = 30
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(144), CByte(115), CByte(73))
        ClientSize = New Size(1144, 747)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Platos registrados"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button7 As Button
End Class
