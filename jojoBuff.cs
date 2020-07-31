using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace catSummonMod.Items
{
	public class jojoBuff : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Jojo the flying cat.");
			Description.SetDefault("That's a silly question, why does anyone have wings?");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			if (player.ownedProjectileCounts[ProjectileType<jojoCat>()] > 0) {
				player.buffTime[buffIndex] = 18000;
			} else {
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
	}
}