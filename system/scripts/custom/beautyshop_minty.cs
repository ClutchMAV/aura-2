using System.Globalization;

public class MintyScript : NpcScript
{
    public override void Load()
    {
		SetName("_<mini>NPC</mini> Minty");
        SetRace(10001);
        SetBody(height: 0.14f);
        SetFace(skinColor: 18, eyeType:7, eyeColor: 27, mouthType: 48);
        SetStand("chapter4/human/anim/female_anohana_menma_stand.ani");
        SetLocation(1, 13192, 38035, 99);
        EquipItem(Pocket.Hair, 7023, 0x10000025, 0, 0);
        EquipItem(Pocket.Face, 3908, 18, 0, 0);
        EquipItem(Pocket.Armor, 15877, 0xFFFFFF, 0x000000, 0xFFFFFF);
        EquipItem(Pocket.Shoe, 17939, 0xFFFFFF);

        AddPhrase("Would you like to go to the cosmetics shop?");
        AddPhrase("Please visit our shop!");

    }

    protected override async Task Talk()
    {

        await Intro(
            "A young small child stands before you.",
			"She seems very happy here, waiting for any customers to take to the cosmetics shop.",
			"She smiles as she greets you."
        );

    L_Selection:
        Msg("Hey! Would you like to go to our cosmetics shop?", Button("Yes", "@yes"), Button("No", "@no"));
        var r = await Select();
        switch (r)
        {
			case "@yes":
			Msg(Hide.Name, "She allows you on a magical carriage that will lead to the cosmetics shop.", Button("Mount"));
				await Select();
				Player.Warp(60209, 1307, 1583);
				Close();
			break;
			
			case "@no":
			Msg("Okay, I hope you will visit us another time then!");
			return;
			break;
			
			default:
			Msg("...");
			return;
			break;
        }
    }
}