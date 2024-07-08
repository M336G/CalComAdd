using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalComAdd.Content.Items;
using static CalamityMod.CalamityUtils;

namespace CalModAdd.Content.NPCs
{
	public class CalModAddGlobalNPC : GlobalNPC
	{
		public override void ModifyShop(NPCShop shop)
        {
			if (shop.NpcType == NPCID.Dryad)
            {
                shop.AddWithCustomValue(ModContent.ItemType<Turnip>(), Item.buyPrice(silver: 5), Condition.DownedQueenBee);
            }
				return;
		}
    }
}