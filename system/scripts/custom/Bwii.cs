//--- Aura Script -----------------------------------------------------------
// Brii
//--- Description -----------------------------------------------------------
// 
//---------------------------------------------------------------------------

public class BriiBaseScript : NpcScript
{
	const long WindmillPropId = 0xA000010009042B;
	
	static bool WindmillActive { get; set; }
	
	static Prop _windmillProp = null;
	Prop WindmillProp { get { return _windmillProp ?? (_windmillProp = NPC.Region.GetProp(WindmillPropId)); } }
	
	public override void Load()
	{
		SetName("Valkyr");
        SetRace(10001);
		SetBody(height: 0.7f, weight: 1.0f, upper: 1.0f, lower: 1.0f);
		SetFace(skinColor: 18, eyeType: 7, eyeColor: 8, mouthType: 53);
		SetLocation(1, 10852, 39135, 224);

        EquipItem(Pocket.Face, 3900, 0x00596131, 0x00FFEEC6, 0x006F0017);
        EquipItem(Pocket.Hair, 3022, 0x1000fefe, 0x00D57527, 0x00D57527);
        EquipItem(Pocket.Armor, 15891, 0x40000009, 0x10000000, 0x10000000);
        EquipItem(Pocket.Shoe, 17143, 0x10000000, 0x40000009, 0x1000000F);
        EquipItem(Pocket.Head, 18429, 0x10000000, 0x60000E0F, 0x0000000F);
        EquipItem(Pocket.Robe, 220105, 0x10000000, 0x10000000, 0x10000000);
        EquipItem(Pocket.Glove, 16188, 0x10000000, 0x10000015, 0x1000000F);

		AddPhrase("Omg NO STOP.");
		AddPhrase("STOP OMG.");
		AddPhrase("La la la la.");
		AddPhrase("Gdfo.");
		AddPhrase("OMG!");
		AddPhrase("NO DP NO.");
		AddPhrase(";-;.");
		AddPhrase("Brb kms.");
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

public class BriiShop : NpcShopScript
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