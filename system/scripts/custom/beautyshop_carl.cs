using System.Globalization;

public class CosmeticCarl : NpcScript
{
    public override void Load()
    {
        SetName("_<mini>FACE</mini> Carl");
        SetRace(10002);
        SetBody(height: 1f);
        SetFace(skinColor: 16, eyeType: 22, eyeColor: 14, mouthType: 0);
        SetStand("chapter4/human/anim/male_alchemists_stand_friendly.ani");
        SetLocation(60209, 1830, 1708, 125);
        EquipItem(Pocket.Hair, 4157, 0xFFFF00, 0, 0);
        EquipItem(Pocket.Face, 6912, 18, 0, 0);
        EquipItem(Pocket.Armor, 15618, 0xFFFFFF, 0x926239, 0xFFFFFF);
        EquipItem(Pocket.Shoe, 17235, 0x926239);

        AddPhrase("You you need to improve your eye vision?");
        AddPhrase("You should try white lenses!");
        AddPhrase("I need to buy more botox...");
        AddPhrase("Don't like your ugly face? I can fix it!");

    }

    protected override async Task Talk()
    {

        int oldface = Player.Inventory.GetItemAt(Pocket.Face, 1, 1).Info.Id;
        byte oldeyecolor = Player.EyeColor;
        short oldeye = Player.EyeType;
        byte oldmouth = Player.MouthType;

        await Intro(
            "A handsome young person stands before you. You are amazed by his eyes, and you find out he's a cosmetician.",
            "He offers you services you wouldn't think were possible, for a cheap price.",
            "He smiles as he waits for you to answer."
        );

    L_Selection:
        Msg("Do you want to change your face?", List("What would you like me to do?", 10, Button("Change Face", "@changeface"), Button("Change Eyes", "@changeeyes"), Button("Change Eye Color", "@changecolor"), Button("Change Mouth", "@changemouth")));

        var r = await Select();
        switch (r)
        {
            case "@changecolor":
                {
                    Msg("What colour do you want?", List("Choose Colour", 10,
                        Button("Black", "@paint_0"),
                        Button("Dark Blue", "@paint_1"),
                        Button("Dark Green", "@paint_2"),
                        Button("Dark Cyan", "@paint_3"),
                        Button("Dark Red", "@paint_4"),
                        Button("Dark Purple", "@paint_5"),
                        Button("Dark Orange", "@paint_6"),
                        Button("Light Gray", "@paint_7"),
                        Button("Dark Gray", "@paint_8"),
                        Button("Blue", "@paint_9"),
                        Button("Green", "@paint_10"),
                        Button("Red", "@paint_11"),
                        Button("Yellow", "@paint_12"),
                        Button("Purple", "@paint_13"),
                        Button("Cyan", "@paint_14"),
                        Button("White", "@paint_15"),
                        Button("Pearly", "@paint_16"),
                        Button("White-yellow", "@paint_17"),
                        Button("Orange-yellow", "@paint_18"),
                        Button("Light Yellow", "@paint_19"),
                        Button("Yellow", "@paint_20"),
                        Button("Peach", "@paint_21"),
                        Button("Grayish-red", "@paint_22"),
                        Button("Coffee", "@paint_23"),
                        Button("Earthen", "@paint_24"),
                        Button("Bronzed", "@paint_25"),
                        Button("Reddish-brown", "@paint_26"),
                        Button("Dark Brown", "@paint_27"),
                        Button("Black", "@paint_28"),
                        Button("Blue-black", "@paint_29"),
                        Button("Blue-gray", "@paint_30"),
                        Button("Violet", "@paint_31"),
                        Button("Light Blue", "@paint_32"),
                        Button("Light Violet", "@paint_33"),
                        Button("Silver-violet", "@paint_34"),
                        Button("Blonde", "@paint_35"),
                        Button("Orange", "@paint_36"),
                        Button("Light Brown", "@paint_37"),
                        Button("Red", "@paint_38"),
                        Button("Brown", "@paint_39"),
                        Button("Pure Black", "@paint_40"),
                        Button("Midnight Blue", "@paint_41"),
                        Button("Deep Blue", "@paint_42"),
                        Button("Ultramarine", "@paint_43"),
                        Button("Goblin Blue", "@paint_44"),
                        Button("Azurite Blue", "@paint_45"),
                        Button("Smalt Blue", "@paint_49"),
                        Button("Caelum Blue", "@paint_50"),
                        Button("Viridis Green", "@paint_52"),
                        Button("Kynnbragg Green", "@paint_53"),
                        Button("Egyptian Blue", "@paint_55"),
                        Button("Sky Blue", "@paint_57"),
                        Button("Realm Green", "@paint_58"),
                        Button("Vallandry Green", "@paint_59"),
                        Button("Acid Green", "@paint_70"),
                        Button("Lime Green", "@paint_71"),
                        Button("Aqua", "@paint_75"),
                        Button("Brown Ochre", "@paint_76"),
                        Button("Dark Grape", "@paint_77"),
                        Button("Iris", "@paint_78"),
                        Button("Indigo", "@paint_79"),
                        Button("Sapphire", "@paint_80"),
                        Button("Turndail Green", "@paint_82"),
                        Button("Forestis Green", "@paint_88"),
                        Button("Earth Green", "@paint_89"),
                        Button("Malachite Green", "@paint_90"),
                        Button("Royal Blue", "@paint_93"),
                        Button("Emerald", "@paint_95"),
                        Button("Bilan Blue", "@paint_99"),
                        Button("Turquoise", "@paint_104"),
                        Button("Maedere Red", "@paint_112"),
                        Button("Eternium Red", "@paint_113"),
                        Button("Prepeace Wine", "@paint_114"),
                        Button("Adamantium Violet", "@paint_116"),
                        Button("Red Ochre", "@paint_117"),
                        Button("Chocolate", "@paint_119"),
                        Button("Goblin Violet", "@paint_120"),
                        Button("Lowendal Green", "@paint_124"),
                        Button("Slate Blue", "@paint_127"),
                        Button("Eweca Blue", "@paint_128"),
                        Button("Grass Green", "@paint_130"),
                        Button("Verte Green", "@paint_131"),
                        Button("Goblin Green", "@paint_132"),
                        Button("Steel Blue", "@paint_134"),
                        Button("Cornflower Blue", "@paint_135"),
                        Button("Aquamarine", "@paint_146"),
                        Button("Carmine Red", "@paint_148"),
                        Button("Saddle Brown", "@paint_154"),
                        Button("Brick Red", "@paint_155"),
                        Button("Ochre", "@paint_160"),
                        Button("Desertum", "@paint_161"),
                        Button("Olive", "@paint_166"),
                        Button("Iceberg Blue", "@paint_177"),
                        Button("Chartreuse Green", "@paint_178"),
                        Button("Bloody Red", "@paint_184"),
                        Button("Crimson Red", "@paint_185"),
                        Button("Enndoria Pink", "@paint_188"),
                        Button("Vermilion Red", "@paint_190"),
                        Button("Lamoah Hong", "@paint_191"),
                        Button("Palarua Red", "@paint_192"),
                        Button("Meldeceit Desertum", "@paint_196"),
                        Button("Glandernos Ochre", "@paint_197"),
                        Button("Ladeca Red", "@paint_198"),
                        Button("Meldeceit Red", "@paint_199"),
                        Button("Orchid", "@paint_200"),
                        Button("Meldeceit Yellow", "@paint_202"),
                        Button("Yellow Ochre", "@paint_204"),
                        Button("Rosy Brown", "@paint_205"),
                        Button("Khaki", "@paint_210"),
                        Button("Mythril White", "@paint_213"),
                        Button("Lemon Yellow", "@paint_214"),
                        Button("Zilberlandow White", "@paint_219"),
                        Button("Burning Red", "@paint_220"),
                        Button("Ruby Red", "@paint_221"),
                        Button("Meldeceit Sun", "@paint_222"),
                        Button("Poison Magenta", "@paint_225"),
                        Button("Lava Red", "@paint_226"),
                        Button("Forging Sword", "@paint_227"),
                        Button("Fuchsia", "@paint_231"),
                        Button("Chroma Orange", "@paint_232"),
                        Button("Rahj-al-ghar Orange", "@paint_233"),
                        Button("Tomato", "@paint_234"),
                        Button("Apricot", "@paint_235"),
                        Button("Hot Pink", "@paint_236"),
                        Button("Meldeceit Yellow", "@paint_239"),
                        Button("Coral", "@paint_240"),
                        Button("Salmon", "@paint_241"),
                        Button("Prill Pink", "@paint_242"),
                        Button("Plum Pink", "@paint_243"),
                        Button("Imperial Yellow", "@paint_244"),
                        Button("Canaria Yellow", "@paint_245"),
                        Button("Xanthe Yellow", "@paint_246"),
                        Button("Palarua Yellow", "@paint_247"),
                        Button("Misty Rose", "@paint_248"),
                        Button("Chroma Yellow", "@paint_250"),
                        Button("Hatchling Yellow", "@paint_253")

                        ));
                }
                break;

            case "@changeface":
                {

                    if (Player.IsMale)
                    {
                        Msg("What face do you want?", List("Choose Face", 10,

                        Button("Lelach Face", "@setface_6912"),
                        Button("Voight Face", "@setface_4910"),
                        Button("Kousai Face", "@setface_4911"),
                        Button("Waboka Face", "@setface_4912"),
                        Button("Shakespeare Face", "@setface_4926"),
                        Button("Claudius Face", "@setface_4927")

                         ));
                    }
                    else if (Player.IsFemale)
                    {
                        Msg("What face do you want?", List("Choose Face", 10,

                        Button("Kusina Face", "@setface_3910"),
                        Button("Gertrude Face", "@setface_3919"),
                        Button("Aisling Face", "@setface_3920"),
                        Button("Portia Face", "@setface_3921"),
                        Button("Eirawen Face", "@setface_3923"),
                        Button("Hatsune Miku Face", "@setface_3926"),
                        Button("Cessair Heart Face", "@setface_3927")
                         ));

                    }




                }
                break;

            case "@changeeyes":
                {

                        Msg("What eyes do you want?", List("Choose Eyes", 10,

                        Button("Clear Eyes", "@eyes_0"),
						Button("Curious Look", "@eyes_1"),
						Button("Affectionate Look", "@eyes_2"),
						Button("Innocent Eyes", "@eyes_3"),
						Button("Sad Eyes", "@eyes_4"),
						Button("Mystic Eyes", "@eyes_5"),
						Button("Mischievous Eyes", "@eyes_6"),
						Button("Fox Eyes", "@eyes_7"),
						Button("Sleepy-as-always Look", "@eyes_8"),
						Button("Serious Look", "@eyes_9"),
						Button("Lovely Eyes", "@eyes_10"),
						Button("Empty Eyes", "@eyes_11"),
						Button("Adventurers Eyes", "@eyes_12"),
						Button("Intellectual Look", "@eyes_13"),
						Button("Cold Eyes", "@eyes_14"),
						Button("Innocent and Pure Look", "@eyes_15"),
						Button("Off-the-Guard Look", "@eyes_16"),
						Button("Too-solemn Look", "@eyes_17"),
						Button("Languid Look", "@eyes_18"),
						Button("Too-righteous Look", "@eyes_19"),
						Button("Serious Rascal Look", "@eyes_20"),
						Button("Fierce Look", "@eyes_21"),
						Button("Foreign Look", "@eyes_22"),
						Button("Sharp Look", "@eyes_23")
                       
                      

                         ));

                }
                break;

            case "@changemouth":
                {

                        Msg("What mouth do you want?", List("Choose Mouth", 10,

                        Button("Plain Lips", "@mouth_0"),
						Button("Always Smiling", "@mouth_1"),
						Button("Small Lips", "@mouth_2"),
						Button("Dumbfounded Look", "@mouth_3"),
						Button("Serious Lips", "@mouth_4"),
						Button("Fang", "@mouth_5"),
						Button("Kitty Lips", "@mouth_6"),
						Button("Rabbit Incisor", "@mouth_7"),
						Button("Grouchy Lips", "@mouth_8"),
						Button("Pouting Lips", "@mouth_9"),
						Button("Prankster Lips", "@mouth_10"),
						Button("Troubled Lips", "@mouth_11"),
						Button("Ordinary Lips", "@mouth_12"),
						Button("Smiling Lips", "@mouth_13"),
						Button("Small Mouth", "@mouth_14"),
						Button("Innocent Lips", "@mouth_15"),
						Button("Happy Lips", "@mouth_16"),
						Button("Seductive Lips", "@mouth_17"),
						Button("Boyish Lips", "@mouth_18"),
						Button("Curious Lips", "@mouth_19")
                      
                         ));

                }
                break;

            default:
                {
                    Msg("Don't want to change your face? That's okay.");
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


                    if (selection.IndexOf("@setface_") != -1)
                    {
                        string facetype = selection.Replace("@setface_", "");
                        Msg("Well, Do you like your new face?", Button("Yes", "@yes"), Button("No. Let me pick something else", "@no"));

                        Item currface = Player.Inventory.GetItemAt(Pocket.Face, 1, 1);
                        currface.Info.Id = Convert.ToInt32(facetype);
                        Send.EquipmentChanged(Player, currface);

                        var n = await Select();
                        switch (n)
                        {
                            case "@yes":
                                Msg("Okay, Then have fun with your new face!");
                                return;
                                break;

                            case "@no":
                                Item revertface = Player.Inventory.GetItemAt(Pocket.Face, 1, 1);
                                revertface.Info.Id = oldface;
                                Send.EquipmentChanged(Player, revertface);
                                goto L_Selection;
                                break;

                        }

                    }
             
                    else if (selection.IndexOf("@paint_") != -1)
                    {
                        string facecolorstring = selection.Replace("@paint_", "");

                        Msg("Well, Do you like your new eye colour?", Button("Yes", "@yes"), Button("No. Let me pick something else", "@no"));


                        Player.EyeColor = Convert.ToByte(facecolorstring);
                        Send.ChannelCharacterInfoRequestR(Player.Client, Player);
                        Send.EntityDisappears(Player);
                        Send.EntityAppears(Player);

                        var n = await Select();
                        switch (n)
                        {
                            case "@yes":
                                Msg("Okay, Then have fun with your new eye colour!");
                                return;
                                break;

                            case "@no":
                                Player.EyeColor = oldeyecolor;
                                Send.ChannelCharacterInfoRequestR(Player.Client, Player);
                                Send.EntityDisappears(Player);
                                Send.EntityAppears(Player);

                                goto L_Selection;
                                break;

                        }
                    }
                    else if (selection.IndexOf("@eyes_") != -1)
                    {
                        string eyestring = selection.Replace("@eyes_", "");

                        Msg("Well, Do you like your new eyes?", Button("Yes", "@yes"), Button("No. Let me pick something else", "@no"));


                        Player.EyeType = Convert.ToInt16(eyestring);
                        Send.ChannelCharacterInfoRequestR(Player.Client, Player);
                        Send.EntityDisappears(Player);
                        Send.EntityAppears(Player);

                        var n = await Select();
                        switch (n)
                        {
                            case "@yes":
                                Msg("Okay, Then have fun with your new eyes!");
                                return;
                                break;

                            case "@no":
                                Player.EyeType = oldeye;
                                Send.ChannelCharacterInfoRequestR(Player.Client, Player);
                                Send.EntityDisappears(Player);
                                Send.EntityAppears(Player);

                                goto L_Selection;
                                break;

                        }
                    }
                    else if (selection.IndexOf("@mouth_") != -1)
                    {
                        string mouthstring = selection.Replace("@mouth_", "");

                        Msg("Well, Do you like your new mouth?", Button("Yes", "@yes"), Button("No. Let me pick something else", "@no"));


                        Player.MouthType = Convert.ToByte(mouthstring);
                        Send.ChannelCharacterInfoRequestR(Player.Client, Player);
                        Send.EntityDisappears(Player);
                        Send.EntityAppears(Player);

                        var n = await Select();
                        switch (n)
                        {
                            case "@yes":
                                Msg("Okay, Then have fun with your mouth!");
                                return;
                                break;

                            case "@no":
                                Player.MouthType = oldmouth;
                                Send.ChannelCharacterInfoRequestR(Player.Client, Player);
                                Send.EntityDisappears(Player);
                                Send.EntityAppears(Player);

                                goto L_Selection;
                                break;

                        }
                    }
                    else
                    {
                        Msg("There was an error.");
                        return;
                    }



                }
                break;
        }
    }
}
