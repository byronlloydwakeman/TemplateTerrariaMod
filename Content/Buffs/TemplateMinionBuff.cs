using MyFirstMod.Content.Projectiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace MyFirstMod.Content.Buffs
{
    internal class TemplateMinionBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            // If the player has the minion already selected
            if (player.ownedProjectileCounts[ModContent.ProjectileType<TemplateMinion>()] > 0)
            {
                player.buffTime[buffIndex] = 18000;
                return;
            }

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}
