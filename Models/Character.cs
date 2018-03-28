using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SteampunkService.Models
{
    public enum Role{
        player =1 , npc
    }

    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double MinDamage { get; set; }
        public double MaxDamage { get; set; }
        public int AC { get; set; }
        public int CurrentHealth { get; set; }
        public double MaxHealth { get; set; }
        public int Level { get; set; }
        public string Role { get; set; }
        public int Initiative { get; set; }
    }
}