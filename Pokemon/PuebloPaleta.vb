Public Class PuebloPaleta

    Private Sub PuebloPaleta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Label1.Text = " X:" & bulba.Location.X & " Y:" & bulba.Location.Y & "  "
        Label2.Text = " TOP:" & Mapa1.Top & " LEFT:" & Mapa1.Left & "  "
        Nickname.Top = bulba.Top - 20
        Nickname.Left = bulba.Left - 3

        Select Case e.KeyCode


            Case Keys.C
                Pokemones.Show()


                '-------------------------------------------------------------------------------------
                '---------------------------------------------------------


            Case Keys.W
                If Me.bulba.Location.Y = 5 And Me.bulba.Location.X >= 535 And Me.bulba.Location.X <= 615 Then
                    bulba.Image = ImageList1.Images(2)
                    Ruta1.Show()
                    bulba.Image = ImageList1.Images(2)
                    Me.Close()
                Else

                    If Me.bulba.Location.Y = 620 And Me.bulba.Location.X >= 735 And Me.bulba.Location.X <= 755 Then
                        bulba.Image = ImageList1.Images(2)
                        Laboratorio.Show()
                        bulba.Image = ImageList1.Images(2)
                        Me.Close()
                    Else
                        If Me.bulba.Location.X = 695 And Me.bulba.Location.Y = 345 Then
                            bulba.Image = ImageList1.Images(2)
                            posicionx = 173
                            posiciony = 401
                            CasaInicio.Show()
                            Me.Close()
                        Else
                            If Me.bulba.Location.Y = 345 And Me.bulba.Location.X >= 575 And Me.bulba.Location.X <= 875 Then
                                bulba.Image = ImageList1.Images(0)
                            Else
                                If Me.bulba.Location.Y = 620 And Me.bulba.Location.X >= 580 And Me.bulba.Location.X <= 905 Then
                                    bulba.Image = ImageList1.Images(0)
                                Else
                                    If Me.bulba.Location.Y = 755 And Me.bulba.Location.X >= 610 And Me.bulba.Location.X <= 860 Then
                                        bulba.Image = ImageList1.Images(0)
                                    Else
                                        If Me.bulba.Location.Y = 50 And Me.bulba.Location.X >= 620 And Me.bulba.Location.X <= 990 Then
                                            bulba.Image = ImageList1.Images(0)
                                        Else
                                            If Me.bulba.Location.Y = 340 And Me.bulba.Location.X >= 155 And Me.bulba.Location.X <= 455 Then
                                                bulba.Image = ImageList1.Images(0)
                                            Else
                                                If Me.bulba.Location.Y = 525 And Me.bulba.Location.X >= 210 And Me.bulba.Location.X <= 405 Then
                                                    bulba.Image = ImageList1.Images(0)
                                                Else
                                                    If Me.bulba.Location.Y = 50 And Me.bulba.Location.X >= 80 And Me.bulba.Location.X <= 530 Then
                                                        bulba.Image = ImageList1.Images(0)
                                                    Else
                                                        Me.bulba.Location = New Point(Me.bulba.Location.X, Me.bulba.Location.Y - 5)
                                                        If Mapa1.Top = -1 Then
                                                            If caminar = 0 Then
                                                                bulba.Image = ImageList1.Images(0)
                                                                caminar = caminar + 1



                                                            Else
                                                                bulba.Image = ImageList1.Images(1)
                                                                caminar = 0
                                                            End If
                                                        Else
                             

                                                            If bulba.Location.Y <= 555 Then
                                                                Mapa1.Top = Mapa1.Top + 5

                                                            End If


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
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If



            Case Keys.S
                If Me.bulba.Location.Y = 885 And Me.bulba.Location.X >= 500 And Me.bulba.Location.X <= 800 Then
                    bulba.Image = ImageList1.Images(3)
                Else
                    If Me.bulba.Location.Y = 270 And Me.bulba.Location.X >= 570 And Me.bulba.Location.X <= 605 Then
                        bulba.Image = ImageList1.Images(3)
                    Else
                        If Me.bulba.Location.Y = 125 And Me.bulba.Location.X >= 610 And Me.bulba.Location.X <= 875 Then
                            bulba.Image = ImageList1.Images(3)
                        Else
                            If Me.bulba.Location.Y = 400 And Me.bulba.Location.X >= 580 And Me.bulba.Location.X <= 905 Then
                                bulba.Image = ImageList1.Images(3)
                            Else
                                If Me.bulba.Location.Y = 700 And Me.bulba.Location.X >= 610 And Me.bulba.Location.X <= 870 Then
                                    bulba.Image = ImageList1.Images(3)
                                Else
                                    If Me.bulba.Location.Y = 845 And Me.bulba.Location.X >= 805 And Me.bulba.Location.X <= 990 Then
                                        bulba.Image = ImageList1.Images(3)
                                    Else
                                        If Me.bulba.Location.Y = 265 And Me.bulba.Location.X >= 155 And Me.bulba.Location.X <= 200 Then
                                            bulba.Image = ImageList1.Images(3)
                                        Else
                                            If Me.bulba.Location.Y = 120 And Me.bulba.Location.X >= 205 And Me.bulba.Location.X <= 455 Then
                                                bulba.Image = ImageList1.Images(3)
                                            Else
                                                If Me.bulba.Location.Y = 475 And Me.bulba.Location.X >= 210 And Me.bulba.Location.X <= 405 Then
                                                    bulba.Image = ImageList1.Images(3)
                                                Else
                                                    If Me.bulba.Location.Y = 750 And Me.bulba.Location.X >= 295 And Me.bulba.Location.X <= 495 Then
                                                        bulba.Image = ImageList1.Images(3)
                                                    Else
                                                        If Me.bulba.Location.Y = 850 And Me.bulba.Location.X >= 250 And Me.bulba.Location.X <= 295 Then
                                                            bulba.Image = ImageList1.Images(3)
                                                        Else
                                                            If Me.bulba.Location.Y = 805 And Me.bulba.Location.X >= 80 And Me.bulba.Location.X <= 245 Then
                                                                bulba.Image = ImageList1.Images(3)
                                                            Else
                                                                Me.bulba.Location = New Point(Me.bulba.Location.X, Me.bulba.Location.Y + 5)
                                                                If Mapa1.Top = -301 Then
                                                                    If caminar = 0 Then
                                                                        bulba.Image = ImageList1.Images(3)
                                                                        caminar = caminar + 1

                                                                    Else
                                                                        bulba.Image = ImageList1.Images(7)
                                                                        caminar = 0
                                                                    End If
                                                                Else
                                   

                                                                    If bulba.Location.Y >= 285 Then
                                                                        Mapa1.Top = Mapa1.Top - 5

                                                                    End If
                                                                    'Mapa1.Top = Mapa1.Top - 5

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
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            Case Keys.A
                If Me.bulba.Location.X = 880 And Me.bulba.Location.Y >= 130 And Me.bulba.Location.Y <= 340 Then
                    bulba.Image = ImageList1.Images(8)
                Else
                    If Me.bulba.Location.X = 910 And Me.bulba.Location.Y >= 405 And Me.bulba.Location.Y <= 615 Then
                        bulba.Image = ImageList1.Images(8)
                    Else
                        If Me.bulba.Location.X = 875 And Me.bulba.Location.Y >= 705 And Me.bulba.Location.Y <= 750 Then
                            bulba.Image = ImageList1.Images(8)
                        Else
                            If Me.bulba.Location.X = 460 And Me.bulba.Location.Y >= 125 And Me.bulba.Location.Y <= 335 Then
                                bulba.Image = ImageList1.Images(8)
                            Else
                                If Me.bulba.Location.X = 410 And Me.bulba.Location.Y >= 480 And Me.bulba.Location.Y <= 520 Then
                                    bulba.Image = ImageList1.Images(8)
                                Else
                                    If Me.bulba.Location.X = 535 And Me.bulba.Location.Y >= 0 And Me.bulba.Location.Y <= 45 Then
                                        bulba.Image = ImageList1.Images(8)
                                    Else
                                        If Me.bulba.Location.X = 500 And Me.bulba.Location.Y >= 755 And Me.bulba.Location.Y <= 890 Then
                                            bulba.Image = ImageList1.Images(8)
                                        Else
                                            If Me.bulba.Location.X = 250 And Me.bulba.Location.Y >= 805 And Me.bulba.Location.Y <= 850 Then
                                                bulba.Image = ImageList1.Images(8)
                                            Else
                                                If Me.bulba.Location.X = 80 And Me.bulba.Location.Y >= 50 And Me.bulba.Location.Y <= 805 Then
                                                    bulba.Image = ImageList1.Images(8)
                                                Else

                                                    Me.bulba.Location = New Point(Me.bulba.Location.X - 5, Me.bulba.Location.Y)
                                                    If Mapa1.Left = -3 Then
                                                        If caminar = 0 Then
                                                            bulba.Image = ImageList1.Images(8)
                                                            caminar = caminar + 1

                                                        Else
                                                            bulba.Image = ImageList1.Images(9)
                                                            caminar = 0
                                                        End If
                                                    Else

                                                        If bulba.Location.X <= 695 Then
                                                            Mapa1.Left = Mapa1.Left + 5

                                                        End If
                                                        '    Mapa1.Left = Mapa1.Left + 5



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
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            Case Keys.D
                If Me.bulba.Location.X = 570 And Me.bulba.Location.Y >= 275 And Me.bulba.Location.Y <= 340 Then
                    bulba.Image = ImageList1.Images(4)
                Else
                    If Me.bulba.Location.X = 605 And Me.bulba.Location.Y >= 130 And Me.bulba.Location.Y <= 270 Then
                        bulba.Image = ImageList1.Images(4)
                    Else
                        If Me.bulba.Location.X = 575 And Me.bulba.Location.Y >= 405 And Me.bulba.Location.Y <= 615 Then
                            bulba.Image = ImageList1.Images(4)
                        Else
                            If Me.bulba.Location.X = 605 And Me.bulba.Location.Y >= 705 And Me.bulba.Location.Y <= 750 Then
                                bulba.Image = ImageList1.Images(4)
                            Else
                                If Me.bulba.Location.X = 800 And Me.bulba.Location.Y >= 850 And Me.bulba.Location.Y <= 890 Then
                                    bulba.Image = ImageList1.Images(4)
                                Else
                                    If Me.bulba.Location.X = 990 And Me.bulba.Location.Y >= 50 And Me.bulba.Location.Y <= 845 Then
                                        bulba.Image = ImageList1.Images(4)
                                    Else
                                        If Me.bulba.Location.X = 615 And Me.bulba.Location.Y >= 0 And Me.bulba.Location.Y <= 45 Then
                                            bulba.Image = ImageList1.Images(4)
                                        Else
                                            If Me.bulba.Location.X = 150 And Me.bulba.Location.Y >= 270 And Me.bulba.Location.Y <= 340 Then
                                                bulba.Image = ImageList1.Images(4)
                                            Else
                                                If Me.bulba.Location.X = 200 And Me.bulba.Location.Y >= 120 And Me.bulba.Location.Y <= 270 Then
                                                    bulba.Image = ImageList1.Images(4)
                                                Else
                                                    If Me.bulba.Location.X = 205 And Me.bulba.Location.Y >= 480 And Me.bulba.Location.Y <= 520 Then
                                                        bulba.Image = ImageList1.Images(4)
                                                    Else
                                                        If Me.bulba.Location.X = 295 And Me.bulba.Location.Y >= 755 And Me.bulba.Location.Y <= 850 Then
                                                            bulba.Image = ImageList1.Images(4)
                                                        Else
                                                            Me.bulba.Location = New Point(Me.bulba.Location.X + 5, Me.bulba.Location.Y)
                                                            If Mapa1.Left = -413 Then
                                                                If caminar = 0 Then
                                                                    bulba.Image = ImageList1.Images(4)
                                                                    caminar = caminar + 1

                                                                Else
                                                                    bulba.Image = ImageList1.Images(5)
                                                                    caminar = 0
                                                                End If
                                                            Else

                                                                If bulba.Location.X >= 365 Then
                                                                    Mapa1.Left = Mapa1.Left - 5

                                                                End If
                                                                '  Mapa1.Left = Mapa1.Left - 5
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
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
        End Select
    End Sub

    Private Sub PuebloPaleta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mapa1.Width = Mapa1.Width * 2
        Mapa1.Height = Mapa1.Height * 2
        Mapa1.Controls.Add(bulba)
        Mapa1.Controls.Add(Nickname)
        Nickname.Text = nick

        Mapa1.Controls.Add(bulba)

        Mapa1.Size = Mapa1.Size

        bulba.Image = ImageList1.Images(11)

        Dim Xpos As Integer
        Dim ypos As Integer

        '    Xpos = (Me.Width / 2)
        '  ypos = (Me.Height / 2
        '   Me.bulba.Location = New Point(695, 360)
        '  Me.Mapa1.Top = -41
        ' Me.Mapa1.Left = -343

        If casa = 1 Then
            Me.bulba.Location = New Point(695, 360)
            Me.Mapa1.Top = -41
            Me.Mapa1.Left = -343
            casa = 0
        End If

        If lab = 1 Then
            Me.bulba.Location = New Point(745, 635)
            Me.Mapa1.Top = -271
            Me.Mapa1.Left = -393
            lab = 0
        End If

        If ruta01 = 1 Then
            Me.bulba.Location = New Point(570, 70)
            Me.Mapa1.Top = -41
            Me.Mapa1.Left = -343
            ruta01 = 0

        End If




        Nickname.Top = bulba.Top - 20
        Nickname.Left = bulba.Left - 3



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.TabIndex = False
        'MsgBox(" " & bulba.Location.X & " " & bulba.Location.Y & "  ")
        MsgBox(Mapa1.Top)
        bulba.Focus()

    End Sub

    Private Sub Mapa1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mapa1.Click

    End Sub

    Private Sub bulba_Click(sender As Object, e As EventArgs) Handles bulba.Click

    End Sub
End Class