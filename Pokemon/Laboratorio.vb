Public Class Laboratorio

    Private Sub Laboratorio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Label1.Text = " " & bulba.Location.X & " " & bulba.Location.Y & " "

        Nickname.Top = bulba.Top - 20
        Nickname.Left = bulba.Left - 3

        Select Case e.KeyCode


            '-------------------------------------------------------------------------------------
            '---------------------------------------------------------
            Case Keys.C
                Pokemones.Show()

            Case Keys.Space
                If primario <> 0 Then
                Else

                    If Me.bulba.Location.Y = 253 And Me.bulba.Location.X >= 245 And Me.bulba.Location.X <= 255 Then
                        bulba.Image = ImageList1.Images(0)
                        RichTextBox1.Visible = True
                        Textbox.Visible = True
                        Button1.Visible = True
                        btnSi.Visible = True
                        RichTextBox1.Text = "Llegas tarde, ya no quedan pokemones primarios, ¿quieres un Pikachu?"


                        ' If MsgBox("", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        'RichTextBox1.Text = "Jaja, ni en tus sueños, selecciona uno de los normales"
                        'Primarios.Show()
                        'Me.Hide()
                        'Else
                        '    RichTextBox1.Text = "Igual no iba a dartelo"
                        '    Primarios.Show()
                        '    Me.Hide()

                    End If

                End If


                '   End If


            Case Keys.W

                If Me.bulba.Location.Y = 253 And Me.bulba.Location.X >= 15 And Me.bulba.Location.X <= 500 Then
                    bulba.Image = ImageList1.Images(0)
                Else
                    If Me.bulba.Location.Y = 363 And Me.bulba.Location.X >= 315 And Me.bulba.Location.X <= 500 Then
                        bulba.Image = ImageList1.Images(0)
                    Else
                        If Me.bulba.Location.Y = 363 And Me.bulba.Location.X >= 15 And Me.bulba.Location.X <= 210 Then
                            bulba.Image = ImageList1.Images(0)
                        Else
                            Me.bulba.Location = New Point(Me.bulba.Location.X, Me.bulba.Location.Y - 5)


                            If caminar = 0 Then
                                bulba.Image = ImageList1.Images(0)
                                caminar = caminar + 1



                            Else
                                bulba.Image = ImageList1.Images(1)
                                caminar = 0


                            End If
                        End If
                    End If
                End If


            Case Keys.S
                If Me.bulba.Location.Y = 488 And Me.bulba.Location.X >= 235 And Me.bulba.Location.X <= 275 Then
                    bulba.Image = ImageList1.Images(3)
                    lab = 1
                    PuebloPaleta.Show()
                    lab = 1
                    Me.Close()
                    lab = 1
                    lab = 1
                    lab = 1
                Else

                    If Me.bulba.Location.Y = 263 And Me.bulba.Location.X >= 310 And Me.bulba.Location.X <= 500 Then
                        bulba.Image = ImageList1.Images(3)
                    Else
                        If Me.bulba.Location.Y = 263 And Me.bulba.Location.X >= 15 And Me.bulba.Location.X <= 215 Then
                            bulba.Image = ImageList1.Images(3)
                        Else
                            If Me.bulba.Location.Y = 413 And Me.bulba.Location.X >= 465 And Me.bulba.Location.X <= 500 Then
                                bulba.Image = ImageList1.Images(3)
                            Else
                                If Me.bulba.Location.Y = 413 And Me.bulba.Location.X >= 15 And Me.bulba.Location.X <= 50 Then
                                    bulba.Image = ImageList1.Images(3)
                                Else
                                    If Me.bulba.Location.Y = 488 And Me.bulba.Location.X >= 50 And Me.bulba.Location.X <= 465 Then
                                        bulba.Image = ImageList1.Images(3)
                                    Else
                                        Me.bulba.Location = New Point(Me.bulba.Location.X, Me.bulba.Location.Y + 5)


                                        If caminar = 0 Then
                                            bulba.Image = ImageList1.Images(3)
                                            caminar = caminar + 1

                                        Else
                                            bulba.Image = ImageList1.Images(7)
                                            caminar = 0
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            Case Keys.A
                If Me.bulba.Location.X = 15 And Me.bulba.Location.Y >= 253 And Me.bulba.Location.Y <= 263 Then
                    bulba.Image = ImageList1.Images(8)
                Else

                    If Me.bulba.Location.X = 215 And Me.bulba.Location.Y >= 268 And Me.bulba.Location.Y <= 363 Then
                        bulba.Image = ImageList1.Images(8)
                    Else
                        If Me.bulba.Location.X = 15 And Me.bulba.Location.Y >= 363 And Me.bulba.Location.Y <= 413 Then
                            bulba.Image = ImageList1.Images(8)
                        Else
                            If Me.bulba.Location.X = 50 And Me.bulba.Location.Y >= 418 And Me.bulba.Location.Y <= 493 Then
                                bulba.Image = ImageList1.Images(8)
                            Else
                                Me.bulba.Location = New Point(Me.bulba.Location.X - 5, Me.bulba.Location.Y)



                                If caminar = 0 Then
                                    bulba.Image = ImageList1.Images(8)
                                    caminar = caminar + 1

                                Else
                                    bulba.Image = ImageList1.Images(9)
                                    caminar = 0
                                End If
                            End If
                        End If
                    End If
                End If



            Case Keys.D
                If Me.bulba.Location.X = 500 And Me.bulba.Location.Y >= 253 And Me.bulba.Location.Y <= 263 Then
                    bulba.Image = ImageList1.Images(4)
                Else
                    If Me.bulba.Location.X = 310 And Me.bulba.Location.Y >= 268 And Me.bulba.Location.Y <= 363 Then
                        bulba.Image = ImageList1.Images(4)
                    Else
                        If Me.bulba.Location.X = 500 And Me.bulba.Location.Y >= 363 And Me.bulba.Location.Y <= 413 Then
                            bulba.Image = ImageList1.Images(4)
                        Else
                            If Me.bulba.Location.X = 465 And Me.bulba.Location.Y >= 418 And Me.bulba.Location.Y <= 493 Then
                                bulba.Image = ImageList1.Images(4)
                            Else
                                Me.bulba.Location = New Point(Me.bulba.Location.X + 5, Me.bulba.Location.Y)

                                If caminar = 0 Then
                                    bulba.Image = ImageList1.Images(4)
                                    caminar = caminar + 1

                                Else
                                    bulba.Image = ImageList1.Images(5)
                                    caminar = 0
                                End If
                            End If
                        End If
                    End If
                End If

        End Select
    End Sub

    Private Sub Laboratorio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mapa1.Controls.Add(bulba)
        Mapa1.Controls.Add(PictureBox1)
        Nickname.Text = nick
        Mapa1.Controls.Add(Textbox)
        Mapa1.Controls.Add(Nickname)
        lab = 1

        Mapa1.Size = Mapa1.Size
   

        bulba.Image = ImageList1.Images(2)

        Me.bulba.Location = New Point(255, 478)
        Me.PictureBox1.Location = New Point(250, 213)

 



        Me.Textbox.Location = New Point(110, 328)
        Me.RichTextBox1.Location = New Point(205, 335)
        Nickname.Top = bulba.Top - 20
        Nickname.Left = bulba.Left - 3

    End Sub

    Private Sub Mapa1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mapa1.Click

    End Sub

    Private Sub btnSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
 
    End Sub

    Private Sub btnSi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSi.Click
    

        If btnSi.Text = "Confirmar" Then
            Primarios.Show()
            btnSi.Visible = False
            RichTextBox1.Visible = False
            Textbox.Visible = False

            Me.Hide()

        Else
            RichTextBox1.Text = "Jaja, ni en tus sueños, selecciona uno de los normales"
            Button1.Visible = False
            btnSi.Text = "Confirmar"
        End If

        ' Primarios.Show()
        '    Me.Hide()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Text = "Igual no iba a dartelo, selecciona uno de los normales"
        Button1.Visible = False
        btnSi.Text = "Confirmar"
        '   Primarios.Show()
        '    Me.Hide()
    End Sub
End Class