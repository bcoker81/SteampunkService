using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SteampunkService.Models
{
    public class CombatResponse
    {
        public Character Player { get; set; }
        public Character Npc { get; set; }

    }
}