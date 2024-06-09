<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laboratorio
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laboratorio))
        Me.Mapa1 = New System.Windows.Forms.PictureBox
        Me.bulba = New System.Windows.Forms.PictureBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Textbox = New System.Windows.Forms.PictureBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.btnSi = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Nickname = New System.Windows.Forms.Label
        CType(Me.Mapa1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bulba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Textbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mapa1
        '
        Me.Mapa1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mapa1.BackColor = System.Drawing.Color.Transparent
        Me.Mapa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Mapa1.Image = CType(resources.GetObject("Mapa1.Image"), System.Drawing.Image)
        Me.Mapa1.Location = New System.Drawing.Point(80, -1)
        Me.Mapa1.Name = "Mapa1"
        Me.Mapa1.Size = New System.Drawing.Size(555, 571)
        Me.Mapa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Mapa1.TabIndex = 1
        Me.Mapa1.TabStop = False
        '
        'bulba
        '
        Me.bulba.BackColor = System.Drawing.Color.Transparent
        Me.bulba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bulba.Image = CType(resources.GetObject("bulba.Image"), System.Drawing.Image)
        Me.bulba.Location = New System.Drawing.Point(345, 488)
        Me.bulba.Name = "bulba"
        Me.bulba.Size = New System.Drawing.Size(28, 34)
        Me.bulba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bulba.TabIndex = 5
        Me.bulba.TabStop = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(526, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(232, 158)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Textbox
        '
        Me.Textbox.BackColor = System.Drawing.Color.Transparent
        Me.Textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Textbox.Image = CType(resources.GetObject("Textbox.Image"), System.Drawing.Image)
        Me.Textbox.Location = New System.Drawing.Point(221, 349)
        Me.Textbox.Name = "Textbox"
        Me.Textbox.Size = New System.Drawing.Size(321, 71)
        Me.Textbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Textbox.TabIndex = 8
        Me.Textbox.TabStop = False
        Me.Textbox.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Location = New System.Drawing.Point(232, 358)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(280, 52)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = "asdasd"
        Me.RichTextBox1.Visible = False
        '
        'btnSi
        '
        Me.btnSi.BackColor = System.Drawing.Color.White
        Me.btnSi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSi.Location = New System.Drawing.Point(332, 397)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(75, 23)
        Me.btnSi.TabIndex = 14
        Me.btnSi.Text = "Si"
        Me.btnSi.UseVisualStyleBackColor = False
        Me.btnSi.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(413, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "No"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Nickname
        '
        Me.Nickname.AutoSize = True
        Me.Nickname.BackColor = System.Drawing.Color.Transparent
        Me.Nickname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nickname.Location = New System.Drawing.Point(315, 306)
        Me.Nickname.Name = "Nickname"
        Me.Nickname.Size = New System.Drawing.Size(64, 13)
        Me.Nickname.TabIndex = 105
        Me.Nickname.Text = "<Brahian>"
        '
        'Laboratorio
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(694, 625)
        Me.Controls.Add(Me.Nickname)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSi)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Textbox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bulba)
        Me.Controls.Add(Me.Mapa1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.KeyPreview = True
        Me.Name = "Laboratorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laboratorio"
        CType(Me.Mapa1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bulba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Textbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mapa1 As System.Windows.Forms.PictureBox
    Friend WithEvents bulba As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Textbox As System.Windows.Forms.PictureBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSi As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Nickname As System.Windows.Forms.Label
End Class
