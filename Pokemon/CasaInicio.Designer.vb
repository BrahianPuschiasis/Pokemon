<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CasaInicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CasaInicio))
        Me.Mapa1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bulba = New System.Windows.Forms.PictureBox()
        Me.Nickname = New System.Windows.Forms.Label()
        CType(Me.Mapa1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bulba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mapa1
        '
        Me.Mapa1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mapa1.BackColor = System.Drawing.Color.Transparent
        Me.Mapa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Mapa1.Image = CType(resources.GetObject("Mapa1.Image"), System.Drawing.Image)
        Me.Mapa1.Location = New System.Drawing.Point(85, -75)
        Me.Mapa1.Name = "Mapa1"
        Me.Mapa1.Size = New System.Drawing.Size(555, 571)
        Me.Mapa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Mapa1.TabIndex = 0
        Me.Mapa1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "arribaderecha.png")
        Me.ImageList1.Images.SetKeyName(1, "arribaizquierda.png")
        Me.ImageList1.Images.SetKeyName(2, "arribaparado.png")
        Me.ImageList1.Images.SetKeyName(3, "derechaabajo.png")
        Me.ImageList1.Images.SetKeyName(4, "derechaderecha.png")
        Me.ImageList1.Images.SetKeyName(5, "derechadizquierda.png")
        Me.ImageList1.Images.SetKeyName(6, "derechaparado.png")
        Me.ImageList1.Images.SetKeyName(7, "izquierdabajo.png")
        Me.ImageList1.Images.SetKeyName(8, "izquierdaderecha.png")
        Me.ImageList1.Images.SetKeyName(9, "izquierdaizquierda.png")
        Me.ImageList1.Images.SetKeyName(10, "izquierdaparado.png")
        Me.ImageList1.Images.SetKeyName(11, "Parado.png")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(526, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 100
        Me.Button1.TabStop = False
        Me.Button1.Text = "Bulba"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'bulba
        '
        Me.bulba.BackColor = System.Drawing.Color.Transparent
        Me.bulba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bulba.Image = CType(resources.GetObject("bulba.Image"), System.Drawing.Image)
        Me.bulba.Location = New System.Drawing.Point(230, 229)
        Me.bulba.Name = "bulba"
        Me.bulba.Size = New System.Drawing.Size(28, 34)
        Me.bulba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bulba.TabIndex = 4
        Me.bulba.TabStop = False
        '
        'Nickname
        '
        Me.Nickname.AutoSize = True
        Me.Nickname.BackColor = System.Drawing.Color.Transparent
        Me.Nickname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nickname.Location = New System.Drawing.Point(183, 157)
        Me.Nickname.Name = "Nickname"
        Me.Nickname.Size = New System.Drawing.Size(64, 13)
        Me.Nickname.TabIndex = 101
        Me.Nickname.Text = "<Brahian>"
        '
        'CasaInicio
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(694, 625)
        Me.Controls.Add(Me.Nickname)
        Me.Controls.Add(Me.bulba)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Mapa1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.KeyPreview = True
        Me.Name = "CasaInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrimeraCiudad"
        CType(Me.Mapa1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bulba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mapa1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bulba As System.Windows.Forms.PictureBox
    Friend WithEvents Nickname As System.Windows.Forms.Label
End Class
