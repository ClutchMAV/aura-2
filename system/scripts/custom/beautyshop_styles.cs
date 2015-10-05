using System.Globalization;

public class StylesScript : NpcScript
{
    public override void Load()
    {
        SetName("_<mini>HAIR</mini> Styles");
        SetRace(10002);
        SetBody(height: 1f);
        SetFace(skinColor: 18, eyeType: 2, eyeColor: 31, mouthType: 0);
        SetStand("human/male/anim/male_natural_stand_npc_simon.ani");
        SetLocation(60209, 1350, 2169, 192);
        EquipItem(Pocket.Hair, 4123, 0x00FFFF, 0, 0);
        EquipItem(Pocket.Face, 4900, 18, 0, 0);
        EquipItem(Pocket.Armor, 210048, 0xFFFFFF, 0x36648B, 0x926239);
        EquipItem(Pocket.Shoe, 17243, 0x926232);
        EquipItem(Pocket.Head, 18590, 0xFFFFFF, 0xFFFFFF, 0xFFFFFF);

        AddPhrase("Gurl, You look like you need a makeover!");
        AddPhrase("That hair is so.. fabulous!");
        AddPhrase("Oh no.. I forgot to trim the sides!");
        AddPhrase("How about a Miley Cyrus hairdo?");
        AddPhrase("Do you like your hair?");
    }

    protected override async Task Talk()
    {

        int oldhair = Player.Inventory.GetItemAt(Pocket.Hair, 1, 1).Info.Id;
        uint oldcolor = Player.Inventory.GetItemAt(Pocket.Hair, 1, 1).Info.Color1;

        await Intro(
            "A handsome young person stands before you. You are amazed by his hair, and you find out he's a barber.",
            "He offers you services you wouldn't think were possible, for a cheap price.",
            "He smiles as he waits for you to answer."
        );

    L_Selection:
        Msg("Hey Cutie, looking for a haircut? Or do you want to paint your hair?", List("What would you like me to do?", 10, Button("Paint Hair", "@paint"), Button("Haircut", "@changehair")));

        var r = await Select();
        switch (r)
        {
            case "@paint":
                {
                    Msg("What colour do you want?", List("Choose Colour", 10,
                        Button("Blue", "@paint_0x0000FF"),
						Button("Green", "@paint_0x00FF00"),
						Button("Red", "@paint_0xFF0000"),
						Button("Yellow", "@paint_0xFFFF00"),
						Button("Cyan", "@paint_0x00FFFF"),
						Button("Magneta", "@paint_0xFF00FF"),
						Button("Pink", "@paint_0xF535AA"),
						Button("Purple", "@paint_0x3F007F"),
						Button("Orange", "@paint_0xFF7F00"),
						Button("Black", "@paint_0x000000"),
						Button("White", "@paint_0xFFFFFF"),
						Button("Red-Black", "@paint_0x6000000b"),
						Button("Blue-Black", "@paint_0x60000009")
                        ));
                }
                break;

            case "@changehair":
                {
				if(Player.IsMale){
                    Msg("What hairstyle do you want?", List("Choose Hairstyle", 10,

                        Button("Ivy League Cut", "@cut_4001"),
                        Button("Emo", "@cut_4002"),
                        Button("Center-parted", "@cut_4003"),
                        Button("80s Dance Kid", "@cut_4004"),
                        Button("Spiky Mop Top", "@cut_4005"),
                        Button("Disheveled Double Cut", "@cut_4006"),
                        Button("Double Cut Hair", "@cut_4007"),
                        Button("Wavy Left", "@cut_4008"),
                        Button("Volumtuous Short cut", "@cut_4009"),
                        Button("Wolf Cut", "@cut_4010"),
                        Button("Huge Bang", "@cut_4011"),
                        Button("Hammer Head", "@cut_4012"),
                        Button("Buzz Saw", "@cut_4013"),
                        Button("Afro", "@cut_4014"),
                        Button("Helmet Head", "@cut_4015"),
                        Button("Middle-aged Fighter Style", "@cut_4016"),

                        Button("Youthful Combat Style", "@cut_4017"),
                        Button("Punk Front Anvil", "@cut_4018"),
                        Button("Hoodlum Hair", "@cut_4019"),
                        Button("Buzz Cut", "@cut_4020"),
                        Button("Puppy Hair", "@cut_4021"),
                        Button("Guitarist", "@cut_4022"),
                        Button("Preppy Ponytail", "@cut_4023"),
                        Button("Short Razor Pageboy", "@cut_4024"),
                        Button("Curly Pageboy", "@cut_4025"),
                        Button("Monastery Hair", "@cut_4026"),
                        Button("Reciding Hair", "@cut_4027"),
                        Button("Manus Cut", "@cut_4028"),
                        Button("Wavy Hair", "@cut_4029"),
                        Button("Shaggy", "@cut_4030"),
                        Button("Oriental Long Hair", "@cut_4031"),
                        Button("Shaggy Volume Cut", "@cut_4032"),

                        Button("Squire Cut", "@cut_4033"),
                        Button("High Priest", "@cut_4034"),
                        Button("Captain Cut", "@cut_4035"),
                        Button("Sleek Ponytail", "@cut_4036"),
                        Button("Grace Volume Curl", "@cut_4037"),
                        Button("Old Asian Hero Style", "@cut_4038"),
                        Button("Mild n Wild", "@cut_4039"),
                        Button("Pineapple Tie up", "@cut_4040"),
                        Button("Wild Style", "@cut_4041"),
                        Button("Dandy Cut", "@cut_4042"),
                        Button("Shaggy Little Tail", "@cut_4043"),
                        Button("Cutie Whisker Cut", "@cut_4049"),
                        Button("Franks Hair", "@cut_4081"),
                        Button("Alberts Hair", "@cut_4082"),
                        Button("Long Straight Hair", "@cut_4083"),
                        Button("Bald", "@cut_4084"),

                        Button("Shadow Wave", "@cut_4085"),
                        Button("Shadow Volume Hairdo", "@cut_4086"),
                        Button("Soft Wave Cut", "@cut_4087"),
                        Button("Medium Layered Cut", "@cut_4088"),
                        Button("Short Wolf Cut", "@cut_4089"),
                        Button("Edelyn Bob", "@cut_4090"),
                        Button("Half Ponytail & Sideburn Braids", "@cut_4091"),
                        Button("Kelpie Hair", "@cut_4094"),
                        Button("Mad Scientist", "@cut_4097"),
                        Button("Natural Cut", "@cut_4098"),
						
						Button("Tecktonic Hair", "@cut_4013"),
						
						Button("Hamlet Hair", "@cut_4119"),
                        Button("Laertes Hair", "@cut_4123"),
                        Button("Horatio Hair", "@cut_4125"),
						
                        Button("Romeo Hair", "@cut_4130"),
                        Button("Tybalt Hair", "@cut_4131"),
                        Button("Paris Hair", "@cut_4132"),
						
                        Button("Mad Paris Hair", "@cut_4134"),
                        Button("Hans Hair", "@cut_4135"),
                        Button("Ascon Hair", "@cut_4136"),
						
						Button("Swept Cut", "@cut_4138"),
                        Button("Mid-Length Pullback", "@cut_4139"),
                        Button("Shylock Hair", "@cut_4140"),
                        Button("Bassanio Hair", "@cut_4142"),
						
                        Button("Odran Hair", "@cut_4147"),
                        Button("Gentle Layers", "@cut_4150"),
							
                        Button("Berched Hair", "@cut_4100"),
						
						
						Button("Kaito Hair", "@cut_4161"),
						
                        Button("Ferghus Hair", "@cut_4153"),
                        Button("Regular Cut", "@cut_4155"),
						Button("Long Emo", "@cut_4156"),
                        Button("Huw Hair", "@cut_4157")
		

                        ));
				}else if(Player.IsFemale){
				Msg("What hairstyle do you want?", List("Choose Hairstyle", 10,
					 Button("Dowra Hair", "@cut_7023")
					 ));
				}

                }
                break;

            default:
                {
                    Msg("Don't want to change your hair? That's okay.");
                    return;
                }
                break;

        }

        var s = await Select();
        switch (s)
        {

            default:
                {
                    string selection = (String)s;

                    if (selection.IndexOf("@paint_") != -1)
                    {
                        string haircolorstring = selection.Replace("@paint_", "");
                        uint haircolor = 0;

                        Msg("Well, Do you like your new hair colour?", Button("Yes", "@yes"), Button("No. Let me pick something else", "@no"));

                        if (!uint.TryParse(haircolorstring.Replace("0x", ""), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out haircolor))
                        {
                            Msg("Sorry, Something went wrong.");
                            return;
                        }

                        Item currhair = Player.Inventory.GetItemAt(Pocket.Hair, 1, 1);
                        currhair.Info.Color1 = haircolor;
                        Send.EquipmentChanged(Player, currhair);

                        var n = await Select();
                        switch (n)
                        {
                            case "@yes":
                                Msg("Okay, Then have fun with your new hair colour!");
                                return;
                                break;

                            case "@no":
                                Item revertcolor = Player.Inventory.GetItemAt(Pocket.Hair, 1, 1);
                                revertcolor.Info.Color1 = oldcolor;
                                Send.EquipmentChanged(Player, revertcolor);
                                goto L_Selection;
                                break;

                        }
                    }
                    else if (selection.IndexOf("@cut_") != -1)
                    {
                        string hairtype = selection.Replace("@cut_", "");
                        Msg("Well, Do you like your new haircut?", Button("Yes", "@yes"), Button("No. Let me pick something else", "@no"));

                        Item currhair = Player.Inventory.GetItemAt(Pocket.Hair, 1, 1);
                        currhair.Info.Id = Convert.ToInt32(hairtype);
                        Send.EquipmentChanged(Player, currhair);

                        var n = await Select();
                        switch (n)
                        {
                            case "@yes":
                                Msg("Okay, Then have fun with your new haircut!");
                                return;
                                break;

                            case "@no":
                                Item reverthair = Player.Inventory.GetItemAt(Pocket.Hair, 1, 1);
                                reverthair.Info.Id = oldhair;
                                Send.EquipmentChanged(Player, reverthair);
                                goto L_Selection;
                                break;

                        }

                    } else {
					Msg("There was an error.");
					return;
					}					

                }
                break;
        }
    }
}
