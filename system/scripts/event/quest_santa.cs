public class SantaQuestScript : QuestScript
{
	public override void Load()
	{
		SetId(9000001);
		SetName("Santa's Helper");
		SetDescription("This may seem like its quite sudden, but could you go assist my helper? \n - Santa -");
		
		AddObjective("talk_santaferghus", "Go to Tir Chonaill and talk to Santa's Secret Helper", 1, 13549, 38399, Talk("Santa's Secret Helper"));
		AddObjective("collect", "Collect 10 Brown Fox Formor Scrolls", 1, 13549, 38399, Collect(71021, 10));
		AddObjective("talk_santaferghus2", "Deliver the scrolls to Santa's Secret Helper", 1, 13549, 38399, Talk("Santa's Secret Helper"));
		
		SetReceive(Receive.Automatically);
		
		AddReward(Exp(1000));
		AddHook("Santa's Secret Helper", "after_intro", TalkSantaHelper);
	}
	
	public async Task<HookResult> TalkSantaHelper(NpcScript npc, params object[] args)
	{
		if(npc.QuestActive(this.Id, "talk_santaferghus"))
		{
			npc.FinishQuest(this.Id, "talk_santaferghus");
			
			npc.Msg("Did santa send you here?");
			npc.Msg(Hide.Name, "(You hand ferghus the letter you received.)");
			npc.Msg("Ah! So santa sent you!<br/>I've run into a little problem you see.. Well.. I've broken the presents I'm supposed to deliver..");
			npc.Msg("...");
			npc.Msg("(You stare at ferghus)");
			npc.Msg("...");
			npc.Msg("Don't judge me!<br/>My hammer just fell on it and it suddently broke...");
			npc.Msg("Anyways, I need some serious cash,<br/>Could you collect Brown Fox Formor Scrolls for me so I can turn them in to buy new presents?<br/>Thanks!");
			
			return HookResult.Break;
		}
		else if(npc.QuestActive(this.Id, "talk_santaferghus2"))
		{
			npc.Msg("Do you have enough scrolls?");
			
			if(npc.Player.Inventory.Count(71021) < 10)
			{
				npc.Msg("You don't have enough, come back when you collect 10 Brown Fox Fomor Scrolls.");
			}
			else
			{
				if(npc.Player.Inventory.Remove(71021, 10))
				{
					npc.FinishQuest(this.Id, "talk_santaferghus2");
					npc.Msg(Hide.Name, "(You hand ferghus the formor scrolls.)");
					npc.Msg("Oh thank you so much!<br/>Now I can save christmas for the Tir Chonaill children!");
					npc.Msg("Here, Take this as a token of my appreciation.");
					
					npc.GiveItem(18387, 0xff0000, 0xffffff, 0xffffff);
					
					if(npc.Player.IsMale)
						npc.GiveItem(15290, 0xff0000, 0xffffff, 0xffffff);
					else
						npc.GiveItem(15291, 0xff0000, 0xffffff, 0xffffff);
						
					npc.GiveItem(18387, 0xff0000, 0xffffff, 0xffffff);
					npc.Msg("(Received a santa outfit and hat.)");
				}
				else
				{
					npc.Msg(Hide.Name, "Something went wrong.");
				}
			}
			
			return HookResult.Break;
		}
		
		return HookResult.Continue;
	}
}
