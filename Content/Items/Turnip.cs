using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityMod.Items;
using static CalamityMod.CalamityUtils;

namespace CalComAdd.Content.Items
{
	public class Turnip : ModItem
	{
		public override void SetDefaults()
		{
                  Item.width = 52;
                  Item.height = 38;

                  Item.useTurn = true;

                  Item.maxStack = 9999;

                  Item.useAnimation = 17;
                  Item.useTime = 17;

                  Item.useStyle = ItemUseStyleID.EatFood;
                  Item.UseSound = SoundID.Item2;

                  Item.consumable = true;

                  Item.value = Item.sellPrice(silver: 5);
                  Item.rare = ItemRarityID.Blue;

                  Item.buffType = BuffID.WellFed;
                  Item.buffTime = SecondsToFrames(60f);
		}
	}
}