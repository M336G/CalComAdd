using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using CalamityMod.Items;

namespace CalComAdd.Content.Items.Weapons
{
	public class ShadowEdge : ModItem
	{
        public override void SetStaticDefaults()
        {
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 16));
        }
		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;
            Item.scale = 1.1f;

			Item.damage = 45;
			Item.crit = 7;
			Item.knockBack = 6f;

			Item.DamageType = DamageClass.Melee;

            Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 30;
			Item.useAnimation = 30;
			
			Item.shoot = ProjectileID.LightsBane;
            Item.shootSpeed = 30f;

			Item.value = CalamityGlobalItem.RarityOrangeBuyPrice;
			Item.rare = ItemRarityID.Orange;

			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<Shadowflare>(), 1);
			recipe.AddIngredient(ItemID.BladeofGrass, 1);
			recipe.AddIngredient(ItemID.Muramasa, 1);
            recipe.AddIngredient(ItemID.FieryGreatsword, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.Register();
		}
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Projectile.NewProjectile(source, position, velocity * 1.2f, type, damage, knockback, player.whoAmI, player.GetAdjustedItemScale(Item) * 1.5f);
            return false;
        }
	}
}