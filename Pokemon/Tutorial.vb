Imports System
Imports System.Media
Imports System.Windows.Forms

Public Class Tutorial
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Dim maximohe As Integer
    Dim maximome As Integer

    Dim medaño As Integer
    Dim hedaño As Integer
    Dim time As Integer = 0
    Dim time1 As Integer = 0

    Dim ronda As Integer = 1


    Private Sub Tutorial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PictureBox2.Controls.Add(Explosion)
        'PictureBox1.Controls.Add(lblHPnow)
        If ruta01 = 1 Then
            Me.BackgroundImage = Image.FromFile(" " & Application.StartupPath & "\Pokemones Battle\Fondos\grass3.png")

        End If

        If tuto1 = 1 Then
            btnSkill1.Visible = False
            btnSkill2.Visible = False
            btnSkill3.Visible = False


            'Me.myMedia.URL = "C:\Users\pc\Desktop\Pokemon\Pokemon\bin\Debug\wild.mp3"




            PokemonMe.Visible = True


            If pokemon1 < 10 Then


                PokemonMe.Image = Image.FromFile(" " & Application.StartupPath & "\Pokemones Battle\Back\Normal\00" & pokemon1 & ".gif")
            End If

            If pokemon1 < 100 And pokemon1 >= 10 Then


                PokemonMe.Image = Image.FromFile(" " & Application.StartupPath & "\Pokemones Battle\Back\Normal\0" & pokemon1 & ".gif")
            End If

            If pokemon1 >= 100 Then


                PokemonMe.Image = Image.FromFile(" " & Application.StartupPath & "\Pokemones Battle\Back\Normal\" & pokemon1 & ".gif")
            End If


            ''
           





            barMe.Value = 100
            barHe.Value = 100
            maximohe = barHe.Value
            maximome = barMe.Value
            lblHPMax.Text = maximome
            barMe.Minimum = 0
            barHe.Minimum = 0

            lblHe.Visible = False
            lblMe.Text = "HP: " & barMe.Value & "/ " & maximome & " "
            lblHPnow.Text = hpnow

            Me.Show()
            Primarios.Close()
        Else
            pokewild()
            dañome()


            '       habilidadhe = "None"
            dañohe()

      

            btnSkill1.Text = skill1
            btnSkill2.Text = skill2
            btnSkill3.Text = skill3
            btnSkill4.Text = skill4


            barMe.Minimum = 0
            barHe.Minimum = 0



            barMe.Value = hp
            barHe.Value = hpw
            maximohe = barHe.Value
            maximome = barMe.Value

            lblMe.Text = "HP: " & barMe.Value & "/ " & maximome & " "
            lblHPnow.Text = hpnow
            lblHPMax.Text = maximome

            PokemonMe.Visible = True
            lblNickhe.Visible = True
            lblNickMe.Visible = True
            lblNickMe.Text = PokeNicks.Items(pokemon1)
            lblNickhe.Text = PokeNicks.Items(wild)

            If pokemon1 < 10 Then


                PokemonMe.Image = Image.FromFile(" " & Application.StartupPath & "\Pokemones Battle\Back\Normal\00" & pokemon1 & ".gif")
            End If

            If pokemon1 < 100 And pokemon1 >= 10 Then


                PokemonMe.Image = Image.FromFile(" " & Application.StartupPath & "\Pokemones Battle\Back\Normal\0" & pokemon1 & ".gif")
            End If

            If pokemon1 >= 100 Then


                PokemonMe.Image = Image.FromFile(" " & Application.StartupPath & "\Pokemones Battle\Back\Normal\" & pokemon1 & ".gif")
            End If






            lblMelvl.Text = LVL
            lblHelvl.Text = lvlwild


            If wild < 10 Then
                PictureBox2.Image = Image.FromFile(" " & Application.StartupPath & "\Pokemones Battle\Front\Normal\00" & wild & ".gif")
            End If

            If wild < 100 And wild >= 10 Then


                PictureBox2.Image = Image.FromFile(" " & Application.StartupPath & "\Pokemones Battle\Front\Normal\0" & wild & ".gif")
            End If

            If wild >= 100 Then


                PictureBox2.Image = Image.FromFile(" " & Application.StartupPath & "\Pokemones Battle\Front\Normal\" & wild & ".gif")


            End If
        End If

        'MsgBox("Este es un tutorial de batallas del juego, presione sobre Tackle para acabar con el enemigo")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkill4.Click
        If tuto1 = 1 Then
        


            Dim nombre As String



            If pokemon1 = 1 Then
                nombre = "Bulbasur"
            End If

            If pokemon1 = 7 Then
                nombre = "Squartle"
            End If
            If pokemon1 = 4 Then
                nombre = "Charmander"
            End If

            medaño = medaño + 20
            hedaño = hedaño + 5


            barHe.Value = 100 - medaño
            barMe.Value = 100 - hedaño
            lblHPnow.Text = barMe.Value
            hpnow = barMe.Value


            lblHPMax.Text = maximome


            pelea.Text = pelea.Text + "" & vbCrLf & "" & vbCrLf & "Ronda Nº" & ronda & "" & vbCrLf & "" & vbCrLf & "" + "" & nombre & ": usa tackle, ratata recibe 20 de daño" & vbCrLf & "Ratata: usa tackle, " & nombre & " recibe 5 de daño"

            If tuto = 0 Then
                MsgBox("Bien hecho, continua hasta debilitar al rival")
                tuto = tuto + 1
            End If
            ronda = ronda + 1

            hphe.Width = hphe.Width - 20
            HPme.Width = HPme.Width - 5

            If hphe.Width <= 30 Then
                hphe.Image = vidas.Images(1)
            End If

            If hphe.Width <= 50 And hphe.Width > 30 Then
                hphe.Image = vidas.Images(0)

            End If


            If HPme.Width <= 30 Then
                HPme.Image = vidas.Images(1)
            End If

            If HPme.Width <= 50 And HPme.Width > 30 Then
                HPme.Image = vidas.Images(0)

            End If


            If barHe.Value <= 100 And barHe.Value >= 50 Then

            Else


            End If

            If barMe.Value <= 100 And barMe.Value >= 50 Then
                barMe.ForeColor = Color.Green
            Else
                barMe.ForeColor = Color.Red

            End If


            If barHe.Value = 0 Or barMe.Value = 0 Then
                pelea.Text = pelea.Text + "" & vbCrLf & "Ratata no tiene más PV para continuar la batalla, ganador " & nombre & ""

                btnSkill4.Enabled = False



                Explot.Enabled = True




                ' Explosion.Image = ImageList1.Images(2)
                'Sleep(1000)
                'Explosion.Image = ImageList1.Images(3)
                'Sleep(1000)
                'Explosion.Image = ImageList1.Images(4)


                pokemon1 = primario
                MsgBox("¡Felicidades, has completado el tutorial!")
                Laboratorio.Show()
                Me.Close()

            End If




        Else



            habilidad = btnSkill4.Text
            dañome()
            dañohe()
        
       

            ''daño
            If barHe.Value - total2 <= 0 Then
                pelea.Text = pelea.Text + "" & vbCrLf & "" & nickwild & " no tiene más PV para continuar la batalla, ganador " & lblNickMe.Text & ""
                hphe.Width = 0




                Explot.Enabled = True
                PokemonMe.Visible = True
                PictureBox2.Visible = False
                exp = exp + 20
                MsgBox("EXP GANADA " & exp & "")
                If ruta01 = 1 Then
                    Ruta1.Show()

                    Me.Close()
                End If




            Else
                If barMe.Value - total2he <= 0 Then
                    pelea.Text = pelea.Text + "" & vbCrLf & "" & lblNickMe.Text & " no tiene más PV para continuar la batalla, ganador " & lblNickhe.Text & ""
                    HPme.Width = 0
                    lblHPnow.Text = 0

                    Explosion.Location = PokemonMe.Location


                    Explot.Enabled = True

                    PokemonMe.Visible = False
                    PictureBox2.Visible = True
                Else

                    barHe.Value = barHe.Value - total2
                    barMe.Value = barMe.Value - total2he


                    lblHPnow.Text = barMe.Value


                    hphe.Width = hphe.Width - total2
                    HPme.Width = HPme.Width - total2he
                    ''daño
                    pelea.Text = pelea.Text + "" & vbCrLf & "" & vbCrLf & "Ronda Nº" & ronda & "" & vbCrLf & "" & vbCrLf & "" + "" & lblNickMe.Text & ": usa " & habilidad & ", " & lblNickhe.Text & " recibe " & total2 & " de daño" & vbCrLf & "" & lblNickhe.Text & ": usa " & habilidadhe & ", " & lblNickMe.Text & " recibe " & total2he & " de daño"
                    ronda = ronda + 1



                    '''''''''''''''''''HE''''''''''''''''''''''''''''
                    Dim porsentaje As Integer
                    porsentaje = barHe.Value * 100 / hpw
                    Dim bajar As Integer = 100
                    Dim real As Integer
                    real = 100 - porsentaje

                    hphe.Width = bajar - real


                    If porsentaje <= 30 Then
                        hphe.Image = vidas.Images(1)
                    End If


                    If porsentaje <= 50 And porsentaje > 30 Then
                        hphe.Image = vidas.Images(0)

                    End If


                    If porsentaje <= 100 And porsentaje >= 50 Then

                    Else


                    End If
                    '     MsgBox(porsentaje)

                    ''''''''''''''''''''''HE''''''''''''''''''''''''''''''''''






                    '''''''''''''''''MIO''''''''''''''''''''''''''''''
                    Dim porsentaje2 As Integer
                    porsentaje2 = barMe.Value * 100 / hp
                    Dim bajar2 As Integer = 100
                    Dim real2 As Integer
                    real2 = 100 - porsentaje2

                    HPme.Width = bajar2 - real2


                    If porsentaje2 <= 30 Then
                        HPme.Image = vidas.Images(1)
                    End If


                    If porsentaje2 <= 50 And porsentaje2 > 30 Then
                        HPme.Image = vidas.Images(0)

                    End If


                    If porsentaje2 <= 100 And porsentaje2 >= 50 Then

                    Else


                    End If
                    '     MsgBox(porsentaje)

                    '''''''''''MIO'''''''''''''''''''''''''''''''''''''''''''''






                End If
            End If
        End If
      


    End Sub

    Private Sub pelea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pelea.TextChanged
        pelea.SelectionStart = pelea.TextLength
        pelea.ScrollToCaret()
    End Sub



    Private Sub squa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Explot.Tick
        If time >= 0 Then
            time = time + 1
            Label1.Text = time
        Else
            Explot.Enabled = False
        End If


        If time = 1 Then
            Explosion.Visible = True
            Explosion.Image = Explo.Images(0)

        End If


        If time = 2 Then
            Explosion.Visible = True
            Explosion.Image = Explo.Images(1)
        End If

        If time = 3 Then
            Explosion.Visible = True
            Explosion.Image = Explo.Images(2)
        End If

        If time = 4 Then
            Explosion.Visible = True
            Explosion.Image = Explo.Images(3)
        End If

        If time = 5 Then
            Explosion.Visible = True
            Explosion.Image = Explo.Images(4)
        End If

        If time = 6 Then
            Explosion.Visible = False

        End If

    End Sub

    Private Sub Change_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Change.Tick

        If time1 >= 0 Then
            time1 = time1 + 1
            Label1.Text = time1
        Else
            Change.Enabled = False
        End If

        If time1 = 1 Then
            Cambio.Visible = True
            Cambio.Image = Rojo.Images(0)

        End If

        If time1 = 2 Then
            Cambio.Visible = True
            Cambio.Image = Rojo.Images(1)
        End If

        If time1 = 3 Then
            Cambio.Visible = True
            Cambio.Image = Rojo.Images(2)
        End If

        If time1 = 4 Then
            Cambio.Visible = True
            Cambio.Image = Rojo.Images(3)
        End If

        If time1 = 5 Then
            Cambio.Visible = True
            Cambio.Image = Rojo.Images(4)
        End If

        If time1 = 6 Then

            Cambio.Visible = False
            Change.Enabled = False
            time1 = 0
        End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambio.Click
        Change.Enabled = True

    End Sub

 
    Private Sub btnSkill1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkill1.Click

        habilidad = btnSkill1.Text
        dañome()
        dañohe()



        ''daño
        If barHe.Value - total2 <= 0 Then
            pelea.Text = pelea.Text + "" & vbCrLf & "" & nickwild & " no tiene más PV para continuar la batalla, ganador " & lblNickMe.Text & ""
            hphe.Width = 0




            Explot.Enabled = True
            PokemonMe.Visible = True
            PictureBox2.Visible = False
        Else
            If barMe.Value - total2he <= 0 Then
                pelea.Text = pelea.Text + "" & vbCrLf & "" & lblNickMe.Text & " no tiene más PV para continuar la batalla, ganador " & lblNickhe.Text & ""
                HPme.Width = 0
                lblHPnow.Text = 0

                Explosion.Location = PokemonMe.Location


                Explot.Enabled = True

                PokemonMe.Visible = False
                PictureBox2.Visible = True
            Else

                barHe.Value = barHe.Value - total2
                barMe.Value = barMe.Value - total2he

                lblHPnow.Text = barMe.Value
                hphe.Width = hphe.Width - total2
                HPme.Width = HPme.Width - total2he
                ''daño
                pelea.Text = pelea.Text + "" & vbCrLf & "" & vbCrLf & "Ronda Nº" & ronda & "" & vbCrLf & "" & vbCrLf & "" + "" & lblNickMe.Text & ": usa " & habilidad & ", " & lblNickhe.Text & " recibe " & total2 & " de daño" & vbCrLf & "" & lblNickhe.Text & ": usa " & habilidadhe & ", " & lblNickMe.Text & " recibe " & total2he & " de daño"
                ronda = ronda + 1



                '''''''''''''''''''HE''''''''''''''''''''''''''''
                Dim porsentaje As Integer
                porsentaje = barHe.Value * 100 / hpw
                Dim bajar As Integer = 100
                Dim real As Integer
                real = 100 - porsentaje

                hphe.Width = bajar - real


                If porsentaje <= 30 Then
                    hphe.Image = vidas.Images(1)
                End If


                If porsentaje <= 50 And porsentaje > 30 Then
                    hphe.Image = vidas.Images(0)

                End If


                If porsentaje <= 100 And porsentaje >= 50 Then

                Else


                End If
                '     MsgBox(porsentaje)

                ''''''''''''''''''''''HE''''''''''''''''''''''''''''''''''






                '''''''''''''''''MIO''''''''''''''''''''''''''''''
                Dim porsentaje2 As Integer
                porsentaje2 = barMe.Value * 100 / hp
                Dim bajar2 As Integer = 100
                Dim real2 As Integer
                real2 = 100 - porsentaje2

                HPme.Width = bajar2 - real2


                If porsentaje2 <= 30 Then
                    HPme.Image = vidas.Images(1)
                End If


                If porsentaje2 <= 50 And porsentaje2 > 30 Then
                    HPme.Image = vidas.Images(0)

                End If


                If porsentaje2 <= 100 And porsentaje2 >= 50 Then

                Else


                End If
                '     MsgBox(porsentaje)

                '''''''''''MIO'''''''''''''''''''''''''''''''''''''''''''''






            End If
        End If



  
    End Sub

    Private Sub btnSkill2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkill2.Click

        habilidad = btnSkill2.Text
        dañome()
        dañohe()



        ''daño
        If barHe.Value - total2 <= 0 Then
            pelea.Text = pelea.Text + "" & vbCrLf & "" & nickwild & " no tiene más PV para continuar la batalla, ganador " & lblNickMe.Text & ""
            hphe.Width = 0




            Explot.Enabled = True
            PokemonMe.Visible = True
            PictureBox2.Visible = False
        Else
            If barMe.Value - total2he <= 0 Then
                pelea.Text = pelea.Text + "" & vbCrLf & "" & lblNickMe.Text & " no tiene más PV para continuar la batalla, ganador " & lblNickhe.Text & ""
                HPme.Width = 0
                lblHPnow.Text = 0

                Explosion.Location = PokemonMe.Location


                Explot.Enabled = True

                PokemonMe.Visible = False
                PictureBox2.Visible = True
            Else

                barHe.Value = barHe.Value - total2
                barMe.Value = barMe.Value - total2he

                lblHPnow.Text = barMe.Value
                hphe.Width = hphe.Width - total2
                HPme.Width = HPme.Width - total2he
                ''daño
                pelea.Text = pelea.Text + "" & vbCrLf & "" & vbCrLf & "Ronda Nº" & ronda & "" & vbCrLf & "" & vbCrLf & "" + "" & lblNickMe.Text & ": usa " & habilidad & ", " & lblNickhe.Text & " recibe " & total2 & " de daño" & vbCrLf & "" & lblNickhe.Text & ": usa " & habilidadhe & ", " & lblNickMe.Text & " recibe " & total2he & " de daño"
                ronda = ronda + 1



                '''''''''''''''''''HE''''''''''''''''''''''''''''
                Dim porsentaje As Integer
                porsentaje = barHe.Value * 100 / hpw
                Dim bajar As Integer = 100
                Dim real As Integer
                real = 100 - porsentaje

                hphe.Width = bajar - real


                If porsentaje <= 30 Then
                    hphe.Image = vidas.Images(1)
                End If


                If porsentaje <= 50 And porsentaje > 30 Then
                    hphe.Image = vidas.Images(0)

                End If


                If porsentaje <= 100 And porsentaje >= 50 Then

                Else


                End If
                '     MsgBox(porsentaje)

                ''''''''''''''''''''''HE''''''''''''''''''''''''''''''''''






                '''''''''''''''''MIO''''''''''''''''''''''''''''''
                Dim porsentaje2 As Integer
                porsentaje2 = barMe.Value * 100 / hp
                Dim bajar2 As Integer = 100
                Dim real2 As Integer
                real2 = 100 - porsentaje2

                HPme.Width = bajar2 - real2


                If porsentaje2 <= 30 Then
                    HPme.Image = vidas.Images(1)
                End If


                If porsentaje2 <= 50 And porsentaje2 > 30 Then
                    HPme.Image = vidas.Images(0)

                End If


                If porsentaje2 <= 100 And porsentaje2 >= 50 Then

                Else


                End If
                '     MsgBox(porsentaje)

                '''''''''''MIO'''''''''''''''''''''''''''''''''''''''''''''






            End If
        End If



 
  
    End Sub

    Private Sub btnSkill3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkill3.Click

        habilidad = btnSkill3.Text
        dañome()
        dañohe()



        ''daño
        If barHe.Value - total2 <= 0 Then
            pelea.Text = pelea.Text + "" & vbCrLf & "" & nickwild & " no tiene más PV para continuar la batalla, ganador " & lblNickMe.Text & ""
            hphe.Width = 0




            Explot.Enabled = True
            PokemonMe.Visible = True
            PictureBox2.Visible = False
        Else
            If barMe.Value - total2he <= 0 Then
                pelea.Text = pelea.Text + "" & vbCrLf & "" & lblNickMe.Text & " no tiene más PV para continuar la batalla, ganador " & lblNickhe.Text & ""
                HPme.Width = 0
                lblHPnow.Text = 0

                Explosion.Location = PokemonMe.Location


                Explot.Enabled = True

                PokemonMe.Visible = False
                PictureBox2.Visible = True
            Else

                barHe.Value = barHe.Value - total2
                barMe.Value = barMe.Value - total2he

                lblHPnow.Text = barMe.Value
                hphe.Width = hphe.Width - total2
                HPme.Width = HPme.Width - total2he
                ''daño
                pelea.Text = pelea.Text + "" & vbCrLf & "" & vbCrLf & "Ronda Nº" & ronda & "" & vbCrLf & "" & vbCrLf & "" + "" & lblNickMe.Text & ": usa " & habilidad & ", " & lblNickhe.Text & " recibe " & total2 & " de daño" & vbCrLf & "" & lblNickhe.Text & ": usa " & habilidadhe & ", " & lblNickMe.Text & " recibe " & total2he & " de daño"
                ronda = ronda + 1



                '''''''''''''''''''HE''''''''''''''''''''''''''''
                Dim porsentaje As Integer
                porsentaje = barHe.Value * 100 / hpw
                Dim bajar As Integer = 100
                Dim real As Integer
                real = 100 - porsentaje

                hphe.Width = bajar - real


                If porsentaje <= 30 Then
                    hphe.Image = vidas.Images(1)
                End If


                If porsentaje <= 50 And porsentaje > 30 Then
                    hphe.Image = vidas.Images(0)

                End If


                If porsentaje <= 100 And porsentaje >= 50 Then

                Else


                End If
                '     MsgBox(porsentaje)

                ''''''''''''''''''''''HE''''''''''''''''''''''''''''''''''






                '''''''''''''''''MIO''''''''''''''''''''''''''''''
                Dim porsentaje2 As Integer
                porsentaje2 = barMe.Value * 100 / hp
                Dim bajar2 As Integer = 100
                Dim real2 As Integer
                real2 = 100 - porsentaje2

                HPme.Width = bajar2 - real2


                If porsentaje2 <= 30 Then
                    HPme.Image = vidas.Images(1)
                End If


                If porsentaje2 <= 50 And porsentaje2 > 30 Then
                    HPme.Image = vidas.Images(0)

                End If


                If porsentaje2 <= 100 And porsentaje2 >= 50 Then

                Else


                End If
                '     MsgBox(porsentaje)

                '''''''''''MIO'''''''''''''''''''''''''''''''''''''''''''''






            End If
        End If



  
    End Sub

    Private Sub PokeNicks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PokeNicks.SelectedIndexChanged

    End Sub
End Class