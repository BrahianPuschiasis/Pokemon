Imports MySql.Data.MySqlClient
Imports System
Imports System.Media
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading
Imports NAudio.Wave



Public Class MenuPrincipal
    Private waveOut As WaveOutEvent
    Private mp3Reader As Mp3FileReader


    Private Sub btnRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistro.Click
        Registro.Show()
        Me.Hide()

    End Sub

    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click


        conectar.Open()

        Dim cmd111 As New MySqlCommand("select Nombre from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
        cmd111.ExecuteScalar()
        jugador = cmd111.ExecuteScalar

        If jugador <> "" Then
            Dim cmd13 As New MySqlCommand("select Contraseña from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
            cmd13.ExecuteScalar()
            Dim verificar As String
            verificar = cmd13.ExecuteScalar

            If txtContraseña2.Text = verificar Then
                jugador = txtNombre.Text
                Dim cmd135 As New MySqlCommand("select Primario from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
                primario = cmd135.ExecuteScalar

                Dim cmd1315 As New MySqlCommand("select Nick from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
                nick = cmd1315.ExecuteScalar

                Dim cmd1 As New MySqlCommand("select Pokemon1 from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
                pokemon1 = cmd1.ExecuteScalar



                Dim cmd1212 As New MySqlCommand("SELECT HP from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                hp = cmd1212.ExecuteScalar

                Dim attack1 As New MySqlCommand("SELECT Attack from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                attack = attack1.ExecuteScalar


                Dim Defense1 As New MySqlCommand("SELECT Defense from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                defense = Defense1.ExecuteScalar


                Dim SPAttack1 As New MySqlCommand("SELECT SPAttack from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                spattack = SPAttack1.ExecuteScalar


                Dim SPDefense1 As New MySqlCommand("SELECT SPDefense from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                spdefense = SPDefense1.ExecuteScalar


                Dim Speed1 As New MySqlCommand("SELECT Speed from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                speed = Speed1.ExecuteScalar

                Dim EXP1 As New MySqlCommand("SELECT EXP from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                exp = EXP1.ExecuteScalar

                Dim LVL1 As New MySqlCommand("SELECT LVL from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                LVL = LVL1.ExecuteScalar

                Dim skill01 As New MySqlCommand("SELECT Skill1 from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                skill1 = skill01.ExecuteScalar

                Dim skill02 As New MySqlCommand("SELECT Skill2 from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                skill2 = skill02.ExecuteScalar

                Dim skill03 As New MySqlCommand("SELECT Skill3 from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                skill3 = skill03.ExecuteScalar

                Dim skill04 As New MySqlCommand("SELECT Skill4 from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                skill4 = skill04.ExecuteScalar

                hpnow = hp

                CasaInicio.Show()
                ' MsgBox(hp)
                'MsgBox(attack)
                'MsgBox(Defense)
                'MsgBox(SPAttack)
                'MsgBox(SPDefense)
                'MsgBox(Speed)
                'MsgBox(EXP)
                'MsgBox(LVL)
                'MsgBox(skill1)
                'MsgBox(skill2)
                'MsgBox(skill3)
                'MsgBox(skill4)





                Me.Hide()
            Else
                MsgBox("Contraseña ingresada incorrecta")
            End If

        Else
            MsgBox("No existe ningun usuario con ese nombre")
        End If
        conectar.Close()

    End Sub

    Private Sub MenuPrincipal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown


        Select Case e.KeyCode




            '-------------------------------------------------------------------------------------
            '---------------------------------------------------------


            Case Keys.Enter


                conectar.Open()

                Dim cmd111 As New MySqlCommand("select Nombre from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
                cmd111.ExecuteScalar()
                jugador = cmd111.ExecuteScalar

                If jugador <> "" Then
                    Dim cmd13 As New MySqlCommand("select Contraseña from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
                    cmd13.ExecuteScalar()
                    Dim verificar As String
                    verificar = cmd13.ExecuteScalar

                    If txtContraseña2.Text = verificar Then
                        jugador = txtNombre.Text
                        Dim cmd135 As New MySqlCommand("select Primario from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
                        primario = cmd135.ExecuteScalar

                        Dim cmd1315 As New MySqlCommand("select Nick from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
                        nick = cmd1315.ExecuteScalar

                        Dim cmd1 As New MySqlCommand("select Pokemon1 from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
                        pokemon1 = cmd1.ExecuteScalar


                        Dim cmd1212 As New MySqlCommand("SELECT HP from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                        hp = cmd1212.ExecuteScalar

                        Dim attack1 As New MySqlCommand("SELECT Attack from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                        attack = attack1.ExecuteScalar


                        Dim Defense1 As New MySqlCommand("SELECT Defense from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                        defense = Defense1.ExecuteScalar


                        Dim SPAttack1 As New MySqlCommand("SELECT SPAttack from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                        spattack = SPAttack1.ExecuteScalar


                        Dim SPDefense1 As New MySqlCommand("SELECT SPDefense from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                        spdefense = SPDefense1.ExecuteScalar


                        Dim Speed1 As New MySqlCommand("SELECT Speed from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                        speed = Speed1.ExecuteScalar

                        Dim EXP1 As New MySqlCommand("SELECT EXP from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                        exp = EXP1.ExecuteScalar

                        Dim LVL1 As New MySqlCommand("SELECT LVL from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                        LVL = LVL1.ExecuteScalar

                        Dim skill01 As New MySqlCommand("SELECT Skill1 from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                        skill1 = skill01.ExecuteScalar

                        Dim skill02 As New MySqlCommand("SELECT Skill2 from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                        skill2 = skill02.ExecuteScalar

                        Dim skill03 As New MySqlCommand("SELECT Skill3 from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                        skill3 = skill03.ExecuteScalar

                        Dim skill04 As New MySqlCommand("SELECT Skill4 from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                        skill4 = skill04.ExecuteScalar

                        hpnow = hp
                        waveOut.Stop()

                        CasaInicio.Show()
                        ' MsgBox(hp)
                        'MsgBox(attack)
                        'MsgBox(Defense)
                        'MsgBox(SPAttack)
                        'MsgBox(SPDefense)
                        'MsgBox(Speed)
                        'MsgBox(EXP)
                        'MsgBox(LVL)
                        'MsgBox(skill1)
                        'MsgBox(skill2)
                        'MsgBox(skill3)
                        'MsgBox(skill4)







                        Me.Hide()
                    Else
                        MsgBox("Contraseña ingresada incorrecta")
                    End If

                Else
                    MsgBox("No existe ningun usuario con ese nombre")
                End If
                conectar.Close()



        End Select
    End Sub


    Private Sub MenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EjecutarScriptSQL()




        ' Ruta relativa al archivo MP3 en la carpeta principal del proyecto
        Dim mp3Path As String = System.IO.Path.Combine(Application.StartupPath, "Login.mp3")
        mp3Reader = New Mp3FileReader(mp3Path)
        waveOut = New WaveOutEvent()
        waveOut.Init(mp3Reader)
        waveOut.Volume = 0.1F ' Ajustar el volumen al 50%
        waveOut.Play()

    End Sub






    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub btnRegistros_Click(sender As Object, e As EventArgs) Handles btnRegistros.Click
        Registro.Show()
        Me.Hide()
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        conectar.Open()

        Dim cmd111 As New MySqlCommand("select Nombre from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
        cmd111.ExecuteScalar()
        jugador = cmd111.ExecuteScalar


        If jugador <> "" Then
            Dim cmd13 As New MySqlCommand("select Contraseña from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
            cmd13.ExecuteScalar()
            Dim verificar As String
            verificar = cmd13.ExecuteScalar

            If txtContraseña2.Text = verificar Then
                jugador = txtNombre.Text
                Dim cmd135 As New MySqlCommand("select Primario from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
                primario = cmd135.ExecuteScalar

                Dim cmd1315 As New MySqlCommand("select Nick from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
                nick = cmd1315.ExecuteScalar

                Dim cmd1 As New MySqlCommand("select Pokemon1 from PokemonUsuarios where Nombre = '" & txtNombre2.Text & "'", conectar)
                pokemon1 = cmd1.ExecuteScalar



                Dim cmd1212 As New MySqlCommand("SELECT HP from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                hp = cmd1212.ExecuteScalar

                Dim attack1 As New MySqlCommand("SELECT Attack from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                attack = attack1.ExecuteScalar


                Dim Defense1 As New MySqlCommand("SELECT Defense from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                defense = Defense1.ExecuteScalar


                Dim SPAttack1 As New MySqlCommand("SELECT SPAttack from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                spattack = SPAttack1.ExecuteScalar


                Dim SPDefense1 As New MySqlCommand("SELECT SPDefense from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                spdefense = SPDefense1.ExecuteScalar


                Dim Speed1 As New MySqlCommand("SELECT Speed from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                speed = Speed1.ExecuteScalar

                Dim EXP1 As New MySqlCommand("SELECT EXP from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                exp = EXP1.ExecuteScalar

                Dim LVL1 As New MySqlCommand("SELECT LVL from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                LVL = LVL1.ExecuteScalar

                Dim skill01 As New MySqlCommand("SELECT Skill1 from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                skill1 = skill01.ExecuteScalar

                Dim skill02 As New MySqlCommand("SELECT Skill2 from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                skill2 = skill02.ExecuteScalar

                Dim skill03 As New MySqlCommand("SELECT Skill3 from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                skill3 = skill03.ExecuteScalar

                Dim skill04 As New MySqlCommand("SELECT Skill4 from Pokemones where Nick = '" & nick & "' and PokemonID= " & pokemon1 & "", conectar)
                skill4 = skill04.ExecuteScalar

                hpnow = hp

                CasaInicio.Show()
                ' MsgBox(hp)
                'MsgBox(attack)
                'MsgBox(Defense)
                'MsgBox(SPAttack)
                'MsgBox(SPDefense)
                'MsgBox(Speed)
                'MsgBox(EXP)
                'MsgBox(LVL)
                'MsgBox(skill1)
                'MsgBox(skill2)
                'MsgBox(skill3)
                'MsgBox(skill4)




                waveOut.Stop()


                Me.Hide()
            Else
                MsgBox("Contraseña ingresada incorrecta")
            End If

        Else
            MsgBox("No existe ningun usuario con ese nombre")
        End If
        conectar.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombre2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class