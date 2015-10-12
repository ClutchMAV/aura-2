using System.Globalization;

public class TanJessica : NpcScript
{
    public override void Load()
    {
        SetName("_<mini>SKIN</mini> Jessica");
        SetRace(10001);
        SetBody(height: 1f);
        SetFace(skinColor: 25, eyeType: 7, eyeColor: 27, mouthType: 48);
        SetStand("chapter4/human/anim/female_alchemists_stand_friendly.ani");
        SetLocation(60209, 1763, 1945, 162);
        EquipItem(Pocket.Hair, 7023, 0xF0DC82, 0, 0);
        EquipItem(Pocket.Face, 3908, 18, 0, 0);
        EquipItem(Pocket.Armor, 15255, 0xFFFFFF, 0x000000, 0xFFFFFF);
        EquipItem(Pocket.Shoe, 17054,0xFFFFFF, 0x000000, 0xFFFFFF);

        AddPhrase("You look a bit pale.");
        AddPhrase("Try my new Bronzer-3000!");
        AddPhrase("True beauty lies in one's skin");

    }

    protected override async Task Talk()
    {

        byte oldskincolor = Player.SkinColor;


        await Intro(
            "An Tanned girl stands before you.",
            "She offers to change your skin colour for you by using her magical tanning bed.",
            "She stands firmly as she waits for you to answer."
        );

    L_Selection:
        Msg("Want to change your skin color?", List("What would you like me to do?", 10, Button("Change Skin Color", "@changeskin")));

        var r = await Select();
        switch (r)
        {
            case "@changeskin":
                {
                    Msg("What skin colour?", List("Choose Colour", 10,
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

           
            default:
                {
                    Msg("Don't want to change your skin color? That's okay.");
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
                        string skincolorstring = selection.Replace("@paint_", "");

                        Msg("Well, Do you like your new skin colour?", Button("Yes", "@yes"), Button("No. Let me pick something else", "@no"));


                        Player.SkinColor = Convert.ToByte(skincolorstring);
                        Send.ChannelCharacterInfoRequestR(Player.Client, Player);
                        Send.EntityDisappears(Player);
                        Send.EntityAppears(Player);

                        var n = await Select();
                        switch (n)
                        {
                            case "@yes":
                                Msg("Okay, Then have fun with your new skin colour!");
                                return;
                                break;

                            case "@no":
                                Player.SkinColor = oldskincolor;
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
