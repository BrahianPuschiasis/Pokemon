Imports MySql.Data.MySqlClient
Imports System
Imports System.Media
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading


Public Class MenuPrincipal

    Private Sub btnRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistro.Click
        Registro.Show()
        Me.Hide()

    End Sub

    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click


        conectar.Open()

        Dim cmd111 As New MySqlCommand("select Nombre from PokemonUsuarios where Nombre = '" & txtNombre.Text & "'", conectar)
        cmd111.ExecuteScalar()
        jugador = cmd111.ExecuteScalar

        If jugador <> "" Then
            Dim cmd13 As New MySqlCommand("select Contraseña from PokemonUsuarios where Nombre = '" & txtNombre.Text & "'", conectar)
            cmd13.ExecuteScalar()
            Dim verificar As String
            verificar = cmd13.ExecuteScalar

            If txtContraseña.Text = verificar Then
                jugador = txtNombre.Text
                Dim cmd135 As New MySqlCommand("select Primario from PokemonUsuarios where Nombre = '" & txtNombre.Text & "'", conectar)
                primario = cmd135.ExecuteScalar

                Dim cmd1315 As New MySqlCommand("select Nick from PokemonUsuarios where Nombre = '" & txtNombre.Text & "'", conectar)
                nick = cmd1315.ExecuteScalar

                Dim cmd1 As New MySqlCommand("select Pokemon1 from PokemonUsuarios where Nombre = '" & txtNombre.Text & "'", conectar)
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


                Opening.close()


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


        Select e.KeyCode




            '-------------------------------------------------------------------------------------
            '---------------------------------------------------------


            Case Keys.Enter


                conectar.Open()

                Dim cmd111 As New MySqlCommand("select Nombre from PokemonUsuarios where Nombre = '" & txtNombre.Text & "'", conectar)
                cmd111.ExecuteScalar()
                jugador = cmd111.ExecuteScalar

                If jugador <> "" Then
                    Dim cmd13 As New MySqlCommand("select Contraseña from PokemonUsuarios where Nombre = '" & txtNombre.Text & "'", conectar)
                    cmd13.ExecuteScalar()
                    Dim verificar As String
                    verificar = cmd13.ExecuteScalar

                    If txtContraseña.Text = verificar Then
                        jugador = txtNombre.Text
                        Dim cmd135 As New MySqlCommand("select Primario from PokemonUsuarios where Nombre = '" & txtNombre.Text & "'", conectar)
                        primario = cmd135.ExecuteScalar

                        Dim cmd1315 As New MySqlCommand("select Nick from PokemonUsuarios where Nombre = '" & txtNombre.Text & "'", conectar)
                        nick = cmd1315.ExecuteScalar

                        Dim cmd1 As New MySqlCommand("select Pokemon1 from PokemonUsuarios where Nombre = '" & txtNombre.Text & "'", conectar)
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


                        Opening.close()




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
        Opening.URL = " " & Application.StartupPath & "\login.mp3 "
        Opening.settings.setMode("loop", True)

    End Sub


    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub
End Class