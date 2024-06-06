<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Simulacion = New System.Windows.Forms.TabPage()
        Me.ParedIzquierda = New System.Windows.Forms.PictureBox()
        Me.Datos = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxX0 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxY0 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AnguloVelocidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MagnitudVelocidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IntervaloViento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Gravedad = New System.Windows.Forms.TextBox()
        Me.ParedDerecha = New System.Windows.Forms.PictureBox()
        Me.Techo = New System.Windows.Forms.PictureBox()
        Me.Piso = New System.Windows.Forms.PictureBox()
        Me.TabControl.SuspendLayout()
        Me.Simulacion.SuspendLayout()
        CType(Me.ParedIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParedDerecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Techo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Piso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.Simulacion)
        Me.TabControl.Controls.Add(Me.Datos)
        Me.TabControl.Location = New System.Drawing.Point(187, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(825, 541)
        Me.TabControl.TabIndex = 0
        '
        'Simulacion
        '
        Me.Simulacion.Controls.Add(Me.Piso)
        Me.Simulacion.Controls.Add(Me.Techo)
        Me.Simulacion.Controls.Add(Me.ParedDerecha)
        Me.Simulacion.Controls.Add(Me.ParedIzquierda)
        Me.Simulacion.Location = New System.Drawing.Point(4, 22)
        Me.Simulacion.Name = "Simulacion"
        Me.Simulacion.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.Simulacion.Size = New System.Drawing.Size(817, 515)
        Me.Simulacion.TabIndex = 0
        Me.Simulacion.Text = "Simulacion"
        Me.Simulacion.UseVisualStyleBackColor = True
        '
        'ParedIzquierda
        '
        Me.ParedIzquierda.BackColor = System.Drawing.Color.Black
        Me.ParedIzquierda.Location = New System.Drawing.Point(-19, 0)
        Me.ParedIzquierda.Name = "ParedIzquierda"
        Me.ParedIzquierda.Size = New System.Drawing.Size(20, 533)
        Me.ParedIzquierda.TabIndex = 0
        Me.ParedIzquierda.TabStop = False
        Me.ParedIzquierda.Visible = False
        '
        'Datos
        '
        Me.Datos.Location = New System.Drawing.Point(4, 23)
        Me.Datos.Name = "Datos"
        Me.Datos.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.Datos.Size = New System.Drawing.Size(817, 514)
        Me.Datos.TabIndex = 1
        Me.Datos.Text = "Datos"
        Me.Datos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 557)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Miguel Angel Alfonso Saavedra - 202012145"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 579)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(373, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Marco Antonio Vargas Garcia - 202015214"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 566)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hecho por:"
        '
        'TextBoxX0
        '
        Me.TextBoxX0.Location = New System.Drawing.Point(24, 67)
        Me.TextBoxX0.Name = "TextBoxX0"
        Me.TextBoxX0.Size = New System.Drawing.Size(132, 20)
        Me.TextBoxX0.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "X0:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Y0:"
        '
        'TextBoxY0
        '
        Me.TextBoxY0.Location = New System.Drawing.Point(24, 132)
        Me.TextBoxY0.Name = "TextBoxY0"
        Me.TextBoxY0.Size = New System.Drawing.Size(132, 20)
        Me.TextBoxY0.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Ángulo V"
        '
        'AnguloVelocidad
        '
        Me.AnguloVelocidad.Location = New System.Drawing.Point(24, 261)
        Me.AnguloVelocidad.Name = "AnguloVelocidad"
        Me.AnguloVelocidad.Size = New System.Drawing.Size(132, 20)
        Me.AnguloVelocidad.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "|V|"
        '
        'MagnitudVelocidad
        '
        Me.MagnitudVelocidad.Location = New System.Drawing.Point(24, 196)
        Me.MagnitudVelocidad.Name = "MagnitudVelocidad"
        Me.MagnitudVelocidad.Size = New System.Drawing.Size(132, 20)
        Me.MagnitudVelocidad.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Intervalo Viento (t')"
        '
        'IntervaloViento
        '
        Me.IntervaloViento.Location = New System.Drawing.Point(24, 392)
        Me.IntervaloViento.Name = "IntervaloViento"
        Me.IntervaloViento.Size = New System.Drawing.Size(132, 20)
        Me.IntervaloViento.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Gravedad"
        '
        'Gravedad
        '
        Me.Gravedad.Location = New System.Drawing.Point(24, 327)
        Me.Gravedad.Name = "Gravedad"
        Me.Gravedad.Size = New System.Drawing.Size(132, 20)
        Me.Gravedad.TabIndex = 12
        '
        'ParedDerecha
        '
        Me.ParedDerecha.BackColor = System.Drawing.Color.Black
        Me.ParedDerecha.Location = New System.Drawing.Point(816, 0)
        Me.ParedDerecha.Name = "ParedDerecha"
        Me.ParedDerecha.Size = New System.Drawing.Size(22, 533)
        Me.ParedDerecha.TabIndex = 1
        Me.ParedDerecha.TabStop = False
        Me.ParedDerecha.Visible = False
        '
        'Techo
        '
        Me.Techo.BackColor = System.Drawing.Color.Black
        Me.Techo.Location = New System.Drawing.Point(0, -29)
        Me.Techo.Name = "Techo"
        Me.Techo.Size = New System.Drawing.Size(821, 31)
        Me.Techo.TabIndex = 2
        Me.Techo.TabStop = False
        Me.Techo.Visible = False
        '
        'Piso
        '
        Me.Piso.BackColor = System.Drawing.Color.Black
        Me.Piso.Location = New System.Drawing.Point(0, 500)
        Me.Piso.Name = "Piso"
        Me.Piso.Size = New System.Drawing.Size(821, 31)
        Me.Piso.TabIndex = 3
        Me.Piso.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 604)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.IntervaloViento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Gravedad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AnguloVelocidad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MagnitudVelocidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxY0)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxX0)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulacion Movimineto Parabolico"
        Me.TabControl.ResumeLayout(False)
        Me.Simulacion.ResumeLayout(False)
        CType(Me.ParedIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParedDerecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Techo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Piso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents Simulacion As TabPage
    Friend WithEvents Datos As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxX0 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxY0 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AnguloVelocidad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MagnitudVelocidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents IntervaloViento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Gravedad As TextBox
    Friend WithEvents ParedIzquierda As PictureBox
    Friend WithEvents ParedDerecha As PictureBox
    Friend WithEvents Techo As PictureBox
    Friend WithEvents Piso As PictureBox
End Class
