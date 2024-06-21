<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Button6 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(45), CByte(29))
        Panel1.BackgroundImage = My.Resources.Resources.Recurso_1
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Location = New Point(5, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(634, 35)
        Panel1.TabIndex = 6
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button5.BackgroundImage = My.Resources.Resources.Icono_Minimizar
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(578, 5)
        Button5.Name = "Button5"
        Button5.Size = New Size(25, 25)
        Button5.TabIndex = 8
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button4.BackgroundImage = My.Resources.Resources.Icono_cerrar_FN
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(605, 5)
        Button4.Name = "Button4"
        Button4.Size = New Size(25, 25)
        Button4.TabIndex = 7
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Location = New Point(310, 379)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 116)
        Button3.TabIndex = 28
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Location = New Point(158, 379)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 116)
        Button2.TabIndex = 27
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(19, 379)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 116)
        Button1.TabIndex = 26
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Button6)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(5, 45)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(634, 568)
        Panel2.TabIndex = 29
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.White
        Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), Image)
        Button6.BackgroundImageLayout = ImageLayout.Stretch
        Button6.Location = New Point(469, 379)
        Button6.Name = "Button6"
        Button6.Size = New Size(116, 116)
        Button6.TabIndex = 29
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(144), CByte(115), CByte(73))
        ClientSize = New Size(644, 618)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button6 As Button

End Class
