//--- Aura Script -----------------------------------------------------------
// Alissa, the windmill operator in Tir Chonaill
//--- Description -----------------------------------------------------------
// 
//---------------------------------------------------------------------------

public class KrisKrosBaseScript : NpcScript
{
	const long WindmillPropId = 0xA000010009042B;
	
	static bool WindmillActive { get; set; }
	
	static Prop _windmillProp = null;
	Prop WindmillProp { get { return _windmillProp ?? (_windmillProp = NPC.Region.GetProp(WindmillPropId)); } }
	
	public override void Load()
	{
		SetName("Kris Kros");
        SetRace(10001);
		SetBody(height: 0.1f, weight: 1.0f, upper: 1.0f, lower: 1.0f);
		SetFace(skinColor: 18, eyeType: 27, eyeColor: 8, mouthType: 2);
		SetLocation(1, 11332, 39370, 224);

        EquipItem(Pocket.Face, 3948, 0x00596131, 0x00FFEEC6, 0x006F0017);
        EquipItem(Pocket.Hair, 3022, 0x1000fefe, 0x00D57527, 0x00D57527);
        EquipItem(Pocket.Armor, 15795, 0x10000e0e, 0x1000000F, 0x1000000F);
        EquipItem(Pocket.Shoe, 17267, 0x1000000F, 0x60000E0F, 0x1000000F);
        EquipItem(Pocket.Head, 18266, 0x1000000F, 0x60000E0F, 0x0000000F);
        EquipItem(Pocket.Robe, 19138, 0x1000000F, 0x60000E0F, 0x60000E0F);
        EquipItem(Pocket.Glove, 16188, 0x1000000F, 0x10000015, 0x1000000F);

		AddPhrase("Hmm... Steven crashed the server again.");
		AddPhrase("How in hells name...?");
		AddPhrase("La la la la.");
		AddPhrase("Gdfo.");
		AddPhrase("OMG!");
		AddPhrase("o uo.");
		AddPhrase("Meow.");
		AddPhrase("Lets kill Sabbyprahh!");
	}

	protected override async Task Talk()
	{
		SetBgm("NPC_Alissa.mp3");

		await Intro(
			"The fuck do you want, I ain't got time for this."
		);

		Msg("May I help you?", Button("Start a Conversation", "@talk"), Button("Shop", "@shop"));

		switch (await Select())
		{
			

case "@shop":
				Msg("Only took this job till I sell chacater cards.");
				OpenShop("MomoBagShop");
				return;
				
			case "@upgrade":
				Msg("Are you asking me...to modify your item?<br/>Honestly, I am not sure if I can, but if you still want me to, I'll give it a try.<br/>Please choose an item to modify.");
				Msg("(Unimplemented)");
				switch(await Select())
				{
					case "@end":
						Msg("Do you want me to stop...? Well, then... Next time...");
						break;

					default:
						Msg("...");
						break;
				}
				return;

			default:
				Msg("...");
				return;

				break;
		}
	}
}

public class MomoBagShop : NpcShopScript
{
    public override void Setup()
    {
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        Add("Bags", 2108);		// Bag'
        



    }
}