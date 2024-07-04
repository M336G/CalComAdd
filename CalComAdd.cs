using Terraria.ModLoader;
namespace CalComAdd
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class CalComAdd : Mod
	{
		internal static Mod CalamityMod;
        public override void Load()
        {
            CalamityMod = ModLoader.GetMod("CalamityMod");
        }

        public override void Unload()
        {
            CalamityMod = null;
        }
    }
}