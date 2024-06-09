Imports MySql.Data.MySqlClient
Public Class Registro

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        conectar.Open()

        Dim cmd11 As New MySqlCommand("select Email from PokemonUsuarios where Email = '" & txtEmail.Text & "'", conectar)
            cmd11.ExecuteScalar()

            If cmd11.ExecuteScalar <> "" Then
                MsgBox("Email ya usado")
            Else

                Dim cmd121 As New MySqlCommand("select Nick from PokemonUsuarios where Nick = '" & txtNick.Text & "'", conectar)
                cmd121.ExecuteScalar()

                If cmd121.ExecuteScalar <> "" Then
                    MsgBox("Nick ya usado")
                Else

                    Dim cmd111 As New MySqlCommand("INSERT INTO `PokemonUsuarios` (Nombre,Contraseña,Email,Genero,Primario,Nick,Pokemon1,Pokemon2,Pokemon3,Pokemon4,Pokemon5,Pokemon6,Zeny) VALUES ('" & txtNombre.Text & "', '" & txtContraseña.Text & "', '" & txtEmail.Text & "', '" & cmbGenero.Text & "',0,'" & txtNick.Text & "',0,0,0,0,0,0,0)", conectar)




                    Try
                        cmd111.ExecuteNonQuery()
                        MsgBox("¡Registro completado con éxito!")

                    MenuPrincipal.Show()
                        Me.Close()

                    Catch
                        MsgBox("Ya existe ese nombre de usuario")
                    End Try
                End If
            End If
            conectar.Close()

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        MenuPrincipal.Show()
        Me.Close()

    End Sub

    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class