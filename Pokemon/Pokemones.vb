Public Class Pokemones

    Private Sub Pokemones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown



        Select Case e.KeyCode




            '-------------------------------------------------------------------------------------
            '---------------------------------------------------------
            Case Keys.C
                Me.Close()


        End Select
    End Sub

    Private Sub Pokemones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If pokemon1 < 10 Then


            Primero.Image = Image.FromFile(" " & Application.StartupPath & "\Normal\00" & pokemon1 & ".png")
        End If

        If pokemon1 < 100 And pokemon1 >= 10 Then


            Primero.Image = Image.FromFile(" " & Application.StartupPath & "\Normal\0" & pokemon1 & ".png")
        End If

        If pokemon1 >= 100 Then


            Primero.Image = Image.FromFile(" " & Application.StartupPath & "\Normal\" & pokemon1 & ".png")

        End If
        txtStats.Text = "HP: " & hp & " " & vbCrLf & "Attack: " & attack & "" & vbCrLf & "Defense: " & defense & "" & vbCrLf & "SP.Attack: " & spattack & "" & vbCrLf & "SP.Defense: " & spdefense & "" & vbCrLf & "Speed: " & speed & "" & vbCrLf & "LVL: " & LVL & "" & vbCrLf & "EXP: " & exp & "" & vbCrLf & ""
    End Sub



    Private Sub txtStats_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStats.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        Dim value As Integer = CInt(Int((6 * Rnd()) + 1))




        multiplicaizq = 0.01 * 85 * 1
        parentesisdivisor = 0.2 * LVL + 1


        divisor = parentesisdivisor * attack * 40
        '''''poder del ataque 40pp''''

        dividendo = 25 * 5
        '''''defensa del enemigo sp/def 4''''''

        total1 = divisor / dividendo + 2


        total2 = total1 * multiplicaizq



    End Sub

    Private Sub Primero_Click(sender As Object, e As EventArgs) Handles Primero.Click

    End Sub
End Class