<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ruta1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ruta1))
        Me.bulba = New System.Windows.Forms.PictureBox
        Me.Mapa1 = New System.Windows.Forms.PictureBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.bulba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mapa1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bulba
        '
        Me.bulba.BackColor = System.Drawing.Color.Transparent
        Me.bulba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bulba.Image = CType(resources.GetObject("bulba.Image"), System.Drawing.Image)
        Me.bulba.Location = New System.Drawing.Point(330, 486)
        Me.bulba.Name = "bulba"
        Me.bulba.Size = New System.Drawing.Size(28, 34)
        Me.bulba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bulba.TabIndex = 7
        Me.bulba.TabStop = False
        '
        'Mapa1
        '
        Me.Mapa1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mapa1.BackColor = System.Drawing.Color.Transparent
        Me.Mapa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Mapa1.Image = CType(resources.GetObject("Mapa1.Image"), System.Drawing.Image)
        Me.Mapa1.Location = New System.Drawing.Point(-105, 0)
        Me.Mapa1.Name = "Mapa1"
        Me.Mapa1.Size = New System.Drawing.Size(555, 571)
        Me.Mapa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Mapa1.TabIndex = 6
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
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(408, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(338, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 104
        '
        'Ruta1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(684, 615)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bulba)
        Me.Controls.Add(Me.Mapa1)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.KeyPreview = True
        Me.Name = "Ruta1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ruta1"
        CType(Me.bulba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mapa1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bulba As System.Windows.Forms.PictureBox
    Friend WithEvents Mapa1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
