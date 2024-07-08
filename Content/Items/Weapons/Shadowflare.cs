using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using CalamityMod.Items;

namespace CalComAdd.Content.Items.Weapons
{
	public class Shadowflare : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;
            Item.scale = 1.1f;

			Item.damage = 19;
			Item.crit = 7;
			Item.knockBack = 6f;

			Item.DamageType = DamageClass.Melee;

            Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 30;
			Item.useAnimation = 30;
			
			Item.shoot = ProjectileID.LightsBane;
            Item.shootSpeed = 30f;

			Item.value = CalamityGlobalItem.RarityBlueBuyPrice;
			Item.rare = ItemRarityID.Blue;

			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DemoniteBar, 10);
			recipe.AddIngredient(ItemID.ShadowScale, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Projectile.NewProjectile(source, position, velocity, type, damage, knockback, player.whoAmI, player.GetAdjustedItemScale(Item));
            return false;
        }
	}
}