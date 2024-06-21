<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Button7 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(7, 7)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(616, 685)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(64), CByte(45), CByte(29))
        Panel2.BackgroundImage = My.Resources.Resources.Recurso_1
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button4)
        Panel2.Location = New Point(17, 22)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(582, 35)
        Panel2.TabIndex = 10
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button5.BackgroundImage = My.Resources.Resources.Icono_Minimizar
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(526, 5)
        Button5.Name = "Button5"
        Button5.Size = New Size(25, 25)
        Button5.TabIndex = 10
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button4.BackgroundImage = My.Resources.Resources.Icono_cerrar_FN
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(553, 5)
        Button4.Name = "Button4"
        Button4.Size = New Size(25, 25)
        Button4.TabIndex = 9
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = My.Resources.Resources.Recurso_1
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Info
        Button1.Location = New Point(79, 554)
        Button1.Name = "Button1"
        Button1.Size = New Size(431, 112)
        Button1.TabIndex = 9
        Button1.Text = "Eliminar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
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
        DataGridView1.Location = New Point(17, 63)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(582, 481)
        DataGridView1.TabIndex = 8
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
        Button7.Location = New Point(551, 622)
        Button7.Name = "Button7"
        Button7.Size = New Size(44, 44)
        Button7.TabIndex = 11
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(144), CByte(115), CByte(73))
        ClientSize = New Size(630, 698)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button7 As Button
End Class
