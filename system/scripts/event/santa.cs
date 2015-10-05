//--- Aura Script -----------------------------------------------------------
// Ferghus, the blacksmith of Tir Chonaill
//--- Description -----------------------------------------------------------
// Weapon Breaker
//---------------------------------------------------------------------------

public class SantaFerghusBaseScript : NpcScript
{
	public override void Load()
	{
		SetName("Santa's Secret Helper");
		SetRace(10002);
		SetBody(height: 1.1f, upper: 1.4f, lower: 1.1f);
		SetFace(skinColor: 23, eyeType: 3, eyeColor: 112, mouthType: 4);
		SetStand("chapter4/human/anim/social_motion/male_2013_xmas");
		SetLocation(1, 13549, 38399, 125);
		
		SetPortrait("ferghus");
		
		EquipItem(Pocket.Face, 4950, 0x00C6C561, 0x00E1C210, 0x00E8A14A);
		EquipItem(Pocket.Hair, 4153, 0x002E303F, 0x002E303F, 0x002E303F);
		EquipItem(Pocket.Armor, 13158, 0x666666, 0x666666, 0x666666);
		AddPhrase("Jingle Bells, Jingle bells!");
		AddPhrase("Look at the bells, Look at the bells, Holy crap there comes jesus, and he doesn't look so happy!");
		AddPhrase("Spread the christmas spririt!");
	}
	
	protected override async Task Talk()
	{
		SetBgm("cat_event.mp3");
		
		await Intro(
			"Greetings " + Player.Name + "!",
			"It's that time of the year again, and because santa is always so busy, I decided to help him out!",
			"I'm spreading the love with free repair coupons at my blacksmith shop!"
		);
		
		Msg("What can I do to brighten your day?", Button("Start a Conversation", "@talk"), Button("Shop", "@shop"));
		
		switch (await Select())
		{
			case "@talk":
				Msg("What do you want to talk about?");
				await StartConversation();
				break;
				
			case "@shop":
				Msg("Looking for some christmas spirit to spread?<br/>Or are you just hungry?");
				OpenShop("SantaFerghusShop");
				break;
			default:
				Msg("...");
				break;
		}
	}

	protected override async Task Keywords(string keyword)
	{
		switch (keyword)
		{
			default:
				RndMsg(
					"What, you have a present for me?",
					"Oh, they always decorate so nicely during christmas!",
					"I love you too!"
				);
				break;
		}
	}
}

public class SantaFerghusShop : NpcShopScript
{
	public override void Setup()
	{
		Add("Food", 50026);       //Holiday Cake
		Add("Food", 50207);		  //Mystic Turkey
		Add("Food", 50427);		  //Apple Pie
	}
}
