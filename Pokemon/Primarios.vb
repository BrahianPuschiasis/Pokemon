Imports MySql.Data.MySqlClient
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms
Public Class Primarios

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Squa.Click

    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bulba.Click

    End Sub
    Private Sub Primarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Charm.Click

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If rbtnBulba.Checked = True Then
            MsgBox("¡Bulbasur yo te elijo!")
            primario = 1
            pokemon1 = primario
            tuto1 = 1
            Tutorial.Show()
            Me.BackgroundWorker1.RunWorkerAsync(2000)
            Me.Close()

        End If
        If rbtnSqua.Checked = True Then
            MsgBox("¡Squartle yo te elijo!")
            primario = 7
            pokemon1 = primario
            tuto1 = 1
            Tutorial.Show()
            Me.BackgroundWorker1.RunWorkerAsync(2000)
            Me.Close()

        End If
        If rbtnCharm.Checked = True Then
            MsgBox("¡Charmander yo te elijo!")
            primario = 4
            pokemon1 = primario
            tuto1 = 1
            Tutorial.Show()
            Me.BackgroundWorker1.RunWorkerAsync(2000)
            Me.Close()

        End If









    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ' Do not access the form's BackgroundWorker reference directly.
        ' Instead, use the reference provided by the sender parameter.
        Dim bw As BackgroundWorker = CType(sender, BackgroundWorker)

        ' Extract the argument.
        Dim arg As Integer = Fix(e.Argument)

        ' Start the time-consuming operation.


        ' If the operation was canceled by the user, 
        ' set the DoWorkEventArgs.Cancel property to true.

        conectar.Open()

        Dim sentenciaSQL As String = "UPDATE PokemonUsuarios SET Primario=" & primario & ", Pokemon1=" & primario & " WHERE Nick='" & nick & "'"
        MsgBox("Sentencia SQL: " & sentenciaSQL)

        Dim cmd55 As New MySqlCommand("UPDATE PokemonUsuarios set Primario= " & primario & ", Pokemon1= " & primario & " where Nick='" & nick & "'", conectar)
        cmd55.ExecuteNonQuery()


        If primario = 4 Then

            Dim cmd111 As New MySqlCommand("INSERT INTO `Pokemones` (Nick,PokemonID,HP,Attack,Defense,SPAttack,SPDefense,Speed,EXP,LVL,Skill1,Skill2,Skill3,Skill4,TP) VALUES ('" & nick & "', " & primario & ",7,5,4,5,5,7,0,1,'Growl','None','None','Scratch',0)", conectar)
            cmd111.ExecuteNonQuery()

        End If

        conectar.Close()




    End Sub
End Class
