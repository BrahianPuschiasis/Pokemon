<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pokemones
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
        Me.Primero = New System.Windows.Forms.PictureBox
        Me.txtStats = New System.Windows.Forms.RichTextBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.Primero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Primero
        '
        Me.Primero.Location = New System.Drawing.Point(64, 30)
        Me.Primero.Name = "Primero"
        Me.Primero.Size = New System.Drawing.Size(143, 125)
        Me.Primero.TabIndex = 0
        Me.Primero.TabStop = False
        '
        'txtStats
        '
        Me.txtStats.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStats.BackColor = System.Drawing.SystemColors.Control
        Me.txtStats.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStats.ForeColor = System.Drawing.Color.Black
        Me.txtStats.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtStats.Location = New System.Drawing.Point(272, 12)
        Me.txtStats.Name = "txtStats"
        Me.txtStats.ReadOnly = True
        Me.txtStats.Size = New System.Drawing.Size(246, 143)
        Me.txtStats.TabIndex = 8
        Me.txtStats.TabStop = False
        Me.txtStats.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(125, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Pokemones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 317)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtStats)
        Me.Controls.Add(Me.Primero)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.KeyPreview = True
        Me.Name = "Pokemones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pokemones"
        Me.TopMost = True
        CType(Me.Primero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Primero As System.Windows.Forms.PictureBox
    Friend WithEvents txtStats As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
