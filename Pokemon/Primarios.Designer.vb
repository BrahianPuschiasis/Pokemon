<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Primarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Primarios))
        Me.Bulba = New System.Windows.Forms.PictureBox
        Me.Charm = New System.Windows.Forms.PictureBox
        Me.Squa = New System.Windows.Forms.PictureBox
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.btnConfirmar = New System.Windows.Forms.Button
        Me.rbtnBulba = New System.Windows.Forms.RadioButton
        Me.rbtnCharm = New System.Windows.Forms.RadioButton
        Me.rbtnSqua = New System.Windows.Forms.RadioButton
        Me.Panel = New System.Windows.Forms.Panel
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        CType(Me.Bulba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Charm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Squa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bulba
        '
        Me.Bulba.Image = CType(resources.GetObject("Bulba.Image"), System.Drawing.Image)
        Me.Bulba.Location = New System.Drawing.Point(173, 155)
        Me.Bulba.Name = "Bulba"
        Me.Bulba.Size = New System.Drawing.Size(96, 80)
        Me.Bulba.TabIndex = 0
        Me.Bulba.TabStop = False
        '
        'Charm
        '
        Me.Charm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Charm.Image = CType(resources.GetObject("Charm.Image"), System.Drawing.Image)
        Me.Charm.Location = New System.Drawing.Point(370, 155)
        Me.Charm.Name = "Charm"
        Me.Charm.Size = New System.Drawing.Size(96, 80)
        Me.Charm.TabIndex = 1
        Me.Charm.TabStop = False
        '
        'Squa
        '
        Me.Squa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Squa.Image = CType(resources.GetObject("Squa.Image"), System.Drawing.Image)
        Me.Squa.Location = New System.Drawing.Point(561, 155)
        Me.Squa.Name = "Squa"
        Me.Squa.Size = New System.Drawing.Size(96, 80)
        Me.Squa.TabIndex = 2
        Me.Squa.TabStop = False
        '
        'lblMensaje
        '
        Me.lblMensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(280, 33)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(222, 25)
        Me.lblMensaje.TabIndex = 3
        Me.lblMensaje.Text = "Seleccione un pokemón"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConfirmar.Location = New System.Drawing.Point(356, 341)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 7
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'rbtnBulba
        '
        Me.rbtnBulba.AutoSize = True
        Me.rbtnBulba.Location = New System.Drawing.Point(40, 12)
        Me.rbtnBulba.Name = "rbtnBulba"
        Me.rbtnBulba.Size = New System.Drawing.Size(14, 13)
        Me.rbtnBulba.TabIndex = 8
        Me.rbtnBulba.TabStop = True
        Me.rbtnBulba.UseVisualStyleBackColor = True
        '
        'rbtnCharm
        '
        Me.rbtnCharm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rbtnCharm.AutoSize = True
        Me.rbtnCharm.Location = New System.Drawing.Point(236, 12)
        Me.rbtnCharm.Name = "rbtnCharm"
        Me.rbtnCharm.Size = New System.Drawing.Size(14, 13)
        Me.rbtnCharm.TabIndex = 9
        Me.rbtnCharm.TabStop = True
        Me.rbtnCharm.UseVisualStyleBackColor = True
        '
        'rbtnSqua
        '
        Me.rbtnSqua.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnSqua.AutoSize = True
        Me.rbtnSqua.Location = New System.Drawing.Point(422, 12)
        Me.rbtnSqua.Name = "rbtnSqua"
        Me.rbtnSqua.Size = New System.Drawing.Size(14, 13)
        Me.rbtnSqua.TabIndex = 10
        Me.rbtnSqua.TabStop = True
        Me.rbtnSqua.UseVisualStyleBackColor = True
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.rbtnSqua)
        Me.Panel.Controls.Add(Me.rbtnCharm)
        Me.Panel.Controls.Add(Me.rbtnBulba)
        Me.Panel.Location = New System.Drawing.Point(148, 229)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(476, 49)
        Me.Panel.TabIndex = 11
        '
        'BackgroundWorker1
        '
        '
        'Primarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 410)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.Squa)
        Me.Controls.Add(Me.Charm)
        Me.Controls.Add(Me.Bulba)
        Me.Name = "Primarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pokemon ???"
        CType(Me.Bulba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Charm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Squa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bulba As System.Windows.Forms.PictureBox
    Friend WithEvents Charm As System.Windows.Forms.PictureBox
    Friend WithEvents Squa As System.Windows.Forms.PictureBox
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents rbtnBulba As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCharm As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSqua As System.Windows.Forms.RadioButton
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
