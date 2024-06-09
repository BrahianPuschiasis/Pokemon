Public Class Ruta1




    Private Sub Ruta1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Label1.Text = " X:" & bulba.Location.X & " Y:" & bulba.Location.Y & "  "
        Label2.Text = " TOP:" & Mapa1.Top & " LEFT:" & Mapa1.Left & "  "

        Select Case e.KeyCode





            '-------------------------------------------------------------------------------------
            '---------------------------------------------------------
            Case Keys.C
                Pokemones.Show()


            Case Keys.W
                If Me.bulba.Location.X >= 550 And Me.bulba.Location.X <= 696 And Me.bulba.Location.Y <= 786 And Me.bulba.Location.Y >= 671 Then
                    ' Initialize the random-number generator.
                    Me.bulba.Location = New Point(Me.bulba.Location.X, Me.bulba.Location.Y - 5)
                    Randomize()
                    ' Generate random value between 1 and 6.
                    Dim value As Integer = CInt(Int((400 * Rnd()) + 1))
                    If value <= 20 Then
                        nickwild = "Rattata"
                        Tutorial.Show()
                        Me.Hide()
                    End If
                    If value >= 90 And value <= 100 Then
                        nickwild = "Pidgey"
                        Tutorial.Show()
                        Me.Hide()
                    End If
                    If caminar = 0 Then
                        bulba.Image = ImageList1.Images(0)
                        caminar = caminar + 1



                    Else
                        bulba.Image = ImageList1.Images(1)
                        caminar = 0
                    End If


                Else

                    If Me.bulba.Location.Y = 141 And Me.bulba.Location.X >= 255 And Me.bulba.Location.X <= 360 Then
                        bulba.Image = ImageList1.Images(0)
                    Else
                        If Me.bulba.Location.Y = 146 And Me.bulba.Location.X >= 485 And Me.bulba.Location.X <= 645 Then
                            bulba.Image = ImageList1.Images(0)
                        Else
                            If Me.bulba.Location.Y = 26 And Me.bulba.Location.X >= 595 And Me.bulba.Location.X <= 815 Then
                                bulba.Image = ImageList1.Images(0)
                            Else
                                If Me.bulba.Location.Y = 26 And Me.bulba.Location.X >= 255 And Me.bulba.Location.X <= 475 Then
                                    bulba.Image = ImageList1.Images(0)
                                Else
                                    If Me.bulba.Location.Y = 316 And Me.bulba.Location.X >= 255 And Me.bulba.Location.X <= 480 Then
                                        bulba.Image = ImageList1.Images(0)
                                    Else
                                        If Me.bulba.Location.Y = 446 And Me.bulba.Location.X >= 255 And Me.bulba.Location.X <= 655 Then
                                            bulba.Image = ImageList1.Images(0)
                                        Else
                                            If Me.bulba.Location.Y = 571 And Me.bulba.Location.X >= 505 And Me.bulba.Location.X <= 815 Then
                                                bulba.Image = ImageList1.Images(0)
                                            Else
                                                If Me.bulba.Location.Y = 571 And Me.bulba.Location.X >= 340 And Me.bulba.Location.X <= 450 Then
                                                    bulba.Image = ImageList1.Images(0)
                                                Else
                                                    If Me.bulba.Location.Y = 571 And Me.bulba.Location.X >= 255 And Me.bulba.Location.X <= 305 Then
                                                        bulba.Image = ImageList1.Images(0)
                                                    Else
                                                        If Me.bulba.Location.Y = 741 And Me.bulba.Location.X >= 710 And Me.bulba.Location.X <= 815 Then
                                                            bulba.Image = ImageList1.Images(0)
                                                        Else
                                                            If Me.bulba.Location.Y = 741 And Me.bulba.Location.X >= 255 And Me.bulba.Location.X <= 545 Then
                                                                bulba.Image = ImageList1.Images(0)
                                                            Else
                                                                If Me.bulba.Location.Y = 896 And Me.bulba.Location.X >= 445 And Me.bulba.Location.X <= 815 Then
                                                                    bulba.Image = ImageList1.Images(0)
                                                                Else
                                                                    If Me.bulba.Location.Y = 896 And Me.bulba.Location.X >= 255 And Me.bulba.Location.X <= 365 Then
                                                                        bulba.Image = ImageList1.Images(0)
                                                                    Else
                                                                        Me.bulba.Location = New Point(Me.bulba.Location.X, Me.bulba.Location.Y - 5)
                                                                        If Mapa1.Top = 0 Then

                                                                        Else

                                                                            If bulba.Location.Y <= 771 Then
                                                                                Mapa1.Top = Mapa1.Top + 5

                                                                            End If
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
                        End If
                    End If
                End If


            Case Keys.S
                If Me.bulba.Location.X >= 550 And Me.bulba.Location.X <= 696 And Me.bulba.Location.Y <= 786 And Me.bulba.Location.Y >= 671 Then
                    Me.bulba.Location = New Point(Me.bulba.Location.X, Me.bulba.Location.Y + 5)
                    Randomize()
                    ' Generate random value between 1 and 6.
                    Dim value As Integer = CInt(Int((400 * Rnd()) + 1))
                    If value <= 20 Then
                        nickwild = "Rattata"
                        Tutorial.Show()
                        Me.Hide()
                    End If
                    If value >= 90 And value <= 100 Then
                        nickwild = "Pidgey"
                        Tutorial.Show()
                        Me.Hide()
                    End If
                    If caminar = 0 Then
                        bulba.Image = ImageList1.Images(3)
                        caminar = caminar + 1

                    Else
                        bulba.Image = ImageList1.Images(7)
                        caminar = 0
                    End If

                Else

                    If Me.bulba.Location.Y = 221 And Me.bulba.Location.X >= 255 And Me.bulba.Location.X <= 370 Then
                        bulba.Image = ImageList1.Images(11)
                    Else

                        If Me.bulba.Location.Y = 51 And Me.bulba.Location.X >= 420 And Me.bulba.Location.X <= 480 Then
                            bulba.Image = ImageList1.Images(11)
                        Else
                            If Me.bulba.Location.Y = 371 And Me.bulba.Location.X >= 315 And Me.bulba.Location.X <= 470 Then
                                Me.bulba.Location = New Point(Me.bulba.Location.X, Me.bulba.Location.Y + 5)
                                bulba.Image = ImageList1.Images(11)
                                If Mapa1.Top = -525 Then
                                    bulba.Image = ImageList1.Images(11)
                                Else
                                    If bulba.Location.Y >= 261 Then
                                        Mapa1.Top = Mapa1.Top - 5

                                    End If
                                End If
                            Else
                                If Me.bulba.Location.Y = 371 And Me.bulba.Location.X >= 255 And Me.bulba.Location.X <= 655 Then
                                    bulba.Image = ImageList1.Images(11)
                                Else
                                    If Me.bulba.Location.Y = 646 And Me.bulba.Location.X >= 255 And Me.bulba.Location.X <= 545 Then
                                        bulba.Image = ImageList1.Images(11)
                                    Else
                                        If Me.bulba.Location.Y = 841 And Me.bulba.Location.X >= 445 And Me.bulba.Location.X <= 480 Then
                                            bulba.Image = ImageList1.Images(11)
                                        Else
                                            If Me.bulba.Location.Y = 996 And Me.bulba.Location.X >= 590 And Me.bulba.Location.X <= 815 Then
                                                bulba.Image = ImageList1.Images(11)
                                            Else
                                                If Me.bulba.Location.Y = 996 And Me.bulba.Location.X >= 255 And Me.bulba.Location.X <= 535 Then
                                                    bulba.Image = ImageList1.Images(11)
                                                Else
                                                    If Me.bulba.Location.Y = 1096 And Me.bulba.Location.X >= 545 And Me.bulba.Location.X <= 580 Then
                                                        bulba.Image = ImageList1.Images(11)

                                                        PuebloPaleta.Show()



                                                        Me.Close()

                                                    Else

                                                        Me.bulba.Location = New Point(Me.bulba.Location.X, Me.bulba.Location.Y + 5)
                                                        If Mapa1.Top = -525 Then
                                                            bulba.Image = ImageList1.Images(3)
                                                        Else
                                                            If bulba.Location.Y >= 261 Then
                                                                Mapa1.Top = Mapa1.Top - 5

                                                            End If

                                                        End If
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


            Case Keys.A
                If Me.bulba.Location.X >= 550 And Me.bulba.Location.X <= 696 And Me.bulba.Location.Y <= 786 And Me.bulba.Location.Y >= 671 Then

                Else

                    If Me.bulba.Location.X = 365 And Me.bulba.Location.Y >= 126 And Me.bulba.Location.Y <= 136 Then
                        bulba.Image = ImageList1.Images(8)
                    Else
                        If Me.bulba.Location.X = 480 And Me.bulba.Location.Y >= -24 And Me.bulba.Location.Y <= 21 Then
                            bulba.Image = ImageList1.Images(8)
                        Else
                            If Me.bulba.Location.X = 650 And Me.bulba.Location.Y >= 126 And Me.bulba.Location.Y <= 141 Then
                                bulba.Image = ImageList1.Images(8)
                            Else
                                If Me.bulba.Location.X = 375 And Me.bulba.Location.Y >= 226 And Me.bulba.Location.Y <= 306 Then
                                    bulba.Image = ImageList1.Images(8)
                                Else
                                    If Me.bulba.Location.X = 485 And Me.bulba.Location.Y >= 56 And Me.bulba.Location.Y <= 311 Then
                                        bulba.Image = ImageList1.Images(8)
                                    Else
                                        If Me.bulba.Location.X = 315 And Me.bulba.Location.Y >= 367 And Me.bulba.Location.Y <= 441 Then
                                            bulba.Image = ImageList1.Images(8)
                                        Else
                                            If Me.bulba.Location.X = 660 And Me.bulba.Location.Y >= 376 And Me.bulba.Location.Y <= 441 Then
                                                bulba.Image = ImageList1.Images(8)
                                            Else
                                                If Me.bulba.Location.X = 310 And Me.bulba.Location.Y >= 546 And Me.bulba.Location.Y <= 566 Then
                                                    bulba.Image = ImageList1.Images(8)
                                                Else
                                                    If Me.bulba.Location.X = 455 And Me.bulba.Location.Y >= 546 And Me.bulba.Location.Y <= 566 Then
                                                        bulba.Image = ImageList1.Images(8)
                                                    Else

                                                        If Me.bulba.Location.X = 550 And Me.bulba.Location.Y >= 651 And Me.bulba.Location.Y <= 736 Then
                                                            bulba.Image = ImageList1.Images(8)
                                                        Else
                                                            If Me.bulba.Location.X = 485 And Me.bulba.Location.Y >= 846 And Me.bulba.Location.Y <= 891 Then
                                                                bulba.Image = ImageList1.Images(8)
                                                            Else
                                                                If Me.bulba.Location.X = 370 And Me.bulba.Location.Y >= 866 And Me.bulba.Location.Y <= 891 Then
                                                                    bulba.Image = ImageList1.Images(8)
                                                                Else
                                                                    If Me.bulba.Location.X = 255 And Me.bulba.Location.Y >= 21 And Me.bulba.Location.Y <= 996 Then
                                                                        bulba.Image = ImageList1.Images(8)
                                                                    Else

                                                                        If Me.bulba.Location.X = 540 And Me.bulba.Location.Y >= 1001 And Me.bulba.Location.Y <= 1086 Then
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
                If Me.bulba.Location.X >= 550 And Me.bulba.Location.X <= 696 And Me.bulba.Location.Y <= 786 And Me.bulba.Location.Y >= 671 Then

                Else

                    If Me.bulba.Location.X = 590 And Me.bulba.Location.Y >= -24 And Me.bulba.Location.Y <= 21 Then
                        bulba.Image = ImageList1.Images(4)
                    Else
                        If Me.bulba.Location.X = 415 And Me.bulba.Location.Y >= 56 And Me.bulba.Location.Y <= 311 Then
                            bulba.Image = ImageList1.Images(4)
                        Else
                            If Me.bulba.Location.X = 470 And Me.bulba.Location.Y >= 367 And Me.bulba.Location.Y <= 441 Then
                                bulba.Image = ImageList1.Images(4)
                            Else
                                If Me.bulba.Location.X = 335 And Me.bulba.Location.Y >= 546 And Me.bulba.Location.Y <= 566 Then
                                    bulba.Image = ImageList1.Images(4)
                                Else

                                    If Me.bulba.Location.X = 500 And Me.bulba.Location.Y >= 546 And Me.bulba.Location.Y <= 566 Then
                                        bulba.Image = ImageList1.Images(4)
                                    Else

                                        If Me.bulba.Location.X = 705 And Me.bulba.Location.Y >= 721 And Me.bulba.Location.Y <= 736 Then
                                            bulba.Image = ImageList1.Images(4)
                                        Else
                                            If Me.bulba.Location.X = 440 And Me.bulba.Location.Y >= 846 And Me.bulba.Location.Y <= 891 Then
                                                bulba.Image = ImageList1.Images(4)
                                            Else
                                                If Me.bulba.Location.X = 815 And Me.bulba.Location.Y >= 21 And Me.bulba.Location.Y <= 996 Then
                                                    bulba.Image = ImageList1.Images(4)
                                                Else
                                                    If Me.bulba.Location.X = 585 And Me.bulba.Location.Y >= 1001 And Me.bulba.Location.Y <= 1086 Then
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
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
        End Select

    End Sub

    Private Sub Ruta1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mapa1.Controls.Add(bulba)
        Mapa1.Width = Mapa1.Width * 2
        Mapa1.Height = Mapa1.Height * 2
        bulba.Image = ImageList1.Images(0)

        Me.bulba.Location = New Point(560, 1056)
        ruta01 = 1
        Me.Mapa1.Top = -525
        Me.Mapa1.Left = -213
    End Sub

    Private Sub Mapa1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mapa1.Click

    End Sub
End Class