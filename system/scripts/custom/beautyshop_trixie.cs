using System.Globalization;

public class TrixieScript : NpcScript
{
    public override void Load()
    {
        SetName("_<mini>NPC</mini> Trixie");
        SetRace(10001);
        SetBody(height: 0.14f);
        SetFace(skinColor: 18, eyeType:7, eyeColor: 27, mouthType: 48);
        SetStand("chapter4/human/anim/female_anohana_menma_stand.ani");
        SetLocation(60209, 1285, 1662, 192);
        EquipItem(Pocket.Hair, 3160, 0x10000025, 0, 0);
        EquipItem(Pocket.Face, 3908, 18, 0, 0);
        EquipItem(Pocket.Armor, 15877, 0xFFFFFF, 0x000000, 0xFFFFFF);
        EquipItem(Pocket.Shoe, 17939, 0xFFFFFF);

        AddPhrase("I love it here!");
        AddPhrase("Should I ask my boss to cut my hair?");

    }

    protected override async Task Talk()
    {

        await Intro(
            "A young small child stands before you.",
			"She seems very happy here, waiting for any customers to come in.",
			"She smiles as she greets you."
        );

    L_Selection:
        Msg("Do you want me to take you back to Minty?", Button("Yes", "@yes"), Button("No", "@no"));

        var r = await Select();
        switch (r)
        {
			case "@yes":
			Msg("Please come again!", Button("Okay!"));
				await Select();
				Player.Warp(1, 12781, 38394);
				Close();
			break;
			
			case "@no":
			Close();
			break;
			
			default:
			Msg("...");
			return;
			break;
        }
    }
}
