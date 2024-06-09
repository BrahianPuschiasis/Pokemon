<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tutorial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tutorial))
        Me.PokemonMe = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.barMe = New System.Windows.Forms.ProgressBar
        Me.barHe = New System.Windows.Forms.ProgressBar
        Me.lblMe = New System.Windows.Forms.Label
        Me.lblHe = New System.Windows.Forms.Label
        Me.btnSkill4 = New System.Windows.Forms.Button
        Me.pelea = New System.Windows.Forms.RichTextBox
        Me.myMedia = New AxWMPLib.AxWindowsMediaPlayer
        Me.Explosion = New System.Windows.Forms.PictureBox
        Me.Explo = New System.Windows.Forms.ImageList(Me.components)
        Me.Explot = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Rojo = New System.Windows.Forms.ImageList(Me.components)
        Me.Cambio = New System.Windows.Forms.PictureBox
        Me.Change = New System.Windows.Forms.Timer(Me.components)
        Me.btnCambio = New System.Windows.Forms.Button
        Me.HUDHe = New System.Windows.Forms.PictureBox
        Me.hphe = New System.Windows.Forms.PictureBox
        Me.vidas = New System.Windows.Forms.ImageList(Me.components)
        Me.HPme = New System.Windows.Forms.PictureBox
        Me.lblHPnow = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblHPMax = New System.Windows.Forms.Label
        Me.lblMelvl = New System.Windows.Forms.Label
        Me.lblHelvl = New System.Windows.Forms.Label
        Me.btnSkill3 = New System.Windows.Forms.Button
        Me.btnSkill2 = New System.Windows.Forms.Button
        Me.btnSkill1 = New System.Windows.Forms.Button
        Me.PokeNicks = New System.Windows.Forms.ListBox
        Me.lblNickMe = New System.Windows.Forms.Label
        Me.lblNickhe = New System.Windows.Forms.Label
        CType(Me.PokemonMe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.myMedia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Explosion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HUDHe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hphe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HPme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PokemonMe
        '
        Me.PokemonMe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PokemonMe.BackColor = System.Drawing.Color.Transparent
        Me.PokemonMe.ErrorImage = Nothing
        Me.PokemonMe.Image = CType(resources.GetObject("PokemonMe.Image"), System.Drawing.Image)
        Me.PokemonMe.Location = New System.Drawing.Point(15, 215)
        Me.PokemonMe.Name = "PokemonMe"
        Me.PokemonMe.Size = New System.Drawing.Size(81, 53)
        Me.PokemonMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PokemonMe.TabIndex = 0
        Me.PokemonMe.TabStop = False
        Me.PokemonMe.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(862, 102)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(81, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'barMe
        '
        Me.barMe.BackColor = System.Drawing.Color.White
        Me.barMe.ForeColor = System.Drawing.Color.Green
        Me.barMe.Location = New System.Drawing.Point(116, 115)
        Me.barMe.Name = "barMe"
        Me.barMe.Size = New System.Drawing.Size(85, 10)
        Me.barMe.TabIndex = 2
        Me.barMe.Visible = False
        '
        'barHe
        '
        Me.barHe.BackColor = System.Drawing.Color.White
        Me.barHe.ForeColor = System.Drawing.Color.White
        Me.barHe.Location = New System.Drawing.Point(462, 86)
        Me.barHe.Name = "barHe"
        Me.barHe.Size = New System.Drawing.Size(100, 10)
        Me.barHe.TabIndex = 3
        Me.barHe.Visible = False
        '
        'lblMe
        '
        Me.lblMe.AutoSize = True
        Me.lblMe.BackColor = System.Drawing.Color.Transparent
        Me.lblMe.Location = New System.Drawing.Point(256, 193)
        Me.lblMe.Name = "lblMe"
        Me.lblMe.Size = New System.Drawing.Size(41, 13)
        Me.lblMe.TabIndex = 4
        Me.lblMe.Text = "asdasd"
        '
        'lblHe
        '
        Me.lblHe.AutoSize = True
        Me.lblHe.BackColor = System.Drawing.Color.Transparent
        Me.lblHe.Location = New System.Drawing.Point(637, 112)
        Me.lblHe.Name = "lblHe"
        Me.lblHe.Size = New System.Drawing.Size(0, 13)
        Me.lblHe.TabIndex = 5
        '
        'btnSkill4
        '
        Me.btnSkill4.Location = New System.Drawing.Point(586, 289)
        Me.btnSkill4.Name = "btnSkill4"
        Me.btnSkill4.Size = New System.Drawing.Size(75, 23)
        Me.btnSkill4.TabIndex = 6
        Me.btnSkill4.Text = "Tackle"
        Me.btnSkill4.UseVisualStyleBackColor = True
        '
        'pelea
        '
        Me.pelea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pelea.BackColor = System.Drawing.Color.Black
        Me.pelea.ForeColor = System.Drawing.Color.White
        Me.pelea.Location = New System.Drawing.Point(0, 373)
        Me.pelea.Name = "pelea"
        Me.pelea.ReadOnly = True
        Me.pelea.Size = New System.Drawing.Size(971, 179)
        Me.pelea.TabIndex = 7
        Me.pelea.Text = ""
        '
        'myMedia
        '
        Me.myMedia.Enabled = True
        Me.myMedia.Location = New System.Drawing.Point(116, 86)
        Me.myMedia.Name = "myMedia"
        Me.myMedia.OcxState = CType(resources.GetObject("myMedia.OcxState"), System.Windows.Forms.AxHost.State)
        Me.myMedia.Size = New System.Drawing.Size(10, 10)
        Me.myMedia.TabIndex = 10
        Me.myMedia.Visible = False
        '
        'Explosion
        '
        Me.Explosion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Explosion.BackColor = System.Drawing.Color.Transparent
        Me.Explosion.ErrorImage = CType(resources.GetObject("Explosion.ErrorImage"), System.Drawing.Image)
        Me.Explosion.Image = CType(resources.GetObject("Explosion.Image"), System.Drawing.Image)
        Me.Explosion.Location = New System.Drawing.Point(862, 102)
        Me.Explosion.Name = "Explosion"
        Me.Explosion.Size = New System.Drawing.Size(81, 53)
        Me.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Explosion.TabIndex = 11
        Me.Explosion.TabStop = False
        Me.Explosion.Visible = False
        '
        'Explo
        '
        Me.Explo.ImageStream = CType(resources.GetObject("Explo.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Explo.TransparentColor = System.Drawing.Color.Transparent
        Me.Explo.Images.SetKeyName(0, "1.png")
        Me.Explo.Images.SetKeyName(1, "2.png")
        Me.Explo.Images.SetKeyName(2, "3.png")
        Me.Explo.Images.SetKeyName(3, "4.png")
        Me.Explo.Images.SetKeyName(4, "Ex.png")
        '
        'Explot
        '
        Me.Explot.Interval = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Rojo
        '
        Me.Rojo.ImageStream = CType(resources.GetObject("Rojo.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Rojo.TransparentColor = System.Drawing.Color.Transparent
        Me.Rojo.Images.SetKeyName(0, "Return1.png")
        Me.Rojo.Images.SetKeyName(1, "Return2.png")
        Me.Rojo.Images.SetKeyName(2, "Return3.png")
        Me.Rojo.Images.SetKeyName(3, "Return4.png")
        Me.Rojo.Images.SetKeyName(4, "Return5.png")
        Me.Rojo.Images.SetKeyName(5, "Return6.png")
        '
        'Cambio
        '
        Me.Cambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cambio.BackColor = System.Drawing.Color.Transparent
        Me.Cambio.ErrorImage = CType(resources.GetObject("Cambio.ErrorImage"), System.Drawing.Image)
        Me.Cambio.Image = CType(resources.GetObject("Cambio.Image"), System.Drawing.Image)
        Me.Cambio.Location = New System.Drawing.Point(15, 215)
        Me.Cambio.Name = "Cambio"
        Me.Cambio.Size = New System.Drawing.Size(81, 53)
        Me.Cambio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Cambio.TabIndex = 13
        Me.Cambio.TabStop = False
        Me.Cambio.Visible = False
        '
        'Change
        '
        Me.Change.Interval = 200
        '
        'btnCambio
        '
        Me.btnCambio.Location = New System.Drawing.Point(240, 26)
        Me.btnCambio.Name = "btnCambio"
        Me.btnCambio.Size = New System.Drawing.Size(75, 23)
        Me.btnCambio.TabIndex = 14
        Me.btnCambio.Text = "Cambio"
        Me.btnCambio.UseVisualStyleBackColor = True
        Me.btnCambio.Visible = False
        '
        'HUDHe
        '
        Me.HUDHe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HUDHe.BackColor = System.Drawing.Color.Transparent
        Me.HUDHe.ErrorImage = CType(resources.GetObject("HUDHe.ErrorImage"), System.Drawing.Image)
        Me.HUDHe.Image = CType(resources.GetObject("HUDHe.Image"), System.Drawing.Image)
        Me.HUDHe.Location = New System.Drawing.Point(609, 43)
        Me.HUDHe.Name = "HUDHe"
        Me.HUDHe.Size = New System.Drawing.Size(250, 53)
        Me.HUDHe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HUDHe.TabIndex = 16
        Me.HUDHe.TabStop = False
        '
        'hphe
        '
        Me.hphe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hphe.BackColor = System.Drawing.Color.Transparent
        Me.hphe.ErrorImage = CType(resources.GetObject("hphe.ErrorImage"), System.Drawing.Image)
        Me.hphe.Image = CType(resources.GetObject("hphe.Image"), System.Drawing.Image)
        Me.hphe.Location = New System.Drawing.Point(715, 77)
        Me.hphe.Name = "hphe"
        Me.hphe.Size = New System.Drawing.Size(100, 5)
        Me.hphe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hphe.TabIndex = 17
        Me.hphe.TabStop = False
        '
        'vidas
        '
        Me.vidas.ImageStream = CType(resources.GetObject("vidas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.vidas.TransparentColor = System.Drawing.Color.Transparent
        Me.vidas.Images.SetKeyName(0, "hpamarillo.png")
        Me.vidas.Images.SetKeyName(1, "hpred.png")
        '
        'HPme
        '
        Me.HPme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HPme.BackColor = System.Drawing.Color.Transparent
        Me.HPme.ErrorImage = CType(resources.GetObject("HPme.ErrorImage"), System.Drawing.Image)
        Me.HPme.Image = CType(resources.GetObject("HPme.Image"), System.Drawing.Image)
        Me.HPme.Location = New System.Drawing.Point(240, 194)
        Me.HPme.Name = "HPme"
        Me.HPme.Size = New System.Drawing.Size(100, 5)
        Me.HPme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HPme.TabIndex = 19
        Me.HPme.TabStop = False
        '
        'lblHPnow
        '
        Me.lblHPnow.AutoSize = True
        Me.lblHPnow.BackColor = System.Drawing.Color.White
        Me.lblHPnow.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHPnow.ForeColor = System.Drawing.Color.Black
        Me.lblHPnow.Location = New System.Drawing.Point(267, 203)
        Me.lblHPnow.Name = "lblHPnow"
        Me.lblHPnow.Size = New System.Drawing.Size(55, 13)
        Me.lblHPnow.TabIndex = 20
        Me.lblHPnow.Text = "asdasd"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(116, 159)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'lblHPMax
        '
        Me.lblHPMax.AutoSize = True
        Me.lblHPMax.BackColor = System.Drawing.Color.White
        Me.lblHPMax.Font = New System.Drawing.Font("Perpetua Titling MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHPMax.ForeColor = System.Drawing.Color.Black
        Me.lblHPMax.Location = New System.Drawing.Point(307, 203)
        Me.lblHPMax.Name = "lblHPMax"
        Me.lblHPMax.Size = New System.Drawing.Size(55, 13)
        Me.lblHPMax.TabIndex = 21
        Me.lblHPMax.Text = "asdasd"
        '
        'lblMelvl
        '
        Me.lblMelvl.AutoSize = True
        Me.lblMelvl.BackColor = System.Drawing.Color.White
        Me.lblMelvl.Font = New System.Drawing.Font("Perpetua Titling MT", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMelvl.ForeColor = System.Drawing.Color.Black
        Me.lblMelvl.Location = New System.Drawing.Point(307, 169)
        Me.lblMelvl.Name = "lblMelvl"
        Me.lblMelvl.Size = New System.Drawing.Size(16, 22)
        Me.lblMelvl.TabIndex = 22
        Me.lblMelvl.Text = "1"
        '
        'lblHelvl
        '
        Me.lblHelvl.AutoSize = True
        Me.lblHelvl.BackColor = System.Drawing.Color.White
        Me.lblHelvl.Font = New System.Drawing.Font("Perpetua Titling MT", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelvl.ForeColor = System.Drawing.Color.Black
        Me.lblHelvl.Location = New System.Drawing.Point(783, 52)
        Me.lblHelvl.Name = "lblHelvl"
        Me.lblHelvl.Size = New System.Drawing.Size(16, 22)
        Me.lblHelvl.TabIndex = 23
        Me.lblHelvl.Text = "1"
        '
        'btnSkill3
        '
        Me.btnSkill3.Location = New System.Drawing.Point(489, 289)
        Me.btnSkill3.Name = "btnSkill3"
        Me.btnSkill3.Size = New System.Drawing.Size(75, 23)
        Me.btnSkill3.TabIndex = 24
        Me.btnSkill3.Text = "Tackle"
        Me.btnSkill3.UseVisualStyleBackColor = True
        '
        'btnSkill2
        '
        Me.btnSkill2.Location = New System.Drawing.Point(395, 289)
        Me.btnSkill2.Name = "btnSkill2"
        Me.btnSkill2.Size = New System.Drawing.Size(75, 23)
        Me.btnSkill2.TabIndex = 25
        Me.btnSkill2.Text = "Tackle"
        Me.btnSkill2.UseVisualStyleBackColor = True
        '
        'btnSkill1
        '
        Me.btnSkill1.Location = New System.Drawing.Point(307, 289)
        Me.btnSkill1.Name = "btnSkill1"
        Me.btnSkill1.Size = New System.Drawing.Size(75, 23)
        Me.btnSkill1.TabIndex = 26
        Me.btnSkill1.Text = "Tackle"
        Me.btnSkill1.UseVisualStyleBackColor = True
        '
        'PokeNicks
        '
        Me.PokeNicks.FormattingEnabled = True
        Me.PokeNicks.Items.AddRange(New Object() {"las weas", "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle" & Global.Microsoft.VisualBasic.ChrW(9), "Kakuna" & Global.Microsoft.VisualBasic.ChrW(9), "Beedrill" & Global.Microsoft.VisualBasic.ChrW(9), "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowt", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag" & Global.Microsoft.VisualBasic.ChrW(9), "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone" & Global.Microsoft.VisualBasic.ChrW(9), "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking" & Global.Microsoft.VisualBasic.ChrW(9), "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres" & Global.Microsoft.VisualBasic.ChrW(9), "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew", "", "Chikorita", "Bayleef", "Meganium", "Cyndaquil", "Quilava", "Typhlosion", "Totodile", "Croconaw", "Feraligatr", "Sentret", "Furret", "Hoothoot", "Noctowl", "Ledyba", "Ledian", "Spinarak", "Ariados", "Crobat", "Chinchou", "Lanturn", "Pichu", "Cleffa", "Igglybuff", "Togepi", "Togetic", "Natu", "Xatu", "Mareep" & Global.Microsoft.VisualBasic.ChrW(9), "Flaaffy", "Ampharos", "Bellossom", "Marill", "Azumarill", "Sudowoodo", "Politoed", "Hoppip", "Skiploom", "Jumpluff", "Aipom", "Sunkern", "Sunflora", "Yanma", "Wooper", "Quagsire", "Espeon", "Umbreon", "Murkrow", "Slowking", "Misdreavus", "Unown", "Wobbuffet", "Girafarig", "Pineco", "Forretress", "Dunsparce", "Gligar", "Steelix", "Snubbull", "Granbull", "Qwilfish", "Scizor", "Shuckle", "Heracross" & Global.Microsoft.VisualBasic.ChrW(9), "Sneasel", "Teddiursa", "Ursaring", "Slugma", "Magcargo", "Swinub", "Piloswine", "Corsola", "Remoraid", "Octillery", "Delibird", "Mantine", "Skarmory", "Houndour", "Houndoom", "Kingdra", "Phanpy", "Donphan", "Porygon2", "Stantler" & Global.Microsoft.VisualBasic.ChrW(9), "Smeargle", "Tyrogue", "Hitmontop", "Smoochum", "Elekid", "Magby", "Miltank", "Blissey", "Raikou", "Entei" & Global.Microsoft.VisualBasic.ChrW(9), "Suicune" & Global.Microsoft.VisualBasic.ChrW(9), "Larvitar", "Pupitar", "Tyranitar", "Lugia", "Ho-oh", "Celebi", "Treecko", "Grovyle", "Sceptile", "Torchic", "Combusken", "Blaziken", "Mudkip", "Marshtomp", "Swampert", "Poochyena", "Mightyena", "Zigzagoon", "Linoone", "Wurmple", "Silcoon", "Beautifly", "Cascoon", "Dustox", "Lotad", "Lombre", "Ludicolo", "Seedot", "Nuzleaf", "Shiftry", "Taillow", "Swellow", "Wingull", "Pelipper", "Ralts", "Kirlia", "Gardevoir", "Surskit", "Masquerain", "Shroomish", "Breloom", "Slakoth", "Vigoroth", "Slaking", "Nincada", "Ninjask", "Shedinja", "Whismur", "Loudred", "Exploud", "Makuhita", "Hariyama", "Azurill", "Nosepass", "Skitty" & Global.Microsoft.VisualBasic.ChrW(9), "Delcatty", "Sableye", "Mawile", "Aron", "Lairon", "Aggron", "Meditite", "Medicham", "Electrike", "Manectric", "Plusle", "Minun", "Volbeat", "Illumise", "Roselia", "Gulpin", "Swalot", "Carvanha", "Sharpedo", "Wailmer", "Wailord", "Numel", "Camerupt", "Torkoal", "Spoink", "Grumpig", "Spinda", "Trapinch", "Vibrava", "Flygon", "Cacnea", "Cacturne", "Swablu", "Altaria", "Zangoose", "Seviper", "Lunatone", "Solrock", "Barboach", "Whiscash", "Corphish", "Crawdaunt", "Baltoy", "Claydol", "Lileep", "Cradily", "Anorith", "Armaldo", "Feebas", "Milotic", "Castform", "Kecleon" & Global.Microsoft.VisualBasic.ChrW(9), "Shuppet", "Banette", "Duskull", "Dusclops", "Tropius", "Chimecho", "Absol", "Wynaut", "Snorunt", "Glalie", "Spheal", "Sealeo", "Walrein", "Clamperl", "Huntail", "Gorebyss", "Relicanth", "Luvdisc", "Bagon", "Shelgon", "Salamence", "Beldum", "Metang" & Global.Microsoft.VisualBasic.ChrW(9), "Metagross", "Regirock", "Regice", "Registeel", "Latias", "Latios", "Kyogre", "Groudon", "Rayquaza", "Jirachi", "Deoxys"})
        Me.PokeNicks.Location = New System.Drawing.Point(395, 134)
        Me.PokeNicks.Name = "PokeNicks"
        Me.PokeNicks.Size = New System.Drawing.Size(120, 95)
        Me.PokeNicks.TabIndex = 27
        Me.PokeNicks.Visible = False
        '
        'lblNickMe
        '
        Me.lblNickMe.AutoSize = True
        Me.lblNickMe.Location = New System.Drawing.Point(162, 175)
        Me.lblNickMe.Name = "lblNickMe"
        Me.lblNickMe.Size = New System.Drawing.Size(48, 13)
        Me.lblNickMe.TabIndex = 28
        Me.lblNickMe.Text = "Bulbasur"
        Me.lblNickMe.Visible = False
        '
        'lblNickhe
        '
        Me.lblNickhe.AutoSize = True
        Me.lblNickhe.Location = New System.Drawing.Point(637, 58)
        Me.lblNickhe.Name = "lblNickhe"
        Me.lblNickhe.Size = New System.Drawing.Size(48, 13)
        Me.lblNickhe.TabIndex = 29
        Me.lblNickhe.Text = "Bulbasur"
        Me.lblNickhe.Visible = False
        '
        'Tutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(969, 548)
        Me.Controls.Add(Me.lblNickhe)
        Me.Controls.Add(Me.lblNickMe)
        Me.Controls.Add(Me.PokeNicks)
        Me.Controls.Add(Me.btnSkill1)
        Me.Controls.Add(Me.btnSkill2)
        Me.Controls.Add(Me.btnSkill3)
        Me.Controls.Add(Me.lblHelvl)
        Me.Controls.Add(Me.lblMelvl)
        Me.Controls.Add(Me.lblHPMax)
        Me.Controls.Add(Me.lblHPnow)
        Me.Controls.Add(Me.HPme)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.hphe)
        Me.Controls.Add(Me.HUDHe)
        Me.Controls.Add(Me.btnCambio)
        Me.Controls.Add(Me.Cambio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Explosion)
        Me.Controls.Add(Me.myMedia)
        Me.Controls.Add(Me.pelea)
        Me.Controls.Add(Me.btnSkill4)
        Me.Controls.Add(Me.lblHe)
        Me.Controls.Add(Me.lblMe)
        Me.Controls.Add(Me.barHe)
        Me.Controls.Add(Me.barMe)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PokemonMe)
        Me.DoubleBuffered = True
        Me.Name = "Tutorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PeleaInicial"
        CType(Me.PokemonMe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.myMedia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Explosion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HUDHe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hphe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HPme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PokemonMe As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents barMe As System.Windows.Forms.ProgressBar
    Friend WithEvents barHe As System.Windows.Forms.ProgressBar
    Friend WithEvents lblMe As System.Windows.Forms.Label
    Friend WithEvents lblHe As System.Windows.Forms.Label
    Friend WithEvents btnSkill4 As System.Windows.Forms.Button
    Friend WithEvents pelea As System.Windows.Forms.RichTextBox
    Friend WithEvents myMedia As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Explosion As System.Windows.Forms.PictureBox
    Friend WithEvents Explo As System.Windows.Forms.ImageList
    Friend WithEvents Explot As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Rojo As System.Windows.Forms.ImageList
    Friend WithEvents Cambio As System.Windows.Forms.PictureBox
    Friend WithEvents Change As System.Windows.Forms.Timer
    Friend WithEvents btnCambio As System.Windows.Forms.Button
    Friend WithEvents HUDHe As System.Windows.Forms.PictureBox
    Friend WithEvents hphe As System.Windows.Forms.PictureBox
    Friend WithEvents vidas As System.Windows.Forms.ImageList
    Friend WithEvents HPme As System.Windows.Forms.PictureBox
    Friend WithEvents lblHPnow As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblHPMax As System.Windows.Forms.Label
    Friend WithEvents lblMelvl As System.Windows.Forms.Label
    Friend WithEvents lblHelvl As System.Windows.Forms.Label
    Friend WithEvents btnSkill3 As System.Windows.Forms.Button
    Friend WithEvents btnSkill2 As System.Windows.Forms.Button
    Friend WithEvents btnSkill1 As System.Windows.Forms.Button
    Friend WithEvents PokeNicks As System.Windows.Forms.ListBox
    Friend WithEvents lblNickMe As System.Windows.Forms.Label
    Friend WithEvents lblNickhe As System.Windows.Forms.Label
End Class
