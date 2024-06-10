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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title6 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Simulacion = New System.Windows.Forms.TabPage()
        Me.PBPelota = New System.Windows.Forms.PictureBox()
        Me.Piso = New System.Windows.Forms.PictureBox()
        Me.Techo = New System.Windows.Forms.PictureBox()
        Me.ParedDerecha = New System.Windows.Forms.PictureBox()
        Me.ParedIzquierda = New System.Windows.Forms.PictureBox()
        Me.Datos = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
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
        Me.ButtonIniciar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonReiniciar = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl.SuspendLayout()
        Me.Simulacion.SuspendLayout()
        CType(Me.PBPelota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Piso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Techo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParedDerecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParedIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Datos.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Simulacion.BackgroundImage = CType(resources.GetObject("Simulacion.BackgroundImage"), System.Drawing.Image)
        Me.Simulacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Simulacion.Controls.Add(Me.PBPelota)
        Me.Simulacion.Controls.Add(Me.Piso)
        Me.Simulacion.Controls.Add(Me.Techo)
        Me.Simulacion.Controls.Add(Me.ParedDerecha)
        Me.Simulacion.Controls.Add(Me.ParedIzquierda)
        Me.Simulacion.Location = New System.Drawing.Point(4, 22)
        Me.Simulacion.Name = "Simulacion"
        Me.Simulacion.Padding = New System.Windows.Forms.Padding(3)
        Me.Simulacion.Size = New System.Drawing.Size(817, 515)
        Me.Simulacion.TabIndex = 0
        Me.Simulacion.Text = "Simulacion"
        Me.Simulacion.UseVisualStyleBackColor = True
        '
        'PBPelota
        '
        Me.PBPelota.Image = CType(resources.GetObject("PBPelota.Image"), System.Drawing.Image)
        Me.PBPelota.Location = New System.Drawing.Point(5, 424)
        Me.PBPelota.Name = "PBPelota"
        Me.PBPelota.Size = New System.Drawing.Size(59, 56)
        Me.PBPelota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBPelota.TabIndex = 4
        Me.PBPelota.TabStop = False
        '
        'Piso
        '
        Me.Piso.BackColor = System.Drawing.Color.Black
        Me.Piso.Image = CType(resources.GetObject("Piso.Image"), System.Drawing.Image)
        Me.Piso.Location = New System.Drawing.Point(0, 484)
        Me.Piso.Name = "Piso"
        Me.Piso.Size = New System.Drawing.Size(838, 74)
        Me.Piso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Piso.TabIndex = 3
        Me.Piso.TabStop = False
        '
        'Techo
        '
        Me.Techo.BackColor = System.Drawing.Color.Black
        Me.Techo.Location = New System.Drawing.Point(0, -30)
        Me.Techo.Name = "Techo"
        Me.Techo.Size = New System.Drawing.Size(821, 31)
        Me.Techo.TabIndex = 2
        Me.Techo.TabStop = False
        Me.Techo.Visible = False
        '
        'ParedDerecha
        '
        Me.ParedDerecha.BackColor = System.Drawing.Color.Black
        Me.ParedDerecha.Location = New System.Drawing.Point(815, 0)
        Me.ParedDerecha.Name = "ParedDerecha"
        Me.ParedDerecha.Size = New System.Drawing.Size(22, 533)
        Me.ParedDerecha.TabIndex = 1
        Me.ParedDerecha.TabStop = False
        Me.ParedDerecha.Visible = False
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
        Me.Datos.Controls.Add(Me.DataGridView2)
        Me.Datos.Controls.Add(Me.DataGridView1)
        Me.Datos.Controls.Add(Me.Chart1)
        Me.Datos.Location = New System.Drawing.Point(4, 22)
        Me.Datos.Name = "Datos"
        Me.Datos.Padding = New System.Windows.Forms.Padding(3)
        Me.Datos.Size = New System.Drawing.Size(817, 515)
        Me.Datos.TabIndex = 1
        Me.Datos.Text = "Datos"
        Me.Datos.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle31
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column10})
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle32
        Me.DataGridView2.Location = New System.Drawing.Point(43, 319)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle33
        Me.DataGridView2.Size = New System.Drawing.Size(387, 161)
        Me.DataGridView2.TabIndex = 2
        '
        'Column9
        '
        Me.Column9.HeaderText = "Variable"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Valor"
        Me.Column10.Name = "Column10"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle34
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column7, Me.Column8, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle35
        Me.DataGridView1.Location = New System.Drawing.Point(454, 51)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle36
        Me.DataGridView1.Size = New System.Drawing.Size(357, 429)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        '
        'Column6
        '
        Me.Column6.HeaderText = "t"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "X"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "y(t)"
        Me.Column8.Name = "Column8"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Coordenada"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Vx"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Vy"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Vv"
        Me.Column5.Name = "Column5"
        '
        'Chart1
        '
        ChartArea6.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea6)
        Me.Chart1.Location = New System.Drawing.Point(3, 33)
        Me.Chart1.Name = "Chart1"
        Series6.BorderWidth = 3
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series6.Name = "Series1"
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Size = New System.Drawing.Size(445, 280)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title6.Name = "Title1"
        Title6.Text = "Y(t) vs X(t)"
        Me.Chart1.Titles.Add(Title6)
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
        Me.AnguloVelocidad.Text = "1"
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
        Me.MagnitudVelocidad.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Intervalo Viento (t') en s"
        '
        'IntervaloViento
        '
        Me.IntervaloViento.Location = New System.Drawing.Point(24, 392)
        Me.IntervaloViento.Name = "IntervaloViento"
        Me.IntervaloViento.Size = New System.Drawing.Size(132, 20)
        Me.IntervaloViento.TabIndex = 14
        Me.IntervaloViento.Text = "1"
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
        Me.Gravedad.Text = "9.81"
        '
        'ButtonIniciar
        '
        Me.ButtonIniciar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIniciar.Location = New System.Drawing.Point(47, 436)
        Me.ButtonIniciar.Name = "ButtonIniciar"
        Me.ButtonIniciar.Size = New System.Drawing.Size(84, 31)
        Me.ButtonIniciar.TabIndex = 16
        Me.ButtonIniciar.Text = "Iniciar"
        Me.ButtonIniciar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'ButtonReiniciar
        '
        Me.ButtonReiniciar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReiniciar.Location = New System.Drawing.Point(47, 483)
        Me.ButtonReiniciar.Name = "ButtonReiniciar"
        Me.ButtonReiniciar.Size = New System.Drawing.Size(84, 31)
        Me.ButtonReiniciar.TabIndex = 17
        Me.ButtonReiniciar.Text = "Reiniciar"
        Me.ButtonReiniciar.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 604)
        Me.Controls.Add(Me.ButtonReiniciar)
        Me.Controls.Add(Me.ButtonIniciar)
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
        Me.MaximumSize = New System.Drawing.Size(1040, 643)
        Me.MinimumSize = New System.Drawing.Size(1040, 643)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulacion Movimineto Parabolico"
        Me.TabControl.ResumeLayout(False)
        Me.Simulacion.ResumeLayout(False)
        CType(Me.PBPelota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Piso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Techo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParedDerecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParedIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Datos.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PBPelota As PictureBox
    Friend WithEvents ButtonIniciar As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ButtonReiniciar As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Timer2 As Timer
End Class
