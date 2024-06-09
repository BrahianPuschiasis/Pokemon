Imports System.Runtime.Remoting.Contexts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports MySql.Data.MySqlClient
Public Module module1
    Public conect As New Odbc.OdbcConnection
    Public Cmd As New Odbc.OdbcCommand



    Public jugador As String
    Public caminar As Integer = 0
    Public pokemon1 As Integer = 0
    Public pokemon2 As Integer = 0
    Public pokemon3 As Integer = 0
    Public pokemon4 As Integer = 0
    Public pokemon5 As Integer = 0
    Public pokemon6 As Integer = 0
    Public primario As Integer = 0
    Public conectar As New MySqlConnection("Server=localhost;Port=3306;Database=pokemon;Uid=root;Pwd=asease22")

    Public posicionx As Integer
    Public posiciony As Integer
    Public casa As Integer = 0
    Public lab As Integer = 0
    Public ruta01 As Integer = 0
    Public nick As String
    Public wild As Integer = 0
    Public tuto1 As Integer = 0
    Public tuto As Integer = 0

    ''POKEMON1 LAS WEAS''
    Public hp As Integer
    Public attack As Integer
    Public spattack As Integer
    Public defense As Integer
    Public spdefense As Integer
    Public speed As Integer
    Public exp As Integer
    Public skill1 As String
    Public skill2 As String
    Public skill3 As String
    Public skill4 As String
    Public LVL As Integer
    Public hpnow As Integer
    ''POKEMON1 LAS WEAS''

    ''salvajes''
    Public hpw As Integer = hp
    Public attackw As Integer
    Public spattackw As Integer
    Public defensew As Integer
    Public spdefensew As Integer
    Public speedw As Integer
    Public nickwild As String
    Public lvlwild As Integer
    ''salvajes

    ''dañome
    Public multiplicaizq As Double
    Public parentesisdivisor As Double
    Public divisor As Double
    Public dividendo As Double
    Public total1 As Double
    Public total2 As Integer
    Public habilidad As String
    Public power As Integer
    ''dañome

    ''dañohe
    Public multiplicaizqhe As Double
    Public parentesisdivisorhe As Double
    Public divisorhe As Double
    Public dividendohe As Double
    Public total1he As Double
    Public total2he As Integer
    Public habilidadhe As String
    Public powerhe As Integer
    ''dañohe





    Public Sub pokewild()
        If nickwild = "Rattata" Then
            hpw = 11
            attackw = 5
            defensew = 5
            spattackw = 5
            spdefensew = 5
            speedw = 6
            wild = 19
            lvlwild = 1
            habilidadhe = "Scratch"
        End If

        If nickwild = "Pidgey" Then
            hpw = 11
            attackw = 5
            defensew = 5
            spattackw = 5
            spdefensew = 5
            speedw = 6
            wild = 16
            lvlwild = 1
            habilidadhe = "Scratch"
        End If



    End Sub
    Public Sub dañome()
        If habilidad = "Scratch" Then
            power = 40
        End If



        multiplicaizq = 0.01 * 85 * 1
        parentesisdivisor = 0.2 * LVL + 1


        divisor = parentesisdivisor * attack * power
        '''''poder del ataque 40pp''''

        dividendo = 25 * defensew
        '''''defensa del enemigo sp/def 4''''''

        total1 = divisor / dividendo + 2


        total2 = total1 * multiplicaizq

        If habilidad = "Growl" Then
            total2 = 0
        End If

        If habilidad = "None" Then
            total2 = 0
        End If


    End Sub

    Public Sub dañohe()
        If habilidadhe = "None" Then
            powerhe = 5
            multiplicaizqhe = 0.01 * 85 * 1
            parentesisdivisorhe = 0.2 * lvlwild + 1


            divisorhe = parentesisdivisorhe * attackw * powerhe
            '''''poder del ataque 40pp''''

            dividendohe = 25 * defense
            '''''defensa del enemigo sp/def 4''''''

            total1he = divisorhe / dividendohe + 2


            total2he = total1he * multiplicaizqhe

        End If

        If habilidadhe = "Growl" Then
            powerhe = 0
        Else
            multiplicaizqhe = 0.01 * 85 * 1
            parentesisdivisorhe = 0.2 * lvlwild + 1


            divisorhe = parentesisdivisorhe * attackw * powerhe
            '''''poder del ataque 40pp''''

            dividendohe = 25 * defense
            '''''defensa del enemigo sp/def 4''''''

            total1he = divisorhe / dividendohe + 2


            total2he = total1he * multiplicaizqhe

        End If

        If habilidadhe = "None" Then
            total2he = 0
        Else
            multiplicaizqhe = 0.01 * 85 * 1
            parentesisdivisorhe = 0.2 * lvlwild + 1


            divisorhe = parentesisdivisorhe * attackw * powerhe
            '''''poder del ataque 40pp''''

            dividendohe = 25 * defense
            '''''defensa del enemigo sp/def 4''''''

            total1he = divisorhe / dividendohe + 2


            total2he = total1he * multiplicaizqhe

        End If









    End Sub




End Module
