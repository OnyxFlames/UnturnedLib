using System;
using System.Collections.Generic;
using System.Text;

namespace UnturnedLib.Weapon
{
    public class Weapon : InventoryItem
    {
        public WeaponType WeaponType { get; set; }
        public Rarity Rarity { get; set; }
        // is item able to be secondary?
        public bool Secondary { get; set; }
        // range in meters
        public short Range { get; set; }
    }
}
