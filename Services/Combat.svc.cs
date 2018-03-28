using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SteampunkService.Models;

namespace SteampunkService.Services
{
    public class Combat : ICombat
    {
        private static Random initiative = new Random();

        public CombatResponse Attack(CombatResponse expected)
        {
            var player = expected.Player;
            var npc = expected.Npc;

            var damage = initiative.Next((int)player.MinDamage, (int)player.MaxDamage);
            //npc.CurrentHealth = Convert.ToInt32((npc.CurrentHealth - ((damage / (double)100) * npc.AC)));
            npc.CurrentHealth = Convert.ToInt32(npc.CurrentHealth - ((damage / npc.AC)));

            if (npc.CurrentHealth <= 0)
            {
                npc.CurrentHealth = 0;
            }

            return expected;
        }
    }
}
