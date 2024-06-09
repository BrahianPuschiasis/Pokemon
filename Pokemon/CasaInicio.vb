Public Class CasaInicio
    Dim rocas As String
    Dim rocas2 As String


    Private Sub PrimeraCiudad_AutoSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AutoSizeChanged


    End Sub
    Private Sub PrimeraCiudad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

   
        rocas = bulba.Location.ToString


        Nickname.Top = bulba.Top - 20
        Nickname.Left = bulba.Left - 3



        Select Case e.KeyCode




            '-------------------------------------------------------------------------------------
            '---------------------------------------------------------
            Case Keys.T
                Tutorial.Show()

            Case Keys.C
                Pokemones.Show()





            Case Keys.W
                If Me.bulba.Location.Y = 291 And Me.bulba.Location.X >= 238 And Me.bulba.Location.X <= 323 Then
                    bulba.Image = ImageList1.Images(0)
                Else
                    If Me.bulba.Location.Y + 5 = 151 Then
                        bulba.Image = ImageList1.Images(0)

                    Else
                        Me.bulba.Location = New Point(Me.bulba.Location.X, Me.bulba.Location.Y - 5)
                        ' Mapa1.Top = Mapa1.Top + 5

                        If caminar = 0 Then
                            bulba.Image = ImageList1.Images(0)
                            caminar = caminar + 1
                            Timer1.Enabled = True
                            Timer1.Start()



                        Else
                            bulba.Image = ImageList1.Images(1)
                            caminar = 0
                            Timer1.Enabled = True
                            Timer1.Start()

                        End If
                    End If
                End If





            Case Keys.S
                If Me.bulba.Location.Y = 411 And Me.bulba.Location.X >= 148 And Me.bulba.Location.X <= 193 Then
                    bulba.Image = ImageList1.Images(11)
                    casa = 1
                    PuebloPaleta.Show()
                    casa = 1
                    Me.Close()

                Else
                    If Me.bulba.Location.Y = 336 And Me.bulba.Location.X >= -2 And Me.bulba.Location.X <= 28 Then
                        bulba.Image = ImageList1.Images(3)
                    Else
                        If Me.bulba.Location.Y = 341 And Me.bulba.Location.X >= 483 And Me.bulba.Location.X <= 518 Then
                            bulba.Image = ImageList1.Images(3)
                        Else
                            If Me.bulba.Location.Y = 206 And Me.bulba.Location.X >= 238 And Me.bulba.Location.X <= 328 Then
                                bulba.Image = ImageList1.Images(3)
                            Else
                                If Me.bulba.Location.Y + 5 = 416 Then
                                    bulba.Image = ImageList1.Images(3)

                                Else
                                    Me.bulba.Location = New Point(Me.bulba.Location.X, Me.bulba.Location.Y + 5)
                                    '  Mapa1.Top = Mapa1.Top - 5

                                    If caminar = 0 Then
                                        bulba.Image = ImageList1.Images(3)
                                        caminar = caminar + 1
                                        Timer1.Enabled = True
                                        Timer1.Start()
                                    Else
                                        bulba.Image = ImageList1.Images(7)
                                        caminar = 0
                                        Timer1.Enabled = True
                                        Timer1.Start()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If


            Case Keys.A
                If Me.bulba.Location.X = 28 And Me.bulba.Location.Y >= 341 And Me.bulba.Location.Y <= 411 Then
                    bulba.Image = ImageList1.Images(8)
                Else
                    If Me.bulba.Location.X = 328 And Me.bulba.Location.Y >= 211 And Me.bulba.Location.Y <= 286 Then
                        bulba.Image = ImageList1.Images(8)
                    Else
                        If Me.bulba.Location.X - 5 = -7 Then
                            bulba.Image = ImageList1.Images(8)

                        Else

                            Me.bulba.Location = New Point(Me.bulba.Location.X - 5, Me.bulba.Location.Y)
                            '  Mapa1.Left = Mapa1.Left + 5


                            If caminar = 0 Then
                                bulba.Image = ImageList1.Images(8)
                                caminar = caminar + 1
                                Timer1.Enabled = True
                                Timer1.Start()
                            Else
                                bulba.Image = ImageList1.Images(9)
                                caminar = 0
                                Timer1.Enabled = True
                                Timer1.Start()
                            End If
                        End If
                    End If
                End If


            Case Keys.D
                If Me.bulba.Location.X = 483 And Me.bulba.Location.Y >= 346 And Me.bulba.Location.Y <= 411 Then
                    bulba.Image = ImageList1.Images(4)
                Else
                    If Me.bulba.Location.X = 233 And Me.bulba.Location.Y >= 211 And Me.bulba.Location.Y <= 286 Then
                        bulba.Image = ImageList1.Images(4)
                    Else

                        If Me.bulba.Location.X + 5 = 523 Then
                            bulba.Image = ImageList1.Images(4)

                        Else
                            Me.bulba.Location = New Point(Me.bulba.Location.X + 5, Me.bulba.Location.Y)
                            's   Mapa1.Left = Mapa1.Left - 5
                            If caminar = 0 Then
                                bulba.Image = ImageList1.Images(4)
                                caminar = caminar + 1
                                Timer1.Enabled = True
                                Timer1.Start()
                            Else
                                bulba.Image = ImageList1.Images(5)
                                caminar = 0
                                Timer1.Enabled = True
                                Timer1.Start()
                            End If

                        End If

                    End If

                End If


        End Select
        'End If
        ' End If


    End Sub

    Private Sub PrimeraCiudad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mapa1.Controls.Add(bulba)
        Mapa1.Controls.Add(Nickname)
        Nickname.Text = nick




        Mapa1.Size = Mapa1.Size
        posicionx = 173
        posiciony = 401
        bulba.Image = ImageList1.Images(11)

        Dim Xpos As Integer
        Dim ypos As Integer
        casa = 1
        'MsgBox(posicionx)
        'MsgBox(posiciony)
        Xpos = (Mapa1.Width / 2)
        ypos = (Mapa1.Height / 2)

        Xpos = posicionx
        ypos = posiciony
        Me.bulba.Image = ImageList1.Images(2)



        Me.bulba.Location = New Point(Xpos, ypos)

        Nickname.Top = bulba.Top - 20
        Nickname.Left = bulba.Left - 3

 


    End Sub

    Private Sub Bulba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub roca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub



    Private Sub Bulba_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles bulba.MouseWheel




    End Sub

    Private Sub PrimeraCiudad_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel

    End Sub

    Private Sub PrimeraCiudad_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

    End Sub

    Private Sub bulba_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Mapa1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mapa1.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' If (Timer1.Interval = 500) Then
        'bulba.Image = ImageList1.Images(11)
        'Timer1.Stop()

        '        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Mapa1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Mapa1.MouseWheel

    End Sub

    Private Sub bulba_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bulba.Click







    End Sub

    Private Sub Button1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.TabIndex = False

        MsgBox(" " & bulba.Location.X & " " & bulba.Location.Y & "  ")




        'MsgBox(Mapa1.Top)

        '  Button1.Enabled = False





    End Sub
End Class